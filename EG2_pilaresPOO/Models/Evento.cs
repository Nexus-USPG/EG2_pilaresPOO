namespace EG2_pilaresPOO.Models;
public class Evento
{
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; } //podes dejarlo como datetime o dejarlo como un int, validar que sea superior a >0
    public string Tipo { get; set; }
    private string ContactoOrganizador { get; set; }
    public int Capacidad { get; internal set; }

    public Evento(string nombre, DateTime fecha, string tipo, string contactoOrganizador)
    {
        Nombre = nombre; // que no sea nulo o espacios
        Fecha = fecha; // Validar que la fecha tenga un buen formato
        Tipo = tipo; //Validar que el evento solo sea academico o extracurricular
        ContactoOrganizador = contactoOrganizador; // que no sea nulo o espacios
    }
}
