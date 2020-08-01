using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppli5.Models
{
    public class Company
    {
        public string SelectedDepartment { get; set; }
        public List<Department> Departments
        {
            get
            {
                hdfcEntities db = new hdfcEntities();
                return db.Departments.ToList();
            }
        }
    }
}