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
        public string name;
        public string img;
        public int cost;
        public double userRating;
        public string ratingURL;
        
        //int d;
        public ApartmentList2(string _name, string _img, int _cost, double _userRating, string _ratingURL)
        {
            this.name = _name;
            this.img = _img;
            this.cost = _cost;
            this.userRating = _userRating;
            this.ratingURL = _ratingURL;
        }
    }
}
