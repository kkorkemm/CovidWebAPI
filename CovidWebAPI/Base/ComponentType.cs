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
    
    public partial class ComponentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComponentType()
        {
            this.Appointment = new HashSet<Appointment>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}
