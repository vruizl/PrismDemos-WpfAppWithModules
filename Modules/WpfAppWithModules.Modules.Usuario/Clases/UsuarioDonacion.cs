using Prism.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WpfAppWithModules.Modules.Usuario.Clases
{
    public class UsuarioDonacion : BindableBase

    {
        //public enum TipoNecesidad  { Comida, Ropa, Productos_limpieza, Otros}; 
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                SetProperty(ref _nombre, value);
            }
        }

        private string _tipoDemanda;
        public string TipoDemanda
        {
            get { return _tipoDemanda; }
            set
            {
                SetProperty(ref _tipoDemanda, value);
            }
        }

       

       
    }
}

