using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppWithModules.Modules.Usuario.ViewModels;
using WpfAppWithModules.Services.Interfaces;

namespace WpfAppWithModules.Modules.Testing
{
    [TestClass]
    public class UsuarioViewModelTest
    {
        [TestMethod]
        public void TestUsuarioViewModelConstructorInitializesMembers()
        {
            // Actions
            var uvm = new UsuarioViewModel();

            // Assertions
            Assert.IsNotNull(uvm);
            Assert.IsFalse(uvm.AddUsuarioCommand == null);
        }
    }
}
