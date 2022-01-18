using System;
using System.Collections.Generic;
namespace DALC
{
#region Entities
public partial class Address
{
public long? ADDRESS_ID {get;set;}
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public long? LOC_L1_ID {get;set;}
public long? LOC_L2_ID {get;set;}
public long? LOC_L3_ID {get;set;}
public long? LOC_L4_ID {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
}
public partial class Answer
{
public Int32? ANSWER_ID {get;set;}
public Int32? QUESTION_ID {get;set;}
public Int32? TEACHER_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Question My_Question {get;set;}
public Teacher My_Teacher {get;set;}
public Student My_Student {get;set;}
}
public partial class Category
{
public Int32? CATEGORY_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Category_favorite
{
public Int32? CATEGORY_FAVORITE_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public Int32? CATEGORY_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Student My_Student {get;set;}
public Category My_Category {get;set;}
}
public partial class Contact
{
public Int32? CONTACT_ID {get;set;}
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
}
public partial class Evaluation
{
public Int32? EVALUATION_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public Int32? ANSWER_ID {get;set;}
public Int32? SCORE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Student My_Student {get;set;}
public Answer My_Answer {get;set;}
}
public partial class Favorite_teacher
{
public Int32? FAVORITE_TEACHER_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public Int32? TEACHER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Student My_Student {get;set;}
public Teacher My_Teacher {get;set;}
}
public partial class Loc_l1
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l2
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L1_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
}
public partial class Loc_l3
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L2_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
}
public partial class Loc_l4
{
public long? LOC_L4_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L3_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Person
{
public long? PERSON_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public bool? IS_BLOCKED {get;set;}
public string DESCRIPTION {get;set;}
public Int32? OWNER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Question
{
public Int32? QUESTION_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public Int32? CATEGORY_ID {get;set;}
public Int32? TEACHER_ID {get;set;}
public string DESCRIPTION {get;set;}
public bool? IS_ANSWERED {get;set;}
public bool? IS_PUBLIC {get;set;}
public bool? IS_SELF_CLOSED {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Student My_Student {get;set;}
public Category My_Category {get;set;}
public Teacher My_Teacher {get;set;}
}
public partial class Question_token
{
public Int32? QUESTION_TOKEN_ID {get;set;}
public Int32? QUESTION_ID {get;set;}
public string PART {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Question My_Question {get;set;}
}
public partial class Student
{
public Int32? STUDENT_ID {get;set;}
public long? USER_ID {get;set;}
public Int32? USER_TYPE_CODE_ID {get;set;}
public bool? IS_BLOCKED {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public User My_User {get;set;}
public User_type_code My_User_type_code {get;set;}
}
public partial class Student_report
{
public Int32? STUDENT_REPORT_ID {get;set;}
public Int32? REPORTED_BY_STUDENT_ID {get;set;}
public Int32? REPORTED_STUDENT_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Student My_Reported_by_student {get;set;}
public Student My_Reported_student {get;set;}
}
public partial class Teacher
{
public Int32? TEACHER_ID {get;set;}
public long? USER_ID {get;set;}
public bool? IS_VALID {get;set;}
public Int32? USER_TYPE_CODE_ID {get;set;}
public Int32? SCORE {get;set;}
public bool? IS_BLOCKED {get;set;}
public Int32? CATEGORY_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public User My_User {get;set;}
public User_type_code My_User_type_code {get;set;}
public Category My_Category {get;set;}
}
public partial class Teacher_category
{
public Int32? TEACHER_CATEGORY_ID {get;set;}
public Int32? TEACHER_ID {get;set;}
public Int32? CATEGORY_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Teacher My_Teacher {get;set;}
public Category My_Category {get;set;}
}
public partial class Teacher_favorite
{
public Int32? TEACHER_FAVORITE_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public Int32? TEACHER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Student My_Student {get;set;}
public Teacher My_Teacher {get;set;}
}
public partial class Teacher_report
{
public Int32? TEACHER_REPORT_ID {get;set;}
public Int32? TEACHER_ID {get;set;}
public Int32? STUDENT_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Teacher My_Teacher {get;set;}
public Student My_Student {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public Int32? USER_TYPE_CODE_ID {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
public User_type_code My_User_type_code {get;set;}
}
public partial class User_type_code
{
public Int32? USER_TYPE_CODE_ID {get;set;}
public string USER_TYPE_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
#endregion 
public partial interface IDALC
{
Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID);
Answer Get_Answer_By_ANSWER_ID ( Int32? ANSWER_ID);
Category Get_Category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
Category_favorite Get_Category_favorite_By_CATEGORY_FAVORITE_ID ( Int32? CATEGORY_FAVORITE_ID);
Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID);
Evaluation Get_Evaluation_By_EVALUATION_ID ( Int32? EVALUATION_ID);
Favorite_teacher Get_Favorite_teacher_By_FAVORITE_TEACHER_ID ( Int32? FAVORITE_TEACHER_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Person Get_Person_By_PERSON_ID ( long? PERSON_ID);
Question Get_Question_By_QUESTION_ID ( Int32? QUESTION_ID);
Question_token Get_Question_token_By_QUESTION_TOKEN_ID ( Int32? QUESTION_TOKEN_ID);
Student Get_Student_By_STUDENT_ID ( Int32? STUDENT_ID);
Student_report Get_Student_report_By_STUDENT_REPORT_ID ( Int32? STUDENT_REPORT_ID);
Teacher Get_Teacher_By_TEACHER_ID ( Int32? TEACHER_ID);
Teacher_category Get_Teacher_category_By_TEACHER_CATEGORY_ID ( Int32? TEACHER_CATEGORY_ID);
Teacher_favorite Get_Teacher_favorite_By_TEACHER_FAVORITE_ID ( Int32? TEACHER_FAVORITE_ID);
Teacher_report Get_Teacher_report_By_TEACHER_REPORT_ID ( Int32? TEACHER_REPORT_ID);
User Get_User_By_USER_ID ( long? USER_ID);
User_type_code Get_User_type_code_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID);
Answer Get_Answer_By_ANSWER_ID_Adv ( Int32? ANSWER_ID);
Category Get_Category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
Category_favorite Get_Category_favorite_By_CATEGORY_FAVORITE_ID_Adv ( Int32? CATEGORY_FAVORITE_ID);
Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID);
Evaluation Get_Evaluation_By_EVALUATION_ID_Adv ( Int32? EVALUATION_ID);
Favorite_teacher Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_Adv ( Int32? FAVORITE_TEACHER_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID);
Question Get_Question_By_QUESTION_ID_Adv ( Int32? QUESTION_ID);
Question_token Get_Question_token_By_QUESTION_TOKEN_ID_Adv ( Int32? QUESTION_TOKEN_ID);
Student Get_Student_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
Student_report Get_Student_report_By_STUDENT_REPORT_ID_Adv ( Int32? STUDENT_REPORT_ID);
Teacher Get_Teacher_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
Teacher_category Get_Teacher_category_By_TEACHER_CATEGORY_ID_Adv ( Int32? TEACHER_CATEGORY_ID);
Teacher_favorite Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_Adv ( Int32? TEACHER_FAVORITE_ID);
Teacher_report Get_Teacher_report_By_TEACHER_REPORT_ID_Adv ( Int32? TEACHER_REPORT_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
User_type_code Get_User_type_code_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID);
List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST);
List<Answer> Get_Answer_By_ANSWER_ID_List ( List<Int32?> ANSWER_ID_LIST);
List<Category> Get_Category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Category_favorite> Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List ( List<Int32?> CATEGORY_FAVORITE_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST);
List<Evaluation> Get_Evaluation_By_EVALUATION_ID_List ( List<Int32?> EVALUATION_ID_LIST);
List<Favorite_teacher> Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List ( List<Int32?> FAVORITE_TEACHER_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Question> Get_Question_By_QUESTION_ID_List ( List<Int32?> QUESTION_ID_LIST);
List<Question_token> Get_Question_token_By_QUESTION_TOKEN_ID_List ( List<Int32?> QUESTION_TOKEN_ID_LIST);
List<Student> Get_Student_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Student_report> Get_Student_report_By_STUDENT_REPORT_ID_List ( List<Int32?> STUDENT_REPORT_ID_LIST);
List<Teacher> Get_Teacher_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_category> Get_Teacher_category_By_TEACHER_CATEGORY_ID_List ( List<Int32?> TEACHER_CATEGORY_ID_LIST);
List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List ( List<Int32?> TEACHER_FAVORITE_ID_LIST);
List<Teacher_report> Get_Teacher_report_By_TEACHER_REPORT_ID_List ( List<Int32?> TEACHER_REPORT_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<User_type_code> Get_User_type_code_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST);
List<Answer> Get_Answer_By_ANSWER_ID_List_Adv ( List<Int32?> ANSWER_ID_LIST);
List<Category> Get_Category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Category_favorite> Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_Adv ( List<Int32?> CATEGORY_FAVORITE_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST);
List<Evaluation> Get_Evaluation_By_EVALUATION_ID_List_Adv ( List<Int32?> EVALUATION_ID_LIST);
List<Favorite_teacher> Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_Adv ( List<Int32?> FAVORITE_TEACHER_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Question> Get_Question_By_QUESTION_ID_List_Adv ( List<Int32?> QUESTION_ID_LIST);
List<Question_token> Get_Question_token_By_QUESTION_TOKEN_ID_List_Adv ( List<Int32?> QUESTION_TOKEN_ID_LIST);
List<Student> Get_Student_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Student_report> Get_Student_report_By_STUDENT_REPORT_ID_List_Adv ( List<Int32?> STUDENT_REPORT_ID_LIST);
List<Teacher> Get_Teacher_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_category> Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_Adv ( List<Int32?> TEACHER_CATEGORY_ID_LIST);
List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_Adv ( List<Int32?> TEACHER_FAVORITE_ID_LIST);
List<Teacher_report> Get_Teacher_report_By_TEACHER_REPORT_ID_List_Adv ( List<Int32?> TEACHER_REPORT_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<User_type_code> Get_User_type_code_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
List<Answer> Get_Answer_By_OWNER_ID ( Int32? OWNER_ID);
List<Answer> Get_Answer_By_QUESTION_ID ( Int32? QUESTION_ID);
List<Answer> Get_Answer_By_TEACHER_ID ( Int32? TEACHER_ID);
List<Answer> Get_Answer_By_STUDENT_ID ( Int32? STUDENT_ID);
List<Category> Get_Category_By_OWNER_ID ( Int32? OWNER_ID);
List<Category_favorite> Get_Category_favorite_By_OWNER_ID ( Int32? OWNER_ID);
List<Category_favorite> Get_Category_favorite_By_STUDENT_ID ( Int32? STUDENT_ID);
List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID ( Int32? CATEGORY_ID);
List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID);
List<Evaluation> Get_Evaluation_By_OWNER_ID ( Int32? OWNER_ID);
List<Evaluation> Get_Evaluation_By_STUDENT_ID ( Int32? STUDENT_ID);
List<Evaluation> Get_Evaluation_By_ANSWER_ID ( Int32? ANSWER_ID);
List<Favorite_teacher> Get_Favorite_teacher_By_OWNER_ID ( Int32? OWNER_ID);
List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID ( Int32? STUDENT_ID);
List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID ( Int32? TEACHER_ID);
List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID);
List<Question> Get_Question_By_OWNER_ID ( Int32? OWNER_ID);
List<Question> Get_Question_By_STUDENT_ID ( Int32? STUDENT_ID);
List<Question> Get_Question_By_CATEGORY_ID ( Int32? CATEGORY_ID);
List<Question> Get_Question_By_TEACHER_ID ( Int32? TEACHER_ID);
List<Question_token> Get_Question_token_By_PART ( string PART);
List<Question_token> Get_Question_token_By_OWNER_ID ( Int32? OWNER_ID);
List<Question_token> Get_Question_token_By_QUESTION_ID ( Int32? QUESTION_ID);
List<Student> Get_Student_By_OWNER_ID ( Int32? OWNER_ID);
List<Student> Get_Student_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
List<Student> Get_Student_By_USER_ID ( long? USER_ID);
List<Student_report> Get_Student_report_By_OWNER_ID ( Int32? OWNER_ID);
List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID ( Int32? REPORTED_BY_STUDENT_ID);
List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID ( Int32? REPORTED_STUDENT_ID);
List<Teacher> Get_Teacher_By_OWNER_ID ( Int32? OWNER_ID);
List<Teacher> Get_Teacher_By_CATEGORY_ID ( Int32? CATEGORY_ID);
List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
List<Teacher> Get_Teacher_By_USER_ID ( long? USER_ID);
List<Teacher_category> Get_Teacher_category_By_OWNER_ID ( Int32? OWNER_ID);
List<Teacher_category> Get_Teacher_category_By_TEACHER_ID ( Int32? TEACHER_ID);
List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
List<Teacher_favorite> Get_Teacher_favorite_By_OWNER_ID ( Int32? OWNER_ID);
List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID ( Int32? STUDENT_ID);
List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID ( Int32? TEACHER_ID);
List<Teacher_report> Get_Teacher_report_By_OWNER_ID ( Int32? OWNER_ID);
List<Teacher_report> Get_Teacher_report_By_TEACHER_ID ( Int32? TEACHER_ID);
List<Teacher_report> Get_Teacher_report_By_STUDENT_ID ( Int32? STUDENT_ID);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<User> Get_User_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
List<User> Get_User_By_EMAIL ( string EMAIL);
List<User_type_code> Get_User_type_code_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
List<Answer> Get_Answer_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Answer> Get_Answer_By_QUESTION_ID_Adv ( Int32? QUESTION_ID);
List<Answer> Get_Answer_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
List<Answer> Get_Answer_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<Category> Get_Category_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Category_favorite> Get_Category_favorite_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Evaluation> Get_Evaluation_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Evaluation> Get_Evaluation_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<Evaluation> Get_Evaluation_By_ANSWER_ID_Adv ( Int32? ANSWER_ID);
List<Favorite_teacher> Get_Favorite_teacher_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Question> Get_Question_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Question> Get_Question_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<Question> Get_Question_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
List<Question> Get_Question_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
List<Question_token> Get_Question_token_By_PART_Adv ( string PART);
List<Question_token> Get_Question_token_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Question_token> Get_Question_token_By_QUESTION_ID_Adv ( Int32? QUESTION_ID);
List<Student> Get_Student_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Student> Get_Student_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID);
List<Student> Get_Student_By_USER_ID_Adv ( long? USER_ID);
List<Student_report> Get_Student_report_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_Adv ( Int32? REPORTED_BY_STUDENT_ID);
List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_Adv ( Int32? REPORTED_STUDENT_ID);
List<Teacher> Get_Teacher_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Teacher> Get_Teacher_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID);
List<Teacher> Get_Teacher_By_USER_ID_Adv ( long? USER_ID);
List<Teacher_category> Get_Teacher_category_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
List<Teacher_favorite> Get_Teacher_favorite_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
List<Teacher_report> Get_Teacher_report_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_Adv ( Int32? TEACHER_ID);
List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_Adv ( Int32? STUDENT_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<User> Get_User_By_USER_TYPE_CODE_ID_Adv ( Int32? USER_TYPE_CODE_ID);
List<User> Get_User_By_EMAIL_Adv ( string EMAIL);
List<User_type_code> Get_User_type_code_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Answer> Get_Answer_By_QUESTION_ID_List ( List<Int32?> QUESTION_ID_LIST);
List<Answer> Get_Answer_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Answer> Get_Answer_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Evaluation> Get_Evaluation_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Evaluation> Get_Evaluation_By_ANSWER_ID_List ( List<Int32?> ANSWER_ID_LIST);
List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Question> Get_Question_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Question> Get_Question_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Question> Get_Question_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Question_token> Get_Question_token_By_QUESTION_ID_List ( List<Int32?> QUESTION_ID_LIST);
List<Student> Get_Student_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Student> Get_Student_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_List ( List<Int32?> REPORTED_BY_STUDENT_ID_LIST);
List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_List ( List<Int32?> REPORTED_STUDENT_ID_LIST);
List<Teacher> Get_Teacher_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Teacher> Get_Teacher_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_List ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_List ( List<Int32?> STUDENT_ID_LIST);
List<User> Get_User_By_USER_TYPE_CODE_ID_List ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Answer> Get_Answer_By_QUESTION_ID_List_Adv ( List<Int32?> QUESTION_ID_LIST);
List<Answer> Get_Answer_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Answer> Get_Answer_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Category_favorite> Get_Category_favorite_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Category_favorite> Get_Category_favorite_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Evaluation> Get_Evaluation_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Evaluation> Get_Evaluation_By_ANSWER_ID_List_Adv ( List<Int32?> ANSWER_ID_LIST);
List<Favorite_teacher> Get_Favorite_teacher_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Favorite_teacher> Get_Favorite_teacher_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Question> Get_Question_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Question> Get_Question_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Question> Get_Question_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Question_token> Get_Question_token_By_QUESTION_ID_List_Adv ( List<Int32?> QUESTION_ID_LIST);
List<Student> Get_Student_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Student> Get_Student_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Student_report> Get_Student_report_By_REPORTED_BY_STUDENT_ID_List_Adv ( List<Int32?> REPORTED_BY_STUDENT_ID_LIST);
List<Student_report> Get_Student_report_By_REPORTED_STUDENT_ID_List_Adv ( List<Int32?> REPORTED_STUDENT_ID_LIST);
List<Teacher> Get_Teacher_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Teacher> Get_Teacher_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Teacher> Get_Teacher_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Teacher_category> Get_Teacher_category_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_category> Get_Teacher_category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Teacher_favorite> Get_Teacher_favorite_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<Teacher_favorite> Get_Teacher_favorite_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_report> Get_Teacher_report_By_TEACHER_ID_List_Adv ( List<Int32?> TEACHER_ID_LIST);
List<Teacher_report> Get_Teacher_report_By_STUDENT_ID_List_Adv ( List<Int32?> STUDENT_ID_LIST);
List<User> Get_User_By_USER_TYPE_CODE_ID_List_Adv ( List<Int32?> USER_TYPE_CODE_ID_LIST);
List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Criteria ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Where ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_type_code> Get_User_type_code_By_Criteria ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_type_code> Get_User_type_code_By_Where ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Criteria_Adv ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Where_Adv ( string PART, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_type_code> Get_User_type_code_By_Criteria_Adv ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_type_code> Get_User_type_code_By_Where_Adv ( string USER_TYPE_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Criteria_InList ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Where_InList ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Criteria_InList ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Where_InList ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Criteria_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Where_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Criteria_InList ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Where_InList ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Criteria_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Where_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Criteria_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Where_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Where_InList ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Criteria_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Where_InList ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_InList ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_InList ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_InList_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_InList_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Answer> Get_Answer_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> QUESTION_ID_LIST, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category_favorite> Get_Category_favorite_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Evaluation> Get_Evaluation_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> ANSWER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Favorite_teacher> Get_Favorite_teacher_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question> Get_Question_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> CATEGORY_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Criteria_InList_Adv ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Question_token> Get_Question_token_By_Where_InList_Adv ( string PART, List<Int32?> QUESTION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student> Get_Student_By_Where_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Student_report> Get_Student_report_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> REPORTED_BY_STUDENT_ID_LIST, List<Int32?> REPORTED_STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher> Get_Teacher_By_Where_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, List<Int32?> USER_TYPE_CODE_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_category> Get_Teacher_category_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_favorite> Get_Teacher_favorite_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STUDENT_ID_LIST, List<Int32?> TEACHER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Teacher_report> Get_Teacher_report_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> TEACHER_ID_LIST, List<Int32?> STUDENT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_InList_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_InList_Adv ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_InList_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_InList_Adv_V2 ( string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, List<Int32?> USER_TYPE_CODE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Address ( long? ADDRESS_ID);
void Delete_Answer ( Int32? ANSWER_ID);
void Delete_Category ( Int32? CATEGORY_ID);
void Delete_Category_favorite ( Int32? CATEGORY_FAVORITE_ID);
void Delete_Contact ( Int32? CONTACT_ID);
void Delete_Evaluation ( Int32? EVALUATION_ID);
void Delete_Favorite_teacher ( Int32? FAVORITE_TEACHER_ID);
void Delete_Loc_l1 ( long? LOC_L1_ID);
void Delete_Loc_l2 ( long? LOC_L2_ID);
void Delete_Loc_l3 ( long? LOC_L3_ID);
void Delete_Loc_l4 ( long? LOC_L4_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Person ( long? PERSON_ID);
void Delete_Question ( Int32? QUESTION_ID);
void Delete_Question_token ( Int32? QUESTION_TOKEN_ID);
void Delete_Student ( Int32? STUDENT_ID);
void Delete_Student_report ( Int32? STUDENT_REPORT_ID);
void Delete_Teacher ( Int32? TEACHER_ID);
void Delete_Teacher_category ( Int32? TEACHER_CATEGORY_ID);
void Delete_Teacher_favorite ( Int32? TEACHER_FAVORITE_ID);
void Delete_Teacher_report ( Int32? TEACHER_REPORT_ID);
void Delete_User ( long? USER_ID);
void Delete_User_type_code ( Int32? USER_TYPE_CODE_ID);
void Delete_Address_By_PERSON_ID ( long? PERSON_ID);
void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
void Delete_Answer_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Answer_By_QUESTION_ID ( Int32? QUESTION_ID);
void Delete_Answer_By_TEACHER_ID ( Int32? TEACHER_ID);
void Delete_Answer_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_Category_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Category_favorite_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Category_favorite_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_Category_favorite_By_CATEGORY_ID ( Int32? CATEGORY_ID);
void Delete_Contact_By_PERSON_ID ( long? PERSON_ID);
void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Evaluation_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Evaluation_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_Evaluation_By_ANSWER_ID ( Int32? ANSWER_ID);
void Delete_Favorite_teacher_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Favorite_teacher_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_Favorite_teacher_By_TEACHER_ID ( Int32? TEACHER_ID);
void Delete_Loc_l1_By_CODE ( string CODE);
void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Question_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Question_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_Question_By_CATEGORY_ID ( Int32? CATEGORY_ID);
void Delete_Question_By_TEACHER_ID ( Int32? TEACHER_ID);
void Delete_Question_token_By_PART ( string PART);
void Delete_Question_token_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Question_token_By_QUESTION_ID ( Int32? QUESTION_ID);
void Delete_Student_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Student_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
void Delete_Student_By_USER_ID ( long? USER_ID);
void Delete_Student_report_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Student_report_By_REPORTED_BY_STUDENT_ID ( Int32? REPORTED_BY_STUDENT_ID);
void Delete_Student_report_By_REPORTED_STUDENT_ID ( Int32? REPORTED_STUDENT_ID);
void Delete_Teacher_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Teacher_By_CATEGORY_ID ( Int32? CATEGORY_ID);
void Delete_Teacher_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
void Delete_Teacher_By_USER_ID ( long? USER_ID);
void Delete_Teacher_category_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Teacher_category_By_TEACHER_ID ( Int32? TEACHER_ID);
void Delete_Teacher_category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
void Delete_Teacher_favorite_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Teacher_favorite_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_Teacher_favorite_By_TEACHER_ID ( Int32? TEACHER_ID);
void Delete_Teacher_report_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Teacher_report_By_TEACHER_ID ( Int32? TEACHER_ID);
void Delete_Teacher_report_By_STUDENT_ID ( Int32? STUDENT_ID);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
void Delete_User_By_USER_TYPE_CODE_ID ( Int32? USER_TYPE_CODE_ID);
void Delete_User_By_EMAIL ( string EMAIL);
void Delete_User_type_code_By_OWNER_ID ( Int32? OWNER_ID);
long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Answer ( Int32? ANSWER_ID, Int32? QUESTION_ID, Int32? TEACHER_ID, Int32? STUDENT_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Category ( Int32? CATEGORY_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Category_favorite ( Int32? CATEGORY_FAVORITE_ID, Int32? STUDENT_ID, Int32? CATEGORY_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Evaluation ( Int32? EVALUATION_ID, Int32? STUDENT_ID, Int32? ANSWER_ID, Int32? SCORE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Favorite_teacher ( Int32? FAVORITE_TEACHER_ID, Int32? STUDENT_ID, Int32? TEACHER_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE);
Int32? Edit_Question ( Int32? QUESTION_ID, Int32? STUDENT_ID, Int32? CATEGORY_ID, Int32? TEACHER_ID, string DESCRIPTION, bool? IS_ANSWERED, bool? IS_PUBLIC, bool? IS_SELF_CLOSED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Question_token ( Int32? QUESTION_TOKEN_ID, Int32? QUESTION_ID, string PART, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Student ( Int32? STUDENT_ID, long? USER_ID, Int32? USER_TYPE_CODE_ID, bool? IS_BLOCKED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Student_report ( Int32? STUDENT_REPORT_ID, Int32? REPORTED_BY_STUDENT_ID, Int32? REPORTED_STUDENT_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Teacher ( Int32? TEACHER_ID, long? USER_ID, bool? IS_VALID, Int32? USER_TYPE_CODE_ID, Int32? SCORE, bool? IS_BLOCKED, Int32? CATEGORY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Teacher_category ( Int32? TEACHER_CATEGORY_ID, Int32? TEACHER_ID, Int32? CATEGORY_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Teacher_favorite ( Int32? TEACHER_FAVORITE_ID, Int32? STUDENT_ID, Int32? TEACHER_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Teacher_report ( Int32? TEACHER_REPORT_ID, Int32? TEACHER_ID, Int32? STUDENT_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string EMAIL, string FIRST_NAME, string LAST_NAME, string MOBILE, string DOB, Int32? USER_TYPE_CODE_ID, bool? IS_ACTIVE, string ENTRY_DATE);
Int32? Edit_User_type_code ( Int32? USER_TYPE_CODE_ID, string USER_TYPE_CODE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_ANSWER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CATEGORY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CATEGORY_FAVORITE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_EVALUATION ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_FAVORITE_TEACHER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_QUESTION ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_QUESTION_TOKEN ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STUDENT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STUDENT_REPORT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TEACHER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TEACHER_CATEGORY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TEACHER_FAVORITE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TEACHER_REPORT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER_TYPE_CODE ( string JSON_CONTENT);
List<dynamic> UP_CHANGE_IS_ANSWERED_TO_TRUE ( Int32? QUESTION_ID);
List<dynamic> UP_CHANGE_IS_BLOCKED_TO_TRUE ( Int32? STUDENT_ID);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_ANSWER_WITH_NAMES_BY_QUESTION_ID ( Int32? QUESTION_ID);
List<dynamic> UP_GET_AVERAGE_BY_STUDENT ( decimal ANSWER);
List<dynamic> UP_GET_AVERAGE_BY_TEACHER ( decimal ANSWER);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_TOP_N_TEACHERS ( Int32? NUMBER_OF_TEACHERS);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
List<dynamic> UP_Get_User_By_Email ( string EMAIL);
List<dynamic> UP_LIMIT_QUESTIONS ( Int32? STUDENT_ID, Int32? LIMIT_PER_DAY);
}
}
