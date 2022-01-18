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
#region Address
public partial class Address
{
#region Advanced Properties
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
#endregion
}
#endregion
#region Answer
public partial class Answer
{
#region Advanced Properties
public Question My_Question {get;set;}
public Teacher My_Teacher {get;set;}
public Student My_Student {get;set;}
#endregion
}
#endregion
#region Category
public partial class Category
{
#region Advanced Properties
#endregion
}
#endregion
#region Category_favorite
public partial class Category_favorite
{
#region Advanced Properties
public Student My_Student {get;set;}
public Category My_Category {get;set;}
#endregion
}
#endregion
#region Contact
public partial class Contact
{
#region Advanced Properties
public Person My_Person {get;set;}
#endregion
}
#endregion
#region Evaluation
public partial class Evaluation
{
#region Advanced Properties
public Student My_Student {get;set;}
public Answer My_Answer {get;set;}
#endregion
}
#endregion
#region Favorite_teacher
public partial class Favorite_teacher
{
#region Advanced Properties
public Student My_Student {get;set;}
public Teacher My_Teacher {get;set;}
#endregion
}
#endregion
#region Loc_l1
public partial class Loc_l1
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l2
public partial class Loc_l2
{
#region Advanced Properties
public Loc_l1 My_Loc_l1 {get;set;}
#endregion
}
#endregion
#region Loc_l3
public partial class Loc_l3
{
#region Advanced Properties
public Loc_l2 My_Loc_l2 {get;set;}
#endregion
}
#endregion
#region Loc_l4
public partial class Loc_l4
{
#region Advanced Properties
public Loc_l3 My_Loc_l3 {get;set;}
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region Person
public partial class Person
{
#region Advanced Properties
#endregion
}
#endregion
#region Question
public partial class Question
{
#region Advanced Properties
public Student My_Student {get;set;}
public Category My_Category {get;set;}
public Teacher My_Teacher {get;set;}
#endregion
}
#endregion
#region Question_token
public partial class Question_token
{
#region Advanced Properties
public Question My_Question {get;set;}
#endregion
}
#endregion
#region Student
public partial class Student
{
#region Advanced Properties
public User My_User {get;set;}
public User_type_code My_User_type_code {get;set;}
#endregion
}
#endregion
#region Student_report
public partial class Student_report
{
#region Advanced Properties
public Student My_Reported_by_student {get;set;}
public Student My_Reported_student {get;set;}
#endregion
}
#endregion
#region Teacher
public partial class Teacher
{
#region Advanced Properties
public User My_User {get;set;}
public User_type_code My_User_type_code {get;set;}
public Category My_Category {get;set;}
#endregion
}
#endregion
#region Teacher_category
public partial class Teacher_category
{
#region Advanced Properties
public Teacher My_Teacher {get;set;}
public Category My_Category {get;set;}
#endregion
}
#endregion
#region Teacher_favorite
public partial class Teacher_favorite
{
#region Advanced Properties
public Student My_Student {get;set;}
public Teacher My_Teacher {get;set;}
#endregion
}
#endregion
#region Teacher_report
public partial class Teacher_report
{
#region Advanced Properties
public Teacher My_Teacher {get;set;}
public Student My_Student {get;set;}
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
public User_type_code My_User_type_code {get;set;}
#endregion
}
#endregion
#region User_type_code
public partial class User_type_code
{
#region Advanced Properties
#endregion
}
#endregion
}
