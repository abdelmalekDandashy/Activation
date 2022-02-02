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
        #region sendNotification_METHOD


        public void sendNotification(string i_notification)
        {
            #region send firebase notification
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            //serverKey - Key from Firebase cloud messaging server  
            tRequest.Headers.Add(string.Format("Authorization: key={0}", "AAAAhUx4cMY:APA91bHT3xtFC-Kwu9poDY2_R_CKNYVzKzJCEuASykdoanLKGxqo_L5Ku-Jl0nqDSOCKwYeCRnWj4dtMd480X8al-0TBnwla5dEIzfpu-wbcyZm-ZIUDwfGGRBKGESvXBpiAjgFuKhOW"));
            //Sender Id - From firebase project setting  
            tRequest.Headers.Add(string.Format("Sender: id={0}", "572513611974"));
            tRequest.ContentType = "application/json";
            var payload = new
            {
                to = i_notification,
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = "wassim akalo men el loop",
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
            //Console.WriteLine("more ways how to send push not from c#");
            //Console.WriteLine("https://stackoverflow.com/questions/37412963/send-push-to-android-by-c-sharp-using-fcm-firebase-cloud-messaging");
            //Console.WriteLine("3 seconds passed");
            //await Task.Delay(3 * 1000, stoppingToken);
            #endregion
        }
        #endregion
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


                Console.WriteLine("5 seconds passed");
                await Task.Delay(5 * 1000, stoppingToken);

                var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
                var resultTables = oBLC.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);


                //foreach(var table in resultTables)
                //{
                    

                //    if(table.IS_CHARGING == true && table.CHARGING_PERCENTAGE <100)
                //    {
                //        var value = table.CHARGING_PERCENTAGE;


                //        switch (value)
                //        {
                //            case var expression when (value < 25):
                //                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 15;
                //                oBLC.Edit_Table(table);
                //                Console.WriteLine(table.CHARGING_PERCENTAGE+" is now " + table.TABLE_NAME);
                //                break;

                //            case var expression when (value < 50):
                //                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 12;
                //                oBLC.Edit_Table(table);
                //                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                //                break;

                //            case var expression when (value < 90):
                //                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 10;
                //                oBLC.Edit_Table(table);
                //                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                //                break;

                //            case var expression when (value < 98):
                //                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 3;
                //                oBLC.Edit_Table(table);
                //                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                //                break;
                //        }


                //    }
                //}
       


            }


           

        }
     


    }

    public class Worker2 : BackgroundService
    {

        #region sendNotification_METHOD
        public void sendNotification(string i_notification)
        {
            #region send firebase notification
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            //serverKey - Key from Firebase cloud messaging server  
            tRequest.Headers.Add(string.Format("Authorization: key={0}", "AAAAhUx4cMY:APA91bHT3xtFC-Kwu9poDY2_R_CKNYVzKzJCEuASykdoanLKGxqo_L5Ku-Jl0nqDSOCKwYeCRnWj4dtMd480X8al-0TBnwla5dEIzfpu-wbcyZm-ZIUDwfGGRBKGESvXBpiAjgFuKhOW"));
            //Sender Id - From firebase project setting  
            tRequest.Headers.Add(string.Format("Sender: id={0}", "572513611974"));
            tRequest.ContentType = "application/json";
            var payload = new
            {
                to = i_notification,
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = "wassim akalo men el loop",
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
            //await Task.Delay(3 * 1000, stoppingToken);
            #endregion
        }
        #endregion

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

                #region get firebase token and send low battery notification

                var oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID() { OWNER_ID= 1};
                var AllUsers = oBLC.Get_User_By_OWNER_ID(oParams_Get_User_By_OWNER_ID);

                if(AllUsers != null && AllUsers.Count > 0)
                {   
                    var tokenList = new List<string>();

                    #region check_tables_battery
                    #region declaration
                    var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
                    var AllTablesList = oBLC.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);
                    #endregion declaration
                    if (AllTablesList != null && AllTablesList.Count > 0)
                    {
                        foreach (var table in AllTablesList)
                        {
                            if (table.CHARGING_PERCENTAGE <= 20)
                            {
                                foreach (var user in AllUsers)
                                {
                                    if (user.FIREBASE_TOKEN != null)
                                    {
                                        //tokenList.Add(token.FIREBASE_TOKEN);
                                        sendNotification(user.FIREBASE_TOKEN);
                                        Console.WriteLine(table.CHARGING_PERCENTAGE+"battery %                              was sent to"+user.USERNAME);
                                        //await Task.Delay(1 * 1000 *3600, stoppingToken);
                                        
                                    }
                                }
                            }
                        }

                        #endregion check_tables_battery
                       

                    }   //here close
                }


                #endregion

                await Task.Delay(10 * 1000, stoppingToken);


            }
        }


    }
}
