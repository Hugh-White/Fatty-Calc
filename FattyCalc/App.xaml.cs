using FattyCalc.MVVM.Views;

namespace FattyCalc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FattyCalcView();
        }
    }
}
