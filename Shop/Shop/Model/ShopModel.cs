using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Model
{
    public class ShopModel
    {
        public String Type { get; set; }
        public String Image { get; set; }
        public String Title { get; set; }
        public String Price { get; set; }
        public bool IsVisible { get; set; }
        public String Categorie { get; set; }
    }

    public class ProductPair : Tuple<ShopModel, ShopModel>
    {
        public ProductPair(ShopModel item1, ShopModel item2)
            : base(item1, item2 ?? CreateEmptyModel()) { }

        private static ShopModel CreateEmptyModel()
        {
            return new ShopModel { IsVisible = false };
        }
    }

}
