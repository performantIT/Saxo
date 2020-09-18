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
    public partial class PlayerBody : IEquatable<PlayerBody>
    { 
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [Required]
        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerBody {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PlayerBody)obj);
        }

        /// <summary>
        /// Returns true if PlayerBody instances are equal
        /// </summary>
        /// <param name="other">Instance of PlayerBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
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
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PlayerBody left, PlayerBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PlayerBody left, PlayerBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}