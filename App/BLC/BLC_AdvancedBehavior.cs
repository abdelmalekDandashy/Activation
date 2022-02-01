using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
public Depo Get_Depo_By_DEPO_ID_Adv(Params_Get_Depo_By_DEPO_ID i_Params_Get_Depo_By_DEPO_ID)
{
Depo oDepo = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Depo_By_DEPO_ID_Adv");}
#region Body Section.
DALC.Depo oDBEntry = _AppContext.Get_Depo_By_DEPO_ID_Adv(i_Params_Get_Depo_By_DEPO_ID.DEPO_ID);
oDepo = new Depo();
oTools.CopyPropValues(oDBEntry, oDepo);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Depo_By_DEPO_ID_Adv");}
return oDepo;
}
public Table Get_Table_By_TABLE_ID_Adv(Params_Get_Table_By_TABLE_ID i_Params_Get_Table_By_TABLE_ID)
{
Table oTable = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_TABLE_ID_Adv");}
#region Body Section.
DALC.Table oDBEntry = _AppContext.Get_Table_By_TABLE_ID_Adv(i_Params_Get_Table_By_TABLE_ID.TABLE_ID);
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_TABLE_ID_Adv");}
return oTable;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public List<Depo> Get_Depo_By_DEPO_ID_List_Adv(Params_Get_Depo_By_DEPO_ID_List i_Params_Get_Depo_By_DEPO_ID_List)
{
Depo oDepo = null;
List<Depo> oList = new List<Depo>();
Params_Get_Depo_By_DEPO_ID_List_SP oParams_Get_Depo_By_DEPO_ID_List_SP = new Params_Get_Depo_By_DEPO_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Depo_By_DEPO_ID_List_Adv");}
#region Body Section.
List<DALC.Depo> oList_DBEntries = _AppContext.Get_Depo_By_DEPO_ID_List_Adv(i_Params_Get_Depo_By_DEPO_ID_List.DEPO_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oDepo = new Depo();
oTools.CopyPropValues(oDBEntry, oDepo);
oList.Add(oDepo);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Depo_By_DEPO_ID_List_Adv");}
return oList;
}
public List<Table> Get_Table_By_TABLE_ID_List_Adv(Params_Get_Table_By_TABLE_ID_List i_Params_Get_Table_By_TABLE_ID_List)
{
Table oTable = null;
List<Table> oList = new List<Table>();
Params_Get_Table_By_TABLE_ID_List_SP oParams_Get_Table_By_TABLE_ID_List_SP = new Params_Get_Table_By_TABLE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_TABLE_ID_List_Adv");}
#region Body Section.
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_TABLE_ID_List_Adv(i_Params_Get_Table_By_TABLE_ID_List.TABLE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_TABLE_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<Depo> Get_Depo_By_OWNER_ID_Adv(Params_Get_Depo_By_OWNER_ID i_Params_Get_Depo_By_OWNER_ID)
{
List<Depo> oList = new List<Depo>();
Depo oDepo = new Depo();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Depo_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Depo> oList_DBEntries = _AppContext.Get_Depo_By_OWNER_ID_Adv(i_Params_Get_Depo_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oDepo = new Depo();
oTools.CopyPropValues(oDBEntry, oDepo);
oList.Add(oDepo);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Depo_By_OWNER_ID_Adv");}
return oList;
}
public List<Table> Get_Table_By_OWNER_ID_Adv(Params_Get_Table_By_OWNER_ID i_Params_Get_Table_By_OWNER_ID)
{
List<Table> oList = new List<Table>();
Table oTable = new Table();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_OWNER_ID_Adv(i_Params_Get_Table_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_OWNER_ID_Adv");}
return oList;
}
public List<Table> Get_Table_By_DEPO_ID_Adv(Params_Get_Table_By_DEPO_ID i_Params_Get_Table_By_DEPO_ID)
{
List<Table> oList = new List<Table>();
Table oTable = new Table();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_DEPO_ID_Adv");}
#region Body Section.
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_DEPO_ID_Adv(i_Params_Get_Table_By_DEPO_ID.DEPO_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_DEPO_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<Table> Get_Table_By_DEPO_ID_List_Adv(Params_Get_Table_By_DEPO_ID_List i_Params_Get_Table_By_DEPO_ID_List)
{
List<Table> oList = new List<Table>();
Table oTable = new Table();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_DEPO_ID_List_Adv");}
#region Body Section.
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_DEPO_ID_List_Adv(i_Params_Get_Table_By_DEPO_ID_List.DEPO_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_DEPO_ID_List_Adv");}
return oList;
}
public List<Depo> Get_Depo_By_Criteria_Adv(Params_Get_Depo_By_Criteria i_Params_Get_Depo_By_Criteria)
{
List<Depo> oList = new List<Depo>();
long? tmp_TOTAL_COUNT = 0;
Depo oDepo = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Depo_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Depo_By_Criteria.OWNER_ID == null) || (i_Params_Get_Depo_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Depo_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Depo_By_Criteria.START_ROW == null) { i_Params_Get_Depo_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Depo_By_Criteria.END_ROW == null) || (i_Params_Get_Depo_By_Criteria.END_ROW == 0)) { i_Params_Get_Depo_By_Criteria.END_ROW = 1000000; }
List<DALC.Depo> oList_DBEntries = _AppContext.Get_Depo_By_Criteria_Adv(i_Params_Get_Depo_By_Criteria.DEPO_NAME,i_Params_Get_Depo_By_Criteria.OWNER_ID,i_Params_Get_Depo_By_Criteria.START_ROW,i_Params_Get_Depo_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oDepo = new Depo();
oTools.CopyPropValues(oDBEntry, oDepo);
oList.Add(oDepo);
}
}
i_Params_Get_Depo_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Depo_By_Criteria_Adv");}
return oList;
}
public List<Depo> Get_Depo_By_Where_Adv(Params_Get_Depo_By_Where i_Params_Get_Depo_By_Where)
{
List<Depo> oList = new List<Depo>();
long? tmp_TOTAL_COUNT = 0;
Depo oDepo = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Depo_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Depo_By_Where.OWNER_ID == null) || (i_Params_Get_Depo_By_Where.OWNER_ID == 0)) { i_Params_Get_Depo_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Depo_By_Where.START_ROW == null) { i_Params_Get_Depo_By_Where.START_ROW = 0; }
if ((i_Params_Get_Depo_By_Where.END_ROW == null) || (i_Params_Get_Depo_By_Where.END_ROW == 0)) { i_Params_Get_Depo_By_Where.END_ROW = 1000000; }
List<DALC.Depo> oList_DBEntries = _AppContext.Get_Depo_By_Where_Adv(i_Params_Get_Depo_By_Where.DEPO_NAME,i_Params_Get_Depo_By_Where.OWNER_ID,i_Params_Get_Depo_By_Where.START_ROW,i_Params_Get_Depo_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oDepo = new Depo();
oTools.CopyPropValues(oDBEntry, oDepo);
oList.Add(oDepo);
}
}
i_Params_Get_Depo_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Depo_By_Where_Adv");}
return oList;
}
public List<Table> Get_Table_By_Criteria_Adv(Params_Get_Table_By_Criteria i_Params_Get_Table_By_Criteria)
{
List<Table> oList = new List<Table>();
long? tmp_TOTAL_COUNT = 0;
Table oTable = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Table_By_Criteria.OWNER_ID == null) || (i_Params_Get_Table_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Table_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Table_By_Criteria.START_ROW == null) { i_Params_Get_Table_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Table_By_Criteria.END_ROW == null) || (i_Params_Get_Table_By_Criteria.END_ROW == 0)) { i_Params_Get_Table_By_Criteria.END_ROW = 1000000; }
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_Criteria_Adv(i_Params_Get_Table_By_Criteria.TABLE_NAME,i_Params_Get_Table_By_Criteria.OWNER_ID,i_Params_Get_Table_By_Criteria.START_ROW,i_Params_Get_Table_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
i_Params_Get_Table_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_Criteria_Adv");}
return oList;
}
public List<Table> Get_Table_By_Where_Adv(Params_Get_Table_By_Where i_Params_Get_Table_By_Where)
{
List<Table> oList = new List<Table>();
long? tmp_TOTAL_COUNT = 0;
Table oTable = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Table_By_Where.OWNER_ID == null) || (i_Params_Get_Table_By_Where.OWNER_ID == 0)) { i_Params_Get_Table_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Table_By_Where.START_ROW == null) { i_Params_Get_Table_By_Where.START_ROW = 0; }
if ((i_Params_Get_Table_By_Where.END_ROW == null) || (i_Params_Get_Table_By_Where.END_ROW == 0)) { i_Params_Get_Table_By_Where.END_ROW = 1000000; }
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_Where_Adv(i_Params_Get_Table_By_Where.TABLE_NAME,i_Params_Get_Table_By_Where.OWNER_ID,i_Params_Get_Table_By_Where.START_ROW,i_Params_Get_Table_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
i_Params_Get_Table_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.FIREBASE_TOKEN,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.FIREBASE_TOKEN,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<Table> Get_Table_By_Criteria_InList_Adv(Params_Get_Table_By_Criteria_InList i_Params_Get_Table_By_Criteria_InList)
{
List<Table> oList = new List<Table>();
Table oTable = new Table();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Table_By_Criteria_InList_SP oParams_Get_Table_By_Criteria_InList_SP = new Params_Get_Table_By_Criteria_InList_SP();
Params_Get_Depo_By_DEPO_ID oParams_Get_Depo_By_DEPO_ID = new Params_Get_Depo_By_DEPO_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Table_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Table_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Table_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Table_By_Criteria_InList.START_ROW == null) { i_Params_Get_Table_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Table_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Table_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Table_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Table_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Table_By_Criteria_InList.OWNER_ID;
oParams_Get_Table_By_Criteria_InList_SP.TABLE_NAME = i_Params_Get_Table_By_Criteria_InList.TABLE_NAME;
if ( i_Params_Get_Table_By_Criteria_InList.DEPO_ID_LIST == null)
{
i_Params_Get_Table_By_Criteria_InList.DEPO_ID_LIST = new List<Int32?>();
}
oParams_Get_Table_By_Criteria_InList_SP.DEPO_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Table_By_Criteria_InList.DEPO_ID_LIST);
oParams_Get_Table_By_Criteria_InList_SP.START_ROW = i_Params_Get_Table_By_Criteria_InList.START_ROW;
oParams_Get_Table_By_Criteria_InList_SP.END_ROW = i_Params_Get_Table_By_Criteria_InList.END_ROW;
oParams_Get_Table_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Table_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_Criteria_InList_Adv(i_Params_Get_Table_By_Criteria_InList.TABLE_NAME,i_Params_Get_Table_By_Criteria_InList.DEPO_ID_LIST,i_Params_Get_Table_By_Criteria_InList.OWNER_ID,i_Params_Get_Table_By_Criteria_InList.START_ROW,i_Params_Get_Table_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
i_Params_Get_Table_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Table_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Table_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_Criteria_InList_Adv");}
return oList;
}
public List<Table> Get_Table_By_Where_InList_Adv(Params_Get_Table_By_Where_InList i_Params_Get_Table_By_Where_InList)
{
List<Table> oList = new List<Table>();
Table oTable = new Table();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Table_By_Where_InList_SP oParams_Get_Table_By_Where_InList_SP = new Params_Get_Table_By_Where_InList_SP();
Params_Get_Depo_By_DEPO_ID oParams_Get_Depo_By_DEPO_ID = new Params_Get_Depo_By_DEPO_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Table_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Table_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Table_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Table_By_Where_InList.START_ROW == null) { i_Params_Get_Table_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Table_By_Where_InList.END_ROW == null) || (i_Params_Get_Table_By_Where_InList.END_ROW == 0)) { i_Params_Get_Table_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Table_By_Where_InList_SP.OWNER_ID = i_Params_Get_Table_By_Where_InList.OWNER_ID;
oParams_Get_Table_By_Where_InList_SP.TABLE_NAME = i_Params_Get_Table_By_Where_InList.TABLE_NAME;
if ( i_Params_Get_Table_By_Where_InList.DEPO_ID_LIST == null)
{
i_Params_Get_Table_By_Where_InList.DEPO_ID_LIST = new List<Int32?>();
}
oParams_Get_Table_By_Where_InList_SP.DEPO_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Table_By_Where_InList.DEPO_ID_LIST);
oParams_Get_Table_By_Where_InList_SP.START_ROW = i_Params_Get_Table_By_Where_InList.START_ROW;
oParams_Get_Table_By_Where_InList_SP.END_ROW = i_Params_Get_Table_By_Where_InList.END_ROW;
oParams_Get_Table_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Table_By_Where_InList.TOTAL_COUNT;
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_Where_InList_Adv(i_Params_Get_Table_By_Where_InList.TABLE_NAME,i_Params_Get_Table_By_Where_InList.DEPO_ID_LIST,i_Params_Get_Table_By_Where_InList.OWNER_ID,i_Params_Get_Table_By_Where_InList.START_ROW,i_Params_Get_Table_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oTable.My_Depo = new Depo();
oTools.CopyPropValues(oDBEntry.My_Depo, oTable.My_Depo);
oList.Add(oTable);
}
}
i_Params_Get_Table_By_Where_InList.TOTAL_COUNT = oParams_Get_Table_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Table_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_Where_InList_Adv");}
return oList;
}
}
}
