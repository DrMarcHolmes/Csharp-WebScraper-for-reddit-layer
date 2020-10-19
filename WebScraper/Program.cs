using System;
using System.Net;


namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets get images!");
            using (var client = new WebClient())
            {
                DateTime localDate = DateTime.Now;

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_HOT_final.png",                                   "All Layers HOT "+ localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("All Layers HOT " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Test%20Canvas,%20Please%20Ignore_HOT_final.png",  "Test Canvas, Please Ignore HOT " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Test Canvas, Please Ignore HOT " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Me%20IRL_HOT_final.png",                          "Me IRL Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Me IRL Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Aww_HOT_final.png",                               "Aww Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Aww Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Comics_HOT_final.png",                            "Comics Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Comics Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Gaming_HOT_final.png",                            "Gaming Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Gaming Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Music_HOT_final.png",                             "Music Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Music Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_NomNom_HOT_final.png",                            "NonNom Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("NonNom Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Threads_HOT_final.png",                           "Threads Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Threads Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Moviedetails_HOT_final.png",                      "Moviedetail Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Moviedetail Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

                client.DownloadFile("https://i.redd.it/layer/t5_32b7p_Vaporwaveaesthetics_HOT_final.png",               "Vaporwave Aesthetics Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
                Console.WriteLine("Vaporwave Aesthetics Hot " + localDate.ToString("yyyy-dd-M--HH-mm-ss") + ".png");

            }
        }

    }
}
