using System;
using persistencia;
using dominio;

namespace aplicacion
{
    class Program
    {
        private static IRepositorio_Personas _repo=new Repositorio_Personas(new ApplicationContext());
        static void Main(string[] args)
        {
            Persona p1 =new Persona();
            p1.Nombre="Camila";
            _repo.Add(p1);
            //_repo.Update(p1);
            //_repo.Delete(3);
            //_repo.GetAll();
            



        }
    }
}
