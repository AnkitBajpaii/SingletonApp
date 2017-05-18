using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonApp
{
    class Program
    {
        /// <summary>
        /// Entry point for your application
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        public static void Main(string[] args)
        {
            SingleInstanceManager wrapper = new SingleInstanceManager(true);
            wrapper.Run(args);

        }
    }
}
