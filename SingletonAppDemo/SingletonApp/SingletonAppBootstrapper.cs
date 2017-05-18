using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;

namespace SingletonApp
{
    public class SingletonAppBootstrapper : UnityBootstrapper
    {
        #region Fields
        private SplashScreen splscreen;
        #endregion

        #region Properties

        private string _commandLineParameter;
        public string CommandLineParameter
        {
            get { return _commandLineParameter; }
            set
            {
                _commandLineParameter = value;
            }
        }

        #endregion

        public SingletonAppBootstrapper(SplashScreen splscreen)
        {
            // TODO: Complete member initialization
            this.splscreen = splscreen;
        }

        #region Methods
        protected override System.Windows.DependencyObject CreateShell()
        {
            return UnityContainerHelper.TryResolve<MainWindow>(this.Container);
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            splscreen.Close(TimeSpan.FromMilliseconds(1000));
            Application.Current.MainWindow = (MainWindow)this.Shell;
            Application.Current.MainWindow.Show();
        }

        #endregion
    }
}
