//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoShr.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class follower
    {
        public int id { get; set; }
        public Nullable<int> follower_who { get; set; }
        public Nullable<int> follower_whom { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
