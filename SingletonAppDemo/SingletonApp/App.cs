using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonApp
{
    public class App : SingletonApp
    {
        #region Fields

        private string _commandLineParameter = string.Empty;

        #endregion

        #region Methods

        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            ApplicationInfo.AppName = "Your App Name Here";
            base.OnStartup(e);
        }

        /// <summary>
        /// Creates an instance of SingletonAppBootstrapper and runs it
        /// </summary>
        /// <param name="commandLines">Command line args</param>
        /// <param name="splscreen">Splash screen object</param>
        protected override void RunBootStrapper(string[] commandLines, System.Windows.SplashScreen splscreen)
        {
            SingletonAppBootstrapper bootstrapper = new SingletonAppBootstrapper(splscreen);

            if (commandLines != null && commandLines.Length > 0)
            {
                bootstrapper.CommandLineParameter = commandLines[0];
                _commandLineParameter = commandLines[0];
            }

            bootstrapper.Run();
        }

        /// <summary>
        /// Method used to handle command line arguments
        /// </summary>
        /// <param name="commandline">Command line args</param>
        public override void ProcessCommandlineArgs(System.Collections.ObjectModel.ReadOnlyCollection<string> commandline)
        {
            if (commandline != null && commandline.Count > 0)
            {
                //Your logic goes here
            }
        }


        #endregion
    }
}
