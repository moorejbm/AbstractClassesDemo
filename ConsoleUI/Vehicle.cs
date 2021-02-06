using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //The vehicle class shall have three string properties Year, Make, and Model
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Modle";

        public abstract void DriveAbstract(); // Stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
      }     
    }



  


