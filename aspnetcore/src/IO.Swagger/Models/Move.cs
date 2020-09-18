/*
 * TicTacToe API
 *
 * The TicTacToe API is a basic suite of tools bringing TicTacToe gaming functionality to your webpages and apps. In its current version, the TicTacToe API only supports two player matchmaking scenarios - (1) where opponent for your user is assigned authomatically and (2) where your user choses a single player to challenge.
 *
 * OpenAPI spec version: 0.0.2
 * Contact: kseniia.kal@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Move : IEquatable<Move>
    { 
        /// <summary>
        /// Gets or Sets ByPlayer
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ByPlayerEnum
        {
            /// <summary>
            /// Enum PlayerXEnum for playerX
            /// </summary>
            [EnumMember(Value = "playerX")]
            PlayerXEnum = 0,
            /// <summary>
            /// Enum Player0Enum for player0
            /// </summary>
            [EnumMember(Value = "player0")]
            Player0Enum = 1        }

        /// <summary>
        /// Gets or Sets ByPlayer
        /// </summary>
        [Required]
        [DataMember(Name="byPlayer")]
        public ByPlayerEnum? ByPlayer { get; set; }

        /// <summary>
        /// Gets or Sets XCoordinate
        /// </summary>
        [Required]
        [DataMember(Name="xCoordinate")]
        public int? XCoordinate { get; set; }

        /// <summary>
        /// Gets or Sets YCoordinate
        /// </summary>
        [Required]
        [DataMember(Name="yCoordinate")]
        public int? YCoordinate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Move {\n");
            sb.Append("  ByPlayer: ").Append(ByPlayer).Append("\n");
            sb.Append("  XCoordinate: ").Append(XCoordinate).Append("\n");
            sb.Append("  YCoordinate: ").Append(YCoordinate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Move)obj);
        }

        /// <summary>
        /// Returns true if Move instances are equal
        /// </summary>
        /// <param name="other">Instance of Move to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Move other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ByPlayer == other.ByPlayer ||
                    ByPlayer != null &&
                    ByPlayer.Equals(other.ByPlayer)
                ) && 
                (
                    XCoordinate == other.XCoordinate ||
                    XCoordinate != null &&
                    XCoordinate.Equals(other.XCoordinate)
                ) && 
                (
                    YCoordinate == other.YCoordinate ||
                    YCoordinate != null &&
                    YCoordinate.Equals(other.YCoordinate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ByPlayer != null)
                    hashCode = hashCode * 59 + ByPlayer.GetHashCode();
                    if (XCoordinate != null)
                    hashCode = hashCode * 59 + XCoordinate.GetHashCode();
                    if (YCoordinate != null)
                    hashCode = hashCode * 59 + YCoordinate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Move left, Move right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Move left, Move right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}