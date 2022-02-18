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
using RestSharp;
using RestSharp.Authenticators;

namespace WorkerService1
{
    
    public class Worker : BackgroundService
    {
        private string server_Key = ConfigurationManager.AppSettings["SERVER_KEY"];
        private string sender_ID = ConfigurationManager.AppSettings["SENDER_ID"];
        

        #region sendNotification_METHOD
        public void sendNotification(string i_notification, string i_title, string i_body)
        {   
            #region send firebase notification
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            //serverKey - Key from Firebase cloud messaging server  
            tRequest.Headers.Add(string.Format("Authorization: key={0}", server_Key));
            //Sender Id - From firebase project setting  
            tRequest.Headers.Add(string.Format("Sender: id={0}", sender_ID));
            tRequest.ContentType = "application/json";
            var payload = new
            {
                to = i_notification,
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = i_body,
                    title = i_title,
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

                

                var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
                var resultTables = oBLC.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);

                var oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID() { OWNER_ID = 1 };
                var AllUsers = oBLC.Get_User_By_OWNER_ID(oParams_Get_User_By_OWNER_ID);

                

                foreach (var table in resultTables)
                {
                    if (
                           table.IS_CHARGING == true
                        && table.CHARGING_PERCENTAGE < 100 
                        //&& table.TABLE_ID == 1 // comment later
                        )
                    {
                        var value = table.CHARGING_PERCENTAGE;
                        switch (value)
                        {
                            case var expression when (value < 45):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 15;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;

                            case var expression when (value < 60):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 13;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;

                            case var expression when (value < 73):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 11;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;

                            case var expression when (value < 84):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 7;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;
                            
                            case var expression when (value < 91):
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 5;
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);
                                break;
                            
                            case var expression when (value <= 100): //  93=> 97, 94=>98, 95=>99, 96=> 100
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE + 4;
                                if(table.CHARGING_PERCENTAGE >= 100)
                                {
                                    table.CHARGING_PERCENTAGE = 100;
                                }
                                oBLC.Edit_Table(table);
                                Console.WriteLine(table.CHARGING_PERCENTAGE + " is now " + table.TABLE_NAME);

                            
                                break;

                            
                        }


                    }
                    //if table.perc == 100 get all users and send notif
                    if (AllUsers != null && AllUsers.Count > 0)
                    {
                        foreach (var user in AllUsers)
                        {
                            if (table.CHARGING_PERCENTAGE == 100 && table.IS_CHARGING == true)
                            {
                                sendNotification(user.FIREBASE_TOKEN, "the table", $"{table.TABLE_NAME} in depo {table.DEPO_ID} battery is FULL");
                            }

                        }

                    }
                }



                //await Task.Delay(1800 * 1000, stoppingToken);
                await Task.Delay(60 * 1000, stoppingToken);
            }


           

        }
     


    }

    public class Worker2 : BackgroundService
    {
        private string server_Key = ConfigurationManager.AppSettings["SERVER_KEY"];
        private string sender_ID = ConfigurationManager.AppSettings["SENDER_ID"];
        #region sendNotification_METHOD
        public void sendNotification(string i_notification, string i_title, string i_body)
        {
            #region send firebase notification
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            //serverKey - Key from Firebase cloud messaging server  
            tRequest.Headers.Add(string.Format("Authorization: key={0}", server_Key));
            //Sender Id - From firebase project setting  
            tRequest.Headers.Add(string.Format("Sender: id={0}", sender_ID));
            tRequest.ContentType = "application/json";
            var payload = new
            {
                to = i_notification,
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = i_body,
                    title = i_title,
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

                #region get firebase token and send low battery notification

                var oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID() { OWNER_ID = 1 };
                var AllUsers = oBLC.Get_User_By_OWNER_ID(oParams_Get_User_By_OWNER_ID);

                if (AllUsers != null && AllUsers.Count > 0)
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

                            ///
                            if (table.IS_CHARGING != true)
                            { 
                                var value = table.CHARGING_PERCENTAGE;
                                switch (value)
                                {
                                    case var expression when (value <= 5):
                                            foreach (var user in AllUsers)
                                            {
                                                if (user.FIREBASE_TOKEN != null)
                                                {
                                                    var notificationTitle = "low battery percentage";
                                                    var notificationBody = $"table {table.TABLE_NAME} battery is below {value}";
                                                    sendNotification(user.FIREBASE_TOKEN, notificationTitle, notificationBody);
                                                    //Console.WriteLine(table.CHARGING_PERCENTAGE + "battery % was sent to" + user.USERNAME);
                                                    //await Task.Delay(1 * 1000 *3600, stoppingToken);

                                                }
                                            }
                                            break;

                                    case var expression when (value <= 20):
                                            foreach (var user in AllUsers)
                                            {
                                                if (user.FIREBASE_TOKEN != null)
                                                {
                                                    var notificationTitle = "low battery percentage";
                                                    var notificationBody = $"table {table.TABLE_NAME} battery is below {value}";
                                                    sendNotification(user.FIREBASE_TOKEN, notificationTitle, notificationBody);


                                                }
                                            }
                                            break;
                                }
                            }
                                    ///
                            //        if (table.CHARGING_PERCENTAGE <= 20 && table.IS_CHARGING != true)
                            //{
                            //    //foreach (var user in AllUsers)
                            //    //{
                            //    //    if (user.FIREBASE_TOKEN != null)
                            //    //    {
                            //    //        var notificationTitle = "low battery percentage";
                            //    //        var notificationBody = $"table {table.TABLE_NAME} battery is below 20%";
                            //    //        sendNotification(user.FIREBASE_TOKEN, notificationTitle, notificationBody);
                            //    //        Console.WriteLine(table.CHARGING_PERCENTAGE + "battery % was sent to" + user.USERNAME);
                            //    //        //await Task.Delay(1 * 1000 *3600, stoppingToken);

                            //    //    }
                            //    //}
                            //}
                        }

                        #endregion check_tables_battery


                    }   //here close
                }


                #endregion
                
                await Task.Delay(60 * 1000, stoppingToken);


            }

        }

    }

    public class dischargingWorker : BackgroundService
    {
        private string server_Key = ConfigurationManager.AppSettings["SERVER_KEY"];
        private string sender_ID = ConfigurationManager.AppSettings["SENDER_ID"];


        #region sendNotification_METHOD
        public void sendNotification(string i_notification, string i_title, string i_body)
        {
            #region send firebase notification
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            //serverKey - Key from Firebase cloud messaging server  
            tRequest.Headers.Add(string.Format("Authorization: key={0}", server_Key));
            //Sender Id - From firebase project setting  
            tRequest.Headers.Add(string.Format("Sender: id={0}", sender_ID));
            tRequest.ContentType = "application/json";
            var payload = new
            {
                to = i_notification,
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = i_body,
                    title = i_title,
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



                var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
                var resultTables = oBLC.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);

                var oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID() { OWNER_ID = 1 };
                var AllUsers = oBLC.Get_User_By_OWNER_ID(oParams_Get_User_By_OWNER_ID);



                foreach (var table in resultTables)
                {
                    if (
                           table.IS_CHARGING == false
                        //&& table.CHARGING_PERCENTAGE > 3
                        //&& table.TABLE_ID == 1 // comment later
                        )
                    {
                                table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE - 4;
                                if(table.CHARGING_PERCENTAGE <= 0)
                        {
                            table.CHARGING_PERCENTAGE = 0;
                        }
                                oBLC.Edit_Table(table);
                    }

                    //if (table.IS_CHARGING == false && table.CHARGING_PERCENTAGE <= 3)
                    //{
                    //    table.CHARGING_PERCENTAGE = table.CHARGING_PERCENTAGE - 1;

                    //    oBLC.Edit_Table(table);
                    //}
                    //if table.perc == 100 get all users and send notif
                }



                //await Task.Delay(1800 * 1000, stoppingToken);
                await Task.Delay(60 * 1000, stoppingToken);
            }




        }



    }
}
