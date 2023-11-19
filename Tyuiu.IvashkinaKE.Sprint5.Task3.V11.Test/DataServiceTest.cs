using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.IvashkinaKE.Sprint5.Task3.V11.Lib;

namespace Tyuiu.IvashkinaKE.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\MSI\source\repos\Tyuiu.IvashkinaKE.Sprint5\Tyuiu.IvashkinaKE.Sprint5.Task3.V11\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
