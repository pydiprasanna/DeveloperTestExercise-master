using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDetails objFileDetails = new FileDetails();
            try
            {
                if (args != null)
                {
                    string[] version = new string[] { "–v", "--v", "/v", "--version" };
                    string[] size = new string[] { "–s", "--s", "/s", "--size" };
                    if (version.Contains(args[0]))
                        Console.WriteLine("Version of the file is :" + objFileDetails.Version(args[1]));
                    if (size.Contains(args[0]))
                        Console.WriteLine("Size of the file is: " + objFileDetails.Size(args[1]));

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objFileDetails = null;
            }
        }
    }
}
