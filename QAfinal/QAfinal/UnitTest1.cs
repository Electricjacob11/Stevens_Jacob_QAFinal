using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QAfinal
{
    [TestClass]
    public class UnitTest1
    {
        // Function to Test
        public bool CanDrive(int age)
        {
            const int drivingAge = 16;
            return age >= drivingAge;
        }

        [TestMethod]
        public void Test_CanDrive_AgeLessThanDrivingAge_ReturnsFalse()
        {
            // Arrange
            int age = 15;

            // Act
            bool result = CanDrive(age);

            // Assert
            Assert.IsFalse(result, "CanDrive should return false for age < 16.");
        }

        [TestMethod]
        public void Test_CanDrive_AgeEqualToDrivingAge_ReturnsTrue()
        {
            // Arrange
            int age = 16;

            // Act
            bool result = CanDrive(age);

            // Assert
            Assert.IsTrue(result, "CanDrive should return true for age = 16.");
        }

        [TestMethod]
        public void Test_CanDrive_AgeGreaterThanDrivingAge_ReturnsTrue()
        {
            // Arrange
            int age = 20;

            // Act
            bool result = CanDrive(age);

            // Assert
            Assert.IsTrue(result, "CanDrive should return true for age > 16.");
        }
    }
}
