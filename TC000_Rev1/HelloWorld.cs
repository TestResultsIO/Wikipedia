using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using System;
using Wikipedia_Model;
using static TestImages.TC000_Rev1;

namespace TC000_Rev1
{
    [TestCase(1)]
    public class HelloWorld
    {
        //  reference the software model
        private WikipediaApp App { get; set; }

        [SetupTest]
        public bool Setup(ITester t)
        {
            App = new WikipediaApp(t);
            return true;
        }

        [PreconditionStep]
        public void PreconditionStep(ITester t)
        {
            App.SystemHelpers.EnvironmentReady();

            // Example for usage of software model:
            //App.ExampleScreen.Activate();
            //App.ExampleScreen.ExampleAction("superuser", "safePW");

            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TestStep(1,
            TestInput = "TestInput1",
            ExpectedResults = "Expected1")]
        public void Step1(ITester t)
        {
            t.Report.FailStep("Hello World");
        }

        [CleanupStep]
        public void Step2(ITester t)
        {
            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TearDownTest]
        public bool TearDown(ITester t)
        {
            return true;
        }
    }
}
