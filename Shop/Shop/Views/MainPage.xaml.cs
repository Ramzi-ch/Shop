using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Shop.Model;

namespace Shop
{
	public partial class MainPage : ContentPage
	{
        List<ShopModel> ListShop;
        List<ProductPair> PairListShop;
        
        public MainPage()
		{
			InitializeComponent();
            PairListShop = new List<ProductPair>
            {
                new ProductPair (new ShopModel{Type="ALMOST NEW", Image="glasses.png", Title="BROWNIE HIP SUN GLASSES", Price="770.00 SAR",Categorie="Accessoreis"},
                                new ShopModel {Type="ACCEPTABLE", Image="holder.png", Title="BROWNIE GLASSES HOLDER", Price="220.00 SAR",Categorie="Accessoreis"} ),
                new ProductPair (new ShopModel{Type="NEW", Image="handbag.png", Title="HANDBAG NATURAL LEATHER", Price="770.00 SAR",Categorie="Bags"},
                                new ShopModel {Type="ALMOST NEW", Image="handwatch.png", Title="CONCORD HANDWATCH", Price="3000.00 SAR",Categorie="Accessoreis"} ),
                new ProductPair (new ShopModel{Type="ALMOST NEW", Image="shoes.png", Title="EVENING SHOES HIGH HEAL", Price="200.00 SAR",Categorie="Shoes"},
                                new ShopModel {Type="ALMOST NEW", Image="Leather.png", Title="BELT NATURAL LEATHER", Price="100.00 SAR",Categorie="Accessoreis"} ),
            };
            List1.ItemsSource = PairListShop;

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            ListShop = new List<ShopModel>();
            List<ProductPair> ResultList = new List<ProductPair>();

            if (sender.Equals(Travel))
            {
                
                Travel.TextColor = Color.White;
                Shoes.TextColor = Color.Gray;
                Bags.TextColor = Color.Gray;
                Accessoreis.TextColor = Color.Gray;
                Travel.FontSize = 24;
                Shoes.FontSize = 18;
                Bags.FontSize = 18;
                Accessoreis.FontSize = 18;
                foreach (ProductPair pp in PairListShop)
                {
                    if (pp.Item1.Categorie.Equals("Travel"))
                    {
                        ListShop.Add(pp.Item1);
                    }
                    if (pp.Item2.Categorie.Equals("Travel"))
                    {
                        ListShop.Add(pp.Item2);
                    }
                }
                for (int i = 0; i < ListShop.Count; i = i + 1)
                {
                    if (i < ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], ListShop[i + 1]);
                        ResultList.Add(pp);
                    }
                    else if (i == ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], null);
                        ResultList.Add(pp);
                    }
                }
            }
            if (sender.Equals(Shoes))
            {
                //ListShop = new List<ShopModel>();
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.White;
                Bags.TextColor = Color.Gray;
                Accessoreis.TextColor = Color.Gray;
                Travel.FontSize = 18;
                Shoes.FontSize = 24;
                Bags.FontSize = 18;
                Accessoreis.FontSize = 18;
                foreach (ProductPair pp in PairListShop)
                {
                    if (pp.Item1.Categorie.Equals("Shoes"))
                    {
                        ListShop.Add(pp.Item1);
                    }
                    if (pp.Item2.Categorie.Equals("Shoes"))
                    {
                        ListShop.Add(pp.Item2);
                    }
                }
                
                for (int i = 0; i < ListShop.Count; i = i + 1)
                {
                    if (i < ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], ListShop[i + 1]);
                        ResultList.Add(pp);
                    }
                    else if (i == ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], null);
                        ResultList.Add(pp);
                    }
                }
            }
            if (sender.Equals(Bags))
            {
                //ListShop = new List<ShopModel>();
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.Gray;
                Bags.TextColor = Color.White;
                Accessoreis.TextColor = Color.Gray;

                Travel.FontSize = 18;
                Shoes.FontSize = 18;
                Bags.FontSize = 24;
                Accessoreis.FontSize = 18;
                foreach (ProductPair pp in PairListShop)
                {
                    if (pp.Item1.Categorie.Equals("Bags"))
                    {
                        ListShop.Add(pp.Item1);
                    }
                    if (pp.Item2.Categorie.Equals("Bags"))
                    {
                        ListShop.Add(pp.Item2);
                    }
                }
               
                for (int i = 0; i < ListShop.Count; i = i + 1)
                {
                    if (i < ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], ListShop[i + 1]);
                        ResultList.Add(pp);
                    }
                    else if (i == ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], null);
                        ResultList.Add(pp);
                    }
                }
            }

            if (sender.Equals(Accessoreis))
            {
                //ListShop = new List<ShopModel>();
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.White;
                Bags.TextColor = Color.Gray;
                Accessoreis.TextColor = Color.Gray;
                Travel.FontSize = 18;
                Shoes.FontSize = 24;
                Bags.FontSize = 18;
                Accessoreis.FontSize = 18;
                foreach (ProductPair pp in PairListShop)
                {
                    if (pp.Item1.Categorie.Equals("Accessoreis"))
                    {
                        ListShop.Add(pp.Item1);
                    }
                    if (pp.Item2.Categorie.Equals("Accessoreis"))
                    {
                        ListShop.Add(pp.Item2);
                    }
                }

                for (int i = 0; i < ListShop.Count; i = i + 1)
                {
                    if (i < ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], ListShop[i + 1]);
                        ResultList.Add(pp);
                    }
                    else if (i == ListShop.Count - 1)
                    {
                        ProductPair pp = new ProductPair(ListShop[i], null);
                        ResultList.Add(pp);
                    }
                }
            }
            List1.ItemsSource = ResultList;

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //thats all you need to make a search  

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                List1.ItemsSource = PairListShop;
            }

            else
            {
                List1.ItemsSource = PairListShop.Where(x => x.Item1.Title.ToLower().StartsWith(e.NewTextValue.ToLower()));
            }
        }
    }
}
