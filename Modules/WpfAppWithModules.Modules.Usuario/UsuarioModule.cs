using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WpfAppWithModules.Core;
using WpfAppWithModules.Modules.Usuario.Views;

namespace WpfAppWithModules.Modules.Usuario
{
    public class UsuarioModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public UsuarioModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerprovider)
        {
            //_regionManager.RegisterViewWithRegion(RegionNames.UsuarioListRegion, typeof(UsuarioListView));
            _regionManager.RegisterViewWithRegion(RegionNames.UsuarioRegion, typeof(UsuarioView));

        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}

