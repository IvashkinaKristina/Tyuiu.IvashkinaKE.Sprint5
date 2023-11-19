﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;


namespace Tyuiu.IvashkinaKE.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\MSI\source\repos\Tyuiu.IvashkinaKE.Sprint5\Tyuiu.IvashkinaKE.Sprint5.Task1.V8\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}