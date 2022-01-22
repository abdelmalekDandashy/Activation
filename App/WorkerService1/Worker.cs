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

                #region Test worker service 
                //Params_Get_Extension_By_EXTENSION_ID oParams_Get_Extension_By_EXTENSION_ID = new Params_Get_Extension_By_EXTENSION_ID();
                //oParams_Get_Extension_By_EXTENSION_ID.EXTENSION_ID = 1;

                //var result = oBLC.Get_Extension_By_EXTENSION_ID(oParams_Get_Extension_By_EXTENSION_ID);
                //Console.WriteLine(result.NUMBER_OF_EXTENSIONS);

                #endregion

                #region charging_batteries
                var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
                var resultTables = oBLC.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);

                foreach(var table in resultTables)
                {
                    

                    if(table.IS_CHARGING == true && table.CHARGING_PERCENTAGE <100)
                    {
                        var value = table.CHARGING_PERCENTAGE;


                        switch (value)
                        {
                            case var expression when (value < 25):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 15;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE+" is now " + table.TABLE_NAME);
                                break;

                            case var expression when (value < 50):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 12;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;

                            case var expression when (value < 90):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 10;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;
                            
                            case var expression when (value < 98):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 3;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;
                        }

                    }
                }
                #endregion
                Console.WriteLine("5 seconds passed");
                await Task.Delay(5*1000, stoppingToken);

                Console.WriteLine("10 seconds passed");
                await Task.Delay(10 * 1000, stoppingToken);
            }


           

        }
    }
}
