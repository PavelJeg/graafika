using graafika.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace graafika.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}