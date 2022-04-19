using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidWebAPI.Models
{
    using Base;

    public class TimeTableModel
    {
        public TimeTableModel(TimeTable timeTable)
        {
            ID = timeTable.ID;
            Date = timeTable.Date;
            Time = timeTable.Time;
            VaccinationPoint = timeTable.VaccinationPoint.Name;
            DoctorName = timeTable.Doctor.FullName;
        }


        public long ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string VaccinationPoint { get; set; }
        public string DoctorName { get; set; }

    }
}