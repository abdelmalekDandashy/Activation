﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace BLC
{
    #region BLC
    public partial class BLC : IDisposable
    {
        #region Enumeration
        public enum Enum_Language
        {
            English = 0,
            French = 1,
            Arabic = 2
        }
        public enum Enum_BR_Codes
        {
            BR_9999,  // Invalid Credentials
            BR_0000,  // Uniqueness Violation                      
            BR_0001   // Password should be at least 4 characters 
        }
        public enum Enum_EditMode
        {
            Add,
            Update
        }
        public enum Enum_Environment
        {
            BHS = 0,
            MS  = 1
        }
        public enum Enum_GradeMode
        {
            Over_One_Hundred = 0,
            Assignment = 1
        }
        #endregion
        #region Members
        private string _ConnectionString = string.Empty;
        DALC.IDALC _AppContext = null;     
        #endregion
        #region Properties
	public Tools.Tools oTools { get; set; }
        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value;
            }
        }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        public List<Message> Messages { get; set; }
        public Enum_Environment Environment { get; set; }
        
        #endregion       
        #region Constructor
        public BLC()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            #endregion
        }
        public BLC(BLCInitializer i_BLCInitializer)
        {
            #region Declaration And Initialization Section.    
            Tools.Tools oTools = new Tools.Tools(); 
            #endregion
            #region Body Section.
            // ---------------------
            ConnectionString = i_BLCInitializer.ConnectionString;
            UserID = i_BLCInitializer.UserID;
            OwnerID = i_BLCInitializer.OwnerID;
            Language = i_BLCInitializer.Language;
            Messages_FilePath = i_BLCInitializer.Messages_FilePath;
            _AppContext = new DALC.MSSQL_DALC(_ConnectionString);
            this.oTools = new Tools.Tools();
            // ---------------------

            // ---------------------
            LoadMessages();
            SubscribeToEvents();
            //Initialize_Audit_Mechanism();
            // ---------------------
                      

            #endregion
        }
        #endregion
        #region Subscribe To Events
        public void SubscribeToEvents()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            this.OnPreEvent_Edit_Table += BLC_OnPreEvent_Edit_Table;
            this.OnPostEvent_Edit_Table += BLC_OnPostEvent_Edit_Table;
            this.OnPreEvent_Edit_Tables += BLC_OnPreEvent_Edit_Tables;
            this.OnPostEvent_Edit_Tables += BLC_OnPostEvent_Edit_Tables;

           
            #endregion
        }

        private void BLC_OnPostEvent_Edit_Tables(Table i_Table, Enum_EditMode i_Enum_EditMode)
        {
            //throw new NotImplementedException();
        }

        private void BLC_OnPreEvent_Edit_Tables(Table i_Table, Enum_EditMode i_Enum_EditMode)
        {
            //throw new NotImplementedException();
        }

        private void BLC_OnPostEvent_Edit_Table(Table i_Table, Enum_EditMode i_Enum_EditMode)
        {

            //throw new NotImplementedException();
            //var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
            //var result = this.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);


        }

        private void BLC_OnPreEvent_Edit_Table(Table i_Table, Enum_EditMode i_Enum_EditMode)
        {   


            //#region check_if_extensions_are_available
            //Params_Get_Extension_By_OWNER_ID oParams_Get_Extension_By_OWNER_ID = new Params_Get_Extension_By_OWNER_ID();
            //oParams_Get_Extension_By_OWNER_ID.OWNER_ID = 1;

            //var result = this.Get_Extension_By_OWNER_ID(oParams_Get_Extension_By_OWNER_ID);
            
            //if (result.Count >= 2 && i_Table.TABLE_ID == -1)
            //{   
            //    Console.WriteLine(result);
                
            //    if (result[0].NUMBER_OF_EXTENSIONS < i_Table.NB_OF_TYPE_A)
            //    {
            //        throw new BLCException("you don't have enough type A extensions");
            //    }


            //    if (result[1].NUMBER_OF_EXTENSIONS < i_Table.NB_OF_TYPE_C)
            //    {
            //        throw new BLCException("you don't have enough type C extensions");
            //    }

            //    #region na22ess_extensions_men_db
            //    result[0].NUMBER_OF_EXTENSIONS = result[0].NUMBER_OF_EXTENSIONS - i_Table.NB_OF_TYPE_A;
            //    Edit_Extension(result[0]);
                
            //    result[1].NUMBER_OF_EXTENSIONS = result[1].NUMBER_OF_EXTENSIONS - i_Table.NB_OF_TYPE_C;
            //    Edit_Extension(result[1]);


            //    #endregion

            //    //throw new NotImplementedException();
            //}

            //#endregion


            //if(i_Table.TABLE_ID == -1)
            //{
            //    i_Table.CHARGING_PERCENTAGE = 10;
            //    i_Table.IS_CHARGING = true;
            //    i_Table.IS_READY = false;
            //}

        }
        #endregion
        #region IDisposable Members
        public void Dispose()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region LoadMessages
        public void LoadMessages()
        {
            #region Declaration And Initialization Section.
            XElement oRoot = null;
            XElement oLanguage = null;
            #endregion
            #region Body Section.
            this.Messages = new List<Message>();

            if (!string.IsNullOrEmpty(this.Messages_FilePath))
            {
                oRoot = XElement.Load(this.Messages_FilePath);
                if (oRoot != null)
                {
                    switch (Language)
                    {
                        case Enum_Language.English:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                        case Enum_Language.Arabic:
                            oLanguage = oRoot.Element("ARABIC");
                            break;
                        default:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                    }

                    foreach (var oItem in oLanguage.Elements("MESSAGE"))
                    {
                        this.Messages.Add(new Message() { Code = oItem.Attribute("CODE").Value, Content = oItem.Attribute("CONTENT").Value });
                    }
                }
            }
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code, Dictionary<string, string> i_PlaceHolders)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;

            foreach (var oItem in i_PlaceHolders)
            {
                str_ReturnValue = str_ReturnValue.Replace(oItem.Key, oItem.Value);
            }
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region Events Implementation

        #endregion
    }
    #endregion
    #region BLCInitializer
    public class BLCInitializer
    {
        #region Properties
        public string ConnectionString { get; set; }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public BLC.Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        #endregion
    }
    #endregion
    #region Message
    public class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region EnvCode Attribute
    #region EnvCode
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = true)]
    public class EnvCode : System.Attribute
    {
        #region Properties
        public BLC.Enum_Environment Environment { get; set; }
        public string MethodName { get; set; }
        #endregion
        #region Constructor
        public EnvCode(BLC.Enum_Environment i_Environment, string i_MethodName)
        {
            #region Body Section.
            Environment = i_Environment;
            MethodName = i_MethodName;
            #endregion
        }
        #endregion
        #region Behavior
        #region GetEnvCode
        public static MethodInfo GetEnvCode(Params_GetEnvCode i_Params_GetEnvCode)
        {
            #region Declaration And Initialization Section.
            MethodInfo[] oMethods = null;
            MethodInfo oMethodInfo = null;
            object[] oAttributes = null;
            EnvCode oEnvCode = null;

            bool Is_AlreadyFound = false;
            MethodInfo oMethodInfo_ReturnValue = null;
            #endregion
            #region Body Section.

            // ----------------------
            oMethods = i_Params_GetEnvCode.My_Type.GetMethods();
            // ----------------------

            // ----------------------
            for (int i = 0; i < oMethods.GetLength(0); i++)
            {
                // ----------------------
                if (Is_AlreadyFound == true)
                {
                    break;
                }
                // ----------------------

                // ----------------------
                oMethodInfo = oMethods[i];
                oAttributes = oMethodInfo.GetCustomAttributes(true);
                // ----------------------

                // ----------------------
                foreach (Attribute oAttribute in oAttributes)
                {
                    if (oAttribute is EnvCode)
                    {
                        oEnvCode = oAttribute as EnvCode;
                        if (oEnvCode != null)
                        {
                            if ((oEnvCode.Environment == i_Params_GetEnvCode.My_Environment) && (oEnvCode.MethodName == i_Params_GetEnvCode.My_MethodName))
                            {
                                oMethodInfo_ReturnValue = oMethodInfo;
                                Is_AlreadyFound = true;
                                break;
                            }
                        }
                    }
                }
                // ----------------------
            }
            // ----------------------
            #endregion
            #region Return Section.
            return oMethodInfo_ReturnValue;
            #endregion
        }
        #endregion
        #endregion
    }
    #endregion
    #region Params_GetEnvCode
    public class Params_GetEnvCode
    {
        #region Properties.
        public System.Type My_Type { get; set; }
        public BLC.Enum_Environment My_Environment { get; set; }
        public string My_MethodName { get; set; }
        #endregion
    }
    #endregion
    #endregion
}


