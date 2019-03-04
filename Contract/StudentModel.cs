using System;
using System.Collections.Generic;
using System.Text;

namespace Contract
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FatherName { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}
