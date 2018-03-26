using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Parte_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Parte_1.Models.Testsnuevouser
{
    [TestClass()]
    public class SingInTestsRegitroUsuario2
    {
        [TestMethod()]
        public void singInTestRegistroUserExist()
        {
            //Arrange
            var RegUser = new SingIn();//{ User = "lcordero", Email = "Lcordero@gmail.com" };
            RegUser.User = "Lcordero";
            RegUser.Email = "Lcordero@gmail.com";

            //Act
            var resultado = RegUser.singIn();

            //Assert
            Assert.IsFalse(resultado);
            
        }

        [TestMethod()]
        public void singInTestRegistroUserNoExist()
        {
            //Arrange
            var RegUser = new SingIn();//{ User = "lcordero", Email = "Lcordero@gmail.com" };
            RegUser.Name = "Raúl";
            RegUser.LastName = "González";
            RegUser.User = "Rgonzalez";
            RegUser.Email = "Rgonzalez@gmail.com";
            RegUser.Password = "123456";

            //Act
            var resultado = RegUser.singIn();

            //Assert
            Assert.IsTrue(resultado);
        }
    }
}