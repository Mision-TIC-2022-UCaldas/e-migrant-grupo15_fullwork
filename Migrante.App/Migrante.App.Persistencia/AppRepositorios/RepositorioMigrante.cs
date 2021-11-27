using Migrante.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Migrante.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private static AppContext _appContext;

        public RepositorioMigrante(AppContext appContext)
        {
            _appContext = appContext;
        }

        PersonaMigrante IRepositorioMigrante.AddMigrante(PersonaMigrante migrante)
        {
            
            var migranteAdicionado = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            //return PersonaMigranteAdicionado;
            return migranteAdicionado.Entity;
        }

        PersonaMigrante IRepositorioMigrante.UpdatePersonaMigrante(PersonaMigrante migrante)
        {
            
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.id == migrante.id);
            if (migranteEncontrado != null)
            {
                migranteEncontrado.nombre = migrante.nombre;
                migranteEncontrado.apellidos = migrante.apellidos;
                migranteEncontrado.tipoIdentificacion = migrante.tipoIdentificacion;
                migranteEncontrado.numeroDocumento = migrante.numeroDocumento;
                migranteEncontrado.pais  = migrante.pais ;
                migranteEncontrado.fechaNacimiento  = migrante.fechaNacimiento ;
                migranteEncontrado.direccionElectronica  = migrante.direccionElectronica ;
                migranteEncontrado.telefono   = migrante.telefono  ;
                migranteEncontrado.direccion  = migrante.direccion ;
                migranteEncontrado.ciudad  = migrante.ciudad ;
                migranteEncontrado.situacionLaboral   = migrante.situacionLaboral  ;

                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }

        void IRepositorioMigrante.DeletePersonaMigrante (int idPersonaMigrante)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.id == idPersonaMigrante);
            if (migranteEncontrado == null)
                return;
            _appContext.Migrantes.Remove(migranteEncontrado);
            _appContext.SaveChanges();
        }

        PersonaMigrante IRepositorioMigrante.GetPersonaMigrante(int idPersonaMigrante)
        {

            var PersonaMigranteEncontrado= _appContext.Migrantes.FirstOrDefault(p => p.id == idPersonaMigrante);
            return PersonaMigranteEncontrado;
        }

        IEnumerable<PersonaMigrante> IRepositorioMigrante.GetAllMigrantes()
        {
            return _appContext.Migrantes;
        }

    }
}