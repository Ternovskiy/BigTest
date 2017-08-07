using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DOT_NET
{
    [TestClass]
    public class SerializeBin
    {
        [TestMethod]
        public void Serialize()
        {
            var t=new TestSer();
            t.SetAllTrue();

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("TestSer.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, t);

                Console.WriteLine("Объект сериализован");
            }
        }



        [TestMethod]
        public void DeSerialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            TestSer t;
            using (FileStream fs = new FileStream("TestSer.dat", FileMode.OpenOrCreate))
            {
                 t = (TestSer)formatter.Deserialize(fs);
            }

            Console.WriteLine("Объект десериализован");

            Assert.AreEqual(t.CheackAll(),true);
        }
    }



    [Serializable]
    public class TestSer
    {
        private bool flag1 = false;
        private bool flag2;
        private bool flag3 { get; set; } = false;
        public bool flag4 { get; set; } = false;

        public void SetAllTrue()
        {
            flag1 = flag2 = flag3 = flag4 = true;
        }

        public bool CheackAll()
        {
            return flag1 && flag2 && flag3 && flag4;
        }
    }


}
