using System;
using System.Collections.Generic;
using System.Text;
using Contract;

namespace Business
{
    public class AdmissionLogic
    {
        public string CapacityExceed(AdmissionModel model)
        {
            string result = string.Empty;

            if (model.NumberOfSubmittedStudents > model.CapacityOfStudents)
                result = string.Format("The course {0} has reached to the maximum size of capacity",model.Course);
            
            return result;
        }
        
    }
}
