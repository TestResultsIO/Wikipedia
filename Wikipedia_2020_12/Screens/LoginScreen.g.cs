//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 3.3.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using static TestImages.Wikipedia;

namespace Wikipedia_Model.Screens
{
	public partial class  LoginScreen : BaseScreen
	{
		public  LoginScreen(IAppBasics appBasics) : base(appBasics, "Login screen", Images.LoginScreen.Screen_Loaded)
		{
			Username = new Progile.TRIO.BaseModel.TextBox(appBasics: AppBasics, displayName: "Username", imageReference: Images.LoginScreen.Username, filters: ScreenSelect) { ParentScreen = this }; 
			Password = new Progile.TRIO.BaseModel.PwTextBox(appBasics: AppBasics, displayName: "Password", imageReference: Images.LoginScreen.Password.TextBoxImage, pwCharImage: Images.LoginScreen.Password.BlindCharImage, filters: ScreenSelect) { ParentScreen = this }; 
			KeepMeLoggedIn = new Progile.TRIO.BaseModel.Checkbox(tester: t, displayName: "Keep me logged in", checkedImageReference: Images.LoginScreen.KeepMeLoggedIn._checked, uncheckedImageReference: Images.LoginScreen.KeepMeLoggedIn._unchecked, filters: ScreenSelect) { ParentScreen = this }; 
			LogInButton = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Log in Button", activeImageReference: Images.LoginScreen.LogInButton.active, filters: ScreenSelect) { ParentScreen = this }; 
			Help = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Help", activeImageReference: Images.LoginScreen.Help.active, filters: ScreenSelect) { ParentScreen = this }; 
			ForgotPassword = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Forgot password", activeImageReference: Images.LoginScreen.ForgotPassword.active, filters: ScreenSelect) { ParentScreen = this }; 
			JoinWikipedia = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Join Wikipedia", activeImageReference: Images.LoginScreen.JoinWikipedia.active, filters: ScreenSelect) { ParentScreen = this }; 
			
			ConfigureElementProperties();
        }

		  
		public Progile.TRIO.BaseModel.TextBox Username { get; private set; }
		  
		public Progile.TRIO.BaseModel.PwTextBox Password { get; private set; }
		  
		public Progile.TRIO.BaseModel.Checkbox KeepMeLoggedIn { get; private set; }
		  
		public Progile.TRIO.BaseModel.Button LogInButton { get; private set; }
		  
		public Progile.TRIO.BaseModel.Button Help { get; private set; }
		  
		public Progile.TRIO.BaseModel.Button ForgotPassword { get; private set; }
		  
		public Progile.TRIO.BaseModel.Button JoinWikipedia { get; private set; }
		
		partial void ConfigureElementProperties();
	}
}