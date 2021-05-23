using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace OrangeHRM.Utilities
{
    class FileLocations
    {

        public string GetFolderLocation(string folder)
        {
            return Directory.GetParent(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString(), @"..\..\")) + @"\" + folder + @"\";

        }
    }
}