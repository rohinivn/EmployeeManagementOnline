using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementOnline.Entity
{
    public class Account
    {
        [Required(ErrorMessage="Name is required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage="Please enter valid format")]
        public string Name { get; set; }
        [Required(ErrorMessage ="EmailId is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage = "Please enter a valid email address")]
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string LanguagesKnown { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long PhoneNumber { get; set; }
        public int PinCode { get; set; }

        public Account(string name,string email,string password,string gender,string languagesKnown,string qualification,string address,string city,string state,long phoneNumber,int pin)
        {
            Name = name;
            EmailId = email;
            Password = password;
            Gender = gender;
            LanguagesKnown = languagesKnown;
            Qualification = qualification;
            Address = address;
            City = city;
            State = state;
            PhoneNumber = phoneNumber;
            PinCode = pin;
        }
    }
}
