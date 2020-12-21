﻿using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;
using Progile.TRIO.EnvironmentModel.WebBrowser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using static TestImages.Wikipedia;

namespace Wikipedia_Model
{
    public partial class WikipediaApp : IWebAppBasics
    {
        public static bool versionLogged; // this needs to be static, because we want to log the version only once over all instances
        private readonly Dictionary<string, object> _testCaseDataStorage = new Dictionary<string, object>();

        public WikipediaApp(ITester t)
        {
            Tester = t;
            SystemHelpers = new SystemHelpers(t);

            // Log version of all required models
            LogSwModelVersion();
            SystemHelpers.LogEnvironmentModelVersion();
            BaseModelHelpers.LogBaseModelVersion(t);

            // Initialize Application Settings
            AppSettings = new Dictionary<string, string>();

            // Set this to the culture of the environment that will be used
            SutLocale = new SutLocale(t, SystemHelpers, "en-CH");

            Browser = new Browser(t, SystemHelpers);
            Browser.Activate();

            InitScreens();
        }

        public ITester Tester { get; }
        public ISystemHelpers SystemHelpers { get; }
        public Browser Browser { get; }
        public Select Window => Browser.BrowserWindow;
        public Dictionary<string, string> AppSettings { get; }
        public ISutLocale SutLocale { get; }


        partial void InitScreens();


        public IScroller GetScroller(Select searchRectangle, bool requiresFocus = false)
        {
            return new BrowserScroller(Tester, searchRectangle ?? Window, Browser.Type, requiresFocus);
        }

        /// <summary>
        /// Stores a variable with the specified name, so that it can be used later in the test case.
        /// </summary>
        public void Store(string name, object value)
        {
            _testCaseDataStorage[name] = value;
        }

        /// <summary>
        /// Retrieves a previously stored variable with the specified name. Replace T with the type of the variable (e.g. string)
        /// </summary>
        public T Get<T>(string name)
        {
            if (!_testCaseDataStorage.ContainsKey(name))
                return default(T);

            return (T)_testCaseDataStorage[name];
        }

        private void LogSwModelVersion()
        {
            if (!versionLogged)
            {
                var assembly = Assembly.GetExecutingAssembly();
                Tester.Log("* SW Model Name:         " + assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title);
                Tester.Log("* SW Model Version:      " + BaseModelHelpers.GetVersionString(assembly.GetName().Version));
                versionLogged = true;
            }
        }
    }
}
