namespace Calendar  //Logic goes here
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      bool leapYear = false;
      if(year % 400 == 0){
        leapYear = true;
      }
      else if(year % 100 == 0){
        leapYear = false;
      } else if(year % 4 == 0){
        leapYear = true;
      }
      return leapYear;

    }
  }
}