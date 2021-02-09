using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppWithModules.Modules.Usuario.ViewModels;

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
