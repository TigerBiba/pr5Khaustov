//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace пр5модули.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Departament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departament()
        {
            this.DrugsInDepartament = new HashSet<DrugsInDepartament>();
            this.Finance = new HashSet<Finance>();
            this.Staff1 = new HashSet<Staff>();
            this.WardInDepartament = new HashSet<WardInDepartament>();
        }
    
        public int ID_departament { get; set; }
        public string name { get; set; }
        public string addres { get; set; }
        public int ID_head_doctor { get; set; }
    
        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrugsInDepartament> DrugsInDepartament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finance> Finance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staff1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WardInDepartament> WardInDepartament { get; set; }
    }
}
