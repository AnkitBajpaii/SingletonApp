using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Reflection;
using System.Threading;

namespace SingletonApp
{
    public abstract class SingletonApp : Application
    {
        public string SplashScreenImagePath { get; set; }
        /// <summary>
        /// Handles the logic on start up of  application.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;

            //Do initialization required for your App

            //Show splash screen
            SplashScreen splashScreen = new SplashScreen(Assembly.GetExecutingAssembly(), SplashScreenImagePath);
            splashScreen.Show(false);
            Thread.Sleep(1000);
            //Run bootstrapper in derived class
            RunBootStrapper(e.Args, splashScreen);
        }

        /// <summary>
        /// This  method responsible for run the  boot strapper  for application specific .
        /// Application can override the splash screen other than basic  one.
        /// </summary>
        /// <param name="commandLines"></param>
        /// <param name="splscreen"></param>
        protected abstract void RunBootStrapper(string[] commandLines, SplashScreen splscreen);

        /// <summary>
        /// Method used to handle command line arguments
        /// </summary>
        /// <param name="commandline">Command line args</param>
        public abstract void ProcessCommandlineArgs(System.Collections.ObjectModel.ReadOnlyCollection<string> commandline);

        /// <summary>
        /// Activates  main window.
        /// </summary>
        public void Activate()
        {
            MainWindow.Activate();
        }
    }
}
