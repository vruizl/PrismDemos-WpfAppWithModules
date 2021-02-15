using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWithModules.Business
{
    public class UsuarioDonacion : BusinessBase
    {
        public int Id {get;set;}

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }

        }

        private string _tipoDemanda;
        public string TipoDemanda
        {
            get { return _tipoDemanda; }
            set { SetProperty(ref _tipoDemanda, value); }
        }

    }
}
