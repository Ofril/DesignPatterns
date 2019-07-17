using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hamburger
    {

        private Dictionary<String, String> ingredients = new Dictionary<String, String>();

        public Hamburger()
        {

            // prepareBun
            // prepareVegg
            // prepareMain
            // prepareTopping		
            // preparePriceLabel	
        }

        public void PrepareBun(String vegg)
        {
            ingredients.Add("Bun", vegg);
        }

        public void PrepareVegg(String vegg)
        {
            ingredients.Add("Vegg", vegg);
        }

        public void PrepareMain(String main)
        {
            ingredients.Add("Main", main);
        }

        public void PrepareTopping(String topping)
        {
            ingredients.Add("Topping", topping);
        }

        public void PreparePriceLabel(String price)
        {
            ingredients.Add("Price", price);
        }

        public string ToString()
        {
            string hamb = "Hamburger with \n";

            foreach (KeyValuePair<string, string> ingredient in ingredients)
            {
                hamb += " " + ingredient.Key + ": " + ingredient.Value + '\n'; 
            }

            return hamb;
        }
    }
}
