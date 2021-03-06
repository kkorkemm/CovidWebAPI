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
    
    public partial class VaccinationPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaccinationPoint()
        {
            this.Doctor = new HashSet<Doctor>();
            this.Review = new HashSet<Review>();
            this.TimeTable = new HashSet<TimeTable>();
        }
    
        public int ID { get; set; }
        public byte UserRoleID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkTime { get; set; }
        public string Telephone { get; set; }
        public byte[] Photo { get; set; }

        [JsonIgnore]
        public virtual ICollection<Doctor> Doctor { get; set; }
        [JsonIgnore]
        public virtual ICollection<Review> Review { get; set; }
        [JsonIgnore]
        public virtual ICollection<TimeTable> TimeTable { get; set; }
        [JsonIgnore]
        public virtual UserRole UserRole { get; set; }
    }
}
