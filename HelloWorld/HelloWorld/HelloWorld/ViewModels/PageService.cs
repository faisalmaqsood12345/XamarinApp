﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
   public class PageService : IPageService
    {
        public async Task PushAsync(Page page)
        {
          await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }
    }
}
