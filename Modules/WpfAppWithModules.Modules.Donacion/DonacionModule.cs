using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Regions;
using WpfAppWithModules.Core;
using WpfAppWithModules.Modules.Donacion.Views;
using WpfAppWithModules.Services.Interfaces;
using WpfAppWithModules.Services;

namespace WpfAppWithModules.Modules.Donacion
{
    public class DonacionModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public DonacionModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerprovider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.DonacionRegion, typeof(DonacionView));
            _regionManager.RegisterViewWithRegion(RegionNames.DonacionListRegion, typeof(DonacionListView));
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IUsuarioDonanteService, UsuarioDonanteService>();
        }
    }
}
