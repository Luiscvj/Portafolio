namespace Portafolio.Models
{
    public class TiempoServicio
    {
    public Guid ObtenerGuid {  get; private set; }
        public TiempoServicio()
           {

                  ObtenerGuid = Guid.NewGuid();
           }
    }

}
