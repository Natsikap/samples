using System;
using System.Globalization;
using System.IO;
using testingresourcefilesusage.filestore.Properties;

namespace testingresourcefilesusage.filestore
{
    public static class InputTemplatesHelper
    {

        public static string GetFileContents(string fileName)
        {
            // this is vital! embedded resource file name with out extension is required in the next step
            string fileWithExt = Path.GetFileNameWithoutExtension(fileName);

            // without specifying the culture
            string wildFile = IamAResourceFile.ResourceManager.GetString(fileWithExt);
            Console.Write(wildFile);
            
            // with culture
            string culturedFile = IamAResourceFile.ResourceManager.GetString(fileWithExt, CultureInfo.InvariantCulture);
            Console.Write(culturedFile);

            return culturedFile;



        }

    }
}
