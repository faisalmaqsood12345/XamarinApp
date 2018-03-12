using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDemo : ContentPage
	{
		public ListDemo ()
		{
			InitializeComponent ();

		    listView.ItemsSource = GetContacts();
		}

	    private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var contact = e.Item as Contact;
	        DisplayAlert("Tapped", contact.Name, "Ok");
	        
	    }

	    private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	      //  var contact = e.SelectedItem as Contact;
	     //   DisplayAlert("Select", contact.Name, "Ok");
	        listView.SelectedItem = null;
	    }

	    private void Handle_Refreshing(object sender, EventArgs e)
	    {
	        listView.ItemsSource = GetContacts();
	        listView.EndRefresh();

	    }

	    IEnumerable<Contact> GetContacts(string searchText = null)
	    {
	      var contacts =  new List<Contact>
	        {
	            new Contact {Name = "Faisal", ImageUrl = "http://lorempixel.com/100/100/people/1"},
	            new Contact {Name = "Jon", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, Lets Talk"}
            };
            if
               ( String.IsNullOrWhiteSpace(searchText))
	        {
	            return contacts;
            }
	        return contacts.Where(c => c.Name.StartsWith(searchText));
	    }

	    private void Handle_TextChanged(object sender, TextChangedEventArgs e)
	    {
	       listView.ItemsSource = GetContacts(e.NewTextValue);


	    }
	}
}