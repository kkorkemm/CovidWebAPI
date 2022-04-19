using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidWebAPI.Models
{
    using Base;

    public class AppointmentModel
    {

        public AppointmentModel(Appointment appointment)
        {
            ID = appointment.ID;
            TimeTableID = appointment.TimeTableID;
            ComponentTypeID = appointment.ComponentTypeID;
            ComponentType = appointment.ComponentType.Name;
            DoctorName = appointment.TimeTable.Doctor.FullName;
            VaccinationPointName = appointment.TimeTable.VaccinationPoint.Name;
            VaccinationPointID = appointment.TimeTable.VaccinationPointID;
            PatientID = appointment.PatientID;
            IsReceived = appointment.IsReceived;
            Date = appointment.TimeTable.Date;
            Time = appointment.TimeTable.Time;

            if (IsReceived == true)
            {
                Status = "Получен " + Convert.ToDateTime(Date).ToString("dd.MM.yyyy");
                BackColor = "#68D172";
                ForeColor = "#fff";
            }
            else if (IsReceived == false && Date != null)
            {
                Status = "Запись на " + Convert.ToDateTime(Date).ToString("dd.MM.yyyy");
                BackColor = "#FFA384";
                ForeColor = "#fff";
            }
            else
            {
                Status = "Не получен";
                BackColor = "#E7F2F8";
                ForeColor = "#939393";
            }
        }


        public long ID { get; set; }
        public long TimeTableID { get; set; }
        public int ComponentTypeID { get; set; }
        public string ComponentType { get; set; }
        public string DoctorName { get; set; }
        public int VaccinationPointID { get; set; }
        public string VaccinationPointName { get; set; }
        public int PatientID { get; set; }
        public bool IsReceived { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Status { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
    }
}