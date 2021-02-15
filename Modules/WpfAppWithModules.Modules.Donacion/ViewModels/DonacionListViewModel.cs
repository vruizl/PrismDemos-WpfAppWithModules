using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModules.Business;
using WpfAppWithModules.Services.Interfaces;

namespace WpfAppWithModules.Modules.Donacion.ViewModels
{
    public class DonacionListViewModel : BindableBase
    {
        private ObservableCollection<UsuarioDonante> _usuarios;
        private readonly IUsuarioDonanteService _usuarioDonanteService;

        public ObservableCollection<UsuarioDonante> Usuarios
        {
            get { return _usuarios; }
            set { SetProperty(ref _usuarios, value); }
        }
        //   public DelegateCommand AddUsuarioCommand { get; set; }

        public DonacionListViewModel(IUsuarioDonanteService usuarioDonanteService)
        {
            //    AddUsuarioCommand = new DelegateCommand(Click);
            _usuarioDonanteService = usuarioDonanteService;
            Usuarios = new ObservableCollection<UsuarioDonante>(usuarioDonanteService.GetUsuarios());
        }

    }
}
