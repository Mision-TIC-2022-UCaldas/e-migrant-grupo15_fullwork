using Migrante.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Migrante.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {
        private static AppContext _appContext;

        public RepositorioEntidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        Entidad IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
            
            var entidadAdicionado = _appContext.Entidad.Add(entidad);
            _appContext.SaveChanges();
            
            return entidadAdicionado.Entity;
        }

       Entidad IRepositorioEntidad.UpdateEntidad(Entidad entidad)
        {
            
            var entidadEncontrado = _appContext.Entidad.FirstOrDefault(p => p.id == entidad.id);
            if (entidadEncontrado != null)
            {
                entidadEncontrado.razonSocial = entidad.razonSocial;
                entidadEncontrado.NIT=entidad.NIT;
                entidadEncontrado.direccion=entidad.direccion;
                entidadEncontrado.ciudad=entidad.ciudad;
                entidadEncontrado.telefono=entidad.telefono;
                entidadEncontrado.sector=entidad.sector;
                entidadEncontrado.tipoServicio=entidad.tipoServicio;
                
                
               

                _appContext.SaveChanges();
            }
            return entidadEncontrado;
        }

        void IRepositorioEntidad.DeleteEntidad (int idEntidad)
        {
            var entidadEncontrado = _appContext.Entidad.FirstOrDefault(p => p.id == idEntidad);
            if (entidadEncontrado == null)
                return;
            _appContext.Entidad.Remove(entidadEncontrado);
            _appContext.SaveChanges();
        }

        Entidad IRepositorioEntidad.GetEntidad(int idEntidad)
        {

            var EntidadEncontrado= _appContext.Entidad.FirstOrDefault(p => p.id == idEntidad);
            return EntidadEncontrado;
        }

        Entidad IRepositorioEntidad.GetEntidad_NIT(string idEntidad)
        {

            var EntidadEncontrado= _appContext.Entidad.FirstOrDefault(p => p.NIT == idEntidad);
            return EntidadEncontrado;
        }

        IEnumerable<Entidad> IRepositorioEntidad.GetAllEntidad()
        {
            return _appContext.Entidad;
        }

    }
}