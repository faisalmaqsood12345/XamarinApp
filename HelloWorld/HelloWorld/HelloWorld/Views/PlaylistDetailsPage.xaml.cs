using System;
using System.Collections.Generic;
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
    public partial class PlaylistDetailsPage : ContentPage
    {
        private PlaylistViewModel _playlist;
        public PlaylistDetailsPage(PlaylistViewModel playlist)
        {
            _playlist = playlist;
            InitializeComponent();
            title.Text = _playlist.Title;
        }
    }
}