using System;
using System.Collections.Generic;
using System.Text;
using WpfAppWithModules.Business;
using WpfAppWithModules.Services.Interfaces;

namespace WpfAppWithModules.Services
{
    public class UsuarioDonanteService : IUsuarioDonanteService
    {
        #region Crear datos (MOCK)
        //Lo utilizamos así porque no tenemos bdd/api/ws que nos proporcione los datos.
        static List<UsuarioDonante> UsuariosDonantes = new List<UsuarioDonante>()
        {
            //TODO: TipoDemanda enumerable
            new UsuarioDonante()
            {
                Id = 1,
                Nombre = "Usuario 1",
                TipoDonacion = "Comida"
            },

             new UsuarioDonante()
            {
                Id = 2,
                Nombre = "Usuario 2",
                TipoDonacion = "Productos limpieza"
            },

              new UsuarioDonante()
            {
                Id = 3,
                Nombre = "Usuario 3",
                TipoDonacion = "Ropa"
            }

        };
        #endregion

        public IList<UsuarioDonante> GetUsuarios()
        {
            return UsuariosDonantes;
        }
    }
}
