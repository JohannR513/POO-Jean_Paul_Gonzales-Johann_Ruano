using System;
using FachadaUniversidad.Reservas;

namespace Fachada_Universidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservar fachadaUniversidad = new Reservar();
            fachadaUniversidad.SaludarCliente();
        }
    }
}
