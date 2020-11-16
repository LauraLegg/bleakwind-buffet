/*
 * Author: Laura Legg
 * Class name Index.cshtml.cs
 * Purpose: Represents the index page of the website
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The menu after filters are applied
        /// </summary>
        public IEnumerable<IOrderItem> MenuResults { get; set; }

        /// <summary>
        /// All of the entrees in MenuResults
        /// </summary>
        public IEnumerable<IOrderItem> EntreeItems { get; set; }

        /// <summary>
        /// All of the drinks in MenuResults
        /// </summary>
        public IEnumerable<IOrderItem> DrinkItems { get; set; }

        /// <summary>
        /// All of the sides in MenuResults
        /// </summary>
        public IEnumerable<IOrderItem> SideItems { get; set; }

        /// <summary>
        /// The term(s) typed into the search bar 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The categories that were checked
        /// </summary>
        public string[] Categories { get; set; }

        /// <summary>
        /// The max price entered by the user
        /// </summary>
        [BindProperty]
        public double PriceMax { get; set; }

        /// <summary>
        /// The min price entered by the user
        /// </summary>
        [BindProperty]
        public double PriceMin { get; set; }

        /// <summary>
        /// The min calories entered by the user
        /// </summary>
        [BindProperty]
        public double CalorieMin { get; set; }

        /// <summary>
        /// The min calories entered by the user
        /// </summary>
        [BindProperty]
        public double CalorieMax { get; set; }

        /// <summary>
        /// The OnGet method
        /// </summary>
        /// <param name="PriceMin">the min price</param>
        /// <param name="PriceMax">the max price</param>
        /// <param name="CalorieMin">the min caloires</param>
        /// <param name="CalorieMax">the max calories</param>
        public void OnGet(double PriceMin, double PriceMax, double CalorieMin, double CalorieMax)
        {
            SearchTerms = Request.Query["SearchItems"];
            Categories = Request.Query["Categories"];

            MenuResults = Menu.FullMenu();
            //Search bar
            if (SearchTerms != null)
            {
                MenuResults = MenuResults.Where(item =>
                item != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            //Filter By Categories
            if (Categories != null && Categories.Length > 0)
            {
                var results = new List<IOrderItem>();
                if (Categories.Contains("Entree"))
                {
                    foreach (IOrderItem item in MenuResults.Where(item => item != null && item is Entree))
                    {
                        results.Add(item);
                    }
                }
                if (Categories.Contains("Drink"))
                {
                    foreach (IOrderItem item in MenuResults.Where(item => item != null && item is Drink))
                    {
                        results.Add(item);
                    }
                }
                if (Categories.Contains("Side"))
                {
                    foreach (IOrderItem item in MenuResults.Where(item => item != null && item is Side))
                    {
                        results.Add(item);
                    };
                }
                MenuResults = results;
            }
            //Filter By Price
            MenuResults = Menu.FilterByPrice(MenuResults, PriceMin, PriceMax);
            //Filter By Calories
            MenuResults = Menu.FilterByCalories(MenuResults, CalorieMin, CalorieMax);
            Organize();
        }

        /// <summary>
        /// Helper method for organizing MenuResults into the three categories
        /// </summary>
        private void Organize()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            List<IOrderItem> drinks = new List<IOrderItem>();
            List<IOrderItem> sides = new List<IOrderItem>();

            foreach (IOrderItem item in MenuResults)
            {
                if (item is Entree) entrees.Add(item);
                if (item is Drink) drinks.Add(item);
                if (item is Side) sides.Add(item);
            }

            EntreeItems = entrees;
            DrinkItems = drinks;
            SideItems = sides;
        }
    }
}
