using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModules.Business;

namespace WpfAppWithModules.Modules.Usuario.ViewModels
{
    public class UsuarioViewModel : BindableBase
    {
        private string _text = string.Empty;
       
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
        private UsuarioDonacion _usuario = new UsuarioDonacion();
        public UsuarioDonacion Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }

       
        public DelegateCommand AddUsuarioCommand { get; set; }

        public UsuarioViewModel()
        {
            AddUsuarioCommand = new DelegateCommand(Click);
          
        }

        private void Click()
        {
            Text = string.Format("Dado de alta el usuario: {0} con demanda: {1}", Usuario.Nombre, Usuario.TipoDemanda);
            //TODO: Limpiar los valores de los textboxes
        }
    }
}
