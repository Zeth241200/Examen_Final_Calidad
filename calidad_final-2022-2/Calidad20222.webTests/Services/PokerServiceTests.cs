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
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "COCO"
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

        [TestMethod()]
        public void GetJugadaTest02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 3,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest03()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest04()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest05()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 3,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest06()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest07()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 5,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "TREBOL"
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
            Assert.AreNotEqual("FULL", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest08()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("FULL", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest09()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13,
                       Palo = "ESPADA"
                    },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest10()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 6,
                       Palo = "ESPADA"
                    },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest11()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 2,
                       Palo = "TREBOL"
                    },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest12()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12,
                       Palo = "CORAZON"
                    },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest13()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 11,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "COCO"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest14()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("DOBLE_PAREJA", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest15()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("DOBLE_PAREJA", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest16()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest17()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest18()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest19()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 5,
                       Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest20()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 7,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList);
        }


    }


}


    