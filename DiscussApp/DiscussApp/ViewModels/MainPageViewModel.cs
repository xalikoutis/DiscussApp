using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        async Task GetData()
        {
            
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            NavigationService.NavigateAsync("");
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            Name = parameters["name"].ToString();
            await GetData();
            base.OnNavigatedTo(parameters);
        }
    }
}
