﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OsiguSDK.Insurers.Models
{
    public class ExpressAuthorization 
    {
        /// <summary>
        /// Osigu express authorization code
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Provider's name 
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string ProviderName { get; set; }

        /// <summary>
        /// Policy holder information
        /// </summary>
        [JsonProperty(PropertyName = "policy_holder")]
        public PolicyHolderInfo PolicyHolder { get; set; }
        
        /// <summary>
        /// Express authorization status [insurer_pending_review, insurer_approved, insurer_rejected, pending_paid, paid]
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// List of items in the transaction
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public List<ExpressAuthItem> Items { get; set; }
        
        /// <summary>
        /// Information about the invoice document
        /// </summary>
        [JsonProperty(PropertyName = "invoice")]
        public Invoice InvoiceDetails { get; set; }

        /// <summary>
        /// Minimum amount to be purchased in order to be eligible for claim
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public decimal Minimum { get; set; }

        /// <summary>
        /// fixed amount of copayment the insured will need to pay
        /// </summary>
        [JsonProperty(PropertyName = "copayment")]
        public decimal Copayment { get; set; }

        /// <summary>
        ///  Amount calculated of the coinsurance that the insured will need to pay
        /// </summary>
        [JsonProperty(PropertyName = "total_coinsurance")]
        public decimal TotalCoInsurance { get; set; }
        
        /// <summary>
        /// Date and time when the resource was created
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date and time when the resource was last updated
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }


        public class PolicyHolderInfo
        {
            /// <summary>
            /// Policy holder's unique identification code (combination of policy number + policy certificate or carnet number)
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            /// <summary>
            /// Date of birth of the policy holder
            /// </summary>
            [JsonProperty(PropertyName = "date_of_birth")]
            public DateTime DateOfBirth { get; set; }
        }

        public class ExpressAuthItem
        {
            /// <summary>
            /// Insurer's product code
            /// </summary>
            [JsonProperty(PropertyName = "product_id")]
            public string ProductId { get; set; }
         
            /// <summary>
            /// quantity claimed
            /// </summary>
            [JsonProperty(PropertyName = "quantity")]
            public int Quantity { get; set; }

            /// <summary>
            /// product price
            /// </summary>
            [JsonProperty(PropertyName = "price")]
            public decimal Price { get; set; }

            /// <summary>
            /// percentage amount that the insured will need to pay for this product / service
            /// </summary>
            [JsonProperty(PropertyName = "coinsurance_percentage")]
            public decimal CoInsurancePercentage { get; set; }
        }

        public class Invoice
        {
            /// <summary>
            /// Provider's invoice number
            /// </summary>
            [JsonProperty(PropertyName = "document_number")]
            public string DocumentNumber { get; set; }

            /// <summary>
            /// Provider's invoice date
            /// </summary>
            [JsonProperty(PropertyName = "document_date")]
            public DateTime DocumentDate { get; set; }

            /// <summary>
            /// currency code
            /// </summary>
            [JsonProperty(PropertyName = "currency")]
            public string Currency { get; set; }

            /// <summary>
            /// invoice amount
            /// </summary>
            [JsonProperty(PropertyName = "amount")]
            public Decimal Amount { get; set; }
        }
    }


}
