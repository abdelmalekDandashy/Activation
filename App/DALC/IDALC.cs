using System;
using System.Collections.Generic;
namespace DALC
{
#region Entities
public partial class Depo
{
public Int32? DEPO_ID {get;set;}
public string DEPO_NAME {get;set;}
public Int32? NB_OF_TYPE_A {get;set;}
public Int32? NB_OF_TYPE_B {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Table
{
public Int32? TABLE_ID {get;set;}
public string TABLE_NAME {get;set;}
public Int32? TABLE_AGE_COUNTER {get;set;}
public bool? IS_CHARGING {get;set;}
public Int32? NB_OF_TYPE_A {get;set;}
public Int32? NB_OF_TYPE_C {get;set;}
public Int32? CHARGING_PERCENTAGE {get;set;}
public Int32? DEPO_ID {get;set;}
public bool? IS_READY {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Depo My_Depo {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
#endregion 
public partial interface IDALC
{
Depo Get_Depo_By_DEPO_ID ( Int32? DEPO_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Table Get_Table_By_TABLE_ID ( Int32? TABLE_ID);
User Get_User_By_USER_ID ( long? USER_ID);
Depo Get_Depo_By_DEPO_ID_Adv ( Int32? DEPO_ID);
Table Get_Table_By_TABLE_ID_Adv ( Int32? TABLE_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
List<Depo> Get_Depo_By_DEPO_ID_List ( List<Int32?> DEPO_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Table> Get_Table_By_TABLE_ID_List ( List<Int32?> TABLE_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Depo> Get_Depo_By_DEPO_ID_List_Adv ( List<Int32?> DEPO_ID_LIST);
List<Table> Get_Table_By_TABLE_ID_List_Adv ( List<Int32?> TABLE_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Depo> Get_Depo_By_OWNER_ID ( Int32? OWNER_ID);
List<Table> Get_Table_By_OWNER_ID ( Int32? OWNER_ID);
List<Table> Get_Table_By_DEPO_ID ( Int32? DEPO_ID);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<Depo> Get_Depo_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Table> Get_Table_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Table> Get_Table_By_DEPO_ID_Adv ( Int32? DEPO_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<Table> Get_Table_By_DEPO_ID_List ( List<Int32?> DEPO_ID_LIST);
List<Table> Get_Table_By_DEPO_ID_List_Adv ( List<Int32?> DEPO_ID_LIST);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Criteria ( string TABLE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Where ( string TABLE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Criteria_Adv ( string TABLE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Where_Adv ( string TABLE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Criteria_InList ( string TABLE_NAME, List<Int32?> DEPO_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Where_InList ( string TABLE_NAME, List<Int32?> DEPO_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Criteria_InList_Adv ( string TABLE_NAME, List<Int32?> DEPO_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Table> Get_Table_By_Where_InList_Adv ( string TABLE_NAME, List<Int32?> DEPO_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Depo ( Int32? DEPO_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Table ( Int32? TABLE_ID);
void Delete_User ( long? USER_ID);
void Delete_Depo_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Table_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Table_By_DEPO_ID ( Int32? DEPO_ID);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
Int32? Edit_Depo ( Int32? DEPO_ID, string DEPO_NAME, Int32? NB_OF_TYPE_A, Int32? NB_OF_TYPE_B, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
Int32? Edit_Table ( Int32? TABLE_ID, string TABLE_NAME, Int32? TABLE_AGE_COUNTER, bool? IS_CHARGING, Int32? NB_OF_TYPE_A, Int32? NB_OF_TYPE_C, Int32? CHARGING_PERCENTAGE, Int32? DEPO_ID, bool? IS_READY, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_DEPO ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_EXTENSION ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TABLE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
}
}
