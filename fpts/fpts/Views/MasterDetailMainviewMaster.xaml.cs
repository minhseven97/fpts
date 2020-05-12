using fpts.Models;
using fpts.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMainviewMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMainviewMaster()
        {
            InitializeComponent();
            this.BindingContext = new MasterDetailMainviewMasterViewModel();

        }

        private async void lbTap(object sender, EventArgs e)
        {
            var pagee = new TaiSanView();
            await Navigation.PushModalAsync(pagee);
           // await Navigation.PushAsync(new TaiSanView());
        }

        
    }
}