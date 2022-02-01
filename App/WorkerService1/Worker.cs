using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using BLC;
using System.Configuration;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

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

                //Params_Get_Extension_By_EXTENSION_ID oParams_Get_Extension_By_EXTENSION_ID = new Params_Get_Extension_By_EXTENSION_ID();
                //oParams_Get_Extension_By_EXTENSION_ID.EXTENSION_ID = 1;

                //var result = oBLC.Get_Extension_By_EXTENSION_ID(oParams_Get_Extension_By_EXTENSION_ID);
                //Console.WriteLine(result.NUMBER_OF_EXTENSIONS);



         
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
       
                Console.WriteLine("5 seconds passed");
                await Task.Delay(5*1000, stoppingToken);


            }


           

        }
     


    }

    public class Worker2 : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            var defaultApp = FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.json")),
            });
            Console.WriteLine(defaultApp.Name); // "[DEFAULT]"

            var message = new FirebaseAdmin.Messaging.Message()
            {
                Notification = new Notification
                {
                    Title = "Message Title",
                    Body = "Message Body"
                },
                Topic = "news"
            };


            while (!stoppingToken.IsCancellationRequested)
            {
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                //serverKey - Key from Firebase cloud messaging server  
                tRequest.Headers.Add(string.Format("Authorization: key={0}", "AAAAhUx4cMY:APA91bHT3xtFC-Kwu9poDY2_R_CKNYVzKzJCEuASykdoanLKGxqo_L5Ku-Jl0nqDSOCKwYeCRnWj4dtMd480X8al-0TBnwla5dEIzfpu-wbcyZm-ZIUDwfGGRBKGESvXBpiAjgFuKhOW"));
                //Sender Id - From firebase project setting  
                tRequest.Headers.Add(string.Format("Sender: id={0}", "572513611974"));
                tRequest.ContentType = "application/json";
                var payload = new
                {
                    to = "cCWE1c01Q-qT5GVYe9ee0f:APA91bGvrfUmjTFmx3srShHXZzDaLKwi9HX26_RklVgW1X6M7OE5Nw-YMErXXfsQzrmFrHR6k3uC-kL-dn5HoqfN90VZORXngfYZWCyCha1we9-iGSJRZsJv2mqvC05P1pu_NHFYTE_5",
                    priority = "high",
                    content_available = true,
                    notification = new
                    {
                        body = "nafiii5",
                        title = "Wassim shubeh ?",
                        badge = 1
                    },
                    data = new
                    {
                        key1 = "value1",
                        key2 = "value2"
                    }

                };

                string postbody = JsonConvert.SerializeObject(payload).ToString();
                Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            if (dataStreamResponse != null) using (StreamReader tReader = new StreamReader(dataStreamResponse))
                                {
                                    String sResponseFromServer = tReader.ReadToEnd();
                                    //result.Response = sResponseFromServer;
                                }
                        }
                    }
                }
                Console.WriteLine("more ways how to send push not from c#");
                Console.WriteLine("https://stackoverflow.com/questions/37412963/send-push-to-android-by-c-sharp-using-fcm-firebase-cloud-messaging");
                Console.WriteLine("3 seconds passed");
                await Task.Delay(3 * 1000, stoppingToken);

            }
        }


    }
}
