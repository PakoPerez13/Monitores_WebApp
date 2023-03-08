using Microsoft.VisualBasic;

namespace Monitores_WebApp.Entities
{
    public class Pedidos
    {
        public int id { get; set; }
        public int id_Monitor { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public string Descripcion { get; set; }
        public List<Monitors> monitores { get; set; }
    }
}
