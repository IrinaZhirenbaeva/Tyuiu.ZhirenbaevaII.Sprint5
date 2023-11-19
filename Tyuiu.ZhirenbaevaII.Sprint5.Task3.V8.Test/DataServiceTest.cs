using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint5.Task3.V8.Lib;
using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\KK\source\repos\Tyuiu.ZhirenbaevaII.Sprint5\Tyuiu.ZhirenbaevaII.Sprint5.Task3.V8\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
    
}
