using System;
using System.Collections.Generic;
using System.Text;

namespace Contract
{
    public class ClassModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Subjects { get; set; }

        public int CapacityOfStudents { get; set; }

        public int Floor { get; set; }

        public int Area { get; set; }
    }
}
