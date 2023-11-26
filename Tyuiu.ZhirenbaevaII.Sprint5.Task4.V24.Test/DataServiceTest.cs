using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.ZhirenbaevaII.Sprint5.Task4.V24.Lib;
using System.IO;
namespace Tyuiu.ZhirenbaevaII.Sprint5.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            {
                string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";
                FileInfo fileinfo = new FileInfo(path);
                bool FileExists = fileinfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, FileExists);
            }
        }
    }
}
    

