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
    
    public partial class exif_data
    {
        public int exif_id { get; set; }
        public int photo_id { get; set; }
        public string camera { get; set; }
        public string aperture { get; set; }
        public string shutter_speed { get; set; }
        public string iso { get; set; }
        public string date_taken { get; set; }
        public string focal_length { get; set; }
    
        public virtual photo photo { get; set; }
    }
}