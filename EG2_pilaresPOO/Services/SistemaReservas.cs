using System.Collections.Generic;
//using ProyectoReservas.Models;
namespace EG2_pilaresPOO.Models;

public class SistemaReservas
{
    private List<Sala> salas = new List<Sala>();

    public void AgregarSala(Sala sala)
    {
        salas.Add(sala);
    }

    public void ListarReservas()
    {
        foreach (var sala in salas)
        {
            Console.WriteLine(`Sala: {sala.Nombre}, Tipo: {sala.GetType().Name}`);
        }
    }
}
