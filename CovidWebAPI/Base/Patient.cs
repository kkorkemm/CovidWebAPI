//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CovidWebAPI.Base
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Appointment = new HashSet<Appointment>();
            this.Questionnnare = new HashSet<Questionnnare>();
            this.Review = new HashSet<Review>();
        }
    
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Code { get; set; }
        public string Telephone { get; set; }
        public System.DateTime DateOfBirth { get; set; }

        [JsonIgnore]
        public virtual ICollection<Appointment> Appointment { get; set; }
        [JsonIgnore]
        public virtual ICollection<Questionnnare> Questionnnare { get; set; }
        [JsonIgnore]
        public virtual ICollection<Review> Review { get; set; }
    }
}
