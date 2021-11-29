using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Migrante.App.Dominio
{
    public class Novedad
    {
        public int id {get;set;}
        
        [Required]
        [MaxLength(10)]
        public string Fecha {get;set;}

        [Required]
        public int DiasValidez {get;set;}

        [Required]
        [MaxLength(500)]
        public string TextoExplica {get;set;}
    }
}