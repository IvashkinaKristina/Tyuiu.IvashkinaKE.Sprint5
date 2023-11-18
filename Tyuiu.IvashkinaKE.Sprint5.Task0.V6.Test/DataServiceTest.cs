using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.IvashkinaKE.Sprint5.Task0.V6.Lib;

namespace Tyuiu.IvashkinaKE.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\MSI\source\repos\Tyuiu.IvashkinaKE.Sprint5\Tyuiu.IvashkinaKE.Sprint5.Task0.V6\bin\Debug\OutputFileTask0.txt\";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);

        }
    }
}
