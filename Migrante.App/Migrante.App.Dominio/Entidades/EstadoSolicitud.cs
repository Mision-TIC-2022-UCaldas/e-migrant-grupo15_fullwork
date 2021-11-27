using System;
namespace Migrante.App.Dominio
{
    public enum EstadoSolicitud
    {
        En espera,
        Autorizado,
        Activo,
        Rechazado Por Migrante,
        Cancelado,
        Negado Por Entidad
    }
}
