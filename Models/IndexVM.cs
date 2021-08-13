using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamic_Model_to_View_Multiple_Model_in_Single_View.Models
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }
        public List<Student> Students { get; set; }
    }
}