using System;
using persistencia;
using dominio;

namespace aplicacion
{
    class Program
    {
        private static IRepositorio_Personas _repo=new Repositorio_Personas(new ApplicationContext());
        private static IRepositorio_cliente _repoc=new Repositorio_cliente(new ApplicationContext());
        static void Main(string[] args)
        {
          /*  Persona p1 =new Persona();
            p1.Nombre="Camila";
            p1.Apellido="fff";
            p1.Direccion="dssff";
            p1.Email="rttttt";
            _repo.Add(p1);

            Cliente c1=new Cliente();
            c1.Ciudad="Bogota";
            c1.FechaIngreso="12/08/22";
            c1.TipoVehiculo="Carro";
            
            _repoc.Add(c1);
            //_repo.Update(p1);
            //_repo.Delete(3);
            //_repo.GetAll();*/
            



        }
    }
}
