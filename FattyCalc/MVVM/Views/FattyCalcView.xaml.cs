using FattyCalc.MVVM.ViewModels;

namespace FattyCalc.MVVM.Views;

public partial class FattyCalcView : ContentPage
{
	public FattyCalcView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}