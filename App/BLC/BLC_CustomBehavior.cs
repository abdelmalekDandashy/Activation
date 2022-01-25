using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Transactions;

namespace BLC
{
    #region Enumeration
    public enum Enum_EntityNameFormat
    {
        FML,
        FLM,
        MFL,
        MLF,
        LFM,
        LMF
    }
    #endregion
    public partial class BLC
    {
        #region Members
        #endregion        
        #region Setup
        #region EditSetup
        #region EditSetup
        public void EditSetup(SetupEntry i_SetupEntry)
        {
            #region Declaration And Initialization Section.
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "EditSetup";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                oMethodInfo.Invoke(this, new object[] { i_SetupEntry });
                return;
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("EditSetup");
            }
            #endregion
            #region Body Section.
            i_SetupEntry.ENTRY_USER_ID = this.UserID;
            i_SetupEntry.OWNER_ID = this.OwnerID;
            i_SetupEntry.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            oTools.InvokeMethod(_AppContext, "UP_EDIT_SETUP", i_SetupEntry);
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("EditSetup");
            }
            #endregion
        }
        #endregion
        #endregion
        #endregion
        #region Ticket
        #region ResolveTicket
        public Dictionary<string, string> ResolveTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            string str_Ticket_PlainText = string.Empty;
            Crypto.Crypto oCrypto = new Crypto.Crypto();
            string[] oMainTempList = null;
            string[] oSubTempList = null;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                //str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
                str_Ticket_PlainText = i_Input;

                if (!string.IsNullOrEmpty(str_Ticket_PlainText))
                {
                    oMainTempList = str_Ticket_PlainText.Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries);

                    var oQuery = from oItem in oMainTempList
                                 select oItem;

                    foreach (var oRow in oQuery)
                    {
                        oSubTempList = oRow.Split(new string[] { ":" }, StringSplitOptions.None);
                        oList.Add(oSubTempList[0], oSubTempList[1]);
                    }
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion
        #region IsValidTicket
        public bool IsValidTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            long? i_MinutesElapsedSinceMidnight = 0;
            string str_CurrentDate = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            Dictionary<string, string> oTicketParts = new Dictionary<string, string>();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "IsValidTicket";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                return Convert.ToBoolean(oMethodInfo.Invoke(this, new object[] { i_Input }));
                // Intentially Left Empty.
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("IsValidTicket");
            }
            #endregion
            #region Body Section.
            try
            {
                oTicketParts = ResolveTicket(i_Input);
                str_CurrentDate = oTools.GetDateString(DateTime.Today);

                if (oTicketParts["START_DATE"] == str_CurrentDate) // Session Started In Different Day.
                {
                    i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;

                    if (i_MinutesElapsedSinceMidnight <= Convert.ToInt32(oTicketParts["START_MINUTE"]) + Convert.ToInt32(oTicketParts["SESSION_PERIOD"]))
                    {
                        Is_ValidTicket = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Is_ValidTicket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("IsValidTicket");
            }
            #endregion
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #endregion
        #region auth
        public User Authenticate(Params_Authenticate i_Params_Authenticate)
        {
            #region declaration

            User oUser = new User();
            #endregion

            List<dynamic> oList = _AppContext.UP_GET_USER_BY_CREDENTIALS(i_Params_Authenticate.OWNER_ID,i_Params_Authenticate.USERNAME,i_Params_Authenticate.PASSWORD);
            if ((oList != null) && (oList.Count > 0))
            {
                if (i_Params_Authenticate.PASSWORD == oList[0].PASSWORD)
                {
                    oUser.USER_ID = oList[0].USER_ID;
                    oUser.OWNER_ID = oList[0].OWNER_ID;
                    oUser.USERNAME = oList[0].USERNAME;

                    var oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID() { USER_ID = oList[0].USER_ID };

                    var userResult = this.Get_User_By_USER_ID(oParams_Get_User_By_USER_ID);

                    if(userResult != null)
                    {
                        oUser.USER_TYPE_CODE = userResult.USER_TYPE_CODE;
                    }

                   
                    //oUser.USER_TYPE_CODE = oList[0].USER_TYPE_CODE;


                    //oUser.My_User_type_code = oList[0].My_User_type_code;

                }

            }
            else
            {
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_9999));
            }

            return oUser;

        }
        #endregion
        #region delete_table
        public List<Table> Delete_Tables(Params_Delete_Tables i_Params_Delete_Tables)
        {
            var oListTables = new List<Table>();

            Params_Get_Table_By_TABLE_ID oParams_Get_Table_By_TABLE_ID = new Params_Get_Table_By_TABLE_ID();
            if (OnPreEvent_General != null) { OnPreEvent_General("Delete_Table"); }
            #region Body Section.
            try
            {
                oParams_Get_Table_By_TABLE_ID.TABLE_ID = i_Params_Delete_Tables.TABLE_ID;
                _Table = Get_Table_By_TABLE_ID_Adv(oParams_Get_Table_By_TABLE_ID);
                if (_Table != null)
                {
                    using (TransactionScope oScope = new TransactionScope())
                    {
                        if (_Stop_Delete_Table_Execution)
                        {
                            _Stop_Delete_Table_Execution = false;
                            throw new BLCException("deletion was stopped");
                        }
                        _AppContext.Delete_Table(i_Params_Delete_Tables.TABLE_ID);
                        oScope.Complete();
                    }
                }
                if (_Table.TABLE_ID == null)
                {
                    throw new BLCException("table you wanted to delete was not found");
                }

                if(_Table != null)
                {
                    var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = 1 };
                    var oResultListTables = this.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);
                    if (oResultListTables.Count > 0)
                    {
                        oListTables = oResultListTables;
                        return oListTables;
                    }
                    
                }
                
                if (OnPostEvent_General != null) { OnPostEvent_General("Delete_Table"); }

               
            }
            catch (BLCException blcex)
            {
                throw new BLCException(blcex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLCException("Cannot be deleted because of related records in other tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            Console.WriteLine(oListTables);
            return oListTables;
        }
        #endregion

        #region edit_tables
        public List<Table> Edit_Tables(Table i_Table)
        {
            var oListTables = new List<Table>();
            Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
            if (i_Table.TABLE_ID == -1)
            {
                oEditMode_Flag = Enum_EditMode.Add;
            }
            if (OnPreEvent_General != null) { OnPreEvent_General("Edit_Tables"); }
            #region Body Section.
            if ((i_Table.TABLE_ID == null) || (i_Table.TABLE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Tables"); }
            i_Table.ENTRY_USER_ID = this.UserID;
            i_Table.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            i_Table.OWNER_ID = this.OwnerID;
            using (TransactionScope oScope = new TransactionScope())
            {
                #region PreEvent_Edit_Tables
                if (OnPreEvent_Edit_Tables != null)
                {
                    OnPreEvent_Edit_Tables(i_Table, oEditMode_Flag);
                }
                #endregion
                if (_Stop_Edit_Table_Execution)
                {
                    _Stop_Edit_Table_Execution = false;
                   
                }
                i_Table.TABLE_ID = _AppContext.Edit_Table
                (
                    i_Table.TABLE_ID
                    , i_Table.TABLE_NAME
                    , i_Table.TABLE_AGE_COUNTER
                    , i_Table.IS_CHARGING
                    , i_Table.NB_OF_TYPE_A
                    , i_Table.NB_OF_TYPE_C
                    , i_Table.CHARGING_PERCENTAGE
                    , i_Table.DEPO_ID
                    , i_Table.IS_READY
                    , i_Table.ENTRY_USER_ID
                    , i_Table.ENTRY_DATE
                    , i_Table.OWNER_ID
                );

                
                #region PostEvent_Edit_Tables
                if (OnPostEvent_Edit_Tables != null)
                {
                    OnPostEvent_Edit_Tables(oListTables, i_Table, oEditMode_Flag);
                }
                #endregion
                oScope.Complete();
            }
            #region get_tables
            Params_Get_Table_By_TABLE_ID oParams_Get_Table_By_TABLE_ID = new Params_Get_Table_By_TABLE_ID();

            oParams_Get_Table_By_TABLE_ID.TABLE_ID = i_Table.TABLE_ID;
            _Table = Get_Table_By_TABLE_ID(oParams_Get_Table_By_TABLE_ID);

            if (_Table.TABLE_ID != null)
            {
                var oParams_Get_Table_By_OWNER_ID = new Params_Get_Table_By_OWNER_ID() { OWNER_ID = this.OwnerID };
                var oResultListTables = this.Get_Table_By_OWNER_ID(oParams_Get_Table_By_OWNER_ID);
                if (oResultListTables.Count > 0)
                {
                    oListTables = oResultListTables;
                    return oListTables;
                }

            }
            if (_Table.TABLE_ID == null)
            {
                throw new BLCException("Could not find table that you Want to Edit");
            }


            #endregion
            #endregion
            if (OnPostEvent_General != null) { OnPostEvent_General("Edit_Table"); }

            return oListTables;

        }

  
        #endregion
    }
    #region Business Entities
    #region Setup
    #region SetupEntry
    public class SetupEntry
    {
        #region Properties
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISDELETEABLE { get; set; }
        public bool? ISUPDATEABLE { get; set; }
        public bool? ISVISIBLE { get; set; }
        public bool? ISDELETED { get; set; }
        public Int32? DISPLAY_ORDER { get; set; }
        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string NOTES { get; set; }

        public string INVARIANT_VALUE { get; set; }
        #endregion
    }
    #endregion    
    #endregion
    public class Params_Authenticate
    {
        #region Properties

        public int OWNER_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }

        #endregion
    }

    #region Params_Delete_Tables
    public partial class Params_Delete_Tables
    {
        #region Properties
        public Int32? TABLE_ID { get; set; }
        #endregion
    }
    #endregion
    #region table advanced
    #region Table

    #endregion
    #endregion
    #endregion

    #region Uploaded_file
    public partial class Uploaded_file
    {
        public string My_URL { get; set; }
    }
    #endregion
   
}


