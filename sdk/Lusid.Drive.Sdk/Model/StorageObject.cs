/*
 * FINBOURNE Drive API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.635
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Drive.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Drive.Sdk.Model
{
    /// <summary>
    /// An object representation of a drive file or folder
    /// </summary>
    [DataContract(Name = "StorageObject")]
    public partial class StorageObject : IEquatable<StorageObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObject" /> class.
        /// </summary>
        /// <param name="id">File or folder identifier (required).</param>
        /// <param name="path">Path of the folder or file (required).</param>
        /// <param name="name">Name of the folder or file (required).</param>
        /// <param name="createdBy">Identifier of the user who created the file or folder (required).</param>
        /// <param name="createdOn">Date of file/folder creation (required).</param>
        /// <param name="updatedBy">Identifier of the last user to modify the file or folder (required).</param>
        /// <param name="updatedOn">Date of file/folder modification (required).</param>
        /// <param name="type">Type of storage object (file or folder) (required).</param>
        /// <param name="size">Size of the file in bytes.</param>
        /// <param name="status">File status corresponding to virus scan status.  (Active, Available, Checking, MalwareDetected, Failed).</param>
        /// <param name="statusDetail">Detailed description describing any negative terminal state of file.</param>
        /// <param name="links">links.</param>
        public StorageObject(string id = default(string), string path = default(string), string name = default(string), string createdBy = default(string), DateTimeOffset createdOn = default(DateTimeOffset), string updatedBy = default(string), DateTimeOffset updatedOn = default(DateTimeOffset), string type = default(string), int? size = default(int?), string status = default(string), string statusDetail = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for StorageObject and cannot be null");
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for StorageObject and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for StorageObject and cannot be null");
            // to ensure "createdBy" is required (not null)
            this.CreatedBy = createdBy ?? throw new ArgumentNullException("createdBy is a required property for StorageObject and cannot be null");
            this.CreatedOn = createdOn;
            // to ensure "updatedBy" is required (not null)
            this.UpdatedBy = updatedBy ?? throw new ArgumentNullException("updatedBy is a required property for StorageObject and cannot be null");
            this.UpdatedOn = updatedOn;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StorageObject and cannot be null");
            this.Size = size;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.Links = links;
        }

        /// <summary>
        /// File or folder identifier
        /// </summary>
        /// <value>File or folder identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Path of the folder or file
        /// </summary>
        /// <value>Path of the folder or file</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Name of the folder or file
        /// </summary>
        /// <value>Name of the folder or file</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Identifier of the user who created the file or folder
        /// </summary>
        /// <value>Identifier of the user who created the file or folder</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date of file/folder creation
        /// </summary>
        /// <value>Date of file/folder creation</value>
        [DataMember(Name = "createdOn", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// Identifier of the last user to modify the file or folder
        /// </summary>
        /// <value>Identifier of the last user to modify the file or folder</value>
        [DataMember(Name = "updatedBy", IsRequired = true, EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Date of file/folder modification
        /// </summary>
        /// <value>Date of file/folder modification</value>
        [DataMember(Name = "updatedOn", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset UpdatedOn { get; set; }

        /// <summary>
        /// Type of storage object (file or folder)
        /// </summary>
        /// <value>Type of storage object (file or folder)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        /// <value>Size of the file in bytes</value>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public int? Size { get; set; }

        /// <summary>
        /// File status corresponding to virus scan status.  (Active, Available, Checking, MalwareDetected, Failed)
        /// </summary>
        /// <value>File status corresponding to virus scan status.  (Active, Available, Checking, MalwareDetected, Failed)</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Detailed description describing any negative terminal state of file
        /// </summary>
        /// <value>Detailed description describing any negative terminal state of file</value>
        [DataMember(Name = "statusDetail", EmitDefaultValue = true)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDetail: ").Append(StatusDetail).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageObject);
        }

        /// <summary>
        /// Returns true if StorageObject instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDetail == input.StatusDetail ||
                    (this.StatusDetail != null &&
                    this.StatusDetail.Equals(input.StatusDetail))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDetail != null)
                    hashCode = hashCode * 59 + this.StatusDetail.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
