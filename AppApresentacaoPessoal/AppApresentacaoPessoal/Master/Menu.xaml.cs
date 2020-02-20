using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppApresentacaoPessoal.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
         private void GoPageXemarin(object sender, EventArgs e)
        {
            Detail = new Pages.Xamarin();
        }
        private void GoPagePerfil1(object sender, EventArgs e)
        {
            Detail = new Pages.Perfil1();
        }
    }
}