using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Migrante.App.Dominio
{
    public class PersonaMigrante
    {
        public int id {get;set;}
        
        [Required]
        [MaxLength(50)]
        public string nombre {get;set;}

        [Required]
        [MaxLength(50)]
        public string apellidos {get;set;}

        [Required]
        public TipoIdentificacion tipoIdentificacion {get;set;}

        [Required]
        [MaxLength(50)]
        public string numeroDocumento {get;set;}

        [Required]
        [MaxLength(50)]
        public string pais {get;set;}

        [Required]
        public DateTime fechaNacimiento {get;set;}
        
        [MaxLength(100)]
        public string direccionElectronica {get;set;}

        public string telefono {get;set;}

        [MaxLength(100)]
        public string direccion {get;set;}

        public string ciudad {get;set;}
        
        public SituacionLaboral situacionLaboral {get;set;}
    }
}