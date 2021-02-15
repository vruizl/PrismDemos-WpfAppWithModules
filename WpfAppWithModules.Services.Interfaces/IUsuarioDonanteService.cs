using System;
using System.Collections.Generic;
using System.Text;
using WpfAppWithModules.Business;

namespace WpfAppWithModules.Services.Interfaces
{
    public interface IUsuarioDonanteService
    {
        IList<UsuarioDonante> GetUsuarios();
    }
}
