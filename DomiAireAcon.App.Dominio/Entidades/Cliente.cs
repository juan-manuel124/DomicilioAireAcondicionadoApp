namespace DomiAireAcon.App.Dominio
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; }
        public string TipoServisio { get; set; }
        public string Nombre { get; set; }
        public bool Membresia { get; set; }
        public datetime DiaCita { get; set; }
    }
}
