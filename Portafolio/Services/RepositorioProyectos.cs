using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositorioProyectos
    {
        List<ProyectoViewModel> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>() {
            new ProyectoViewModel
            {
                Titulo = "vTorke",
                Descripcion = "CRM realizado en ASP.NET Framework",
                Link = "http://ferreagro.ddns.net:2323/",
                ImagenURL = "/img/pgvTorke.png"
            },
            new ProyectoViewModel
            {
                Titulo = "Sitio Web Motorke",
                Descripcion = "Pagina web realizada con HTML",
                Link = "http://www.motorke.com.mx",
                ImagenURL = "/img/pgMotorke.png"
            },
            new ProyectoViewModel
            {
                Titulo = "E-Commerce realizado en PrestaShop",
                Descripcion = "Pagina web administrada con PrestaShop",
                Link = "http://www.torke.com.mx",
                ImagenURL = "/img/pgTorke.png"
            }
            };
        }
    }
}
