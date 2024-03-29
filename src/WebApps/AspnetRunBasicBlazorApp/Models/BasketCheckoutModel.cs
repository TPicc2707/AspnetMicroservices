﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRunBasicBlazorApp.Models
{
    public class BasketCheckoutModel
    {
        [Required(ErrorMessage = "Your username is required.")]
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }

        //BillingAddress
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address for shipping updates.")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter your shipping address.")]
        public string AddressLine { get; set; }
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter a valid country.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter a valid state.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Zip code required.")]
        public string ZipCode { get; set; }

        //Payment
        [Required(ErrorMessage = "Name on card is requried.")]
        public string CardName { get; set; }
        [Required(ErrorMessage = "Credit card number is requried.")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Expiration date is requried.")]
        public string Expiration { get; set; }
        [Required(ErrorMessage = "Security code is requried.")]
        [MinLength(3)]
        [MaxLength(3)]
        public string CVV { get; set; }
        public int PaymentMethod { get; set; }


    }
}
