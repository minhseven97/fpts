using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }


        private async void BtnLogin_click(object sender, EventArgs e)
        {
            var page = new MasterDetailMainview();
            await Navigation.PushModalAsync(page);
        }
    }
    }
