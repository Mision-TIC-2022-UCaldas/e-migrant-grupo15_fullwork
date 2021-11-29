using System.Collections.Generic;
using Migrante.App.Dominio;

namespace Migrante.App.Persistencia
{
    public interface IRepositorioEntidad
    {
        //GetAllMigrantes
        IEnumerable<Entidad> GetAllEntidad();
        //AddMigrante
        Entidad  AddEntidad (Entidad entidad);
        //UpdateMigrante
        Entidad  UpdateEntidad(Entidad entidad);
        //DeletePersonaMigrante
        void DeleteEntidad(int idEntidad);
        //GetPersonaMigrante
        Entidad GetEntidad(int idEntidad);

        Entidad GetEntidad_NIT(string idEntidad);
        
    }
}