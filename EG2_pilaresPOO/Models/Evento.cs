namespace EG2_pilaresPOO.Models;
public class Evento
{
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; } 
    public string Tipo { get; set; }
    private string ContactoOrganizador { get; set; }
    public int Capacidad { get; internal set; }

    public Evento(string nombre, DateTime fecha, string tipo, string contactoOrganizador)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío");

        if (fecha == default || fecha < DateTime.Today)
            throw new ArgumentException("La fecha tiene que ser válida ");

        string tipoLower = tipo.ToLower();
        if (tipoLower != "academico" && tipoLower != "extracurricular")
            throw new ArgumentException("El tipo de evento debe ser 'academico' o 'extracurricular'");

        if (string.IsNullOrWhiteSpace(contactoOrganizador))
            throw new ArgumentException("El contacto del organizador no puede estar vacío.");

        Nombre = nombre; 
        Fecha = fecha; 
        Tipo = tipo; 
        ContactoOrganizador = contactoOrganizador; 
    }
}
