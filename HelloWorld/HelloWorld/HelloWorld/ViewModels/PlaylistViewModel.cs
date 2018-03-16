﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
    public class PlaylistViewModel : BaseViewModel
    {


        public string Title { get; set; }

        private bool _isFavorite;

        public bool IsFavorite
        {
            get { return _isFavorite; }
            set { SetValue(ref _isFavorite, value); OnPropertyChanged(nameof(Color)); }

        }


        public Color Color
        {
            get { return IsFavorite ? Color.Pink : Color.Black; }
        }


    }
}
