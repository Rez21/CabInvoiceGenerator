
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTestProject
{
    public class Tests
    {
        InvoiceGenerator invoice;
     
        [Test]
        [TestCase(5,5,55,RideType.NORMAL)]
        [TestCase(5,5,85,RideType.PREMIUM)]
        public void Given_Distance_ANd_Time_Return_Total_Fare(double distance, int time, double expected, RideType rideType)
        {
            // Arrange
            //double distance = 5;
            //int time = 5;
            //double expected = 55;
            invoice = new InvoiceGenerator(rideType);

            //Act
            double actual = invoice.CalculateFare(distance, time);
            
            //Assert
            Assert.AreEqual(actual,expected);
        }
    }
}