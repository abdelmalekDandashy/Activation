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
#region Reset_Evaluation_By_Answer
public void Reset_Evaluation_By_Answer(Answer i_Answer, List<Evaluation> i_Evaluation_List)
{
#region Declaration And Initialization Section.
Params_Delete_Evaluation_By_ANSWER_ID oParams_Delete_Evaluation_By_ANSWER_ID = new Params_Delete_Evaluation_By_ANSWER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Evaluation_By_Answer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Evaluation
//---------------------------------
oParams_Delete_Evaluation_By_ANSWER_ID.ANSWER_ID = i_Answer.ANSWER_ID;
Delete_Evaluation_By_ANSWER_ID(oParams_Delete_Evaluation_By_ANSWER_ID);
//---------------------------------
// Edit Evaluation
//---------------------------------
Edit_Answer_WithEvaluation(i_Answer, i_Evaluation_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Evaluation_By_Answer");}
}
#endregion
#region Reset_Evaluation_By_Answer
public void Reset_Evaluation_By_Answer(Answer i_Answer, List<Evaluation> i_Evaluation_List_To_Delete,List<Evaluation> i_Evaluation_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Evaluation oParams_Delete_Evaluation = new Params_Delete_Evaluation();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Evaluation_By_Answer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Evaluation_List_To_Delete != null)
{
foreach (var oRow in i_Evaluation_List_To_Delete)
{
oParams_Delete_Evaluation.EVALUATION_ID = oRow.EVALUATION_ID;
Delete_Evaluation(oParams_Delete_Evaluation);
}
}
//---------------------------------
// Edit Evaluation
//---------------------------------
Edit_Answer_WithEvaluation(i_Answer, i_Evaluation_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Evaluation_By_Answer");}
}
#endregion
#region Edit_Answer_With_Evaluation(Answer i_Answer,List<Evaluation> i_EvaluationList)
public void Edit_Answer_WithEvaluation(Answer i_Answer,List<Evaluation> i_List_Evaluation)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Answer_WithEvaluation");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Answer(i_Answer);
if (i_List_Evaluation != null)
{
foreach(Evaluation oEvaluation in i_List_Evaluation)
{
oEvaluation.ANSWER_ID = i_Answer.ANSWER_ID;
Edit_Evaluation(oEvaluation);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Answer_WithEvaluation");}
}
#endregion
#region Edit_Answer_WithRelatedData(Answer i_Answer,List<Evaluation> i_List_Evaluation)
public void Edit_Answer_WithRelatedData(Answer i_Answer,List<Evaluation> i_List_Evaluation)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Answer_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Answer(i_Answer);
if (i_List_Evaluation != null)
{
foreach(Evaluation oEvaluation in i_List_Evaluation)
{
oEvaluation.ANSWER_ID = i_Answer.ANSWER_ID;
Edit_Evaluation(oEvaluation);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Answer_WithRelatedData");}
}
#endregion
#region Delete_Answer_With_Children(Answer i_Answer)
public void Delete_Answer_With_Children(Answer i_Answer)
{
 #region Declaration And Initialization Section.
Params_Delete_Answer oParams_Delete_Answer = new Params_Delete_Answer();
Params_Delete_Evaluation_By_ANSWER_ID oParams_Delete_Evaluation_By_ANSWER_ID = new Params_Delete_Evaluation_By_ANSWER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Answer_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Evaluation_By_ANSWER_ID.ANSWER_ID = i_Answer.ANSWER_ID;
Delete_Evaluation_By_ANSWER_ID(oParams_Delete_Evaluation_By_ANSWER_ID);
//-------------------------

//-------------------------
oParams_Delete_Answer.ANSWER_ID = i_Answer.ANSWER_ID;
Delete_Answer(oParams_Delete_Answer);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Answer_With_Children");}
}
#endregion
#region Reset_Category_favorite_By_Category
public void Reset_Category_favorite_By_Category(Category i_Category, List<Category_favorite> i_Category_favorite_List)
{
#region Declaration And Initialization Section.
Params_Delete_Category_favorite_By_CATEGORY_ID oParams_Delete_Category_favorite_By_CATEGORY_ID = new Params_Delete_Category_favorite_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Category_favorite_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Category_favorite
//---------------------------------
oParams_Delete_Category_favorite_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Category_favorite_By_CATEGORY_ID(oParams_Delete_Category_favorite_By_CATEGORY_ID);
//---------------------------------
// Edit Category_favorite
//---------------------------------
Edit_Category_WithCategory_favorite(i_Category, i_Category_favorite_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Category_favorite_By_Category");}
}
#endregion
#region Reset_Category_favorite_By_Category
public void Reset_Category_favorite_By_Category(Category i_Category, List<Category_favorite> i_Category_favorite_List_To_Delete,List<Category_favorite> i_Category_favorite_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Category_favorite oParams_Delete_Category_favorite = new Params_Delete_Category_favorite();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Category_favorite_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Category_favorite_List_To_Delete != null)
{
foreach (var oRow in i_Category_favorite_List_To_Delete)
{
oParams_Delete_Category_favorite.CATEGORY_FAVORITE_ID = oRow.CATEGORY_FAVORITE_ID;
Delete_Category_favorite(oParams_Delete_Category_favorite);
}
}
//---------------------------------
// Edit Category_favorite
//---------------------------------
Edit_Category_WithCategory_favorite(i_Category, i_Category_favorite_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Category_favorite_By_Category");}
}
#endregion
#region Edit_Category_With_Category_favorite(Category i_Category,List<Category_favorite> i_Category_favoriteList)
public void Edit_Category_WithCategory_favorite(Category i_Category,List<Category_favorite> i_List_Category_favorite)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithCategory_favorite");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Category_favorite != null)
{
foreach(Category_favorite oCategory_favorite in i_List_Category_favorite)
{
oCategory_favorite.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Category_favorite(oCategory_favorite);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithCategory_favorite");}
}
#endregion
#region Reset_Question_By_Category
public void Reset_Question_By_Category(Category i_Category, List<Question> i_Question_List)
{
#region Declaration And Initialization Section.
Params_Delete_Question_By_CATEGORY_ID oParams_Delete_Question_By_CATEGORY_ID = new Params_Delete_Question_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Question
//---------------------------------
oParams_Delete_Question_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Question_By_CATEGORY_ID(oParams_Delete_Question_By_CATEGORY_ID);
//---------------------------------
// Edit Question
//---------------------------------
Edit_Category_WithQuestion(i_Category, i_Question_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_By_Category");}
}
#endregion
#region Reset_Question_By_Category
public void Reset_Question_By_Category(Category i_Category, List<Question> i_Question_List_To_Delete,List<Question> i_Question_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Question oParams_Delete_Question = new Params_Delete_Question();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Question_List_To_Delete != null)
{
foreach (var oRow in i_Question_List_To_Delete)
{
oParams_Delete_Question.QUESTION_ID = oRow.QUESTION_ID;
Delete_Question(oParams_Delete_Question);
}
}
//---------------------------------
// Edit Question
//---------------------------------
Edit_Category_WithQuestion(i_Category, i_Question_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_By_Category");}
}
#endregion
#region Edit_Category_With_Question(Category i_Category,List<Question> i_QuestionList)
public void Edit_Category_WithQuestion(Category i_Category,List<Question> i_List_Question)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithQuestion");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Question != null)
{
foreach(Question oQuestion in i_List_Question)
{
oQuestion.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Question(oQuestion);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithQuestion");}
}
#endregion
#region Reset_Teacher_By_Category
public void Reset_Teacher_By_Category(Category i_Category, List<Teacher> i_Teacher_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_By_CATEGORY_ID oParams_Delete_Teacher_By_CATEGORY_ID = new Params_Delete_Teacher_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher
//---------------------------------
oParams_Delete_Teacher_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Teacher_By_CATEGORY_ID(oParams_Delete_Teacher_By_CATEGORY_ID);
//---------------------------------
// Edit Teacher
//---------------------------------
Edit_Category_WithTeacher(i_Category, i_Teacher_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_By_Category");}
}
#endregion
#region Reset_Teacher_By_Category
public void Reset_Teacher_By_Category(Category i_Category, List<Teacher> i_Teacher_List_To_Delete,List<Teacher> i_Teacher_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher oParams_Delete_Teacher = new Params_Delete_Teacher();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_List_To_Delete)
{
oParams_Delete_Teacher.TEACHER_ID = oRow.TEACHER_ID;
Delete_Teacher(oParams_Delete_Teacher);
}
}
//---------------------------------
// Edit Teacher
//---------------------------------
Edit_Category_WithTeacher(i_Category, i_Teacher_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_By_Category");}
}
#endregion
#region Edit_Category_With_Teacher(Category i_Category,List<Teacher> i_TeacherList)
public void Edit_Category_WithTeacher(Category i_Category,List<Teacher> i_List_Teacher)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithTeacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Teacher != null)
{
foreach(Teacher oTeacher in i_List_Teacher)
{
oTeacher.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Teacher(oTeacher);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithTeacher");}
}
#endregion
#region Reset_Teacher_category_By_Category
public void Reset_Teacher_category_By_Category(Category i_Category, List<Teacher_category> i_Teacher_category_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_category_By_CATEGORY_ID oParams_Delete_Teacher_category_By_CATEGORY_ID = new Params_Delete_Teacher_category_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_category_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher_category
//---------------------------------
oParams_Delete_Teacher_category_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Teacher_category_By_CATEGORY_ID(oParams_Delete_Teacher_category_By_CATEGORY_ID);
//---------------------------------
// Edit Teacher_category
//---------------------------------
Edit_Category_WithTeacher_category(i_Category, i_Teacher_category_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_category_By_Category");}
}
#endregion
#region Reset_Teacher_category_By_Category
public void Reset_Teacher_category_By_Category(Category i_Category, List<Teacher_category> i_Teacher_category_List_To_Delete,List<Teacher_category> i_Teacher_category_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_category oParams_Delete_Teacher_category = new Params_Delete_Teacher_category();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_category_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_category_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_category_List_To_Delete)
{
oParams_Delete_Teacher_category.TEACHER_CATEGORY_ID = oRow.TEACHER_CATEGORY_ID;
Delete_Teacher_category(oParams_Delete_Teacher_category);
}
}
//---------------------------------
// Edit Teacher_category
//---------------------------------
Edit_Category_WithTeacher_category(i_Category, i_Teacher_category_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_category_By_Category");}
}
#endregion
#region Edit_Category_With_Teacher_category(Category i_Category,List<Teacher_category> i_Teacher_categoryList)
public void Edit_Category_WithTeacher_category(Category i_Category,List<Teacher_category> i_List_Teacher_category)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithTeacher_category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Teacher_category != null)
{
foreach(Teacher_category oTeacher_category in i_List_Teacher_category)
{
oTeacher_category.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Teacher_category(oTeacher_category);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithTeacher_category");}
}
#endregion
#region Edit_Category_WithRelatedData(Category i_Category,List<Category_favorite> i_List_Category_favorite,List<Question> i_List_Question,List<Teacher> i_List_Teacher,List<Teacher_category> i_List_Teacher_category)
public void Edit_Category_WithRelatedData(Category i_Category,List<Category_favorite> i_List_Category_favorite,List<Question> i_List_Question,List<Teacher> i_List_Teacher,List<Teacher_category> i_List_Teacher_category)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Category_favorite != null)
{
foreach(Category_favorite oCategory_favorite in i_List_Category_favorite)
{
oCategory_favorite.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Category_favorite(oCategory_favorite);
}
}
if (i_List_Question != null)
{
foreach(Question oQuestion in i_List_Question)
{
oQuestion.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Question(oQuestion);
}
}
if (i_List_Teacher != null)
{
foreach(Teacher oTeacher in i_List_Teacher)
{
oTeacher.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Teacher(oTeacher);
}
}
if (i_List_Teacher_category != null)
{
foreach(Teacher_category oTeacher_category in i_List_Teacher_category)
{
oTeacher_category.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Teacher_category(oTeacher_category);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithRelatedData");}
}
#endregion
#region Delete_Category_With_Children(Category i_Category)
public void Delete_Category_With_Children(Category i_Category)
{
 #region Declaration And Initialization Section.
Params_Delete_Category oParams_Delete_Category = new Params_Delete_Category();
Params_Delete_Category_favorite_By_CATEGORY_ID oParams_Delete_Category_favorite_By_CATEGORY_ID = new Params_Delete_Category_favorite_By_CATEGORY_ID();
Params_Delete_Question_By_CATEGORY_ID oParams_Delete_Question_By_CATEGORY_ID = new Params_Delete_Question_By_CATEGORY_ID();
Params_Delete_Teacher_By_CATEGORY_ID oParams_Delete_Teacher_By_CATEGORY_ID = new Params_Delete_Teacher_By_CATEGORY_ID();
Params_Delete_Teacher_category_By_CATEGORY_ID oParams_Delete_Teacher_category_By_CATEGORY_ID = new Params_Delete_Teacher_category_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Category_favorite_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Category_favorite_By_CATEGORY_ID(oParams_Delete_Category_favorite_By_CATEGORY_ID);
oParams_Delete_Question_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Question_By_CATEGORY_ID(oParams_Delete_Question_By_CATEGORY_ID);
oParams_Delete_Teacher_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Teacher_By_CATEGORY_ID(oParams_Delete_Teacher_By_CATEGORY_ID);
oParams_Delete_Teacher_category_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Teacher_category_By_CATEGORY_ID(oParams_Delete_Teacher_category_By_CATEGORY_ID);
//-------------------------

//-------------------------
oParams_Delete_Category.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Category(oParams_Delete_Category);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Address(Loc_l1 i_Loc_l1,List<Address> i_AddressList)
public void Edit_Loc_l1_WithAddress(Loc_l1 i_Loc_l1,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithAddress");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l2
//---------------------------------
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List_To_Delete,List<Loc_l2> i_Loc_l2_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l2_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l2_List_To_Delete)
{
oParams_Delete_Loc_l2.LOC_L2_ID = oRow.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
}
}
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Loc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_Loc_l2List)
public void Edit_Loc_l1_WithLoc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithLoc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithLoc_l2");}
}
#endregion
#region Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
public void Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithRelatedData");}
}
#endregion
#region Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
public void Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l1 oParams_Delete_Loc_l1 = new Params_Delete_Loc_l1();
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l1.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l1(oParams_Delete_Loc_l1);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Address(Loc_l2 i_Loc_l2,List<Address> i_AddressList)
public void Edit_Loc_l2_WithAddress(Loc_l2 i_Loc_l2,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithAddress");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l3
//---------------------------------
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List_To_Delete,List<Loc_l3> i_Loc_l3_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l3_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l3_List_To_Delete)
{
oParams_Delete_Loc_l3.LOC_L3_ID = oRow.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
}
}
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Loc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_Loc_l3List)
public void Edit_Loc_l2_WithLoc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithLoc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithLoc_l3");}
}
#endregion
#region Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
public void Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithRelatedData");}
}
#endregion
#region Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
public void Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l2.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Address(Loc_l3 i_Loc_l3,List<Address> i_AddressList)
public void Edit_Loc_l3_WithAddress(Loc_l3 i_Loc_l3,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithAddress");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l4
//---------------------------------
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List_To_Delete,List<Loc_l4> i_Loc_l4_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l4_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l4_List_To_Delete)
{
oParams_Delete_Loc_l4.LOC_L4_ID = oRow.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
}
}
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Loc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_Loc_l4List)
public void Edit_Loc_l3_WithLoc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithLoc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithLoc_l4");}
}
#endregion
#region Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
public void Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithRelatedData");}
}
#endregion
#region Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
public void Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l3.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Edit_Loc_l4_With_Address(Loc_l4 i_Loc_l4,List<Address> i_AddressList)
public void Edit_Loc_l4_WithAddress(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithAddress");}
}
#endregion
#region Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
public void Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithRelatedData");}
}
#endregion
#region Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
public void Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l4.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_With_Children");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Edit_Person_With_Address(Person i_Person,List<Address> i_AddressList)
public void Edit_Person_WithAddress(Person i_Person,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithAddress");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List)
{
#region Declaration And Initialization Section.
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Contact
//---------------------------------
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List_To_Delete,List<Contact> i_Contact_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Contact oParams_Delete_Contact = new Params_Delete_Contact();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Contact_List_To_Delete != null)
{
foreach (var oRow in i_Contact_List_To_Delete)
{
oParams_Delete_Contact.CONTACT_ID = oRow.CONTACT_ID;
Delete_Contact(oParams_Delete_Contact);
}
}
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Edit_Person_With_Contact(Person i_Person,List<Contact> i_ContactList)
public void Edit_Person_WithContact(Person i_Person,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithContact");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithContact");}
}
#endregion
#region Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
public void Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithRelatedData");}
}
#endregion
#region Delete_Person_With_Children(Person i_Person)
public void Delete_Person_With_Children(Person i_Person)
{
 #region Declaration And Initialization Section.
Params_Delete_Person oParams_Delete_Person = new Params_Delete_Person();
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//-------------------------

//-------------------------
oParams_Delete_Person.PERSON_ID = i_Person.PERSON_ID;
Delete_Person(oParams_Delete_Person);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_With_Children");}
}
#endregion
#region Reset_Answer_By_Question
public void Reset_Answer_By_Question(Question i_Question, List<Answer> i_Answer_List)
{
#region Declaration And Initialization Section.
Params_Delete_Answer_By_QUESTION_ID oParams_Delete_Answer_By_QUESTION_ID = new Params_Delete_Answer_By_QUESTION_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Answer_By_Question");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Answer
//---------------------------------
oParams_Delete_Answer_By_QUESTION_ID.QUESTION_ID = i_Question.QUESTION_ID;
Delete_Answer_By_QUESTION_ID(oParams_Delete_Answer_By_QUESTION_ID);
//---------------------------------
// Edit Answer
//---------------------------------
Edit_Question_WithAnswer(i_Question, i_Answer_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Answer_By_Question");}
}
#endregion
#region Reset_Answer_By_Question
public void Reset_Answer_By_Question(Question i_Question, List<Answer> i_Answer_List_To_Delete,List<Answer> i_Answer_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Answer oParams_Delete_Answer = new Params_Delete_Answer();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Answer_By_Question");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Answer_List_To_Delete != null)
{
foreach (var oRow in i_Answer_List_To_Delete)
{
oParams_Delete_Answer.ANSWER_ID = oRow.ANSWER_ID;
Delete_Answer(oParams_Delete_Answer);
}
}
//---------------------------------
// Edit Answer
//---------------------------------
Edit_Question_WithAnswer(i_Question, i_Answer_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Answer_By_Question");}
}
#endregion
#region Edit_Question_With_Answer(Question i_Question,List<Answer> i_AnswerList)
public void Edit_Question_WithAnswer(Question i_Question,List<Answer> i_List_Answer)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_WithAnswer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Question(i_Question);
if (i_List_Answer != null)
{
foreach(Answer oAnswer in i_List_Answer)
{
oAnswer.QUESTION_ID = i_Question.QUESTION_ID;
Edit_Answer(oAnswer);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_WithAnswer");}
}
#endregion
#region Reset_Question_token_By_Question
public void Reset_Question_token_By_Question(Question i_Question, List<Question_token> i_Question_token_List)
{
#region Declaration And Initialization Section.
Params_Delete_Question_token_By_QUESTION_ID oParams_Delete_Question_token_By_QUESTION_ID = new Params_Delete_Question_token_By_QUESTION_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_token_By_Question");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Question_token
//---------------------------------
oParams_Delete_Question_token_By_QUESTION_ID.QUESTION_ID = i_Question.QUESTION_ID;
Delete_Question_token_By_QUESTION_ID(oParams_Delete_Question_token_By_QUESTION_ID);
//---------------------------------
// Edit Question_token
//---------------------------------
Edit_Question_WithQuestion_token(i_Question, i_Question_token_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_token_By_Question");}
}
#endregion
#region Reset_Question_token_By_Question
public void Reset_Question_token_By_Question(Question i_Question, List<Question_token> i_Question_token_List_To_Delete,List<Question_token> i_Question_token_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Question_token oParams_Delete_Question_token = new Params_Delete_Question_token();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_token_By_Question");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Question_token_List_To_Delete != null)
{
foreach (var oRow in i_Question_token_List_To_Delete)
{
oParams_Delete_Question_token.QUESTION_TOKEN_ID = oRow.QUESTION_TOKEN_ID;
Delete_Question_token(oParams_Delete_Question_token);
}
}
//---------------------------------
// Edit Question_token
//---------------------------------
Edit_Question_WithQuestion_token(i_Question, i_Question_token_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_token_By_Question");}
}
#endregion
#region Edit_Question_With_Question_token(Question i_Question,List<Question_token> i_Question_tokenList)
public void Edit_Question_WithQuestion_token(Question i_Question,List<Question_token> i_List_Question_token)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_WithQuestion_token");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Question(i_Question);
if (i_List_Question_token != null)
{
foreach(Question_token oQuestion_token in i_List_Question_token)
{
oQuestion_token.QUESTION_ID = i_Question.QUESTION_ID;
Edit_Question_token(oQuestion_token);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_WithQuestion_token");}
}
#endregion
#region Edit_Question_WithRelatedData(Question i_Question,List<Answer> i_List_Answer,List<Question_token> i_List_Question_token)
public void Edit_Question_WithRelatedData(Question i_Question,List<Answer> i_List_Answer,List<Question_token> i_List_Question_token)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Question_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Question(i_Question);
if (i_List_Answer != null)
{
foreach(Answer oAnswer in i_List_Answer)
{
oAnswer.QUESTION_ID = i_Question.QUESTION_ID;
Edit_Answer(oAnswer);
}
}
if (i_List_Question_token != null)
{
foreach(Question_token oQuestion_token in i_List_Question_token)
{
oQuestion_token.QUESTION_ID = i_Question.QUESTION_ID;
Edit_Question_token(oQuestion_token);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Question_WithRelatedData");}
}
#endregion
#region Delete_Question_With_Children(Question i_Question)
public void Delete_Question_With_Children(Question i_Question)
{
 #region Declaration And Initialization Section.
Params_Delete_Question oParams_Delete_Question = new Params_Delete_Question();
Params_Delete_Answer_By_QUESTION_ID oParams_Delete_Answer_By_QUESTION_ID = new Params_Delete_Answer_By_QUESTION_ID();
Params_Delete_Question_token_By_QUESTION_ID oParams_Delete_Question_token_By_QUESTION_ID = new Params_Delete_Question_token_By_QUESTION_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Question_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Answer_By_QUESTION_ID.QUESTION_ID = i_Question.QUESTION_ID;
Delete_Answer_By_QUESTION_ID(oParams_Delete_Answer_By_QUESTION_ID);
oParams_Delete_Question_token_By_QUESTION_ID.QUESTION_ID = i_Question.QUESTION_ID;
Delete_Question_token_By_QUESTION_ID(oParams_Delete_Question_token_By_QUESTION_ID);
//-------------------------

//-------------------------
oParams_Delete_Question.QUESTION_ID = i_Question.QUESTION_ID;
Delete_Question(oParams_Delete_Question);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Question_With_Children");}
}
#endregion
#region Reset_Answer_By_Student
public void Reset_Answer_By_Student(Student i_Student, List<Answer> i_Answer_List)
{
#region Declaration And Initialization Section.
Params_Delete_Answer_By_STUDENT_ID oParams_Delete_Answer_By_STUDENT_ID = new Params_Delete_Answer_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Answer_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Answer
//---------------------------------
oParams_Delete_Answer_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Answer_By_STUDENT_ID(oParams_Delete_Answer_By_STUDENT_ID);
//---------------------------------
// Edit Answer
//---------------------------------
Edit_Student_WithAnswer(i_Student, i_Answer_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Answer_By_Student");}
}
#endregion
#region Reset_Answer_By_Student
public void Reset_Answer_By_Student(Student i_Student, List<Answer> i_Answer_List_To_Delete,List<Answer> i_Answer_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Answer oParams_Delete_Answer = new Params_Delete_Answer();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Answer_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Answer_List_To_Delete != null)
{
foreach (var oRow in i_Answer_List_To_Delete)
{
oParams_Delete_Answer.ANSWER_ID = oRow.ANSWER_ID;
Delete_Answer(oParams_Delete_Answer);
}
}
//---------------------------------
// Edit Answer
//---------------------------------
Edit_Student_WithAnswer(i_Student, i_Answer_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Answer_By_Student");}
}
#endregion
#region Edit_Student_With_Answer(Student i_Student,List<Answer> i_AnswerList)
public void Edit_Student_WithAnswer(Student i_Student,List<Answer> i_List_Answer)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithAnswer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Answer != null)
{
foreach(Answer oAnswer in i_List_Answer)
{
oAnswer.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Answer(oAnswer);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithAnswer");}
}
#endregion
#region Reset_Category_favorite_By_Student
public void Reset_Category_favorite_By_Student(Student i_Student, List<Category_favorite> i_Category_favorite_List)
{
#region Declaration And Initialization Section.
Params_Delete_Category_favorite_By_STUDENT_ID oParams_Delete_Category_favorite_By_STUDENT_ID = new Params_Delete_Category_favorite_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Category_favorite_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Category_favorite
//---------------------------------
oParams_Delete_Category_favorite_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Category_favorite_By_STUDENT_ID(oParams_Delete_Category_favorite_By_STUDENT_ID);
//---------------------------------
// Edit Category_favorite
//---------------------------------
Edit_Student_WithCategory_favorite(i_Student, i_Category_favorite_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Category_favorite_By_Student");}
}
#endregion
#region Reset_Category_favorite_By_Student
public void Reset_Category_favorite_By_Student(Student i_Student, List<Category_favorite> i_Category_favorite_List_To_Delete,List<Category_favorite> i_Category_favorite_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Category_favorite oParams_Delete_Category_favorite = new Params_Delete_Category_favorite();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Category_favorite_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Category_favorite_List_To_Delete != null)
{
foreach (var oRow in i_Category_favorite_List_To_Delete)
{
oParams_Delete_Category_favorite.CATEGORY_FAVORITE_ID = oRow.CATEGORY_FAVORITE_ID;
Delete_Category_favorite(oParams_Delete_Category_favorite);
}
}
//---------------------------------
// Edit Category_favorite
//---------------------------------
Edit_Student_WithCategory_favorite(i_Student, i_Category_favorite_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Category_favorite_By_Student");}
}
#endregion
#region Edit_Student_With_Category_favorite(Student i_Student,List<Category_favorite> i_Category_favoriteList)
public void Edit_Student_WithCategory_favorite(Student i_Student,List<Category_favorite> i_List_Category_favorite)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithCategory_favorite");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Category_favorite != null)
{
foreach(Category_favorite oCategory_favorite in i_List_Category_favorite)
{
oCategory_favorite.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Category_favorite(oCategory_favorite);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithCategory_favorite");}
}
#endregion
#region Reset_Evaluation_By_Student
public void Reset_Evaluation_By_Student(Student i_Student, List<Evaluation> i_Evaluation_List)
{
#region Declaration And Initialization Section.
Params_Delete_Evaluation_By_STUDENT_ID oParams_Delete_Evaluation_By_STUDENT_ID = new Params_Delete_Evaluation_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Evaluation_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Evaluation
//---------------------------------
oParams_Delete_Evaluation_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Evaluation_By_STUDENT_ID(oParams_Delete_Evaluation_By_STUDENT_ID);
//---------------------------------
// Edit Evaluation
//---------------------------------
Edit_Student_WithEvaluation(i_Student, i_Evaluation_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Evaluation_By_Student");}
}
#endregion
#region Reset_Evaluation_By_Student
public void Reset_Evaluation_By_Student(Student i_Student, List<Evaluation> i_Evaluation_List_To_Delete,List<Evaluation> i_Evaluation_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Evaluation oParams_Delete_Evaluation = new Params_Delete_Evaluation();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Evaluation_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Evaluation_List_To_Delete != null)
{
foreach (var oRow in i_Evaluation_List_To_Delete)
{
oParams_Delete_Evaluation.EVALUATION_ID = oRow.EVALUATION_ID;
Delete_Evaluation(oParams_Delete_Evaluation);
}
}
//---------------------------------
// Edit Evaluation
//---------------------------------
Edit_Student_WithEvaluation(i_Student, i_Evaluation_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Evaluation_By_Student");}
}
#endregion
#region Edit_Student_With_Evaluation(Student i_Student,List<Evaluation> i_EvaluationList)
public void Edit_Student_WithEvaluation(Student i_Student,List<Evaluation> i_List_Evaluation)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithEvaluation");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Evaluation != null)
{
foreach(Evaluation oEvaluation in i_List_Evaluation)
{
oEvaluation.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Evaluation(oEvaluation);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithEvaluation");}
}
#endregion
#region Reset_Favorite_teacher_By_Student
public void Reset_Favorite_teacher_By_Student(Student i_Student, List<Favorite_teacher> i_Favorite_teacher_List)
{
#region Declaration And Initialization Section.
Params_Delete_Favorite_teacher_By_STUDENT_ID oParams_Delete_Favorite_teacher_By_STUDENT_ID = new Params_Delete_Favorite_teacher_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Favorite_teacher_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Favorite_teacher
//---------------------------------
oParams_Delete_Favorite_teacher_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Favorite_teacher_By_STUDENT_ID(oParams_Delete_Favorite_teacher_By_STUDENT_ID);
//---------------------------------
// Edit Favorite_teacher
//---------------------------------
Edit_Student_WithFavorite_teacher(i_Student, i_Favorite_teacher_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Favorite_teacher_By_Student");}
}
#endregion
#region Reset_Favorite_teacher_By_Student
public void Reset_Favorite_teacher_By_Student(Student i_Student, List<Favorite_teacher> i_Favorite_teacher_List_To_Delete,List<Favorite_teacher> i_Favorite_teacher_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Favorite_teacher oParams_Delete_Favorite_teacher = new Params_Delete_Favorite_teacher();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Favorite_teacher_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Favorite_teacher_List_To_Delete != null)
{
foreach (var oRow in i_Favorite_teacher_List_To_Delete)
{
oParams_Delete_Favorite_teacher.FAVORITE_TEACHER_ID = oRow.FAVORITE_TEACHER_ID;
Delete_Favorite_teacher(oParams_Delete_Favorite_teacher);
}
}
//---------------------------------
// Edit Favorite_teacher
//---------------------------------
Edit_Student_WithFavorite_teacher(i_Student, i_Favorite_teacher_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Favorite_teacher_By_Student");}
}
#endregion
#region Edit_Student_With_Favorite_teacher(Student i_Student,List<Favorite_teacher> i_Favorite_teacherList)
public void Edit_Student_WithFavorite_teacher(Student i_Student,List<Favorite_teacher> i_List_Favorite_teacher)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithFavorite_teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Favorite_teacher != null)
{
foreach(Favorite_teacher oFavorite_teacher in i_List_Favorite_teacher)
{
oFavorite_teacher.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Favorite_teacher(oFavorite_teacher);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithFavorite_teacher");}
}
#endregion
#region Reset_Question_By_Student
public void Reset_Question_By_Student(Student i_Student, List<Question> i_Question_List)
{
#region Declaration And Initialization Section.
Params_Delete_Question_By_STUDENT_ID oParams_Delete_Question_By_STUDENT_ID = new Params_Delete_Question_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Question
//---------------------------------
oParams_Delete_Question_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Question_By_STUDENT_ID(oParams_Delete_Question_By_STUDENT_ID);
//---------------------------------
// Edit Question
//---------------------------------
Edit_Student_WithQuestion(i_Student, i_Question_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_By_Student");}
}
#endregion
#region Reset_Question_By_Student
public void Reset_Question_By_Student(Student i_Student, List<Question> i_Question_List_To_Delete,List<Question> i_Question_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Question oParams_Delete_Question = new Params_Delete_Question();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Question_List_To_Delete != null)
{
foreach (var oRow in i_Question_List_To_Delete)
{
oParams_Delete_Question.QUESTION_ID = oRow.QUESTION_ID;
Delete_Question(oParams_Delete_Question);
}
}
//---------------------------------
// Edit Question
//---------------------------------
Edit_Student_WithQuestion(i_Student, i_Question_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_By_Student");}
}
#endregion
#region Edit_Student_With_Question(Student i_Student,List<Question> i_QuestionList)
public void Edit_Student_WithQuestion(Student i_Student,List<Question> i_List_Question)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithQuestion");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Question != null)
{
foreach(Question oQuestion in i_List_Question)
{
oQuestion.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Question(oQuestion);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithQuestion");}
}
#endregion
#region Reset_Teacher_favorite_By_Student
public void Reset_Teacher_favorite_By_Student(Student i_Student, List<Teacher_favorite> i_Teacher_favorite_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_favorite_By_STUDENT_ID oParams_Delete_Teacher_favorite_By_STUDENT_ID = new Params_Delete_Teacher_favorite_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_favorite_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher_favorite
//---------------------------------
oParams_Delete_Teacher_favorite_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Teacher_favorite_By_STUDENT_ID(oParams_Delete_Teacher_favorite_By_STUDENT_ID);
//---------------------------------
// Edit Teacher_favorite
//---------------------------------
Edit_Student_WithTeacher_favorite(i_Student, i_Teacher_favorite_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_favorite_By_Student");}
}
#endregion
#region Reset_Teacher_favorite_By_Student
public void Reset_Teacher_favorite_By_Student(Student i_Student, List<Teacher_favorite> i_Teacher_favorite_List_To_Delete,List<Teacher_favorite> i_Teacher_favorite_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_favorite oParams_Delete_Teacher_favorite = new Params_Delete_Teacher_favorite();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_favorite_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_favorite_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_favorite_List_To_Delete)
{
oParams_Delete_Teacher_favorite.TEACHER_FAVORITE_ID = oRow.TEACHER_FAVORITE_ID;
Delete_Teacher_favorite(oParams_Delete_Teacher_favorite);
}
}
//---------------------------------
// Edit Teacher_favorite
//---------------------------------
Edit_Student_WithTeacher_favorite(i_Student, i_Teacher_favorite_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_favorite_By_Student");}
}
#endregion
#region Edit_Student_With_Teacher_favorite(Student i_Student,List<Teacher_favorite> i_Teacher_favoriteList)
public void Edit_Student_WithTeacher_favorite(Student i_Student,List<Teacher_favorite> i_List_Teacher_favorite)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithTeacher_favorite");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Teacher_favorite != null)
{
foreach(Teacher_favorite oTeacher_favorite in i_List_Teacher_favorite)
{
oTeacher_favorite.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Teacher_favorite(oTeacher_favorite);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithTeacher_favorite");}
}
#endregion
#region Reset_Teacher_report_By_Student
public void Reset_Teacher_report_By_Student(Student i_Student, List<Teacher_report> i_Teacher_report_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_report_By_STUDENT_ID oParams_Delete_Teacher_report_By_STUDENT_ID = new Params_Delete_Teacher_report_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_report_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher_report
//---------------------------------
oParams_Delete_Teacher_report_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Teacher_report_By_STUDENT_ID(oParams_Delete_Teacher_report_By_STUDENT_ID);
//---------------------------------
// Edit Teacher_report
//---------------------------------
Edit_Student_WithTeacher_report(i_Student, i_Teacher_report_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_report_By_Student");}
}
#endregion
#region Reset_Teacher_report_By_Student
public void Reset_Teacher_report_By_Student(Student i_Student, List<Teacher_report> i_Teacher_report_List_To_Delete,List<Teacher_report> i_Teacher_report_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_report oParams_Delete_Teacher_report = new Params_Delete_Teacher_report();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_report_By_Student");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_report_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_report_List_To_Delete)
{
oParams_Delete_Teacher_report.TEACHER_REPORT_ID = oRow.TEACHER_REPORT_ID;
Delete_Teacher_report(oParams_Delete_Teacher_report);
}
}
//---------------------------------
// Edit Teacher_report
//---------------------------------
Edit_Student_WithTeacher_report(i_Student, i_Teacher_report_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_report_By_Student");}
}
#endregion
#region Edit_Student_With_Teacher_report(Student i_Student,List<Teacher_report> i_Teacher_reportList)
public void Edit_Student_WithTeacher_report(Student i_Student,List<Teacher_report> i_List_Teacher_report)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithTeacher_report");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Teacher_report != null)
{
foreach(Teacher_report oTeacher_report in i_List_Teacher_report)
{
oTeacher_report.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Teacher_report(oTeacher_report);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithTeacher_report");}
}
#endregion
#region Edit_Student_WithRelatedData(Student i_Student,List<Answer> i_List_Answer,List<Category_favorite> i_List_Category_favorite,List<Evaluation> i_List_Evaluation,List<Favorite_teacher> i_List_Favorite_teacher,List<Question> i_List_Question,List<Teacher_favorite> i_List_Teacher_favorite,List<Teacher_report> i_List_Teacher_report)
public void Edit_Student_WithRelatedData(Student i_Student,List<Answer> i_List_Answer,List<Category_favorite> i_List_Category_favorite,List<Evaluation> i_List_Evaluation,List<Favorite_teacher> i_List_Favorite_teacher,List<Question> i_List_Question,List<Teacher_favorite> i_List_Teacher_favorite,List<Teacher_report> i_List_Teacher_report)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Student_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Student(i_Student);
if (i_List_Answer != null)
{
foreach(Answer oAnswer in i_List_Answer)
{
oAnswer.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Answer(oAnswer);
}
}
if (i_List_Category_favorite != null)
{
foreach(Category_favorite oCategory_favorite in i_List_Category_favorite)
{
oCategory_favorite.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Category_favorite(oCategory_favorite);
}
}
if (i_List_Evaluation != null)
{
foreach(Evaluation oEvaluation in i_List_Evaluation)
{
oEvaluation.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Evaluation(oEvaluation);
}
}
if (i_List_Favorite_teacher != null)
{
foreach(Favorite_teacher oFavorite_teacher in i_List_Favorite_teacher)
{
oFavorite_teacher.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Favorite_teacher(oFavorite_teacher);
}
}
if (i_List_Question != null)
{
foreach(Question oQuestion in i_List_Question)
{
oQuestion.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Question(oQuestion);
}
}
if (i_List_Teacher_favorite != null)
{
foreach(Teacher_favorite oTeacher_favorite in i_List_Teacher_favorite)
{
oTeacher_favorite.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Teacher_favorite(oTeacher_favorite);
}
}
if (i_List_Teacher_report != null)
{
foreach(Teacher_report oTeacher_report in i_List_Teacher_report)
{
oTeacher_report.STUDENT_ID = i_Student.STUDENT_ID;
Edit_Teacher_report(oTeacher_report);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Student_WithRelatedData");}
}
#endregion
#region Delete_Student_With_Children(Student i_Student)
public void Delete_Student_With_Children(Student i_Student)
{
 #region Declaration And Initialization Section.
Params_Delete_Student oParams_Delete_Student = new Params_Delete_Student();
Params_Delete_Answer_By_STUDENT_ID oParams_Delete_Answer_By_STUDENT_ID = new Params_Delete_Answer_By_STUDENT_ID();
Params_Delete_Category_favorite_By_STUDENT_ID oParams_Delete_Category_favorite_By_STUDENT_ID = new Params_Delete_Category_favorite_By_STUDENT_ID();
Params_Delete_Evaluation_By_STUDENT_ID oParams_Delete_Evaluation_By_STUDENT_ID = new Params_Delete_Evaluation_By_STUDENT_ID();
Params_Delete_Favorite_teacher_By_STUDENT_ID oParams_Delete_Favorite_teacher_By_STUDENT_ID = new Params_Delete_Favorite_teacher_By_STUDENT_ID();
Params_Delete_Question_By_STUDENT_ID oParams_Delete_Question_By_STUDENT_ID = new Params_Delete_Question_By_STUDENT_ID();
Params_Delete_Teacher_favorite_By_STUDENT_ID oParams_Delete_Teacher_favorite_By_STUDENT_ID = new Params_Delete_Teacher_favorite_By_STUDENT_ID();
Params_Delete_Teacher_report_By_STUDENT_ID oParams_Delete_Teacher_report_By_STUDENT_ID = new Params_Delete_Teacher_report_By_STUDENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Student_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Answer_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Answer_By_STUDENT_ID(oParams_Delete_Answer_By_STUDENT_ID);
oParams_Delete_Category_favorite_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Category_favorite_By_STUDENT_ID(oParams_Delete_Category_favorite_By_STUDENT_ID);
oParams_Delete_Evaluation_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Evaluation_By_STUDENT_ID(oParams_Delete_Evaluation_By_STUDENT_ID);
oParams_Delete_Favorite_teacher_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Favorite_teacher_By_STUDENT_ID(oParams_Delete_Favorite_teacher_By_STUDENT_ID);
oParams_Delete_Question_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Question_By_STUDENT_ID(oParams_Delete_Question_By_STUDENT_ID);
oParams_Delete_Teacher_favorite_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Teacher_favorite_By_STUDENT_ID(oParams_Delete_Teacher_favorite_By_STUDENT_ID);
oParams_Delete_Teacher_report_By_STUDENT_ID.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Teacher_report_By_STUDENT_ID(oParams_Delete_Teacher_report_By_STUDENT_ID);
//-------------------------

//-------------------------
oParams_Delete_Student.STUDENT_ID = i_Student.STUDENT_ID;
Delete_Student(oParams_Delete_Student);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Student_With_Children");}
}
#endregion
#region Reset_Answer_By_Teacher
public void Reset_Answer_By_Teacher(Teacher i_Teacher, List<Answer> i_Answer_List)
{
#region Declaration And Initialization Section.
Params_Delete_Answer_By_TEACHER_ID oParams_Delete_Answer_By_TEACHER_ID = new Params_Delete_Answer_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Answer_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Answer
//---------------------------------
oParams_Delete_Answer_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Answer_By_TEACHER_ID(oParams_Delete_Answer_By_TEACHER_ID);
//---------------------------------
// Edit Answer
//---------------------------------
Edit_Teacher_WithAnswer(i_Teacher, i_Answer_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Answer_By_Teacher");}
}
#endregion
#region Reset_Answer_By_Teacher
public void Reset_Answer_By_Teacher(Teacher i_Teacher, List<Answer> i_Answer_List_To_Delete,List<Answer> i_Answer_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Answer oParams_Delete_Answer = new Params_Delete_Answer();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Answer_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Answer_List_To_Delete != null)
{
foreach (var oRow in i_Answer_List_To_Delete)
{
oParams_Delete_Answer.ANSWER_ID = oRow.ANSWER_ID;
Delete_Answer(oParams_Delete_Answer);
}
}
//---------------------------------
// Edit Answer
//---------------------------------
Edit_Teacher_WithAnswer(i_Teacher, i_Answer_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Answer_By_Teacher");}
}
#endregion
#region Edit_Teacher_With_Answer(Teacher i_Teacher,List<Answer> i_AnswerList)
public void Edit_Teacher_WithAnswer(Teacher i_Teacher,List<Answer> i_List_Answer)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithAnswer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Answer != null)
{
foreach(Answer oAnswer in i_List_Answer)
{
oAnswer.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Answer(oAnswer);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithAnswer");}
}
#endregion
#region Reset_Favorite_teacher_By_Teacher
public void Reset_Favorite_teacher_By_Teacher(Teacher i_Teacher, List<Favorite_teacher> i_Favorite_teacher_List)
{
#region Declaration And Initialization Section.
Params_Delete_Favorite_teacher_By_TEACHER_ID oParams_Delete_Favorite_teacher_By_TEACHER_ID = new Params_Delete_Favorite_teacher_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Favorite_teacher_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Favorite_teacher
//---------------------------------
oParams_Delete_Favorite_teacher_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Favorite_teacher_By_TEACHER_ID(oParams_Delete_Favorite_teacher_By_TEACHER_ID);
//---------------------------------
// Edit Favorite_teacher
//---------------------------------
Edit_Teacher_WithFavorite_teacher(i_Teacher, i_Favorite_teacher_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Favorite_teacher_By_Teacher");}
}
#endregion
#region Reset_Favorite_teacher_By_Teacher
public void Reset_Favorite_teacher_By_Teacher(Teacher i_Teacher, List<Favorite_teacher> i_Favorite_teacher_List_To_Delete,List<Favorite_teacher> i_Favorite_teacher_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Favorite_teacher oParams_Delete_Favorite_teacher = new Params_Delete_Favorite_teacher();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Favorite_teacher_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Favorite_teacher_List_To_Delete != null)
{
foreach (var oRow in i_Favorite_teacher_List_To_Delete)
{
oParams_Delete_Favorite_teacher.FAVORITE_TEACHER_ID = oRow.FAVORITE_TEACHER_ID;
Delete_Favorite_teacher(oParams_Delete_Favorite_teacher);
}
}
//---------------------------------
// Edit Favorite_teacher
//---------------------------------
Edit_Teacher_WithFavorite_teacher(i_Teacher, i_Favorite_teacher_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Favorite_teacher_By_Teacher");}
}
#endregion
#region Edit_Teacher_With_Favorite_teacher(Teacher i_Teacher,List<Favorite_teacher> i_Favorite_teacherList)
public void Edit_Teacher_WithFavorite_teacher(Teacher i_Teacher,List<Favorite_teacher> i_List_Favorite_teacher)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithFavorite_teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Favorite_teacher != null)
{
foreach(Favorite_teacher oFavorite_teacher in i_List_Favorite_teacher)
{
oFavorite_teacher.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Favorite_teacher(oFavorite_teacher);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithFavorite_teacher");}
}
#endregion
#region Reset_Question_By_Teacher
public void Reset_Question_By_Teacher(Teacher i_Teacher, List<Question> i_Question_List)
{
#region Declaration And Initialization Section.
Params_Delete_Question_By_TEACHER_ID oParams_Delete_Question_By_TEACHER_ID = new Params_Delete_Question_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Question
//---------------------------------
oParams_Delete_Question_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Question_By_TEACHER_ID(oParams_Delete_Question_By_TEACHER_ID);
//---------------------------------
// Edit Question
//---------------------------------
Edit_Teacher_WithQuestion(i_Teacher, i_Question_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_By_Teacher");}
}
#endregion
#region Reset_Question_By_Teacher
public void Reset_Question_By_Teacher(Teacher i_Teacher, List<Question> i_Question_List_To_Delete,List<Question> i_Question_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Question oParams_Delete_Question = new Params_Delete_Question();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Question_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Question_List_To_Delete != null)
{
foreach (var oRow in i_Question_List_To_Delete)
{
oParams_Delete_Question.QUESTION_ID = oRow.QUESTION_ID;
Delete_Question(oParams_Delete_Question);
}
}
//---------------------------------
// Edit Question
//---------------------------------
Edit_Teacher_WithQuestion(i_Teacher, i_Question_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Question_By_Teacher");}
}
#endregion
#region Edit_Teacher_With_Question(Teacher i_Teacher,List<Question> i_QuestionList)
public void Edit_Teacher_WithQuestion(Teacher i_Teacher,List<Question> i_List_Question)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithQuestion");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Question != null)
{
foreach(Question oQuestion in i_List_Question)
{
oQuestion.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Question(oQuestion);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithQuestion");}
}
#endregion
#region Reset_Teacher_category_By_Teacher
public void Reset_Teacher_category_By_Teacher(Teacher i_Teacher, List<Teacher_category> i_Teacher_category_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_category_By_TEACHER_ID oParams_Delete_Teacher_category_By_TEACHER_ID = new Params_Delete_Teacher_category_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_category_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher_category
//---------------------------------
oParams_Delete_Teacher_category_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher_category_By_TEACHER_ID(oParams_Delete_Teacher_category_By_TEACHER_ID);
//---------------------------------
// Edit Teacher_category
//---------------------------------
Edit_Teacher_WithTeacher_category(i_Teacher, i_Teacher_category_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_category_By_Teacher");}
}
#endregion
#region Reset_Teacher_category_By_Teacher
public void Reset_Teacher_category_By_Teacher(Teacher i_Teacher, List<Teacher_category> i_Teacher_category_List_To_Delete,List<Teacher_category> i_Teacher_category_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_category oParams_Delete_Teacher_category = new Params_Delete_Teacher_category();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_category_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_category_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_category_List_To_Delete)
{
oParams_Delete_Teacher_category.TEACHER_CATEGORY_ID = oRow.TEACHER_CATEGORY_ID;
Delete_Teacher_category(oParams_Delete_Teacher_category);
}
}
//---------------------------------
// Edit Teacher_category
//---------------------------------
Edit_Teacher_WithTeacher_category(i_Teacher, i_Teacher_category_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_category_By_Teacher");}
}
#endregion
#region Edit_Teacher_With_Teacher_category(Teacher i_Teacher,List<Teacher_category> i_Teacher_categoryList)
public void Edit_Teacher_WithTeacher_category(Teacher i_Teacher,List<Teacher_category> i_List_Teacher_category)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithTeacher_category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Teacher_category != null)
{
foreach(Teacher_category oTeacher_category in i_List_Teacher_category)
{
oTeacher_category.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Teacher_category(oTeacher_category);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithTeacher_category");}
}
#endregion
#region Reset_Teacher_favorite_By_Teacher
public void Reset_Teacher_favorite_By_Teacher(Teacher i_Teacher, List<Teacher_favorite> i_Teacher_favorite_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_favorite_By_TEACHER_ID oParams_Delete_Teacher_favorite_By_TEACHER_ID = new Params_Delete_Teacher_favorite_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_favorite_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher_favorite
//---------------------------------
oParams_Delete_Teacher_favorite_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher_favorite_By_TEACHER_ID(oParams_Delete_Teacher_favorite_By_TEACHER_ID);
//---------------------------------
// Edit Teacher_favorite
//---------------------------------
Edit_Teacher_WithTeacher_favorite(i_Teacher, i_Teacher_favorite_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_favorite_By_Teacher");}
}
#endregion
#region Reset_Teacher_favorite_By_Teacher
public void Reset_Teacher_favorite_By_Teacher(Teacher i_Teacher, List<Teacher_favorite> i_Teacher_favorite_List_To_Delete,List<Teacher_favorite> i_Teacher_favorite_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_favorite oParams_Delete_Teacher_favorite = new Params_Delete_Teacher_favorite();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_favorite_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_favorite_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_favorite_List_To_Delete)
{
oParams_Delete_Teacher_favorite.TEACHER_FAVORITE_ID = oRow.TEACHER_FAVORITE_ID;
Delete_Teacher_favorite(oParams_Delete_Teacher_favorite);
}
}
//---------------------------------
// Edit Teacher_favorite
//---------------------------------
Edit_Teacher_WithTeacher_favorite(i_Teacher, i_Teacher_favorite_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_favorite_By_Teacher");}
}
#endregion
#region Edit_Teacher_With_Teacher_favorite(Teacher i_Teacher,List<Teacher_favorite> i_Teacher_favoriteList)
public void Edit_Teacher_WithTeacher_favorite(Teacher i_Teacher,List<Teacher_favorite> i_List_Teacher_favorite)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithTeacher_favorite");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Teacher_favorite != null)
{
foreach(Teacher_favorite oTeacher_favorite in i_List_Teacher_favorite)
{
oTeacher_favorite.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Teacher_favorite(oTeacher_favorite);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithTeacher_favorite");}
}
#endregion
#region Reset_Teacher_report_By_Teacher
public void Reset_Teacher_report_By_Teacher(Teacher i_Teacher, List<Teacher_report> i_Teacher_report_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_report_By_TEACHER_ID oParams_Delete_Teacher_report_By_TEACHER_ID = new Params_Delete_Teacher_report_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_report_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher_report
//---------------------------------
oParams_Delete_Teacher_report_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher_report_By_TEACHER_ID(oParams_Delete_Teacher_report_By_TEACHER_ID);
//---------------------------------
// Edit Teacher_report
//---------------------------------
Edit_Teacher_WithTeacher_report(i_Teacher, i_Teacher_report_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_report_By_Teacher");}
}
#endregion
#region Reset_Teacher_report_By_Teacher
public void Reset_Teacher_report_By_Teacher(Teacher i_Teacher, List<Teacher_report> i_Teacher_report_List_To_Delete,List<Teacher_report> i_Teacher_report_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_report oParams_Delete_Teacher_report = new Params_Delete_Teacher_report();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_report_By_Teacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_report_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_report_List_To_Delete)
{
oParams_Delete_Teacher_report.TEACHER_REPORT_ID = oRow.TEACHER_REPORT_ID;
Delete_Teacher_report(oParams_Delete_Teacher_report);
}
}
//---------------------------------
// Edit Teacher_report
//---------------------------------
Edit_Teacher_WithTeacher_report(i_Teacher, i_Teacher_report_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_report_By_Teacher");}
}
#endregion
#region Edit_Teacher_With_Teacher_report(Teacher i_Teacher,List<Teacher_report> i_Teacher_reportList)
public void Edit_Teacher_WithTeacher_report(Teacher i_Teacher,List<Teacher_report> i_List_Teacher_report)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithTeacher_report");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Teacher_report != null)
{
foreach(Teacher_report oTeacher_report in i_List_Teacher_report)
{
oTeacher_report.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Teacher_report(oTeacher_report);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithTeacher_report");}
}
#endregion
#region Edit_Teacher_WithRelatedData(Teacher i_Teacher,List<Answer> i_List_Answer,List<Favorite_teacher> i_List_Favorite_teacher,List<Question> i_List_Question,List<Teacher_category> i_List_Teacher_category,List<Teacher_favorite> i_List_Teacher_favorite,List<Teacher_report> i_List_Teacher_report)
public void Edit_Teacher_WithRelatedData(Teacher i_Teacher,List<Answer> i_List_Answer,List<Favorite_teacher> i_List_Favorite_teacher,List<Question> i_List_Question,List<Teacher_category> i_List_Teacher_category,List<Teacher_favorite> i_List_Teacher_favorite,List<Teacher_report> i_List_Teacher_report)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Teacher_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Teacher(i_Teacher);
if (i_List_Answer != null)
{
foreach(Answer oAnswer in i_List_Answer)
{
oAnswer.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Answer(oAnswer);
}
}
if (i_List_Favorite_teacher != null)
{
foreach(Favorite_teacher oFavorite_teacher in i_List_Favorite_teacher)
{
oFavorite_teacher.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Favorite_teacher(oFavorite_teacher);
}
}
if (i_List_Question != null)
{
foreach(Question oQuestion in i_List_Question)
{
oQuestion.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Question(oQuestion);
}
}
if (i_List_Teacher_category != null)
{
foreach(Teacher_category oTeacher_category in i_List_Teacher_category)
{
oTeacher_category.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Teacher_category(oTeacher_category);
}
}
if (i_List_Teacher_favorite != null)
{
foreach(Teacher_favorite oTeacher_favorite in i_List_Teacher_favorite)
{
oTeacher_favorite.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Teacher_favorite(oTeacher_favorite);
}
}
if (i_List_Teacher_report != null)
{
foreach(Teacher_report oTeacher_report in i_List_Teacher_report)
{
oTeacher_report.TEACHER_ID = i_Teacher.TEACHER_ID;
Edit_Teacher_report(oTeacher_report);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Teacher_WithRelatedData");}
}
#endregion
#region Delete_Teacher_With_Children(Teacher i_Teacher)
public void Delete_Teacher_With_Children(Teacher i_Teacher)
{
 #region Declaration And Initialization Section.
Params_Delete_Teacher oParams_Delete_Teacher = new Params_Delete_Teacher();
Params_Delete_Answer_By_TEACHER_ID oParams_Delete_Answer_By_TEACHER_ID = new Params_Delete_Answer_By_TEACHER_ID();
Params_Delete_Favorite_teacher_By_TEACHER_ID oParams_Delete_Favorite_teacher_By_TEACHER_ID = new Params_Delete_Favorite_teacher_By_TEACHER_ID();
Params_Delete_Question_By_TEACHER_ID oParams_Delete_Question_By_TEACHER_ID = new Params_Delete_Question_By_TEACHER_ID();
Params_Delete_Teacher_category_By_TEACHER_ID oParams_Delete_Teacher_category_By_TEACHER_ID = new Params_Delete_Teacher_category_By_TEACHER_ID();
Params_Delete_Teacher_favorite_By_TEACHER_ID oParams_Delete_Teacher_favorite_By_TEACHER_ID = new Params_Delete_Teacher_favorite_By_TEACHER_ID();
Params_Delete_Teacher_report_By_TEACHER_ID oParams_Delete_Teacher_report_By_TEACHER_ID = new Params_Delete_Teacher_report_By_TEACHER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Teacher_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Answer_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Answer_By_TEACHER_ID(oParams_Delete_Answer_By_TEACHER_ID);
oParams_Delete_Favorite_teacher_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Favorite_teacher_By_TEACHER_ID(oParams_Delete_Favorite_teacher_By_TEACHER_ID);
oParams_Delete_Question_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Question_By_TEACHER_ID(oParams_Delete_Question_By_TEACHER_ID);
oParams_Delete_Teacher_category_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher_category_By_TEACHER_ID(oParams_Delete_Teacher_category_By_TEACHER_ID);
oParams_Delete_Teacher_favorite_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher_favorite_By_TEACHER_ID(oParams_Delete_Teacher_favorite_By_TEACHER_ID);
oParams_Delete_Teacher_report_By_TEACHER_ID.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher_report_By_TEACHER_ID(oParams_Delete_Teacher_report_By_TEACHER_ID);
//-------------------------

//-------------------------
oParams_Delete_Teacher.TEACHER_ID = i_Teacher.TEACHER_ID;
Delete_Teacher(oParams_Delete_Teacher);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Teacher_With_Children");}
}
#endregion
#region Reset_Student_By_User_type_code
public void Reset_Student_By_User_type_code(User_type_code i_User_type_code, List<Student> i_Student_List)
{
#region Declaration And Initialization Section.
Params_Delete_Student_By_USER_TYPE_CODE_ID oParams_Delete_Student_By_USER_TYPE_CODE_ID = new Params_Delete_Student_By_USER_TYPE_CODE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Student_By_User_type_code");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Student
//---------------------------------
oParams_Delete_Student_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_Student_By_USER_TYPE_CODE_ID(oParams_Delete_Student_By_USER_TYPE_CODE_ID);
//---------------------------------
// Edit Student
//---------------------------------
Edit_User_type_code_WithStudent(i_User_type_code, i_Student_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Student_By_User_type_code");}
}
#endregion
#region Reset_Student_By_User_type_code
public void Reset_Student_By_User_type_code(User_type_code i_User_type_code, List<Student> i_Student_List_To_Delete,List<Student> i_Student_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Student oParams_Delete_Student = new Params_Delete_Student();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Student_By_User_type_code");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Student_List_To_Delete != null)
{
foreach (var oRow in i_Student_List_To_Delete)
{
oParams_Delete_Student.STUDENT_ID = oRow.STUDENT_ID;
Delete_Student(oParams_Delete_Student);
}
}
//---------------------------------
// Edit Student
//---------------------------------
Edit_User_type_code_WithStudent(i_User_type_code, i_Student_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Student_By_User_type_code");}
}
#endregion
#region Edit_User_type_code_With_Student(User_type_code i_User_type_code,List<Student> i_StudentList)
public void Edit_User_type_code_WithStudent(User_type_code i_User_type_code,List<Student> i_List_Student)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code_WithStudent");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_User_type_code(i_User_type_code);
if (i_List_Student != null)
{
foreach(Student oStudent in i_List_Student)
{
oStudent.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Edit_Student(oStudent);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code_WithStudent");}
}
#endregion
#region Reset_Teacher_By_User_type_code
public void Reset_Teacher_By_User_type_code(User_type_code i_User_type_code, List<Teacher> i_Teacher_List)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher_By_USER_TYPE_CODE_ID oParams_Delete_Teacher_By_USER_TYPE_CODE_ID = new Params_Delete_Teacher_By_USER_TYPE_CODE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_By_User_type_code");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Teacher
//---------------------------------
oParams_Delete_Teacher_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_Teacher_By_USER_TYPE_CODE_ID(oParams_Delete_Teacher_By_USER_TYPE_CODE_ID);
//---------------------------------
// Edit Teacher
//---------------------------------
Edit_User_type_code_WithTeacher(i_User_type_code, i_Teacher_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_By_User_type_code");}
}
#endregion
#region Reset_Teacher_By_User_type_code
public void Reset_Teacher_By_User_type_code(User_type_code i_User_type_code, List<Teacher> i_Teacher_List_To_Delete,List<Teacher> i_Teacher_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Teacher oParams_Delete_Teacher = new Params_Delete_Teacher();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Teacher_By_User_type_code");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Teacher_List_To_Delete != null)
{
foreach (var oRow in i_Teacher_List_To_Delete)
{
oParams_Delete_Teacher.TEACHER_ID = oRow.TEACHER_ID;
Delete_Teacher(oParams_Delete_Teacher);
}
}
//---------------------------------
// Edit Teacher
//---------------------------------
Edit_User_type_code_WithTeacher(i_User_type_code, i_Teacher_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Teacher_By_User_type_code");}
}
#endregion
#region Edit_User_type_code_With_Teacher(User_type_code i_User_type_code,List<Teacher> i_TeacherList)
public void Edit_User_type_code_WithTeacher(User_type_code i_User_type_code,List<Teacher> i_List_Teacher)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code_WithTeacher");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_User_type_code(i_User_type_code);
if (i_List_Teacher != null)
{
foreach(Teacher oTeacher in i_List_Teacher)
{
oTeacher.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Edit_Teacher(oTeacher);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code_WithTeacher");}
}
#endregion
#region Reset_User_By_User_type_code
public void Reset_User_By_User_type_code(User_type_code i_User_type_code, List<User> i_User_List)
{
#region Declaration And Initialization Section.
Params_Delete_User_By_USER_TYPE_CODE_ID oParams_Delete_User_By_USER_TYPE_CODE_ID = new Params_Delete_User_By_USER_TYPE_CODE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_User_By_User_type_code");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing User
//---------------------------------
oParams_Delete_User_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_User_By_USER_TYPE_CODE_ID(oParams_Delete_User_By_USER_TYPE_CODE_ID);
//---------------------------------
// Edit User
//---------------------------------
Edit_User_type_code_WithUser(i_User_type_code, i_User_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_User_By_User_type_code");}
}
#endregion
#region Reset_User_By_User_type_code
public void Reset_User_By_User_type_code(User_type_code i_User_type_code, List<User> i_User_List_To_Delete,List<User> i_User_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_User oParams_Delete_User = new Params_Delete_User();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_User_By_User_type_code");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_User_List_To_Delete != null)
{
foreach (var oRow in i_User_List_To_Delete)
{
oParams_Delete_User.USER_ID = oRow.USER_ID;
Delete_User(oParams_Delete_User);
}
}
//---------------------------------
// Edit User
//---------------------------------
Edit_User_type_code_WithUser(i_User_type_code, i_User_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_User_By_User_type_code");}
}
#endregion
#region Edit_User_type_code_With_User(User_type_code i_User_type_code,List<User> i_UserList)
public void Edit_User_type_code_WithUser(User_type_code i_User_type_code,List<User> i_List_User)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code_WithUser");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_User_type_code(i_User_type_code);
if (i_List_User != null)
{
foreach(User oUser in i_List_User)
{
oUser.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Edit_User(oUser);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code_WithUser");}
}
#endregion
#region Edit_User_type_code_WithRelatedData(User_type_code i_User_type_code,List<Student> i_List_Student,List<Teacher> i_List_Teacher,List<User> i_List_User)
public void Edit_User_type_code_WithRelatedData(User_type_code i_User_type_code,List<Student> i_List_Student,List<Teacher> i_List_Teacher,List<User> i_List_User)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_type_code_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_User_type_code(i_User_type_code);
if (i_List_Student != null)
{
foreach(Student oStudent in i_List_Student)
{
oStudent.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Edit_Student(oStudent);
}
}
if (i_List_Teacher != null)
{
foreach(Teacher oTeacher in i_List_Teacher)
{
oTeacher.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Edit_Teacher(oTeacher);
}
}
if (i_List_User != null)
{
foreach(User oUser in i_List_User)
{
oUser.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Edit_User(oUser);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_type_code_WithRelatedData");}
}
#endregion
#region Delete_User_type_code_With_Children(User_type_code i_User_type_code)
public void Delete_User_type_code_With_Children(User_type_code i_User_type_code)
{
 #region Declaration And Initialization Section.
Params_Delete_User_type_code oParams_Delete_User_type_code = new Params_Delete_User_type_code();
Params_Delete_Student_By_USER_TYPE_CODE_ID oParams_Delete_Student_By_USER_TYPE_CODE_ID = new Params_Delete_Student_By_USER_TYPE_CODE_ID();
Params_Delete_Teacher_By_USER_TYPE_CODE_ID oParams_Delete_Teacher_By_USER_TYPE_CODE_ID = new Params_Delete_Teacher_By_USER_TYPE_CODE_ID();
Params_Delete_User_By_USER_TYPE_CODE_ID oParams_Delete_User_By_USER_TYPE_CODE_ID = new Params_Delete_User_By_USER_TYPE_CODE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_type_code_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Student_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_Student_By_USER_TYPE_CODE_ID(oParams_Delete_Student_By_USER_TYPE_CODE_ID);
oParams_Delete_Teacher_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_Teacher_By_USER_TYPE_CODE_ID(oParams_Delete_Teacher_By_USER_TYPE_CODE_ID);
oParams_Delete_User_By_USER_TYPE_CODE_ID.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_User_By_USER_TYPE_CODE_ID(oParams_Delete_User_By_USER_TYPE_CODE_ID);
//-------------------------

//-------------------------
oParams_Delete_User_type_code.USER_TYPE_CODE_ID = i_User_type_code.USER_TYPE_CODE_ID;
Delete_User_type_code(oParams_Delete_User_type_code);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_type_code_With_Children");}
}
#endregion
}
}
