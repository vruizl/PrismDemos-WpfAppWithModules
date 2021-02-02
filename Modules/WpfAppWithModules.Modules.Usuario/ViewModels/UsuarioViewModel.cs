﻿using Prism.Commands;
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
        private UsuarioDonacion _usuario = new UsuarioDonacion();
        public UsuarioDonacion Usuario
        {
            get { return _usuario; }
            //set { SetProperty(ref _usuario, value); }
        }

        private readonly ObservableCollection<UsuarioDonacion> _usuarios = new ObservableCollection<UsuarioDonacion>();

        public ObservableCollection<UsuarioDonacion> Usuarios
        {
            get { return _usuarios; }
        }

        public DelegateCommand AddUsuarioCommand { get; set; }

        public UsuarioViewModel()
        {
            AddUsuarioCommand = new DelegateCommand(Click);
        }

        private void Click()
        {      
            _usuarios.Add(new UsuarioDonacion(Usuario.Nombre,Usuario.TipoDemanda));
            //TODO:Limpiar valores textboxes
        }


    }
}

