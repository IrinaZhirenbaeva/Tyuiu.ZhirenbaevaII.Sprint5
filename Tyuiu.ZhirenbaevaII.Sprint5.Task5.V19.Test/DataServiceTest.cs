using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint5.Task5.V19.Lib;
using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }
}
    

