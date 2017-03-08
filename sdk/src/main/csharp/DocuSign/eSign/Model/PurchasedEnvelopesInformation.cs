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
    /// PurchasedEnvelopesInformation
    /// </summary>
    [DataContract]
    public partial class PurchasedEnvelopesInformation :  IEquatable<PurchasedEnvelopesInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasedEnvelopesInformation" /> class.
        /// </summary>
        /// <param name="Amount">The total amount of the purchase..</param>
        /// <param name="AppName">The AppName of the client application..</param>
        /// <param name="CurrencyCode">Specifies the ISO currency code of the purchase. This is based on the ISO 4217 currency code information..</param>
        /// <param name="Platform">The Platform of the client application.</param>
        /// <param name="ProductId">The Product ID from the AppStore..</param>
        /// <param name="Quantity">The quantity of envelopes to add to the account..</param>
        /// <param name="ReceiptData">The encrypted Base64 encoded receipt data..</param>
        /// <param name="StoreName">The name of the AppStore..</param>
        /// <param name="TransactionId">Specifies the Transaction ID from the AppStore..</param>
        public PurchasedEnvelopesInformation(string Amount = default(string), string AppName = default(string), string CurrencyCode = default(string), string Platform = default(string), string ProductId = default(string), string Quantity = default(string), string ReceiptData = default(string), string StoreName = default(string), string TransactionId = default(string))
        {
            this.Amount = Amount;
            this.AppName = AppName;
            this.CurrencyCode = CurrencyCode;
            this.Platform = Platform;
            this.ProductId = ProductId;
            this.Quantity = Quantity;
            this.ReceiptData = ReceiptData;
            this.StoreName = StoreName;
            this.TransactionId = TransactionId;
        }
        
        /// <summary>
        /// The total amount of the purchase.
        /// </summary>
        /// <value>The total amount of the purchase.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }
        /// <summary>
        /// The AppName of the client application.
        /// </summary>
        /// <value>The AppName of the client application.</value>
        [DataMember(Name="appName", EmitDefaultValue=false)]
        public string AppName { get; set; }
        /// <summary>
        /// Specifies the ISO currency code of the purchase. This is based on the ISO 4217 currency code information.
        /// </summary>
        /// <value>Specifies the ISO currency code of the purchase. This is based on the ISO 4217 currency code information.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// The Platform of the client application
        /// </summary>
        /// <value>The Platform of the client application</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }
        /// <summary>
        /// The Product ID from the AppStore.
        /// </summary>
        /// <value>The Product ID from the AppStore.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }
        /// <summary>
        /// The quantity of envelopes to add to the account.
        /// </summary>
        /// <value>The quantity of envelopes to add to the account.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }
        /// <summary>
        /// The encrypted Base64 encoded receipt data.
        /// </summary>
        /// <value>The encrypted Base64 encoded receipt data.</value>
        [DataMember(Name="receiptData", EmitDefaultValue=false)]
        public string ReceiptData { get; set; }
        /// <summary>
        /// The name of the AppStore.
        /// </summary>
        /// <value>The name of the AppStore.</value>
        [DataMember(Name="storeName", EmitDefaultValue=false)]
        public string StoreName { get; set; }
        /// <summary>
        /// Specifies the Transaction ID from the AppStore.
        /// </summary>
        /// <value>Specifies the Transaction ID from the AppStore.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchasedEnvelopesInformation {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReceiptData: ").Append(ReceiptData).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(obj as PurchasedEnvelopesInformation);
        }

        /// <summary>
        /// Returns true if PurchasedEnvelopesInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PurchasedEnvelopesInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchasedEnvelopesInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.AppName == other.AppName ||
                    this.AppName != null &&
                    this.AppName.Equals(other.AppName)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.ReceiptData == other.ReceiptData ||
                    this.ReceiptData != null &&
                    this.ReceiptData.Equals(other.ReceiptData)
                ) && 
                (
                    this.StoreName == other.StoreName ||
                    this.StoreName != null &&
                    this.StoreName.Equals(other.StoreName)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.AppName != null)
                    hash = hash * 59 + this.AppName.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.ReceiptData != null)
                    hash = hash * 59 + this.ReceiptData.GetHashCode();
                if (this.StoreName != null)
                    hash = hash * 59 + this.StoreName.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
