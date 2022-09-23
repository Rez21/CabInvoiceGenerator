
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTestProject
{
    public class Tests
    {
        InvoiceGenerator invoice = new InvoiceGenerator();
     
        [Test]
        [TestCase(5,5,55,RideType.NORMAL)]
        [TestCase(5,5,85,RideType.PREMIUM)]
        public void Given_Distance_ANd_Time_Return_Total_Fare(double distance, int time, double expected, RideType rideType)
        {
            // Arrange
            Ride ride = new Ride(distance,time,rideType);

            //Act
            double actual = invoice.CalculateFare(ride);
            
            //Assert
            Assert.AreEqual(actual,expected);
        }

        [Test]
        public void Given_Multiple_Rides_Return_TotalFare()
        {
            //Arrange
            double expected = 88;
            Ride[] rides = { new Ride(5, 2, RideType.NORMAL), new Ride(2, 3, RideType.PREMIUM) };                    
            // Act
            double actual = invoice.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}