using System;
namespace Migrante.App.Dominio
{
    public enum EstadoSolicitud
    {
        En_espera,
        Autorizado,
        Activo,
        Rechazado_Por_Migrante,
        Cancelado,
        Negado_Por_Entidad
    }
}
