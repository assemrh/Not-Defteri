using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Not_Defteri.Classes
{
    [Table("Notlar")]
    class Content
    {
        [PrimaryKey, AutoIncrement,Column("No")]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Kategori { get; set; }
        public string EklemeTarihi { get; set; }
        public string GuncellemeTarihi { get; set; }

    }
}
