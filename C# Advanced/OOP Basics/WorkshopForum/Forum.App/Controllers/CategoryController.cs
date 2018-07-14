namespace Forum.App.Controllers
{
    using System;
    using System.Linq;
    using Forum.App.Services;
    using Forum.App.Services.Contracts;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.Views;

    public class CategoryController : IController, IPaginationController
    {
        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        private enum Command
        {
            Back = 0, ViewPost = 1, PreviousPage = 11, NextPage = 12
        }

        public int CurrentPage { get; set; }
        public string[] AllCategoryNames { get; set; }
        public string[] CurrentPageCategories { get; set; }
        public int LastPage => this.AllCategoryNames.Length / (PAGE_OFFSET + 1);
        public bool IsFirstPage => this.CurrentPage == 0;
        public bool IsLastPage => this.CurrentPage == this.LastPage;

        private void ChangePage(bool forward = true)
        {
            this.CurrentPage += forward ? 1 : -1;
        }

        private void LoadCategories()
        {
            this.AllCategoryNames = PostService.GetAllCategoryNames();
            this.CurrentPageCategories = this.AllCategoryNames
                .Skip(this.CurrentPage * PAGE_OFFSET)
                .Take(PAGE_OFFSET).ToArray();
        }

        public MenuState ExecuteCommand(int index)
        {
            if (index >1&&index<11)
            {
                index =1;
            }
            switch ((Command)index)
            {
                case Command.Back:
                    return MenuState.Back;
                case Command.ViewPost:
                    return MenuState.Back;
                case Command.PreviousPage:
                   return MenuState.Rerender;
                case Command.NextPage:
                  return MenuState.Rerender;
            }
            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            LoadCategories();
            return new CategoriesView(this.CurrentPageCategories, this.IsFirstPage, this.IsLastPage);
        }
    }
}
