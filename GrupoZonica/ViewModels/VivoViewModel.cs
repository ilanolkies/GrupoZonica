using System;
using System.Diagnostics;
using System.Threading.Tasks;
using GrupoZonica.Services;
using Xamarin.Forms;

namespace GrupoZonica.ViewModels
{
    public class VivoViewModel : BaseViewModel
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        public Command LoadNombre { get; set; }

        string banner;
        public string Banner
        {
            get { return banner; }
            set { SetProperty(ref banner, value); }
        }
        public Command LoadBanner { get; set; }

        public VivoViewModel()
        {
            Nombre = null;
            Banner = null;

            LoadNombre = new Command(async () => await ExecuteLoadNombre());
            LoadBanner = new Command(async () => await ExecuteLoadBanner());
        }

        async Task ExecuteLoadNombre()
        {
            Nombre = "...";
            Nombre = (await WebDataHelper.GetNombrePrograma()).Trim();
        }

        async Task ExecuteLoadBanner()
        {
            Banner = (await WebDataHelper.GetBannerPrograma()).Trim();
        }
    }
}
