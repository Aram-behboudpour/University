using System;
using System.Diagnostics.Contracts;
using Contract;
using Xunit;

namespace University.UnitTest
{
    public class CollageUnitTest
    {
       
        [Theory]
        [InlineData("Tehran")]
        public void TestWelcomMessage(string collageName)
        {
            //Arrange
            var collegeModel = new CollegeModel()
            {
                Name = collageName,
            };
            var cBus = new Business.CollegeBusiness();
            //Act

            var rsltMessage = cBus.WelcomeMessage(collegeModel);
            //Assert
            Assert.Equal($"Dear student, welcome to {collegeModel.Name} College.", rsltMessage);
        }
        [Theory]
        [InlineData(20,"Tehran")]
        public void TestMaxReachedOfCapacity(int numberCapcityClass,string collageName)
        {
            //Arrange
            var collegeModel = new CollegeModel()
            {
                NumberOfClass = numberCapcityClass,
                Name = collageName
            };
            var cBus = new Business.CollegeBusiness();
            //Act

            var rsltMessage = cBus.MaxSizeReached(collegeModel);
            //Assert
            Assert.Equal($"{collegeModel.Name}College has reached the maximum size of capacity", rsltMessage);
        }
        [Theory]
        [InlineData(20, "Tehran")]
        public void TestShowNumberOfTeacher(int numberOfTeacher, string collageName)
        {
            //Arrange
            var collegeModel = new CollegeModel()
            {
                NumberOfTeacher = numberOfTeacher,
                Name = collageName
            };
            var cBus = new Business.CollegeBusiness();
            //Act

            var rsltMessage = cBus.NumberOfTeacher(collegeModel);
            //Assert
            Assert.Equal($"{collegeModel.Name}College has Number of Teacher =  {collegeModel.NumberOfTeacher}", rsltMessage);
        }
    }
}
