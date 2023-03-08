namespace Monitores_WebApp.Entities
{
    public class Monitors
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Frecuencia   { get; set; }
        public string Pulgadas { get; set; }
        public string Resolución { get; set; }
        public float Precio { get; set; }
        public bool Disponible { get; set; }
        public Pedidos pedidos { get; set; }

    }
}
