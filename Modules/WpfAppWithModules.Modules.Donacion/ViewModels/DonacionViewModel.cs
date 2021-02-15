using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModules.Business;

namespace WpfAppWithModules.Modules.Donacion.ViewModels
{
    public class DonacionViewModel : BindableBase
    {

        private string _text = string.Empty;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
        private UsuarioDonante _usuario = new UsuarioDonante();
    
        public UsuarioDonante Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }

        public DelegateCommand AddUsuarioCommand { get; set; }

        public DonacionViewModel()
        {
            AddUsuarioCommand = new DelegateCommand(Click);
        }

        private void Click()
        {
            Text = string.Format("Dado de alta el usuario: {0} donando: {1}", Usuario.Nombre, Usuario.TipoDonacion);
            //TODO: Limpiar los valores de los textboxes
        }


    }
}

