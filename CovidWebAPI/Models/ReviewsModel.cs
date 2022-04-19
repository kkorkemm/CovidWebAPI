using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidWebAPI.Models
{
    using Base;

    public class ReviewsModel
    {
        public ReviewsModel(Review review)
        {
            ID = review.ID;
            VaccinationPointID = review.VaccinationPointID;
            Patient = review.Patient.FullName;
            Rating = Convert.ToInt32(review.Rating);
            Text = review.Text;
        }

        public long ID { get; set; }
        public int VaccinationPointID { get; set; }
        public string Patient { get; set; }
        public int? Rating { get; set; }
        public string Text { get; set; }
    }
}