//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _00_AuthorWorkApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Work
    {
        public int WorkId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<int> AuthorId { get; set; }
    
        public virtual Author Author { get; set; }
    }
}
