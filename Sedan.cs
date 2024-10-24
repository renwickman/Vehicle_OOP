using System;

namespace Vehicle_OOP
{
  class Sedan : Vehicle
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }

  }
}