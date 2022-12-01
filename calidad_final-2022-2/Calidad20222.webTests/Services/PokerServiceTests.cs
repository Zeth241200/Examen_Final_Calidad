using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calidad20222.web.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Routing;


namespace Calidad20222.web.Services.Tests
{
    [TestClass()]
    public class PokerServiceTests
    {
        [TestMethod()]
        public void GetJugadaTest01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 8,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO",cartaList);
        }





    }

}


    