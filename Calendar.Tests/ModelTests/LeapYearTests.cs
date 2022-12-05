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

    }
  }
}