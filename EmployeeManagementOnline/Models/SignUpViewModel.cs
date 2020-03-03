using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagementOnline.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter valid format")]
        public string Name { get; set; }
        [Required(ErrorMessage = "EmailId is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter a valid email address")]
        public string EmailId { get; set; }
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = (@"At least one lower case letter,one upper case letter,one special character,one digits,At least 8 characters length"))]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Gender is required")]
        public string Gender { get; set; }
        public string LanguagesKnown { get; set; }
        [Required(ErrorMessage = "Qualification is required")]

        public string Qualification { get; set; }
        [Required(ErrorMessage = "Address is required")]

        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]

        public string City { get; set; }
        [Required(ErrorMessage = "State is required")]

        public string State { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }
        [Required(ErrorMessage = "Pincode is required")]

        public int PinCode { get; set; }

    }
}