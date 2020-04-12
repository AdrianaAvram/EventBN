using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EventBN.Models;

namespace EventBN
{
    
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var account = App.DBUtil.GetAllEvent();
            MyListView.ItemsSource = account;
           
 
            
        }

    }
}
