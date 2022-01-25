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
public Extension Get_Extension_By_EXTENSION_ID_Adv(Params_Get_Extension_By_EXTENSION_ID i_Params_Get_Extension_By_EXTENSION_ID)
{
Extension oExtension = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Extension_By_EXTENSION_ID_Adv");}
#region Body Section.
DALC.Extension oDBEntry = _AppContext.Get_Extension_By_EXTENSION_ID_Adv(i_Params_Get_Extension_By_EXTENSION_ID.EXTENSION_ID);
oExtension = new Extension();
oTools.CopyPropValues(oDBEntry, oExtension);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Extension_By_EXTENSION_ID_Adv");}
return oExtension;
}
public Table Get_Table_By_TABLE_ID_Adv(Params_Get_Table_By_TABLE_ID i_Params_Get_Table_By_TABLE_ID)
{
Table oTable = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_TABLE_ID_Adv");}
#region Body Section.
DALC.Table oDBEntry = _AppContext.Get_Table_By_TABLE_ID_Adv(i_Params_Get_Table_By_TABLE_ID.TABLE_ID);
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
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
public List<Extension> Get_Extension_By_EXTENSION_ID_List_Adv(Params_Get_Extension_By_EXTENSION_ID_List i_Params_Get_Extension_By_EXTENSION_ID_List)
{
Extension oExtension = null;
List<Extension> oList = new List<Extension>();
Params_Get_Extension_By_EXTENSION_ID_List_SP oParams_Get_Extension_By_EXTENSION_ID_List_SP = new Params_Get_Extension_By_EXTENSION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Extension_By_EXTENSION_ID_List_Adv");}
#region Body Section.
List<DALC.Extension> oList_DBEntries = _AppContext.Get_Extension_By_EXTENSION_ID_List_Adv(i_Params_Get_Extension_By_EXTENSION_ID_List.EXTENSION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oExtension = new Extension();
oTools.CopyPropValues(oDBEntry, oExtension);
oList.Add(oExtension);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Extension_By_EXTENSION_ID_List_Adv");}
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
public List<Extension> Get_Extension_By_OWNER_ID_Adv(Params_Get_Extension_By_OWNER_ID i_Params_Get_Extension_By_OWNER_ID)
{
List<Extension> oList = new List<Extension>();
Extension oExtension = new Extension();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Extension_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Extension> oList_DBEntries = _AppContext.Get_Extension_By_OWNER_ID_Adv(i_Params_Get_Extension_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oExtension = new Extension();
oTools.CopyPropValues(oDBEntry, oExtension);
oList.Add(oExtension);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Extension_By_OWNER_ID_Adv");}
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
oList.Add(oTable);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_OWNER_ID_Adv");}
return oList;
}
public List<Table> Get_Table_By_DEPO_Adv(Params_Get_Table_By_DEPO i_Params_Get_Table_By_DEPO)
{
List<Table> oList = new List<Table>();
Table oTable = new Table();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Table_By_DEPO_Adv");}
#region Body Section.
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_DEPO_Adv(i_Params_Get_Table_By_DEPO.DEPO);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
oList.Add(oTable);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Table_By_DEPO_Adv");}
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
public List<Extension> Get_Extension_By_Criteria_Adv(Params_Get_Extension_By_Criteria i_Params_Get_Extension_By_Criteria)
{
List<Extension> oList = new List<Extension>();
long? tmp_TOTAL_COUNT = 0;
Extension oExtension = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Extension_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Extension_By_Criteria.OWNER_ID == null) || (i_Params_Get_Extension_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Extension_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Extension_By_Criteria.START_ROW == null) { i_Params_Get_Extension_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Extension_By_Criteria.END_ROW == null) || (i_Params_Get_Extension_By_Criteria.END_ROW == 0)) { i_Params_Get_Extension_By_Criteria.END_ROW = 1000000; }
List<DALC.Extension> oList_DBEntries = _AppContext.Get_Extension_By_Criteria_Adv(i_Params_Get_Extension_By_Criteria.EXTENSION_TYPE,i_Params_Get_Extension_By_Criteria.OWNER_ID,i_Params_Get_Extension_By_Criteria.START_ROW,i_Params_Get_Extension_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oExtension = new Extension();
oTools.CopyPropValues(oDBEntry, oExtension);
oList.Add(oExtension);
}
}
i_Params_Get_Extension_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Extension_By_Criteria_Adv");}
return oList;
}
public List<Extension> Get_Extension_By_Where_Adv(Params_Get_Extension_By_Where i_Params_Get_Extension_By_Where)
{
List<Extension> oList = new List<Extension>();
long? tmp_TOTAL_COUNT = 0;
Extension oExtension = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Extension_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Extension_By_Where.OWNER_ID == null) || (i_Params_Get_Extension_By_Where.OWNER_ID == 0)) { i_Params_Get_Extension_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Extension_By_Where.START_ROW == null) { i_Params_Get_Extension_By_Where.START_ROW = 0; }
if ((i_Params_Get_Extension_By_Where.END_ROW == null) || (i_Params_Get_Extension_By_Where.END_ROW == 0)) { i_Params_Get_Extension_By_Where.END_ROW = 1000000; }
List<DALC.Extension> oList_DBEntries = _AppContext.Get_Extension_By_Where_Adv(i_Params_Get_Extension_By_Where.EXTENSION_TYPE,i_Params_Get_Extension_By_Where.OWNER_ID,i_Params_Get_Extension_By_Where.START_ROW,i_Params_Get_Extension_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oExtension = new Extension();
oTools.CopyPropValues(oDBEntry, oExtension);
oList.Add(oExtension);
}
}
i_Params_Get_Extension_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Extension_By_Where_Adv");}
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
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_Criteria_Adv(i_Params_Get_Table_By_Criteria.TABLE_NAME,i_Params_Get_Table_By_Criteria.DEPO,i_Params_Get_Table_By_Criteria.OWNER_ID,i_Params_Get_Table_By_Criteria.START_ROW,i_Params_Get_Table_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
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
List<DALC.Table> oList_DBEntries = _AppContext.Get_Table_By_Where_Adv(i_Params_Get_Table_By_Where.TABLE_NAME,i_Params_Get_Table_By_Where.DEPO,i_Params_Get_Table_By_Where.OWNER_ID,i_Params_Get_Table_By_Where.START_ROW,i_Params_Get_Table_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTable = new Table();
oTools.CopyPropValues(oDBEntry, oTable);
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
}
}
