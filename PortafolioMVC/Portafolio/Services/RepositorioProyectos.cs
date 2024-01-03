using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Services
{
    public class RepositorioProyectos : IRepositorioProyecto
    {

        public List<Proyecto> ObtenerProyectos() 
        {
            return new List<Proyecto>()
            {

                    new Proyecto
                    {
                        Titulo= "Zona Franca",
                        Descripcion ="Un proyecto para Zona Franca Santander para registro de asistencias",
                        Imagen= "../Images/zonaFranca.jpg",
                        Url = "https://www.zonafrancasantander.com"

                    },
                    new Proyecto
                    {
                        Titulo = "Envia",
                        Descripcion = "Un Backend completo para la empresa de Envia",
                        Imagen ="../Images/ENVIA.png",
                        Url="https://github.com/Luiscvj/PushUpBackendEnvia.LuisCarlosVillan"
                    }

            };
                
        }
    }
}
