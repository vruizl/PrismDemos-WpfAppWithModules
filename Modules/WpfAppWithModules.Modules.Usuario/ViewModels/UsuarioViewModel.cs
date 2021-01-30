using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModules.Modules.Usuario.Clases;

namespace WpfAppWithModules.Modules.Usuario.ViewModels
{
    public class UsuarioViewModel : BindableBase
    {
        private string _text = "Hola hola hola";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private UsuarioDonacion _usuario = new UsuarioDonacion();
        public UsuarioDonacion Usuario
        {
            get { return _usuario; }
            //set { SetProperty(ref _usuario, value); }
        }

        private readonly ObservableCollection<UsuarioDonacion> _usuarios = new ObservableCollection<UsuarioDonacion>();

        public ICollection<UsuarioDonacion> Usuarios
        {
            get { return _usuarios; }
        }

        private readonly ObservableCollection<string> _nombresUsuarios = new ObservableCollection<string>();

        public ObservableCollection<string> NombresUsuarios 
        {
            get { return _nombresUsuarios; }
        }

        

        public DelegateCommand AddUsuarioCommand { get; set; }

        public UsuarioViewModel()
        {
            AddUsuarioCommand = new DelegateCommand(Click);
        }

        private void Click()
        {
            Text = "Has agregado el usuario: " + Usuario.Nombre + "que solicita: " + Usuario.TipoDemanda;
            //TODO: Añadir usuario a la lista de usuarios
            _usuarios.Add(Usuario);
            _nombresUsuarios.Add(Usuario.Nombre);

        }


    }
}

