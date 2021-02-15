using System;
using System.Collections.Generic;
using System.Text;
using WpfAppWithModules.Business;
using WpfAppWithModules.Services.Interfaces;
using System.Collections.ObjectModel;

namespace WpfAppWithModules.Services
{
    public class UsuarioDonacionService:IUsuarioDonacionService
    {
        #region Crear datos (MOCK)
        //Lo utilizamos así porque no tenemos bdd/api/ws que nos proporcione los datos.
        static List<UsuarioDonacion> UsuariosDonacion = new List<UsuarioDonacion>()
        {
            //TODO: TipoDemanda enumerable
            new UsuarioDonacion()
            {
                Id = 1,
                Nombre = "Usuario 1",
                TipoDemanda = "Comida"
            },

             new UsuarioDonacion()
            {
                Id = 2,
                Nombre = "Usuario 2",
                TipoDemanda = "Productos limpieza"
            },

              new UsuarioDonacion()
            {
                Id = 3,
                Nombre = "Usuario 3",
                TipoDemanda = "Ropa"
            }

        };
        #endregion

        public IList<UsuarioDonacion> GetUsuarios()
        {
            return UsuariosDonacion;
        }
 
    }
}
