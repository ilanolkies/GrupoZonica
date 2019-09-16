using Xamarin.Forms;
using GrupoZonica.ViewModels;
using System.Diagnostics;

namespace GrupoZonica.Views
{
    public partial class Vivo : ContentPage
    {
        VivoViewModel viewModel;

        public Vivo()
        {
            InitializeComponent();

            BindingContext = viewModel = new VivoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.LoadNombre.Execute(null);
            viewModel.LoadBanner.Execute(null);
        }
    }
}
