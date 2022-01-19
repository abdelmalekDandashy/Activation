using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Data.Linq;

namespace CodeGenerator
{
    class Program
    {
        #region Members
        private static string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
        private static DataContext oDataContext = new DataContext(_ConnectionString);
        private static CodeBoosterClientNS.CodeBoosterClient oCodeBoosterClient = new CodeBoosterClientNS.CodeBoosterClient(oDataContext);
        private static CodeBooster oCodeBooster = oCodeBoosterClient.My_CodeBooster;
        #endregion
        #region Main
        static void Main(string[] args)
        {
            #region Declaration And Initialization Section.
            string str_Option = string.Empty;
            string str_TableName = string.Empty;
            string str_FolderPath = string.Empty;
            Tools.Tools oTools = new Tools.Tools();

            Hierarchy oHierarchy = new Hierarchy();
            OneToMany oOneToMany = new OneToMany();
            List<String> oList_ChildTables = new List<string>();

            Hierarchy oApplicationHierarchy = new Hierarchy();


            // Initialization.
            // ---------------------------------------------------------------------   
            oCodeBooster.Tables_Excluded_From_Generatrion_Process = new List<string>();
            oCodeBooster.KeysMapper = new Dictionary<string, string>();
            oCodeBooster.APIMethodsGenerationMode = Enum_APIMethodsGenerationMode.Selection;
            oCodeBooster.APIMethodsSelection = new List<string>();
            oCodeBooster.Methods_With_Events = new List<string>();
            oCodeBooster.DefaultRecordsToCreate = new Dictionary<string, string>();
            oCodeBooster.Tables_Static_Data = new List<string>();
            oCodeBooster.NonSetup_Fields = new List<string>();
            oCodeBooster.Tables_To_Create_Get_By_Hierarchy = new List<HierarchyBracket>();
            oCodeBooster.Tables_Exluded_From_12M_Hanlder = new List<string>();
            oCodeBooster.ByPassed_PreCheck_Notifications = new List<Notification_ByPassing>();
            oCodeBooster.AssemblyPath = ConfigurationManager.AppSettings["BLC_PATH"];
            oCodeBooster.Is_Generate_API_Caller = true;
            oCodeBooster.Is_Generate_Kotlin_API_Caller = true;
            oCodeBooster.Is_Generate_Swift_API_Caller = true;
            oCodeBooster.Android_Package_Name = "com.example.roni.myapplication";
            oCodeBooster.Is_Apply_Minification = false;
            oCodeBooster.Is_Show_Notifications_In_Console = true;
            oCodeBooster.Is_Create_DB_Demo = false;
            oCodeBoosterClient.Is_Handle_Custom_Procedures = true;
            oCodeBoosterClient.Authenticate_User();


            Params_ConvertTypeSchemaToUIFields oParams_ConvertTypeSchemaToUIFields = new Params_ConvertTypeSchemaToUIFields();
            Search_AdvancedProp oSearch_AdvancedProp = new Search_AdvancedProp();
            WebClient oWebClient = new WebClient();
            UIFields oUIFields = new UIFields();
            // ---------------------------------------------------------------------   


            #region Exluded Tables From Generation Process
            oCodeBooster.Tables_Excluded_From_Generatrion_Process = new List<string>();
            //oCodeBooster.Tables_Excluded_From_Generatrion_Process.Add("[TBL_MENU]");
            //oCodeGenerator.Tables_Excluded_From_Generatrion_Process.Add("[TBL_ACCOUNT]");
            #endregion
            #region Excluded Properties From Generation Process
            oCodeBooster.Properties_Excluded_From_Generation_Process = new List<string>();
            //oCodeBooster.Properties_Excluded_From_Generation_Process.Add("[TBL_LEG_PRODUCT]");
            //oCodeBooster.Properties_Excluded_From_Generation_Process.Add("[TBL_LEG_PRODUCT_EINFO]");
            #endregion
            #region Keys Mapper
            //oCodeBooster.KeysMapper.Add("[MAIN_ID]", "[PERSON_ID]");
            //oCodeBooster.KeysMapper.Add("[REL_ID]", "[PERSON_ID]");                        
            #endregion
            #region Events
            //oCodeBooster.Methods_With_Events.Add("Edit_Car");
            //oCodeBooster.Methods_With_Events.Add("Delete_Car");
            //oCodeBooster.Methods_With_Events.Add("Edit_Uploaded_file");
            //oCodeBooster.Methods_With_Events.Add("Edit_Table");
            oCodeBooster.Methods_With_Events.Add("Edit_Table");
            #endregion
            #region Excluding Tables From 12M Hanlder
            oCodeBooster.Tables_Exluded_From_12M_Hanlder = new List<string>();
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_OWNER]");
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_USER]");
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_INC]");
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_SETUP]");
            #endregion
            #region Handling Static Data            
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L1]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L2]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L3]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L4]");
            #endregion
            #region Uploaded_files
            //oCodeBooster.Is_Uploaded_File_Feature = true;
            //oCodeBooster.Uploaded_Files_BackEnd_Events = new List<Uploaded_File_BackEnd_Event>();
            //oCodeBooster.Uploaded_Files_BackEnd_Events.Add
            //    (
            //        new Uploaded_File_BackEnd_Event() 
            //        {
            //            TBL_NAME = "[TBL_USER]", 
            //            UI_METHOD_NAME = "Get_User_By_USER_ID", Mode = 1 
            //        }
            //    );
            //oCodeBooster.Uploaded_Files_BackEnd_Events.Add
            //   (
            //       new Uploaded_File_BackEnd_Event()
            //       {
            //           TBL_NAME = "[TBL_USER]",
            //           UI_METHOD_NAME = "Get_User_By_Where",
            //           Mode = 1
            //       }
            //   );            
            #endregion
            #region Defining Non Setup Fields [Fields That ends with CODE by they are not Setup Fields]
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L1_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L2_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L3_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L4_CODE]");
            #endregion
            #region Audit
            //oCodeBooster.List_Tables_To_Audit = new List<string>();
            //oCodeBooster.List_Tables_To_Audit.Add("[TBL_CAR]");
            #endregion
            #region Custom Procedures / Queries
            //oCodeBooster.List_Procedure_Info = new List<Procedure_Info>();
            //oCodeBooster.List_Procedure_Info.Add
            //        (
            //            new Procedure_Info()
            //            {
            //                Alias = "Get_Person_Test",
            //                Procedure_Name = "UP_GET_TEST",
            //                Result_CLR_Type = "Person",
            //                Result_Mode = Enum_Procedure_Result_Mode.List
            //            }
            //        );

            //oCodeBooster.List_Procedure_Info.Add
            //       (
            //           new Procedure_Info()
            //           {
            //               Alias = "Get_Stats",
            //               Procedure_Name = "GET_STATS",
            //               Result_CLR_Type = "dynamic",
            //               Result_Mode = Enum_Procedure_Result_Mode.List,
            //               Fields = "METHOD_NAME|AVG|NBR|TOTAL_EXECUTE_TIME"
            //           }
            //       );

            //oCodeBooster.List_Procedure_Info.Add
            //      (
            //          new Procedure_Info()
            //          {
            //              Alias = "Get_Stats_2",
            //              Procedure_Name = "GET_STATS_WITH_PARAM",
            //              Result_CLR_Type = "dynamic",
            //              Result_Mode = Enum_Procedure_Result_Mode.List,
            //              Fields = "METHOD_NAME|AVG|NBR|TOTAL_EXECUTE_TIME"
            //          }
            //      );
            #endregion
            #region ByPassing Notification
            oCodeBooster.ByPassed_PreCheck_Notifications = new List<Notification_ByPassing>();
            oCodeBooster.ByPassed_PreCheck_Notifications.Add(new Notification_ByPassing() { TABLE_NAME = "[TBL_USER_TYPE]", COLUMN_NAME = "[USER_TYPE_CODE]", My_PreCheck_To_ByPass = Enum_Precheck_Enum.INVALID_CODE_FIELD });
            oCodeBooster.ByPassed_PreCheck_Notifications.Add(new Notification_ByPassing() { TABLE_NAME = "[TBL_PERSON]", COLUMN_NAME = "[CHILD_PERSON_ID]", My_PreCheck_To_ByPass = Enum_Precheck_Enum.MAPPED_KEY });
            #endregion
            #region Caching
            //oCodeBooster.Is_Caching_Enabled = true;
            //oCodeBooster.Methods_With_Caching = new List<Caching_Topology>();
            //oCodeBooster.Methods_With_Caching.Add(new Caching_Topology() { Method_Name = "Get_Car_By_OWNER_ID", Caching_Level = Enum_Caching_Level.Application });

            //oCodeBooster.Cash_Dropper_Collection = new List<string>();
            //oCodeBooster.Cash_Dropper_Collection.Add("[TBL_CAR]");


            #region System
            //oCodeBooster.Methods_With_Caching.Add(new Caching_Topology() { Method_Name = "Get_City_By_COUNTRY_ID_Adv", Caching_Level = Enum_Caching_Level.Application });
            #endregion


            #endregion
            #region Cascade
            oCodeBooster.List_Cascade_Tables = new List<Cascade>();
            //oCodeBooster.List_Cascade_Tables.Add(new Cascade() { ParentTable = "[TBL_AC_IMAGE]", ChildTables = new List<string>() { "[TBL_AC_IMAGE_RC]" } });

            #endregion

            #endregion
            #region Body Section
            Console.WriteLine("Enter An Option:");
            Console.WriteLine("001 --> Create SP's & BLC Layer");
            Console.WriteLine("002 --> Generate API / JSON Code");
            Console.WriteLine("003 --> Generate UI");
            Console.WriteLine("051 --> Generate Mobile Native UI");

            str_Option = Console.ReadLine();


            #region API


            // Car
            //----------------------------
            //oCodeBooster.APIMethodsSelection.Add("Edit_Car");
            //oCodeBooster.APIMethodsSelection.Add("Delete_Car");
            //oCodeBooster.APIMethodsSelection.Add("Get_Car_By_OWNER_ID");


            oCodeBooster.APIMethodsSelection.Add("Get_Table_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Edit_Table");
            oCodeBooster.APIMethodsSelection.Add("Delete_Tables");


            oCodeBooster.APIMethodsSelection.Add("Get_Extension_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Edit_Extension");



            oCodeBooster.APIMethodsSelection.Add("Get_User_By_USER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Delete_User");
            oCodeBooster.APIMethodsSelection.Add("Edit_User");
            oCodeBooster.APIMethodsSelection.Add("Authenticate");
            //----------------------------

            #endregion
            #region Advanced Options
            oCodeBooster.Is_By_Criteria_Shadowed = true;
            oCodeBooster.Is_Generate_By_RelatedID_List = true;
            oCodeBooster.By_Related_ID_List_GenerationMode = Enum_By_Related_ID_List_GenerationMode.All;
            oCodeBooster.Is_OnDemand_DALC = true;
            #endregion
            #region AZURE
            //oCodeBooster.Is_AZURE_Enabled = false;
            #endregion
            #region MemCached
            //oCodeBooster.Is_MemCached_Enabled = true;
            #endregion

            oCodeBoosterClient.Local_Patch_Folder = @"E:\patches";
            oCodeBoosterClient.Is_Apply_CB_Rules = true;
            oCodeBoosterClient.Show_Embedded_TSql_Exceptions = false;
            oCodeBooster.Is_Profiling_Enabled = false;
            oCodeBooster.Is_Multilingual_Enabled = false;
            oCodeBooster.Is_BackOffice_Enabled = false;
            oCodeBooster.Is_Offline_Enabled = false;
            oCodeBooster.Is_Summary_Enabled = false;
            oCodeBooster.Is_EnvCode_Enabled = false;
            oCodeBooster.Is_Generate_API_Caller = true;
            oCodeBooster.Is_Generate_Kotlin_API_Caller = true;
            oCodeBooster.Is_Generate_Swift_API_Caller = true;
            oCodeBooster.Is_Embed_USE_DB = true;
            oCodeBooster.UI_Root_Folder = @"C:\inetpub\wwwroot\ClinicPlusWeb\Content";
            oCodeBooster.Is_By_Criteria_Shadowed = true;
            #region Inheritance
            #endregion
            switch (str_Option)
            {
                #region case "001":
                case "001":
                    oCodeBooster.Is_Method_Monitoring_Enabled = false;
                    oCodeBooster.Is_Renamed_Routines_Generation_Stopped = true;
                    oCodeBooster.Is_Count_UDF_Generation_Stopped = true;
                    oCodeBooster.Is_Create_Default_Record_Generation_Stopped = true;
                    oCodeBooster.Is_Get_Rows_Generations_Stopped = true;
                    oCodeBooster.Methods_With_Events_By_Ref = new List<string>();
                    //oCodeBooster.Methods_With_Events_By_Ref.Add("Edit_PersoN");
                    oCodeBooster.List_Reset_Topology = new List<Reset_Topology>();
                    //oCodeBooster.List_Reset_Topology.Add(new Reset_Topology() { ParentTable = "[TBL_PERSONS]", ChildTables = new List<string>() { "[TBL_ADDRES]", "[TBL_CONTACT]" } });

                    oCodeBooster.List_Eager_Loading = new List<Eager_Loading>();
                    //oCodeBooster.List_Eager_Loading.Add(new Eager_Loading() { Method_Name = "Get_Ac_By_AC_ID_Adv", ParentTable = "[TBL_AC]", ChildTables = new List<string>() { "[TBL_AC_AMENITY]", "[TBL_AC_CARD]", "[TBL_AC_CONTACT]", "[TBL_AC_IMAGE]", "[TBL_AC_SLIDE]","[TBL_AC_SOCIAL]", "[TBL_AC_HWS_INFO]", "[TBL_AC_HWS_XPAGE]", "[TBL_AC_PICKUP]", "[TBL_AC_THEME]", "[TBL_AC_DESCRIPTION]", "[TBL_AC_GW]" } });

                    #region One2Many
                    oCodeBooster.List_Inheritance = new List<Inheritance>();
                    //oCodeBooster.List_Inheritance.Add(new Inheritance() { ParentTable = "[TBL_PERSON]", ChildTable = "[TBL_ADDRESS]", RelationField = "[PERSON_ID]", RelationType = "12M" });                    
                    #endregion
                    #region Generate SP's & BLC Layer
                    oCodeBoosterClient.GenerateAllSPAndBLCLayer();
                    #endregion
                    break;
                #endregion
                #region case "002":
                case "002":

                    oCodeBooster.My_Enum_API_Target = Enum_API_Target.WebAPI;
                    oCodeBooster.My_Enum_API_Accessibility = Enum_API_Accessibility.Same_Domain;

                    oCodeBooster.List_ByPass_Ticketing = new List<string>();
                    oCodeBooster.List_ByPass_Ticketing.Add("Authenticate");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_NearBy_Ac_List");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_By_OWNER_ID_Adv");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Currency_By_OWNER_ID");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Language_By_OWNER_ID");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_By_AC_ID_Adv");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Rate_Matrix");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_Front_Data");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Application_Cached_Entry");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Delete_Fictitious_Bookings");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Startup_Data_Signature");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Startup_Data");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Person_By_Email");
                    //oCodeBooster.List_ByPass_Ticketing.Add("CheckUserExistence");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Edit_Person");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Application_Cached_Entry");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Gate_Rate_Matrix_Cached_Entry");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Get_Ac_Front_Data_Application_Cached_Entry_By_Ac");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Cached_Hotel_Page");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Issue_Booking");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Seriliaze_Booking_02");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Send_Email");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Request_Booking_Cancelation");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Convert_Booking_Data_URI_To_Image");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Guest_Specific_Booking");
                    ////oCodeBooster.List_ByPass_Ticketing.Add("Send_HWS_ContactUs_Email");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_pickup_By_AC_ID_Adv");
                    ////oCodeBooster.List_ByPass_Ticketing.Add("Chm_Booking_Handler");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_Lowest_Price_PerCountry");


                    
                    // --------------                                        
                    oCodeBoosterClient.GenerateAPILayer();
                    // --------------

                    break;
                #endregion
                #region case "003":
                case "003":

                    // --------------
                    UIFields oUIFields_EditUI = new UIFields();
                    UIFields oUIFields_Criteria = new UIFields();
                    UIFields oUIFields_Result = new UIFields();
                    // --------------

                    // --------------
                    oCodeBooster.My_Enum_UI_Target = Enum_UI_Target.HTML5;
                    oCodeBooster.My_Enum_HTML5_Target = Enum_HTML5_Target.NG;
                    // --------------


                    // Gather Required Data.
                    // --------------
                    oCodeBoosterClient.Gather_Required_Data();
                    // --------------

                    // Cleans UI Folder
                    // --------------
                    oCodeBoosterClient.Cleanse_UI_Patch_Folder();
                    // --------------

                    #region Person
                    #region Search Screen
                    oUIFields_Criteria = new UIFields();
                    oUIFields_Criteria.MainTableName = "[TBL_PERSON]";
                    oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Person_By_Criteria";

                    oUIFields_Result = new UIFields();
                    oUIFields_Result.MainTableName = "[TBL_PERSON]";
                    oUIFields_Result.Based_On_Type = "BLC.Person";
                    oUIFields_Result.GetMethodName = "Get_Person_By_Criteria";
                    oUIFields_Result.GridFields = new List<GridField>();



                    oSearch_AdvancedProp = new Search_AdvancedProp();
                    oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    oCodeBooster.Entity_FriendlyName = "Person";
                    oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    #endregion
                    #endregion


                    // Send UI Patch
                    // -------------
                    oCodeBoosterClient.Send_UI_Patch();
                    // --------------

                    break;
                #endregion
                #region Case "051"
                case "051":
                    Params_Generate_Mobile_Native_UI oParams_Generate_Mobile_Native_UI = new Params_Generate_Mobile_Native_UI();
                    oParams_Generate_Mobile_Native_UI.MOBILE_PLATFORM = "ANDROID";
                    oParams_Generate_Mobile_Native_UI.VIEW_TYPE = "001";
                    oParams_Generate_Mobile_Native_UI.TABLE_NAME = "[TBL_AC]";
                    oParams_Generate_Mobile_Native_UI.GET_METHOD_NAME = "Get_Ac_By_Where";
                    oParams_Generate_Mobile_Native_UI.TITLE = "Hotels";
                    oParams_Generate_Mobile_Native_UI.BAR_BUTTON_ITEM_TITLE = "Bla Bla";
                    oParams_Generate_Mobile_Native_UI.IMAGE_BASE_URL = @"https://www.igloorooms.com/irimages/aclogo/AcLogo_\(myData[indexPath.row].AC_ID!).jpg";
                    //oCodeBoosterClient.Generate_Mobile_Native_UI(oParams_Generate_Mobile_Native_UI);

                    oParams_Generate_Mobile_Native_UI = new Params_Generate_Mobile_Native_UI();
                    oParams_Generate_Mobile_Native_UI.MOBILE_PLATFORM = "IOS";
                    oParams_Generate_Mobile_Native_UI.VIEW_TYPE = "001";
                    oParams_Generate_Mobile_Native_UI.TABLE_NAME = "[TBL_AC]";
                    oParams_Generate_Mobile_Native_UI.GET_METHOD_NAME = "Get_Ac_By_Where";
                    oParams_Generate_Mobile_Native_UI.TITLE = "Hotels";
                    oParams_Generate_Mobile_Native_UI.BAR_BUTTON_ITEM_TITLE = "Bla Bla";
                    oParams_Generate_Mobile_Native_UI.IMAGE_BASE_URL = @"https://www.igloorooms.com/irimages/aclogo/AcLogo_\(myData[indexPath.row].AC_ID!).jpg";
                    //oCodeBoosterClient.Generate_Mobile_Native_UI(oParams_Generate_Mobile_Native_UI);

                    break;
                    #endregion
            }
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadLine();
            #endregion
        }
        #endregion
    }
}




