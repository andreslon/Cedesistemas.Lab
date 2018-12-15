using Lab1.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab1.App.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VehicleDetailPage : ContentPage
	{
		public VehicleDetailPage (VehicleViewModel vm)
		{
			InitializeComponent ();
            BindingContext = vm;
		}
	}
}