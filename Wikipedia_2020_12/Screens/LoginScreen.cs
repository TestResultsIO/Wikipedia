using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

using static TestImages.Wikipedia;


namespace Wikipedia_Model.Screens
{
    public partial class LoginScreen
    {
        public void LoginUser(string username, string password)
        {
            Username.Enter(username);
            Password.Enter(password);
            KeepMeLoggedIn.Check();
            LogInButton.Click(WaitForDisappear);
        }
    }
}