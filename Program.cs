using System;
using Lesson10_1InterfacesMachineExample.Interfaces;
using Lesson10_1InterfacesMachineExample.Repositories;

namespace Lesson10_1InterfacesMachineExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World from Lesson10_1InterfacesMachineExample!");

            //// No interface Example:
            // CarRepo hummer = new CarRepo();
            // hummer.Start();
            // hummer.Stop();

            // Interface Example:
            // IMachine hummer = new CarRepo(); // empty constructor with no parameter
            IMachine hummer = new CarRepo("Yellow H2 Hummer");
            ExecuteMachine(hummer);

            // IMachine honda = new CarRepo();  // empty constructor with no parameter           
            IMachine honda = new CarRepo("White Accord EX Sedan"); // constructor with parameter
            ExecuteMachine(honda);

            // IMachine johnDeere = new LawnmowerRepo(); // empty constructor with no parameter 
            IMachine johnDeere = new LawnmowerRepo("Stratton");
            ExecuteMachine(johnDeere);

        }

        #region Methods

        static void ExecuteMachine(IMachine machine) 
        {
            machine.Start();
            machine.Stop();
        }

        #endregion


    }
}
