//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLSLms
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfileSetting
    {
        public UserProfileSetting()
        {
            this.UserProfileSettingsOrgs = new HashSet<UserProfileSettingsOrg>();
        }
    
        public int ProfileSettingID { get; set; }
        public string ProfileTitle { get; set; }
        public Nullable<byte> ProfileOrder { get; set; }
    
        public virtual ICollection<UserProfileSettingsOrg> UserProfileSettingsOrgs { get; set; }
    }
}
