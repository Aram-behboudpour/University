using System;
using System.Collections.Generic;
using System.Text;

namespace Contract
{
    public class AdmissionModel
    {
       
        public int Id { get; set; }
        public string Course { get; set; }
        public DateTime DateOfClose { get; set; }
        public DateTime DateOfReopen { get; set; }
        public int CapacityOfStudents { get; set; }
        public int NumberOfSubmittedStudents { get; set; }

    }
}
