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
#region Reset_Table_By_Depo
public void Reset_Table_By_Depo(Depo i_Depo, List<Table> i_Table_List)
{
#region Declaration And Initialization Section.
Params_Delete_Table_By_DEPO_ID oParams_Delete_Table_By_DEPO_ID = new Params_Delete_Table_By_DEPO_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Table_By_Depo");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Table
//---------------------------------
oParams_Delete_Table_By_DEPO_ID.DEPO_ID = i_Depo.DEPO_ID;
Delete_Table_By_DEPO_ID(oParams_Delete_Table_By_DEPO_ID);
//---------------------------------
// Edit Table
//---------------------------------
Edit_Depo_WithTable(i_Depo, i_Table_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Table_By_Depo");}
}
#endregion
#region Reset_Table_By_Depo
public void Reset_Table_By_Depo(Depo i_Depo, List<Table> i_Table_List_To_Delete,List<Table> i_Table_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Table oParams_Delete_Table = new Params_Delete_Table();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Table_By_Depo");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Table_List_To_Delete != null)
{
foreach (var oRow in i_Table_List_To_Delete)
{
oParams_Delete_Table.TABLE_ID = oRow.TABLE_ID;
Delete_Table(oParams_Delete_Table);
}
}
//---------------------------------
// Edit Table
//---------------------------------
Edit_Depo_WithTable(i_Depo, i_Table_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Table_By_Depo");}
}
#endregion
#region Edit_Depo_With_Table(Depo i_Depo,List<Table> i_TableList)
public void Edit_Depo_WithTable(Depo i_Depo,List<Table> i_List_Table)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Depo_WithTable");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Depo(i_Depo);
if (i_List_Table != null)
{
foreach(Table oTable in i_List_Table)
{
oTable.DEPO_ID = i_Depo.DEPO_ID;
Edit_Table(oTable);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Depo_WithTable");}
}
#endregion
#region Edit_Depo_WithRelatedData(Depo i_Depo,List<Table> i_List_Table)
public void Edit_Depo_WithRelatedData(Depo i_Depo,List<Table> i_List_Table)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Depo_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Depo(i_Depo);
if (i_List_Table != null)
{
foreach(Table oTable in i_List_Table)
{
oTable.DEPO_ID = i_Depo.DEPO_ID;
Edit_Table(oTable);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Depo_WithRelatedData");}
}
#endregion
#region Delete_Depo_With_Children(Depo i_Depo)
public void Delete_Depo_With_Children(Depo i_Depo)
{
 #region Declaration And Initialization Section.
Params_Delete_Depo oParams_Delete_Depo = new Params_Delete_Depo();
Params_Delete_Table_By_DEPO_ID oParams_Delete_Table_By_DEPO_ID = new Params_Delete_Table_By_DEPO_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Depo_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Table_By_DEPO_ID.DEPO_ID = i_Depo.DEPO_ID;
Delete_Table_By_DEPO_ID(oParams_Delete_Table_By_DEPO_ID);
//-------------------------

//-------------------------
oParams_Delete_Depo.DEPO_ID = i_Depo.DEPO_ID;
Delete_Depo(oParams_Delete_Depo);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Depo_With_Children");}
}
#endregion
}
}
