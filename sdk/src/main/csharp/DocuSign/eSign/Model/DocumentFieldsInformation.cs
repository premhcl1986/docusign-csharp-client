/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DocumentFieldsInformation
    /// </summary>
    [DataContract]
    public partial class DocumentFieldsInformation :  IEquatable<DocumentFieldsInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFieldsInformation" /> class.
        /// </summary>
        /// <param name="DocumentFields">The array of name/value custom data strings to be added to a document. Custom document field information is returned in the status, but otherwise is not used by DocuSign. The array contains the elements:   * name – A string that can be a maximum of 50 characters.  * value – A string that can be a maximum of 200 characters.  *IMPORTANT*: If you are using xml, the name/value pair is contained in a nameValue element.  .</param>
        public DocumentFieldsInformation(List<NameValue> DocumentFields = default(List<NameValue>))
        {
            this.DocumentFields = DocumentFields;
        }
        
        /// <summary>
        /// The array of name/value custom data strings to be added to a document. Custom document field information is returned in the status, but otherwise is not used by DocuSign. The array contains the elements:   * name – A string that can be a maximum of 50 characters.  * value – A string that can be a maximum of 200 characters.  *IMPORTANT*: If you are using xml, the name/value pair is contained in a nameValue element.  
        /// </summary>
        /// <value>The array of name/value custom data strings to be added to a document. Custom document field information is returned in the status, but otherwise is not used by DocuSign. The array contains the elements:   * name – A string that can be a maximum of 50 characters.  * value – A string that can be a maximum of 200 characters.  *IMPORTANT*: If you are using xml, the name/value pair is contained in a nameValue element.  </value>
        [DataMember(Name="documentFields", EmitDefaultValue=false)]
        public List<NameValue> DocumentFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentFieldsInformation {\n");
            sb.Append("  DocumentFields: ").Append(DocumentFields).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DocumentFieldsInformation);
        }

        /// <summary>
        /// Returns true if DocumentFieldsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentFieldsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentFieldsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentFields == other.DocumentFields ||
                    this.DocumentFields != null &&
                    this.DocumentFields.SequenceEqual(other.DocumentFields)
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
                if (this.DocumentFields != null)
                    hash = hash * 59 + this.DocumentFields.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
