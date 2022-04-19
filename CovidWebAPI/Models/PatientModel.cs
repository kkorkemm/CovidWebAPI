using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidWebAPI.Models
{
    using Base;

    public class PatientModel
    {
        public PatientModel(Patient patient)
        {
            ID = patient.ID;
            FullName = patient.FullName;
            Code = patient.Code;
            Telephone = patient.Telephone;
            DateOfBirth = patient.DateOfBirth;
            IsQuestionnareCompleted = patient.Questionnnare.Count > 0;
        }

        public int ID { get; set; }
        public string FullName { get; set; }
        public string Code { get; set; }
        public string Telephone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsQuestionnareCompleted { get; set; }
    }
}