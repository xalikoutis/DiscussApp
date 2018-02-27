using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;

namespace DiscussApp.ViewModels
{
    class CategoriesViewModel : ViewModelBase
    {
        //IAuthenticationService _authenticationService { get; }

        public CategoriesViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Categories";
            //_authenticationService = authenticationService;
            //LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        //public DelegateCommand LogoutCommand { get; }

        //public override void OnNavigatedTo(NavigationParameters parameters)
        //{
        //    Message = parameters.GetValue<string>("message");
        //}

        //public void OnLogoutCommandExecuted() =>
        //    _authenticationService.Logout();
    }
}

