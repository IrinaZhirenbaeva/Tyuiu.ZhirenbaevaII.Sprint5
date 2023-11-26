﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint5.Task6.V27.Lib;
using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
       
         
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";

            FileInfo info = new FileInfo(path);
            bool tyta = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
