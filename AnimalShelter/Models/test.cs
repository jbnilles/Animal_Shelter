using System;
namespace cars
{

  class car
  {
    public bool lightsOn;

    public car()
    {

    }
    public static void updateComputers()
    {
      //update
      return;
    }
    public void horn()
    {
      //sound horn
      return;
    }
    public void start()
    {
      //start the car
      return;
    }
  }

  class toyota : car
  {
      public toyota()
      {

      }
      new public void horn()
      {
        //play toyota horn
        return;
      }
  }

  class program
  {
    public static void main()
    {
      car c = new car();
      toyota t = new toyota();
      t.horn();
      t.start();
      t.lightsOn = true;
      toyota.updateComputers();
    }
    

    

  }










}