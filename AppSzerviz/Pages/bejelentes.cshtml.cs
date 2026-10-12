using AppSzerviz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;

namespace AppSzerviz.Pages
{
    public class bejelentesModel : PageModel
    {
        public Context cont { get; }

        public void OnGet()
        {
        }

        public bejelentesModel(Context con)
        {
            cont = con;
        }
        public void OnPost(Bejelentes b) 
        {
            Console.WriteLine($"{b.BejelentoNeve} ");
            b.BejelentesDatuma = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return;
            }
            cont.Bejelentesek.Add(b);
            cont.SaveChanges();

        }
    }
}
