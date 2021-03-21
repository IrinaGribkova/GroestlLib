using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroestlLib;
using System.Text;

namespace GroestlTests
{
    [TestClass]
    public class MyGroestlTests
    {
        [TestMethod]
        public void EmptyString_224()
        {
            Groestl groestl = new Groestl();
            groestl.btvrs = 224;
            groestl.input = "";
            string expected = "f2e180fb5947be964cd584e22e496242c6a329c577fc4ce8c36d34c3";
            groestl.Execute();

            StringBuilder sb = new StringBuilder();
            foreach (var _byte in groestl.OutputData)
            {
                string res = Convert.ToString(Convert.ToInt16(_byte), 16);
                if (res.Length == 1)
                    res = "0" + res;
                sb.Append(res);
            }
            string actual = sb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyString_256()
        {
            Groestl groestl = new Groestl();
            groestl.btvrs = 256;
            groestl.input = "";
            string expected = "1a52d11d550039be16107f9c58db9ebcc417f16f736adb2502567119f0083467";
            groestl.Execute();

            StringBuilder sb = new StringBuilder();
            foreach (var _byte in groestl.OutputData)
            {
                string res = Convert.ToString(Convert.ToInt16(_byte), 16);
                if (res.Length == 1)
                    res = "0" + res;
                sb.Append(res);
            }
            string actual = sb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyString_384()
        {
            Groestl groestl = new Groestl();
            groestl.btvrs = 384;
            groestl.input = "";
            string expected = "ac353c1095ace21439251007862d6c62f829ddbe6de4f78e68d310a9205a736d8b11d99bffe448f57a1cfa2934f044a5";
            groestl.Execute();

            StringBuilder sb = new StringBuilder();
            foreach (var _byte in groestl.OutputData)
            {
                string res = Convert.ToString(Convert.ToInt16(_byte), 16);
                if (res.Length == 1)
                    res = "0" + res;
                sb.Append(res);
            }
            string actual = sb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_From_Wiki_256()
        {
            Groestl groestl = new Groestl();
            groestl.btvrs = 256;
            groestl.input = "The quick brown fox jumps over the lazy dog";
            string expected = "8c7ad62eb26a21297bc39c2d7293b4bd4d3399fa8afab29e970471739e28b301";
            groestl.Execute();

            StringBuilder sb = new StringBuilder();
            foreach (var _byte in groestl.OutputData)
            {
                string res = Convert.ToString(Convert.ToInt16(_byte), 16);
                if (res.Length == 1)
                    res = "0" + res;
                sb.Append(res);
            }
            string actual = sb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_From_Wiki_256_2()
        {
            Groestl groestl = new Groestl();
            groestl.btvrs = 256;
            groestl.input = "The quick brown fox jumps over the lazy dog.";
            string expected = "f48290b1bcacee406a0429b993adb8fb3d065f4b09cbcdb464a631d4a0080aaf";
            groestl.Execute();

            StringBuilder sb = new StringBuilder();
            foreach (var _byte in groestl.OutputData)
            {
                string res = Convert.ToString(Convert.ToInt16(_byte), 16);
                if (res.Length == 1)
                    res = "0" + res;
                sb.Append(res);
            }
            string actual = sb.ToString();
            Assert.AreEqual(expected, actual);
        }

        
    }
}
