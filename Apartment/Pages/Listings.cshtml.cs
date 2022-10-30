using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apartment.Pages
{
    public class Index1Model : PageModel
    {
        public void OnGet()
        {
        }
    }

    public class ApartmentList2
    {
        public string img;
        public int cost;
        public double userRating;
        //int d;
        public ApartmentList2(string _img, int _cost, double _userRating)
        {
            this.img = _img;
            this.cost = _cost;
            this.userRating = _userRating;
        }
    }
}
