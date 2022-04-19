using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidWebAPI.Models
{
    using Base;

    public class VaccinationPointsModel
    {
        public VaccinationPointsModel(VaccinationPoint point)
        {
            ID = point.ID;
            UserRoleID = point.UserRoleID;
            Login = point.Login;
            Password = point.Password;
            Name = point.Name;
            Address = point.Address;
            WorkTime = point.WorkTime;
            Telephone = point.Telephone;
            Photo = point.Photo;

            AverageRating = Math.Round(Convert.ToDecimal(point.Review.Average(p => p.RatingInt)), 1);
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

        public decimal? AverageRating { get; set; }
    }
}