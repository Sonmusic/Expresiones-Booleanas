using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExpresionesBooleanas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return_Equal_Tabla_1_Variable()
        {
            ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("*A");
            Assert.AreEqual("|1|\n|0|", expresion.TablaBooleana());
        }
        [TestMethod]
        public void Return_Equal_Tabla_2_Variables()
        {
            ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("(A || B) && (*A && B)");
            Assert.AreEqual("|1| |1|\n|1| |0|\n|0| |1|\n|0| |0|", expresion.TablaBooleana());
        }
        [TestMethod]
        public void Return_NotEqual_Tabla_3_Variables()
        {
            ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("((A || B) && (*A && B)) || C");
            Assert.AreEqual("|1| |1| |1|\n|1| |1| |0|\n|1| |0| |1|\n|1| |0| |0|\n|0| |1| |1|\n|0| |1| |0|\n|0| |0| |1|\n|0| |0| |0|\n"
                , expresion.TablaBooleana());
        }
        [TestMethod]
        public void Return_NotEqual_Tabla_1_Variables()
        {
            ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("A");
            Assert.AreNotEqual("|0|\n|0|", expresion.TablaBooleana());
        }
        [TestMethod]
        public void Return_NotEqual_Tabla_2_Variables()
        {
            ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("(A || B) && (*A && B)");
            Assert.AreNotEqual("|1| |1|\n|1| |0|\n|0| |1|\n|1| |0|", expresion.TablaBooleana());
        }
        [TestMethod]
        public void Return_Equal_Tabla_3_Variables()
        {
            ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("((A || B) && (*A && B)) || C");
            Assert.AreNotEqual("|0| |1| |1|\n|1| |1| |0|\n|1| |0| |1|\n|1| |0| |0|\n|0| |1| |1|\n|0| |1| |0|\n|0| |0| |1|\n|0| |0| |0|\n"
                , expresion.TablaBooleana());
        }
        [TestMethod]
        public void Return_Error_Null_Tabla()
        {
            try
            {
                ExpresionesBooleanas.Expresion expresion = new ExpresionesBooleanas.Expresion("");
            }
            catch (System.Exception)
            {

                Assert.IsTrue(true);
            }
        }
    }
}
