using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using BLC;
using System.Configuration;


namespace WorkerService1
{
   
    public class Worker : BackgroundService
    {
        //public override Task StartAsync(CancellationToken cancellationToken)
        //{
        //    return base.StartAsync(cancellationToken);
        //}
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
           
            while (!stoppingToken.IsCancellationRequested)
            {
                #region Declaration And Initialization Section.
           
           
                    string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
                        BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
                        oBLCInitializer.ConnectionString = _ConnectionString;
                        oBLCInitializer.OwnerID = 1;
                        oBLCInitializer.UserID = 1;
                        oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
                        BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
                        string str_Option = string.Empty;
                        string str_BH_ID = string.Empty;
                        string str_AC_ID = string.Empty;
                        string str_Bucket_Name = string.Empty;
                        string str_Main_Folder_Path = string.Empty;
                        Tools.Tools oTools = new Tools.Tools();
                #endregion

                Params_Get_Extension_By_EXTENSION_ID oParams_Get_Extension_By_EXTENSION_ID = new Params_Get_Extension_By_EXTENSION_ID();
                oParams_Get_Extension_By_EXTENSION_ID.EXTENSION_ID = 1;
               
                var result = oBLC.Get_Extension_By_EXTENSION_ID(oParams_Get_Extension_By_EXTENSION_ID);
                Console.WriteLine(result.NUMBER_OF_EXTENSIONS);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
