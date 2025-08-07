namespace EG2_pilaresPOO.Models;
public class Evento
{
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public string Tipo { get; set; }
    private string ContactoOrganizador { get; set; }

    public Evento(string nombre, DateTime fecha, string tipo, string contactoOrganizador)
    {
        Nombre = nombre;
        Fecha = fecha;
        Tipo = tipo;
        ContactoOrganizador = contactoOrganizador;
    }
}
