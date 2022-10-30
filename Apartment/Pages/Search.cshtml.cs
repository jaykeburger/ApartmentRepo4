using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apartment.Pages
{
    public class SearchModel : PageModel
    {
        double Rating;
        int MinCost;
        int MaxCost;
        bool HasViolations;
        int Zipcode;
        bool PetsAllowed;
        int b;

        public void OnGet()
        {
        }
    }
}
