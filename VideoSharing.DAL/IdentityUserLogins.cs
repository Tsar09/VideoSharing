//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoSharing.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class IdentityUserLogins
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ApplicationUser_Id { get; set; }
    
        public virtual ApplicationUsers ApplicationUsers { get; set; }
    }
}
