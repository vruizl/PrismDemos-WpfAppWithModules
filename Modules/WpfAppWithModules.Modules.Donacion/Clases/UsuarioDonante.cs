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

namespace WpfAppWithModules.Modules.Donacion.Clases
{
    public class UsuarioDonante : BindableBase

    {
       
        public UsuarioDonante(string nombre, string tipoDonacion)
        {
            _nombre = nombre;
            _tipoDonacion = tipoDonacion;
        }

        public UsuarioDonante()
        {

        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                SetProperty(ref _nombre, value);
            }
        }

        private string _tipoDonacion;
        public string TipoDonacion
        {
            get { return _tipoDonacion; }
            set
            {
                SetProperty(ref _tipoDonacion, value);
            }
        }




    }
}
