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
    
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            this.TimeTable = new HashSet<TimeTable>();
        }
    
        public int ID { get; set; }
        public int VaccinationPointID { get; set; }
        public string FullName { get; set; }

        [JsonIgnore]
        public virtual VaccinationPoint VaccinationPoint { get; set; }
        [JsonIgnore]
        public virtual ICollection<TimeTable> TimeTable { get; set; }
    }
}