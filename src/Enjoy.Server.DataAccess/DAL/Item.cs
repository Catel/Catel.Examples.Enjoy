//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enjoy.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.Category = new HashSet<Category>();
            this.Tag = new HashSet<Tag>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public int GroupId { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
