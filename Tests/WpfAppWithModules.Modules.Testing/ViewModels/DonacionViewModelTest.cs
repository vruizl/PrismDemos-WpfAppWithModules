using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppWithModules.Modules.Donacion.ViewModels;

namespace WpfAppWithModules.Modules.Testing
{
    [TestClass]
    public class DonacionViewModelTest
    {
        [TestMethod]
        public void TestDonacionViewModelConstructorInitializesMembers()
        {

            // Actions
            var dvm = new DonacionViewModel();

            // Assertions
            Assert.IsNotNull(dvm);
            Assert.IsFalse(dvm.AddUsuarioCommand == null);

        }
    }
}
