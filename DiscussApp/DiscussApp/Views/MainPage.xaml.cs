using Prism.Navigation;
using Xamarin.Forms;

namespace DiscussApp.Views
{
	public partial class MainPage :  MasterDetailPage, IMasterDetailPageOptions
    {
		public MainPage ()
		{
			InitializeComponent ();
		}
        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;
    }
}