//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tema1_Restaurant.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiningTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiningTable()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int TableID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> TableNumber { get; set; }
        public Nullable<int> AvailableSeats { get; set; }
        public Nullable<int> OccupiedSeats { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}