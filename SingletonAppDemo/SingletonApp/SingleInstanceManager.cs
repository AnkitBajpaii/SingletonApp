using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;

namespace SingletonApp
{
    public class SingleInstanceManager : WindowsFormsApplicationBase
    {
        #region Fields
        SingletonApp app;
        #endregion

        public SingleInstanceManager(bool isSingleInstance)
        {
            this.IsSingleInstance = isSingleInstance;
        }

        #region Methods
        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
            app = new App();
            app.SplashScreenImagePath = ConfigurationManager.AppSettings["SplashScreenImagePath"].ToString();// Should return "\Images\Splash\Loading.jpg"
            app.Run();
            return false;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            app.Activate();
            app.ProcessCommandlineArgs(eventArgs.CommandLine);
        }

        #endregion
    }
}
