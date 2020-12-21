using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using System;
using Wikipedia_Model;
using static TestImages.TC001_Rev1;

namespace TC001_Rev1
{
    [TestCase(1)]
    public class LoginTest
    {
        //  reference the software model
        private WikipediaApp App { get; set; }

        [SetupTest]
        public bool Setup(ITester t)
        {
            App = new WikipediaApp(t);
            return true;
        }

        [PreconditionStep(TestInput = "On the welcome screen select English to go the the Wikipedia Main Page.",
            ExpectedResults = "Wikipedia Main Page in English is displayed.")]
        public void PreconditionStep(ITester t)
        {
            App.WelcomeScreen.English.Click(App.MainScreen.WaitForAppear);

            t.Report.PassStep("Wikipedia Main screen was loaded.");
        }

        [TestStep(1,
        TestInput = "Navigate to Login page.",
        ExpectedResults = "Login page is displayed.")]
        public void Step1(ITester t)
        {
            App.TopMenu.GoTo(App.LoginScreen);

            t.Report.PassStep("Login page was displayed.");
        }

        [TestStep(2,
            TestInput = "Login to Wikipedia.",
            ExpectedResults = "User is logged in.")]
        public void Step2(ITester t)
        {
            App.LoginScreen.LoginUser("TestResults.io", "Tutorial");

            t.Report.PassFailStep(
                App.TopMenu.LoggedInUser.VerifyValue("TestResults.io"),
                "Logged in user was correctly displayed.",
                "Logged in user was not correctly displayed.");
        }

        [CleanupStep(TestInput = "Cleanup: Logout from Wikipedia.")]
        public void Step3(ITester t)
        {
            App.TopMenu.LogoutUser();

            t.Report.PassStep("User was logged out");
        }

    }
}
