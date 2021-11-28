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
    public class consultarModel : PageModel
    {
/*
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());

        public PersonaMigrante personaMigrante { get; set; }
*/
        public string docu = "Nueva cadena";

        //Este es el objeto recibido del formulario que llama la pagina
        public class DatosRecibidos
        {
            public string NumDocu {get; set;}

        } //Se pueden Agregar los string que correspondan para cada campo del formulario

        //IActionResult
        public void OnGet(DatosRecibidos DatosGet)
        {
            Console.WriteLine("Dentro del OnGet");
            docu = DatosGet.NumDocu;
            Console.WriteLine(docu);
            Console.WriteLine(value: "datos.NumDocu" + DatosGet.NumDocu );
            
            /*
            personaMigrante = _repoMigrante.GetPersonaMigrante_docu(DatosGet.NumDocu);
            Console.WriteLine(personaMigrante.nombre);
            Console.WriteLine(personaMigrante.apellidos);
            Console.WriteLine(personaMigrante.numeroDocumento);
*/
            /*
            if(personaMigrante.id == null)
             {
                 Console.Write("personaMigrante es null");
                 //return RedirectToPage("/Index");

             }
             else
             {
                 Console.WriteLine(personaMigrante.nombre);
                 Console.WriteLine(personaMigrante.apellidos);
                 Console.WriteLine(personaMigrante.numeroDocumento);
                 //Console.WriteLine(personaMigrante.nombre );

             }
             */
           
        }
    }
}


