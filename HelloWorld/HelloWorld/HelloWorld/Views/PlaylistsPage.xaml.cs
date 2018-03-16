using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using HelloWorld.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
    {
        

        public PlaylistsPage()
        {
            ViewModel = new PlaylistsViewModel(new PageService());

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        void OnPlaylistSelected(object sender, SelectedItemChangedEventArgs e)
        {ViewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }

        public PlaylistsViewModel ViewModel
        {
            get { return BindingContext as PlaylistsViewModel;}
            set { BindingContext = value; }
        }
    }
}