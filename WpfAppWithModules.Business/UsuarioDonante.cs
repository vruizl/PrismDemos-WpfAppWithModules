using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWithModules.Business
{
    public class UsuarioDonante : BusinessBase
    {
        public int Id { get; set; }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }

        }

        private string _tipoDonacion;
        public string TipoDonacion
        {
            get { return _tipoDonacion; }
            set { SetProperty(ref _tipoDonacion, value); }
        }
    }
}
