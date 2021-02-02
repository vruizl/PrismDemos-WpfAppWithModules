using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModules.Modules.Donacion.Clases;

namespace WpfAppWithModules.Modules.Donacion.ViewModels
{
    public class DonacionViewModel : BindableBase
    {
        private UsuarioDonante _usuario = new UsuarioDonante();
        public UsuarioDonante Usuario
        {
            get { return _usuario; }
            //set { SetProperty(ref _usuario, value); }
        }

        private readonly ObservableCollection<UsuarioDonante> _usuarios = new ObservableCollection<UsuarioDonante>();

        public ObservableCollection<UsuarioDonante> Usuarios
        {
            get { return _usuarios; }
        }

        public DelegateCommand AddUsuarioCommand { get; set; }

        public DonacionViewModel()
        {
            AddUsuarioCommand = new DelegateCommand(Click);
        }

        private void Click()
        {
            _usuarios.Add(new UsuarioDonante(Usuario.Nombre, Usuario.TipoDonacion));
            //TODO:Limpiar valores textboxes
        }


    }
}

