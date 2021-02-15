using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WpfAppWithModules.Business;
using WpfAppWithModules.Modules.Donacion.ViewModels;
using WpfAppWithModules.Services.Interfaces;

namespace WpfAppWithModules.Modules.Testing
{
    [TestClass]
    public class DonacionListViewModelTest
    {

        [TestMethod]
        public void TestDonacionListViewModelConstructorInitializesMembers()
        {

            var mockSet = new Mock<ObservableCollection<UsuarioDonante>>();
            var _mockUsuarioDonacionService = new Mock<IUsuarioDonanteService>();
            _mockUsuarioDonacionService.Setup(c => c.GetUsuarios()).Returns(mockSet.Object);

            // Actions
            var uvm = new DonacionListViewModel(_mockUsuarioDonacionService.Object);

            // Assertions
            Assert.IsNotNull(uvm);
           
        }
    }
}
    }
}
