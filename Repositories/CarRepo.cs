using System;
using System.Collections.Generic;
using System.Text;
using Lesson10_1InterfacesMachineExample.Interfaces;

namespace Lesson10_1InterfacesMachineExample.Repositories
{
    class CarRepo : IMachine
    {

        #region Fields and Properties

        string _carName;

        // Expression Body Definitions consist of the => symbol
        public string carName 
        {

            get => _carName;            
        
        }

        // or

        //// Auto Implemented Properties Classic Prop way
        // public string carName
        // {

        //    get => _carName;

        // }

        #endregion

        #region Constructors
        public CarRepo()
        {
            this._carName = "car";

        }
        public CarRepo(string carName)
        {
            this._carName = carName;

        }

        #endregion

        #region Methods

        // Implemented Methods from Interface
        public void Start()
        {
            Console.WriteLine($"The {carName} started with a key.");
        }

        public void Stop()
        {
            Console.WriteLine($"The {carName} stopped when I turned it off with the key.");
        }

        #endregion

    }
}
