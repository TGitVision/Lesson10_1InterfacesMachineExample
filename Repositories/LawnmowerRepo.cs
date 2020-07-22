using System;
using System.Collections.Generic;
using System.Text;
using Lesson10_1InterfacesMachineExample.Interfaces;

namespace Lesson10_1InterfacesMachineExample.Repositories
{
    class LawnmowerRepo : IMachine
    {

        #region Fields and Properties

        string _lawnmowerName;

        // Expression Body Definitions consist of the => symbol
        public string carName
        {

            get => _lawnmowerName;

        }

        // or

        //// Auto Implemented Properties Classic Prop way
        // public string carName
        // {

        //    get => _carName;

        // }

        #endregion

        #region Constructors

        public LawnmowerRepo() 
        {

            _lawnmowerName = "lawnmower";

        }

        public LawnmowerRepo(string lawnmowerName)
        {
            this._lawnmowerName = lawnmowerName;

        }

        #endregion

        #region Methods

        // Implemented Methods from Interface
        public void Start()
        {
            Console.WriteLine($"The {_lawnmowerName} started with a pull string.");
        }

        public void Stop()
        {
            Console.WriteLine($"The {_lawnmowerName} stopped by releasing the handle.");
        }

        #endregion
    }
}
