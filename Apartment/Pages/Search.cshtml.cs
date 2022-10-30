using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apartment.Pages
{
    public class SearchModel
    {
        public double Rating;
        public int MinCost;
        public int MaxCost;
        public bool HasViolations;
        public int Zipcode;
        public bool PetsAllowed;
        public int b;

        public SearchModel(int _MinCost)
        {
            MinCost = _MinCost;
        }

        public void OnGet()
        {
        }
    }
}
