using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication.Models
{
    public class Item
    {
        public int ItCode { get; set; } // Primary Key
        public string ItName { get; set; }
        public int ItPrice { get; set; }
        public int ItStock { get; set; }
        public string ItManufacturer { get; set; }




        public Item(int itemID, object itemName, Category category, object itemCount, object itemPrice, object description)
        {
            this.ItCode = (int)itemID;
            this.ItName = itemName as string;
            this.Category = category;
            this.ItPrice = (int)itemPrice;
            this.ItManufacturer = description as string;
        }

        public Item() { ItCode = 0; }

        // Foreign Key
        public int CatCode { get; set; }

        // Navigation Properties
        public Category Category { get; set; }
        public List<Billing> Billings { get; set; }
    }
}
