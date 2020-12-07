/* 
 * FINBOURNE Drive API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.149
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Drive.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Drive.Sdk.Model
{
    /// <summary>
    /// ResourceListOfAccessControlledResource
    /// </summary>
    [DataContract]
    public partial class ResourceListOfAccessControlledResource :  IEquatable<ResourceListOfAccessControlledResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceListOfAccessControlledResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceListOfAccessControlledResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceListOfAccessControlledResource" /> class.
        /// </summary>
        /// <param name="values">values (required).</param>
        /// <param name="href">href.</param>
        /// <param name="links">links.</param>
        public ResourceListOfAccessControlledResource(List<AccessControlledResource> values = default(List<AccessControlledResource>), string href = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for ResourceListOfAccessControlledResource and cannot be null");
            }
            else
            {
                this.Values = values;
            }
            
            this.Href = href;
            this.Links = links;
            this.Href = href;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<AccessControlledResource> Values { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceListOfAccessControlledResource {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceListOfAccessControlledResource);
        }

        /// <summary>
        /// Returns true if ResourceListOfAccessControlledResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceListOfAccessControlledResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceListOfAccessControlledResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                int hashCode = 41;
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
