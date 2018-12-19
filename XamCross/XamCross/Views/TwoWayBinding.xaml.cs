using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCross.View_Model;

namespace XamCross.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TwoWayBinding : ContentPage
	{
		public TwoWayBinding ()
		{
			InitializeComponent ();

            BindingContext = new TwoWayBindingLoginViewModel();
		}
	}
}