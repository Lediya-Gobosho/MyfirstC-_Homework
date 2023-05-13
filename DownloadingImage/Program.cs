using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadingImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.pexels.com/photo/white-mercedes-benz-suv-parked-beside-brown-wooden-fence-215528/";
            string localFilePath = @"C:\Users\lidiya gobosho\Downloads\this code";
            WebClient mywebclient = new WebClient();
            try
            {
                mywebclient.DownloadFile(url, localFilePath);
                Console.WriteLine("Image downloaded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error downloading image: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
