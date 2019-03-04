using System;
using System.Collections.Generic;
using System.Text;

namespace Contract
{
    public class CollegeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public int NumberOfClass { get; set; }
        public int NumberOfTeacher { get; set; }
        public string PlaceOfBirth { get; set; }
        public int MaxCapacity { get; set; }

    }
}
