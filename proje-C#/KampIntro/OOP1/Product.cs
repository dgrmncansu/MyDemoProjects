using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet: hazır kodlar
    class Product //Entity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
      //ürünün adı
        public string ProductName { get; set; }
     //ürünün birim fiyatı
        public double UnitPrice { get; set; }
     //ürünün stok adedi
        public int UnitsInStock { get; set; }


        //CRUD
       // EKLEMEK-OKUMAK-GÜNCELLEMEK-SİLMEK_LİSTELEMEK
    }
}