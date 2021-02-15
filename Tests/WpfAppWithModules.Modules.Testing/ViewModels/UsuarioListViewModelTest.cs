using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfAppWithModules.Business;
using WpfAppWithModules.Modules.Usuario.ViewModels;
using WpfAppWithModules.Services.Interfaces;

namespace WpfAppWithModules.Modules.Testing
{
    [TestClass]
    public class UsuarioListViewModelTest
    {

        [TestMethod]
        public void TestUsuarioListViewModelConstructorInitializesMembers()
        {
          
            var mockSet = new Mock<ObservableCollection<UsuarioDonacion>>();
            var _mockUsuarioDonacionService = new Mock<IUsuarioDonacionService>();
            _mockUsuarioDonacionService.Setup(c => c.GetUsuarios()).Returns(mockSet.Object);

            // Actions
            var uvm = new UsuarioListViewModel(_mockUsuarioDonacionService.Object);

            // Assertions
            Assert.IsNotNull(uvm);
           
         }   
    }
}
