using System;
using Forum.App.UserInterface;
using Forum.App.UserInterface.Views;

namespace Forum.App.Services
{
    using Forum.App.Services.Contracts;
    using Forum.App.UserInterface.Contracts;

    public class LogInController : IController, IReadUserInfoController
    {
        private enum Command
        {
            ReadUsername, ReadPassword, LogIn, Back
        }
        public string Username { get; private set; }
        private string Password { get; set; }
        private bool Error { get; set; }

        public LogInController()
        {
            this.ResetLogin();
        }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.ReadUsername:
                    this.ReadUsername();
                    return MenuState.Login;
                case Command.ReadPassword:
                    this.ReadPassword();
                    return MenuState.Login;
                case Command.LogIn:
                    return MenuState.Error;
                case Command.Back:
                    return MenuState.Back;
            }
            throw new System.InvalidOperationException();
        }

        public IView GetView(string userName)
        {
            return new LogInView(this.Error, this.Username, this.Password.Length);
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

        private void ResetLogin()
        {
            this.Error = false;
            this.Username = String.Empty;
            this.Password= String.Empty;
        }
    }
}
