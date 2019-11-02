using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class LIbraryUsesIndexers
    {
        private const string FOLDER_NAME = "Microsoft.NET\\assembly\\GAC_64\\mscorlib\\v4.0_4.0.0.0__b77a5c561934e089\\mscorlib.dll";

        [TestMethod]
        public void Test_MSCORLIB_Get_Libraries_Uses_Indexer_Feature()
        {
            string initPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Windows);

            string fullPath = Path.Combine(initPath, FOLDER_NAME);

            var mscorLib = System.Reflection.Assembly.LoadFile(fullPath);

            foreach (var itemType in mscorLib.DefinedTypes)
            {
                var type = itemType.GetProperties().Where(x => x.GetIndexParameters().Length != 0).FirstOrDefault();

                if (type != null)
                {
                    Console.WriteLine($" Type: {itemType.FullName}, Property: {type}");
                }
            }
        }
    }
}
