using Not_Defteri.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Not_Defteri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentsPage : ContentPage
    {

        public ContentsPage()
        {
            InitializeComponent();
        }


        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Content>();
                var contents = conn.Table<Content>().OrderByDescending(x => x.Id).ToList();
                contentListiew.ItemsSource = contents;
            }
        }
        private void ClickMe_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}