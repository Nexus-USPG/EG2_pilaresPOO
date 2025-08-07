namespace EG2_pilaresPOO.Models;
public class SalaComun : Sala
{
    public SalaComun(string nombre, int capacidad, string ubicacion) : base(nombre, capacidad, ubicacion) { }

    public override bool Reservar(Evento evento)
    {
         
        return true;
    }
}
