//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PickAny_.Logic
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserProfile()
        {
            this.UserProfile1 = new HashSet<UserProfile>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public Nullable<int> CreatedById { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfile1 { get; set; }
        public virtual UserProfile UserProfile2 { get; set; }
    }
}