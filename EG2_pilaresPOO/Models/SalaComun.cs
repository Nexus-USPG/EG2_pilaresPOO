namespace EG2_pilaresPOO.Models;
public class SalaComun : Sala
{
    public int Mesas { get; set; } = 10;
    public int Sillas { get; set; } = 20;
    public bool TieneCanon { get; set; } = true;
    public bool TienePizarron { get; set; } = true;
    public bool TieneAireAcondicionado { get; set; } = true;
    public SalaComun(string nombre, int capacidad, string ubicacion) : base(nombre, capacidad, ubicacion) { }

    public override bool Reservar(Evento evento)
    {
        int hora = evento.Fecha.Hour;

        if (hora >= 8 && hora <= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
