using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Migrante.App.Dominio
{
    public class Entidad
    {
        public int id {get;set;}
        
        [Required]
        [MaxLength(50)]
        public string razonSocial {get;set;}

        [Required]
        [MaxLength(50)]
        public string NIT {get;set;}

        [Required]
        [MaxLength(50)]
        public string direccion {get;set;}
        [Required]
        [MaxLength(50)]
        public string ciudad {get;set;}

        [Required]
        [MaxLength(50)]
        public string telefono {get;set;}

        public Sector sector {get;set;}

        public TipoServicio tipoServicio {get;set;}
    }
}