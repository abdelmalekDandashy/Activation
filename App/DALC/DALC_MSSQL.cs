using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Answer Get_Answer_By_ANSWER_ID ( Int32? ANSWER_ID)
{
Answer o = new Answer();
dynamic p = new ExpandoObject();
p.ANSWER_ID = ANSWER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ANSWER_BY_ANSWER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category Get_Category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
Category o = new Category();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category_favorite Get_Category_favorite_By_CATEGORY_FAVORITE_ID ( Int32? CATEGORY_FAVORITE_ID)
{
Category_favorite o = new Category_favorite();
dynamic p = new ExpandoObject();
p.CATEGORY_FAVORITE_ID = CATEGORY_FAVORITE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_FAVORITE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Evaluation Get_Evaluation_By_EVALUATION_ID ( Int32? EVALUATION_ID)
{
Evaluation o = new Evaluation();
dynamic p = new ExpandoObject();
p.EVALUATION_ID = EVALUATION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_EVALUATION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Favorite_teacher Get_Favorite_teacher_By_FAVORITE_TEACHER_ID ( Int32? FAVORITE_TEACHER_ID)
{
Favorite_teacher o = new Favorite_teacher();
dynamic p = new ExpandoObject();
p.FAVORITE_TEACHER_ID = FAVORITE_TEACHER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_FAVORITE_TEACHER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Person Get_Person_By_PERSON_ID ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Question Get_Question_By_QUESTION_ID ( Int32? QUESTION_ID)
{
Question o = new Question();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_QUESTION_BY_QUESTION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Question_token Get_Question_token_By_QUESTION_TOKEN_ID ( Int32? QUESTION_TOKEN_ID)
{
Question_token o = new Question_token();
dynamic p = new ExpandoObject();
p.QUESTION_TOKEN_ID = QUESTION_TOKEN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_TOKEN_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Student Get_Student_By_STUDENT_ID ( Int32? STUDENT_ID)
{
Student o = new Student();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STUDENT_BY_STUDENT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Student_report Get_Student_report_By_STUDENT_REPORT_ID ( Int32? STUDENT_REPORT_ID)
{
Student_report o = new Student_report();
dynamic p = new ExpandoObject();
p.STUDENT_REPORT_ID = STUDENT_REPORT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_STUDENT_REPORT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Teacher Get_Teacher_By_TEACHER_ID ( Int32? TEACHER_ID)
{
Teacher o = new Teacher();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_BY_TEACHER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Teacher_category Get_Teacher_category_By_TEACHER_CATEGORY_ID ( Int32? TEACHER_CATEGORY_ID)
{
Teacher_category o = new Teacher_category();
dynamic p = new ExpandoObject();
p.TEACHER_CATEGORY_ID = TEACHER_CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_CATEGORY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Teacher_favorite Get_Teacher_favorite_By_TEACHER_FAVORITE_ID ( Int32? TEACHER_FAVORITE_ID)
{
Teacher_favorite o = new Teacher_favorite();
dynamic p = new ExpandoObject();
p.TEACHER_FAVORITE_ID = TEACHER_FAVORITE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_FAVORITE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Teacher_report Get_Teacher_report_By_TEACHER_REPORT_ID ( Int32? TEACHER_REPORT_ID)
{
Teacher_report o = new Teacher_report();
dynamic p = new ExpandoObject();
p.TEACHER_REPORT_ID = TEACHER_REPORT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_REPORT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User_type_code Get_User_type_code_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
User_type_code o = new User_type_code();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_USER_TYPE_CODE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(R["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(R["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(R["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(R["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(R["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(R["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(R["T_LOC_L4_OWNER_ID"]);
}
return o;
}
public Answer Get_Answer_By_ANSWER_ID_Adv ( Int32? ANSWER_ID)
{
Answer o = new Answer();
dynamic p = new ExpandoObject();
p.ANSWER_ID = ANSWER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ANSWER_BY_ANSWER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(R["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(R["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(R["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(R["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(R["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(R["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(R["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(R["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(R["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(R["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(R["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(R["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(R["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(R["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(R["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(R["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(R["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(R["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(R["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(R["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(R["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(R["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
}
return o;
}
public Category Get_Category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
Category o = new Category();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category_favorite Get_Category_favorite_By_CATEGORY_FAVORITE_ID_Adv ( Int32? CATEGORY_FAVORITE_ID)
{
Category_favorite o = new Category_favorite();
dynamic p = new ExpandoObject();
p.CATEGORY_FAVORITE_ID = CATEGORY_FAVORITE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_FAVORITE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(R["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(R["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(R["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(R["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(R["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(R["T_CATEGORY_OWNER_ID"]);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
}
return o;
}
public Evaluation Get_Evaluation_By_EVALUATION_ID_Adv ( Int32? EVALUATION_ID)
{
Evaluation o = new Evaluation();
dynamic p = new ExpandoObject();
p.EVALUATION_ID = EVALUATION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_EVALUATION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(R["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(R["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(R["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(R["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(R["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(R["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(R["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(R["T_ANSWER_OWNER_ID"]);
}
return o;
}
public Favorite_teacher Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_Adv ( Int32? FAVORITE_TEACHER_ID)
{
Favorite_teacher o = new Favorite_teacher();
dynamic p = new ExpandoObject();
p.FAVORITE_TEACHER_ID = FAVORITE_TEACHER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_FAVORITE_TEACHER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(R["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(R["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(R["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(R["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(R["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(R["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(R["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(R["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(R["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(R["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(R["T_TEACHER_DESCRIPTION"]);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
}
return o;
}
public Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Question Get_Question_By_QUESTION_ID_Adv ( Int32? QUESTION_ID)
{
Question o = new Question();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_QUESTION_BY_QUESTION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(R["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(R["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(R["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(R["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(R["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(R["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(R["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(R["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(R["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(R["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(R["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(R["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(R["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(R["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(R["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(R["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(R["T_TEACHER_DESCRIPTION"]);
}
return o;
}
public Question_token Get_Question_token_By_QUESTION_TOKEN_ID_Adv ( Int32? QUESTION_TOKEN_ID)
{
Question_token o = new Question_token();
dynamic p = new ExpandoObject();
p.QUESTION_TOKEN_ID = QUESTION_TOKEN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_TOKEN_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(R["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(R["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(R["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(R["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(R["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(R["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(R["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(R["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(R["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(R["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(R["T_QUESTION_OWNER_ID"]);
}
return o;
}
public Student Get_Student_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
Student o = new Student();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STUDENT_BY_STUDENT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(R["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(R["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(R["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(R["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(R["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(R["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(R["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(R["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(R["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(R["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(R["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(R["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(R["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(R["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(R["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(R["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(R["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(R["T_USER_TYPE_CODE_OWNER_ID"]);
}
return o;
}
public Student_report Get_Student_report_By_STUDENT_REPORT_ID_Adv ( Int32? STUDENT_REPORT_ID)
{
Student_report o = new Student_report();
dynamic p = new ExpandoObject();
p.STUDENT_REPORT_ID = STUDENT_REPORT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_STUDENT_REPORT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(R["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(R["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(R["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(R["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(R["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(R["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(R["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(R["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(R["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(R["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(R["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(R["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(R["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(R["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(R["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(R["T_REPORTED_STUDENT_DESCRIPTION"]);
}
return o;
}
public Teacher Get_Teacher_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
Teacher o = new Teacher();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_BY_TEACHER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(R["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(R["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(R["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(R["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(R["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(R["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(R["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(R["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(R["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(R["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(R["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(R["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(R["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(R["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(R["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(R["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(R["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(R["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(R["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(R["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(R["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(R["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(R["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(R["T_CATEGORY_OWNER_ID"]);
}
return o;
}
public Teacher_category Get_Teacher_category_By_TEACHER_CATEGORY_ID_Adv ( Int32? TEACHER_CATEGORY_ID)
{
Teacher_category o = new Teacher_category();
dynamic p = new ExpandoObject();
p.TEACHER_CATEGORY_ID = TEACHER_CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_CATEGORY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(R["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(R["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(R["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(R["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(R["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(R["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(R["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(R["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(R["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(R["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(R["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(R["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(R["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(R["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(R["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(R["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(R["T_CATEGORY_OWNER_ID"]);
}
return o;
}
public Teacher_favorite Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_Adv ( Int32? TEACHER_FAVORITE_ID)
{
Teacher_favorite o = new Teacher_favorite();
dynamic p = new ExpandoObject();
p.TEACHER_FAVORITE_ID = TEACHER_FAVORITE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_FAVORITE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(R["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(R["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(R["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(R["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(R["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(R["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(R["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(R["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(R["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(R["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(R["T_TEACHER_DESCRIPTION"]);
}
return o;
}
public Teacher_report Get_Teacher_report_By_TEACHER_REPORT_ID_Adv ( Int32? TEACHER_REPORT_ID)
{
Teacher_report o = new Teacher_report();
dynamic p = new ExpandoObject();
p.TEACHER_REPORT_ID = TEACHER_REPORT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_REPORT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(R["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(R["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(R["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(R["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(R["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(R["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(R["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(R["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(R["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(R["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(R["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(R["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(R["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(R["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(R["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(R["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(R["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(R["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(R["T_STUDENT_DESCRIPTION"]);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(R["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(R["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(R["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(R["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(R["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(R["T_USER_TYPE_CODE_OWNER_ID"]);
}
return o;
}
public User_type_code Get_User_type_code_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID)
{
User_type_code o = new User_type_code();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_USER_TYPE_CODE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_ANSWER_ID_List ( List<Int32?> ANSWER_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_ANSWER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List ( List<Int32?> CATEGORY_FAVORITE_ID_LIST)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.CATEGORY_FAVORITE_ID_LIST = string.Join(",", CATEGORY_FAVORITE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_FAVORITE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_EVALUATION_ID_List ( List<Int32?> EVALUATION_ID_LIST)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.EVALUATION_ID_LIST = string.Join(",", EVALUATION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_EVALUATION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List ( List<Int32?> FAVORITE_TEACHER_ID_LIST)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.FAVORITE_TEACHER_ID_LIST = string.Join(",", FAVORITE_TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_FAVORITE_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_QUESTION_ID_List ( List<Int32?> QUESTION_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_QUESTION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_TOKEN_ID_List ( List<Int32?> QUESTION_TOKEN_ID_LIST)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.QUESTION_TOKEN_ID_LIST = string.Join(",", QUESTION_TOKEN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_TOKEN_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_STUDENT_REPORT_ID_List ( List<Int32?> STUDENT_REPORT_ID_LIST)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.STUDENT_REPORT_ID_LIST = string.Join(",", STUDENT_REPORT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_STUDENT_REPORT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_CATEGORY_ID_List ( List<Int32?> TEACHER_CATEGORY_ID_LIST)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.TEACHER_CATEGORY_ID_LIST = string.Join(",", TEACHER_CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List ( List<Int32?> TEACHER_FAVORITE_ID_LIST)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.TEACHER_FAVORITE_ID_LIST = string.Join(",", TEACHER_FAVORITE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_FAVORITE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_REPORT_ID_List ( List<Int32?> TEACHER_REPORT_ID_LIST)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.TEACHER_REPORT_ID_LIST = string.Join(",", TEACHER_REPORT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_REPORT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User_type_code> Get_User_type_code_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_USER_TYPE_CODE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_ANSWER_ID_List_Adv ( List<Int32?> ANSWER_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_ANSWER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_Adv ( List<Int32?> CATEGORY_FAVORITE_ID_LIST)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.CATEGORY_FAVORITE_ID_LIST = string.Join(",", CATEGORY_FAVORITE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_FAVORITE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_EVALUATION_ID_List_Adv ( List<Int32?> EVALUATION_ID_LIST)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.EVALUATION_ID_LIST = string.Join(",", EVALUATION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_EVALUATION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_Adv ( List<Int32?> FAVORITE_TEACHER_ID_LIST)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.FAVORITE_TEACHER_ID_LIST = string.Join(",", FAVORITE_TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_FAVORITE_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_QUESTION_ID_List_Adv ( List<Int32?> QUESTION_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_QUESTION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_TOKEN_ID_List_Adv ( List<Int32?> QUESTION_TOKEN_ID_LIST)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.QUESTION_TOKEN_ID_LIST = string.Join(",", QUESTION_TOKEN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_TOKEN_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_STUDENT_REPORT_ID_List_Adv ( List<Int32?> STUDENT_REPORT_ID_LIST)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.STUDENT_REPORT_ID_LIST = string.Join(",", STUDENT_REPORT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_STUDENT_REPORT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_Adv ( List<Int32?> TEACHER_CATEGORY_ID_LIST)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.TEACHER_CATEGORY_ID_LIST = string.Join(",", TEACHER_CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_Adv ( List<Int32?> TEACHER_FAVORITE_ID_LIST)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.TEACHER_FAVORITE_ID_LIST = string.Join(",", TEACHER_FAVORITE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_FAVORITE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_REPORT_ID_List_Adv ( List<Int32?> TEACHER_REPORT_ID_LIST)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.TEACHER_REPORT_ID_LIST = string.Join(",", TEACHER_REPORT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_REPORT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User_type_code> Get_User_type_code_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_USER_TYPE_CODE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID ( Int32? QUESTION_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_QUESTION_ID", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID ( Int32? TEACHER_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_TEACHER_ID", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID ( Int32? ANSWER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.ANSWER_ID = ANSWER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_ANSWER_ID", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID ( Int32? TEACHER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_TEACHER_ID", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID ( Int32? TEACHER_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_TEACHER_ID", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_PART ( string PART)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_PART", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID ( Int32? QUESTION_ID)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_ID", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_TYPE_CODE_ID", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_ID ( long? USER_ID)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_ID", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID ( Int32? REPORTED_BY_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_BY_STUDENT_ID = REPORTED_BY_STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID ( Int32? REPORTED_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_STUDENT_ID = REPORTED_STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_TYPE_CODE_ID", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID ( long? USER_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID ( Int32? TEACHER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID ( Int32? TEACHER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID ( Int32? TEACHER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID ( Int32? STUDENT_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_STUDENT_ID", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_CODE_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_EMAIL ( string EMAIL)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_EMAIL", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User_type_code> Get_User_type_code_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID_Adv ( Int32? QUESTION_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_QUESTION_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_TEACHER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID_Adv ( Int32? ANSWER_ID)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.ANSWER_ID = ANSWER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_ANSWER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_TEACHER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_TEACHER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_PART_Adv ( string PART)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_PART_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID_Adv ( Int32? QUESTION_ID)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_TYPE_CODE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_ID_Adv ( long? USER_ID)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_Adv ( Int32? REPORTED_BY_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_BY_STUDENT_ID = REPORTED_BY_STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_Adv ( Int32? REPORTED_STUDENT_ID)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_STUDENT_ID = REPORTED_STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_TYPE_CODE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID_Adv ( long? USER_ID)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_Adv ( Int32? TEACHER_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.TEACHER_ID = TEACHER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_Adv ( Int32? STUDENT_ID)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_STUDENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_CODE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_EMAIL_Adv ( string EMAIL)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_EMAIL_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User_type_code> Get_User_type_code_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID_List ( List<Int32?> QUESTION_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_QUESTION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID_List ( List<Int32?> ANSWER_ID_LIST)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_ANSWER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID_List ( List<Int32?> QUESTION_ID_LIST)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_TYPE_CODE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_List ( List<Int32?> REPORTED_BY_STUDENT_ID_LIST)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_BY_STUDENT_ID_LIST = string.Join(",", REPORTED_BY_STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_List ( List<Int32?> REPORTED_STUDENT_ID_LIST)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_STUDENT_ID_LIST = string.Join(",", REPORTED_STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_TYPE_CODE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_STUDENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_CODE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_QUESTION_ID_List_Adv ( List<Int32?> QUESTION_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_QUESTION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Answer> Get_Answer_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Evaluation> Get_Evaluation_By_ANSWER_ID_List_Adv ( List<Int32?> ANSWER_ID_LIST)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_ANSWER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question> Get_Question_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Question_token> Get_Question_token_By_QUESTION_ID_List_Adv ( List<Int32?> QUESTION_ID_LIST)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_QUESTION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_TYPE_CODE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student> Get_Student_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_List_Adv ( List<Int32?> REPORTED_BY_STUDENT_ID_LIST)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_BY_STUDENT_ID_LIST = string.Join(",", REPORTED_BY_STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_List_Adv ( List<Int32?> REPORTED_STUDENT_ID_LIST)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.REPORTED_STUDENT_ID_LIST = string.Join(",", REPORTED_STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_REPORTED_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_TYPE_CODE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher> Get_Teacher_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_TEACHER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_STUDENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_CODE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Where ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User_type_code> Get_User_type_code_By_Criteria ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE = USER_TYPE_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User_type_code> Get_User_type_code_By_Where ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE = USER_TYPE_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria_Adv ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Where_Adv ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User_type_code> Get_User_type_code_By_Criteria_Adv ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE = USER_TYPE_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User_type_code> Get_User_type_code_By_Where_Adv ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User_type_code> oList = new List<User_type_code>();
dynamic p = new ExpandoObject();
p.USER_TYPE_CODE = USER_TYPE_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_TYPE_CODE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User_type_code o = new User_type_code();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Criteria_InList ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Where_InList ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria_InList ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Where_InList ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Criteria_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Where_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria_InList ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.REPORTED_BY_STUDENT_ID_LIST = string.Join(",", REPORTED_BY_STUDENT_ID_LIST.ToArray()); p.REPORTED_STUDENT_ID_LIST = string.Join(",", REPORTED_STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Where_InList ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.REPORTED_BY_STUDENT_ID_LIST = string.Join(",", REPORTED_BY_STUDENT_ID_LIST.ToArray()); p.REPORTED_STUDENT_ID_LIST = string.Join(",", REPORTED_STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Where_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_InList ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_InList ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_InList_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_InList_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Answer> Get_Answer_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Answer> oList = new List<Answer>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ANSWER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Answer o = new Answer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category_favorite> Get_Category_favorite_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category_favorite> oList = new List<Category_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_FAVORITE_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category_favorite o = new Category_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Evaluation> Get_Evaluation_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Evaluation> oList = new List<Evaluation>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.ANSWER_ID_LIST = string.Join(",", ANSWER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_EVALUATION_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Evaluation o = new Evaluation();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Answer = new Answer();
o.My_Answer.ANSWER_ID = GV<Int32>(X["T_ANSWER_ANSWER_ID"]);o.My_Answer.QUESTION_ID = GV<Int32>(X["T_ANSWER_QUESTION_ID"]);o.My_Answer.TEACHER_ID = GV<Int32>(X["T_ANSWER_TEACHER_ID"]);o.My_Answer.STUDENT_ID = GV<Int32>(X["T_ANSWER_STUDENT_ID"]);o.My_Answer.DESCRIPTION = GV<String>(X["T_ANSWER_DESCRIPTION"]);o.My_Answer.ENTRY_USER_ID = GV<Int64>(X["T_ANSWER_ENTRY_USER_ID"]);o.My_Answer.ENTRY_DATE = GV<String>(X["T_ANSWER_ENTRY_DATE"]);o.My_Answer.OWNER_ID = GV<Int32>(X["T_ANSWER_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Favorite_teacher> Get_Favorite_teacher_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Favorite_teacher> oList = new List<Favorite_teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FAVORITE_TEACHER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Favorite_teacher o = new Favorite_teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question> Get_Question_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question> oList = new List<Question>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question o = new Question();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Criteria_InList_Adv ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Question_token> Get_Question_token_By_Where_InList_Adv ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Question_token> oList = new List<Question_token>();
dynamic p = new ExpandoObject();
p.PART = PART; p.QUESTION_ID_LIST = string.Join(",", QUESTION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_QUESTION_TOKEN_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Question_token o = new Question_token();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Question = new Question();
o.My_Question.QUESTION_ID = GV<Int32>(X["T_QUESTION_QUESTION_ID"]);o.My_Question.STUDENT_ID = GV<Int32>(X["T_QUESTION_STUDENT_ID"]);o.My_Question.CATEGORY_ID = GV<Int32>(X["T_QUESTION_CATEGORY_ID"]);o.My_Question.TEACHER_ID = GV<Int32>(X["T_QUESTION_TEACHER_ID"]);o.My_Question.DESCRIPTION = GV<String>(X["T_QUESTION_DESCRIPTION"]);o.My_Question.IS_ANSWERED = GV<Boolean>(X["T_QUESTION_IS_ANSWERED"]);o.My_Question.IS_PUBLIC = GV<Boolean>(X["T_QUESTION_IS_PUBLIC"]);o.My_Question.IS_SELF_CLOSED = GV<Boolean>(X["T_QUESTION_IS_SELF_CLOSED"]);o.My_Question.ENTRY_USER_ID = GV<Int64>(X["T_QUESTION_ENTRY_USER_ID"]);o.My_Question.ENTRY_DATE = GV<String>(X["T_QUESTION_ENTRY_DATE"]);o.My_Question.OWNER_ID = GV<Int32>(X["T_QUESTION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student> Get_Student_By_Where_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student> oList = new List<Student>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student o = new Student();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.REPORTED_BY_STUDENT_ID_LIST = string.Join(",", REPORTED_BY_STUDENT_ID_LIST.ToArray()); p.REPORTED_STUDENT_ID_LIST = string.Join(",", REPORTED_STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Student_report> Get_Student_report_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Student_report> oList = new List<Student_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.REPORTED_BY_STUDENT_ID_LIST = string.Join(",", REPORTED_BY_STUDENT_ID_LIST.ToArray()); p.REPORTED_STUDENT_ID_LIST = string.Join(",", REPORTED_STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STUDENT_REPORT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Student_report o = new Student_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Reported_by_student = new Student();
o.My_Reported_by_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_STUDENT_ID"]);o.My_Reported_by_student.USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_USER_ID"]);o.My_Reported_by_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_by_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_BY_STUDENT_IS_BLOCKED"]);o.My_Reported_by_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_BY_STUDENT_ENTRY_USER_ID"]);o.My_Reported_by_student.ENTRY_DATE = GV<String>(X["T_REPORTED_BY_STUDENT_ENTRY_DATE"]);o.My_Reported_by_student.OWNER_ID = GV<Int32>(X["T_REPORTED_BY_STUDENT_OWNER_ID"]);o.My_Reported_by_student.DESCRIPTION = GV<String>(X["T_REPORTED_BY_STUDENT_DESCRIPTION"]);
o.My_Reported_student = new Student();
o.My_Reported_student.STUDENT_ID = GV<Int32>(X["T_REPORTED_STUDENT_STUDENT_ID"]);o.My_Reported_student.USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_USER_ID"]);o.My_Reported_student.USER_TYPE_CODE_ID = GV<Int32>(X["T_REPORTED_STUDENT_USER_TYPE_CODE_ID"]);o.My_Reported_student.IS_BLOCKED = GV<Boolean>(X["T_REPORTED_STUDENT_IS_BLOCKED"]);o.My_Reported_student.ENTRY_USER_ID = GV<Int64>(X["T_REPORTED_STUDENT_ENTRY_USER_ID"]);o.My_Reported_student.ENTRY_DATE = GV<String>(X["T_REPORTED_STUDENT_ENTRY_DATE"]);o.My_Reported_student.OWNER_ID = GV<Int32>(X["T_REPORTED_STUDENT_OWNER_ID"]);o.My_Reported_student.DESCRIPTION = GV<String>(X["T_REPORTED_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher> Get_Teacher_By_Where_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher> oList = new List<Teacher>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher o = new Teacher();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.FIRST_NAME = GV<String>(X["T_USER_FIRST_NAME"]);o.My_User.LAST_NAME = GV<String>(X["T_USER_LAST_NAME"]);o.My_User.MOBILE = GV<String>(X["T_USER_MOBILE"]);o.My_User.DOB = GV<String>(X["T_USER_DOB"]);o.My_User.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_USER_TYPE_CODE_ID"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_category> Get_Teacher_category_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_category> oList = new List<Teacher_category>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_CATEGORY_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_category o = new Teacher_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_favorite> Get_Teacher_favorite_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_favorite> oList = new List<Teacher_favorite>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_FAVORITE_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_favorite o = new Teacher_favorite();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Teacher_report> Get_Teacher_report_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Teacher_report> oList = new List<Teacher_report>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.TEACHER_ID_LIST = string.Join(",", TEACHER_ID_LIST.ToArray()); p.STUDENT_ID_LIST = string.Join(",", STUDENT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEACHER_REPORT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Teacher_report o = new Teacher_report();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Teacher = new Teacher();
o.My_Teacher.TEACHER_ID = GV<Int32>(X["T_TEACHER_TEACHER_ID"]);o.My_Teacher.USER_ID = GV<Int64>(X["T_TEACHER_USER_ID"]);o.My_Teacher.IS_VALID = GV<Boolean>(X["T_TEACHER_IS_VALID"]);o.My_Teacher.USER_TYPE_CODE_ID = GV<Int32>(X["T_TEACHER_USER_TYPE_CODE_ID"]);o.My_Teacher.SCORE = GV<Int32>(X["T_TEACHER_SCORE"]);o.My_Teacher.IS_BLOCKED = GV<Boolean>(X["T_TEACHER_IS_BLOCKED"]);o.My_Teacher.CATEGORY_ID = GV<Int32>(X["T_TEACHER_CATEGORY_ID"]);o.My_Teacher.ENTRY_USER_ID = GV<Int64>(X["T_TEACHER_ENTRY_USER_ID"]);o.My_Teacher.ENTRY_DATE = GV<String>(X["T_TEACHER_ENTRY_DATE"]);o.My_Teacher.OWNER_ID = GV<Int32>(X["T_TEACHER_OWNER_ID"]);o.My_Teacher.DESCRIPTION = GV<String>(X["T_TEACHER_DESCRIPTION"]);
o.My_Student = new Student();
o.My_Student.STUDENT_ID = GV<Int32>(X["T_STUDENT_STUDENT_ID"]);o.My_Student.USER_ID = GV<Int64>(X["T_STUDENT_USER_ID"]);o.My_Student.USER_TYPE_CODE_ID = GV<Int32>(X["T_STUDENT_USER_TYPE_CODE_ID"]);o.My_Student.IS_BLOCKED = GV<Boolean>(X["T_STUDENT_IS_BLOCKED"]);o.My_Student.ENTRY_USER_ID = GV<Int64>(X["T_STUDENT_ENTRY_USER_ID"]);o.My_Student.ENTRY_DATE = GV<String>(X["T_STUDENT_ENTRY_DATE"]);o.My_Student.OWNER_ID = GV<Int32>(X["T_STUDENT_OWNER_ID"]);o.My_Student.DESCRIPTION = GV<String>(X["T_STUDENT_DESCRIPTION"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_InList_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_InList_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User_type_code = new User_type_code();
o.My_User_type_code.USER_TYPE_CODE_ID = GV<Int32>(X["T_USER_TYPE_CODE_USER_TYPE_CODE_ID"]);o.My_User_type_code.USER_TYPE_CODE = GV<String>(X["T_USER_TYPE_CODE_USER_TYPE_CODE"]);o.My_User_type_code.DESCRIPTION = GV<String>(X["T_USER_TYPE_CODE_DESCRIPTION"]);o.My_User_type_code.ENTRY_USER_ID = GV<Int64>(X["T_USER_TYPE_CODE_ENTRY_USER_ID"]);o.My_User_type_code.ENTRY_DATE = GV<String>(X["T_USER_TYPE_CODE_ENTRY_DATE"]);o.My_User_type_code.OWNER_ID = GV<Int32>(X["T_USER_TYPE_CODE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_InList_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_InList_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.MOBILE = MOBILE; p.DOB = DOB; p.USER_TYPE_CODE_ID_LIST = string.Join(",", USER_TYPE_CODE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Address ( long? ADDRESS_ID)
{
var p = new { ADDRESS_ID = ADDRESS_ID };
ExecuteDelete("UPG_DELETE_ADDRESS", p);
}
public void Delete_Answer ( Int32? ANSWER_ID)
{
var p = new { ANSWER_ID = ANSWER_ID };
ExecuteDelete("UPG_DELETE_ANSWER", p);
}
public void Delete_Category ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_CATEGORY", p);
}
public void Delete_Category_favorite ( Int32? CATEGORY_FAVORITE_ID)
{
var p = new { CATEGORY_FAVORITE_ID = CATEGORY_FAVORITE_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_FAVORITE", p);
}
public void Delete_Contact ( Int32? CONTACT_ID)
{
var p = new { CONTACT_ID = CONTACT_ID };
ExecuteDelete("UPG_DELETE_CONTACT", p);
}
public void Delete_Evaluation ( Int32? EVALUATION_ID)
{
var p = new { EVALUATION_ID = EVALUATION_ID };
ExecuteDelete("UPG_DELETE_EVALUATION", p);
}
public void Delete_Favorite_teacher ( Int32? FAVORITE_TEACHER_ID)
{
var p = new { FAVORITE_TEACHER_ID = FAVORITE_TEACHER_ID };
ExecuteDelete("UPG_DELETE_FAVORITE_TEACHER", p);
}
public void Delete_Loc_l1 ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L1", p);
}
public void Delete_Loc_l2 ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L2", p);
}
public void Delete_Loc_l3 ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L3", p);
}
public void Delete_Loc_l4 ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_LOC_L4", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Person ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_PERSON", p);
}
public void Delete_Question ( Int32? QUESTION_ID)
{
var p = new { QUESTION_ID = QUESTION_ID };
ExecuteDelete("UPG_DELETE_QUESTION", p);
}
public void Delete_Question_token ( Int32? QUESTION_TOKEN_ID)
{
var p = new { QUESTION_TOKEN_ID = QUESTION_TOKEN_ID };
ExecuteDelete("UPG_DELETE_QUESTION_TOKEN", p);
}
public void Delete_Student ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_STUDENT", p);
}
public void Delete_Student_report ( Int32? STUDENT_REPORT_ID)
{
var p = new { STUDENT_REPORT_ID = STUDENT_REPORT_ID };
ExecuteDelete("UPG_DELETE_STUDENT_REPORT", p);
}
public void Delete_Teacher ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_TEACHER", p);
}
public void Delete_Teacher_category ( Int32? TEACHER_CATEGORY_ID)
{
var p = new { TEACHER_CATEGORY_ID = TEACHER_CATEGORY_ID };
ExecuteDelete("UPG_DELETE_TEACHER_CATEGORY", p);
}
public void Delete_Teacher_favorite ( Int32? TEACHER_FAVORITE_ID)
{
var p = new { TEACHER_FAVORITE_ID = TEACHER_FAVORITE_ID };
ExecuteDelete("UPG_DELETE_TEACHER_FAVORITE", p);
}
public void Delete_Teacher_report ( Int32? TEACHER_REPORT_ID)
{
var p = new { TEACHER_REPORT_ID = TEACHER_REPORT_ID };
ExecuteDelete("UPG_DELETE_TEACHER_REPORT", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_User_type_code ( Int32? USER_TYPE_CODE_ID)
{
var p = new { USER_TYPE_CODE_ID = USER_TYPE_CODE_ID };
ExecuteDelete("UPG_DELETE_USER_TYPE_CODE", p);
}
public void Delete_Address_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID", p);
}
public void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L1_ID", p);
}
public void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L2_ID", p);
}
public void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L3_ID", p);
}
public void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_OWNER_ID", p);
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
var p = new { PERSON_ID = PERSON_ID,ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
}
public void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L4_ID", p);
}
public void Delete_Answer_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ANSWER_BY_OWNER_ID", p);
}
public void Delete_Answer_By_QUESTION_ID ( Int32? QUESTION_ID)
{
var p = new { QUESTION_ID = QUESTION_ID };
ExecuteDelete("UPG_DELETE_ANSWER_BY_QUESTION_ID", p);
}
public void Delete_Answer_By_TEACHER_ID ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_ANSWER_BY_TEACHER_ID", p);
}
public void Delete_Answer_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_ANSWER_BY_STUDENT_ID", p);
}
public void Delete_Category_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_BY_OWNER_ID", p);
}
public void Delete_Category_favorite_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_FAVORITE_BY_OWNER_ID", p);
}
public void Delete_Category_favorite_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_FAVORITE_BY_STUDENT_ID", p);
}
public void Delete_Category_favorite_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_FAVORITE_BY_CATEGORY_ID", p);
}
public void Delete_Contact_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID", p);
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
var p = new { PERSON_ID = PERSON_ID,CONTACT_TYPE_CODE = CONTACT_TYPE_CODE,CONTACT = CONTACT };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
}
public void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_OWNER_ID", p);
}
public void Delete_Evaluation_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_EVALUATION_BY_OWNER_ID", p);
}
public void Delete_Evaluation_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_EVALUATION_BY_STUDENT_ID", p);
}
public void Delete_Evaluation_By_ANSWER_ID ( Int32? ANSWER_ID)
{
var p = new { ANSWER_ID = ANSWER_ID };
ExecuteDelete("UPG_DELETE_EVALUATION_BY_ANSWER_ID", p);
}
public void Delete_Favorite_teacher_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_FAVORITE_TEACHER_BY_OWNER_ID", p);
}
public void Delete_Favorite_teacher_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_FAVORITE_TEACHER_BY_STUDENT_ID", p);
}
public void Delete_Favorite_teacher_By_TEACHER_ID ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_FAVORITE_TEACHER_BY_TEACHER_ID", p);
}
public void Delete_Loc_l1_By_CODE ( string CODE)
{
var p = new { CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_CODE", p);
}
public void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_OWNER_ID", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
var p = new { LOC_L1_ID = LOC_L1_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID_CODE", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID", p);
}
public void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_OWNER_ID", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
var p = new { LOC_L2_ID = LOC_L2_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID_CODE", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID", p);
}
public void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_OWNER_ID", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
var p = new { LOC_L3_ID = LOC_L3_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID_CODE", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID", p);
}
public void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_OWNER_ID", p);
}
public void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PERSON_BY_OWNER_ID", p);
}
public void Delete_Question_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_QUESTION_BY_OWNER_ID", p);
}
public void Delete_Question_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_QUESTION_BY_STUDENT_ID", p);
}
public void Delete_Question_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_QUESTION_BY_CATEGORY_ID", p);
}
public void Delete_Question_By_TEACHER_ID ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_QUESTION_BY_TEACHER_ID", p);
}
public void Delete_Question_token_By_PART ( string PART)
{
var p = new { PART = PART };
ExecuteDelete("UPG_DELETE_QUESTION_TOKEN_BY_PART", p);
}
public void Delete_Question_token_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_QUESTION_TOKEN_BY_OWNER_ID", p);
}
public void Delete_Question_token_By_QUESTION_ID ( Int32? QUESTION_ID)
{
var p = new { QUESTION_ID = QUESTION_ID };
ExecuteDelete("UPG_DELETE_QUESTION_TOKEN_BY_QUESTION_ID", p);
}
public void Delete_Student_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STUDENT_BY_OWNER_ID", p);
}
public void Delete_Student_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
var p = new { USER_TYPE_CODE_ID = USER_TYPE_CODE_ID };
ExecuteDelete("UPG_DELETE_STUDENT_BY_USER_TYPE_CODE_ID", p);
}
public void Delete_Student_By_USER_ID ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_STUDENT_BY_USER_ID", p);
}
public void Delete_Student_report_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STUDENT_REPORT_BY_OWNER_ID", p);
}
public void Delete_Student_report_By_REPORTED_BY_STUDENT_ID ( Int32? REPORTED_BY_STUDENT_ID)
{
var p = new { REPORTED_BY_STUDENT_ID = REPORTED_BY_STUDENT_ID };
ExecuteDelete("UPG_DELETE_STUDENT_REPORT_BY_REPORTED_BY_STUDENT_ID", p);
}
public void Delete_Student_report_By_REPORTED_STUDENT_ID ( Int32? REPORTED_STUDENT_ID)
{
var p = new { REPORTED_STUDENT_ID = REPORTED_STUDENT_ID };
ExecuteDelete("UPG_DELETE_STUDENT_REPORT_BY_REPORTED_STUDENT_ID", p);
}
public void Delete_Teacher_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_BY_OWNER_ID", p);
}
public void Delete_Teacher_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_TEACHER_BY_CATEGORY_ID", p);
}
public void Delete_Teacher_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
var p = new { USER_TYPE_CODE_ID = USER_TYPE_CODE_ID };
ExecuteDelete("UPG_DELETE_TEACHER_BY_USER_TYPE_CODE_ID", p);
}
public void Delete_Teacher_By_USER_ID ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_BY_USER_ID", p);
}
public void Delete_Teacher_category_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_CATEGORY_BY_OWNER_ID", p);
}
public void Delete_Teacher_category_By_TEACHER_ID ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_CATEGORY_BY_TEACHER_ID", p);
}
public void Delete_Teacher_category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_TEACHER_CATEGORY_BY_CATEGORY_ID", p);
}
public void Delete_Teacher_favorite_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_FAVORITE_BY_OWNER_ID", p);
}
public void Delete_Teacher_favorite_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_TEACHER_FAVORITE_BY_STUDENT_ID", p);
}
public void Delete_Teacher_favorite_By_TEACHER_ID ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_FAVORITE_BY_TEACHER_ID", p);
}
public void Delete_Teacher_report_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_REPORT_BY_OWNER_ID", p);
}
public void Delete_Teacher_report_By_TEACHER_ID ( Int32? TEACHER_ID)
{
var p = new { TEACHER_ID = TEACHER_ID };
ExecuteDelete("UPG_DELETE_TEACHER_REPORT_BY_TEACHER_ID", p);
}
public void Delete_Teacher_report_By_STUDENT_ID ( Int32? STUDENT_ID)
{
var p = new { STUDENT_ID = STUDENT_ID };
ExecuteDelete("UPG_DELETE_TEACHER_REPORT_BY_STUDENT_ID", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public void Delete_User_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID)
{
var p = new { USER_TYPE_CODE_ID = USER_TYPE_CODE_ID };
ExecuteDelete("UPG_DELETE_USER_BY_USER_TYPE_CODE_ID", p);
}
public void Delete_User_By_EMAIL ( string EMAIL)
{
var p = new { EMAIL = EMAIL };
ExecuteDelete("UPG_DELETE_USER_BY_EMAIL", p);
}
public void Delete_User_type_code_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_TYPE_CODE_BY_OWNER_ID", p);
}
public long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Address oAddress = new Address();
oAddress.ADDRESS_ID = ADDRESS_ID;oAddress.PERSON_ID = PERSON_ID;oAddress.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;oAddress.LOC_L1_ID = LOC_L1_ID;oAddress.LOC_L2_ID = LOC_L2_ID;oAddress.LOC_L3_ID = LOC_L3_ID;oAddress.LOC_L4_ID = LOC_L4_ID;oAddress.STREET = STREET;oAddress.BUILDING = BUILDING;oAddress.FLOOR = FLOOR;oAddress.POBOX = POBOX;oAddress.VALID_DATE_START = VALID_DATE_START;oAddress.VALID_DATE_END = VALID_DATE_END;oAddress.NOTES = NOTES;oAddress.ENTRY_DATE = ENTRY_DATE;oAddress.ENTRY_USER_ID = ENTRY_USER_ID;oAddress.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADDRESS", oAddress, "ADDRESS_ID");
return oAddress.ADDRESS_ID;
}
public Int32? Edit_Answer ( Int32? ANSWER_ID, Int32? QUESTION_ID, Int32? TEACHER_ID, Int32? STUDENT_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Answer oAnswer = new Answer();
oAnswer.ANSWER_ID = ANSWER_ID;oAnswer.QUESTION_ID = QUESTION_ID;oAnswer.TEACHER_ID = TEACHER_ID;oAnswer.STUDENT_ID = STUDENT_ID;oAnswer.DESCRIPTION = DESCRIPTION;oAnswer.ENTRY_USER_ID = ENTRY_USER_ID;oAnswer.ENTRY_DATE = ENTRY_DATE;oAnswer.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ANSWER", oAnswer, "ANSWER_ID");
return oAnswer.ANSWER_ID;
}
public Int32? Edit_Category ( Int32? CATEGORY_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Category oCategory = new Category();
oCategory.CATEGORY_ID = CATEGORY_ID;oCategory.NAME = NAME;oCategory.DESCRIPTION = DESCRIPTION;oCategory.ENTRY_USER_ID = ENTRY_USER_ID;oCategory.ENTRY_DATE = ENTRY_DATE;oCategory.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CATEGORY", oCategory, "CATEGORY_ID");
return oCategory.CATEGORY_ID;
}
public Int32? Edit_Category_favorite ( Int32? CATEGORY_FAVORITE_ID, Int32? STUDENT_ID, Int32? CATEGORY_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Category_favorite oCategory_favorite = new Category_favorite();
oCategory_favorite.CATEGORY_FAVORITE_ID = CATEGORY_FAVORITE_ID;oCategory_favorite.STUDENT_ID = STUDENT_ID;oCategory_favorite.CATEGORY_ID = CATEGORY_ID;oCategory_favorite.DESCRIPTION = DESCRIPTION;oCategory_favorite.ENTRY_USER_ID = ENTRY_USER_ID;oCategory_favorite.ENTRY_DATE = ENTRY_DATE;oCategory_favorite.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CATEGORY_FAVORITE", oCategory_favorite, "CATEGORY_FAVORITE_ID");
return oCategory_favorite.CATEGORY_FAVORITE_ID;
}
public Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Contact oContact = new Contact();
oContact.CONTACT_ID = CONTACT_ID;oContact.PERSON_ID = PERSON_ID;oContact.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE;oContact.CONTACT = CONTACT;oContact.DESCRIPTION = DESCRIPTION;oContact.ENTRY_USER_ID = ENTRY_USER_ID;oContact.ENTRY_DATE = ENTRY_DATE;oContact.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CONTACT", oContact, "CONTACT_ID");
return oContact.CONTACT_ID;
}
public Int32? Edit_Evaluation ( Int32? EVALUATION_ID, Int32? STUDENT_ID, Int32? ANSWER_ID, Int32? SCORE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Evaluation oEvaluation = new Evaluation();
oEvaluation.EVALUATION_ID = EVALUATION_ID;oEvaluation.STUDENT_ID = STUDENT_ID;oEvaluation.ANSWER_ID = ANSWER_ID;oEvaluation.SCORE = SCORE;oEvaluation.ENTRY_USER_ID = ENTRY_USER_ID;oEvaluation.ENTRY_DATE = ENTRY_DATE;oEvaluation.OWNER_ID = OWNER_ID;oEvaluation.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_EVALUATION", oEvaluation, "EVALUATION_ID");
return oEvaluation.EVALUATION_ID;
}
public Int32? Edit_Favorite_teacher ( Int32? FAVORITE_TEACHER_ID, Int32? STUDENT_ID, Int32? TEACHER_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Favorite_teacher oFavorite_teacher = new Favorite_teacher();
oFavorite_teacher.FAVORITE_TEACHER_ID = FAVORITE_TEACHER_ID;oFavorite_teacher.STUDENT_ID = STUDENT_ID;oFavorite_teacher.TEACHER_ID = TEACHER_ID;oFavorite_teacher.DESCRIPTION = DESCRIPTION;oFavorite_teacher.ENTRY_USER_ID = ENTRY_USER_ID;oFavorite_teacher.ENTRY_DATE = ENTRY_DATE;oFavorite_teacher.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_FAVORITE_TEACHER", oFavorite_teacher, "FAVORITE_TEACHER_ID");
return oFavorite_teacher.FAVORITE_TEACHER_ID;
}
public long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l1 oLoc_l1 = new Loc_l1();
oLoc_l1.LOC_L1_ID = LOC_L1_ID;oLoc_l1.CODE = CODE;oLoc_l1.DESCRIPTION = DESCRIPTION;oLoc_l1.NOTES = NOTES;oLoc_l1.ENTRY_DATE = ENTRY_DATE;oLoc_l1.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l1.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L1", oLoc_l1, "LOC_L1_ID");
return oLoc_l1.LOC_L1_ID;
}
public long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l2 oLoc_l2 = new Loc_l2();
oLoc_l2.LOC_L2_ID = LOC_L2_ID;oLoc_l2.CODE = CODE;oLoc_l2.DESCRIPTION = DESCRIPTION;oLoc_l2.LOC_L1_ID = LOC_L1_ID;oLoc_l2.NOTES = NOTES;oLoc_l2.ENTRY_DATE = ENTRY_DATE;oLoc_l2.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l2.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L2", oLoc_l2, "LOC_L2_ID");
return oLoc_l2.LOC_L2_ID;
}
public long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l3 oLoc_l3 = new Loc_l3();
oLoc_l3.LOC_L3_ID = LOC_L3_ID;oLoc_l3.CODE = CODE;oLoc_l3.DESCRIPTION = DESCRIPTION;oLoc_l3.LOC_L2_ID = LOC_L2_ID;oLoc_l3.NOTES = NOTES;oLoc_l3.ENTRY_DATE = ENTRY_DATE;oLoc_l3.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l3.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L3", oLoc_l3, "LOC_L3_ID");
return oLoc_l3.LOC_L3_ID;
}
public long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l4 oLoc_l4 = new Loc_l4();
oLoc_l4.LOC_L4_ID = LOC_L4_ID;oLoc_l4.CODE = CODE;oLoc_l4.DESCRIPTION = DESCRIPTION;oLoc_l4.LOC_L3_ID = LOC_L3_ID;oLoc_l4.NOTES = NOTES;oLoc_l4.ENTRY_DATE = ENTRY_DATE;oLoc_l4.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l4.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L4", oLoc_l4, "LOC_L4_ID");
return oLoc_l4.LOC_L4_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE)
{
Person oPerson = new Person();
oPerson.PERSON_ID = PERSON_ID;oPerson.FIRST_NAME = FIRST_NAME;oPerson.LAST_NAME = LAST_NAME;oPerson.FATHER_NAME = FATHER_NAME;oPerson.MOTHER_NAME = MOTHER_NAME;oPerson.TITLE_CODE = TITLE_CODE;oPerson.GENDER_CODE = GENDER_CODE;oPerson.RELIGION_CODE = RELIGION_CODE;oPerson.BIRTH_DATE = BIRTH_DATE;oPerson.IS_BLOCKED = IS_BLOCKED;oPerson.DESCRIPTION = DESCRIPTION;oPerson.OWNER_ID = OWNER_ID;oPerson.ENTRY_USER_ID = ENTRY_USER_ID;oPerson.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_PERSON", oPerson, "PERSON_ID");
return oPerson.PERSON_ID;
}
public Int32? Edit_Question ( Int32? QUESTION_ID, Int32? STUDENT_ID, Int32? CATEGORY_ID, Int32? TEACHER_ID, string DESCRIPTION, bool? IS_ANSWERED, bool? IS_PUBLIC, bool? IS_SELF_CLOSED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Question oQuestion = new Question();
oQuestion.QUESTION_ID = QUESTION_ID;oQuestion.STUDENT_ID = STUDENT_ID;oQuestion.CATEGORY_ID = CATEGORY_ID;oQuestion.TEACHER_ID = TEACHER_ID;oQuestion.DESCRIPTION = DESCRIPTION;oQuestion.IS_ANSWERED = IS_ANSWERED;oQuestion.IS_PUBLIC = IS_PUBLIC;oQuestion.IS_SELF_CLOSED = IS_SELF_CLOSED;oQuestion.ENTRY_USER_ID = ENTRY_USER_ID;oQuestion.ENTRY_DATE = ENTRY_DATE;oQuestion.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_QUESTION", oQuestion, "QUESTION_ID");
return oQuestion.QUESTION_ID;
}
public Int32? Edit_Question_token ( Int32? QUESTION_TOKEN_ID, Int32? QUESTION_ID, string PART, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Question_token oQuestion_token = new Question_token();
oQuestion_token.QUESTION_TOKEN_ID = QUESTION_TOKEN_ID;oQuestion_token.QUESTION_ID = QUESTION_ID;oQuestion_token.PART = PART;oQuestion_token.ENTRY_USER_ID = ENTRY_USER_ID;oQuestion_token.ENTRY_DATE = ENTRY_DATE;oQuestion_token.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_QUESTION_TOKEN", oQuestion_token, "QUESTION_TOKEN_ID");
return oQuestion_token.QUESTION_TOKEN_ID;
}
public Int32? Edit_Student ( Int32? STUDENT_ID, long? USER_ID, Int32? USER_TYPE_CODE_ID, bool? IS_BLOCKED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Student oStudent = new Student();
oStudent.STUDENT_ID = STUDENT_ID;oStudent.USER_ID = USER_ID;oStudent.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;oStudent.IS_BLOCKED = IS_BLOCKED;oStudent.ENTRY_USER_ID = ENTRY_USER_ID;oStudent.ENTRY_DATE = ENTRY_DATE;oStudent.OWNER_ID = OWNER_ID;oStudent.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_STUDENT", oStudent, "STUDENT_ID");
return oStudent.STUDENT_ID;
}
public Int32? Edit_Student_report ( Int32? STUDENT_REPORT_ID, Int32? REPORTED_BY_STUDENT_ID, Int32? REPORTED_STUDENT_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Student_report oStudent_report = new Student_report();
oStudent_report.STUDENT_REPORT_ID = STUDENT_REPORT_ID;oStudent_report.REPORTED_BY_STUDENT_ID = REPORTED_BY_STUDENT_ID;oStudent_report.REPORTED_STUDENT_ID = REPORTED_STUDENT_ID;oStudent_report.DESCRIPTION = DESCRIPTION;oStudent_report.ENTRY_USER_ID = ENTRY_USER_ID;oStudent_report.ENTRY_DATE = ENTRY_DATE;oStudent_report.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_STUDENT_REPORT", oStudent_report, "STUDENT_REPORT_ID");
return oStudent_report.STUDENT_REPORT_ID;
}
public Int32? Edit_Teacher ( Int32? TEACHER_ID, long? USER_ID, bool? IS_VALID, Int32? USER_TYPE_CODE_ID, Int32? SCORE, bool? IS_BLOCKED, Int32? CATEGORY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Teacher oTeacher = new Teacher();
oTeacher.TEACHER_ID = TEACHER_ID;oTeacher.USER_ID = USER_ID;oTeacher.IS_VALID = IS_VALID;oTeacher.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;oTeacher.SCORE = SCORE;oTeacher.IS_BLOCKED = IS_BLOCKED;oTeacher.CATEGORY_ID = CATEGORY_ID;oTeacher.ENTRY_USER_ID = ENTRY_USER_ID;oTeacher.ENTRY_DATE = ENTRY_DATE;oTeacher.OWNER_ID = OWNER_ID;oTeacher.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_TEACHER", oTeacher, "TEACHER_ID");
return oTeacher.TEACHER_ID;
}
public Int32? Edit_Teacher_category ( Int32? TEACHER_CATEGORY_ID, Int32? TEACHER_ID, Int32? CATEGORY_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Teacher_category oTeacher_category = new Teacher_category();
oTeacher_category.TEACHER_CATEGORY_ID = TEACHER_CATEGORY_ID;oTeacher_category.TEACHER_ID = TEACHER_ID;oTeacher_category.CATEGORY_ID = CATEGORY_ID;oTeacher_category.DESCRIPTION = DESCRIPTION;oTeacher_category.ENTRY_USER_ID = ENTRY_USER_ID;oTeacher_category.ENTRY_DATE = ENTRY_DATE;oTeacher_category.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TEACHER_CATEGORY", oTeacher_category, "TEACHER_CATEGORY_ID");
return oTeacher_category.TEACHER_CATEGORY_ID;
}
public Int32? Edit_Teacher_favorite ( Int32? TEACHER_FAVORITE_ID, Int32? STUDENT_ID, Int32? TEACHER_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Teacher_favorite oTeacher_favorite = new Teacher_favorite();
oTeacher_favorite.TEACHER_FAVORITE_ID = TEACHER_FAVORITE_ID;oTeacher_favorite.STUDENT_ID = STUDENT_ID;oTeacher_favorite.TEACHER_ID = TEACHER_ID;oTeacher_favorite.DESCRIPTION = DESCRIPTION;oTeacher_favorite.ENTRY_USER_ID = ENTRY_USER_ID;oTeacher_favorite.ENTRY_DATE = ENTRY_DATE;oTeacher_favorite.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TEACHER_FAVORITE", oTeacher_favorite, "TEACHER_FAVORITE_ID");
return oTeacher_favorite.TEACHER_FAVORITE_ID;
}
public Int32? Edit_Teacher_report ( Int32? TEACHER_REPORT_ID, Int32? TEACHER_ID, Int32? STUDENT_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Teacher_report oTeacher_report = new Teacher_report();
oTeacher_report.TEACHER_REPORT_ID = TEACHER_REPORT_ID;oTeacher_report.TEACHER_ID = TEACHER_ID;oTeacher_report.STUDENT_ID = STUDENT_ID;oTeacher_report.DESCRIPTION = DESCRIPTION;oTeacher_report.ENTRY_USER_ID = ENTRY_USER_ID;oTeacher_report.ENTRY_DATE = ENTRY_DATE;oTeacher_report.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TEACHER_REPORT", oTeacher_report, "TEACHER_REPORT_ID");
return oTeacher_report.TEACHER_REPORT_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? USER_TYPE_CODE_ID, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.EMAIL = EMAIL;oUser.FIRST_NAME = FIRST_NAME;oUser.LAST_NAME = LAST_NAME;oUser.MOBILE = MOBILE;oUser.DOB = DOB;oUser.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public Int32? Edit_User_type_code ( Int32? USER_TYPE_CODE_ID, string USER_TYPE_CODE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
User_type_code oUser_type_code = new User_type_code();
oUser_type_code.USER_TYPE_CODE_ID = USER_TYPE_CODE_ID;oUser_type_code.USER_TYPE_CODE = USER_TYPE_CODE;oUser_type_code.DESCRIPTION = DESCRIPTION;oUser_type_code.ENTRY_USER_ID = ENTRY_USER_ID;oUser_type_code.ENTRY_DATE = ENTRY_DATE;oUser_type_code.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_USER_TYPE_CODE", oUser_type_code, "USER_TYPE_CODE_ID");
return oUser_type_code.USER_TYPE_CODE_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADDRESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADDRESS_ID = GV<Int64>(X["ADDRESS_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.ADDRESS_TYPE_CODE = GV<String>(X["ADDRESS_TYPE_CODE"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.STREET = GV<String>(X["STREET"]);o.BUILDING = GV<String>(X["BUILDING"]);o.FLOOR = GV<String>(X["FLOOR"]);o.POBOX = GV<String>(X["POBOX"]);o.VALID_DATE_START = GV<String>(X["VALID_DATE_START"]);o.VALID_DATE_END = GV<String>(X["VALID_DATE_END"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ANSWER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ANSWER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ANSWER_ID = GV<Int32>(X["ANSWER_ID"]);o.QUESTION_ID = GV<Int32>(X["QUESTION_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CATEGORY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CATEGORY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CATEGORY_FAVORITE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CATEGORY_FAVORITE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CATEGORY_FAVORITE_ID = GV<Int32>(X["CATEGORY_FAVORITE_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CONTACT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CONTACT_ID = GV<Int32>(X["CONTACT_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.CONTACT_TYPE_CODE = GV<String>(X["CONTACT_TYPE_CODE"]);o.CONTACT = GV<String>(X["CONTACT"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_EVALUATION ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_EVALUATION", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.EVALUATION_ID = GV<Int32>(X["EVALUATION_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.ANSWER_ID = GV<Int32>(X["ANSWER_ID"]);o.SCORE = GV<Int32>(X["SCORE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_FAVORITE_TEACHER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_FAVORITE_TEACHER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FAVORITE_TEACHER_ID = GV<Int32>(X["FAVORITE_TEACHER_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L1", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L2", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L3", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L4", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PERSON", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.FATHER_NAME = GV<String>(X["FATHER_NAME"]);o.MOTHER_NAME = GV<String>(X["MOTHER_NAME"]);o.TITLE_CODE = GV<String>(X["TITLE_CODE"]);o.GENDER_CODE = GV<String>(X["GENDER_CODE"]);o.RELIGION_CODE = GV<String>(X["RELIGION_CODE"]);o.BIRTH_DATE = GV<String>(X["BIRTH_DATE"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_QUESTION ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_QUESTION", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.QUESTION_ID = GV<Int32>(X["QUESTION_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.IS_ANSWERED = GV<Boolean>(X["IS_ANSWERED"]);o.IS_PUBLIC = GV<Boolean>(X["IS_PUBLIC"]);o.IS_SELF_CLOSED = GV<Boolean>(X["IS_SELF_CLOSED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_QUESTION_TOKEN ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_QUESTION_TOKEN", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.QUESTION_TOKEN_ID = GV<Int32>(X["QUESTION_TOKEN_ID"]);o.QUESTION_ID = GV<Int32>(X["QUESTION_ID"]);o.PART = GV<String>(X["PART"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STUDENT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STUDENT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.USER_ID = GV<Int64>(X["USER_ID"]);o.USER_TYPE_CODE_ID = GV<Int32>(X["USER_TYPE_CODE_ID"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STUDENT_REPORT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STUDENT_REPORT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STUDENT_REPORT_ID = GV<Int32>(X["STUDENT_REPORT_ID"]);o.REPORTED_BY_STUDENT_ID = GV<Int32>(X["REPORTED_BY_STUDENT_ID"]);o.REPORTED_STUDENT_ID = GV<Int32>(X["REPORTED_STUDENT_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_TEACHER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_TEACHER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.USER_ID = GV<Int64>(X["USER_ID"]);o.IS_VALID = GV<Boolean>(X["IS_VALID"]);o.USER_TYPE_CODE_ID = GV<Int32>(X["USER_TYPE_CODE_ID"]);o.SCORE = GV<Int32>(X["SCORE"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_TEACHER_CATEGORY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_TEACHER_CATEGORY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TEACHER_CATEGORY_ID = GV<Int32>(X["TEACHER_CATEGORY_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_TEACHER_FAVORITE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_TEACHER_FAVORITE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TEACHER_FAVORITE_ID = GV<Int32>(X["TEACHER_FAVORITE_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_TEACHER_REPORT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_TEACHER_REPORT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TEACHER_REPORT_ID = GV<Int32>(X["TEACHER_REPORT_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.MOBILE = GV<String>(X["MOBILE"]);o.DOB = GV<String>(X["DOB"]);o.USER_TYPE_CODE_ID = GV<Int32>(X["USER_TYPE_CODE_ID"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER_TYPE_CODE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER_TYPE_CODE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_TYPE_CODE_ID = GV<Int32>(X["USER_TYPE_CODE_ID"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHANGE_IS_ANSWERED_TO_TRUE ( Int32? QUESTION_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHANGE_IS_ANSWERED_TO_TRUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHANGE_IS_BLOCKED_TO_TRUE ( Int32? STUDENT_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHANGE_IS_BLOCKED_TO_TRUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_ANSWER_WITH_NAMES_BY_QUESTION_ID ( Int32? QUESTION_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.QUESTION_ID = QUESTION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_ANSWER_WITH_NAMES_BY_QUESTION_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.QUESTION_ID = GV<Int32>(X["QUESTION_ID"]);o.ANSWER_ID = GV<Int32>(X["ANSWER_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.ANSWER = GV<String>(X["ANSWER"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.QUESTION = GV<String>(X["QUESTION"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.STUDENT_FIRST_NAME = GV<String>(X["STUDENT_FIRST_NAME"]);o.STUDENT_LAST_NAME = GV<String>(X["STUDENT_LAST_NAME"]);o.USER_ID = GV<Int64>(X["USER_ID"]);o.TEACHTER_F_NAME = GV<String>(X["TEACHTER_F_NAME"]);o.TEACHTER_L_NAME = GV<String>(X["TEACHTER_L_NAME"]);o.TEACHTER_USER_ID = GV<Int64>(X["TEACHTER_USER_ID"]);o.QUESTION_ID = GV<Int32>(X["QUESTION_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_AVERAGE_BY_STUDENT ( decimal ANSWER)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ANSWER = ANSWER;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_AVERAGE_BY_STUDENT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.AVG = GV<Decimal>(X["AVG"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_AVERAGE_BY_TEACHER ( decimal ANSWER)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ANSWER = ANSWER;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_AVERAGE_BY_TEACHER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_TOP_N_TEACHERS ( Int32? NUMBER_OF_TEACHERS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.NUMBER_OF_TEACHERS = NUMBER_OF_TEACHERS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_TOP_N_TEACHERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.EMAIL = GV<String>(X["EMAIL"]);o.MOBILE = GV<String>(X["MOBILE"]);o.DOB = GV<String>(X["DOB"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.USER_ID = GV<Int64>(X["USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_Get_User_By_Email ( string EMAIL)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_Get_User_By_Email", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.MOBILE = GV<String>(X["MOBILE"]);o.DOB = GV<String>(X["DOB"]);o.USER_TYPE_CODE_ID = GV<Int32>(X["USER_TYPE_CODE_ID"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.FTS = GV<String>(X["FTS"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_LIMIT_QUESTIONS ( Int32? STUDENT_ID, Int32? LIMIT_PER_DAY)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STUDENT_ID = STUDENT_ID; p.LIMIT_PER_DAY = LIMIT_PER_DAY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_LIMIT_QUESTIONS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.QUESTION_ID = GV<Int32>(X["QUESTION_ID"]);o.STUDENT_ID = GV<Int32>(X["STUDENT_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.TEACHER_ID = GV<Int32>(X["TEACHER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.IS_ANSWERED = GV<Boolean>(X["IS_ANSWERED"]);o.IS_PUBLIC = GV<Boolean>(X["IS_PUBLIC"]);o.IS_SELF_CLOSED = GV<Boolean>(X["IS_SELF_CLOSED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
}
}
