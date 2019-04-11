// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Address details.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        /// <param name="firstName">First Name.</param>
        /// <param name="lastName">Last Name.</param>
        /// <param name="companyName">Company Name.</param>
        /// <param name="addressLine1">Address Line1.</param>
        /// <param name="addressLine2">Address Line2.</param>
        /// <param name="addressLine3">Address Line3.</param>
        /// <param name="city">Address City.</param>
        /// <param name="region">Address Region.</param>
        /// <param name="country">Country code uses ISO2, 2-digit
        /// format.</param>
        /// <param name="postalCode">Address Postal Code.</param>
        public Address(string firstName = default(string), string lastName = default(string), string companyName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string region = default(string), string country = default(string), string postalCode = default(string))
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets first Name.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last Name.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets company Name.
        /// </summary>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets address Line1.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets address Line2.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets address Line3.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets address City.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets address Region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets country code uses ISO2, 2-digit format.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets address Postal Code.
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

    }
}