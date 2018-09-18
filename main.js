// Global variables
// token for Saxo API
var token = "";
// array to keep JSON object
var dataArr = [];
// user input of currency pair
var query;
// user input translated into universal instrumental code (uic)
var uicQuery;

// Functions
function prepareQueryAndData() {
    // reading and saving user input
    query = $(".search-text").val();
    // sending AJAX request for data about Instruments
    $.ajax(
        {
            "url": "https://gateway.saxobank.com/sim/openapi/ref/v1/instruments?KeyWords=" + query.slice(0, -3) + "&AssetTypes=FxSpot",
            "method": "GET",
            "dataType": "json",
            "headers": {
                "Authorization": "Bearer " + token,
            }
        })
    // attaching success callback to translate user input into uic and get respective data for the chart
        .done(function (data) {
            $.each(data.Data, function (key, val) {
                var currency = val.Symbol;
                uicQuery = val.Identifier;
                if (currency === query) {
                    return false;
                } else {
                    uicQuery = "";
                }
            });
            getDataForChart();
        })
}

function getDataForChart() {
    // emptying array with JSON object
    dataArr = [];
    // // emptying html element with possible previous query results
    $("#container").empty();
    // sending AJAX request for chart data
    $.ajax(
        {
            "url": "https://gateway.saxobank.com/sim/openapi/chart/v1/charts/?AssetType=FxSpot&Count=1000&Horizon=15&Uic=" + uicQuery,
            "method": "GET",
            "dataType": "json",
            "headers": {
                "Authorization": "Bearer " + token,
            }
        })
        // attaching success callback to preprocess Json data and build Highchart graph
        .done(function (response) {
            $.each(response.Data, function (key, val) {
                var datasample = [new Date(val.Time).getTime(), val.OpenBid, val.HighBid, val.LowBid, val.CloseBid];
                dataArr.push(datasample);
            })
            console.log(dataArr)
            buildChart()
        })
        // attaching error callback in case there is issue with user query or API availability
        .fail(function () {
            console.debug("Currency pair is invalid or the API is down");
            $("#container").append("<h5>Currency pair is invalid or the API is down - please try again.</h5><h6> Hint: Search for currency pair, using 3-digit currency codes (USDDKK, EURSGD, GBPUSD...)</h6>")
        })
}

function buildChart() {
    // highcharts' settings
    var chartSettings = {

        title: {
            text: "Chart for " + query,
        },
        rangeSelector: {
            buttons: [
                {
                    type: "day",
                    count: 1,
                    text: "1D"
                }, {
                    type: "all",
                    count: 1,
                    text: "All"
                }],
            selected: 1,
            inputEnabled: false
        },
        series: [{
            type: "ohlc",
            name: query,
            data: dataArr,
        }]
    }
    Highcharts.stockChart("container", chartSettings);
}

//Event listeners
//button with function for building chart on-click
$(".search-button").click(function () {
    prepareQueryAndData();

});
//button with function for building chart when pressing 'enter'
$(".search-text").keyup(function (e) {
    if (e.keyCode == 13) {
        prepareQueryAndData();
    }
});
