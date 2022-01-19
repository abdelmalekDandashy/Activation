using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using BLC;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    //#region Declaration And Initialization Section.
                    //string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
                    //BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
                    //oBLCInitializer.ConnectionString = _ConnectionString;
                    //oBLCInitializer.OwnerID = 1;
                    //oBLCInitializer.UserID = 1;
                    //oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
                    //BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
                    //string str_Option = string.Empty;
                    //string str_BH_ID = string.Empty;
                    //string str_AC_ID = string.Empty;
                    //string str_Bucket_Name = string.Empty;
                    //string str_Main_Folder_Path = string.Empty;
                    //Tools.Tools oTools = new Tools.Tools();
                    //#endregion

                    services.AddHostedService<Worker>();
                });
    }
}
