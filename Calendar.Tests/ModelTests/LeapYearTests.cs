using Microsoft.VisualStudio.TestTools.UnitTesting;  //imports MSTest framework 
using Calendar; //imports Calendar namepsace from Calendar project

namespace Calendar.Tests
{
  [TestClass] //tells MSTest that the following class contains tests to be run
  public class LeapYearTests
  {
    [TestMethod] //tells the complier that the following code block is an individual test that MSTest will run
    public void IsLeapYear_NumberDivisibleByFour_True() //naming criteria NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012)); //first arguement = what we expect. second is the test itself
    }

    //new [TestMethod] must be added for each test
    [TestMethod]
    public void IsLeapYear_NotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(2011));
    }

    //new [TestMethod] must be added for each test
    [TestMethod]
    public void IsLeapYear_NumberDivisibleBy100_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }

    //new [TestMethod] must be added for each test
    [TestMethod]
    public void IsLeapYear_NumberDivisibleBy400_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2400));
    }
  }
}