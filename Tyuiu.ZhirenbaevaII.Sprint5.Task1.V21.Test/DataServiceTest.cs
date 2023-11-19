using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint5.Task1.V21.Lib;

using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\KK\source\repos\Tyuiu.ZhirenbaevaII.Sprint5\Tyuiu.ZhirenbaevaII.Sprint5.Task1.V21\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
        
    

