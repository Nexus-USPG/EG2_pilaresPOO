public class Auditorio : Sala
{
    public bool TieneEquipoDeSonido { get; set; }

    public Auditorio(string nombre, int capacidad, string ubicacion, bool tieneEquipoDeSonido) : base(nombre, capacidad, ubicacion)
    {
        TieneEquipoDeSonido = tieneEquipoDeSonido;
    }

    public override bool Reservar(Evento evento)
    {
        // Implementación específica
        return true;
    }
}
