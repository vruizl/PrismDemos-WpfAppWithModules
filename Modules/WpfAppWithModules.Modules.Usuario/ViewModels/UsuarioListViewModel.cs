using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModules.Business;
using WpfAppWithModules.Services.Interfaces;

namespace WpfAppWithModules.Modules.Usuario.ViewModels
{
    public class UsuarioListViewModel : BindableBase
    {
        //private UsuarioDonacion _usuario = new UsuarioDonacion();
        //public UsuarioDonacion Usuario
        //{
        //    get { return _usuario; }
        //    //set { SetProperty(ref _usuario, value); }
        //}

        //private readonly ObservableCollection<UsuarioDonacion> _usuarios = new ObservableCollection<UsuarioDonacion>();

        //public ObservableCollection<UsuarioDonacion> Usuarios
        //{
        //    get { return _usuarios; }
        //}

        private ObservableCollection<UsuarioDonacion> _usuarios;
        private readonly IUsuarioDonacionService _usuarioDonacionService;

        public ObservableCollection<UsuarioDonacion> Usuarios
        {
            get { return _usuarios; }
            set { SetProperty(ref _usuarios, value); }
        }
     //   public DelegateCommand AddUsuarioCommand { get; set; }

        public UsuarioListViewModel(IUsuarioDonacionService usuarioDonacionService)
        {
        //    AddUsuarioCommand = new DelegateCommand(Click);
            _usuarioDonacionService = usuarioDonacionService;
            Usuarios = new ObservableCollection<UsuarioDonacion>(_usuarioDonacionService.GetUsuarios());
        }

      //  private void Click()
      //  {      
           // _usuarios.Add(new UsuarioDonacion(Usuario.Nombre,Usuario.TipoDemanda));
            //TODO:Limpiar valores textboxes
      //  }


    }
}

