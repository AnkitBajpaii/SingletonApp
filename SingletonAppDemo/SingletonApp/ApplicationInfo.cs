using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonApp
{
    /// <summary>
    /// To use  entire application level ,this  initializes at the time of app initializes.
    /// Customize this class as per your need
    /// </summary>
    public class ApplicationInfo
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public ApplicationInfo()
        {

        }

        /// <summary>
        /// Get  application name
        /// </summary>
        private static string appName;
        public static string AppName
        {
            get
            {
                return appName;
            }
            set
            {
                appName = value;
            }
        }

        /// <summary>
        /// Get and sets db server name
        /// </summary>
        public static string DBServer
        {
            get;
            set;
        }

        /// <summary>
        /// Get and sets db  name
        /// </summary>
        public static string DBName
        {
            get;
            set;
        }

        /// <summary>
        /// Get and sets user  name
        /// </summary>
        public static string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Get and sets password ,mostly this  is  same as  user name for now
        /// TODO:encryption may need if we use this.
        /// </summary>
        public static string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Get and sets user  name
        /// </summary>
        public static int DomainId
        {
            get;
            set;
        }

        public static int GlobalDomainId
        {
            get;
            set;
        }

        public static string GlobalDomainName
        {
            get
            {
                return "Global";
            }
        }

    }
}
