namespace EG2_pilaresPOO.Models;
public class Laboratorio : Sala
{
    public int NumeroDeComputadoras { get; set; }

    public Laboratorio(string nombre, int capacidad, string ubicacion, int numeroDeComputadoras) : base(nombre, capacidad, ubicacion)
    {
        NumeroDeComputadoras = numeroDeComputadoras;
    }

    public override bool Reservar(Evento evento)
    {
         
        return true;
    }
}
