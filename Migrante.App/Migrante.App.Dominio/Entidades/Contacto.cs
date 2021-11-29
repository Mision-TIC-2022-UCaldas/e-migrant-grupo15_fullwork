
namespace Migrante.App.Dominio
{
    public class Contacto
    {
        public int id {get;set;}
        
        public int id_migrante {get;set;}

        public int id_contactado {get;set;}

        public TipoContacto tipoContacto {get;set;}

    }
}