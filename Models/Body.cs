/*
 * Swagger Petstore
 *
 * This is a sample server Petstore server.  You can find out more about     Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).      For this sample, you can use the api key `special-key` to test the authorization     filters.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SwaggerDemo.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Body :  IEquatable<Body>
    {
                /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum AvailableEnum for "available"
            /// </summary>
            [EnumMember(Value = "available")]
            AvailableEnum,
            
            /// <summary>
            /// Enum PendingEnum for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            PendingEnum,
            
            /// <summary>
            /// Enum SoldEnum for "sold"
            /// </summary>
            [EnumMember(Value = "sold")]
            SoldEnum
        }
        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="PhotoUrls">PhotoUrls (required).</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Status">pet status in the store.</param>
        public Body(long? Id = default(long?), PetCategory Category = default(PetCategory), string Name = default(string), List<string> PhotoUrls = default(List<string>), List<PetTags> Tags = default(List<PetTags>), StatusEnum? Status = default(StatusEnum?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Body and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "PhotoUrls" is required (not null)
            if (PhotoUrls == null)
            {
                throw new InvalidDataException("PhotoUrls is a required property for Body and cannot be null");
            }
            else
            {
                this.PhotoUrls = PhotoUrls;
            }
            this.Id = Id;
            this.Category = Category;
            this.Tags = Tags;
            this.Status = Status;
            
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category")]
        public PetCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets PhotoUrls
        /// </summary>
        [DataMember(Name="photoUrls")]
        public List<string> PhotoUrls { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags")]
        public List<PetTags> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            if (obj.GetType() != GetType()) return false;
            return Equals((Body)obj);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="other">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PhotoUrls == other.PhotoUrls ||
                    this.PhotoUrls != null &&
                    this.PhotoUrls.SequenceEqual(other.PhotoUrls)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.PhotoUrls != null)
                    hash = hash * 59 + this.PhotoUrls.GetHashCode();
                    if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Body left, Body right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Body left, Body right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
