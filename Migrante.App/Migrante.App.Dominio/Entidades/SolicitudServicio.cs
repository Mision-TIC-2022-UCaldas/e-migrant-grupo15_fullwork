
namespace Migrante.App.Dominio
{
    public class SolicitudServicio
    {
        public int id {get;set;}
        public int id_migrante {get;set;}
        
        public string fecha {get;set;}

        public TipoServicio tipoServicio {get;set;}

        public EstadoSolicitud estadoSolicitud {get;set;}

        public String Descripcion {get;set;}

    }
}