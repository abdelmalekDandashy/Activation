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
#region Check_Address_Uniqueness_Violation
public bool Check_Address_Uniqueness_Violation(Address i_Address)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Address_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Address.ADDRESS_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Address_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.PERSON_ID == i_Address.PERSON_ID) && (oItem_Row.ADDRESS_TYPE_CODE == i_Address.ADDRESS_TYPE_CODE))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Address_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.PERSON_ID == i_Address.PERSON_ID) && (oItem_Row.ADDRESS_TYPE_CODE == i_Address.ADDRESS_TYPE_CODE)) && (oItem_Row.ADDRESS_ID != i_Address.ADDRESS_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_Contact_Uniqueness_Violation
public bool Check_Contact_Uniqueness_Violation(Contact i_Contact)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Contact_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Contact.CONTACT_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Contact_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.PERSON_ID == i_Contact.PERSON_ID) && (oItem_Row.CONTACT_TYPE_CODE == i_Contact.CONTACT_TYPE_CODE) && (oItem_Row.CONTACT == i_Contact.CONTACT))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Contact_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.PERSON_ID == i_Contact.PERSON_ID) && (oItem_Row.CONTACT_TYPE_CODE == i_Contact.CONTACT_TYPE_CODE) && (oItem_Row.CONTACT == i_Contact.CONTACT)) && (oItem_Row.CONTACT_ID != i_Contact.CONTACT_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_Loc_l1_Uniqueness_Violation
public bool Check_Loc_l1_Uniqueness_Violation(Loc_l1 i_Loc_l1)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Loc_l1_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Loc_l1.LOC_L1_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l1_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.CODE == i_Loc_l1.CODE))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l1_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.CODE == i_Loc_l1.CODE)) && (oItem_Row.LOC_L1_ID != i_Loc_l1.LOC_L1_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_Loc_l2_Uniqueness_Violation
public bool Check_Loc_l2_Uniqueness_Violation(Loc_l2 i_Loc_l2)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Loc_l2_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Loc_l2.LOC_L2_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l2_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.LOC_L1_ID == i_Loc_l2.LOC_L1_ID) && (oItem_Row.CODE == i_Loc_l2.CODE))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l2_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.LOC_L1_ID == i_Loc_l2.LOC_L1_ID) && (oItem_Row.CODE == i_Loc_l2.CODE)) && (oItem_Row.LOC_L2_ID != i_Loc_l2.LOC_L2_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_Loc_l3_Uniqueness_Violation
public bool Check_Loc_l3_Uniqueness_Violation(Loc_l3 i_Loc_l3)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Loc_l3_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Loc_l3.LOC_L3_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l3_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.LOC_L2_ID == i_Loc_l3.LOC_L2_ID) && (oItem_Row.CODE == i_Loc_l3.CODE))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l3_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.LOC_L2_ID == i_Loc_l3.LOC_L2_ID) && (oItem_Row.CODE == i_Loc_l3.CODE)) && (oItem_Row.LOC_L3_ID != i_Loc_l3.LOC_L3_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_Loc_l4_Uniqueness_Violation
public bool Check_Loc_l4_Uniqueness_Violation(Loc_l4 i_Loc_l4)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Loc_l4_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Loc_l4.LOC_L4_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l4_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.LOC_L3_ID == i_Loc_l4.LOC_L3_ID) && (oItem_Row.CODE == i_Loc_l4.CODE))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Loc_l4_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.LOC_L3_ID == i_Loc_l4.LOC_L3_ID) && (oItem_Row.CODE == i_Loc_l4.CODE)) && (oItem_Row.LOC_L4_ID != i_Loc_l4.LOC_L4_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_User_Uniqueness_Violation
public bool Check_User_Uniqueness_Violation(User i_User)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_User_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_User.USER_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_User_By_OWNER_ID(this.OwnerID)
where (((oItem_Row.USERNAME == i_User.USERNAME)) || (oItem_Row.EMAIL == i_User.EMAIL))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_User_By_OWNER_ID(this.OwnerID)
where (((oItem_Row.USERNAME == i_User.USERNAME)) || (oItem_Row.EMAIL == i_User.EMAIL)) && (oItem_Row.USER_ID != i_User.USER_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
}
}
