using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeTest.Models
{
    public class CustomEmployee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> BirthDate { get; set; }

        public string Gender { get; set; }

        public string Salary { get; set; }

        public Nullable<int> FkCityId { get; set; }

        public Nullable<int> FkStateId { get; set; }

        public string Photo { get; set; }

        public Nullable<int> FkDepartmentId { get; set; }

        public Nullable<bool> IsActive { get; set; }

        public HttpPostedFileBase user_image { get; set; }

        public virtual City City { get; set; }
        public virtual Department Department { get; set; }
        public virtual State State { get; set; }

        public string CityName { get; set; }
        public string DepartmentName { get; set; }
        public string StateName { get; set; }
    }

}
