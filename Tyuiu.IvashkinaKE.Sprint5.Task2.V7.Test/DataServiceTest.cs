using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IvashkinaKE.Sprint5.Task2.V7.Lib;

namespace Tyuiu.IvashkinaKE.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\MSI\source\repos\Tyuiu.IvashkinaKE.Sprint5\Tyuiu.IvashkinaKE.Sprint5.Task2.V7\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
