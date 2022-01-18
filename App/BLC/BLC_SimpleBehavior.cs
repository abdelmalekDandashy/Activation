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
#region Members
#region Used For Delete Operations
private Address _Address;
private Answer _Answer;
private Category _Category;
private Category_favorite _Category_favorite;
private Contact _Contact;
private Evaluation _Evaluation;
private Favorite_teacher _Favorite_teacher;
private Loc_l1 _Loc_l1;
private Loc_l2 _Loc_l2;
private Loc_l3 _Loc_l3;
private Loc_l4 _Loc_l4;
private Owner _Owner;
private Person _Person;
private Question _Question;
private Question_token _Question_token;
private Student _Student;
private Student_report _Student_report;
private Teacher _Teacher;
private Teacher_category _Teacher_category;
private Teacher_favorite _Teacher_favorite;
private Teacher_report _Teacher_report;
private User _User;
private User_type_code _User_type_code;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Address_Execution;
private bool _Stop_Delete_Address_Execution;
private bool _Stop_Edit_Answer_Execution;
private bool _Stop_Delete_Answer_Execution;
private bool _Stop_Edit_Category_Execution;
private bool _Stop_Delete_Category_Execution;
private bool _Stop_Edit_Category_favorite_Execution;
private bool _Stop_Delete_Category_favorite_Execution;
private bool _Stop_Edit_Contact_Execution;
private bool _Stop_Delete_Contact_Execution;
private bool _Stop_Edit_Evaluation_Execution;
private bool _Stop_Delete_Evaluation_Execution;
private bool _Stop_Edit_Favorite_teacher_Execution;
private bool _Stop_Delete_Favorite_teacher_Execution;
private bool _Stop_Edit_Loc_l1_Execution;
private bool _Stop_Delete_Loc_l1_Execution;
private bool _Stop_Edit_Loc_l2_Execution;
private bool _Stop_Delete_Loc_l2_Execution;
private bool _Stop_Edit_Loc_l3_Execution;
private bool _Stop_Delete_Loc_l3_Execution;
private bool _Stop_Edit_Loc_l4_Execution;
private bool _Stop_Delete_Loc_l4_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Person_Execution;
private bool _Stop_Delete_Person_Execution;
private bool _Stop_Edit_Question_Execution;
private bool _Stop_Delete_Question_Execution;
private bool _Stop_Edit_Question_token_Execution;
private bool _Stop_Delete_Question_token_Execution;
private bool _Stop_Edit_Student_Execution;
private bool _Stop_Delete_Student_Execution;
private bool _Stop_Edit_Student_report_Execution;
private bool _Stop_Delete_Student_report_Execution;
private bool _Stop_Edit_Teacher_Execution;
private bool _Stop_Delete_Teacher_Execution;
private bool _Stop_Edit_Teacher_category_Execution;
private bool _Stop_Delete_Teacher_category_Execution;
private bool _Stop_Edit_Teacher_favorite_Execution;
private bool _Stop_Delete_Teacher_favorite_Execution;
private bool _Stop_Edit_Teacher_report_Execution;
private bool _Stop_Delete_Teacher_report_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
private bool _Stop_Edit_User_type_code_Execution;
private bool _Stop_Delete_User_type_code_Execution;
#endregion
#endregion
public Address Get_Address_By_ADDRESS_ID(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID");}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID");}
return oAddress;
}
public Answer Get_Answer_By_ANSWER_ID(Params_Get_Answer_By_ANSWER_ID i_Params_Get_Answer_By_ANSWER_ID)
{
Answer oAnswer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_ANSWER_ID");}
#region Body Section.
DALC.Answer oDBEntry = _AppContext.Get_Answer_By_ANSWER_ID(i_Params_Get_Answer_By_ANSWER_ID.ANSWER_ID);
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_ANSWER_ID");}
return oAnswer;
}
public Category Get_Category_By_CATEGORY_ID(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID");}
#region Body Section.
DALC.Category oDBEntry = _AppContext.Get_Category_By_CATEGORY_ID(i_Params_Get_Category_By_CATEGORY_ID.CATEGORY_ID);
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID");}
return oCategory;
}
public Category_favorite Get_Category_favorite_By_CATEGORY_FAVORITE_ID(Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID)
{
Category_favorite oCategory_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID");}
#region Body Section.
DALC.Category_favorite oDBEntry = _AppContext.Get_Category_favorite_By_CATEGORY_FAVORITE_ID(i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID.CATEGORY_FAVORITE_ID);
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID");}
return oCategory_favorite;
}
public Contact Get_Contact_By_CONTACT_ID(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID");}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID");}
return oContact;
}
public Evaluation Get_Evaluation_By_EVALUATION_ID(Params_Get_Evaluation_By_EVALUATION_ID i_Params_Get_Evaluation_By_EVALUATION_ID)
{
Evaluation oEvaluation = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_EVALUATION_ID");}
#region Body Section.
DALC.Evaluation oDBEntry = _AppContext.Get_Evaluation_By_EVALUATION_ID(i_Params_Get_Evaluation_By_EVALUATION_ID.EVALUATION_ID);
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_EVALUATION_ID");}
return oEvaluation;
}
public Favorite_teacher Get_Favorite_teacher_By_FAVORITE_TEACHER_ID(Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID)
{
Favorite_teacher oFavorite_teacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID");}
#region Body Section.
DALC.Favorite_teacher oDBEntry = _AppContext.Get_Favorite_teacher_By_FAVORITE_TEACHER_ID(i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID.FAVORITE_TEACHER_ID);
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID");}
return oFavorite_teacher;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
return oLoc_l4;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Person Get_Person_By_PERSON_ID(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID");}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID");}
return oPerson;
}
public Question Get_Question_By_QUESTION_ID(Params_Get_Question_By_QUESTION_ID i_Params_Get_Question_By_QUESTION_ID)
{
Question oQuestion = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_QUESTION_ID");}
#region Body Section.
DALC.Question oDBEntry = _AppContext.Get_Question_By_QUESTION_ID(i_Params_Get_Question_By_QUESTION_ID.QUESTION_ID);
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_QUESTION_ID");}
return oQuestion;
}
public Question_token Get_Question_token_By_QUESTION_TOKEN_ID(Params_Get_Question_token_By_QUESTION_TOKEN_ID i_Params_Get_Question_token_By_QUESTION_TOKEN_ID)
{
Question_token oQuestion_token = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID");}
#region Body Section.
DALC.Question_token oDBEntry = _AppContext.Get_Question_token_By_QUESTION_TOKEN_ID(i_Params_Get_Question_token_By_QUESTION_TOKEN_ID.QUESTION_TOKEN_ID);
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID");}
return oQuestion_token;
}
public Student Get_Student_By_STUDENT_ID(Params_Get_Student_By_STUDENT_ID i_Params_Get_Student_By_STUDENT_ID)
{
Student oStudent = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_STUDENT_ID");}
#region Body Section.
DALC.Student oDBEntry = _AppContext.Get_Student_By_STUDENT_ID(i_Params_Get_Student_By_STUDENT_ID.STUDENT_ID);
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_STUDENT_ID");}
return oStudent;
}
public Student_report Get_Student_report_By_STUDENT_REPORT_ID(Params_Get_Student_report_By_STUDENT_REPORT_ID i_Params_Get_Student_report_By_STUDENT_REPORT_ID)
{
Student_report oStudent_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_STUDENT_REPORT_ID");}
#region Body Section.
DALC.Student_report oDBEntry = _AppContext.Get_Student_report_By_STUDENT_REPORT_ID(i_Params_Get_Student_report_By_STUDENT_REPORT_ID.STUDENT_REPORT_ID);
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_STUDENT_REPORT_ID");}
return oStudent_report;
}
public Teacher Get_Teacher_By_TEACHER_ID(Params_Get_Teacher_By_TEACHER_ID i_Params_Get_Teacher_By_TEACHER_ID)
{
Teacher oTeacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_TEACHER_ID");}
#region Body Section.
DALC.Teacher oDBEntry = _AppContext.Get_Teacher_By_TEACHER_ID(i_Params_Get_Teacher_By_TEACHER_ID.TEACHER_ID);
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_TEACHER_ID");}
return oTeacher;
}
public Teacher_category Get_Teacher_category_By_TEACHER_CATEGORY_ID(Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID)
{
Teacher_category oTeacher_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID");}
#region Body Section.
DALC.Teacher_category oDBEntry = _AppContext.Get_Teacher_category_By_TEACHER_CATEGORY_ID(i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID.TEACHER_CATEGORY_ID);
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID");}
return oTeacher_category;
}
public Teacher_favorite Get_Teacher_favorite_By_TEACHER_FAVORITE_ID(Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID)
{
Teacher_favorite oTeacher_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID");}
#region Body Section.
DALC.Teacher_favorite oDBEntry = _AppContext.Get_Teacher_favorite_By_TEACHER_FAVORITE_ID(i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID.TEACHER_FAVORITE_ID);
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID");}
return oTeacher_favorite;
}
public Teacher_report Get_Teacher_report_By_TEACHER_REPORT_ID(Params_Get_Teacher_report_By_TEACHER_REPORT_ID i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID)
{
Teacher_report oTeacher_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID");}
#region Body Section.
DALC.Teacher_report oDBEntry = _AppContext.Get_Teacher_report_By_TEACHER_REPORT_ID(i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID.TEACHER_REPORT_ID);
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID");}
return oTeacher_report;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public User_type_code Get_User_type_code_By_USER_TYPE_CODE_ID(Params_Get_User_type_code_By_USER_TYPE_CODE_ID i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID)
{
User_type_code oUser_type_code = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID");}
#region Body Section.
DALC.User_type_code oDBEntry = _AppContext.Get_User_type_code_By_USER_TYPE_CODE_ID(i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
oUser_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry, oUser_type_code);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID");}
return oUser_type_code;
}
public List<Address> Get_Address_By_ADDRESS_ID_List(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List");}
return oList;
}
public List<Answer> Get_Answer_By_ANSWER_ID_List(Params_Get_Answer_By_ANSWER_ID_List i_Params_Get_Answer_By_ANSWER_ID_List)
{
Answer oAnswer = null;
List<Answer> oList = new List<Answer>();
Params_Get_Answer_By_ANSWER_ID_List_SP oParams_Get_Answer_By_ANSWER_ID_List_SP = new Params_Get_Answer_By_ANSWER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_ANSWER_ID_List");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_ANSWER_ID_List(i_Params_Get_Answer_By_ANSWER_ID_List.ANSWER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_ANSWER_ID_List");}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List(Params_Get_Category_By_CATEGORY_ID_List i_Params_Get_Category_By_CATEGORY_ID_List)
{
Category oCategory = null;
List<Category> oList = new List<Category>();
Params_Get_Category_By_CATEGORY_ID_List_SP oParams_Get_Category_By_CATEGORY_ID_List_SP = new Params_Get_Category_By_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_CATEGORY_ID_List(i_Params_Get_Category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_List");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List(Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List)
{
Category_favorite oCategory_favorite = null;
List<Category_favorite> oList = new List<Category_favorite>();
Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP oParams_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP = new Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List(i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List.CATEGORY_FAVORITE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_EVALUATION_ID_List(Params_Get_Evaluation_By_EVALUATION_ID_List i_Params_Get_Evaluation_By_EVALUATION_ID_List)
{
Evaluation oEvaluation = null;
List<Evaluation> oList = new List<Evaluation>();
Params_Get_Evaluation_By_EVALUATION_ID_List_SP oParams_Get_Evaluation_By_EVALUATION_ID_List_SP = new Params_Get_Evaluation_By_EVALUATION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_EVALUATION_ID_List");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_EVALUATION_ID_List(i_Params_Get_Evaluation_By_EVALUATION_ID_List.EVALUATION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_EVALUATION_ID_List");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List(Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List)
{
Favorite_teacher oFavorite_teacher = null;
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP oParams_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP = new Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List(i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List.FAVORITE_TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List");}
return oList;
}
public List<Question> Get_Question_By_QUESTION_ID_List(Params_Get_Question_By_QUESTION_ID_List i_Params_Get_Question_By_QUESTION_ID_List)
{
Question oQuestion = null;
List<Question> oList = new List<Question>();
Params_Get_Question_By_QUESTION_ID_List_SP oParams_Get_Question_By_QUESTION_ID_List_SP = new Params_Get_Question_By_QUESTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_QUESTION_ID_List");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_QUESTION_ID_List(i_Params_Get_Question_By_QUESTION_ID_List.QUESTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_QUESTION_ID_List");}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_TOKEN_ID_List(Params_Get_Question_token_By_QUESTION_TOKEN_ID_List i_Params_Get_Question_token_By_QUESTION_TOKEN_ID_List)
{
Question_token oQuestion_token = null;
List<Question_token> oList = new List<Question_token>();
Params_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP oParams_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP = new Params_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID_List");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_QUESTION_TOKEN_ID_List(i_Params_Get_Question_token_By_QUESTION_TOKEN_ID_List.QUESTION_TOKEN_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID_List");}
return oList;
}
public List<Student> Get_Student_By_STUDENT_ID_List(Params_Get_Student_By_STUDENT_ID_List i_Params_Get_Student_By_STUDENT_ID_List)
{
Student oStudent = null;
List<Student> oList = new List<Student>();
Params_Get_Student_By_STUDENT_ID_List_SP oParams_Get_Student_By_STUDENT_ID_List_SP = new Params_Get_Student_By_STUDENT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_STUDENT_ID_List(i_Params_Get_Student_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_STUDENT_ID_List");}
return oList;
}
public List<Student_report> Get_Student_report_By_STUDENT_REPORT_ID_List(Params_Get_Student_report_By_STUDENT_REPORT_ID_List i_Params_Get_Student_report_By_STUDENT_REPORT_ID_List)
{
Student_report oStudent_report = null;
List<Student_report> oList = new List<Student_report>();
Params_Get_Student_report_By_STUDENT_REPORT_ID_List_SP oParams_Get_Student_report_By_STUDENT_REPORT_ID_List_SP = new Params_Get_Student_report_By_STUDENT_REPORT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_STUDENT_REPORT_ID_List");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_STUDENT_REPORT_ID_List(i_Params_Get_Student_report_By_STUDENT_REPORT_ID_List.STUDENT_REPORT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_STUDENT_REPORT_ID_List");}
return oList;
}
public List<Teacher> Get_Teacher_By_TEACHER_ID_List(Params_Get_Teacher_By_TEACHER_ID_List i_Params_Get_Teacher_By_TEACHER_ID_List)
{
Teacher oTeacher = null;
List<Teacher> oList = new List<Teacher>();
Params_Get_Teacher_By_TEACHER_ID_List_SP oParams_Get_Teacher_By_TEACHER_ID_List_SP = new Params_Get_Teacher_By_TEACHER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_TEACHER_ID_List(i_Params_Get_Teacher_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_TEACHER_ID_List");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_CATEGORY_ID_List(Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List)
{
Teacher_category oTeacher_category = null;
List<Teacher_category> oList = new List<Teacher_category>();
Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP oParams_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP = new Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_TEACHER_CATEGORY_ID_List(i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List.TEACHER_CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID_List");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List(Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List)
{
Teacher_favorite oTeacher_favorite = null;
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP oParams_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP = new Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List(i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List.TEACHER_FAVORITE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_REPORT_ID_List(Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List)
{
Teacher_report oTeacher_report = null;
List<Teacher_report> oList = new List<Teacher_report>();
Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP oParams_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP = new Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID_List");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_TEACHER_REPORT_ID_List(i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List.TEACHER_REPORT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_USER_TYPE_CODE_ID_List(Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List)
{
User_type_code oUser_type_code = null;
List<User_type_code> oList = new List<User_type_code>();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP oParams_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID_List");}
#region Body Section.
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_USER_TYPE_CODE_ID_List(i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry, oUser_type_code);
oList.Add(oUser_type_code);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID_List");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID");}
return oList;
}
public List<Answer> Get_Answer_By_OWNER_ID(Params_Get_Answer_By_OWNER_ID i_Params_Get_Answer_By_OWNER_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_OWNER_ID");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_OWNER_ID(i_Params_Get_Answer_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_OWNER_ID");}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID(Params_Get_Answer_By_QUESTION_ID i_Params_Get_Answer_By_QUESTION_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_QUESTION_ID");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_QUESTION_ID(i_Params_Get_Answer_By_QUESTION_ID.QUESTION_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_QUESTION_ID");}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID(Params_Get_Answer_By_TEACHER_ID i_Params_Get_Answer_By_TEACHER_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_TEACHER_ID");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_TEACHER_ID(i_Params_Get_Answer_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_TEACHER_ID");}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID(Params_Get_Answer_By_STUDENT_ID i_Params_Get_Answer_By_STUDENT_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_STUDENT_ID");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_STUDENT_ID(i_Params_Get_Answer_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_STUDENT_ID");}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_OWNER_ID");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_OWNER_ID(i_Params_Get_Category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_OWNER_ID");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_OWNER_ID(Params_Get_Category_favorite_By_OWNER_ID i_Params_Get_Category_favorite_By_OWNER_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_OWNER_ID");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_OWNER_ID(i_Params_Get_Category_favorite_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_OWNER_ID");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID(Params_Get_Category_favorite_By_STUDENT_ID i_Params_Get_Category_favorite_By_STUDENT_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_STUDENT_ID");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_STUDENT_ID(i_Params_Get_Category_favorite_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_STUDENT_ID");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID(Params_Get_Category_favorite_By_CATEGORY_ID i_Params_Get_Category_favorite_By_CATEGORY_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_ID");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_CATEGORY_ID(i_Params_Get_Category_favorite_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_OWNER_ID(Params_Get_Evaluation_By_OWNER_ID i_Params_Get_Evaluation_By_OWNER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_OWNER_ID");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_OWNER_ID(i_Params_Get_Evaluation_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_OWNER_ID");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID(Params_Get_Evaluation_By_STUDENT_ID i_Params_Get_Evaluation_By_STUDENT_ID)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_STUDENT_ID");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_STUDENT_ID(i_Params_Get_Evaluation_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_STUDENT_ID");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID(Params_Get_Evaluation_By_ANSWER_ID i_Params_Get_Evaluation_By_ANSWER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_ANSWER_ID");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_ANSWER_ID(i_Params_Get_Evaluation_By_ANSWER_ID.ANSWER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_ANSWER_ID");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_OWNER_ID(Params_Get_Favorite_teacher_By_OWNER_ID i_Params_Get_Favorite_teacher_By_OWNER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_OWNER_ID");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_OWNER_ID(i_Params_Get_Favorite_teacher_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_OWNER_ID");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID(Params_Get_Favorite_teacher_By_STUDENT_ID i_Params_Get_Favorite_teacher_By_STUDENT_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_STUDENT_ID");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_STUDENT_ID(i_Params_Get_Favorite_teacher_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_STUDENT_ID");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID(Params_Get_Favorite_teacher_By_TEACHER_ID i_Params_Get_Favorite_teacher_By_TEACHER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_TEACHER_ID");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_TEACHER_ID(i_Params_Get_Favorite_teacher_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_TEACHER_ID");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE(i_Params_Get_Loc_l1_By_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID");}
return oList;
}
public List<Question> Get_Question_By_OWNER_ID(Params_Get_Question_By_OWNER_ID i_Params_Get_Question_By_OWNER_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_OWNER_ID");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_OWNER_ID(i_Params_Get_Question_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_OWNER_ID");}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID(Params_Get_Question_By_STUDENT_ID i_Params_Get_Question_By_STUDENT_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_STUDENT_ID");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_STUDENT_ID(i_Params_Get_Question_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_STUDENT_ID");}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID(Params_Get_Question_By_CATEGORY_ID i_Params_Get_Question_By_CATEGORY_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_CATEGORY_ID");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_CATEGORY_ID(i_Params_Get_Question_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_CATEGORY_ID");}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID(Params_Get_Question_By_TEACHER_ID i_Params_Get_Question_By_TEACHER_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_TEACHER_ID");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_TEACHER_ID(i_Params_Get_Question_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_TEACHER_ID");}
return oList;
}
public List<Question_token> Get_Question_token_By_PART(Params_Get_Question_token_By_PART i_Params_Get_Question_token_By_PART)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_PART");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_PART(i_Params_Get_Question_token_By_PART.PART);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_PART");}
return oList;
}
public List<Question_token> Get_Question_token_By_OWNER_ID(Params_Get_Question_token_By_OWNER_ID i_Params_Get_Question_token_By_OWNER_ID)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_OWNER_ID");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_OWNER_ID(i_Params_Get_Question_token_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_OWNER_ID");}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID(Params_Get_Question_token_By_QUESTION_ID i_Params_Get_Question_token_By_QUESTION_ID)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_ID");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_QUESTION_ID(i_Params_Get_Question_token_By_QUESTION_ID.QUESTION_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_ID");}
return oList;
}
public List<Student> Get_Student_By_OWNER_ID(Params_Get_Student_By_OWNER_ID i_Params_Get_Student_By_OWNER_ID)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_OWNER_ID");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_OWNER_ID(i_Params_Get_Student_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_OWNER_ID");}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID(Params_Get_Student_By_USER_TYPE_CODE_ID i_Params_Get_Student_By_USER_TYPE_CODE_ID)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_TYPE_CODE_ID");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_TYPE_CODE_ID(i_Params_Get_Student_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_TYPE_CODE_ID");}
return oList;
}
public List<Student> Get_Student_By_USER_ID(Params_Get_Student_By_USER_ID i_Params_Get_Student_By_USER_ID)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_ID");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_ID(i_Params_Get_Student_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_ID");}
return oList;
}
public List<Student_report> Get_Student_report_By_OWNER_ID(Params_Get_Student_report_By_OWNER_ID i_Params_Get_Student_report_By_OWNER_ID)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_OWNER_ID");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_OWNER_ID(i_Params_Get_Student_report_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_OWNER_ID");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID(Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_BY_STUDENT_ID(i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID.REPORTED_BY_STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID(Params_Get_Student_report_By_REPORTED_STUDENT_ID i_Params_Get_Student_report_By_REPORTED_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_STUDENT_ID(i_Params_Get_Student_report_By_REPORTED_STUDENT_ID.REPORTED_STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID");}
return oList;
}
public List<Teacher> Get_Teacher_By_OWNER_ID(Params_Get_Teacher_By_OWNER_ID i_Params_Get_Teacher_By_OWNER_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_OWNER_ID");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_OWNER_ID(i_Params_Get_Teacher_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_OWNER_ID");}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID(Params_Get_Teacher_By_CATEGORY_ID i_Params_Get_Teacher_By_CATEGORY_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_CATEGORY_ID");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_CATEGORY_ID(i_Params_Get_Teacher_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_CATEGORY_ID");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID(Params_Get_Teacher_By_USER_TYPE_CODE_ID i_Params_Get_Teacher_By_USER_TYPE_CODE_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_TYPE_CODE_ID(i_Params_Get_Teacher_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID(Params_Get_Teacher_By_USER_ID i_Params_Get_Teacher_By_USER_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_ID");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_ID(i_Params_Get_Teacher_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_ID");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_OWNER_ID(Params_Get_Teacher_category_By_OWNER_ID i_Params_Get_Teacher_category_By_OWNER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_OWNER_ID");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_OWNER_ID(i_Params_Get_Teacher_category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_OWNER_ID");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID(Params_Get_Teacher_category_By_TEACHER_ID i_Params_Get_Teacher_category_By_TEACHER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_ID");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_TEACHER_ID(i_Params_Get_Teacher_category_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_ID");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID(Params_Get_Teacher_category_By_CATEGORY_ID i_Params_Get_Teacher_category_By_CATEGORY_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_CATEGORY_ID");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_CATEGORY_ID(i_Params_Get_Teacher_category_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_CATEGORY_ID");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_OWNER_ID(Params_Get_Teacher_favorite_By_OWNER_ID i_Params_Get_Teacher_favorite_By_OWNER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_OWNER_ID");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_OWNER_ID(i_Params_Get_Teacher_favorite_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_OWNER_ID");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID(Params_Get_Teacher_favorite_By_STUDENT_ID i_Params_Get_Teacher_favorite_By_STUDENT_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_STUDENT_ID");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_STUDENT_ID(i_Params_Get_Teacher_favorite_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_STUDENT_ID");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID(Params_Get_Teacher_favorite_By_TEACHER_ID i_Params_Get_Teacher_favorite_By_TEACHER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_ID");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_TEACHER_ID(i_Params_Get_Teacher_favorite_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_ID");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_OWNER_ID(Params_Get_Teacher_report_By_OWNER_ID i_Params_Get_Teacher_report_By_OWNER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_OWNER_ID");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_OWNER_ID(i_Params_Get_Teacher_report_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_OWNER_ID");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID(Params_Get_Teacher_report_By_TEACHER_ID i_Params_Get_Teacher_report_By_TEACHER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_ID");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_TEACHER_ID(i_Params_Get_Teacher_report_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_ID");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID(Params_Get_Teacher_report_By_STUDENT_ID i_Params_Get_Teacher_report_By_STUDENT_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_STUDENT_ID");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_STUDENT_ID(i_Params_Get_Teacher_report_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_STUDENT_ID");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID(Params_Get_User_By_USER_TYPE_CODE_ID i_Params_Get_User_By_USER_TYPE_CODE_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_TYPE_CODE_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_TYPE_CODE_ID(i_Params_Get_User_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_TYPE_CODE_ID");}
return oList;
}
public List<User> Get_User_By_EMAIL(Params_Get_User_By_EMAIL i_Params_Get_User_By_EMAIL)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_EMAIL");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_EMAIL(i_Params_Get_User_By_EMAIL.EMAIL);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_EMAIL");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_OWNER_ID(Params_Get_User_type_code_By_OWNER_ID i_Params_Get_User_type_code_By_OWNER_ID)
{
List<User_type_code> oList = new List<User_type_code>();
User_type_code oUser_type_code = new User_type_code();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_OWNER_ID");}
#region Body Section.
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_OWNER_ID(i_Params_Get_User_type_code_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry, oUser_type_code);
oList.Add(oUser_type_code);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List");}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID_List(Params_Get_Answer_By_QUESTION_ID_List i_Params_Get_Answer_By_QUESTION_ID_List)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_QUESTION_ID_List");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_QUESTION_ID_List(i_Params_Get_Answer_By_QUESTION_ID_List.QUESTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_QUESTION_ID_List");}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID_List(Params_Get_Answer_By_TEACHER_ID_List i_Params_Get_Answer_By_TEACHER_ID_List)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_TEACHER_ID_List(i_Params_Get_Answer_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_TEACHER_ID_List");}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID_List(Params_Get_Answer_By_STUDENT_ID_List i_Params_Get_Answer_By_STUDENT_ID_List)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_STUDENT_ID_List(i_Params_Get_Answer_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_STUDENT_ID_List");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_List(Params_Get_Category_favorite_By_STUDENT_ID_List i_Params_Get_Category_favorite_By_STUDENT_ID_List)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_STUDENT_ID_List(i_Params_Get_Category_favorite_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_STUDENT_ID_List");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_List(Params_Get_Category_favorite_By_CATEGORY_ID_List i_Params_Get_Category_favorite_By_CATEGORY_ID_List)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_CATEGORY_ID_List(i_Params_Get_Category_favorite_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID_List(Params_Get_Evaluation_By_STUDENT_ID_List i_Params_Get_Evaluation_By_STUDENT_ID_List)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_STUDENT_ID_List(i_Params_Get_Evaluation_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_STUDENT_ID_List");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID_List(Params_Get_Evaluation_By_ANSWER_ID_List i_Params_Get_Evaluation_By_ANSWER_ID_List)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_ANSWER_ID_List");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_ANSWER_ID_List(i_Params_Get_Evaluation_By_ANSWER_ID_List.ANSWER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_ANSWER_ID_List");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_List(Params_Get_Favorite_teacher_By_STUDENT_ID_List i_Params_Get_Favorite_teacher_By_STUDENT_ID_List)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_STUDENT_ID_List(i_Params_Get_Favorite_teacher_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_STUDENT_ID_List");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_List(Params_Get_Favorite_teacher_By_TEACHER_ID_List i_Params_Get_Favorite_teacher_By_TEACHER_ID_List)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_TEACHER_ID_List(i_Params_Get_Favorite_teacher_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_TEACHER_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID_List(Params_Get_Question_By_STUDENT_ID_List i_Params_Get_Question_By_STUDENT_ID_List)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_STUDENT_ID_List(i_Params_Get_Question_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_STUDENT_ID_List");}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID_List(Params_Get_Question_By_CATEGORY_ID_List i_Params_Get_Question_By_CATEGORY_ID_List)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_CATEGORY_ID_List(i_Params_Get_Question_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_CATEGORY_ID_List");}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID_List(Params_Get_Question_By_TEACHER_ID_List i_Params_Get_Question_By_TEACHER_ID_List)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_TEACHER_ID_List(i_Params_Get_Question_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_TEACHER_ID_List");}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID_List(Params_Get_Question_token_By_QUESTION_ID_List i_Params_Get_Question_token_By_QUESTION_ID_List)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_ID_List");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_QUESTION_ID_List(i_Params_Get_Question_token_By_QUESTION_ID_List.QUESTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_ID_List");}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID_List(Params_Get_Student_By_USER_TYPE_CODE_ID_List i_Params_Get_Student_By_USER_TYPE_CODE_ID_List)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_TYPE_CODE_ID_List");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_TYPE_CODE_ID_List(i_Params_Get_Student_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_TYPE_CODE_ID_List");}
return oList;
}
public List<Student> Get_Student_By_USER_ID_List(Params_Get_Student_By_USER_ID_List i_Params_Get_Student_By_USER_ID_List)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_ID_List");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_ID_List(i_Params_Get_Student_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_ID_List");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_List(Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID_List");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_BY_STUDENT_ID_List(i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List.REPORTED_BY_STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID_List");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_List(Params_Get_Student_report_By_REPORTED_STUDENT_ID_List i_Params_Get_Student_report_By_REPORTED_STUDENT_ID_List)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID_List");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_STUDENT_ID_List(i_Params_Get_Student_report_By_REPORTED_STUDENT_ID_List.REPORTED_STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID_List");}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID_List(Params_Get_Teacher_By_CATEGORY_ID_List i_Params_Get_Teacher_By_CATEGORY_ID_List)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_CATEGORY_ID_List(i_Params_Get_Teacher_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_CATEGORY_ID_List");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_List(Params_Get_Teacher_By_USER_TYPE_CODE_ID_List i_Params_Get_Teacher_By_USER_TYPE_CODE_ID_List)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID_List");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_TYPE_CODE_ID_List(i_Params_Get_Teacher_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID_List");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID_List(Params_Get_Teacher_By_USER_ID_List i_Params_Get_Teacher_By_USER_ID_List)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_ID_List");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_ID_List(i_Params_Get_Teacher_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_ID_List");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_List(Params_Get_Teacher_category_By_TEACHER_ID_List i_Params_Get_Teacher_category_By_TEACHER_ID_List)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_TEACHER_ID_List(i_Params_Get_Teacher_category_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_ID_List");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_List(Params_Get_Teacher_category_By_CATEGORY_ID_List i_Params_Get_Teacher_category_By_CATEGORY_ID_List)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_CATEGORY_ID_List(i_Params_Get_Teacher_category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_CATEGORY_ID_List");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_List(Params_Get_Teacher_favorite_By_STUDENT_ID_List i_Params_Get_Teacher_favorite_By_STUDENT_ID_List)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_STUDENT_ID_List(i_Params_Get_Teacher_favorite_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_STUDENT_ID_List");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_List(Params_Get_Teacher_favorite_By_TEACHER_ID_List i_Params_Get_Teacher_favorite_By_TEACHER_ID_List)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_TEACHER_ID_List(i_Params_Get_Teacher_favorite_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_ID_List");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_List(Params_Get_Teacher_report_By_TEACHER_ID_List i_Params_Get_Teacher_report_By_TEACHER_ID_List)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_ID_List");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_TEACHER_ID_List(i_Params_Get_Teacher_report_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_ID_List");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_List(Params_Get_Teacher_report_By_STUDENT_ID_List i_Params_Get_Teacher_report_By_STUDENT_ID_List)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_STUDENT_ID_List");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_STUDENT_ID_List(i_Params_Get_Teacher_report_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_STUDENT_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID_List(Params_Get_User_By_USER_TYPE_CODE_ID_List i_Params_Get_User_By_USER_TYPE_CODE_ID_List)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_TYPE_CODE_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_TYPE_CODE_ID_List(i_Params_Get_User_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_TYPE_CODE_ID_List");}
return oList;
}
public List<Address> Get_Address_By_Criteria(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria");}
return oList;
}
public List<Address> Get_Address_By_Where(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where");}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_V2");}
return oList;
}
public List<Answer> Get_Answer_By_Criteria(Params_Get_Answer_By_Criteria i_Params_Get_Answer_By_Criteria)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Answer_By_Criteria.OWNER_ID == null) || (i_Params_Get_Answer_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Answer_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Answer_By_Criteria.START_ROW == null) { i_Params_Get_Answer_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Answer_By_Criteria.END_ROW == null) || (i_Params_Get_Answer_By_Criteria.END_ROW == 0)) { i_Params_Get_Answer_By_Criteria.END_ROW = 1000000; }
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Criteria(i_Params_Get_Answer_By_Criteria.DESCRIPTION,i_Params_Get_Answer_By_Criteria.OWNER_ID,i_Params_Get_Answer_By_Criteria.START_ROW,i_Params_Get_Answer_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Criteria");}
return oList;
}
public List<Answer> Get_Answer_By_Where(Params_Get_Answer_By_Where i_Params_Get_Answer_By_Where)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Where");}
#region Body Section.
if ((i_Params_Get_Answer_By_Where.OWNER_ID == null) || (i_Params_Get_Answer_By_Where.OWNER_ID == 0)) { i_Params_Get_Answer_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Answer_By_Where.START_ROW == null) { i_Params_Get_Answer_By_Where.START_ROW = 0; }
if ((i_Params_Get_Answer_By_Where.END_ROW == null) || (i_Params_Get_Answer_By_Where.END_ROW == 0)) { i_Params_Get_Answer_By_Where.END_ROW = 1000000; }
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Where(i_Params_Get_Answer_By_Where.DESCRIPTION,i_Params_Get_Answer_By_Where.OWNER_ID,i_Params_Get_Answer_By_Where.START_ROW,i_Params_Get_Answer_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Where");}
return oList;
}
public List<Category> Get_Category_By_Criteria(Params_Get_Category_By_Criteria i_Params_Get_Category_By_Criteria)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Criteria.START_ROW == null) { i_Params_Get_Category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_By_Criteria.END_ROW == null) || (i_Params_Get_Category_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_By_Criteria.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Criteria(i_Params_Get_Category_By_Criteria.NAME,i_Params_Get_Category_By_Criteria.DESCRIPTION,i_Params_Get_Category_By_Criteria.OWNER_ID,i_Params_Get_Category_By_Criteria.START_ROW,i_Params_Get_Category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
i_Params_Get_Category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Criteria");}
return oList;
}
public List<Category> Get_Category_By_Where(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Where");}
#region Body Section.
if ((i_Params_Get_Category_By_Where.OWNER_ID == null) || (i_Params_Get_Category_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Where.START_ROW == null) { i_Params_Get_Category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_By_Where.END_ROW == null) || (i_Params_Get_Category_By_Where.END_ROW == 0)) { i_Params_Get_Category_By_Where.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Where(i_Params_Get_Category_By_Where.NAME,i_Params_Get_Category_By_Where.DESCRIPTION,i_Params_Get_Category_By_Where.OWNER_ID,i_Params_Get_Category_By_Where.START_ROW,i_Params_Get_Category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
i_Params_Get_Category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Where");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria(Params_Get_Category_favorite_By_Criteria i_Params_Get_Category_favorite_By_Criteria)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Category_favorite_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_favorite_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_favorite_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_favorite_By_Criteria.START_ROW == null) { i_Params_Get_Category_favorite_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_favorite_By_Criteria.END_ROW == null) || (i_Params_Get_Category_favorite_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_favorite_By_Criteria.END_ROW = 1000000; }
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Criteria(i_Params_Get_Category_favorite_By_Criteria.DESCRIPTION,i_Params_Get_Category_favorite_By_Criteria.OWNER_ID,i_Params_Get_Category_favorite_By_Criteria.START_ROW,i_Params_Get_Category_favorite_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Criteria");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where(Params_Get_Category_favorite_By_Where i_Params_Get_Category_favorite_By_Where)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Where");}
#region Body Section.
if ((i_Params_Get_Category_favorite_By_Where.OWNER_ID == null) || (i_Params_Get_Category_favorite_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_favorite_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_favorite_By_Where.START_ROW == null) { i_Params_Get_Category_favorite_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_favorite_By_Where.END_ROW == null) || (i_Params_Get_Category_favorite_By_Where.END_ROW == 0)) { i_Params_Get_Category_favorite_By_Where.END_ROW = 1000000; }
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Where(i_Params_Get_Category_favorite_By_Where.DESCRIPTION,i_Params_Get_Category_favorite_By_Where.OWNER_ID,i_Params_Get_Category_favorite_By_Where.START_ROW,i_Params_Get_Category_favorite_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Where");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria");}
return oList;
}
public List<Contact> Get_Contact_By_Where(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria(Params_Get_Evaluation_By_Criteria i_Params_Get_Evaluation_By_Criteria)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Evaluation_By_Criteria.OWNER_ID == null) || (i_Params_Get_Evaluation_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Evaluation_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Evaluation_By_Criteria.START_ROW == null) { i_Params_Get_Evaluation_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Evaluation_By_Criteria.END_ROW == null) || (i_Params_Get_Evaluation_By_Criteria.END_ROW == 0)) { i_Params_Get_Evaluation_By_Criteria.END_ROW = 1000000; }
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Criteria(i_Params_Get_Evaluation_By_Criteria.DESCRIPTION,i_Params_Get_Evaluation_By_Criteria.OWNER_ID,i_Params_Get_Evaluation_By_Criteria.START_ROW,i_Params_Get_Evaluation_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Criteria");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where(Params_Get_Evaluation_By_Where i_Params_Get_Evaluation_By_Where)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Where");}
#region Body Section.
if ((i_Params_Get_Evaluation_By_Where.OWNER_ID == null) || (i_Params_Get_Evaluation_By_Where.OWNER_ID == 0)) { i_Params_Get_Evaluation_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Evaluation_By_Where.START_ROW == null) { i_Params_Get_Evaluation_By_Where.START_ROW = 0; }
if ((i_Params_Get_Evaluation_By_Where.END_ROW == null) || (i_Params_Get_Evaluation_By_Where.END_ROW == 0)) { i_Params_Get_Evaluation_By_Where.END_ROW = 1000000; }
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Where(i_Params_Get_Evaluation_By_Where.DESCRIPTION,i_Params_Get_Evaluation_By_Where.OWNER_ID,i_Params_Get_Evaluation_By_Where.START_ROW,i_Params_Get_Evaluation_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Where");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria(Params_Get_Favorite_teacher_By_Criteria i_Params_Get_Favorite_teacher_By_Criteria)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID == null) || (i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Favorite_teacher_By_Criteria.START_ROW == null) { i_Params_Get_Favorite_teacher_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Favorite_teacher_By_Criteria.END_ROW == null) || (i_Params_Get_Favorite_teacher_By_Criteria.END_ROW == 0)) { i_Params_Get_Favorite_teacher_By_Criteria.END_ROW = 1000000; }
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Criteria(i_Params_Get_Favorite_teacher_By_Criteria.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID,i_Params_Get_Favorite_teacher_By_Criteria.START_ROW,i_Params_Get_Favorite_teacher_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Criteria");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where(Params_Get_Favorite_teacher_By_Where i_Params_Get_Favorite_teacher_By_Where)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Where");}
#region Body Section.
if ((i_Params_Get_Favorite_teacher_By_Where.OWNER_ID == null) || (i_Params_Get_Favorite_teacher_By_Where.OWNER_ID == 0)) { i_Params_Get_Favorite_teacher_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Favorite_teacher_By_Where.START_ROW == null) { i_Params_Get_Favorite_teacher_By_Where.START_ROW = 0; }
if ((i_Params_Get_Favorite_teacher_By_Where.END_ROW == null) || (i_Params_Get_Favorite_teacher_By_Where.END_ROW == 0)) { i_Params_Get_Favorite_teacher_By_Where.END_ROW = 1000000; }
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Where(i_Params_Get_Favorite_teacher_By_Where.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Where.OWNER_ID,i_Params_Get_Favorite_teacher_By_Where.START_ROW,i_Params_Get_Favorite_teacher_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Where");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Person> Get_Person_By_Criteria(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria");}
return oList;
}
public List<Person> Get_Person_By_Where(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where");}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where");}
return oList;
}
public List<Person> Get_Person_By_Criteria_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_V2");}
return oList;
}
public List<Question> Get_Question_By_Criteria(Params_Get_Question_By_Criteria i_Params_Get_Question_By_Criteria)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Question_By_Criteria.OWNER_ID == null) || (i_Params_Get_Question_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Question_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_By_Criteria.START_ROW == null) { i_Params_Get_Question_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Question_By_Criteria.END_ROW == null) || (i_Params_Get_Question_By_Criteria.END_ROW == 0)) { i_Params_Get_Question_By_Criteria.END_ROW = 1000000; }
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Criteria(i_Params_Get_Question_By_Criteria.DESCRIPTION,i_Params_Get_Question_By_Criteria.OWNER_ID,i_Params_Get_Question_By_Criteria.START_ROW,i_Params_Get_Question_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Criteria");}
return oList;
}
public List<Question> Get_Question_By_Where(Params_Get_Question_By_Where i_Params_Get_Question_By_Where)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Where");}
#region Body Section.
if ((i_Params_Get_Question_By_Where.OWNER_ID == null) || (i_Params_Get_Question_By_Where.OWNER_ID == 0)) { i_Params_Get_Question_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_By_Where.START_ROW == null) { i_Params_Get_Question_By_Where.START_ROW = 0; }
if ((i_Params_Get_Question_By_Where.END_ROW == null) || (i_Params_Get_Question_By_Where.END_ROW == 0)) { i_Params_Get_Question_By_Where.END_ROW = 1000000; }
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Where(i_Params_Get_Question_By_Where.DESCRIPTION,i_Params_Get_Question_By_Where.OWNER_ID,i_Params_Get_Question_By_Where.START_ROW,i_Params_Get_Question_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Where");}
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria(Params_Get_Question_token_By_Criteria i_Params_Get_Question_token_By_Criteria)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Question_token_By_Criteria.OWNER_ID == null) || (i_Params_Get_Question_token_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Question_token_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_token_By_Criteria.START_ROW == null) { i_Params_Get_Question_token_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Question_token_By_Criteria.END_ROW == null) || (i_Params_Get_Question_token_By_Criteria.END_ROW == 0)) { i_Params_Get_Question_token_By_Criteria.END_ROW = 1000000; }
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Criteria(i_Params_Get_Question_token_By_Criteria.PART,i_Params_Get_Question_token_By_Criteria.OWNER_ID,i_Params_Get_Question_token_By_Criteria.START_ROW,i_Params_Get_Question_token_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Criteria");}
return oList;
}
public List<Question_token> Get_Question_token_By_Where(Params_Get_Question_token_By_Where i_Params_Get_Question_token_By_Where)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Where");}
#region Body Section.
if ((i_Params_Get_Question_token_By_Where.OWNER_ID == null) || (i_Params_Get_Question_token_By_Where.OWNER_ID == 0)) { i_Params_Get_Question_token_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_token_By_Where.START_ROW == null) { i_Params_Get_Question_token_By_Where.START_ROW = 0; }
if ((i_Params_Get_Question_token_By_Where.END_ROW == null) || (i_Params_Get_Question_token_By_Where.END_ROW == 0)) { i_Params_Get_Question_token_By_Where.END_ROW = 1000000; }
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Where(i_Params_Get_Question_token_By_Where.PART,i_Params_Get_Question_token_By_Where.OWNER_ID,i_Params_Get_Question_token_By_Where.START_ROW,i_Params_Get_Question_token_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Where");}
return oList;
}
public List<Student> Get_Student_By_Criteria(Params_Get_Student_By_Criteria i_Params_Get_Student_By_Criteria)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Student_By_Criteria.OWNER_ID == null) || (i_Params_Get_Student_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Student_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_By_Criteria.START_ROW == null) { i_Params_Get_Student_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Student_By_Criteria.END_ROW == null) || (i_Params_Get_Student_By_Criteria.END_ROW == 0)) { i_Params_Get_Student_By_Criteria.END_ROW = 1000000; }
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Criteria(i_Params_Get_Student_By_Criteria.DESCRIPTION,i_Params_Get_Student_By_Criteria.OWNER_ID,i_Params_Get_Student_By_Criteria.START_ROW,i_Params_Get_Student_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Criteria");}
return oList;
}
public List<Student> Get_Student_By_Where(Params_Get_Student_By_Where i_Params_Get_Student_By_Where)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Where");}
#region Body Section.
if ((i_Params_Get_Student_By_Where.OWNER_ID == null) || (i_Params_Get_Student_By_Where.OWNER_ID == 0)) { i_Params_Get_Student_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_By_Where.START_ROW == null) { i_Params_Get_Student_By_Where.START_ROW = 0; }
if ((i_Params_Get_Student_By_Where.END_ROW == null) || (i_Params_Get_Student_By_Where.END_ROW == 0)) { i_Params_Get_Student_By_Where.END_ROW = 1000000; }
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Where(i_Params_Get_Student_By_Where.DESCRIPTION,i_Params_Get_Student_By_Where.OWNER_ID,i_Params_Get_Student_By_Where.START_ROW,i_Params_Get_Student_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Where");}
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria(Params_Get_Student_report_By_Criteria i_Params_Get_Student_report_By_Criteria)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Student_report_By_Criteria.OWNER_ID == null) || (i_Params_Get_Student_report_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Student_report_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_report_By_Criteria.START_ROW == null) { i_Params_Get_Student_report_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Student_report_By_Criteria.END_ROW == null) || (i_Params_Get_Student_report_By_Criteria.END_ROW == 0)) { i_Params_Get_Student_report_By_Criteria.END_ROW = 1000000; }
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Criteria(i_Params_Get_Student_report_By_Criteria.DESCRIPTION,i_Params_Get_Student_report_By_Criteria.OWNER_ID,i_Params_Get_Student_report_By_Criteria.START_ROW,i_Params_Get_Student_report_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Criteria");}
return oList;
}
public List<Student_report> Get_Student_report_By_Where(Params_Get_Student_report_By_Where i_Params_Get_Student_report_By_Where)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Where");}
#region Body Section.
if ((i_Params_Get_Student_report_By_Where.OWNER_ID == null) || (i_Params_Get_Student_report_By_Where.OWNER_ID == 0)) { i_Params_Get_Student_report_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_report_By_Where.START_ROW == null) { i_Params_Get_Student_report_By_Where.START_ROW = 0; }
if ((i_Params_Get_Student_report_By_Where.END_ROW == null) || (i_Params_Get_Student_report_By_Where.END_ROW == 0)) { i_Params_Get_Student_report_By_Where.END_ROW = 1000000; }
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Where(i_Params_Get_Student_report_By_Where.DESCRIPTION,i_Params_Get_Student_report_By_Where.OWNER_ID,i_Params_Get_Student_report_By_Where.START_ROW,i_Params_Get_Student_report_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Where");}
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria(Params_Get_Teacher_By_Criteria i_Params_Get_Teacher_By_Criteria)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Teacher_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Criteria(i_Params_Get_Teacher_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_By_Criteria.OWNER_ID,i_Params_Get_Teacher_By_Criteria.START_ROW,i_Params_Get_Teacher_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Criteria");}
return oList;
}
public List<Teacher> Get_Teacher_By_Where(Params_Get_Teacher_By_Where i_Params_Get_Teacher_By_Where)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Where");}
#region Body Section.
if ((i_Params_Get_Teacher_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_By_Where.START_ROW == null) { i_Params_Get_Teacher_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_By_Where.END_ROW == null) || (i_Params_Get_Teacher_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_By_Where.END_ROW = 1000000; }
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Where(i_Params_Get_Teacher_By_Where.DESCRIPTION,i_Params_Get_Teacher_By_Where.OWNER_ID,i_Params_Get_Teacher_By_Where.START_ROW,i_Params_Get_Teacher_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Where");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria(Params_Get_Teacher_category_By_Criteria i_Params_Get_Teacher_category_By_Criteria)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Teacher_category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_category_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_category_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_category_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_category_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Criteria(i_Params_Get_Teacher_category_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_category_By_Criteria.OWNER_ID,i_Params_Get_Teacher_category_By_Criteria.START_ROW,i_Params_Get_Teacher_category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Criteria");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where(Params_Get_Teacher_category_By_Where i_Params_Get_Teacher_category_By_Where)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Where");}
#region Body Section.
if ((i_Params_Get_Teacher_category_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_category_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_category_By_Where.START_ROW == null) { i_Params_Get_Teacher_category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_category_By_Where.END_ROW == null) || (i_Params_Get_Teacher_category_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_category_By_Where.END_ROW = 1000000; }
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Where(i_Params_Get_Teacher_category_By_Where.DESCRIPTION,i_Params_Get_Teacher_category_By_Where.OWNER_ID,i_Params_Get_Teacher_category_By_Where.START_ROW,i_Params_Get_Teacher_category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Where");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria(Params_Get_Teacher_favorite_By_Criteria i_Params_Get_Teacher_favorite_By_Criteria)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_favorite_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_favorite_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_favorite_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_favorite_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_favorite_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Criteria(i_Params_Get_Teacher_favorite_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID,i_Params_Get_Teacher_favorite_By_Criteria.START_ROW,i_Params_Get_Teacher_favorite_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Criteria");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where(Params_Get_Teacher_favorite_By_Where i_Params_Get_Teacher_favorite_By_Where)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Where");}
#region Body Section.
if ((i_Params_Get_Teacher_favorite_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_favorite_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_favorite_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_favorite_By_Where.START_ROW == null) { i_Params_Get_Teacher_favorite_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_favorite_By_Where.END_ROW == null) || (i_Params_Get_Teacher_favorite_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_favorite_By_Where.END_ROW = 1000000; }
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Where(i_Params_Get_Teacher_favorite_By_Where.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Where.OWNER_ID,i_Params_Get_Teacher_favorite_By_Where.START_ROW,i_Params_Get_Teacher_favorite_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Where");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria(Params_Get_Teacher_report_By_Criteria i_Params_Get_Teacher_report_By_Criteria)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Teacher_report_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_report_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_report_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_report_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_report_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_report_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_report_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_report_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Criteria(i_Params_Get_Teacher_report_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_report_By_Criteria.OWNER_ID,i_Params_Get_Teacher_report_By_Criteria.START_ROW,i_Params_Get_Teacher_report_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Criteria");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where(Params_Get_Teacher_report_By_Where i_Params_Get_Teacher_report_By_Where)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Where");}
#region Body Section.
if ((i_Params_Get_Teacher_report_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_report_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_report_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_report_By_Where.START_ROW == null) { i_Params_Get_Teacher_report_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_report_By_Where.END_ROW == null) || (i_Params_Get_Teacher_report_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_report_By_Where.END_ROW = 1000000; }
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Where(i_Params_Get_Teacher_report_By_Where.DESCRIPTION,i_Params_Get_Teacher_report_By_Where.OWNER_ID,i_Params_Get_Teacher_report_By_Where.START_ROW,i_Params_Get_Teacher_report_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.EMAIL,i_Params_Get_User_By_Criteria.FIRST_NAME,i_Params_Get_User_By_Criteria.LAST_NAME,i_Params_Get_User_By_Criteria.MOBILE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.EMAIL,i_Params_Get_User_By_Where.FIRST_NAME,i_Params_Get_User_By_Where.LAST_NAME,i_Params_Get_User_By_Where.MOBILE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria_V2(Params_Get_User_By_Criteria_V2 i_Params_Get_User_By_Criteria_V2)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_User_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria_V2.START_ROW == null) { i_Params_Get_User_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria_V2.END_ROW == null) || (i_Params_Get_User_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_User_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_V2(i_Params_Get_User_By_Criteria_V2.USERNAME,i_Params_Get_User_By_Criteria_V2.PASSWORD,i_Params_Get_User_By_Criteria_V2.EMAIL,i_Params_Get_User_By_Criteria_V2.FIRST_NAME,i_Params_Get_User_By_Criteria_V2.LAST_NAME,i_Params_Get_User_By_Criteria_V2.MOBILE,i_Params_Get_User_By_Criteria_V2.DOB,i_Params_Get_User_By_Criteria_V2.OWNER_ID,i_Params_Get_User_By_Criteria_V2.START_ROW,i_Params_Get_User_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_V2");}
return oList;
}
public List<User> Get_User_By_Where_V2(Params_Get_User_By_Where_V2 i_Params_Get_User_By_Where_V2)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_User_By_Where_V2.OWNER_ID == null) || (i_Params_Get_User_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_User_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where_V2.START_ROW == null) { i_Params_Get_User_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_User_By_Where_V2.END_ROW == null) || (i_Params_Get_User_By_Where_V2.END_ROW == 0)) { i_Params_Get_User_By_Where_V2.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_V2(i_Params_Get_User_By_Where_V2.USERNAME,i_Params_Get_User_By_Where_V2.PASSWORD,i_Params_Get_User_By_Where_V2.EMAIL,i_Params_Get_User_By_Where_V2.FIRST_NAME,i_Params_Get_User_By_Where_V2.LAST_NAME,i_Params_Get_User_By_Where_V2.MOBILE,i_Params_Get_User_By_Where_V2.DOB,i_Params_Get_User_By_Where_V2.OWNER_ID,i_Params_Get_User_By_Where_V2.START_ROW,i_Params_Get_User_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_V2");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_Criteria(Params_Get_User_type_code_By_Criteria i_Params_Get_User_type_code_By_Criteria)
{
List<User_type_code> oList = new List<User_type_code>();
User_type_code oUser_type_code = new User_type_code();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_type_code_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_type_code_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_type_code_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_type_code_By_Criteria.START_ROW == null) { i_Params_Get_User_type_code_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_type_code_By_Criteria.END_ROW == null) || (i_Params_Get_User_type_code_By_Criteria.END_ROW == 0)) { i_Params_Get_User_type_code_By_Criteria.END_ROW = 1000000; }
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_Criteria(i_Params_Get_User_type_code_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_type_code_By_Criteria.DESCRIPTION,i_Params_Get_User_type_code_By_Criteria.OWNER_ID,i_Params_Get_User_type_code_By_Criteria.START_ROW,i_Params_Get_User_type_code_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry, oUser_type_code);
oList.Add(oUser_type_code);
}
}
i_Params_Get_User_type_code_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_Criteria");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_Where(Params_Get_User_type_code_By_Where i_Params_Get_User_type_code_By_Where)
{
List<User_type_code> oList = new List<User_type_code>();
User_type_code oUser_type_code = new User_type_code();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_Where");}
#region Body Section.
if ((i_Params_Get_User_type_code_By_Where.OWNER_ID == null) || (i_Params_Get_User_type_code_By_Where.OWNER_ID == 0)) { i_Params_Get_User_type_code_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_type_code_By_Where.START_ROW == null) { i_Params_Get_User_type_code_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_type_code_By_Where.END_ROW == null) || (i_Params_Get_User_type_code_By_Where.END_ROW == 0)) { i_Params_Get_User_type_code_By_Where.END_ROW = 1000000; }
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_Where(i_Params_Get_User_type_code_By_Where.USER_TYPE_CODE,i_Params_Get_User_type_code_By_Where.DESCRIPTION,i_Params_Get_User_type_code_By_Where.OWNER_ID,i_Params_Get_User_type_code_By_Where.START_ROW,i_Params_Get_User_type_code_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry, oUser_type_code);
oList.Add(oUser_type_code);
}
}
i_Params_Get_User_type_code_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Address_By_Criteria_InList.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP.STREET = i_Params_Get_Address_By_Criteria_InList.STREET;
oParams_Get_Address_By_Criteria_InList_SP.BUILDING = i_Params_Get_Address_By_Criteria_InList.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP.FLOOR = i_Params_Get_Address_By_Criteria_InList.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP.POBOX = i_Params_Get_Address_By_Criteria_InList.POBOX;
if ( i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP.START_ROW = i_Params_Get_Address_By_Criteria_InList.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP.END_ROW = i_Params_Get_Address_By_Criteria_InList.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList");}
return oList;
}
public List<Address> Get_Address_By_Where_InList(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList.START_ROW == null) { i_Params_Get_Address_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList.END_ROW == null) || (i_Params_Get_Address_By_Where_InList.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP.OWNER_ID = i_Params_Get_Address_By_Where_InList.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP.STREET = i_Params_Get_Address_By_Where_InList.STREET;
oParams_Get_Address_By_Where_InList_SP.BUILDING = i_Params_Get_Address_By_Where_InList.BUILDING;
oParams_Get_Address_By_Where_InList_SP.FLOOR = i_Params_Get_Address_By_Where_InList.FLOOR;
oParams_Get_Address_By_Where_InList_SP.POBOX = i_Params_Get_Address_By_Where_InList.POBOX;
if ( i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP.START_ROW = i_Params_Get_Address_By_Where_InList.START_ROW;
oParams_Get_Address_By_Where_InList_SP.END_ROW = i_Params_Get_Address_By_Where_InList.END_ROW;
oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP_V2.STREET = i_Params_Get_Address_By_Criteria_InList_V2.STREET;
oParams_Get_Address_By_Criteria_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Criteria_InList_V2.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Criteria_InList_V2.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP_V2.POBOX = i_Params_Get_Address_By_Criteria_InList_V2.POBOX;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Criteria_InList_V2.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Criteria_InList_V2.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Where_InList_V2.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP_V2.STREET = i_Params_Get_Address_By_Where_InList_V2.STREET;
oParams_Get_Address_By_Where_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Where_InList_V2.BUILDING;
oParams_Get_Address_By_Where_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Where_InList_V2.FLOOR;
oParams_Get_Address_By_Where_InList_SP_V2.POBOX = i_Params_Get_Address_By_Where_InList_V2.POBOX;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Where_InList_V2.START_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Where_InList_V2.END_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_V2");}
return oList;
}
public List<Answer> Get_Answer_By_Criteria_InList(Params_Get_Answer_By_Criteria_InList i_Params_Get_Answer_By_Criteria_InList)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Answer_By_Criteria_InList_SP oParams_Get_Answer_By_Criteria_InList_SP = new Params_Get_Answer_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Answer_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Answer_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Answer_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Answer_By_Criteria_InList.START_ROW == null) { i_Params_Get_Answer_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Answer_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Answer_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Answer_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Answer_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Answer_By_Criteria_InList.OWNER_ID;
oParams_Get_Answer_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Answer_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Answer_By_Criteria_InList.QUESTION_ID_LIST == null)
{
i_Params_Get_Answer_By_Criteria_InList.QUESTION_ID_LIST = new List<Int32?>();
}
oParams_Get_Answer_By_Criteria_InList_SP.QUESTION_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Answer_By_Criteria_InList.QUESTION_ID_LIST);
if ( i_Params_Get_Answer_By_Criteria_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Answer_By_Criteria_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Answer_By_Criteria_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Answer_By_Criteria_InList.TEACHER_ID_LIST);
if ( i_Params_Get_Answer_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Answer_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Answer_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Answer_By_Criteria_InList.STUDENT_ID_LIST);
oParams_Get_Answer_By_Criteria_InList_SP.START_ROW = i_Params_Get_Answer_By_Criteria_InList.START_ROW;
oParams_Get_Answer_By_Criteria_InList_SP.END_ROW = i_Params_Get_Answer_By_Criteria_InList.END_ROW;
oParams_Get_Answer_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Answer_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Criteria_InList(i_Params_Get_Answer_By_Criteria_InList.DESCRIPTION,i_Params_Get_Answer_By_Criteria_InList.QUESTION_ID_LIST,i_Params_Get_Answer_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Answer_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Answer_By_Criteria_InList.OWNER_ID,i_Params_Get_Answer_By_Criteria_InList.START_ROW,i_Params_Get_Answer_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Answer_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Answer_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Criteria_InList");}
return oList;
}
public List<Answer> Get_Answer_By_Where_InList(Params_Get_Answer_By_Where_InList i_Params_Get_Answer_By_Where_InList)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Answer_By_Where_InList_SP oParams_Get_Answer_By_Where_InList_SP = new Params_Get_Answer_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Answer_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Answer_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Answer_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Answer_By_Where_InList.START_ROW == null) { i_Params_Get_Answer_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Answer_By_Where_InList.END_ROW == null) || (i_Params_Get_Answer_By_Where_InList.END_ROW == 0)) { i_Params_Get_Answer_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Answer_By_Where_InList_SP.OWNER_ID = i_Params_Get_Answer_By_Where_InList.OWNER_ID;
oParams_Get_Answer_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Answer_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Answer_By_Where_InList.QUESTION_ID_LIST == null)
{
i_Params_Get_Answer_By_Where_InList.QUESTION_ID_LIST = new List<Int32?>();
}
oParams_Get_Answer_By_Where_InList_SP.QUESTION_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Answer_By_Where_InList.QUESTION_ID_LIST);
if ( i_Params_Get_Answer_By_Where_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Answer_By_Where_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Answer_By_Where_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Answer_By_Where_InList.TEACHER_ID_LIST);
if ( i_Params_Get_Answer_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Answer_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Answer_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Answer_By_Where_InList.STUDENT_ID_LIST);
oParams_Get_Answer_By_Where_InList_SP.START_ROW = i_Params_Get_Answer_By_Where_InList.START_ROW;
oParams_Get_Answer_By_Where_InList_SP.END_ROW = i_Params_Get_Answer_By_Where_InList.END_ROW;
oParams_Get_Answer_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Answer_By_Where_InList.TOTAL_COUNT;
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Where_InList(i_Params_Get_Answer_By_Where_InList.DESCRIPTION,i_Params_Get_Answer_By_Where_InList.QUESTION_ID_LIST,i_Params_Get_Answer_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Answer_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Answer_By_Where_InList.OWNER_ID,i_Params_Get_Answer_By_Where_InList.START_ROW,i_Params_Get_Answer_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Where_InList.TOTAL_COUNT = oParams_Get_Answer_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Answer_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Where_InList");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria_InList(Params_Get_Category_favorite_By_Criteria_InList i_Params_Get_Category_favorite_By_Criteria_InList)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Category_favorite_By_Criteria_InList_SP oParams_Get_Category_favorite_By_Criteria_InList_SP = new Params_Get_Category_favorite_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Category_favorite_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Category_favorite_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Category_favorite_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_favorite_By_Criteria_InList.START_ROW == null) { i_Params_Get_Category_favorite_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Category_favorite_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Category_favorite_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Category_favorite_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Category_favorite_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Category_favorite_By_Criteria_InList.OWNER_ID;
oParams_Get_Category_favorite_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Category_favorite_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Category_favorite_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Category_favorite_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Category_favorite_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Category_favorite_By_Criteria_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Category_favorite_By_Criteria_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Category_favorite_By_Criteria_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Category_favorite_By_Criteria_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Category_favorite_By_Criteria_InList.CATEGORY_ID_LIST);
oParams_Get_Category_favorite_By_Criteria_InList_SP.START_ROW = i_Params_Get_Category_favorite_By_Criteria_InList.START_ROW;
oParams_Get_Category_favorite_By_Criteria_InList_SP.END_ROW = i_Params_Get_Category_favorite_By_Criteria_InList.END_ROW;
oParams_Get_Category_favorite_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Category_favorite_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Criteria_InList(i_Params_Get_Category_favorite_By_Criteria_InList.DESCRIPTION,i_Params_Get_Category_favorite_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Category_favorite_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Category_favorite_By_Criteria_InList.OWNER_ID,i_Params_Get_Category_favorite_By_Criteria_InList.START_ROW,i_Params_Get_Category_favorite_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Category_favorite_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Category_favorite_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Criteria_InList");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where_InList(Params_Get_Category_favorite_By_Where_InList i_Params_Get_Category_favorite_By_Where_InList)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Category_favorite_By_Where_InList_SP oParams_Get_Category_favorite_By_Where_InList_SP = new Params_Get_Category_favorite_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Category_favorite_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Category_favorite_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Category_favorite_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_favorite_By_Where_InList.START_ROW == null) { i_Params_Get_Category_favorite_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Category_favorite_By_Where_InList.END_ROW == null) || (i_Params_Get_Category_favorite_By_Where_InList.END_ROW == 0)) { i_Params_Get_Category_favorite_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Category_favorite_By_Where_InList_SP.OWNER_ID = i_Params_Get_Category_favorite_By_Where_InList.OWNER_ID;
oParams_Get_Category_favorite_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Category_favorite_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Category_favorite_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Category_favorite_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Category_favorite_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Category_favorite_By_Where_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Category_favorite_By_Where_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Category_favorite_By_Where_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Category_favorite_By_Where_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Category_favorite_By_Where_InList.CATEGORY_ID_LIST);
oParams_Get_Category_favorite_By_Where_InList_SP.START_ROW = i_Params_Get_Category_favorite_By_Where_InList.START_ROW;
oParams_Get_Category_favorite_By_Where_InList_SP.END_ROW = i_Params_Get_Category_favorite_By_Where_InList.END_ROW;
oParams_Get_Category_favorite_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Category_favorite_By_Where_InList.TOTAL_COUNT;
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Where_InList(i_Params_Get_Category_favorite_By_Where_InList.DESCRIPTION,i_Params_Get_Category_favorite_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Category_favorite_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Category_favorite_By_Where_InList.OWNER_ID,i_Params_Get_Category_favorite_By_Where_InList.START_ROW,i_Params_Get_Category_favorite_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Where_InList.TOTAL_COUNT = oParams_Get_Category_favorite_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Category_favorite_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Where_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria_InList.START_ROW == null) { i_Params_Get_Contact_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Contact_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Criteria_InList.OWNER_ID;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT = i_Params_Get_Contact_By_Criteria_InList.CONTACT;
oParams_Get_Contact_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Criteria_InList_SP.START_ROW = i_Params_Get_Contact_By_Criteria_InList.START_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.END_ROW = i_Params_Get_Contact_By_Criteria_InList.END_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where_InList.START_ROW == null) { i_Params_Get_Contact_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where_InList.END_ROW == null) || (i_Params_Get_Contact_By_Where_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Where_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Where_InList.OWNER_ID;
oParams_Get_Contact_By_Where_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Where_InList_SP.CONTACT = i_Params_Get_Contact_By_Where_InList.CONTACT;
oParams_Get_Contact_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Where_InList_SP.START_ROW = i_Params_Get_Contact_By_Where_InList.START_ROW;
oParams_Get_Contact_By_Where_InList_SP.END_ROW = i_Params_Get_Contact_By_Where_InList.END_ROW;
oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria_InList(Params_Get_Evaluation_By_Criteria_InList i_Params_Get_Evaluation_By_Criteria_InList)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Evaluation_By_Criteria_InList_SP oParams_Get_Evaluation_By_Criteria_InList_SP = new Params_Get_Evaluation_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Evaluation_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Evaluation_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Evaluation_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Evaluation_By_Criteria_InList.START_ROW == null) { i_Params_Get_Evaluation_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Evaluation_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Evaluation_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Evaluation_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Evaluation_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Evaluation_By_Criteria_InList.OWNER_ID;
oParams_Get_Evaluation_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Evaluation_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Evaluation_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Evaluation_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Evaluation_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Evaluation_By_Criteria_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Evaluation_By_Criteria_InList.ANSWER_ID_LIST == null)
{
i_Params_Get_Evaluation_By_Criteria_InList.ANSWER_ID_LIST = new List<Int32?>();
}
oParams_Get_Evaluation_By_Criteria_InList_SP.ANSWER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Evaluation_By_Criteria_InList.ANSWER_ID_LIST);
oParams_Get_Evaluation_By_Criteria_InList_SP.START_ROW = i_Params_Get_Evaluation_By_Criteria_InList.START_ROW;
oParams_Get_Evaluation_By_Criteria_InList_SP.END_ROW = i_Params_Get_Evaluation_By_Criteria_InList.END_ROW;
oParams_Get_Evaluation_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Evaluation_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Criteria_InList(i_Params_Get_Evaluation_By_Criteria_InList.DESCRIPTION,i_Params_Get_Evaluation_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Evaluation_By_Criteria_InList.ANSWER_ID_LIST,i_Params_Get_Evaluation_By_Criteria_InList.OWNER_ID,i_Params_Get_Evaluation_By_Criteria_InList.START_ROW,i_Params_Get_Evaluation_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Evaluation_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Evaluation_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Criteria_InList");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where_InList(Params_Get_Evaluation_By_Where_InList i_Params_Get_Evaluation_By_Where_InList)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Evaluation_By_Where_InList_SP oParams_Get_Evaluation_By_Where_InList_SP = new Params_Get_Evaluation_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Evaluation_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Evaluation_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Evaluation_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Evaluation_By_Where_InList.START_ROW == null) { i_Params_Get_Evaluation_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Evaluation_By_Where_InList.END_ROW == null) || (i_Params_Get_Evaluation_By_Where_InList.END_ROW == 0)) { i_Params_Get_Evaluation_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Evaluation_By_Where_InList_SP.OWNER_ID = i_Params_Get_Evaluation_By_Where_InList.OWNER_ID;
oParams_Get_Evaluation_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Evaluation_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Evaluation_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Evaluation_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Evaluation_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Evaluation_By_Where_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Evaluation_By_Where_InList.ANSWER_ID_LIST == null)
{
i_Params_Get_Evaluation_By_Where_InList.ANSWER_ID_LIST = new List<Int32?>();
}
oParams_Get_Evaluation_By_Where_InList_SP.ANSWER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Evaluation_By_Where_InList.ANSWER_ID_LIST);
oParams_Get_Evaluation_By_Where_InList_SP.START_ROW = i_Params_Get_Evaluation_By_Where_InList.START_ROW;
oParams_Get_Evaluation_By_Where_InList_SP.END_ROW = i_Params_Get_Evaluation_By_Where_InList.END_ROW;
oParams_Get_Evaluation_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Evaluation_By_Where_InList.TOTAL_COUNT;
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Where_InList(i_Params_Get_Evaluation_By_Where_InList.DESCRIPTION,i_Params_Get_Evaluation_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Evaluation_By_Where_InList.ANSWER_ID_LIST,i_Params_Get_Evaluation_By_Where_InList.OWNER_ID,i_Params_Get_Evaluation_By_Where_InList.START_ROW,i_Params_Get_Evaluation_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Where_InList.TOTAL_COUNT = oParams_Get_Evaluation_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Evaluation_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Where_InList");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_InList(Params_Get_Favorite_teacher_By_Criteria_InList i_Params_Get_Favorite_teacher_By_Criteria_InList)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Favorite_teacher_By_Criteria_InList_SP oParams_Get_Favorite_teacher_By_Criteria_InList_SP = new Params_Get_Favorite_teacher_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Favorite_teacher_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Favorite_teacher_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Favorite_teacher_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Favorite_teacher_By_Criteria_InList.START_ROW == null) { i_Params_Get_Favorite_teacher_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Favorite_teacher_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Favorite_teacher_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Favorite_teacher_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Favorite_teacher_By_Criteria_InList.OWNER_ID;
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Favorite_teacher_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Favorite_teacher_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Favorite_teacher_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Favorite_teacher_By_Criteria_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Favorite_teacher_By_Criteria_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Favorite_teacher_By_Criteria_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Favorite_teacher_By_Criteria_InList.TEACHER_ID_LIST);
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.START_ROW = i_Params_Get_Favorite_teacher_By_Criteria_InList.START_ROW;
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.END_ROW = i_Params_Get_Favorite_teacher_By_Criteria_InList.END_ROW;
oParams_Get_Favorite_teacher_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Favorite_teacher_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Criteria_InList(i_Params_Get_Favorite_teacher_By_Criteria_InList.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Favorite_teacher_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Favorite_teacher_By_Criteria_InList.OWNER_ID,i_Params_Get_Favorite_teacher_By_Criteria_InList.START_ROW,i_Params_Get_Favorite_teacher_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Favorite_teacher_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Favorite_teacher_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Criteria_InList");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where_InList(Params_Get_Favorite_teacher_By_Where_InList i_Params_Get_Favorite_teacher_By_Where_InList)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Favorite_teacher_By_Where_InList_SP oParams_Get_Favorite_teacher_By_Where_InList_SP = new Params_Get_Favorite_teacher_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Favorite_teacher_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Favorite_teacher_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Favorite_teacher_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Favorite_teacher_By_Where_InList.START_ROW == null) { i_Params_Get_Favorite_teacher_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Favorite_teacher_By_Where_InList.END_ROW == null) || (i_Params_Get_Favorite_teacher_By_Where_InList.END_ROW == 0)) { i_Params_Get_Favorite_teacher_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Favorite_teacher_By_Where_InList_SP.OWNER_ID = i_Params_Get_Favorite_teacher_By_Where_InList.OWNER_ID;
oParams_Get_Favorite_teacher_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Favorite_teacher_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Favorite_teacher_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Favorite_teacher_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Favorite_teacher_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Favorite_teacher_By_Where_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Favorite_teacher_By_Where_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Favorite_teacher_By_Where_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Favorite_teacher_By_Where_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Favorite_teacher_By_Where_InList.TEACHER_ID_LIST);
oParams_Get_Favorite_teacher_By_Where_InList_SP.START_ROW = i_Params_Get_Favorite_teacher_By_Where_InList.START_ROW;
oParams_Get_Favorite_teacher_By_Where_InList_SP.END_ROW = i_Params_Get_Favorite_teacher_By_Where_InList.END_ROW;
oParams_Get_Favorite_teacher_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Favorite_teacher_By_Where_InList.TOTAL_COUNT;
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Where_InList(i_Params_Get_Favorite_teacher_By_Where_InList.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Favorite_teacher_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Favorite_teacher_By_Where_InList.OWNER_ID,i_Params_Get_Favorite_teacher_By_Where_InList.START_ROW,i_Params_Get_Favorite_teacher_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Where_InList.TOTAL_COUNT = oParams_Get_Favorite_teacher_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Favorite_teacher_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Where_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l2_By_Criteria_InList.CODE;
oParams_Get_Loc_l2_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Where_InList_SP.CODE = i_Params_Get_Loc_l2_By_Where_InList.CODE;
oParams_Get_Loc_l2_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Where_InList.START_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Where_InList.END_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l3_By_Criteria_InList.CODE;
oParams_Get_Loc_l3_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Where_InList_SP.CODE = i_Params_Get_Loc_l3_By_Where_InList.CODE;
oParams_Get_Loc_l3_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Where_InList.START_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Where_InList.END_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l4_By_Criteria_InList.CODE;
oParams_Get_Loc_l4_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Where_InList_SP.CODE = i_Params_Get_Loc_l4_By_Where_InList.CODE;
oParams_Get_Loc_l4_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Where_InList.START_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Where_InList.END_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList");}
return oList;
}
public List<Question> Get_Question_By_Criteria_InList(Params_Get_Question_By_Criteria_InList i_Params_Get_Question_By_Criteria_InList)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Question_By_Criteria_InList_SP oParams_Get_Question_By_Criteria_InList_SP = new Params_Get_Question_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Question_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Question_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Question_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_By_Criteria_InList.START_ROW == null) { i_Params_Get_Question_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Question_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Question_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Question_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Question_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Question_By_Criteria_InList.OWNER_ID;
oParams_Get_Question_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Question_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Question_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Question_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_By_Criteria_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Question_By_Criteria_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Question_By_Criteria_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_By_Criteria_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_By_Criteria_InList.CATEGORY_ID_LIST);
if ( i_Params_Get_Question_By_Criteria_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Question_By_Criteria_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_By_Criteria_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_By_Criteria_InList.TEACHER_ID_LIST);
oParams_Get_Question_By_Criteria_InList_SP.START_ROW = i_Params_Get_Question_By_Criteria_InList.START_ROW;
oParams_Get_Question_By_Criteria_InList_SP.END_ROW = i_Params_Get_Question_By_Criteria_InList.END_ROW;
oParams_Get_Question_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Question_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Criteria_InList(i_Params_Get_Question_By_Criteria_InList.DESCRIPTION,i_Params_Get_Question_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Question_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Question_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Question_By_Criteria_InList.OWNER_ID,i_Params_Get_Question_By_Criteria_InList.START_ROW,i_Params_Get_Question_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Question_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Criteria_InList");}
return oList;
}
public List<Question> Get_Question_By_Where_InList(Params_Get_Question_By_Where_InList i_Params_Get_Question_By_Where_InList)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Question_By_Where_InList_SP oParams_Get_Question_By_Where_InList_SP = new Params_Get_Question_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Question_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Question_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Question_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_By_Where_InList.START_ROW == null) { i_Params_Get_Question_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Question_By_Where_InList.END_ROW == null) || (i_Params_Get_Question_By_Where_InList.END_ROW == 0)) { i_Params_Get_Question_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Question_By_Where_InList_SP.OWNER_ID = i_Params_Get_Question_By_Where_InList.OWNER_ID;
oParams_Get_Question_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Question_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Question_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Question_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_By_Where_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Question_By_Where_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Question_By_Where_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_By_Where_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_By_Where_InList.CATEGORY_ID_LIST);
if ( i_Params_Get_Question_By_Where_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Question_By_Where_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_By_Where_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_By_Where_InList.TEACHER_ID_LIST);
oParams_Get_Question_By_Where_InList_SP.START_ROW = i_Params_Get_Question_By_Where_InList.START_ROW;
oParams_Get_Question_By_Where_InList_SP.END_ROW = i_Params_Get_Question_By_Where_InList.END_ROW;
oParams_Get_Question_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Question_By_Where_InList.TOTAL_COUNT;
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Where_InList(i_Params_Get_Question_By_Where_InList.DESCRIPTION,i_Params_Get_Question_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Question_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Question_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Question_By_Where_InList.OWNER_ID,i_Params_Get_Question_By_Where_InList.START_ROW,i_Params_Get_Question_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Where_InList.TOTAL_COUNT = oParams_Get_Question_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Where_InList");}
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria_InList(Params_Get_Question_token_By_Criteria_InList i_Params_Get_Question_token_By_Criteria_InList)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Question_token_By_Criteria_InList_SP oParams_Get_Question_token_By_Criteria_InList_SP = new Params_Get_Question_token_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Question_token_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Question_token_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Question_token_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_token_By_Criteria_InList.START_ROW == null) { i_Params_Get_Question_token_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Question_token_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Question_token_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Question_token_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Question_token_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Question_token_By_Criteria_InList.OWNER_ID;
oParams_Get_Question_token_By_Criteria_InList_SP.PART = i_Params_Get_Question_token_By_Criteria_InList.PART;
if ( i_Params_Get_Question_token_By_Criteria_InList.QUESTION_ID_LIST == null)
{
i_Params_Get_Question_token_By_Criteria_InList.QUESTION_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_token_By_Criteria_InList_SP.QUESTION_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_token_By_Criteria_InList.QUESTION_ID_LIST);
oParams_Get_Question_token_By_Criteria_InList_SP.START_ROW = i_Params_Get_Question_token_By_Criteria_InList.START_ROW;
oParams_Get_Question_token_By_Criteria_InList_SP.END_ROW = i_Params_Get_Question_token_By_Criteria_InList.END_ROW;
oParams_Get_Question_token_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Question_token_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Criteria_InList(i_Params_Get_Question_token_By_Criteria_InList.PART,i_Params_Get_Question_token_By_Criteria_InList.QUESTION_ID_LIST,i_Params_Get_Question_token_By_Criteria_InList.OWNER_ID,i_Params_Get_Question_token_By_Criteria_InList.START_ROW,i_Params_Get_Question_token_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Question_token_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_token_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Criteria_InList");}
return oList;
}
public List<Question_token> Get_Question_token_By_Where_InList(Params_Get_Question_token_By_Where_InList i_Params_Get_Question_token_By_Where_InList)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Question_token_By_Where_InList_SP oParams_Get_Question_token_By_Where_InList_SP = new Params_Get_Question_token_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Question_token_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Question_token_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Question_token_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_token_By_Where_InList.START_ROW == null) { i_Params_Get_Question_token_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Question_token_By_Where_InList.END_ROW == null) || (i_Params_Get_Question_token_By_Where_InList.END_ROW == 0)) { i_Params_Get_Question_token_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Question_token_By_Where_InList_SP.OWNER_ID = i_Params_Get_Question_token_By_Where_InList.OWNER_ID;
oParams_Get_Question_token_By_Where_InList_SP.PART = i_Params_Get_Question_token_By_Where_InList.PART;
if ( i_Params_Get_Question_token_By_Where_InList.QUESTION_ID_LIST == null)
{
i_Params_Get_Question_token_By_Where_InList.QUESTION_ID_LIST = new List<Int32?>();
}
oParams_Get_Question_token_By_Where_InList_SP.QUESTION_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Question_token_By_Where_InList.QUESTION_ID_LIST);
oParams_Get_Question_token_By_Where_InList_SP.START_ROW = i_Params_Get_Question_token_By_Where_InList.START_ROW;
oParams_Get_Question_token_By_Where_InList_SP.END_ROW = i_Params_Get_Question_token_By_Where_InList.END_ROW;
oParams_Get_Question_token_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Question_token_By_Where_InList.TOTAL_COUNT;
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Where_InList(i_Params_Get_Question_token_By_Where_InList.PART,i_Params_Get_Question_token_By_Where_InList.QUESTION_ID_LIST,i_Params_Get_Question_token_By_Where_InList.OWNER_ID,i_Params_Get_Question_token_By_Where_InList.START_ROW,i_Params_Get_Question_token_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Where_InList.TOTAL_COUNT = oParams_Get_Question_token_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_token_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Where_InList");}
return oList;
}
public List<Student> Get_Student_By_Criteria_InList(Params_Get_Student_By_Criteria_InList i_Params_Get_Student_By_Criteria_InList)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Student_By_Criteria_InList_SP oParams_Get_Student_By_Criteria_InList_SP = new Params_Get_Student_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Student_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Student_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Student_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_By_Criteria_InList.START_ROW == null) { i_Params_Get_Student_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Student_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Student_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Student_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Student_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Student_By_Criteria_InList.OWNER_ID;
oParams_Get_Student_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Student_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Student_By_Criteria_InList.USER_ID_LIST == null)
{
i_Params_Get_Student_By_Criteria_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_Student_By_Criteria_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Student_By_Criteria_InList.USER_ID_LIST);
if ( i_Params_Get_Student_By_Criteria_InList.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_Student_By_Criteria_InList.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_Student_By_Criteria_InList_SP.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Student_By_Criteria_InList.USER_TYPE_CODE_ID_LIST);
oParams_Get_Student_By_Criteria_InList_SP.START_ROW = i_Params_Get_Student_By_Criteria_InList.START_ROW;
oParams_Get_Student_By_Criteria_InList_SP.END_ROW = i_Params_Get_Student_By_Criteria_InList.END_ROW;
oParams_Get_Student_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Student_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Criteria_InList(i_Params_Get_Student_By_Criteria_InList.DESCRIPTION,i_Params_Get_Student_By_Criteria_InList.USER_ID_LIST,i_Params_Get_Student_By_Criteria_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Student_By_Criteria_InList.OWNER_ID,i_Params_Get_Student_By_Criteria_InList.START_ROW,i_Params_Get_Student_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Student_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Criteria_InList");}
return oList;
}
public List<Student> Get_Student_By_Where_InList(Params_Get_Student_By_Where_InList i_Params_Get_Student_By_Where_InList)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Student_By_Where_InList_SP oParams_Get_Student_By_Where_InList_SP = new Params_Get_Student_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Student_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Student_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Student_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_By_Where_InList.START_ROW == null) { i_Params_Get_Student_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Student_By_Where_InList.END_ROW == null) || (i_Params_Get_Student_By_Where_InList.END_ROW == 0)) { i_Params_Get_Student_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Student_By_Where_InList_SP.OWNER_ID = i_Params_Get_Student_By_Where_InList.OWNER_ID;
oParams_Get_Student_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Student_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Student_By_Where_InList.USER_ID_LIST == null)
{
i_Params_Get_Student_By_Where_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_Student_By_Where_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Student_By_Where_InList.USER_ID_LIST);
if ( i_Params_Get_Student_By_Where_InList.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_Student_By_Where_InList.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_Student_By_Where_InList_SP.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Student_By_Where_InList.USER_TYPE_CODE_ID_LIST);
oParams_Get_Student_By_Where_InList_SP.START_ROW = i_Params_Get_Student_By_Where_InList.START_ROW;
oParams_Get_Student_By_Where_InList_SP.END_ROW = i_Params_Get_Student_By_Where_InList.END_ROW;
oParams_Get_Student_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Student_By_Where_InList.TOTAL_COUNT;
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Where_InList(i_Params_Get_Student_By_Where_InList.DESCRIPTION,i_Params_Get_Student_By_Where_InList.USER_ID_LIST,i_Params_Get_Student_By_Where_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Student_By_Where_InList.OWNER_ID,i_Params_Get_Student_By_Where_InList.START_ROW,i_Params_Get_Student_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Where_InList.TOTAL_COUNT = oParams_Get_Student_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Where_InList");}
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria_InList(Params_Get_Student_report_By_Criteria_InList i_Params_Get_Student_report_By_Criteria_InList)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Student_report_By_Criteria_InList_SP oParams_Get_Student_report_By_Criteria_InList_SP = new Params_Get_Student_report_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Student_report_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Student_report_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Student_report_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_report_By_Criteria_InList.START_ROW == null) { i_Params_Get_Student_report_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Student_report_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Student_report_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Student_report_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Student_report_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Student_report_By_Criteria_InList.OWNER_ID;
oParams_Get_Student_report_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Student_report_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Student_report_By_Criteria_InList.REPORTED_BY_STUDENT_ID_LIST == null)
{
i_Params_Get_Student_report_By_Criteria_InList.REPORTED_BY_STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Student_report_By_Criteria_InList_SP.REPORTED_BY_STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Student_report_By_Criteria_InList.REPORTED_BY_STUDENT_ID_LIST);
if ( i_Params_Get_Student_report_By_Criteria_InList.REPORTED_STUDENT_ID_LIST == null)
{
i_Params_Get_Student_report_By_Criteria_InList.REPORTED_STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Student_report_By_Criteria_InList_SP.REPORTED_STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Student_report_By_Criteria_InList.REPORTED_STUDENT_ID_LIST);
oParams_Get_Student_report_By_Criteria_InList_SP.START_ROW = i_Params_Get_Student_report_By_Criteria_InList.START_ROW;
oParams_Get_Student_report_By_Criteria_InList_SP.END_ROW = i_Params_Get_Student_report_By_Criteria_InList.END_ROW;
oParams_Get_Student_report_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Student_report_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Criteria_InList(i_Params_Get_Student_report_By_Criteria_InList.DESCRIPTION,i_Params_Get_Student_report_By_Criteria_InList.REPORTED_BY_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Criteria_InList.REPORTED_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Criteria_InList.OWNER_ID,i_Params_Get_Student_report_By_Criteria_InList.START_ROW,i_Params_Get_Student_report_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Student_report_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_report_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Criteria_InList");}
return oList;
}
public List<Student_report> Get_Student_report_By_Where_InList(Params_Get_Student_report_By_Where_InList i_Params_Get_Student_report_By_Where_InList)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Student_report_By_Where_InList_SP oParams_Get_Student_report_By_Where_InList_SP = new Params_Get_Student_report_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Student_report_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Student_report_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Student_report_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_report_By_Where_InList.START_ROW == null) { i_Params_Get_Student_report_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Student_report_By_Where_InList.END_ROW == null) || (i_Params_Get_Student_report_By_Where_InList.END_ROW == 0)) { i_Params_Get_Student_report_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Student_report_By_Where_InList_SP.OWNER_ID = i_Params_Get_Student_report_By_Where_InList.OWNER_ID;
oParams_Get_Student_report_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Student_report_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Student_report_By_Where_InList.REPORTED_BY_STUDENT_ID_LIST == null)
{
i_Params_Get_Student_report_By_Where_InList.REPORTED_BY_STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Student_report_By_Where_InList_SP.REPORTED_BY_STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Student_report_By_Where_InList.REPORTED_BY_STUDENT_ID_LIST);
if ( i_Params_Get_Student_report_By_Where_InList.REPORTED_STUDENT_ID_LIST == null)
{
i_Params_Get_Student_report_By_Where_InList.REPORTED_STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Student_report_By_Where_InList_SP.REPORTED_STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Student_report_By_Where_InList.REPORTED_STUDENT_ID_LIST);
oParams_Get_Student_report_By_Where_InList_SP.START_ROW = i_Params_Get_Student_report_By_Where_InList.START_ROW;
oParams_Get_Student_report_By_Where_InList_SP.END_ROW = i_Params_Get_Student_report_By_Where_InList.END_ROW;
oParams_Get_Student_report_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Student_report_By_Where_InList.TOTAL_COUNT;
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Where_InList(i_Params_Get_Student_report_By_Where_InList.DESCRIPTION,i_Params_Get_Student_report_By_Where_InList.REPORTED_BY_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Where_InList.REPORTED_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Where_InList.OWNER_ID,i_Params_Get_Student_report_By_Where_InList.START_ROW,i_Params_Get_Student_report_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Where_InList.TOTAL_COUNT = oParams_Get_Student_report_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_report_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Where_InList");}
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria_InList(Params_Get_Teacher_By_Criteria_InList i_Params_Get_Teacher_By_Criteria_InList)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_By_Criteria_InList_SP oParams_Get_Teacher_By_Criteria_InList_SP = new Params_Get_Teacher_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Teacher_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_By_Criteria_InList.START_ROW == null) { i_Params_Get_Teacher_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Teacher_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Teacher_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Teacher_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Teacher_By_Criteria_InList.OWNER_ID;
oParams_Get_Teacher_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Teacher_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_By_Criteria_InList.USER_ID_LIST == null)
{
i_Params_Get_Teacher_By_Criteria_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_Teacher_By_Criteria_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Teacher_By_Criteria_InList.USER_ID_LIST);
if ( i_Params_Get_Teacher_By_Criteria_InList.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_Teacher_By_Criteria_InList.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_By_Criteria_InList_SP.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_By_Criteria_InList.USER_TYPE_CODE_ID_LIST);
if ( i_Params_Get_Teacher_By_Criteria_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Teacher_By_Criteria_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_By_Criteria_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_By_Criteria_InList.CATEGORY_ID_LIST);
oParams_Get_Teacher_By_Criteria_InList_SP.START_ROW = i_Params_Get_Teacher_By_Criteria_InList.START_ROW;
oParams_Get_Teacher_By_Criteria_InList_SP.END_ROW = i_Params_Get_Teacher_By_Criteria_InList.END_ROW;
oParams_Get_Teacher_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Criteria_InList(i_Params_Get_Teacher_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_By_Criteria_InList.USER_ID_LIST,i_Params_Get_Teacher_By_Criteria_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Teacher_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Criteria_InList");}
return oList;
}
public List<Teacher> Get_Teacher_By_Where_InList(Params_Get_Teacher_By_Where_InList i_Params_Get_Teacher_By_Where_InList)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_By_Where_InList_SP oParams_Get_Teacher_By_Where_InList_SP = new Params_Get_Teacher_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Teacher_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_By_Where_InList.START_ROW == null) { i_Params_Get_Teacher_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_By_Where_InList.END_ROW == null) || (i_Params_Get_Teacher_By_Where_InList.END_ROW == 0)) { i_Params_Get_Teacher_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Teacher_By_Where_InList_SP.OWNER_ID = i_Params_Get_Teacher_By_Where_InList.OWNER_ID;
oParams_Get_Teacher_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Teacher_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_By_Where_InList.USER_ID_LIST == null)
{
i_Params_Get_Teacher_By_Where_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_Teacher_By_Where_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Teacher_By_Where_InList.USER_ID_LIST);
if ( i_Params_Get_Teacher_By_Where_InList.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_Teacher_By_Where_InList.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_By_Where_InList_SP.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_By_Where_InList.USER_TYPE_CODE_ID_LIST);
if ( i_Params_Get_Teacher_By_Where_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Teacher_By_Where_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_By_Where_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_By_Where_InList.CATEGORY_ID_LIST);
oParams_Get_Teacher_By_Where_InList_SP.START_ROW = i_Params_Get_Teacher_By_Where_InList.START_ROW;
oParams_Get_Teacher_By_Where_InList_SP.END_ROW = i_Params_Get_Teacher_By_Where_InList.END_ROW;
oParams_Get_Teacher_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_By_Where_InList.TOTAL_COUNT;
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Where_InList(i_Params_Get_Teacher_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_By_Where_InList.USER_ID_LIST,i_Params_Get_Teacher_By_Where_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Teacher_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_By_Where_InList.START_ROW,i_Params_Get_Teacher_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Where_InList");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria_InList(Params_Get_Teacher_category_By_Criteria_InList i_Params_Get_Teacher_category_By_Criteria_InList)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_category_By_Criteria_InList_SP oParams_Get_Teacher_category_By_Criteria_InList_SP = new Params_Get_Teacher_category_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_category_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Teacher_category_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_category_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_category_By_Criteria_InList.START_ROW == null) { i_Params_Get_Teacher_category_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_category_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Teacher_category_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Teacher_category_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Teacher_category_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Teacher_category_By_Criteria_InList.OWNER_ID;
oParams_Get_Teacher_category_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Teacher_category_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_category_By_Criteria_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Teacher_category_By_Criteria_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_category_By_Criteria_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_category_By_Criteria_InList.TEACHER_ID_LIST);
if ( i_Params_Get_Teacher_category_By_Criteria_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Teacher_category_By_Criteria_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_category_By_Criteria_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_category_By_Criteria_InList.CATEGORY_ID_LIST);
oParams_Get_Teacher_category_By_Criteria_InList_SP.START_ROW = i_Params_Get_Teacher_category_By_Criteria_InList.START_ROW;
oParams_Get_Teacher_category_By_Criteria_InList_SP.END_ROW = i_Params_Get_Teacher_category_By_Criteria_InList.END_ROW;
oParams_Get_Teacher_category_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_category_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Criteria_InList(i_Params_Get_Teacher_category_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_category_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_category_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_category_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_category_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_category_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_category_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_category_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Criteria_InList");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where_InList(Params_Get_Teacher_category_By_Where_InList i_Params_Get_Teacher_category_By_Where_InList)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_category_By_Where_InList_SP oParams_Get_Teacher_category_By_Where_InList_SP = new Params_Get_Teacher_category_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_category_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Teacher_category_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_category_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_category_By_Where_InList.START_ROW == null) { i_Params_Get_Teacher_category_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_category_By_Where_InList.END_ROW == null) || (i_Params_Get_Teacher_category_By_Where_InList.END_ROW == 0)) { i_Params_Get_Teacher_category_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Teacher_category_By_Where_InList_SP.OWNER_ID = i_Params_Get_Teacher_category_By_Where_InList.OWNER_ID;
oParams_Get_Teacher_category_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Teacher_category_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_category_By_Where_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Teacher_category_By_Where_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_category_By_Where_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_category_By_Where_InList.TEACHER_ID_LIST);
if ( i_Params_Get_Teacher_category_By_Where_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Teacher_category_By_Where_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_category_By_Where_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_category_By_Where_InList.CATEGORY_ID_LIST);
oParams_Get_Teacher_category_By_Where_InList_SP.START_ROW = i_Params_Get_Teacher_category_By_Where_InList.START_ROW;
oParams_Get_Teacher_category_By_Where_InList_SP.END_ROW = i_Params_Get_Teacher_category_By_Where_InList.END_ROW;
oParams_Get_Teacher_category_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_category_By_Where_InList.TOTAL_COUNT;
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Where_InList(i_Params_Get_Teacher_category_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_category_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_category_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_category_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_category_By_Where_InList.START_ROW,i_Params_Get_Teacher_category_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_category_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_category_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Where_InList");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_InList(Params_Get_Teacher_favorite_By_Criteria_InList i_Params_Get_Teacher_favorite_By_Criteria_InList)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_favorite_By_Criteria_InList_SP oParams_Get_Teacher_favorite_By_Criteria_InList_SP = new Params_Get_Teacher_favorite_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_favorite_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Teacher_favorite_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_favorite_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_favorite_By_Criteria_InList.START_ROW == null) { i_Params_Get_Teacher_favorite_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_favorite_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Teacher_favorite_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Teacher_favorite_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Teacher_favorite_By_Criteria_InList.OWNER_ID;
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Teacher_favorite_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_favorite_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Teacher_favorite_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_favorite_By_Criteria_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Teacher_favorite_By_Criteria_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Teacher_favorite_By_Criteria_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_favorite_By_Criteria_InList.TEACHER_ID_LIST);
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.START_ROW = i_Params_Get_Teacher_favorite_By_Criteria_InList.START_ROW;
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.END_ROW = i_Params_Get_Teacher_favorite_By_Criteria_InList.END_ROW;
oParams_Get_Teacher_favorite_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_favorite_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Criteria_InList(i_Params_Get_Teacher_favorite_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_favorite_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_favorite_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_favorite_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_favorite_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_favorite_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_favorite_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Criteria_InList");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where_InList(Params_Get_Teacher_favorite_By_Where_InList i_Params_Get_Teacher_favorite_By_Where_InList)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_favorite_By_Where_InList_SP oParams_Get_Teacher_favorite_By_Where_InList_SP = new Params_Get_Teacher_favorite_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_favorite_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Teacher_favorite_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_favorite_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_favorite_By_Where_InList.START_ROW == null) { i_Params_Get_Teacher_favorite_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_favorite_By_Where_InList.END_ROW == null) || (i_Params_Get_Teacher_favorite_By_Where_InList.END_ROW == 0)) { i_Params_Get_Teacher_favorite_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Teacher_favorite_By_Where_InList_SP.OWNER_ID = i_Params_Get_Teacher_favorite_By_Where_InList.OWNER_ID;
oParams_Get_Teacher_favorite_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Teacher_favorite_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_favorite_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Teacher_favorite_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_favorite_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_favorite_By_Where_InList.STUDENT_ID_LIST);
if ( i_Params_Get_Teacher_favorite_By_Where_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Teacher_favorite_By_Where_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_favorite_By_Where_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_favorite_By_Where_InList.TEACHER_ID_LIST);
oParams_Get_Teacher_favorite_By_Where_InList_SP.START_ROW = i_Params_Get_Teacher_favorite_By_Where_InList.START_ROW;
oParams_Get_Teacher_favorite_By_Where_InList_SP.END_ROW = i_Params_Get_Teacher_favorite_By_Where_InList.END_ROW;
oParams_Get_Teacher_favorite_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_favorite_By_Where_InList.TOTAL_COUNT;
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Where_InList(i_Params_Get_Teacher_favorite_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_favorite_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_favorite_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_favorite_By_Where_InList.START_ROW,i_Params_Get_Teacher_favorite_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_favorite_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_favorite_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Where_InList");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria_InList(Params_Get_Teacher_report_By_Criteria_InList i_Params_Get_Teacher_report_By_Criteria_InList)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_report_By_Criteria_InList_SP oParams_Get_Teacher_report_By_Criteria_InList_SP = new Params_Get_Teacher_report_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_report_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Teacher_report_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_report_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_report_By_Criteria_InList.START_ROW == null) { i_Params_Get_Teacher_report_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_report_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Teacher_report_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Teacher_report_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Teacher_report_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Teacher_report_By_Criteria_InList.OWNER_ID;
oParams_Get_Teacher_report_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Teacher_report_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_report_By_Criteria_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Teacher_report_By_Criteria_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_report_By_Criteria_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_report_By_Criteria_InList.TEACHER_ID_LIST);
if ( i_Params_Get_Teacher_report_By_Criteria_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Teacher_report_By_Criteria_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_report_By_Criteria_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_report_By_Criteria_InList.STUDENT_ID_LIST);
oParams_Get_Teacher_report_By_Criteria_InList_SP.START_ROW = i_Params_Get_Teacher_report_By_Criteria_InList.START_ROW;
oParams_Get_Teacher_report_By_Criteria_InList_SP.END_ROW = i_Params_Get_Teacher_report_By_Criteria_InList.END_ROW;
oParams_Get_Teacher_report_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_report_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Criteria_InList(i_Params_Get_Teacher_report_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_report_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_report_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_report_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_report_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_report_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_report_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_report_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Criteria_InList");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where_InList(Params_Get_Teacher_report_By_Where_InList i_Params_Get_Teacher_report_By_Where_InList)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Teacher_report_By_Where_InList_SP oParams_Get_Teacher_report_By_Where_InList_SP = new Params_Get_Teacher_report_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Teacher_report_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Teacher_report_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Teacher_report_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_report_By_Where_InList.START_ROW == null) { i_Params_Get_Teacher_report_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Teacher_report_By_Where_InList.END_ROW == null) || (i_Params_Get_Teacher_report_By_Where_InList.END_ROW == 0)) { i_Params_Get_Teacher_report_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Teacher_report_By_Where_InList_SP.OWNER_ID = i_Params_Get_Teacher_report_By_Where_InList.OWNER_ID;
oParams_Get_Teacher_report_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Teacher_report_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Teacher_report_By_Where_InList.TEACHER_ID_LIST == null)
{
i_Params_Get_Teacher_report_By_Where_InList.TEACHER_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_report_By_Where_InList_SP.TEACHER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_report_By_Where_InList.TEACHER_ID_LIST);
if ( i_Params_Get_Teacher_report_By_Where_InList.STUDENT_ID_LIST == null)
{
i_Params_Get_Teacher_report_By_Where_InList.STUDENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Teacher_report_By_Where_InList_SP.STUDENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Teacher_report_By_Where_InList.STUDENT_ID_LIST);
oParams_Get_Teacher_report_By_Where_InList_SP.START_ROW = i_Params_Get_Teacher_report_By_Where_InList.START_ROW;
oParams_Get_Teacher_report_By_Where_InList_SP.END_ROW = i_Params_Get_Teacher_report_By_Where_InList.END_ROW;
oParams_Get_Teacher_report_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Teacher_report_By_Where_InList.TOTAL_COUNT;
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Where_InList(i_Params_Get_Teacher_report_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_report_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_report_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_report_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_report_By_Where_InList.START_ROW,i_Params_Get_Teacher_report_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_report_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_report_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Where_InList");}
return oList;
}
public List<User> Get_User_By_Criteria_InList(Params_Get_User_By_Criteria_InList i_Params_Get_User_By_Criteria_InList)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
Params_Get_User_By_Criteria_InList_SP oParams_Get_User_By_Criteria_InList_SP = new Params_Get_User_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_User_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria_InList.START_ROW == null) { i_Params_Get_User_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria_InList.END_ROW == null) || (i_Params_Get_User_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_User_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_User_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_User_By_Criteria_InList.OWNER_ID;
oParams_Get_User_By_Criteria_InList_SP.USERNAME = i_Params_Get_User_By_Criteria_InList.USERNAME;
oParams_Get_User_By_Criteria_InList_SP.PASSWORD = i_Params_Get_User_By_Criteria_InList.PASSWORD;
oParams_Get_User_By_Criteria_InList_SP.EMAIL = i_Params_Get_User_By_Criteria_InList.EMAIL;
oParams_Get_User_By_Criteria_InList_SP.FIRST_NAME = i_Params_Get_User_By_Criteria_InList.FIRST_NAME;
oParams_Get_User_By_Criteria_InList_SP.LAST_NAME = i_Params_Get_User_By_Criteria_InList.LAST_NAME;
oParams_Get_User_By_Criteria_InList_SP.MOBILE = i_Params_Get_User_By_Criteria_InList.MOBILE;
if ( i_Params_Get_User_By_Criteria_InList.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_User_By_Criteria_InList.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_User_By_Criteria_InList_SP.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_User_By_Criteria_InList.USER_TYPE_CODE_ID_LIST);
oParams_Get_User_By_Criteria_InList_SP.START_ROW = i_Params_Get_User_By_Criteria_InList.START_ROW;
oParams_Get_User_By_Criteria_InList_SP.END_ROW = i_Params_Get_User_By_Criteria_InList.END_ROW;
oParams_Get_User_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_User_By_Criteria_InList.TOTAL_COUNT;
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_InList(i_Params_Get_User_By_Criteria_InList.USERNAME,i_Params_Get_User_By_Criteria_InList.PASSWORD,i_Params_Get_User_By_Criteria_InList.EMAIL,i_Params_Get_User_By_Criteria_InList.FIRST_NAME,i_Params_Get_User_By_Criteria_InList.LAST_NAME,i_Params_Get_User_By_Criteria_InList.MOBILE,i_Params_Get_User_By_Criteria_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Criteria_InList.OWNER_ID,i_Params_Get_User_By_Criteria_InList.START_ROW,i_Params_Get_User_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria_InList.TOTAL_COUNT = oParams_Get_User_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_User_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_InList");}
return oList;
}
public List<User> Get_User_By_Where_InList(Params_Get_User_By_Where_InList i_Params_Get_User_By_Where_InList)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
Params_Get_User_By_Where_InList_SP oParams_Get_User_By_Where_InList_SP = new Params_Get_User_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_User_By_Where_InList.OWNER_ID == null) || (i_Params_Get_User_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_User_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where_InList.START_ROW == null) { i_Params_Get_User_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_User_By_Where_InList.END_ROW == null) || (i_Params_Get_User_By_Where_InList.END_ROW == 0)) { i_Params_Get_User_By_Where_InList.END_ROW = 1000000; }
oParams_Get_User_By_Where_InList_SP.OWNER_ID = i_Params_Get_User_By_Where_InList.OWNER_ID;
oParams_Get_User_By_Where_InList_SP.USERNAME = i_Params_Get_User_By_Where_InList.USERNAME;
oParams_Get_User_By_Where_InList_SP.PASSWORD = i_Params_Get_User_By_Where_InList.PASSWORD;
oParams_Get_User_By_Where_InList_SP.EMAIL = i_Params_Get_User_By_Where_InList.EMAIL;
oParams_Get_User_By_Where_InList_SP.FIRST_NAME = i_Params_Get_User_By_Where_InList.FIRST_NAME;
oParams_Get_User_By_Where_InList_SP.LAST_NAME = i_Params_Get_User_By_Where_InList.LAST_NAME;
oParams_Get_User_By_Where_InList_SP.MOBILE = i_Params_Get_User_By_Where_InList.MOBILE;
if ( i_Params_Get_User_By_Where_InList.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_User_By_Where_InList.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_User_By_Where_InList_SP.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_User_By_Where_InList.USER_TYPE_CODE_ID_LIST);
oParams_Get_User_By_Where_InList_SP.START_ROW = i_Params_Get_User_By_Where_InList.START_ROW;
oParams_Get_User_By_Where_InList_SP.END_ROW = i_Params_Get_User_By_Where_InList.END_ROW;
oParams_Get_User_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_User_By_Where_InList.TOTAL_COUNT;
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_InList(i_Params_Get_User_By_Where_InList.USERNAME,i_Params_Get_User_By_Where_InList.PASSWORD,i_Params_Get_User_By_Where_InList.EMAIL,i_Params_Get_User_By_Where_InList.FIRST_NAME,i_Params_Get_User_By_Where_InList.LAST_NAME,i_Params_Get_User_By_Where_InList.MOBILE,i_Params_Get_User_By_Where_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Where_InList.OWNER_ID,i_Params_Get_User_By_Where_InList.START_ROW,i_Params_Get_User_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where_InList.TOTAL_COUNT = oParams_Get_User_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_User_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_InList");}
return oList;
}
public List<User> Get_User_By_Criteria_InList_V2(Params_Get_User_By_Criteria_InList_V2 i_Params_Get_User_By_Criteria_InList_V2)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
Params_Get_User_By_Criteria_InList_SP_V2 oParams_Get_User_By_Criteria_InList_SP_V2 = new Params_Get_User_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_InList_V2");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_User_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_User_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_User_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_User_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_User_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_User_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_User_By_Criteria_InList_SP_V2.USERNAME = i_Params_Get_User_By_Criteria_InList_V2.USERNAME;
oParams_Get_User_By_Criteria_InList_SP_V2.PASSWORD = i_Params_Get_User_By_Criteria_InList_V2.PASSWORD;
oParams_Get_User_By_Criteria_InList_SP_V2.EMAIL = i_Params_Get_User_By_Criteria_InList_V2.EMAIL;
oParams_Get_User_By_Criteria_InList_SP_V2.FIRST_NAME = i_Params_Get_User_By_Criteria_InList_V2.FIRST_NAME;
oParams_Get_User_By_Criteria_InList_SP_V2.LAST_NAME = i_Params_Get_User_By_Criteria_InList_V2.LAST_NAME;
oParams_Get_User_By_Criteria_InList_SP_V2.MOBILE = i_Params_Get_User_By_Criteria_InList_V2.MOBILE;
oParams_Get_User_By_Criteria_InList_SP_V2.DOB = i_Params_Get_User_By_Criteria_InList_V2.DOB;
if ( i_Params_Get_User_By_Criteria_InList_V2.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_User_By_Criteria_InList_V2.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_User_By_Criteria_InList_SP_V2.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_User_By_Criteria_InList_V2.USER_TYPE_CODE_ID_LIST);
oParams_Get_User_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_User_By_Criteria_InList_V2.START_ROW;
oParams_Get_User_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_User_By_Criteria_InList_V2.END_ROW;
oParams_Get_User_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_User_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_InList_V2(i_Params_Get_User_By_Criteria_InList_V2.USERNAME,i_Params_Get_User_By_Criteria_InList_V2.PASSWORD,i_Params_Get_User_By_Criteria_InList_V2.EMAIL,i_Params_Get_User_By_Criteria_InList_V2.FIRST_NAME,i_Params_Get_User_By_Criteria_InList_V2.LAST_NAME,i_Params_Get_User_By_Criteria_InList_V2.MOBILE,i_Params_Get_User_By_Criteria_InList_V2.DOB,i_Params_Get_User_By_Criteria_InList_V2.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_User_By_Criteria_InList_V2.START_ROW,i_Params_Get_User_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_User_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_User_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_InList_V2");}
return oList;
}
public List<User> Get_User_By_Where_InList_V2(Params_Get_User_By_Where_InList_V2 i_Params_Get_User_By_Where_InList_V2)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
Params_Get_User_By_Where_InList_SP_V2 oParams_Get_User_By_Where_InList_SP_V2 = new Params_Get_User_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_InList_V2");}
#region Body Section.
if ((i_Params_Get_User_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_User_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_User_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where_InList_V2.START_ROW == null) { i_Params_Get_User_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_User_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_User_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_User_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_User_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_User_By_Where_InList_V2.OWNER_ID;
oParams_Get_User_By_Where_InList_SP_V2.USERNAME = i_Params_Get_User_By_Where_InList_V2.USERNAME;
oParams_Get_User_By_Where_InList_SP_V2.PASSWORD = i_Params_Get_User_By_Where_InList_V2.PASSWORD;
oParams_Get_User_By_Where_InList_SP_V2.EMAIL = i_Params_Get_User_By_Where_InList_V2.EMAIL;
oParams_Get_User_By_Where_InList_SP_V2.FIRST_NAME = i_Params_Get_User_By_Where_InList_V2.FIRST_NAME;
oParams_Get_User_By_Where_InList_SP_V2.LAST_NAME = i_Params_Get_User_By_Where_InList_V2.LAST_NAME;
oParams_Get_User_By_Where_InList_SP_V2.MOBILE = i_Params_Get_User_By_Where_InList_V2.MOBILE;
oParams_Get_User_By_Where_InList_SP_V2.DOB = i_Params_Get_User_By_Where_InList_V2.DOB;
if ( i_Params_Get_User_By_Where_InList_V2.USER_TYPE_CODE_ID_LIST == null)
{
i_Params_Get_User_By_Where_InList_V2.USER_TYPE_CODE_ID_LIST = new List<Int32?>();
}
oParams_Get_User_By_Where_InList_SP_V2.USER_TYPE_CODE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_User_By_Where_InList_V2.USER_TYPE_CODE_ID_LIST);
oParams_Get_User_By_Where_InList_SP_V2.START_ROW = i_Params_Get_User_By_Where_InList_V2.START_ROW;
oParams_Get_User_By_Where_InList_SP_V2.END_ROW = i_Params_Get_User_By_Where_InList_V2.END_ROW;
oParams_Get_User_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_User_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_InList_V2(i_Params_Get_User_By_Where_InList_V2.USERNAME,i_Params_Get_User_By_Where_InList_V2.PASSWORD,i_Params_Get_User_By_Where_InList_V2.EMAIL,i_Params_Get_User_By_Where_InList_V2.FIRST_NAME,i_Params_Get_User_By_Where_InList_V2.LAST_NAME,i_Params_Get_User_By_Where_InList_V2.MOBILE,i_Params_Get_User_By_Where_InList_V2.DOB,i_Params_Get_User_By_Where_InList_V2.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Where_InList_V2.OWNER_ID,i_Params_Get_User_By_Where_InList_V2.START_ROW,i_Params_Get_User_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_User_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_User_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_InList_V2");}
return oList;
}
public void Delete_Address(Params_Delete_Address i_Params_Delete_Address)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address(i_Params_Delete_Address.ADDRESS_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address");}
}
public void Delete_Answer(Params_Delete_Answer i_Params_Delete_Answer)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Answer");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Answer_Execution)
{
_Stop_Delete_Answer_Execution = false;
return;
}
_AppContext.Delete_Answer(i_Params_Delete_Answer.ANSWER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Answer");}
}
public void Delete_Category(Params_Delete_Category i_Params_Delete_Category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_Execution)
{
_Stop_Delete_Category_Execution = false;
return;
}
_AppContext.Delete_Category(i_Params_Delete_Category.CATEGORY_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category");}
}
public void Delete_Category_favorite(Params_Delete_Category_favorite i_Params_Delete_Category_favorite)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_favorite");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_favorite_Execution)
{
_Stop_Delete_Category_favorite_Execution = false;
return;
}
_AppContext.Delete_Category_favorite(i_Params_Delete_Category_favorite.CATEGORY_FAVORITE_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_favorite");}
}
public void Delete_Contact(Params_Delete_Contact i_Params_Delete_Contact)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact(i_Params_Delete_Contact.CONTACT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact");}
}
public void Delete_Evaluation(Params_Delete_Evaluation i_Params_Delete_Evaluation)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Evaluation");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Evaluation_Execution)
{
_Stop_Delete_Evaluation_Execution = false;
return;
}
_AppContext.Delete_Evaluation(i_Params_Delete_Evaluation.EVALUATION_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Evaluation");}
}
public void Delete_Favorite_teacher(Params_Delete_Favorite_teacher i_Params_Delete_Favorite_teacher)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Favorite_teacher");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Favorite_teacher_Execution)
{
_Stop_Delete_Favorite_teacher_Execution = false;
return;
}
_AppContext.Delete_Favorite_teacher(i_Params_Delete_Favorite_teacher.FAVORITE_TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Favorite_teacher");}
}
public void Delete_Loc_l1(Params_Delete_Loc_l1 i_Params_Delete_Loc_l1)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1(i_Params_Delete_Loc_l1.LOC_L1_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1");}
}
public void Delete_Loc_l2(Params_Delete_Loc_l2 i_Params_Delete_Loc_l2)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2(i_Params_Delete_Loc_l2.LOC_L2_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2");}
}
public void Delete_Loc_l3(Params_Delete_Loc_l3 i_Params_Delete_Loc_l3)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3(i_Params_Delete_Loc_l3.LOC_L3_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3");}
}
public void Delete_Loc_l4(Params_Delete_Loc_l4 i_Params_Delete_Loc_l4)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4(i_Params_Delete_Loc_l4.LOC_L4_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Person(Params_Delete_Person i_Params_Delete_Person)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person(i_Params_Delete_Person.PERSON_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person");}
}
public void Delete_Question(Params_Delete_Question i_Params_Delete_Question)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_Execution)
{
_Stop_Delete_Question_Execution = false;
return;
}
_AppContext.Delete_Question(i_Params_Delete_Question.QUESTION_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question");}
}
public void Delete_Question_token(Params_Delete_Question_token i_Params_Delete_Question_token)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_token");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_token_Execution)
{
_Stop_Delete_Question_token_Execution = false;
return;
}
_AppContext.Delete_Question_token(i_Params_Delete_Question_token.QUESTION_TOKEN_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_token");}
}
public void Delete_Student(Params_Delete_Student i_Params_Delete_Student)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_Execution)
{
_Stop_Delete_Student_Execution = false;
return;
}
_AppContext.Delete_Student(i_Params_Delete_Student.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student");}
}
public void Delete_Student_report(Params_Delete_Student_report i_Params_Delete_Student_report)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_report");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_report_Execution)
{
_Stop_Delete_Student_report_Execution = false;
return;
}
_AppContext.Delete_Student_report(i_Params_Delete_Student_report.STUDENT_REPORT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_report");}
}
public void Delete_Teacher(Params_Delete_Teacher i_Params_Delete_Teacher)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_Execution)
{
_Stop_Delete_Teacher_Execution = false;
return;
}
_AppContext.Delete_Teacher(i_Params_Delete_Teacher.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher");}
}
public void Delete_Teacher_category(Params_Delete_Teacher_category i_Params_Delete_Teacher_category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_category");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_category_Execution)
{
_Stop_Delete_Teacher_category_Execution = false;
return;
}
_AppContext.Delete_Teacher_category(i_Params_Delete_Teacher_category.TEACHER_CATEGORY_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_category");}
}
public void Delete_Teacher_favorite(Params_Delete_Teacher_favorite i_Params_Delete_Teacher_favorite)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_favorite");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_favorite_Execution)
{
_Stop_Delete_Teacher_favorite_Execution = false;
return;
}
_AppContext.Delete_Teacher_favorite(i_Params_Delete_Teacher_favorite.TEACHER_FAVORITE_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_favorite");}
}
public void Delete_Teacher_report(Params_Delete_Teacher_report i_Params_Delete_Teacher_report)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_report");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_report_Execution)
{
_Stop_Delete_Teacher_report_Execution = false;
return;
}
_AppContext.Delete_Teacher_report(i_Params_Delete_Teacher_report.TEACHER_REPORT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_report");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_User_type_code(Params_Delete_User_type_code i_Params_Delete_User_type_code)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_type_code");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_type_code_Execution)
{
_Stop_Delete_User_type_code_Execution = false;
return;
}
_AppContext.Delete_User_type_code(i_Params_Delete_User_type_code.USER_TYPE_CODE_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_type_code");}
}
public void Delete_Address_By_PERSON_ID(Params_Delete_Address_By_PERSON_ID i_Params_Delete_Address_By_PERSON_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID(i_Params_Delete_Address_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID");}
}
public void Delete_Address_By_LOC_L1_ID(Params_Delete_Address_By_LOC_L1_ID i_Params_Delete_Address_By_LOC_L1_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L1_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L1_ID(i_Params_Delete_Address_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L1_ID");}
}
public void Delete_Address_By_LOC_L2_ID(Params_Delete_Address_By_LOC_L2_ID i_Params_Delete_Address_By_LOC_L2_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L2_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L2_ID(i_Params_Delete_Address_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L2_ID");}
}
public void Delete_Address_By_LOC_L3_ID(Params_Delete_Address_By_LOC_L3_ID i_Params_Delete_Address_By_LOC_L3_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L3_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L3_ID(i_Params_Delete_Address_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L3_ID");}
}
public void Delete_Address_By_OWNER_ID(Params_Delete_Address_By_OWNER_ID i_Params_Delete_Address_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_OWNER_ID(i_Params_Delete_Address_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_OWNER_ID");}
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
}
public void Delete_Address_By_LOC_L4_ID(Params_Delete_Address_By_LOC_L4_ID i_Params_Delete_Address_By_LOC_L4_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L4_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L4_ID(i_Params_Delete_Address_By_LOC_L4_ID.LOC_L4_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L4_ID");}
}
public void Delete_Answer_By_OWNER_ID(Params_Delete_Answer_By_OWNER_ID i_Params_Delete_Answer_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Answer_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Answer_Execution)
{
_Stop_Delete_Answer_Execution = false;
return;
}
_AppContext.Delete_Answer_By_OWNER_ID(i_Params_Delete_Answer_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Answer_By_OWNER_ID");}
}
public void Delete_Answer_By_QUESTION_ID(Params_Delete_Answer_By_QUESTION_ID i_Params_Delete_Answer_By_QUESTION_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Answer_By_QUESTION_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Answer_Execution)
{
_Stop_Delete_Answer_Execution = false;
return;
}
_AppContext.Delete_Answer_By_QUESTION_ID(i_Params_Delete_Answer_By_QUESTION_ID.QUESTION_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Answer_By_QUESTION_ID");}
}
public void Delete_Answer_By_TEACHER_ID(Params_Delete_Answer_By_TEACHER_ID i_Params_Delete_Answer_By_TEACHER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Answer_By_TEACHER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Answer_Execution)
{
_Stop_Delete_Answer_Execution = false;
return;
}
_AppContext.Delete_Answer_By_TEACHER_ID(i_Params_Delete_Answer_By_TEACHER_ID.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Answer_By_TEACHER_ID");}
}
public void Delete_Answer_By_STUDENT_ID(Params_Delete_Answer_By_STUDENT_ID i_Params_Delete_Answer_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Answer_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Answer_Execution)
{
_Stop_Delete_Answer_Execution = false;
return;
}
_AppContext.Delete_Answer_By_STUDENT_ID(i_Params_Delete_Answer_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Answer_By_STUDENT_ID");}
}
public void Delete_Category_By_OWNER_ID(Params_Delete_Category_By_OWNER_ID i_Params_Delete_Category_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_Execution)
{
_Stop_Delete_Category_Execution = false;
return;
}
_AppContext.Delete_Category_By_OWNER_ID(i_Params_Delete_Category_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_By_OWNER_ID");}
}
public void Delete_Category_favorite_By_OWNER_ID(Params_Delete_Category_favorite_By_OWNER_ID i_Params_Delete_Category_favorite_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_favorite_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_favorite_Execution)
{
_Stop_Delete_Category_favorite_Execution = false;
return;
}
_AppContext.Delete_Category_favorite_By_OWNER_ID(i_Params_Delete_Category_favorite_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_favorite_By_OWNER_ID");}
}
public void Delete_Category_favorite_By_STUDENT_ID(Params_Delete_Category_favorite_By_STUDENT_ID i_Params_Delete_Category_favorite_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_favorite_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_favorite_Execution)
{
_Stop_Delete_Category_favorite_Execution = false;
return;
}
_AppContext.Delete_Category_favorite_By_STUDENT_ID(i_Params_Delete_Category_favorite_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_favorite_By_STUDENT_ID");}
}
public void Delete_Category_favorite_By_CATEGORY_ID(Params_Delete_Category_favorite_By_CATEGORY_ID i_Params_Delete_Category_favorite_By_CATEGORY_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_favorite_By_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_favorite_Execution)
{
_Stop_Delete_Category_favorite_Execution = false;
return;
}
_AppContext.Delete_Category_favorite_By_CATEGORY_ID(i_Params_Delete_Category_favorite_By_CATEGORY_ID.CATEGORY_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_favorite_By_CATEGORY_ID");}
}
public void Delete_Contact_By_PERSON_ID(Params_Delete_Contact_By_PERSON_ID i_Params_Delete_Contact_By_PERSON_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID(i_Params_Delete_Contact_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID");}
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
}
public void Delete_Contact_By_OWNER_ID(Params_Delete_Contact_By_OWNER_ID i_Params_Delete_Contact_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_OWNER_ID(i_Params_Delete_Contact_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_OWNER_ID");}
}
public void Delete_Evaluation_By_OWNER_ID(Params_Delete_Evaluation_By_OWNER_ID i_Params_Delete_Evaluation_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Evaluation_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Evaluation_Execution)
{
_Stop_Delete_Evaluation_Execution = false;
return;
}
_AppContext.Delete_Evaluation_By_OWNER_ID(i_Params_Delete_Evaluation_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Evaluation_By_OWNER_ID");}
}
public void Delete_Evaluation_By_STUDENT_ID(Params_Delete_Evaluation_By_STUDENT_ID i_Params_Delete_Evaluation_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Evaluation_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Evaluation_Execution)
{
_Stop_Delete_Evaluation_Execution = false;
return;
}
_AppContext.Delete_Evaluation_By_STUDENT_ID(i_Params_Delete_Evaluation_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Evaluation_By_STUDENT_ID");}
}
public void Delete_Evaluation_By_ANSWER_ID(Params_Delete_Evaluation_By_ANSWER_ID i_Params_Delete_Evaluation_By_ANSWER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Evaluation_By_ANSWER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Evaluation_Execution)
{
_Stop_Delete_Evaluation_Execution = false;
return;
}
_AppContext.Delete_Evaluation_By_ANSWER_ID(i_Params_Delete_Evaluation_By_ANSWER_ID.ANSWER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Evaluation_By_ANSWER_ID");}
}
public void Delete_Favorite_teacher_By_OWNER_ID(Params_Delete_Favorite_teacher_By_OWNER_ID i_Params_Delete_Favorite_teacher_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Favorite_teacher_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Favorite_teacher_Execution)
{
_Stop_Delete_Favorite_teacher_Execution = false;
return;
}
_AppContext.Delete_Favorite_teacher_By_OWNER_ID(i_Params_Delete_Favorite_teacher_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Favorite_teacher_By_OWNER_ID");}
}
public void Delete_Favorite_teacher_By_STUDENT_ID(Params_Delete_Favorite_teacher_By_STUDENT_ID i_Params_Delete_Favorite_teacher_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Favorite_teacher_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Favorite_teacher_Execution)
{
_Stop_Delete_Favorite_teacher_Execution = false;
return;
}
_AppContext.Delete_Favorite_teacher_By_STUDENT_ID(i_Params_Delete_Favorite_teacher_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Favorite_teacher_By_STUDENT_ID");}
}
public void Delete_Favorite_teacher_By_TEACHER_ID(Params_Delete_Favorite_teacher_By_TEACHER_ID i_Params_Delete_Favorite_teacher_By_TEACHER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Favorite_teacher_By_TEACHER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Favorite_teacher_Execution)
{
_Stop_Delete_Favorite_teacher_Execution = false;
return;
}
_AppContext.Delete_Favorite_teacher_By_TEACHER_ID(i_Params_Delete_Favorite_teacher_By_TEACHER_ID.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Favorite_teacher_By_TEACHER_ID");}
}
public void Delete_Loc_l1_By_CODE(Params_Delete_Loc_l1_By_CODE i_Params_Delete_Loc_l1_By_CODE)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_CODE(i_Params_Delete_Loc_l1_By_CODE.CODE);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_CODE");}
}
public void Delete_Loc_l1_By_OWNER_ID(Params_Delete_Loc_l1_By_OWNER_ID i_Params_Delete_Loc_l1_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_OWNER_ID(i_Params_Delete_Loc_l1_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_OWNER_ID");}
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE(Params_Delete_Loc_l2_By_LOC_L1_ID_CODE i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.CODE);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
}
public void Delete_Loc_l2_By_LOC_L1_ID(Params_Delete_Loc_l2_By_LOC_L1_ID i_Params_Delete_Loc_l2_By_LOC_L1_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID(i_Params_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
}
public void Delete_Loc_l2_By_OWNER_ID(Params_Delete_Loc_l2_By_OWNER_ID i_Params_Delete_Loc_l2_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_OWNER_ID(i_Params_Delete_Loc_l2_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_OWNER_ID");}
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE(Params_Delete_Loc_l3_By_LOC_L2_ID_CODE i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.CODE);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
}
public void Delete_Loc_l3_By_LOC_L2_ID(Params_Delete_Loc_l3_By_LOC_L2_ID i_Params_Delete_Loc_l3_By_LOC_L2_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID(i_Params_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
}
public void Delete_Loc_l3_By_OWNER_ID(Params_Delete_Loc_l3_By_OWNER_ID i_Params_Delete_Loc_l3_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_OWNER_ID(i_Params_Delete_Loc_l3_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_OWNER_ID");}
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE(Params_Delete_Loc_l4_By_LOC_L3_ID_CODE i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.CODE);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
}
public void Delete_Loc_l4_By_LOC_L3_ID(Params_Delete_Loc_l4_By_LOC_L3_ID i_Params_Delete_Loc_l4_By_LOC_L3_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID(i_Params_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
}
public void Delete_Loc_l4_By_OWNER_ID(Params_Delete_Loc_l4_By_OWNER_ID i_Params_Delete_Loc_l4_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_OWNER_ID(i_Params_Delete_Loc_l4_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_OWNER_ID");}
}
public void Delete_Person_By_OWNER_ID(Params_Delete_Person_By_OWNER_ID i_Params_Delete_Person_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person_By_OWNER_ID(i_Params_Delete_Person_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_By_OWNER_ID");}
}
public void Delete_Question_By_OWNER_ID(Params_Delete_Question_By_OWNER_ID i_Params_Delete_Question_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_Execution)
{
_Stop_Delete_Question_Execution = false;
return;
}
_AppContext.Delete_Question_By_OWNER_ID(i_Params_Delete_Question_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_By_OWNER_ID");}
}
public void Delete_Question_By_STUDENT_ID(Params_Delete_Question_By_STUDENT_ID i_Params_Delete_Question_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_Execution)
{
_Stop_Delete_Question_Execution = false;
return;
}
_AppContext.Delete_Question_By_STUDENT_ID(i_Params_Delete_Question_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_By_STUDENT_ID");}
}
public void Delete_Question_By_CATEGORY_ID(Params_Delete_Question_By_CATEGORY_ID i_Params_Delete_Question_By_CATEGORY_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_By_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_Execution)
{
_Stop_Delete_Question_Execution = false;
return;
}
_AppContext.Delete_Question_By_CATEGORY_ID(i_Params_Delete_Question_By_CATEGORY_ID.CATEGORY_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_By_CATEGORY_ID");}
}
public void Delete_Question_By_TEACHER_ID(Params_Delete_Question_By_TEACHER_ID i_Params_Delete_Question_By_TEACHER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_By_TEACHER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_Execution)
{
_Stop_Delete_Question_Execution = false;
return;
}
_AppContext.Delete_Question_By_TEACHER_ID(i_Params_Delete_Question_By_TEACHER_ID.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_By_TEACHER_ID");}
}
public void Delete_Question_token_By_PART(Params_Delete_Question_token_By_PART i_Params_Delete_Question_token_By_PART)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_token_By_PART");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_token_Execution)
{
_Stop_Delete_Question_token_Execution = false;
return;
}
_AppContext.Delete_Question_token_By_PART(i_Params_Delete_Question_token_By_PART.PART);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_token_By_PART");}
}
public void Delete_Question_token_By_OWNER_ID(Params_Delete_Question_token_By_OWNER_ID i_Params_Delete_Question_token_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_token_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_token_Execution)
{
_Stop_Delete_Question_token_Execution = false;
return;
}
_AppContext.Delete_Question_token_By_OWNER_ID(i_Params_Delete_Question_token_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_token_By_OWNER_ID");}
}
public void Delete_Question_token_By_QUESTION_ID(Params_Delete_Question_token_By_QUESTION_ID i_Params_Delete_Question_token_By_QUESTION_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_token_By_QUESTION_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Question_token_Execution)
{
_Stop_Delete_Question_token_Execution = false;
return;
}
_AppContext.Delete_Question_token_By_QUESTION_ID(i_Params_Delete_Question_token_By_QUESTION_ID.QUESTION_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_token_By_QUESTION_ID");}
}
public void Delete_Student_By_OWNER_ID(Params_Delete_Student_By_OWNER_ID i_Params_Delete_Student_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_Execution)
{
_Stop_Delete_Student_Execution = false;
return;
}
_AppContext.Delete_Student_By_OWNER_ID(i_Params_Delete_Student_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_By_OWNER_ID");}
}
public void Delete_Student_By_USER_TYPE_CODE_ID(Params_Delete_Student_By_USER_TYPE_CODE_ID i_Params_Delete_Student_By_USER_TYPE_CODE_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_By_USER_TYPE_CODE_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_Execution)
{
_Stop_Delete_Student_Execution = false;
return;
}
_AppContext.Delete_Student_By_USER_TYPE_CODE_ID(i_Params_Delete_Student_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_By_USER_TYPE_CODE_ID");}
}
public void Delete_Student_By_USER_ID(Params_Delete_Student_By_USER_ID i_Params_Delete_Student_By_USER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_By_USER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_Execution)
{
_Stop_Delete_Student_Execution = false;
return;
}
_AppContext.Delete_Student_By_USER_ID(i_Params_Delete_Student_By_USER_ID.USER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_By_USER_ID");}
}
public void Delete_Student_report_By_OWNER_ID(Params_Delete_Student_report_By_OWNER_ID i_Params_Delete_Student_report_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_report_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_report_Execution)
{
_Stop_Delete_Student_report_Execution = false;
return;
}
_AppContext.Delete_Student_report_By_OWNER_ID(i_Params_Delete_Student_report_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_report_By_OWNER_ID");}
}
public void Delete_Student_report_By_REPORTED_BY_STUDENT_ID(Params_Delete_Student_report_By_REPORTED_BY_STUDENT_ID i_Params_Delete_Student_report_By_REPORTED_BY_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_report_By_REPORTED_BY_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_report_Execution)
{
_Stop_Delete_Student_report_Execution = false;
return;
}
_AppContext.Delete_Student_report_By_REPORTED_BY_STUDENT_ID(i_Params_Delete_Student_report_By_REPORTED_BY_STUDENT_ID.REPORTED_BY_STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_report_By_REPORTED_BY_STUDENT_ID");}
}
public void Delete_Student_report_By_REPORTED_STUDENT_ID(Params_Delete_Student_report_By_REPORTED_STUDENT_ID i_Params_Delete_Student_report_By_REPORTED_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_report_By_REPORTED_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Student_report_Execution)
{
_Stop_Delete_Student_report_Execution = false;
return;
}
_AppContext.Delete_Student_report_By_REPORTED_STUDENT_ID(i_Params_Delete_Student_report_By_REPORTED_STUDENT_ID.REPORTED_STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_report_By_REPORTED_STUDENT_ID");}
}
public void Delete_Teacher_By_OWNER_ID(Params_Delete_Teacher_By_OWNER_ID i_Params_Delete_Teacher_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_Execution)
{
_Stop_Delete_Teacher_Execution = false;
return;
}
_AppContext.Delete_Teacher_By_OWNER_ID(i_Params_Delete_Teacher_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_By_OWNER_ID");}
}
public void Delete_Teacher_By_CATEGORY_ID(Params_Delete_Teacher_By_CATEGORY_ID i_Params_Delete_Teacher_By_CATEGORY_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_By_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_Execution)
{
_Stop_Delete_Teacher_Execution = false;
return;
}
_AppContext.Delete_Teacher_By_CATEGORY_ID(i_Params_Delete_Teacher_By_CATEGORY_ID.CATEGORY_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_By_CATEGORY_ID");}
}
public void Delete_Teacher_By_USER_TYPE_CODE_ID(Params_Delete_Teacher_By_USER_TYPE_CODE_ID i_Params_Delete_Teacher_By_USER_TYPE_CODE_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_By_USER_TYPE_CODE_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_Execution)
{
_Stop_Delete_Teacher_Execution = false;
return;
}
_AppContext.Delete_Teacher_By_USER_TYPE_CODE_ID(i_Params_Delete_Teacher_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_By_USER_TYPE_CODE_ID");}
}
public void Delete_Teacher_By_USER_ID(Params_Delete_Teacher_By_USER_ID i_Params_Delete_Teacher_By_USER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_By_USER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_Execution)
{
_Stop_Delete_Teacher_Execution = false;
return;
}
_AppContext.Delete_Teacher_By_USER_ID(i_Params_Delete_Teacher_By_USER_ID.USER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_By_USER_ID");}
}
public void Delete_Teacher_category_By_OWNER_ID(Params_Delete_Teacher_category_By_OWNER_ID i_Params_Delete_Teacher_category_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_category_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_category_Execution)
{
_Stop_Delete_Teacher_category_Execution = false;
return;
}
_AppContext.Delete_Teacher_category_By_OWNER_ID(i_Params_Delete_Teacher_category_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_category_By_OWNER_ID");}
}
public void Delete_Teacher_category_By_TEACHER_ID(Params_Delete_Teacher_category_By_TEACHER_ID i_Params_Delete_Teacher_category_By_TEACHER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_category_By_TEACHER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_category_Execution)
{
_Stop_Delete_Teacher_category_Execution = false;
return;
}
_AppContext.Delete_Teacher_category_By_TEACHER_ID(i_Params_Delete_Teacher_category_By_TEACHER_ID.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_category_By_TEACHER_ID");}
}
public void Delete_Teacher_category_By_CATEGORY_ID(Params_Delete_Teacher_category_By_CATEGORY_ID i_Params_Delete_Teacher_category_By_CATEGORY_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_category_By_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_category_Execution)
{
_Stop_Delete_Teacher_category_Execution = false;
return;
}
_AppContext.Delete_Teacher_category_By_CATEGORY_ID(i_Params_Delete_Teacher_category_By_CATEGORY_ID.CATEGORY_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_category_By_CATEGORY_ID");}
}
public void Delete_Teacher_favorite_By_OWNER_ID(Params_Delete_Teacher_favorite_By_OWNER_ID i_Params_Delete_Teacher_favorite_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_favorite_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_favorite_Execution)
{
_Stop_Delete_Teacher_favorite_Execution = false;
return;
}
_AppContext.Delete_Teacher_favorite_By_OWNER_ID(i_Params_Delete_Teacher_favorite_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_favorite_By_OWNER_ID");}
}
public void Delete_Teacher_favorite_By_STUDENT_ID(Params_Delete_Teacher_favorite_By_STUDENT_ID i_Params_Delete_Teacher_favorite_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_favorite_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_favorite_Execution)
{
_Stop_Delete_Teacher_favorite_Execution = false;
return;
}
_AppContext.Delete_Teacher_favorite_By_STUDENT_ID(i_Params_Delete_Teacher_favorite_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_favorite_By_STUDENT_ID");}
}
public void Delete_Teacher_favorite_By_TEACHER_ID(Params_Delete_Teacher_favorite_By_TEACHER_ID i_Params_Delete_Teacher_favorite_By_TEACHER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_favorite_By_TEACHER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_favorite_Execution)
{
_Stop_Delete_Teacher_favorite_Execution = false;
return;
}
_AppContext.Delete_Teacher_favorite_By_TEACHER_ID(i_Params_Delete_Teacher_favorite_By_TEACHER_ID.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_favorite_By_TEACHER_ID");}
}
public void Delete_Teacher_report_By_OWNER_ID(Params_Delete_Teacher_report_By_OWNER_ID i_Params_Delete_Teacher_report_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_report_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_report_Execution)
{
_Stop_Delete_Teacher_report_Execution = false;
return;
}
_AppContext.Delete_Teacher_report_By_OWNER_ID(i_Params_Delete_Teacher_report_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_report_By_OWNER_ID");}
}
public void Delete_Teacher_report_By_TEACHER_ID(Params_Delete_Teacher_report_By_TEACHER_ID i_Params_Delete_Teacher_report_By_TEACHER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_report_By_TEACHER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_report_Execution)
{
_Stop_Delete_Teacher_report_Execution = false;
return;
}
_AppContext.Delete_Teacher_report_By_TEACHER_ID(i_Params_Delete_Teacher_report_By_TEACHER_ID.TEACHER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_report_By_TEACHER_ID");}
}
public void Delete_Teacher_report_By_STUDENT_ID(Params_Delete_Teacher_report_By_STUDENT_ID i_Params_Delete_Teacher_report_By_STUDENT_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_report_By_STUDENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Teacher_report_Execution)
{
_Stop_Delete_Teacher_report_Execution = false;
return;
}
_AppContext.Delete_Teacher_report_By_STUDENT_ID(i_Params_Delete_Teacher_report_By_STUDENT_ID.STUDENT_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_report_By_STUDENT_ID");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Delete_User_By_USER_TYPE_CODE_ID(Params_Delete_User_By_USER_TYPE_CODE_ID i_Params_Delete_User_By_USER_TYPE_CODE_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USER_TYPE_CODE_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USER_TYPE_CODE_ID(i_Params_Delete_User_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USER_TYPE_CODE_ID");}
}
public void Delete_User_By_EMAIL(Params_Delete_User_By_EMAIL i_Params_Delete_User_By_EMAIL)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_EMAIL");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_EMAIL(i_Params_Delete_User_By_EMAIL.EMAIL);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_EMAIL");}
}
public void Delete_User_type_code_By_OWNER_ID(Params_Delete_User_type_code_By_OWNER_ID i_Params_Delete_User_type_code_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_type_code_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_type_code_Execution)
{
_Stop_Delete_User_type_code_Execution = false;
return;
}
_AppContext.Delete_User_type_code_By_OWNER_ID(i_Params_Delete_User_type_code_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
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
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_type_code_By_OWNER_ID");}
}
public void Edit_Address(Address i_Address) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Address.ADDRESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address");}
#region Body Section.
if ((i_Address.ADDRESS_ID == null) || (i_Address.ADDRESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Address"); }
i_Address.ENTRY_USER_ID = this.UserID;
i_Address.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Address.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Address_Execution)
{
_Stop_Edit_Address_Execution = false;
return;
}
i_Address.ADDRESS_ID = _AppContext.Edit_Address
(
i_Address.ADDRESS_ID
,i_Address.PERSON_ID
,i_Address.ADDRESS_TYPE_CODE
,i_Address.LOC_L1_ID
,i_Address.LOC_L2_ID
,i_Address.LOC_L3_ID
,i_Address.LOC_L4_ID
,i_Address.STREET
,i_Address.BUILDING
,i_Address.FLOOR
,i_Address.POBOX
,i_Address.VALID_DATE_START
,i_Address.VALID_DATE_END
,i_Address.NOTES
,i_Address.ENTRY_DATE
,i_Address.ENTRY_USER_ID
,i_Address.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address");}
}
public void Edit_Answer(Answer i_Answer) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Answer.ANSWER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Answer");}
#region Body Section.
if ((i_Answer.ANSWER_ID == null) || (i_Answer.ANSWER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Answer"); }
i_Answer.ENTRY_USER_ID = this.UserID;
i_Answer.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Answer.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Answer_Execution)
{
_Stop_Edit_Answer_Execution = false;
return;
}
i_Answer.ANSWER_ID = _AppContext.Edit_Answer
(
i_Answer.ANSWER_ID
,i_Answer.QUESTION_ID
,i_Answer.TEACHER_ID
,i_Answer.STUDENT_ID
,i_Answer.DESCRIPTION
,i_Answer.ENTRY_USER_ID
,i_Answer.ENTRY_DATE
,i_Answer.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Answer");}
}
public void Edit_Category(Category i_Category) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Category.CATEGORY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category");}
#region Body Section.
if ((i_Category.CATEGORY_ID == null) || (i_Category.CATEGORY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Category"); }
i_Category.ENTRY_USER_ID = this.UserID;
i_Category.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Category.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Category_Execution)
{
_Stop_Edit_Category_Execution = false;
return;
}
i_Category.CATEGORY_ID = _AppContext.Edit_Category
(
i_Category.CATEGORY_ID
,i_Category.NAME
,i_Category.DESCRIPTION
,i_Category.ENTRY_USER_ID
,i_Category.ENTRY_DATE
,i_Category.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category");}
}
public void Edit_Category_favorite(Category_favorite i_Category_favorite) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Category_favorite.CATEGORY_FAVORITE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_favorite");}
#region Body Section.
if ((i_Category_favorite.CATEGORY_FAVORITE_ID == null) || (i_Category_favorite.CATEGORY_FAVORITE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Category_favorite"); }
i_Category_favorite.ENTRY_USER_ID = this.UserID;
i_Category_favorite.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Category_favorite.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Category_favorite_Execution)
{
_Stop_Edit_Category_favorite_Execution = false;
return;
}
i_Category_favorite.CATEGORY_FAVORITE_ID = _AppContext.Edit_Category_favorite
(
i_Category_favorite.CATEGORY_FAVORITE_ID
,i_Category_favorite.STUDENT_ID
,i_Category_favorite.CATEGORY_ID
,i_Category_favorite.DESCRIPTION
,i_Category_favorite.ENTRY_USER_ID
,i_Category_favorite.ENTRY_DATE
,i_Category_favorite.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_favorite");}
}
public void Edit_Contact(Contact i_Contact) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Contact.CONTACT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact");}
#region Body Section.
if ((i_Contact.CONTACT_ID == null) || (i_Contact.CONTACT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Contact"); }
i_Contact.ENTRY_USER_ID = this.UserID;
i_Contact.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Contact.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Contact_Execution)
{
_Stop_Edit_Contact_Execution = false;
return;
}
i_Contact.CONTACT_ID = _AppContext.Edit_Contact
(
i_Contact.CONTACT_ID
,i_Contact.PERSON_ID
,i_Contact.CONTACT_TYPE_CODE
,i_Contact.CONTACT
,i_Contact.DESCRIPTION
,i_Contact.ENTRY_USER_ID
,i_Contact.ENTRY_DATE
,i_Contact.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact");}
}
public void Edit_Evaluation(Evaluation i_Evaluation) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Evaluation.EVALUATION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Evaluation");}
#region Body Section.
if ((i_Evaluation.EVALUATION_ID == null) || (i_Evaluation.EVALUATION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Evaluation"); }
i_Evaluation.ENTRY_USER_ID = this.UserID;
i_Evaluation.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Evaluation.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Evaluation_Execution)
{
_Stop_Edit_Evaluation_Execution = false;
return;
}
i_Evaluation.EVALUATION_ID = _AppContext.Edit_Evaluation
(
i_Evaluation.EVALUATION_ID
,i_Evaluation.STUDENT_ID
,i_Evaluation.ANSWER_ID
,i_Evaluation.SCORE
,i_Evaluation.ENTRY_USER_ID
,i_Evaluation.ENTRY_DATE
,i_Evaluation.OWNER_ID
,i_Evaluation.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Evaluation");}
}
public void Edit_Favorite_teacher(Favorite_teacher i_Favorite_teacher) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Favorite_teacher.FAVORITE_TEACHER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Favorite_teacher");}
#region Body Section.
if ((i_Favorite_teacher.FAVORITE_TEACHER_ID == null) || (i_Favorite_teacher.FAVORITE_TEACHER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Favorite_teacher"); }
i_Favorite_teacher.ENTRY_USER_ID = this.UserID;
i_Favorite_teacher.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Favorite_teacher.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Favorite_teacher_Execution)
{
_Stop_Edit_Favorite_teacher_Execution = false;
return;
}
i_Favorite_teacher.FAVORITE_TEACHER_ID = _AppContext.Edit_Favorite_teacher
(
i_Favorite_teacher.FAVORITE_TEACHER_ID
,i_Favorite_teacher.STUDENT_ID
,i_Favorite_teacher.TEACHER_ID
,i_Favorite_teacher.DESCRIPTION
,i_Favorite_teacher.ENTRY_USER_ID
,i_Favorite_teacher.ENTRY_DATE
,i_Favorite_teacher.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Favorite_teacher");}
}
public void Edit_Loc_l1(Loc_l1 i_Loc_l1) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l1.LOC_L1_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1");}
#region Body Section.
if ((i_Loc_l1.LOC_L1_ID == null) || (i_Loc_l1.LOC_L1_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l1"); }
i_Loc_l1.ENTRY_USER_ID = this.UserID;
i_Loc_l1.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l1.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l1_Execution)
{
_Stop_Edit_Loc_l1_Execution = false;
return;
}
i_Loc_l1.LOC_L1_ID = _AppContext.Edit_Loc_l1
(
i_Loc_l1.LOC_L1_ID
,i_Loc_l1.CODE
,i_Loc_l1.DESCRIPTION
,i_Loc_l1.NOTES
,i_Loc_l1.ENTRY_DATE
,i_Loc_l1.ENTRY_USER_ID
,i_Loc_l1.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1");}
}
public void Edit_Loc_l2(Loc_l2 i_Loc_l2) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l2.LOC_L2_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2");}
#region Body Section.
if ((i_Loc_l2.LOC_L2_ID == null) || (i_Loc_l2.LOC_L2_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l2"); }
i_Loc_l2.ENTRY_USER_ID = this.UserID;
i_Loc_l2.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l2.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l2_Execution)
{
_Stop_Edit_Loc_l2_Execution = false;
return;
}
i_Loc_l2.LOC_L2_ID = _AppContext.Edit_Loc_l2
(
i_Loc_l2.LOC_L2_ID
,i_Loc_l2.CODE
,i_Loc_l2.DESCRIPTION
,i_Loc_l2.LOC_L1_ID
,i_Loc_l2.NOTES
,i_Loc_l2.ENTRY_DATE
,i_Loc_l2.ENTRY_USER_ID
,i_Loc_l2.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2");}
}
public void Edit_Loc_l3(Loc_l3 i_Loc_l3) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l3.LOC_L3_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3");}
#region Body Section.
if ((i_Loc_l3.LOC_L3_ID == null) || (i_Loc_l3.LOC_L3_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l3"); }
i_Loc_l3.ENTRY_USER_ID = this.UserID;
i_Loc_l3.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l3.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l3_Execution)
{
_Stop_Edit_Loc_l3_Execution = false;
return;
}
i_Loc_l3.LOC_L3_ID = _AppContext.Edit_Loc_l3
(
i_Loc_l3.LOC_L3_ID
,i_Loc_l3.CODE
,i_Loc_l3.DESCRIPTION
,i_Loc_l3.LOC_L2_ID
,i_Loc_l3.NOTES
,i_Loc_l3.ENTRY_DATE
,i_Loc_l3.ENTRY_USER_ID
,i_Loc_l3.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3");}
}
public void Edit_Loc_l4(Loc_l4 i_Loc_l4) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l4.LOC_L4_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4");}
#region Body Section.
if ((i_Loc_l4.LOC_L4_ID == null) || (i_Loc_l4.LOC_L4_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l4"); }
i_Loc_l4.ENTRY_USER_ID = this.UserID;
i_Loc_l4.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l4.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l4_Execution)
{
_Stop_Edit_Loc_l4_Execution = false;
return;
}
i_Loc_l4.LOC_L4_ID = _AppContext.Edit_Loc_l4
(
i_Loc_l4.LOC_L4_ID
,i_Loc_l4.CODE
,i_Loc_l4.DESCRIPTION
,i_Loc_l4.LOC_L3_ID
,i_Loc_l4.NOTES
,i_Loc_l4.ENTRY_DATE
,i_Loc_l4.ENTRY_USER_ID
,i_Loc_l4.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Person(Person i_Person) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Person.PERSON_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person");}
#region Body Section.
if ((i_Person.PERSON_ID == null) || (i_Person.PERSON_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Person"); }
i_Person.ENTRY_USER_ID = this.UserID;
i_Person.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Person.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Person_Execution)
{
_Stop_Edit_Person_Execution = false;
return;
}
i_Person.PERSON_ID = _AppContext.Edit_Person
(
i_Person.PERSON_ID
,i_Person.FIRST_NAME
,i_Person.LAST_NAME
,i_Person.FATHER_NAME
,i_Person.MOTHER_NAME
,i_Person.TITLE_CODE
,i_Person.GENDER_CODE
,i_Person.RELIGION_CODE
,i_Person.BIRTH_DATE
,i_Person.IS_BLOCKED
,i_Person.DESCRIPTION
,i_Person.OWNER_ID
,i_Person.ENTRY_USER_ID
,i_Person.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person");}
}
public void Edit_Question(Question i_Question) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Question.QUESTION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question");}
#region Body Section.
if ((i_Question.QUESTION_ID == null) || (i_Question.QUESTION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Question"); }
i_Question.ENTRY_USER_ID = this.UserID;
i_Question.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Question.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Question_Execution)
{
_Stop_Edit_Question_Execution = false;
return;
}
i_Question.QUESTION_ID = _AppContext.Edit_Question
(
i_Question.QUESTION_ID
,i_Question.STUDENT_ID
,i_Question.CATEGORY_ID
,i_Question.TEACHER_ID
,i_Question.DESCRIPTION
,i_Question.IS_ANSWERED
,i_Question.IS_PUBLIC
,i_Question.IS_SELF_CLOSED
,i_Question.ENTRY_USER_ID
,i_Question.ENTRY_DATE
,i_Question.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question");}
}
public void Edit_Question_token(Question_token i_Question_token) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Question_token.QUESTION_TOKEN_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_token");}
#region Body Section.
if ((i_Question_token.QUESTION_TOKEN_ID == null) || (i_Question_token.QUESTION_TOKEN_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Question_token"); }
i_Question_token.ENTRY_USER_ID = this.UserID;
i_Question_token.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Question_token.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Question_token_Execution)
{
_Stop_Edit_Question_token_Execution = false;
return;
}
i_Question_token.QUESTION_TOKEN_ID = _AppContext.Edit_Question_token
(
i_Question_token.QUESTION_TOKEN_ID
,i_Question_token.QUESTION_ID
,i_Question_token.PART
,i_Question_token.ENTRY_USER_ID
,i_Question_token.ENTRY_DATE
,i_Question_token.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_token");}
}
public void Edit_Student(Student i_Student) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Student.STUDENT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student");}
#region Body Section.
if ((i_Student.STUDENT_ID == null) || (i_Student.STUDENT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Student"); }
i_Student.ENTRY_USER_ID = this.UserID;
i_Student.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Student.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Student_Execution)
{
_Stop_Edit_Student_Execution = false;
return;
}
i_Student.STUDENT_ID = _AppContext.Edit_Student
(
i_Student.STUDENT_ID
,i_Student.USER_ID
,i_Student.USER_TYPE_CODE_ID
,i_Student.IS_BLOCKED
,i_Student.ENTRY_USER_ID
,i_Student.ENTRY_DATE
,i_Student.OWNER_ID
,i_Student.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student");}
}
public void Edit_Student_report(Student_report i_Student_report) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Student_report.STUDENT_REPORT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_report");}
#region Body Section.
if ((i_Student_report.STUDENT_REPORT_ID == null) || (i_Student_report.STUDENT_REPORT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Student_report"); }
i_Student_report.ENTRY_USER_ID = this.UserID;
i_Student_report.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Student_report.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Student_report_Execution)
{
_Stop_Edit_Student_report_Execution = false;
return;
}
i_Student_report.STUDENT_REPORT_ID = _AppContext.Edit_Student_report
(
i_Student_report.STUDENT_REPORT_ID
,i_Student_report.REPORTED_BY_STUDENT_ID
,i_Student_report.REPORTED_STUDENT_ID
,i_Student_report.DESCRIPTION
,i_Student_report.ENTRY_USER_ID
,i_Student_report.ENTRY_DATE
,i_Student_report.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_report");}
}
public void Edit_Teacher(Teacher i_Teacher) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Teacher.TEACHER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher");}
#region Body Section.
if ((i_Teacher.TEACHER_ID == null) || (i_Teacher.TEACHER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Teacher"); }
i_Teacher.ENTRY_USER_ID = this.UserID;
i_Teacher.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Teacher.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Teacher_Execution)
{
_Stop_Edit_Teacher_Execution = false;
return;
}
i_Teacher.TEACHER_ID = _AppContext.Edit_Teacher
(
i_Teacher.TEACHER_ID
,i_Teacher.USER_ID
,i_Teacher.IS_VALID
,i_Teacher.USER_TYPE_CODE_ID
,i_Teacher.SCORE
,i_Teacher.IS_BLOCKED
,i_Teacher.CATEGORY_ID
,i_Teacher.ENTRY_USER_ID
,i_Teacher.ENTRY_DATE
,i_Teacher.OWNER_ID
,i_Teacher.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher");}
}
public void Edit_Teacher_category(Teacher_category i_Teacher_category) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Teacher_category.TEACHER_CATEGORY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_category");}
#region Body Section.
if ((i_Teacher_category.TEACHER_CATEGORY_ID == null) || (i_Teacher_category.TEACHER_CATEGORY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Teacher_category"); }
i_Teacher_category.ENTRY_USER_ID = this.UserID;
i_Teacher_category.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Teacher_category.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Teacher_category_Execution)
{
_Stop_Edit_Teacher_category_Execution = false;
return;
}
i_Teacher_category.TEACHER_CATEGORY_ID = _AppContext.Edit_Teacher_category
(
i_Teacher_category.TEACHER_CATEGORY_ID
,i_Teacher_category.TEACHER_ID
,i_Teacher_category.CATEGORY_ID
,i_Teacher_category.DESCRIPTION
,i_Teacher_category.ENTRY_USER_ID
,i_Teacher_category.ENTRY_DATE
,i_Teacher_category.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_category");}
}
public void Edit_Teacher_favorite(Teacher_favorite i_Teacher_favorite) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Teacher_favorite.TEACHER_FAVORITE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_favorite");}
#region Body Section.
if ((i_Teacher_favorite.TEACHER_FAVORITE_ID == null) || (i_Teacher_favorite.TEACHER_FAVORITE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Teacher_favorite"); }
i_Teacher_favorite.ENTRY_USER_ID = this.UserID;
i_Teacher_favorite.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Teacher_favorite.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Teacher_favorite_Execution)
{
_Stop_Edit_Teacher_favorite_Execution = false;
return;
}
i_Teacher_favorite.TEACHER_FAVORITE_ID = _AppContext.Edit_Teacher_favorite
(
i_Teacher_favorite.TEACHER_FAVORITE_ID
,i_Teacher_favorite.STUDENT_ID
,i_Teacher_favorite.TEACHER_ID
,i_Teacher_favorite.DESCRIPTION
,i_Teacher_favorite.ENTRY_USER_ID
,i_Teacher_favorite.ENTRY_DATE
,i_Teacher_favorite.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_favorite");}
}
public void Edit_Teacher_report(Teacher_report i_Teacher_report) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Teacher_report.TEACHER_REPORT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_report");}
#region Body Section.
if ((i_Teacher_report.TEACHER_REPORT_ID == null) || (i_Teacher_report.TEACHER_REPORT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Teacher_report"); }
i_Teacher_report.ENTRY_USER_ID = this.UserID;
i_Teacher_report.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Teacher_report.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Teacher_report_Execution)
{
_Stop_Edit_Teacher_report_Execution = false;
return;
}
i_Teacher_report.TEACHER_REPORT_ID = _AppContext.Edit_Teacher_report
(
i_Teacher_report.TEACHER_REPORT_ID
,i_Teacher_report.TEACHER_ID
,i_Teacher_report.STUDENT_ID
,i_Teacher_report.DESCRIPTION
,i_Teacher_report.ENTRY_USER_ID
,i_Teacher_report.ENTRY_DATE
,i_Teacher_report.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_report");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.EMAIL
,i_User.FIRST_NAME
,i_User.LAST_NAME
,i_User.MOBILE
,i_User.DOB
,i_User.USER_TYPE_CODE_ID
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_User_type_code(User_type_code i_User_type_code) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User_type_code.USER_TYPE_CODE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code");}
#region Body Section.
if ((i_User_type_code.USER_TYPE_CODE_ID == null) || (i_User_type_code.USER_TYPE_CODE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User_type_code"); }
i_User_type_code.ENTRY_USER_ID = this.UserID;
i_User_type_code.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User_type_code.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_type_code_Execution)
{
_Stop_Edit_User_type_code_Execution = false;
return;
}
i_User_type_code.USER_TYPE_CODE_ID = _AppContext.Edit_User_type_code
(
i_User_type_code.USER_TYPE_CODE_ID
,i_User_type_code.USER_TYPE_CODE
,i_User_type_code.DESCRIPTION
,i_User_type_code.ENTRY_USER_ID
,i_User_type_code.ENTRY_DATE
,i_User_type_code.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code");}
}
public void Edit_Address_List(List<Address> i_List_Address)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Address != null)
{
foreach (var oRow in i_List_Address)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Address_List(Params_Edit_Address_List i_Params_Edit_Address_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Address_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Delete)
{
Delete_Address(new Params_Delete_Address() { ADDRESS_ID = oRow.ADDRESS_ID });
}
}
if (i_Params_Edit_Address_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Edit)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Answer_List(List<Answer> i_List_Answer)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Answer_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Answer != null)
{
foreach (var oRow in i_List_Answer)
{
Edit_Answer(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Answer_List");}
}
public void Edit_Answer_List(Params_Edit_Answer_List i_Params_Edit_Answer_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Answer_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Answer_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Answer_List.My_List_To_Delete)
{
Delete_Answer(new Params_Delete_Answer() { ANSWER_ID = oRow.ANSWER_ID });
}
}
if (i_Params_Edit_Answer_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Answer_List.My_List_To_Edit)
{
Edit_Answer(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Answer_List");}
}
public void Edit_Category_List(List<Category> i_List_Category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Category != null)
{
foreach (var oRow in i_List_Category)
{
Edit_Category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_List");}
}
public void Edit_Category_List(Params_Edit_Category_List i_Params_Edit_Category_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Category_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Category_List.My_List_To_Delete)
{
Delete_Category(new Params_Delete_Category() { CATEGORY_ID = oRow.CATEGORY_ID });
}
}
if (i_Params_Edit_Category_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Category_List.My_List_To_Edit)
{
Edit_Category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_List");}
}
public void Edit_Category_favorite_List(List<Category_favorite> i_List_Category_favorite)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_favorite_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Category_favorite != null)
{
foreach (var oRow in i_List_Category_favorite)
{
Edit_Category_favorite(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_favorite_List");}
}
public void Edit_Category_favorite_List(Params_Edit_Category_favorite_List i_Params_Edit_Category_favorite_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_favorite_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Category_favorite_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Category_favorite_List.My_List_To_Delete)
{
Delete_Category_favorite(new Params_Delete_Category_favorite() { CATEGORY_FAVORITE_ID = oRow.CATEGORY_FAVORITE_ID });
}
}
if (i_Params_Edit_Category_favorite_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Category_favorite_List.My_List_To_Edit)
{
Edit_Category_favorite(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_favorite_List");}
}
public void Edit_Contact_List(List<Contact> i_List_Contact)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Contact != null)
{
foreach (var oRow in i_List_Contact)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Contact_List(Params_Edit_Contact_List i_Params_Edit_Contact_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Contact_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Delete)
{
Delete_Contact(new Params_Delete_Contact() { CONTACT_ID = oRow.CONTACT_ID });
}
}
if (i_Params_Edit_Contact_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Edit)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Evaluation_List(List<Evaluation> i_List_Evaluation)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Evaluation_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Evaluation != null)
{
foreach (var oRow in i_List_Evaluation)
{
Edit_Evaluation(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Evaluation_List");}
}
public void Edit_Evaluation_List(Params_Edit_Evaluation_List i_Params_Edit_Evaluation_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Evaluation_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Evaluation_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Evaluation_List.My_List_To_Delete)
{
Delete_Evaluation(new Params_Delete_Evaluation() { EVALUATION_ID = oRow.EVALUATION_ID });
}
}
if (i_Params_Edit_Evaluation_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Evaluation_List.My_List_To_Edit)
{
Edit_Evaluation(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Evaluation_List");}
}
public void Edit_Favorite_teacher_List(List<Favorite_teacher> i_List_Favorite_teacher)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Favorite_teacher_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Favorite_teacher != null)
{
foreach (var oRow in i_List_Favorite_teacher)
{
Edit_Favorite_teacher(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Favorite_teacher_List");}
}
public void Edit_Favorite_teacher_List(Params_Edit_Favorite_teacher_List i_Params_Edit_Favorite_teacher_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Favorite_teacher_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Favorite_teacher_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Favorite_teacher_List.My_List_To_Delete)
{
Delete_Favorite_teacher(new Params_Delete_Favorite_teacher() { FAVORITE_TEACHER_ID = oRow.FAVORITE_TEACHER_ID });
}
}
if (i_Params_Edit_Favorite_teacher_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Favorite_teacher_List.My_List_To_Edit)
{
Edit_Favorite_teacher(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Favorite_teacher_List");}
}
public void Edit_Loc_l1_List(List<Loc_l1> i_List_Loc_l1)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l1 != null)
{
foreach (var oRow in i_List_Loc_l1)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l1_List(Params_Edit_Loc_l1_List i_Params_Edit_Loc_l1_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l1_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Delete)
{
Delete_Loc_l1(new Params_Delete_Loc_l1() { LOC_L1_ID = oRow.LOC_L1_ID });
}
}
if (i_Params_Edit_Loc_l1_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Edit)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l2_List(List<Loc_l2> i_List_Loc_l2)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l2 != null)
{
foreach (var oRow in i_List_Loc_l2)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l2_List(Params_Edit_Loc_l2_List i_Params_Edit_Loc_l2_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l2_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Delete)
{
Delete_Loc_l2(new Params_Delete_Loc_l2() { LOC_L2_ID = oRow.LOC_L2_ID });
}
}
if (i_Params_Edit_Loc_l2_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Edit)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l3_List(List<Loc_l3> i_List_Loc_l3)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l3 != null)
{
foreach (var oRow in i_List_Loc_l3)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l3_List(Params_Edit_Loc_l3_List i_Params_Edit_Loc_l3_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l3_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Delete)
{
Delete_Loc_l3(new Params_Delete_Loc_l3() { LOC_L3_ID = oRow.LOC_L3_ID });
}
}
if (i_Params_Edit_Loc_l3_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Edit)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l4_List(List<Loc_l4> i_List_Loc_l4)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l4 != null)
{
foreach (var oRow in i_List_Loc_l4)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Loc_l4_List(Params_Edit_Loc_l4_List i_Params_Edit_Loc_l4_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l4_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Delete)
{
Delete_Loc_l4(new Params_Delete_Loc_l4() { LOC_L4_ID = oRow.LOC_L4_ID });
}
}
if (i_Params_Edit_Loc_l4_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Edit)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Person_List(List<Person> i_List_Person)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Person != null)
{
foreach (var oRow in i_List_Person)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Person_List(Params_Edit_Person_List i_Params_Edit_Person_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Person_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Delete)
{
Delete_Person(new Params_Delete_Person() { PERSON_ID = oRow.PERSON_ID });
}
}
if (i_Params_Edit_Person_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Edit)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Question_List(List<Question> i_List_Question)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Question != null)
{
foreach (var oRow in i_List_Question)
{
Edit_Question(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_List");}
}
public void Edit_Question_List(Params_Edit_Question_List i_Params_Edit_Question_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Question_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Question_List.My_List_To_Delete)
{
Delete_Question(new Params_Delete_Question() { QUESTION_ID = oRow.QUESTION_ID });
}
}
if (i_Params_Edit_Question_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Question_List.My_List_To_Edit)
{
Edit_Question(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_List");}
}
public void Edit_Question_token_List(List<Question_token> i_List_Question_token)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_token_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Question_token != null)
{
foreach (var oRow in i_List_Question_token)
{
Edit_Question_token(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_token_List");}
}
public void Edit_Question_token_List(Params_Edit_Question_token_List i_Params_Edit_Question_token_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_token_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Question_token_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Question_token_List.My_List_To_Delete)
{
Delete_Question_token(new Params_Delete_Question_token() { QUESTION_TOKEN_ID = oRow.QUESTION_TOKEN_ID });
}
}
if (i_Params_Edit_Question_token_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Question_token_List.My_List_To_Edit)
{
Edit_Question_token(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_token_List");}
}
public void Edit_Student_List(List<Student> i_List_Student)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Student != null)
{
foreach (var oRow in i_List_Student)
{
Edit_Student(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_List");}
}
public void Edit_Student_List(Params_Edit_Student_List i_Params_Edit_Student_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Student_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Student_List.My_List_To_Delete)
{
Delete_Student(new Params_Delete_Student() { STUDENT_ID = oRow.STUDENT_ID });
}
}
if (i_Params_Edit_Student_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Student_List.My_List_To_Edit)
{
Edit_Student(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_List");}
}
public void Edit_Student_report_List(List<Student_report> i_List_Student_report)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_report_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Student_report != null)
{
foreach (var oRow in i_List_Student_report)
{
Edit_Student_report(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_report_List");}
}
public void Edit_Student_report_List(Params_Edit_Student_report_List i_Params_Edit_Student_report_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_report_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Student_report_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Student_report_List.My_List_To_Delete)
{
Delete_Student_report(new Params_Delete_Student_report() { STUDENT_REPORT_ID = oRow.STUDENT_REPORT_ID });
}
}
if (i_Params_Edit_Student_report_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Student_report_List.My_List_To_Edit)
{
Edit_Student_report(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_report_List");}
}
public void Edit_Teacher_List(List<Teacher> i_List_Teacher)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Teacher != null)
{
foreach (var oRow in i_List_Teacher)
{
Edit_Teacher(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_List");}
}
public void Edit_Teacher_List(Params_Edit_Teacher_List i_Params_Edit_Teacher_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Teacher_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Teacher_List.My_List_To_Delete)
{
Delete_Teacher(new Params_Delete_Teacher() { TEACHER_ID = oRow.TEACHER_ID });
}
}
if (i_Params_Edit_Teacher_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Teacher_List.My_List_To_Edit)
{
Edit_Teacher(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_List");}
}
public void Edit_Teacher_category_List(List<Teacher_category> i_List_Teacher_category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Teacher_category != null)
{
foreach (var oRow in i_List_Teacher_category)
{
Edit_Teacher_category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_category_List");}
}
public void Edit_Teacher_category_List(Params_Edit_Teacher_category_List i_Params_Edit_Teacher_category_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Teacher_category_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Teacher_category_List.My_List_To_Delete)
{
Delete_Teacher_category(new Params_Delete_Teacher_category() { TEACHER_CATEGORY_ID = oRow.TEACHER_CATEGORY_ID });
}
}
if (i_Params_Edit_Teacher_category_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Teacher_category_List.My_List_To_Edit)
{
Edit_Teacher_category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_category_List");}
}
public void Edit_Teacher_favorite_List(List<Teacher_favorite> i_List_Teacher_favorite)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_favorite_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Teacher_favorite != null)
{
foreach (var oRow in i_List_Teacher_favorite)
{
Edit_Teacher_favorite(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_favorite_List");}
}
public void Edit_Teacher_favorite_List(Params_Edit_Teacher_favorite_List i_Params_Edit_Teacher_favorite_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_favorite_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Teacher_favorite_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Teacher_favorite_List.My_List_To_Delete)
{
Delete_Teacher_favorite(new Params_Delete_Teacher_favorite() { TEACHER_FAVORITE_ID = oRow.TEACHER_FAVORITE_ID });
}
}
if (i_Params_Edit_Teacher_favorite_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Teacher_favorite_List.My_List_To_Edit)
{
Edit_Teacher_favorite(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_favorite_List");}
}
public void Edit_Teacher_report_List(List<Teacher_report> i_List_Teacher_report)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_report_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Teacher_report != null)
{
foreach (var oRow in i_List_Teacher_report)
{
Edit_Teacher_report(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_report_List");}
}
public void Edit_Teacher_report_List(Params_Edit_Teacher_report_List i_Params_Edit_Teacher_report_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_report_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Teacher_report_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Teacher_report_List.My_List_To_Delete)
{
Delete_Teacher_report(new Params_Delete_Teacher_report() { TEACHER_REPORT_ID = oRow.TEACHER_REPORT_ID });
}
}
if (i_Params_Edit_Teacher_report_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Teacher_report_List.My_List_To_Edit)
{
Edit_Teacher_report(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_report_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_type_code_List(List<User_type_code> i_List_User_type_code)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User_type_code != null)
{
foreach (var oRow in i_List_User_type_code)
{
Edit_User_type_code(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code_List");}
}
public void Edit_User_type_code_List(Params_Edit_User_type_code_List i_Params_Edit_User_type_code_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_type_code_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_type_code_List.My_List_To_Delete)
{
Delete_User_type_code(new Params_Delete_User_type_code() { USER_TYPE_CODE_ID = oRow.USER_TYPE_CODE_ID });
}
}
if (i_Params_Edit_User_type_code_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_type_code_List.My_List_To_Edit)
{
Edit_User_type_code(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code_List");}
}
}
}
