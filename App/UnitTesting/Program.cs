using BLC;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
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

            //Params_Get_Extension_By_OWNER_ID oParams_Get_Extension_By_OWNER_ID  = new Params_Get_Extension_By_OWNER_ID();

            //oParams_Get_Extension_By_OWNER_ID.OWNER_ID = 1;

            //var reuslt = oBLC.Get_Extension_By_OWNER_ID(oParams_Get_Extension_By_OWNER_ID);

            //Console.WriteLine(reuslt);
            //Console.WriteLine(reuslt);



            //Params_Get_Table_By_OWNER_ID oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID();
            //oParams_Get_Table_By_OWNER_ID.OWNER_ID = 1;

            //var result = oBLC.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);
            //Console.WriteLine(result);
            //Console.WriteLine(result);






            Table oTable = new Table();
            oTable.TABLE_ID = -1;
            oTable.TABLE_NAME = "jan 6";
            oTable.TABLE_AGE_COUNTER = 40;
            oTable.IS_CHARGING = true;
            oTable.CHARGING_PERCENTAGE = 100;
            oTable.NB_OF_TYPE_A = 51;
            oTable.NB_OF_TYPE_C = 50;
            oTable.IS_READY = false;
            oTable.OWNER_ID = 1;
            oTable.ENTRY_USER_ID = 1;

            oBLC.Edit_Table(oTable);




        }
    }
}
