using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class item
    {
        int id;

        int price;
        string item_name;
        string description;
        int stock_number;
        string remarks;
        string subcategory_id;
        string subcategory_name;
        string brief_details;
        sub_category subcategory;
        public item(int id, int price, string item_name, string description, int stock_number, string remarke, sub_category sb)
        {
            this.id = id;
            this.price = price;
            this.item_name = item_name;
            this.description = description;
            this.stock_number = stock_number;
            this.remarks = remarke;
            this.subcategory = sb;
        }
    }
}
