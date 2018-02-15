using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DiscussApp.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{
	    public DelegateCommand LoginCommmand { get; set; }


        private string _email;
	    private string _password;

	    public string Email
	    {
	        get { return _email; }
	        set
	        {
	            _email = value; 
	            RaisePropertyChanged();
	        }
	    }

	    public string Password
	    {
	        get { return _password; }
	        set
	        {
	            _password = value; 
	            RaisePropertyChanged();
	        }
	    }



	    public LoginViewModel(INavigationService navigationService) : base(navigationService)
	    {
            LoginCommmand = new DelegateCommand(()=>Login());
        }

	    private void Login()
	    {
            //call auth service
            var param = new NavigationParameters();
	        param.Add("name","Evi");
            NavigationService.NavigateAsync("MainPage",param);
	    }
	}
}
