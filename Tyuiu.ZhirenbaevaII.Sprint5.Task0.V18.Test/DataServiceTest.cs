using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint5.Task0.V18.Lib;
using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            {
                string path = @"C:\Users\KK\source\repos\Tyuiu.ZhirenbaevaII.Sprint5\Tyuiu.ZhirenbaevaII.Sprint5.Task0.V18\bin\Debug\OutPutFileTask0.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }
}
