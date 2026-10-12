using AppSzerviz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppSzerviz.Pages
{
    public class bejelentesekModel : PageModel
    {
        public Context cont { get; }

        public void OnGet()
        {
        }

        public bejelentesekModel(Context con)
        {
            cont = con;
        }
    }
}
