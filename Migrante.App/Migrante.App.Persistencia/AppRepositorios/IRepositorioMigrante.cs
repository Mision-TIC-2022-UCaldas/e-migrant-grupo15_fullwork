using System.Collections.Generic;
using Migrante.App.Dominio;

namespace Migrante.App.Persistencia
{
    public interface IRepositorioMigrante
    {
        //GetAllMigrantes
        IEnumerable<PersonaMigrante> GetAllMigrantes();
        //AddMigrante
        PersonaMigrante AddMigrante (PersonaMigrante migrante);
        //UpdateMigrante
        PersonaMigrante UpdatePersonaMigrante(PersonaMigrante migrante);
        //DeletePersonaMigrante
        void DeletePersonaMigrante(int idMigrante);
        //GetPersonaMigrante
        PersonaMigrante GetPersonaMigrante(int idMigrante);

        PersonaMigrante GetPersonaMigrante_docu(string DocuPersonaMigrante);
        
    }
}