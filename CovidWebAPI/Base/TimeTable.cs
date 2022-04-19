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
    
    public partial class TimeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeTable()
        {
            this.Appointment = new HashSet<Appointment>();
        }
    
        public long ID { get; set; }
        public int VaccinationPointID { get; set; }
        public int DoctorID { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }

        [JsonIgnore]
        public virtual ICollection<Appointment> Appointment { get; set; }
        [JsonIgnore]
        public virtual Doctor Doctor { get; set; }
        [JsonIgnore]
        public virtual VaccinationPoint VaccinationPoint { get; set; }
    }
}
