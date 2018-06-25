using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAny_.Model.UserProfiles
{
    public class UserProfiles
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
        public string Pass { get; set; }
        public string ActivationCode { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeactive { get; set; }
        public int IndustryId { get; set; }
        public int RoleId { get; set; }
        public bool EmailVerified { get; set; }
    }
}
