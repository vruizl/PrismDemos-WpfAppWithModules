using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using WpfAppWithModules.Modules.Donacion;
using WpfAppWithModules.Modules.Usuario;
using WpfAppWithModules.Views;
using WpfAppWithModules.Core;

namespace WpfAppWithModules
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override Window CreateShell()
        {
            var w = Container.Resolve<ShellWindow>();
            return w;
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<UsuarioModule>();
            moduleCatalog.AddModule<DonacionModule>();
        }
    }
}
