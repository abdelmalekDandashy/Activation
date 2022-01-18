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
public Address Get_Address_By_ADDRESS_ID_Adv(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID_Adv(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
return oAddress;
}
public Answer Get_Answer_By_ANSWER_ID_Adv(Params_Get_Answer_By_ANSWER_ID i_Params_Get_Answer_By_ANSWER_ID)
{
Answer oAnswer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_ANSWER_ID_Adv");}
#region Body Section.
DALC.Answer oDBEntry = _AppContext.Get_Answer_By_ANSWER_ID_Adv(i_Params_Get_Answer_By_ANSWER_ID.ANSWER_ID);
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_ANSWER_ID_Adv");}
return oAnswer;
}
public Category Get_Category_By_CATEGORY_ID_Adv(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_Adv");}
#region Body Section.
DALC.Category oDBEntry = _AppContext.Get_Category_By_CATEGORY_ID_Adv(i_Params_Get_Category_By_CATEGORY_ID.CATEGORY_ID);
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_Adv");}
return oCategory;
}
public Category_favorite Get_Category_favorite_By_CATEGORY_FAVORITE_ID_Adv(Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID)
{
Category_favorite oCategory_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID_Adv");}
#region Body Section.
DALC.Category_favorite oDBEntry = _AppContext.Get_Category_favorite_By_CATEGORY_FAVORITE_ID_Adv(i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID.CATEGORY_FAVORITE_ID);
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID_Adv");}
return oCategory_favorite;
}
public Contact Get_Contact_By_CONTACT_ID_Adv(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID_Adv(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
return oContact;
}
public Evaluation Get_Evaluation_By_EVALUATION_ID_Adv(Params_Get_Evaluation_By_EVALUATION_ID i_Params_Get_Evaluation_By_EVALUATION_ID)
{
Evaluation oEvaluation = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_EVALUATION_ID_Adv");}
#region Body Section.
DALC.Evaluation oDBEntry = _AppContext.Get_Evaluation_By_EVALUATION_ID_Adv(i_Params_Get_Evaluation_By_EVALUATION_ID.EVALUATION_ID);
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_EVALUATION_ID_Adv");}
return oEvaluation;
}
public Favorite_teacher Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_Adv(Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID)
{
Favorite_teacher oFavorite_teacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_Adv");}
#region Body Section.
DALC.Favorite_teacher oDBEntry = _AppContext.Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_Adv(i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID.FAVORITE_TEACHER_ID);
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_Adv");}
return oFavorite_teacher;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
return oLoc_l4;
}
public Person Get_Person_By_PERSON_ID_Adv(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_Adv");}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID_Adv(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_Adv");}
return oPerson;
}
public Question Get_Question_By_QUESTION_ID_Adv(Params_Get_Question_By_QUESTION_ID i_Params_Get_Question_By_QUESTION_ID)
{
Question oQuestion = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_QUESTION_ID_Adv");}
#region Body Section.
DALC.Question oDBEntry = _AppContext.Get_Question_By_QUESTION_ID_Adv(i_Params_Get_Question_By_QUESTION_ID.QUESTION_ID);
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_QUESTION_ID_Adv");}
return oQuestion;
}
public Question_token Get_Question_token_By_QUESTION_TOKEN_ID_Adv(Params_Get_Question_token_By_QUESTION_TOKEN_ID i_Params_Get_Question_token_By_QUESTION_TOKEN_ID)
{
Question_token oQuestion_token = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID_Adv");}
#region Body Section.
DALC.Question_token oDBEntry = _AppContext.Get_Question_token_By_QUESTION_TOKEN_ID_Adv(i_Params_Get_Question_token_By_QUESTION_TOKEN_ID.QUESTION_TOKEN_ID);
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID_Adv");}
return oQuestion_token;
}
public Student Get_Student_By_STUDENT_ID_Adv(Params_Get_Student_By_STUDENT_ID i_Params_Get_Student_By_STUDENT_ID)
{
Student oStudent = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_STUDENT_ID_Adv");}
#region Body Section.
DALC.Student oDBEntry = _AppContext.Get_Student_By_STUDENT_ID_Adv(i_Params_Get_Student_By_STUDENT_ID.STUDENT_ID);
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_STUDENT_ID_Adv");}
return oStudent;
}
public Student_report Get_Student_report_By_STUDENT_REPORT_ID_Adv(Params_Get_Student_report_By_STUDENT_REPORT_ID i_Params_Get_Student_report_By_STUDENT_REPORT_ID)
{
Student_report oStudent_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_STUDENT_REPORT_ID_Adv");}
#region Body Section.
DALC.Student_report oDBEntry = _AppContext.Get_Student_report_By_STUDENT_REPORT_ID_Adv(i_Params_Get_Student_report_By_STUDENT_REPORT_ID.STUDENT_REPORT_ID);
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_STUDENT_REPORT_ID_Adv");}
return oStudent_report;
}
public Teacher Get_Teacher_By_TEACHER_ID_Adv(Params_Get_Teacher_By_TEACHER_ID i_Params_Get_Teacher_By_TEACHER_ID)
{
Teacher oTeacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_TEACHER_ID_Adv");}
#region Body Section.
DALC.Teacher oDBEntry = _AppContext.Get_Teacher_By_TEACHER_ID_Adv(i_Params_Get_Teacher_By_TEACHER_ID.TEACHER_ID);
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_TEACHER_ID_Adv");}
return oTeacher;
}
public Teacher_category Get_Teacher_category_By_TEACHER_CATEGORY_ID_Adv(Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID)
{
Teacher_category oTeacher_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID_Adv");}
#region Body Section.
DALC.Teacher_category oDBEntry = _AppContext.Get_Teacher_category_By_TEACHER_CATEGORY_ID_Adv(i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID.TEACHER_CATEGORY_ID);
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID_Adv");}
return oTeacher_category;
}
public Teacher_favorite Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_Adv(Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID)
{
Teacher_favorite oTeacher_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_Adv");}
#region Body Section.
DALC.Teacher_favorite oDBEntry = _AppContext.Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_Adv(i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID.TEACHER_FAVORITE_ID);
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_Adv");}
return oTeacher_favorite;
}
public Teacher_report Get_Teacher_report_By_TEACHER_REPORT_ID_Adv(Params_Get_Teacher_report_By_TEACHER_REPORT_ID i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID)
{
Teacher_report oTeacher_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID_Adv");}
#region Body Section.
DALC.Teacher_report oDBEntry = _AppContext.Get_Teacher_report_By_TEACHER_REPORT_ID_Adv(i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID.TEACHER_REPORT_ID);
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID_Adv");}
return oTeacher_report;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public User_type_code Get_User_type_code_By_USER_TYPE_CODE_ID_Adv(Params_Get_User_type_code_By_USER_TYPE_CODE_ID i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID)
{
User_type_code oUser_type_code = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID_Adv");}
#region Body Section.
DALC.User_type_code oDBEntry = _AppContext.Get_User_type_code_By_USER_TYPE_CODE_ID_Adv(i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
oUser_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry, oUser_type_code);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID_Adv");}
return oUser_type_code;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List_Adv(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_ANSWER_ID_List_Adv(Params_Get_Answer_By_ANSWER_ID_List i_Params_Get_Answer_By_ANSWER_ID_List)
{
Answer oAnswer = null;
List<Answer> oList = new List<Answer>();
Params_Get_Answer_By_ANSWER_ID_List_SP oParams_Get_Answer_By_ANSWER_ID_List_SP = new Params_Get_Answer_By_ANSWER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_ANSWER_ID_List_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_ANSWER_ID_List_Adv(i_Params_Get_Answer_By_ANSWER_ID_List.ANSWER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_ANSWER_ID_List_Adv");}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List_Adv(Params_Get_Category_By_CATEGORY_ID_List i_Params_Get_Category_By_CATEGORY_ID_List)
{
Category oCategory = null;
List<Category> oList = new List<Category>();
Params_Get_Category_By_CATEGORY_ID_List_SP oParams_Get_Category_By_CATEGORY_ID_List_SP = new Params_Get_Category_By_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_CATEGORY_ID_List_Adv(i_Params_Get_Category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_Adv(Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List)
{
Category_favorite oCategory_favorite = null;
List<Category_favorite> oList = new List<Category_favorite>();
Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP oParams_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP = new Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_Adv");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_Adv(i_Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List.CATEGORY_FAVORITE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List_Adv(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_EVALUATION_ID_List_Adv(Params_Get_Evaluation_By_EVALUATION_ID_List i_Params_Get_Evaluation_By_EVALUATION_ID_List)
{
Evaluation oEvaluation = null;
List<Evaluation> oList = new List<Evaluation>();
Params_Get_Evaluation_By_EVALUATION_ID_List_SP oParams_Get_Evaluation_By_EVALUATION_ID_List_SP = new Params_Get_Evaluation_By_EVALUATION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_EVALUATION_ID_List_Adv");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_EVALUATION_ID_List_Adv(i_Params_Get_Evaluation_By_EVALUATION_ID_List.EVALUATION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_EVALUATION_ID_List_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_Adv(Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List)
{
Favorite_teacher oFavorite_teacher = null;
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP oParams_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP = new Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_Adv(i_Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List.FAVORITE_TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List_Adv(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Question> Get_Question_By_QUESTION_ID_List_Adv(Params_Get_Question_By_QUESTION_ID_List i_Params_Get_Question_By_QUESTION_ID_List)
{
Question oQuestion = null;
List<Question> oList = new List<Question>();
Params_Get_Question_By_QUESTION_ID_List_SP oParams_Get_Question_By_QUESTION_ID_List_SP = new Params_Get_Question_By_QUESTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_QUESTION_ID_List_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_QUESTION_ID_List_Adv(i_Params_Get_Question_By_QUESTION_ID_List.QUESTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_QUESTION_ID_List_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_TOKEN_ID_List_Adv(Params_Get_Question_token_By_QUESTION_TOKEN_ID_List i_Params_Get_Question_token_By_QUESTION_TOKEN_ID_List)
{
Question_token oQuestion_token = null;
List<Question_token> oList = new List<Question_token>();
Params_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP oParams_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP = new Params_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID_List_Adv");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_QUESTION_TOKEN_ID_List_Adv(i_Params_Get_Question_token_By_QUESTION_TOKEN_ID_List.QUESTION_TOKEN_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_TOKEN_ID_List_Adv");}
return oList;
}
public List<Student> Get_Student_By_STUDENT_ID_List_Adv(Params_Get_Student_By_STUDENT_ID_List i_Params_Get_Student_By_STUDENT_ID_List)
{
Student oStudent = null;
List<Student> oList = new List<Student>();
Params_Get_Student_By_STUDENT_ID_List_SP oParams_Get_Student_By_STUDENT_ID_List_SP = new Params_Get_Student_By_STUDENT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_STUDENT_ID_List_Adv(i_Params_Get_Student_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_STUDENT_REPORT_ID_List_Adv(Params_Get_Student_report_By_STUDENT_REPORT_ID_List i_Params_Get_Student_report_By_STUDENT_REPORT_ID_List)
{
Student_report oStudent_report = null;
List<Student_report> oList = new List<Student_report>();
Params_Get_Student_report_By_STUDENT_REPORT_ID_List_SP oParams_Get_Student_report_By_STUDENT_REPORT_ID_List_SP = new Params_Get_Student_report_By_STUDENT_REPORT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_STUDENT_REPORT_ID_List_Adv");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_STUDENT_REPORT_ID_List_Adv(i_Params_Get_Student_report_By_STUDENT_REPORT_ID_List.STUDENT_REPORT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_STUDENT_REPORT_ID_List_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_TEACHER_ID_List_Adv(Params_Get_Teacher_By_TEACHER_ID_List i_Params_Get_Teacher_By_TEACHER_ID_List)
{
Teacher oTeacher = null;
List<Teacher> oList = new List<Teacher>();
Params_Get_Teacher_By_TEACHER_ID_List_SP oParams_Get_Teacher_By_TEACHER_ID_List_SP = new Params_Get_Teacher_By_TEACHER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_TEACHER_ID_List_Adv(i_Params_Get_Teacher_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_Adv(Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List)
{
Teacher_category oTeacher_category = null;
List<Teacher_category> oList = new List<Teacher_category>();
Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP oParams_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP = new Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_Adv(i_Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List.TEACHER_CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_Adv(Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List)
{
Teacher_favorite oTeacher_favorite = null;
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP oParams_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP = new Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_Adv(i_Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List.TEACHER_FAVORITE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_REPORT_ID_List_Adv(Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List)
{
Teacher_report oTeacher_report = null;
List<Teacher_report> oList = new List<Teacher_report>();
Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP oParams_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP = new Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_TEACHER_REPORT_ID_List_Adv(i_Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List.TEACHER_REPORT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_REPORT_ID_List_Adv");}
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
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_USER_TYPE_CODE_ID_List_Adv(Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List)
{
User_type_code oUser_type_code = null;
List<User_type_code> oList = new List<User_type_code>();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP oParams_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID_List_Adv");}
#region Body Section.
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_USER_TYPE_CODE_ID_List_Adv(i_Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_USER_TYPE_CODE_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_Adv(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_Adv(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_Adv(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_Adv(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID_Adv(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_Adv(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_OWNER_ID_Adv(Params_Get_Answer_By_OWNER_ID i_Params_Get_Answer_By_OWNER_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_OWNER_ID_Adv(i_Params_Get_Answer_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_OWNER_ID_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID_Adv(Params_Get_Answer_By_QUESTION_ID i_Params_Get_Answer_By_QUESTION_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_QUESTION_ID_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_QUESTION_ID_Adv(i_Params_Get_Answer_By_QUESTION_ID.QUESTION_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_QUESTION_ID_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID_Adv(Params_Get_Answer_By_TEACHER_ID i_Params_Get_Answer_By_TEACHER_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_TEACHER_ID_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_TEACHER_ID_Adv(i_Params_Get_Answer_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_TEACHER_ID_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID_Adv(Params_Get_Answer_By_STUDENT_ID i_Params_Get_Answer_By_STUDENT_ID)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_STUDENT_ID_Adv(i_Params_Get_Answer_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_STUDENT_ID_Adv");}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID_Adv(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_OWNER_ID_Adv(i_Params_Get_Category_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_OWNER_ID_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_OWNER_ID_Adv(Params_Get_Category_favorite_By_OWNER_ID i_Params_Get_Category_favorite_By_OWNER_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_OWNER_ID_Adv(i_Params_Get_Category_favorite_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_OWNER_ID_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_Adv(Params_Get_Category_favorite_By_STUDENT_ID i_Params_Get_Category_favorite_By_STUDENT_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_STUDENT_ID_Adv(i_Params_Get_Category_favorite_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_STUDENT_ID_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_Adv(Params_Get_Category_favorite_By_CATEGORY_ID i_Params_Get_Category_favorite_By_CATEGORY_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_CATEGORY_ID_Adv(i_Params_Get_Category_favorite_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_Adv(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID_Adv(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_OWNER_ID_Adv(Params_Get_Evaluation_By_OWNER_ID i_Params_Get_Evaluation_By_OWNER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_OWNER_ID_Adv(i_Params_Get_Evaluation_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_OWNER_ID_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID_Adv(Params_Get_Evaluation_By_STUDENT_ID i_Params_Get_Evaluation_By_STUDENT_ID)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_STUDENT_ID_Adv(i_Params_Get_Evaluation_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_STUDENT_ID_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID_Adv(Params_Get_Evaluation_By_ANSWER_ID i_Params_Get_Evaluation_By_ANSWER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_ANSWER_ID_Adv");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_ANSWER_ID_Adv(i_Params_Get_Evaluation_By_ANSWER_ID.ANSWER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_ANSWER_ID_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_OWNER_ID_Adv(Params_Get_Favorite_teacher_By_OWNER_ID i_Params_Get_Favorite_teacher_By_OWNER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_OWNER_ID_Adv(i_Params_Get_Favorite_teacher_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_OWNER_ID_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_Adv(Params_Get_Favorite_teacher_By_STUDENT_ID i_Params_Get_Favorite_teacher_By_STUDENT_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_STUDENT_ID_Adv(i_Params_Get_Favorite_teacher_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_STUDENT_ID_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_Adv(Params_Get_Favorite_teacher_By_TEACHER_ID i_Params_Get_Favorite_teacher_By_TEACHER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_TEACHER_ID_Adv");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_TEACHER_ID_Adv(i_Params_Get_Favorite_teacher_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_TEACHER_ID_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE_Adv(i_Params_Get_Loc_l1_By_CODE.CODE);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID_Adv(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID_Adv(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID_Adv(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID_Adv(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID_Adv(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID_Adv");}
return oList;
}
public List<Question> Get_Question_By_OWNER_ID_Adv(Params_Get_Question_By_OWNER_ID i_Params_Get_Question_By_OWNER_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_OWNER_ID_Adv(i_Params_Get_Question_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_OWNER_ID_Adv");}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID_Adv(Params_Get_Question_By_STUDENT_ID i_Params_Get_Question_By_STUDENT_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_STUDENT_ID_Adv(i_Params_Get_Question_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_STUDENT_ID_Adv");}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID_Adv(Params_Get_Question_By_CATEGORY_ID i_Params_Get_Question_By_CATEGORY_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_CATEGORY_ID_Adv(i_Params_Get_Question_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_CATEGORY_ID_Adv");}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID_Adv(Params_Get_Question_By_TEACHER_ID i_Params_Get_Question_By_TEACHER_ID)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_TEACHER_ID_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_TEACHER_ID_Adv(i_Params_Get_Question_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_TEACHER_ID_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_PART_Adv(Params_Get_Question_token_By_PART i_Params_Get_Question_token_By_PART)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_PART_Adv");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_PART_Adv(i_Params_Get_Question_token_By_PART.PART);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_PART_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_OWNER_ID_Adv(Params_Get_Question_token_By_OWNER_ID i_Params_Get_Question_token_By_OWNER_ID)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_OWNER_ID_Adv(i_Params_Get_Question_token_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_OWNER_ID_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID_Adv(Params_Get_Question_token_By_QUESTION_ID i_Params_Get_Question_token_By_QUESTION_ID)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_ID_Adv");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_QUESTION_ID_Adv(i_Params_Get_Question_token_By_QUESTION_ID.QUESTION_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_ID_Adv");}
return oList;
}
public List<Student> Get_Student_By_OWNER_ID_Adv(Params_Get_Student_By_OWNER_ID i_Params_Get_Student_By_OWNER_ID)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_OWNER_ID_Adv(i_Params_Get_Student_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_OWNER_ID_Adv");}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID_Adv(Params_Get_Student_By_USER_TYPE_CODE_ID i_Params_Get_Student_By_USER_TYPE_CODE_ID)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_TYPE_CODE_ID_Adv");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_TYPE_CODE_ID_Adv(i_Params_Get_Student_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_TYPE_CODE_ID_Adv");}
return oList;
}
public List<Student> Get_Student_By_USER_ID_Adv(Params_Get_Student_By_USER_ID i_Params_Get_Student_By_USER_ID)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_ID_Adv");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_ID_Adv(i_Params_Get_Student_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_ID_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_OWNER_ID_Adv(Params_Get_Student_report_By_OWNER_ID i_Params_Get_Student_report_By_OWNER_ID)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_OWNER_ID_Adv(i_Params_Get_Student_report_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_OWNER_ID_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_Adv(Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_BY_STUDENT_ID_Adv(i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID.REPORTED_BY_STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_Adv(Params_Get_Student_report_By_REPORTED_STUDENT_ID i_Params_Get_Student_report_By_REPORTED_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_STUDENT_ID_Adv(i_Params_Get_Student_report_By_REPORTED_STUDENT_ID.REPORTED_STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_OWNER_ID_Adv(Params_Get_Teacher_By_OWNER_ID i_Params_Get_Teacher_By_OWNER_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_OWNER_ID_Adv(i_Params_Get_Teacher_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_OWNER_ID_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID_Adv(Params_Get_Teacher_By_CATEGORY_ID i_Params_Get_Teacher_By_CATEGORY_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_CATEGORY_ID_Adv(i_Params_Get_Teacher_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_CATEGORY_ID_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_Adv(Params_Get_Teacher_By_USER_TYPE_CODE_ID i_Params_Get_Teacher_By_USER_TYPE_CODE_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_TYPE_CODE_ID_Adv(i_Params_Get_Teacher_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID_Adv(Params_Get_Teacher_By_USER_ID i_Params_Get_Teacher_By_USER_ID)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_ID_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_ID_Adv(i_Params_Get_Teacher_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_ID_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_OWNER_ID_Adv(Params_Get_Teacher_category_By_OWNER_ID i_Params_Get_Teacher_category_By_OWNER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_OWNER_ID_Adv(i_Params_Get_Teacher_category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_OWNER_ID_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_Adv(Params_Get_Teacher_category_By_TEACHER_ID i_Params_Get_Teacher_category_By_TEACHER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_ID_Adv");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_TEACHER_ID_Adv(i_Params_Get_Teacher_category_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_ID_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_Adv(Params_Get_Teacher_category_By_CATEGORY_ID i_Params_Get_Teacher_category_By_CATEGORY_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_CATEGORY_ID_Adv(i_Params_Get_Teacher_category_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_CATEGORY_ID_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_OWNER_ID_Adv(Params_Get_Teacher_favorite_By_OWNER_ID i_Params_Get_Teacher_favorite_By_OWNER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_OWNER_ID_Adv(i_Params_Get_Teacher_favorite_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_OWNER_ID_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_Adv(Params_Get_Teacher_favorite_By_STUDENT_ID i_Params_Get_Teacher_favorite_By_STUDENT_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_STUDENT_ID_Adv(i_Params_Get_Teacher_favorite_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_STUDENT_ID_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_Adv(Params_Get_Teacher_favorite_By_TEACHER_ID i_Params_Get_Teacher_favorite_By_TEACHER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_ID_Adv");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_TEACHER_ID_Adv(i_Params_Get_Teacher_favorite_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_ID_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_OWNER_ID_Adv(Params_Get_Teacher_report_By_OWNER_ID i_Params_Get_Teacher_report_By_OWNER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_OWNER_ID_Adv(i_Params_Get_Teacher_report_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_OWNER_ID_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_Adv(Params_Get_Teacher_report_By_TEACHER_ID i_Params_Get_Teacher_report_By_TEACHER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_ID_Adv");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_TEACHER_ID_Adv(i_Params_Get_Teacher_report_By_TEACHER_ID.TEACHER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_ID_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_Adv(Params_Get_Teacher_report_By_STUDENT_ID i_Params_Get_Teacher_report_By_STUDENT_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_STUDENT_ID_Adv");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_STUDENT_ID_Adv(i_Params_Get_Teacher_report_By_STUDENT_ID.STUDENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_STUDENT_ID_Adv");}
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
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
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
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID_Adv(Params_Get_User_By_USER_TYPE_CODE_ID i_Params_Get_User_By_USER_TYPE_CODE_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_TYPE_CODE_ID_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_TYPE_CODE_ID_Adv(i_Params_Get_User_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_TYPE_CODE_ID_Adv");}
return oList;
}
public List<User> Get_User_By_EMAIL_Adv(Params_Get_User_By_EMAIL i_Params_Get_User_By_EMAIL)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_EMAIL_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_EMAIL_Adv(i_Params_Get_User_By_EMAIL.EMAIL);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_EMAIL_Adv");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_OWNER_ID_Adv(Params_Get_User_type_code_By_OWNER_ID i_Params_Get_User_type_code_By_OWNER_ID)
{
List<User_type_code> oList = new List<User_type_code>();
User_type_code oUser_type_code = new User_type_code();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_OWNER_ID_Adv(i_Params_Get_User_type_code_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_OWNER_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List_Adv(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List_Adv(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List_Adv(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List_Adv(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List_Adv(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID_List_Adv(Params_Get_Answer_By_QUESTION_ID_List i_Params_Get_Answer_By_QUESTION_ID_List)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_QUESTION_ID_List_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_QUESTION_ID_List_Adv(i_Params_Get_Answer_By_QUESTION_ID_List.QUESTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_QUESTION_ID_List_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID_List_Adv(Params_Get_Answer_By_TEACHER_ID_List i_Params_Get_Answer_By_TEACHER_ID_List)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_TEACHER_ID_List_Adv(i_Params_Get_Answer_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID_List_Adv(Params_Get_Answer_By_STUDENT_ID_List i_Params_Get_Answer_By_STUDENT_ID_List)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_STUDENT_ID_List_Adv(i_Params_Get_Answer_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_List_Adv(Params_Get_Category_favorite_By_STUDENT_ID_List i_Params_Get_Category_favorite_By_STUDENT_ID_List)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_STUDENT_ID_List_Adv(i_Params_Get_Category_favorite_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_List_Adv(Params_Get_Category_favorite_By_CATEGORY_ID_List i_Params_Get_Category_favorite_By_CATEGORY_ID_List)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_CATEGORY_ID_List_Adv(i_Params_Get_Category_favorite_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List_Adv(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID_List_Adv(Params_Get_Evaluation_By_STUDENT_ID_List i_Params_Get_Evaluation_By_STUDENT_ID_List)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_STUDENT_ID_List_Adv(i_Params_Get_Evaluation_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID_List_Adv(Params_Get_Evaluation_By_ANSWER_ID_List i_Params_Get_Evaluation_By_ANSWER_ID_List)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_ANSWER_ID_List_Adv");}
#region Body Section.
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_ANSWER_ID_List_Adv(i_Params_Get_Evaluation_By_ANSWER_ID_List.ANSWER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_ANSWER_ID_List_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_List_Adv(Params_Get_Favorite_teacher_By_STUDENT_ID_List i_Params_Get_Favorite_teacher_By_STUDENT_ID_List)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_STUDENT_ID_List_Adv(i_Params_Get_Favorite_teacher_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_List_Adv(Params_Get_Favorite_teacher_By_TEACHER_ID_List i_Params_Get_Favorite_teacher_By_TEACHER_ID_List)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_TEACHER_ID_List_Adv(i_Params_Get_Favorite_teacher_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID_List_Adv(Params_Get_Question_By_STUDENT_ID_List i_Params_Get_Question_By_STUDENT_ID_List)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_STUDENT_ID_List_Adv(i_Params_Get_Question_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID_List_Adv(Params_Get_Question_By_CATEGORY_ID_List i_Params_Get_Question_By_CATEGORY_ID_List)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_CATEGORY_ID_List_Adv(i_Params_Get_Question_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID_List_Adv(Params_Get_Question_By_TEACHER_ID_List i_Params_Get_Question_By_TEACHER_ID_List)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_TEACHER_ID_List_Adv(i_Params_Get_Question_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID_List_Adv(Params_Get_Question_token_By_QUESTION_ID_List i_Params_Get_Question_token_By_QUESTION_ID_List)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_QUESTION_ID_List_Adv");}
#region Body Section.
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_QUESTION_ID_List_Adv(i_Params_Get_Question_token_By_QUESTION_ID_List.QUESTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_QUESTION_ID_List_Adv");}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID_List_Adv(Params_Get_Student_By_USER_TYPE_CODE_ID_List i_Params_Get_Student_By_USER_TYPE_CODE_ID_List)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_TYPE_CODE_ID_List_Adv");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_TYPE_CODE_ID_List_Adv(i_Params_Get_Student_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_TYPE_CODE_ID_List_Adv");}
return oList;
}
public List<Student> Get_Student_By_USER_ID_List_Adv(Params_Get_Student_By_USER_ID_List i_Params_Get_Student_By_USER_ID_List)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_USER_ID_List_Adv(i_Params_Get_Student_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_USER_ID_List_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_List_Adv(Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_BY_STUDENT_ID_List_Adv(i_Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List.REPORTED_BY_STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_BY_STUDENT_ID_List_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_List_Adv(Params_Get_Student_report_By_REPORTED_STUDENT_ID_List i_Params_Get_Student_report_By_REPORTED_STUDENT_ID_List)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_REPORTED_STUDENT_ID_List_Adv(i_Params_Get_Student_report_By_REPORTED_STUDENT_ID_List.REPORTED_STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_REPORTED_STUDENT_ID_List_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID_List_Adv(Params_Get_Teacher_By_CATEGORY_ID_List i_Params_Get_Teacher_By_CATEGORY_ID_List)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_CATEGORY_ID_List_Adv(i_Params_Get_Teacher_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_List_Adv(Params_Get_Teacher_By_USER_TYPE_CODE_ID_List i_Params_Get_Teacher_By_USER_TYPE_CODE_ID_List)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_TYPE_CODE_ID_List_Adv(i_Params_Get_Teacher_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_TYPE_CODE_ID_List_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID_List_Adv(Params_Get_Teacher_By_USER_ID_List i_Params_Get_Teacher_By_USER_ID_List)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_USER_ID_List_Adv(i_Params_Get_Teacher_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_USER_ID_List_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_List_Adv(Params_Get_Teacher_category_By_TEACHER_ID_List i_Params_Get_Teacher_category_By_TEACHER_ID_List)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_TEACHER_ID_List_Adv(i_Params_Get_Teacher_category_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_List_Adv(Params_Get_Teacher_category_By_CATEGORY_ID_List i_Params_Get_Teacher_category_By_CATEGORY_ID_List)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_CATEGORY_ID_List_Adv(i_Params_Get_Teacher_category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_List_Adv(Params_Get_Teacher_favorite_By_STUDENT_ID_List i_Params_Get_Teacher_favorite_By_STUDENT_ID_List)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_STUDENT_ID_List_Adv(i_Params_Get_Teacher_favorite_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_List_Adv(Params_Get_Teacher_favorite_By_TEACHER_ID_List i_Params_Get_Teacher_favorite_By_TEACHER_ID_List)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_TEACHER_ID_List_Adv(i_Params_Get_Teacher_favorite_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_List_Adv(Params_Get_Teacher_report_By_TEACHER_ID_List i_Params_Get_Teacher_report_By_TEACHER_ID_List)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_TEACHER_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_TEACHER_ID_List_Adv(i_Params_Get_Teacher_report_By_TEACHER_ID_List.TEACHER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_TEACHER_ID_List_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_List_Adv(Params_Get_Teacher_report_By_STUDENT_ID_List i_Params_Get_Teacher_report_By_STUDENT_ID_List)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_STUDENT_ID_List_Adv");}
#region Body Section.
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_STUDENT_ID_List_Adv(i_Params_Get_Teacher_report_By_STUDENT_ID_List.STUDENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_STUDENT_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID_List_Adv(Params_Get_User_By_USER_TYPE_CODE_ID_List i_Params_Get_User_By_USER_TYPE_CODE_ID_List)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_TYPE_CODE_ID_List_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_TYPE_CODE_ID_List_Adv(i_Params_Get_User_By_USER_TYPE_CODE_ID_List.USER_TYPE_CODE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_TYPE_CODE_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv_V2");}
return oList;
}
public List<Answer> Get_Answer_By_Criteria_Adv(Params_Get_Answer_By_Criteria i_Params_Get_Answer_By_Criteria)
{
List<Answer> oList = new List<Answer>();
long? tmp_TOTAL_COUNT = 0;
Answer oAnswer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Answer_By_Criteria.OWNER_ID == null) || (i_Params_Get_Answer_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Answer_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Answer_By_Criteria.START_ROW == null) { i_Params_Get_Answer_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Answer_By_Criteria.END_ROW == null) || (i_Params_Get_Answer_By_Criteria.END_ROW == 0)) { i_Params_Get_Answer_By_Criteria.END_ROW = 1000000; }
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Criteria_Adv(i_Params_Get_Answer_By_Criteria.DESCRIPTION,i_Params_Get_Answer_By_Criteria.OWNER_ID,i_Params_Get_Answer_By_Criteria.START_ROW,i_Params_Get_Answer_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Criteria_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_Where_Adv(Params_Get_Answer_By_Where i_Params_Get_Answer_By_Where)
{
List<Answer> oList = new List<Answer>();
long? tmp_TOTAL_COUNT = 0;
Answer oAnswer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Answer_By_Where.OWNER_ID == null) || (i_Params_Get_Answer_By_Where.OWNER_ID == 0)) { i_Params_Get_Answer_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Answer_By_Where.START_ROW == null) { i_Params_Get_Answer_By_Where.START_ROW = 0; }
if ((i_Params_Get_Answer_By_Where.END_ROW == null) || (i_Params_Get_Answer_By_Where.END_ROW == 0)) { i_Params_Get_Answer_By_Where.END_ROW = 1000000; }
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Where_Adv(i_Params_Get_Answer_By_Where.DESCRIPTION,i_Params_Get_Answer_By_Where.OWNER_ID,i_Params_Get_Answer_By_Where.START_ROW,i_Params_Get_Answer_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Where_Adv");}
return oList;
}
public List<Category> Get_Category_By_Criteria_Adv(Params_Get_Category_By_Criteria i_Params_Get_Category_By_Criteria)
{
List<Category> oList = new List<Category>();
long? tmp_TOTAL_COUNT = 0;
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Criteria.START_ROW == null) { i_Params_Get_Category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_By_Criteria.END_ROW == null) || (i_Params_Get_Category_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_By_Criteria.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Criteria_Adv(i_Params_Get_Category_By_Criteria.NAME,i_Params_Get_Category_By_Criteria.DESCRIPTION,i_Params_Get_Category_By_Criteria.OWNER_ID,i_Params_Get_Category_By_Criteria.START_ROW,i_Params_Get_Category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Criteria_Adv");}
return oList;
}
public List<Category> Get_Category_By_Where_Adv(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
List<Category> oList = new List<Category>();
long? tmp_TOTAL_COUNT = 0;
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Category_By_Where.OWNER_ID == null) || (i_Params_Get_Category_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Where.START_ROW == null) { i_Params_Get_Category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_By_Where.END_ROW == null) || (i_Params_Get_Category_By_Where.END_ROW == 0)) { i_Params_Get_Category_By_Where.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Where_Adv(i_Params_Get_Category_By_Where.NAME,i_Params_Get_Category_By_Where.DESCRIPTION,i_Params_Get_Category_By_Where.OWNER_ID,i_Params_Get_Category_By_Where.START_ROW,i_Params_Get_Category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Where_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria_Adv(Params_Get_Category_favorite_By_Criteria i_Params_Get_Category_favorite_By_Criteria)
{
List<Category_favorite> oList = new List<Category_favorite>();
long? tmp_TOTAL_COUNT = 0;
Category_favorite oCategory_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Category_favorite_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_favorite_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_favorite_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_favorite_By_Criteria.START_ROW == null) { i_Params_Get_Category_favorite_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_favorite_By_Criteria.END_ROW == null) || (i_Params_Get_Category_favorite_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_favorite_By_Criteria.END_ROW = 1000000; }
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Criteria_Adv(i_Params_Get_Category_favorite_By_Criteria.DESCRIPTION,i_Params_Get_Category_favorite_By_Criteria.OWNER_ID,i_Params_Get_Category_favorite_By_Criteria.START_ROW,i_Params_Get_Category_favorite_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Criteria_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where_Adv(Params_Get_Category_favorite_By_Where i_Params_Get_Category_favorite_By_Where)
{
List<Category_favorite> oList = new List<Category_favorite>();
long? tmp_TOTAL_COUNT = 0;
Category_favorite oCategory_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Category_favorite_By_Where.OWNER_ID == null) || (i_Params_Get_Category_favorite_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_favorite_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_favorite_By_Where.START_ROW == null) { i_Params_Get_Category_favorite_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_favorite_By_Where.END_ROW == null) || (i_Params_Get_Category_favorite_By_Where.END_ROW == 0)) { i_Params_Get_Category_favorite_By_Where.END_ROW = 1000000; }
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Where_Adv(i_Params_Get_Category_favorite_By_Where.DESCRIPTION,i_Params_Get_Category_favorite_By_Where.OWNER_ID,i_Params_Get_Category_favorite_By_Where.START_ROW,i_Params_Get_Category_favorite_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Where_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_Adv(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_Adv(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria_Adv(Params_Get_Evaluation_By_Criteria i_Params_Get_Evaluation_By_Criteria)
{
List<Evaluation> oList = new List<Evaluation>();
long? tmp_TOTAL_COUNT = 0;
Evaluation oEvaluation = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Evaluation_By_Criteria.OWNER_ID == null) || (i_Params_Get_Evaluation_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Evaluation_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Evaluation_By_Criteria.START_ROW == null) { i_Params_Get_Evaluation_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Evaluation_By_Criteria.END_ROW == null) || (i_Params_Get_Evaluation_By_Criteria.END_ROW == 0)) { i_Params_Get_Evaluation_By_Criteria.END_ROW = 1000000; }
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Criteria_Adv(i_Params_Get_Evaluation_By_Criteria.DESCRIPTION,i_Params_Get_Evaluation_By_Criteria.OWNER_ID,i_Params_Get_Evaluation_By_Criteria.START_ROW,i_Params_Get_Evaluation_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Criteria_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where_Adv(Params_Get_Evaluation_By_Where i_Params_Get_Evaluation_By_Where)
{
List<Evaluation> oList = new List<Evaluation>();
long? tmp_TOTAL_COUNT = 0;
Evaluation oEvaluation = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Evaluation_By_Where.OWNER_ID == null) || (i_Params_Get_Evaluation_By_Where.OWNER_ID == 0)) { i_Params_Get_Evaluation_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Evaluation_By_Where.START_ROW == null) { i_Params_Get_Evaluation_By_Where.START_ROW = 0; }
if ((i_Params_Get_Evaluation_By_Where.END_ROW == null) || (i_Params_Get_Evaluation_By_Where.END_ROW == 0)) { i_Params_Get_Evaluation_By_Where.END_ROW = 1000000; }
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Where_Adv(i_Params_Get_Evaluation_By_Where.DESCRIPTION,i_Params_Get_Evaluation_By_Where.OWNER_ID,i_Params_Get_Evaluation_By_Where.START_ROW,i_Params_Get_Evaluation_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Where_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_Adv(Params_Get_Favorite_teacher_By_Criteria i_Params_Get_Favorite_teacher_By_Criteria)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
long? tmp_TOTAL_COUNT = 0;
Favorite_teacher oFavorite_teacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID == null) || (i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Favorite_teacher_By_Criteria.START_ROW == null) { i_Params_Get_Favorite_teacher_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Favorite_teacher_By_Criteria.END_ROW == null) || (i_Params_Get_Favorite_teacher_By_Criteria.END_ROW == 0)) { i_Params_Get_Favorite_teacher_By_Criteria.END_ROW = 1000000; }
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Criteria_Adv(i_Params_Get_Favorite_teacher_By_Criteria.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Criteria.OWNER_ID,i_Params_Get_Favorite_teacher_By_Criteria.START_ROW,i_Params_Get_Favorite_teacher_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Criteria_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where_Adv(Params_Get_Favorite_teacher_By_Where i_Params_Get_Favorite_teacher_By_Where)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
long? tmp_TOTAL_COUNT = 0;
Favorite_teacher oFavorite_teacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Favorite_teacher_By_Where.OWNER_ID == null) || (i_Params_Get_Favorite_teacher_By_Where.OWNER_ID == 0)) { i_Params_Get_Favorite_teacher_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Favorite_teacher_By_Where.START_ROW == null) { i_Params_Get_Favorite_teacher_By_Where.START_ROW = 0; }
if ((i_Params_Get_Favorite_teacher_By_Where.END_ROW == null) || (i_Params_Get_Favorite_teacher_By_Where.END_ROW == 0)) { i_Params_Get_Favorite_teacher_By_Where.END_ROW = 1000000; }
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Where_Adv(i_Params_Get_Favorite_teacher_By_Where.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Where.OWNER_ID,i_Params_Get_Favorite_teacher_By_Where.START_ROW,i_Params_Get_Favorite_teacher_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Where_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria_Adv(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where_Adv(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_Adv(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_Adv(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_Adv(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_Adv(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_Adv(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_Adv(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_Adv");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv_V2");}
return oList;
}
public List<Question> Get_Question_By_Criteria_Adv(Params_Get_Question_By_Criteria i_Params_Get_Question_By_Criteria)
{
List<Question> oList = new List<Question>();
long? tmp_TOTAL_COUNT = 0;
Question oQuestion = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Question_By_Criteria.OWNER_ID == null) || (i_Params_Get_Question_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Question_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_By_Criteria.START_ROW == null) { i_Params_Get_Question_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Question_By_Criteria.END_ROW == null) || (i_Params_Get_Question_By_Criteria.END_ROW == 0)) { i_Params_Get_Question_By_Criteria.END_ROW = 1000000; }
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Criteria_Adv(i_Params_Get_Question_By_Criteria.DESCRIPTION,i_Params_Get_Question_By_Criteria.OWNER_ID,i_Params_Get_Question_By_Criteria.START_ROW,i_Params_Get_Question_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Criteria_Adv");}
return oList;
}
public List<Question> Get_Question_By_Where_Adv(Params_Get_Question_By_Where i_Params_Get_Question_By_Where)
{
List<Question> oList = new List<Question>();
long? tmp_TOTAL_COUNT = 0;
Question oQuestion = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Question_By_Where.OWNER_ID == null) || (i_Params_Get_Question_By_Where.OWNER_ID == 0)) { i_Params_Get_Question_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_By_Where.START_ROW == null) { i_Params_Get_Question_By_Where.START_ROW = 0; }
if ((i_Params_Get_Question_By_Where.END_ROW == null) || (i_Params_Get_Question_By_Where.END_ROW == 0)) { i_Params_Get_Question_By_Where.END_ROW = 1000000; }
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Where_Adv(i_Params_Get_Question_By_Where.DESCRIPTION,i_Params_Get_Question_By_Where.OWNER_ID,i_Params_Get_Question_By_Where.START_ROW,i_Params_Get_Question_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Where_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria_Adv(Params_Get_Question_token_By_Criteria i_Params_Get_Question_token_By_Criteria)
{
List<Question_token> oList = new List<Question_token>();
long? tmp_TOTAL_COUNT = 0;
Question_token oQuestion_token = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Question_token_By_Criteria.OWNER_ID == null) || (i_Params_Get_Question_token_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Question_token_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_token_By_Criteria.START_ROW == null) { i_Params_Get_Question_token_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Question_token_By_Criteria.END_ROW == null) || (i_Params_Get_Question_token_By_Criteria.END_ROW == 0)) { i_Params_Get_Question_token_By_Criteria.END_ROW = 1000000; }
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Criteria_Adv(i_Params_Get_Question_token_By_Criteria.PART,i_Params_Get_Question_token_By_Criteria.OWNER_ID,i_Params_Get_Question_token_By_Criteria.START_ROW,i_Params_Get_Question_token_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Criteria_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_Where_Adv(Params_Get_Question_token_By_Where i_Params_Get_Question_token_By_Where)
{
List<Question_token> oList = new List<Question_token>();
long? tmp_TOTAL_COUNT = 0;
Question_token oQuestion_token = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Question_token_By_Where.OWNER_ID == null) || (i_Params_Get_Question_token_By_Where.OWNER_ID == 0)) { i_Params_Get_Question_token_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Question_token_By_Where.START_ROW == null) { i_Params_Get_Question_token_By_Where.START_ROW = 0; }
if ((i_Params_Get_Question_token_By_Where.END_ROW == null) || (i_Params_Get_Question_token_By_Where.END_ROW == 0)) { i_Params_Get_Question_token_By_Where.END_ROW = 1000000; }
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Where_Adv(i_Params_Get_Question_token_By_Where.PART,i_Params_Get_Question_token_By_Where.OWNER_ID,i_Params_Get_Question_token_By_Where.START_ROW,i_Params_Get_Question_token_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Where_Adv");}
return oList;
}
public List<Student> Get_Student_By_Criteria_Adv(Params_Get_Student_By_Criteria i_Params_Get_Student_By_Criteria)
{
List<Student> oList = new List<Student>();
long? tmp_TOTAL_COUNT = 0;
Student oStudent = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Student_By_Criteria.OWNER_ID == null) || (i_Params_Get_Student_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Student_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_By_Criteria.START_ROW == null) { i_Params_Get_Student_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Student_By_Criteria.END_ROW == null) || (i_Params_Get_Student_By_Criteria.END_ROW == 0)) { i_Params_Get_Student_By_Criteria.END_ROW = 1000000; }
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Criteria_Adv(i_Params_Get_Student_By_Criteria.DESCRIPTION,i_Params_Get_Student_By_Criteria.OWNER_ID,i_Params_Get_Student_By_Criteria.START_ROW,i_Params_Get_Student_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Criteria_Adv");}
return oList;
}
public List<Student> Get_Student_By_Where_Adv(Params_Get_Student_By_Where i_Params_Get_Student_By_Where)
{
List<Student> oList = new List<Student>();
long? tmp_TOTAL_COUNT = 0;
Student oStudent = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Student_By_Where.OWNER_ID == null) || (i_Params_Get_Student_By_Where.OWNER_ID == 0)) { i_Params_Get_Student_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_By_Where.START_ROW == null) { i_Params_Get_Student_By_Where.START_ROW = 0; }
if ((i_Params_Get_Student_By_Where.END_ROW == null) || (i_Params_Get_Student_By_Where.END_ROW == 0)) { i_Params_Get_Student_By_Where.END_ROW = 1000000; }
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Where_Adv(i_Params_Get_Student_By_Where.DESCRIPTION,i_Params_Get_Student_By_Where.OWNER_ID,i_Params_Get_Student_By_Where.START_ROW,i_Params_Get_Student_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Where_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria_Adv(Params_Get_Student_report_By_Criteria i_Params_Get_Student_report_By_Criteria)
{
List<Student_report> oList = new List<Student_report>();
long? tmp_TOTAL_COUNT = 0;
Student_report oStudent_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Student_report_By_Criteria.OWNER_ID == null) || (i_Params_Get_Student_report_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Student_report_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_report_By_Criteria.START_ROW == null) { i_Params_Get_Student_report_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Student_report_By_Criteria.END_ROW == null) || (i_Params_Get_Student_report_By_Criteria.END_ROW == 0)) { i_Params_Get_Student_report_By_Criteria.END_ROW = 1000000; }
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Criteria_Adv(i_Params_Get_Student_report_By_Criteria.DESCRIPTION,i_Params_Get_Student_report_By_Criteria.OWNER_ID,i_Params_Get_Student_report_By_Criteria.START_ROW,i_Params_Get_Student_report_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Criteria_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_Where_Adv(Params_Get_Student_report_By_Where i_Params_Get_Student_report_By_Where)
{
List<Student_report> oList = new List<Student_report>();
long? tmp_TOTAL_COUNT = 0;
Student_report oStudent_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Student_report_By_Where.OWNER_ID == null) || (i_Params_Get_Student_report_By_Where.OWNER_ID == 0)) { i_Params_Get_Student_report_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Student_report_By_Where.START_ROW == null) { i_Params_Get_Student_report_By_Where.START_ROW = 0; }
if ((i_Params_Get_Student_report_By_Where.END_ROW == null) || (i_Params_Get_Student_report_By_Where.END_ROW == 0)) { i_Params_Get_Student_report_By_Where.END_ROW = 1000000; }
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Where_Adv(i_Params_Get_Student_report_By_Where.DESCRIPTION,i_Params_Get_Student_report_By_Where.OWNER_ID,i_Params_Get_Student_report_By_Where.START_ROW,i_Params_Get_Student_report_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Where_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria_Adv(Params_Get_Teacher_By_Criteria i_Params_Get_Teacher_By_Criteria)
{
List<Teacher> oList = new List<Teacher>();
long? tmp_TOTAL_COUNT = 0;
Teacher oTeacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Criteria_Adv(i_Params_Get_Teacher_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_By_Criteria.OWNER_ID,i_Params_Get_Teacher_By_Criteria.START_ROW,i_Params_Get_Teacher_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Criteria_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_Where_Adv(Params_Get_Teacher_By_Where i_Params_Get_Teacher_By_Where)
{
List<Teacher> oList = new List<Teacher>();
long? tmp_TOTAL_COUNT = 0;
Teacher oTeacher = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_By_Where.START_ROW == null) { i_Params_Get_Teacher_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_By_Where.END_ROW == null) || (i_Params_Get_Teacher_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_By_Where.END_ROW = 1000000; }
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Where_Adv(i_Params_Get_Teacher_By_Where.DESCRIPTION,i_Params_Get_Teacher_By_Where.OWNER_ID,i_Params_Get_Teacher_By_Where.START_ROW,i_Params_Get_Teacher_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Where_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria_Adv(Params_Get_Teacher_category_By_Criteria i_Params_Get_Teacher_category_By_Criteria)
{
List<Teacher_category> oList = new List<Teacher_category>();
long? tmp_TOTAL_COUNT = 0;
Teacher_category oTeacher_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_category_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_category_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_category_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_category_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Criteria_Adv(i_Params_Get_Teacher_category_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_category_By_Criteria.OWNER_ID,i_Params_Get_Teacher_category_By_Criteria.START_ROW,i_Params_Get_Teacher_category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Criteria_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where_Adv(Params_Get_Teacher_category_By_Where i_Params_Get_Teacher_category_By_Where)
{
List<Teacher_category> oList = new List<Teacher_category>();
long? tmp_TOTAL_COUNT = 0;
Teacher_category oTeacher_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_category_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_category_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_category_By_Where.START_ROW == null) { i_Params_Get_Teacher_category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_category_By_Where.END_ROW == null) || (i_Params_Get_Teacher_category_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_category_By_Where.END_ROW = 1000000; }
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Where_Adv(i_Params_Get_Teacher_category_By_Where.DESCRIPTION,i_Params_Get_Teacher_category_By_Where.OWNER_ID,i_Params_Get_Teacher_category_By_Where.START_ROW,i_Params_Get_Teacher_category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Where_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_Adv(Params_Get_Teacher_favorite_By_Criteria i_Params_Get_Teacher_favorite_By_Criteria)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
long? tmp_TOTAL_COUNT = 0;
Teacher_favorite oTeacher_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_favorite_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_favorite_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_favorite_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_favorite_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_favorite_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Criteria_Adv(i_Params_Get_Teacher_favorite_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Criteria.OWNER_ID,i_Params_Get_Teacher_favorite_By_Criteria.START_ROW,i_Params_Get_Teacher_favorite_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Criteria_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where_Adv(Params_Get_Teacher_favorite_By_Where i_Params_Get_Teacher_favorite_By_Where)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
long? tmp_TOTAL_COUNT = 0;
Teacher_favorite oTeacher_favorite = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_favorite_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_favorite_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_favorite_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_favorite_By_Where.START_ROW == null) { i_Params_Get_Teacher_favorite_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_favorite_By_Where.END_ROW == null) || (i_Params_Get_Teacher_favorite_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_favorite_By_Where.END_ROW = 1000000; }
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Where_Adv(i_Params_Get_Teacher_favorite_By_Where.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Where.OWNER_ID,i_Params_Get_Teacher_favorite_By_Where.START_ROW,i_Params_Get_Teacher_favorite_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Where_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria_Adv(Params_Get_Teacher_report_By_Criteria i_Params_Get_Teacher_report_By_Criteria)
{
List<Teacher_report> oList = new List<Teacher_report>();
long? tmp_TOTAL_COUNT = 0;
Teacher_report oTeacher_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_report_By_Criteria.OWNER_ID == null) || (i_Params_Get_Teacher_report_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Teacher_report_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_report_By_Criteria.START_ROW == null) { i_Params_Get_Teacher_report_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Teacher_report_By_Criteria.END_ROW == null) || (i_Params_Get_Teacher_report_By_Criteria.END_ROW == 0)) { i_Params_Get_Teacher_report_By_Criteria.END_ROW = 1000000; }
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Criteria_Adv(i_Params_Get_Teacher_report_By_Criteria.DESCRIPTION,i_Params_Get_Teacher_report_By_Criteria.OWNER_ID,i_Params_Get_Teacher_report_By_Criteria.START_ROW,i_Params_Get_Teacher_report_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Criteria_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where_Adv(Params_Get_Teacher_report_By_Where i_Params_Get_Teacher_report_By_Where)
{
List<Teacher_report> oList = new List<Teacher_report>();
long? tmp_TOTAL_COUNT = 0;
Teacher_report oTeacher_report = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Teacher_report_By_Where.OWNER_ID == null) || (i_Params_Get_Teacher_report_By_Where.OWNER_ID == 0)) { i_Params_Get_Teacher_report_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Teacher_report_By_Where.START_ROW == null) { i_Params_Get_Teacher_report_By_Where.START_ROW = 0; }
if ((i_Params_Get_Teacher_report_By_Where.END_ROW == null) || (i_Params_Get_Teacher_report_By_Where.END_ROW == 0)) { i_Params_Get_Teacher_report_By_Where.END_ROW = 1000000; }
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Where_Adv(i_Params_Get_Teacher_report_By_Where.DESCRIPTION,i_Params_Get_Teacher_report_By_Where.OWNER_ID,i_Params_Get_Teacher_report_By_Where.START_ROW,i_Params_Get_Teacher_report_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Where_Adv");}
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.EMAIL,i_Params_Get_User_By_Criteria.FIRST_NAME,i_Params_Get_User_By_Criteria.LAST_NAME,i_Params_Get_User_By_Criteria.MOBILE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.EMAIL,i_Params_Get_User_By_Where.FIRST_NAME,i_Params_Get_User_By_Where.LAST_NAME,i_Params_Get_User_By_Where.MOBILE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv_V2(Params_Get_User_By_Criteria_V2 i_Params_Get_User_By_Criteria_V2)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_User_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria_V2.START_ROW == null) { i_Params_Get_User_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria_V2.END_ROW == null) || (i_Params_Get_User_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_User_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv_V2(i_Params_Get_User_By_Criteria_V2.USERNAME,i_Params_Get_User_By_Criteria_V2.PASSWORD,i_Params_Get_User_By_Criteria_V2.EMAIL,i_Params_Get_User_By_Criteria_V2.FIRST_NAME,i_Params_Get_User_By_Criteria_V2.LAST_NAME,i_Params_Get_User_By_Criteria_V2.MOBILE,i_Params_Get_User_By_Criteria_V2.DOB,i_Params_Get_User_By_Criteria_V2.OWNER_ID,i_Params_Get_User_By_Criteria_V2.START_ROW,i_Params_Get_User_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv_V2");}
return oList;
}
public List<User> Get_User_By_Where_Adv_V2(Params_Get_User_By_Where_V2 i_Params_Get_User_By_Where_V2)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_User_By_Where_V2.OWNER_ID == null) || (i_Params_Get_User_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_User_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where_V2.START_ROW == null) { i_Params_Get_User_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_User_By_Where_V2.END_ROW == null) || (i_Params_Get_User_By_Where_V2.END_ROW == 0)) { i_Params_Get_User_By_Where_V2.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv_V2(i_Params_Get_User_By_Where_V2.USERNAME,i_Params_Get_User_By_Where_V2.PASSWORD,i_Params_Get_User_By_Where_V2.EMAIL,i_Params_Get_User_By_Where_V2.FIRST_NAME,i_Params_Get_User_By_Where_V2.LAST_NAME,i_Params_Get_User_By_Where_V2.MOBILE,i_Params_Get_User_By_Where_V2.DOB,i_Params_Get_User_By_Where_V2.OWNER_ID,i_Params_Get_User_By_Where_V2.START_ROW,i_Params_Get_User_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv_V2");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_Criteria_Adv(Params_Get_User_type_code_By_Criteria i_Params_Get_User_type_code_By_Criteria)
{
List<User_type_code> oList = new List<User_type_code>();
long? tmp_TOTAL_COUNT = 0;
User_type_code oUser_type_code = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_type_code_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_type_code_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_type_code_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_type_code_By_Criteria.START_ROW == null) { i_Params_Get_User_type_code_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_type_code_By_Criteria.END_ROW == null) || (i_Params_Get_User_type_code_By_Criteria.END_ROW == 0)) { i_Params_Get_User_type_code_By_Criteria.END_ROW = 1000000; }
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_Criteria_Adv(i_Params_Get_User_type_code_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_type_code_By_Criteria.DESCRIPTION,i_Params_Get_User_type_code_By_Criteria.OWNER_ID,i_Params_Get_User_type_code_By_Criteria.START_ROW,i_Params_Get_User_type_code_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_Criteria_Adv");}
return oList;
}
public List<User_type_code> Get_User_type_code_By_Where_Adv(Params_Get_User_type_code_By_Where i_Params_Get_User_type_code_By_Where)
{
List<User_type_code> oList = new List<User_type_code>();
long? tmp_TOTAL_COUNT = 0;
User_type_code oUser_type_code = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_type_code_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_type_code_By_Where.OWNER_ID == null) || (i_Params_Get_User_type_code_By_Where.OWNER_ID == 0)) { i_Params_Get_User_type_code_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_type_code_By_Where.START_ROW == null) { i_Params_Get_User_type_code_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_type_code_By_Where.END_ROW == null) || (i_Params_Get_User_type_code_By_Where.END_ROW == 0)) { i_Params_Get_User_type_code_By_Where.END_ROW = 1000000; }
List<DALC.User_type_code> oList_DBEntries = _AppContext.Get_User_type_code_By_Where_Adv(i_Params_Get_User_type_code_By_Where.USER_TYPE_CODE,i_Params_Get_User_type_code_By_Where.DESCRIPTION,i_Params_Get_User_type_code_By_Where.OWNER_ID,i_Params_Get_User_type_code_By_Where.START_ROW,i_Params_Get_User_type_code_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_type_code_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv_V2");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv_V2");}
return oList;
}
public List<Answer> Get_Answer_By_Criteria_InList_Adv(Params_Get_Answer_By_Criteria_InList i_Params_Get_Answer_By_Criteria_InList)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Answer_By_Criteria_InList_SP oParams_Get_Answer_By_Criteria_InList_SP = new Params_Get_Answer_By_Criteria_InList_SP();
Params_Get_Question_By_QUESTION_ID oParams_Get_Question_By_QUESTION_ID = new Params_Get_Question_By_QUESTION_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Criteria_InList_Adv");}
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
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Criteria_InList_Adv(i_Params_Get_Answer_By_Criteria_InList.DESCRIPTION,i_Params_Get_Answer_By_Criteria_InList.QUESTION_ID_LIST,i_Params_Get_Answer_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Answer_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Answer_By_Criteria_InList.OWNER_ID,i_Params_Get_Answer_By_Criteria_InList.START_ROW,i_Params_Get_Answer_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Answer_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Answer_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Criteria_InList_Adv");}
return oList;
}
public List<Answer> Get_Answer_By_Where_InList_Adv(Params_Get_Answer_By_Where_InList i_Params_Get_Answer_By_Where_InList)
{
List<Answer> oList = new List<Answer>();
Answer oAnswer = new Answer();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Answer_By_Where_InList_SP oParams_Get_Answer_By_Where_InList_SP = new Params_Get_Answer_By_Where_InList_SP();
Params_Get_Question_By_QUESTION_ID oParams_Get_Question_By_QUESTION_ID = new Params_Get_Question_By_QUESTION_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Answer_By_Where_InList_Adv");}
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
List<DALC.Answer> oList_DBEntries = _AppContext.Get_Answer_By_Where_InList_Adv(i_Params_Get_Answer_By_Where_InList.DESCRIPTION,i_Params_Get_Answer_By_Where_InList.QUESTION_ID_LIST,i_Params_Get_Answer_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Answer_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Answer_By_Where_InList.OWNER_ID,i_Params_Get_Answer_By_Where_InList.START_ROW,i_Params_Get_Answer_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAnswer = new Answer();
oTools.CopyPropValues(oDBEntry, oAnswer);
oAnswer.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oAnswer.My_Question);
oAnswer.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oAnswer.My_Teacher);
oAnswer.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oAnswer.My_Student);
oList.Add(oAnswer);
}
}
i_Params_Get_Answer_By_Where_InList.TOTAL_COUNT = oParams_Get_Answer_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Answer_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Answer_By_Where_InList_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria_InList_Adv(Params_Get_Category_favorite_By_Criteria_InList i_Params_Get_Category_favorite_By_Criteria_InList)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Category_favorite_By_Criteria_InList_SP oParams_Get_Category_favorite_By_Criteria_InList_SP = new Params_Get_Category_favorite_By_Criteria_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Criteria_InList_Adv");}
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
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Criteria_InList_Adv(i_Params_Get_Category_favorite_By_Criteria_InList.DESCRIPTION,i_Params_Get_Category_favorite_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Category_favorite_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Category_favorite_By_Criteria_InList.OWNER_ID,i_Params_Get_Category_favorite_By_Criteria_InList.START_ROW,i_Params_Get_Category_favorite_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Category_favorite_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Category_favorite_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Criteria_InList_Adv");}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where_InList_Adv(Params_Get_Category_favorite_By_Where_InList i_Params_Get_Category_favorite_By_Where_InList)
{
List<Category_favorite> oList = new List<Category_favorite>();
Category_favorite oCategory_favorite = new Category_favorite();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Category_favorite_By_Where_InList_SP oParams_Get_Category_favorite_By_Where_InList_SP = new Params_Get_Category_favorite_By_Where_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_favorite_By_Where_InList_Adv");}
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
List<DALC.Category_favorite> oList_DBEntries = _AppContext.Get_Category_favorite_By_Where_InList_Adv(i_Params_Get_Category_favorite_By_Where_InList.DESCRIPTION,i_Params_Get_Category_favorite_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Category_favorite_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Category_favorite_By_Where_InList.OWNER_ID,i_Params_Get_Category_favorite_By_Where_InList.START_ROW,i_Params_Get_Category_favorite_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory_favorite = new Category_favorite();
oTools.CopyPropValues(oDBEntry, oCategory_favorite);
oCategory_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oCategory_favorite.My_Student);
oCategory_favorite.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oCategory_favorite.My_Category);
oList.Add(oCategory_favorite);
}
}
i_Params_Get_Category_favorite_By_Where_InList.TOTAL_COUNT = oParams_Get_Category_favorite_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Category_favorite_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_favorite_By_Where_InList_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList_Adv");}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList_Adv(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList_Adv");}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList_Adv(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria_InList_Adv(Params_Get_Evaluation_By_Criteria_InList i_Params_Get_Evaluation_By_Criteria_InList)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Evaluation_By_Criteria_InList_SP oParams_Get_Evaluation_By_Criteria_InList_SP = new Params_Get_Evaluation_By_Criteria_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Answer_By_ANSWER_ID oParams_Get_Answer_By_ANSWER_ID = new Params_Get_Answer_By_ANSWER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Criteria_InList_Adv");}
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
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Criteria_InList_Adv(i_Params_Get_Evaluation_By_Criteria_InList.DESCRIPTION,i_Params_Get_Evaluation_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Evaluation_By_Criteria_InList.ANSWER_ID_LIST,i_Params_Get_Evaluation_By_Criteria_InList.OWNER_ID,i_Params_Get_Evaluation_By_Criteria_InList.START_ROW,i_Params_Get_Evaluation_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Evaluation_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Evaluation_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Criteria_InList_Adv");}
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where_InList_Adv(Params_Get_Evaluation_By_Where_InList i_Params_Get_Evaluation_By_Where_InList)
{
List<Evaluation> oList = new List<Evaluation>();
Evaluation oEvaluation = new Evaluation();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Evaluation_By_Where_InList_SP oParams_Get_Evaluation_By_Where_InList_SP = new Params_Get_Evaluation_By_Where_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Answer_By_ANSWER_ID oParams_Get_Answer_By_ANSWER_ID = new Params_Get_Answer_By_ANSWER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Evaluation_By_Where_InList_Adv");}
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
List<DALC.Evaluation> oList_DBEntries = _AppContext.Get_Evaluation_By_Where_InList_Adv(i_Params_Get_Evaluation_By_Where_InList.DESCRIPTION,i_Params_Get_Evaluation_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Evaluation_By_Where_InList.ANSWER_ID_LIST,i_Params_Get_Evaluation_By_Where_InList.OWNER_ID,i_Params_Get_Evaluation_By_Where_InList.START_ROW,i_Params_Get_Evaluation_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oEvaluation = new Evaluation();
oTools.CopyPropValues(oDBEntry, oEvaluation);
oEvaluation.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oEvaluation.My_Student);
oEvaluation.My_Answer = new Answer();
oTools.CopyPropValues(oDBEntry.My_Answer, oEvaluation.My_Answer);
oList.Add(oEvaluation);
}
}
i_Params_Get_Evaluation_By_Where_InList.TOTAL_COUNT = oParams_Get_Evaluation_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Evaluation_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Evaluation_By_Where_InList_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_InList_Adv(Params_Get_Favorite_teacher_By_Criteria_InList i_Params_Get_Favorite_teacher_By_Criteria_InList)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Favorite_teacher_By_Criteria_InList_SP oParams_Get_Favorite_teacher_By_Criteria_InList_SP = new Params_Get_Favorite_teacher_By_Criteria_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Criteria_InList_Adv");}
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
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Criteria_InList_Adv(i_Params_Get_Favorite_teacher_By_Criteria_InList.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Favorite_teacher_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Favorite_teacher_By_Criteria_InList.OWNER_ID,i_Params_Get_Favorite_teacher_By_Criteria_InList.START_ROW,i_Params_Get_Favorite_teacher_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Favorite_teacher_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Favorite_teacher_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Criteria_InList_Adv");}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where_InList_Adv(Params_Get_Favorite_teacher_By_Where_InList i_Params_Get_Favorite_teacher_By_Where_InList)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Favorite_teacher_By_Where_InList_SP oParams_Get_Favorite_teacher_By_Where_InList_SP = new Params_Get_Favorite_teacher_By_Where_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Favorite_teacher_By_Where_InList_Adv");}
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
List<DALC.Favorite_teacher> oList_DBEntries = _AppContext.Get_Favorite_teacher_By_Where_InList_Adv(i_Params_Get_Favorite_teacher_By_Where_InList.DESCRIPTION,i_Params_Get_Favorite_teacher_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Favorite_teacher_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Favorite_teacher_By_Where_InList.OWNER_ID,i_Params_Get_Favorite_teacher_By_Where_InList.START_ROW,i_Params_Get_Favorite_teacher_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFavorite_teacher = new Favorite_teacher();
oTools.CopyPropValues(oDBEntry, oFavorite_teacher);
oFavorite_teacher.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oFavorite_teacher.My_Student);
oFavorite_teacher.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oFavorite_teacher.My_Teacher);
oList.Add(oFavorite_teacher);
}
}
i_Params_Get_Favorite_teacher_By_Where_InList.TOTAL_COUNT = oParams_Get_Favorite_teacher_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Favorite_teacher_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Favorite_teacher_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList_Adv(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList_Adv(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList_Adv(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList_Adv(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList_Adv(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList_Adv(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
return oList;
}
public List<Question> Get_Question_By_Criteria_InList_Adv(Params_Get_Question_By_Criteria_InList i_Params_Get_Question_By_Criteria_InList)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Question_By_Criteria_InList_SP oParams_Get_Question_By_Criteria_InList_SP = new Params_Get_Question_By_Criteria_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Criteria_InList_Adv");}
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
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Criteria_InList_Adv(i_Params_Get_Question_By_Criteria_InList.DESCRIPTION,i_Params_Get_Question_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Question_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Question_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Question_By_Criteria_InList.OWNER_ID,i_Params_Get_Question_By_Criteria_InList.START_ROW,i_Params_Get_Question_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Question_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Criteria_InList_Adv");}
return oList;
}
public List<Question> Get_Question_By_Where_InList_Adv(Params_Get_Question_By_Where_InList i_Params_Get_Question_By_Where_InList)
{
List<Question> oList = new List<Question>();
Question oQuestion = new Question();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Question_By_Where_InList_SP oParams_Get_Question_By_Where_InList_SP = new Params_Get_Question_By_Where_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_By_Where_InList_Adv");}
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
List<DALC.Question> oList_DBEntries = _AppContext.Get_Question_By_Where_InList_Adv(i_Params_Get_Question_By_Where_InList.DESCRIPTION,i_Params_Get_Question_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Question_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Question_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Question_By_Where_InList.OWNER_ID,i_Params_Get_Question_By_Where_InList.START_ROW,i_Params_Get_Question_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion = new Question();
oTools.CopyPropValues(oDBEntry, oQuestion);
oQuestion.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oQuestion.My_Student);
oQuestion.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oQuestion.My_Category);
oQuestion.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oQuestion.My_Teacher);
oList.Add(oQuestion);
}
}
i_Params_Get_Question_By_Where_InList.TOTAL_COUNT = oParams_Get_Question_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_By_Where_InList_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria_InList_Adv(Params_Get_Question_token_By_Criteria_InList i_Params_Get_Question_token_By_Criteria_InList)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Question_token_By_Criteria_InList_SP oParams_Get_Question_token_By_Criteria_InList_SP = new Params_Get_Question_token_By_Criteria_InList_SP();
Params_Get_Question_By_QUESTION_ID oParams_Get_Question_By_QUESTION_ID = new Params_Get_Question_By_QUESTION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Criteria_InList_Adv");}
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
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Criteria_InList_Adv(i_Params_Get_Question_token_By_Criteria_InList.PART,i_Params_Get_Question_token_By_Criteria_InList.QUESTION_ID_LIST,i_Params_Get_Question_token_By_Criteria_InList.OWNER_ID,i_Params_Get_Question_token_By_Criteria_InList.START_ROW,i_Params_Get_Question_token_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Question_token_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_token_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Criteria_InList_Adv");}
return oList;
}
public List<Question_token> Get_Question_token_By_Where_InList_Adv(Params_Get_Question_token_By_Where_InList i_Params_Get_Question_token_By_Where_InList)
{
List<Question_token> oList = new List<Question_token>();
Question_token oQuestion_token = new Question_token();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Question_token_By_Where_InList_SP oParams_Get_Question_token_By_Where_InList_SP = new Params_Get_Question_token_By_Where_InList_SP();
Params_Get_Question_By_QUESTION_ID oParams_Get_Question_By_QUESTION_ID = new Params_Get_Question_By_QUESTION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Question_token_By_Where_InList_Adv");}
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
List<DALC.Question_token> oList_DBEntries = _AppContext.Get_Question_token_By_Where_InList_Adv(i_Params_Get_Question_token_By_Where_InList.PART,i_Params_Get_Question_token_By_Where_InList.QUESTION_ID_LIST,i_Params_Get_Question_token_By_Where_InList.OWNER_ID,i_Params_Get_Question_token_By_Where_InList.START_ROW,i_Params_Get_Question_token_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oQuestion_token = new Question_token();
oTools.CopyPropValues(oDBEntry, oQuestion_token);
oQuestion_token.My_Question = new Question();
oTools.CopyPropValues(oDBEntry.My_Question, oQuestion_token.My_Question);
oList.Add(oQuestion_token);
}
}
i_Params_Get_Question_token_By_Where_InList.TOTAL_COUNT = oParams_Get_Question_token_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Question_token_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Question_token_By_Where_InList_Adv");}
return oList;
}
public List<Student> Get_Student_By_Criteria_InList_Adv(Params_Get_Student_By_Criteria_InList i_Params_Get_Student_By_Criteria_InList)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Student_By_Criteria_InList_SP oParams_Get_Student_By_Criteria_InList_SP = new Params_Get_Student_By_Criteria_InList_SP();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Criteria_InList_Adv");}
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
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Criteria_InList_Adv(i_Params_Get_Student_By_Criteria_InList.DESCRIPTION,i_Params_Get_Student_By_Criteria_InList.USER_ID_LIST,i_Params_Get_Student_By_Criteria_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Student_By_Criteria_InList.OWNER_ID,i_Params_Get_Student_By_Criteria_InList.START_ROW,i_Params_Get_Student_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Student_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Criteria_InList_Adv");}
return oList;
}
public List<Student> Get_Student_By_Where_InList_Adv(Params_Get_Student_By_Where_InList i_Params_Get_Student_By_Where_InList)
{
List<Student> oList = new List<Student>();
Student oStudent = new Student();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Student_By_Where_InList_SP oParams_Get_Student_By_Where_InList_SP = new Params_Get_Student_By_Where_InList_SP();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_By_Where_InList_Adv");}
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
List<DALC.Student> oList_DBEntries = _AppContext.Get_Student_By_Where_InList_Adv(i_Params_Get_Student_By_Where_InList.DESCRIPTION,i_Params_Get_Student_By_Where_InList.USER_ID_LIST,i_Params_Get_Student_By_Where_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Student_By_Where_InList.OWNER_ID,i_Params_Get_Student_By_Where_InList.START_ROW,i_Params_Get_Student_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent = new Student();
oTools.CopyPropValues(oDBEntry, oStudent);
oStudent.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oStudent.My_User);
oStudent.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oStudent.My_User_type_code);
oList.Add(oStudent);
}
}
i_Params_Get_Student_By_Where_InList.TOTAL_COUNT = oParams_Get_Student_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_By_Where_InList_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria_InList_Adv(Params_Get_Student_report_By_Criteria_InList i_Params_Get_Student_report_By_Criteria_InList)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Student_report_By_Criteria_InList_SP oParams_Get_Student_report_By_Criteria_InList_SP = new Params_Get_Student_report_By_Criteria_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_REPORTED_BY_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_REPORTED_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Criteria_InList_Adv");}
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
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Criteria_InList_Adv(i_Params_Get_Student_report_By_Criteria_InList.DESCRIPTION,i_Params_Get_Student_report_By_Criteria_InList.REPORTED_BY_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Criteria_InList.REPORTED_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Criteria_InList.OWNER_ID,i_Params_Get_Student_report_By_Criteria_InList.START_ROW,i_Params_Get_Student_report_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Student_report_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_report_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Criteria_InList_Adv");}
return oList;
}
public List<Student_report> Get_Student_report_By_Where_InList_Adv(Params_Get_Student_report_By_Where_InList i_Params_Get_Student_report_By_Where_InList)
{
List<Student_report> oList = new List<Student_report>();
Student_report oStudent_report = new Student_report();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Student_report_By_Where_InList_SP oParams_Get_Student_report_By_Where_InList_SP = new Params_Get_Student_report_By_Where_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_REPORTED_BY_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_REPORTED_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Student_report_By_Where_InList_Adv");}
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
List<DALC.Student_report> oList_DBEntries = _AppContext.Get_Student_report_By_Where_InList_Adv(i_Params_Get_Student_report_By_Where_InList.DESCRIPTION,i_Params_Get_Student_report_By_Where_InList.REPORTED_BY_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Where_InList.REPORTED_STUDENT_ID_LIST,i_Params_Get_Student_report_By_Where_InList.OWNER_ID,i_Params_Get_Student_report_By_Where_InList.START_ROW,i_Params_Get_Student_report_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStudent_report = new Student_report();
oTools.CopyPropValues(oDBEntry, oStudent_report);
oStudent_report.My_Reported_by_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_by_student, oStudent_report.My_Reported_by_student);
oStudent_report.My_Reported_student = new Student();
oTools.CopyPropValues(oDBEntry.My_Reported_student, oStudent_report.My_Reported_student);
oList.Add(oStudent_report);
}
}
i_Params_Get_Student_report_By_Where_InList.TOTAL_COUNT = oParams_Get_Student_report_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Student_report_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Student_report_By_Where_InList_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria_InList_Adv(Params_Get_Teacher_By_Criteria_InList i_Params_Get_Teacher_By_Criteria_InList)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_By_Criteria_InList_SP oParams_Get_Teacher_By_Criteria_InList_SP = new Params_Get_Teacher_By_Criteria_InList_SP();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Criteria_InList_Adv");}
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
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Criteria_InList_Adv(i_Params_Get_Teacher_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_By_Criteria_InList.USER_ID_LIST,i_Params_Get_Teacher_By_Criteria_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Teacher_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Criteria_InList_Adv");}
return oList;
}
public List<Teacher> Get_Teacher_By_Where_InList_Adv(Params_Get_Teacher_By_Where_InList i_Params_Get_Teacher_By_Where_InList)
{
List<Teacher> oList = new List<Teacher>();
Teacher oTeacher = new Teacher();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_By_Where_InList_SP oParams_Get_Teacher_By_Where_InList_SP = new Params_Get_Teacher_By_Where_InList_SP();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_By_Where_InList_Adv");}
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
List<DALC.Teacher> oList_DBEntries = _AppContext.Get_Teacher_By_Where_InList_Adv(i_Params_Get_Teacher_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_By_Where_InList.USER_ID_LIST,i_Params_Get_Teacher_By_Where_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_Teacher_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_By_Where_InList.START_ROW,i_Params_Get_Teacher_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher = new Teacher();
oTools.CopyPropValues(oDBEntry, oTeacher);
oTeacher.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oTeacher.My_User);
oTeacher.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oTeacher.My_User_type_code);
oTeacher.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher.My_Category);
oList.Add(oTeacher);
}
}
i_Params_Get_Teacher_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_By_Where_InList_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria_InList_Adv(Params_Get_Teacher_category_By_Criteria_InList i_Params_Get_Teacher_category_By_Criteria_InList)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_category_By_Criteria_InList_SP oParams_Get_Teacher_category_By_Criteria_InList_SP = new Params_Get_Teacher_category_By_Criteria_InList_SP();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Criteria_InList_Adv");}
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
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Criteria_InList_Adv(i_Params_Get_Teacher_category_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_category_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_category_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_category_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_category_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_category_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_category_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_category_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Criteria_InList_Adv");}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where_InList_Adv(Params_Get_Teacher_category_By_Where_InList i_Params_Get_Teacher_category_By_Where_InList)
{
List<Teacher_category> oList = new List<Teacher_category>();
Teacher_category oTeacher_category = new Teacher_category();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_category_By_Where_InList_SP oParams_Get_Teacher_category_By_Where_InList_SP = new Params_Get_Teacher_category_By_Where_InList_SP();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_category_By_Where_InList_Adv");}
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
List<DALC.Teacher_category> oList_DBEntries = _AppContext.Get_Teacher_category_By_Where_InList_Adv(i_Params_Get_Teacher_category_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_category_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_category_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Teacher_category_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_category_By_Where_InList.START_ROW,i_Params_Get_Teacher_category_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_category = new Teacher_category();
oTools.CopyPropValues(oDBEntry, oTeacher_category);
oTeacher_category.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_category.My_Teacher);
oTeacher_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oTeacher_category.My_Category);
oList.Add(oTeacher_category);
}
}
i_Params_Get_Teacher_category_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_category_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_category_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_category_By_Where_InList_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_InList_Adv(Params_Get_Teacher_favorite_By_Criteria_InList i_Params_Get_Teacher_favorite_By_Criteria_InList)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_favorite_By_Criteria_InList_SP oParams_Get_Teacher_favorite_By_Criteria_InList_SP = new Params_Get_Teacher_favorite_By_Criteria_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Criteria_InList_Adv");}
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
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Criteria_InList_Adv(i_Params_Get_Teacher_favorite_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_favorite_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_favorite_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_favorite_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_favorite_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_favorite_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_favorite_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Criteria_InList_Adv");}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where_InList_Adv(Params_Get_Teacher_favorite_By_Where_InList i_Params_Get_Teacher_favorite_By_Where_InList)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_favorite_By_Where_InList_SP oParams_Get_Teacher_favorite_By_Where_InList_SP = new Params_Get_Teacher_favorite_By_Where_InList_SP();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_favorite_By_Where_InList_Adv");}
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
List<DALC.Teacher_favorite> oList_DBEntries = _AppContext.Get_Teacher_favorite_By_Where_InList_Adv(i_Params_Get_Teacher_favorite_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_favorite_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_favorite_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_favorite_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_favorite_By_Where_InList.START_ROW,i_Params_Get_Teacher_favorite_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_favorite = new Teacher_favorite();
oTools.CopyPropValues(oDBEntry, oTeacher_favorite);
oTeacher_favorite.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_favorite.My_Student);
oTeacher_favorite.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_favorite.My_Teacher);
oList.Add(oTeacher_favorite);
}
}
i_Params_Get_Teacher_favorite_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_favorite_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_favorite_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_favorite_By_Where_InList_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria_InList_Adv(Params_Get_Teacher_report_By_Criteria_InList i_Params_Get_Teacher_report_By_Criteria_InList)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_report_By_Criteria_InList_SP oParams_Get_Teacher_report_By_Criteria_InList_SP = new Params_Get_Teacher_report_By_Criteria_InList_SP();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Criteria_InList_Adv");}
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
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Criteria_InList_Adv(i_Params_Get_Teacher_report_By_Criteria_InList.DESCRIPTION,i_Params_Get_Teacher_report_By_Criteria_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_report_By_Criteria_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_report_By_Criteria_InList.OWNER_ID,i_Params_Get_Teacher_report_By_Criteria_InList.START_ROW,i_Params_Get_Teacher_report_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Teacher_report_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_report_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Criteria_InList_Adv");}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where_InList_Adv(Params_Get_Teacher_report_By_Where_InList i_Params_Get_Teacher_report_By_Where_InList)
{
List<Teacher_report> oList = new List<Teacher_report>();
Teacher_report oTeacher_report = new Teacher_report();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Teacher_report_By_Where_InList_SP oParams_Get_Teacher_report_By_Where_InList_SP = new Params_Get_Teacher_report_By_Where_InList_SP();
Params_Get_Teacher_By_TEACHER_ID oParams_Get_Teacher_By_TEACHER_ID = new Params_Get_Teacher_By_TEACHER_ID();
Params_Get_Student_By_STUDENT_ID oParams_Get_Student_By_STUDENT_ID = new Params_Get_Student_By_STUDENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Teacher_report_By_Where_InList_Adv");}
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
List<DALC.Teacher_report> oList_DBEntries = _AppContext.Get_Teacher_report_By_Where_InList_Adv(i_Params_Get_Teacher_report_By_Where_InList.DESCRIPTION,i_Params_Get_Teacher_report_By_Where_InList.TEACHER_ID_LIST,i_Params_Get_Teacher_report_By_Where_InList.STUDENT_ID_LIST,i_Params_Get_Teacher_report_By_Where_InList.OWNER_ID,i_Params_Get_Teacher_report_By_Where_InList.START_ROW,i_Params_Get_Teacher_report_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeacher_report = new Teacher_report();
oTools.CopyPropValues(oDBEntry, oTeacher_report);
oTeacher_report.My_Teacher = new Teacher();
oTools.CopyPropValues(oDBEntry.My_Teacher, oTeacher_report.My_Teacher);
oTeacher_report.My_Student = new Student();
oTools.CopyPropValues(oDBEntry.My_Student, oTeacher_report.My_Student);
oList.Add(oTeacher_report);
}
}
i_Params_Get_Teacher_report_By_Where_InList.TOTAL_COUNT = oParams_Get_Teacher_report_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Teacher_report_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Teacher_report_By_Where_InList_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_InList_Adv(Params_Get_User_By_Criteria_InList i_Params_Get_User_By_Criteria_InList)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_User_By_Criteria_InList_SP oParams_Get_User_By_Criteria_InList_SP = new Params_Get_User_By_Criteria_InList_SP();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_InList_Adv");}
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_InList_Adv(i_Params_Get_User_By_Criteria_InList.USERNAME,i_Params_Get_User_By_Criteria_InList.PASSWORD,i_Params_Get_User_By_Criteria_InList.EMAIL,i_Params_Get_User_By_Criteria_InList.FIRST_NAME,i_Params_Get_User_By_Criteria_InList.LAST_NAME,i_Params_Get_User_By_Criteria_InList.MOBILE,i_Params_Get_User_By_Criteria_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Criteria_InList.OWNER_ID,i_Params_Get_User_By_Criteria_InList.START_ROW,i_Params_Get_User_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria_InList.TOTAL_COUNT = oParams_Get_User_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_User_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_InList_Adv");}
return oList;
}
public List<User> Get_User_By_Where_InList_Adv(Params_Get_User_By_Where_InList i_Params_Get_User_By_Where_InList)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_User_By_Where_InList_SP oParams_Get_User_By_Where_InList_SP = new Params_Get_User_By_Where_InList_SP();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_InList_Adv");}
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_InList_Adv(i_Params_Get_User_By_Where_InList.USERNAME,i_Params_Get_User_By_Where_InList.PASSWORD,i_Params_Get_User_By_Where_InList.EMAIL,i_Params_Get_User_By_Where_InList.FIRST_NAME,i_Params_Get_User_By_Where_InList.LAST_NAME,i_Params_Get_User_By_Where_InList.MOBILE,i_Params_Get_User_By_Where_InList.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Where_InList.OWNER_ID,i_Params_Get_User_By_Where_InList.START_ROW,i_Params_Get_User_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where_InList.TOTAL_COUNT = oParams_Get_User_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_User_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_InList_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_InList_Adv_V2(Params_Get_User_By_Criteria_InList_V2 i_Params_Get_User_By_Criteria_InList_V2)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_User_By_Criteria_InList_SP_V2 oParams_Get_User_By_Criteria_InList_SP_V2 = new Params_Get_User_By_Criteria_InList_SP_V2();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_InList_Adv_V2");}
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_InList_Adv_V2(i_Params_Get_User_By_Criteria_InList_V2.USERNAME,i_Params_Get_User_By_Criteria_InList_V2.PASSWORD,i_Params_Get_User_By_Criteria_InList_V2.EMAIL,i_Params_Get_User_By_Criteria_InList_V2.FIRST_NAME,i_Params_Get_User_By_Criteria_InList_V2.LAST_NAME,i_Params_Get_User_By_Criteria_InList_V2.MOBILE,i_Params_Get_User_By_Criteria_InList_V2.DOB,i_Params_Get_User_By_Criteria_InList_V2.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_User_By_Criteria_InList_V2.START_ROW,i_Params_Get_User_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_User_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_User_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<User> Get_User_By_Where_InList_Adv_V2(Params_Get_User_By_Where_InList_V2 i_Params_Get_User_By_Where_InList_V2)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_User_By_Where_InList_SP_V2 oParams_Get_User_By_Where_InList_SP_V2 = new Params_Get_User_By_Where_InList_SP_V2();
Params_Get_User_type_code_By_USER_TYPE_CODE_ID oParams_Get_User_type_code_By_USER_TYPE_CODE_ID = new Params_Get_User_type_code_By_USER_TYPE_CODE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_InList_Adv_V2");}
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
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_InList_Adv_V2(i_Params_Get_User_By_Where_InList_V2.USERNAME,i_Params_Get_User_By_Where_InList_V2.PASSWORD,i_Params_Get_User_By_Where_InList_V2.EMAIL,i_Params_Get_User_By_Where_InList_V2.FIRST_NAME,i_Params_Get_User_By_Where_InList_V2.LAST_NAME,i_Params_Get_User_By_Where_InList_V2.MOBILE,i_Params_Get_User_By_Where_InList_V2.DOB,i_Params_Get_User_By_Where_InList_V2.USER_TYPE_CODE_ID_LIST,i_Params_Get_User_By_Where_InList_V2.OWNER_ID,i_Params_Get_User_By_Where_InList_V2.START_ROW,i_Params_Get_User_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oUser.My_User_type_code = new User_type_code();
oTools.CopyPropValues(oDBEntry.My_User_type_code, oUser.My_User_type_code);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_User_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_User_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_InList_Adv_V2");}
return oList;
}
}
}
