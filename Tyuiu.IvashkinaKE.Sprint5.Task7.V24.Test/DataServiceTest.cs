﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.IvashkinaKE.Sprint5.Task7.V24.Lib;

namespace Tyuiu.IvashkinaKE.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileInFolder()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
