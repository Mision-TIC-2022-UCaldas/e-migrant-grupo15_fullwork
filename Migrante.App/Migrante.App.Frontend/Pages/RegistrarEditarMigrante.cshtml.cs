using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrante.App.Persistencia;
using Migrante.App.Dominio;

namespace Migrante.App.Frontend.Pages
{
    public class RegistrarEditarMigranteModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());
        [BindProperty]

        public PersonaMigrante migrante{get;set;}
        
        public IActionResult OnGet(int? idPersonaMigrante)
        {
            if(idPersonaMigrante.HasValue)
            {
                migrante = _repoMigrante.GetPersonaMigrante(idPersonaMigrante.Value);

            }
            else
            {
                migrante = new PersonaMigrante();
            }

            if(migrante == null)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
           
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();                
            }else{
                if(migrante.id>0)
                {
                    migrante = _repoMigrante.UpdatePersonaMigrante(migrante);
                }else{
                     _repoMigrante.AddMigrante(migrante);
                }
                return RedirectToPage("/Index");
            }
        }
    }
}
