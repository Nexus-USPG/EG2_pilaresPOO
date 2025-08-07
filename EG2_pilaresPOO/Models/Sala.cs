namespace EG2_pilaresPOO.Models;
public abstract class Sala
{
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public string Ubicacion { get; set; }

    protected Sala(string nombre, int capacidad, string ubicacion)
    {
        Nombre = nombre;
        Capacidad = capacidad;
        Ubicacion = ubicacion;
    }

    public abstract bool Reservar(Evento evento);
}
