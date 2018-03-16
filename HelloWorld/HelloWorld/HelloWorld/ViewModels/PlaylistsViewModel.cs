using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HelloWorld.Models;
using HelloWorld.Views;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
  public class PlaylistsViewModel : BaseViewModel
    {
        private PlaylistViewModel _selectedPlayList;
        private readonly IPageService _pageService;

        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistViewModel>();

        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlayList; }
            set { SetValue(ref _selectedPlayList, value);}
           
        }
        public ICommand AddPlayListCommand { get; private set; }
        public ICommand SelectPlaylistCommand { get; private set; }

       

        public PlaylistsViewModel(IPageService pageService)
        {
            _pageService = pageService;
            AddPlayListCommand = new Command(AddPlayList);
            SelectPlaylistCommand = new Command<PlaylistViewModel>(async vm => await onPlayListSelected(vm));
        }
        private void AddPlayList()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        private async Task onPlayListSelected(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;         

            playlist.IsFavorite = !playlist.IsFavorite;
            SelectedPlaylist = null;
            await _pageService.PushAsync(new PlaylistDetailsPage(playlist));


        }

    }
}
