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
        if (evento.Tipo.ToUpper() == "ACADEMICO" || evento.Tipo.ToUpper() == "EXTRACURRICULAR")
        {
            if (evento.Capacidad <= Capacidad)
            {
                Console.WriteLine($"Laboratorio {Nombre} reservado para el evento {evento.Nombre}.");

                if (NumeroDeComputadoras > 0)
                {
                    Console.WriteLine($"Se le asignaran {NumeroDeComputadoras} para el evento");
                }else
                {
                    Console.WriteLine($"Al laboratorio {Nombre} no se le asiganaran computadoras.");
                }

                return true;
            }
            else
            {
                Console.WriteLine($"No se puede reservar el laboratorio {Nombre} para el evento {evento.Nombre} debido a la capacidad excedida.");
                return false;
            }
        }
        else
        {
            Console.WriteLine($"El laboratorio {Nombre} solo puede ser reservado para evento académico o extracurricular.");
            return false;
        }

    }
}
    