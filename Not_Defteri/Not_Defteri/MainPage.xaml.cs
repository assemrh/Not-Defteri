using Not_Defteri.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Not_Defteri
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Savebtn_Clicked(object sender, EventArgs e)
        {
            Content content = new Content()
            {
                Baslik = baslikEntry.Text,
                Icerik = icerikEditor.Text,
                Kategori = kategoriEntry.Text,
                EklemeTarihi = DateTime.Now.ToString()
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Content>();
                conn.Insert(content);
            }
    }

    private void Canclebtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
