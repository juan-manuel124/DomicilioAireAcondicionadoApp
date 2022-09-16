namespace DomiAireAcon.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTel { get; set; }
        public Genero Genero { get; set; }
    }
}
