namespace Forum.App.Services
{
	using Forum.App;
	using Forum.App.Services.Contracts;
    using Forum.App.UserInterface;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.UserInterface.Views;

    public class SignUpController : IController, IReadUserInfoController
    {
        private const string DETAILS_ERROR = "Invalid Username or Password!";
        private const string USERNAME_TAKEN_ERROR = "Username already on use!";
        private enum Command
        {
            ReadUsername, ReadPassword, SignUp, Back
        }
        private enum SignUpStatus
        {
            Success, DetailsError, UsernameTakenError
        }

        public string Username { get; private set; }
        private string Password { get; set; }
        private string ErrorMessage { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.ReadUsername:
                    this.ReadUsername();
                   return MenuState.Signup;

                case Command.ReadPassword:
                    this.ReadPassword();
                   return MenuState.Signup;
               
                case Command.SignUp:
                   return MenuState.Signup;
           
                case Command.Back:
                    this.ResetSignUp();
                   return MenuState.Signup;
            }
            throw new System.InvalidOperationException();
        }

        public IView GetView(string userName)
        {
            return new SignUpView(this.ErrorMessage);
        }

        public void ReadPassword()
        {
            this.Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
             this.Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }
        private void ResetSignUp()
        {
            this.ErrorMessage = string.Empty;
            this.Username = string.Empty;
            this.Password = string.Empty;
        }
    }
}
