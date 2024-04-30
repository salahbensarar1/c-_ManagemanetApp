using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication.Models
{
    public class Category
    {
        public int CatCode { get; set; } // Primary Key
        public required string CatName { get; set; }
        public required List<Item> Items { get; set; }
        public Category(int catCode, string catName)
        {
            this.CatCode = catCode;
            this.CatName = catName;
        }

        public Category() { CatCode = 0; }

    }
}
