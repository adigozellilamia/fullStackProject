//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Black_friday.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.product_to_sale = new HashSet<product_to_sale>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> group_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> image_id { get; set; }
        public Nullable<double> price { get; set; }
        public string type { get; set; }
        public Nullable<int> description_id { get; set; }
    
        public virtual category category { get; set; }
        public virtual description description { get; set; }
        public virtual group_products group_products { get; set; }
        public virtual image image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_to_sale> product_to_sale { get; set; }
    }
}
