//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD1.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Rols = new HashSet<Rol>();
        }
    
        public int IdUser { get; set; }
        public string Name { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Ingrese un correo válido")]
        public string EmaisAddress { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string Password { get; set; }
        public long CI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rol> Rols { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}
