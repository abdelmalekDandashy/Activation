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
#region Params_Get_Address_By_ADDRESS_ID
public partial class Params_Get_Address_By_ADDRESS_ID
{
#region Properties
public long? ADDRESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Answer_By_ANSWER_ID
public partial class Params_Get_Answer_By_ANSWER_ID
{
#region Properties
public Int32? ANSWER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Category_By_CATEGORY_ID
public partial class Params_Get_Category_By_CATEGORY_ID
{
#region Properties
public Int32? CATEGORY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID
public partial class Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID
{
#region Properties
public Int32? CATEGORY_FAVORITE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Contact_By_CONTACT_ID
public partial class Params_Get_Contact_By_CONTACT_ID
{
#region Properties
public Int32? CONTACT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Evaluation_By_EVALUATION_ID
public partial class Params_Get_Evaluation_By_EVALUATION_ID
{
#region Properties
public Int32? EVALUATION_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID
public partial class Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID
{
#region Properties
public Int32? FAVORITE_TEACHER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l1_By_LOC_L1_ID
public partial class Params_Get_Loc_l1_By_LOC_L1_ID
{
#region Properties
public long? LOC_L1_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l2_By_LOC_L2_ID
public partial class Params_Get_Loc_l2_By_LOC_L2_ID
{
#region Properties
public long? LOC_L2_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l3_By_LOC_L3_ID
public partial class Params_Get_Loc_l3_By_LOC_L3_ID
{
#region Properties
public long? LOC_L3_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l4_By_LOC_L4_ID
public partial class Params_Get_Loc_l4_By_LOC_L4_ID
{
#region Properties
public long? LOC_L4_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Person_By_PERSON_ID
public partial class Params_Get_Person_By_PERSON_ID
{
#region Properties
public long? PERSON_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Question_By_QUESTION_ID
public partial class Params_Get_Question_By_QUESTION_ID
{
#region Properties
public Int32? QUESTION_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Question_token_By_QUESTION_TOKEN_ID
public partial class Params_Get_Question_token_By_QUESTION_TOKEN_ID
{
#region Properties
public Int32? QUESTION_TOKEN_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Student_By_STUDENT_ID
public partial class Params_Get_Student_By_STUDENT_ID
{
#region Properties
public Int32? STUDENT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Student_report_By_STUDENT_REPORT_ID
public partial class Params_Get_Student_report_By_STUDENT_REPORT_ID
{
#region Properties
public Int32? STUDENT_REPORT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Teacher_By_TEACHER_ID
public partial class Params_Get_Teacher_By_TEACHER_ID
{
#region Properties
public Int32? TEACHER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID
public partial class Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID
{
#region Properties
public Int32? TEACHER_CATEGORY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID
public partial class Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID
{
#region Properties
public Int32? TEACHER_FAVORITE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Teacher_report_By_TEACHER_REPORT_ID
public partial class Params_Get_Teacher_report_By_TEACHER_REPORT_ID
{
#region Properties
public Int32? TEACHER_REPORT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_type_code_By_USER_TYPE_CODE_ID
public partial class Params_Get_User_type_code_By_USER_TYPE_CODE_ID
{
#region Properties
public Int32? USER_TYPE_CODE_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Address_By_ADDRESS_ID_List
{
public List<long?> ADDRESS_ID_LIST {get;set;}
}
public partial class Params_Get_Address_By_ADDRESS_ID_List_SP
{
public string ADDRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Answer_By_ANSWER_ID_List
{
public List<Int32?> ANSWER_ID_LIST {get;set;}
}
public partial class Params_Get_Answer_By_ANSWER_ID_List_SP
{
public string ANSWER_ID_LIST {get;set;}

}
public partial class Params_Get_Category_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}
}
public partial class Params_Get_Category_By_CATEGORY_ID_List_SP
{
public string CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List
{
public List<Int32?> CATEGORY_FAVORITE_ID_LIST {get;set;}
}
public partial class Params_Get_Category_favorite_By_CATEGORY_FAVORITE_ID_List_SP
{
public string CATEGORY_FAVORITE_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_CONTACT_ID_List
{
public List<Int32?> CONTACT_ID_LIST {get;set;}
}
public partial class Params_Get_Contact_By_CONTACT_ID_List_SP
{
public string CONTACT_ID_LIST {get;set;}

}
public partial class Params_Get_Evaluation_By_EVALUATION_ID_List
{
public List<Int32?> EVALUATION_ID_LIST {get;set;}
}
public partial class Params_Get_Evaluation_By_EVALUATION_ID_List_SP
{
public string EVALUATION_ID_LIST {get;set;}

}
public partial class Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List
{
public List<Int32?> FAVORITE_TEACHER_ID_LIST {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_FAVORITE_TEACHER_ID_List_SP
{
public string FAVORITE_TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List_SP
{
public string LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List_SP
{
public string LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List_SP
{
public string LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List_SP
{
public string LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Person_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}
}
public partial class Params_Get_Person_By_PERSON_ID_List_SP
{
public string PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Question_By_QUESTION_ID_List
{
public List<Int32?> QUESTION_ID_LIST {get;set;}
}
public partial class Params_Get_Question_By_QUESTION_ID_List_SP
{
public string QUESTION_ID_LIST {get;set;}

}
public partial class Params_Get_Question_token_By_QUESTION_TOKEN_ID_List
{
public List<Int32?> QUESTION_TOKEN_ID_LIST {get;set;}
}
public partial class Params_Get_Question_token_By_QUESTION_TOKEN_ID_List_SP
{
public string QUESTION_TOKEN_ID_LIST {get;set;}

}
public partial class Params_Get_Student_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}
}
public partial class Params_Get_Student_By_STUDENT_ID_List_SP
{
public string STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Student_report_By_STUDENT_REPORT_ID_List
{
public List<Int32?> STUDENT_REPORT_ID_LIST {get;set;}
}
public partial class Params_Get_Student_report_By_STUDENT_REPORT_ID_List_SP
{
public string STUDENT_REPORT_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}
}
public partial class Params_Get_Teacher_By_TEACHER_ID_List_SP
{
public string TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List
{
public List<Int32?> TEACHER_CATEGORY_ID_LIST {get;set;}
}
public partial class Params_Get_Teacher_category_By_TEACHER_CATEGORY_ID_List_SP
{
public string TEACHER_CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List
{
public List<Int32?> TEACHER_FAVORITE_ID_LIST {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_TEACHER_FAVORITE_ID_List_SP
{
public string TEACHER_FAVORITE_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List
{
public List<Int32?> TEACHER_REPORT_ID_LIST {get;set;}
}
public partial class Params_Get_Teacher_report_By_TEACHER_REPORT_ID_List_SP
{
public string TEACHER_REPORT_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List
{
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
}
public partial class Params_Get_User_type_code_By_USER_TYPE_CODE_ID_List_SP
{
public string USER_TYPE_CODE_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}

}
public partial class Params_Get_Answer_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Answer_By_QUESTION_ID
{
public Int32? QUESTION_ID {get;set;}

}
public partial class Params_Get_Answer_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}

}
public partial class Params_Get_Answer_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_Category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Category_favorite_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Category_favorite_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_Category_favorite_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}

}
public partial class Params_Get_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Evaluation_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Evaluation_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_Evaluation_By_ANSWER_ID
{
public Int32? ANSWER_ID {get;set;}

}
public partial class Params_Get_Favorite_teacher_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Favorite_teacher_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_Favorite_teacher_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}

}
public partial class Params_Get_Loc_l1_By_CODE
{
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Question_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Question_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_Question_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}

}
public partial class Params_Get_Question_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}

}
public partial class Params_Get_Question_token_By_PART
{
public string PART {get;set;}

}
public partial class Params_Get_Question_token_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Question_token_By_QUESTION_ID
{
public Int32? QUESTION_ID {get;set;}

}
public partial class Params_Get_Student_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Student_By_USER_TYPE_CODE_ID
{
public Int32? USER_TYPE_CODE_ID {get;set;}

}
public partial class Params_Get_Student_By_USER_ID
{
public long? USER_ID {get;set;}

}
public partial class Params_Get_Student_report_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID
{
public Int32? REPORTED_BY_STUDENT_ID {get;set;}

}
public partial class Params_Get_Student_report_By_REPORTED_STUDENT_ID
{
public Int32? REPORTED_STUDENT_ID {get;set;}

}
public partial class Params_Get_Teacher_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Teacher_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}

}
public partial class Params_Get_Teacher_By_USER_TYPE_CODE_ID
{
public Int32? USER_TYPE_CODE_ID {get;set;}

}
public partial class Params_Get_Teacher_By_USER_ID
{
public long? USER_ID {get;set;}

}
public partial class Params_Get_Teacher_category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Teacher_category_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}

}
public partial class Params_Get_Teacher_category_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}

}
public partial class Params_Get_Teacher_favorite_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Teacher_favorite_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_Teacher_favorite_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}

}
public partial class Params_Get_Teacher_report_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Teacher_report_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}

}
public partial class Params_Get_Teacher_report_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_User_By_USER_TYPE_CODE_ID
{
public Int32? USER_TYPE_CODE_ID {get;set;}

}
public partial class Params_Get_User_By_EMAIL
{
public string EMAIL {get;set;}

}
public partial class Params_Get_User_type_code_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Answer_By_QUESTION_ID_List
{
public List<Int32?> QUESTION_ID_LIST {get;set;}

}
public partial class Params_Get_Answer_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Answer_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Category_favorite_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Category_favorite_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Evaluation_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Evaluation_By_ANSWER_ID_List
{
public List<Int32?> ANSWER_ID_LIST {get;set;}

}
public partial class Params_Get_Favorite_teacher_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Favorite_teacher_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Question_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Question_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Question_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Question_token_By_QUESTION_ID_List
{
public List<Int32?> QUESTION_ID_LIST {get;set;}

}
public partial class Params_Get_Student_By_USER_TYPE_CODE_ID_List
{
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}

}
public partial class Params_Get_Student_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}

}
public partial class Params_Get_Student_report_By_REPORTED_BY_STUDENT_ID_List
{
public List<Int32?> REPORTED_BY_STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Student_report_By_REPORTED_STUDENT_ID_List
{
public List<Int32?> REPORTED_STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_By_USER_TYPE_CODE_ID_List
{
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_category_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_category_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_favorite_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_favorite_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_report_By_TEACHER_ID_List
{
public List<Int32?> TEACHER_ID_LIST {get;set;}

}
public partial class Params_Get_Teacher_report_By_STUDENT_ID_List
{
public List<Int32?> STUDENT_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_TYPE_CODE_ID_List
{
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Answer_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Answer_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_favorite_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_favorite_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Evaluation_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Evaluation_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_token_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string PART {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_token_By_Where
{

public Int32? OWNER_ID {get;set;}
public string PART {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_report_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_report_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_category_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_category_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_report_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_report_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_type_code_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USER_TYPE_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_type_code_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USER_TYPE_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Answer_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> QUESTION_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Answer_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string QUESTION_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public string STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Answer_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> QUESTION_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Answer_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string QUESTION_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public string STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_favorite_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_favorite_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_favorite_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_favorite_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Evaluation_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> ANSWER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Evaluation_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string ANSWER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Evaluation_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> ANSWER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Evaluation_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string ANSWER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Favorite_teacher_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_token_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string PART {get;set;}
public List<Int32?> QUESTION_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_token_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string PART {get;set;}
public string QUESTION_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_token_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string PART {get;set;}
public List<Int32?> QUESTION_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Question_token_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string PART {get;set;}
public string QUESTION_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string USER_ID_LIST {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string USER_ID_LIST {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_report_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> REPORTED_BY_STUDENT_ID_LIST {get;set;}
public List<Int32?> REPORTED_STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_report_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string REPORTED_BY_STUDENT_ID_LIST {get;set;}
public string REPORTED_STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_report_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> REPORTED_BY_STUDENT_ID_LIST {get;set;}
public List<Int32?> REPORTED_STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Student_report_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string REPORTED_BY_STUDENT_ID_LIST {get;set;}
public string REPORTED_STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string USER_ID_LIST {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string USER_ID_LIST {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_category_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_category_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string TEACHER_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_category_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_category_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string TEACHER_ID_LIST {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_favorite_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STUDENT_ID_LIST {get;set;}
public string TEACHER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_report_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_report_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string TEACHER_ID_LIST {get;set;}
public string STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_report_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TEACHER_ID_LIST {get;set;}
public List<Int32?> STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Teacher_report_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string TEACHER_ID_LIST {get;set;}
public string STUDENT_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public List<Int32?> USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string MOBILE {get;set;}
public string DOB {get;set;}
public string USER_TYPE_CODE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Address
public partial class Params_Delete_Address
{
#region Properties
public long? ADDRESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Answer
public partial class Params_Delete_Answer
{
#region Properties
public Int32? ANSWER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Category
public partial class Params_Delete_Category
{
#region Properties
public Int32? CATEGORY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Category_favorite
public partial class Params_Delete_Category_favorite
{
#region Properties
public Int32? CATEGORY_FAVORITE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Contact
public partial class Params_Delete_Contact
{
#region Properties
public Int32? CONTACT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Evaluation
public partial class Params_Delete_Evaluation
{
#region Properties
public Int32? EVALUATION_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Favorite_teacher
public partial class Params_Delete_Favorite_teacher
{
#region Properties
public Int32? FAVORITE_TEACHER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l1
public partial class Params_Delete_Loc_l1
{
#region Properties
public long? LOC_L1_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l2
public partial class Params_Delete_Loc_l2
{
#region Properties
public long? LOC_L2_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l3
public partial class Params_Delete_Loc_l3
{
#region Properties
public long? LOC_L3_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l4
public partial class Params_Delete_Loc_l4
{
#region Properties
public long? LOC_L4_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Person
public partial class Params_Delete_Person
{
#region Properties
public long? PERSON_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Question
public partial class Params_Delete_Question
{
#region Properties
public Int32? QUESTION_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Question_token
public partial class Params_Delete_Question_token
{
#region Properties
public Int32? QUESTION_TOKEN_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Student
public partial class Params_Delete_Student
{
#region Properties
public Int32? STUDENT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Student_report
public partial class Params_Delete_Student_report
{
#region Properties
public Int32? STUDENT_REPORT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Teacher
public partial class Params_Delete_Teacher
{
#region Properties
public Int32? TEACHER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Teacher_category
public partial class Params_Delete_Teacher_category
{
#region Properties
public Int32? TEACHER_CATEGORY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Teacher_favorite
public partial class Params_Delete_Teacher_favorite
{
#region Properties
public Int32? TEACHER_FAVORITE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Teacher_report
public partial class Params_Delete_Teacher_report
{
#region Properties
public Int32? TEACHER_REPORT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User_type_code
public partial class Params_Delete_User_type_code
{
#region Properties
public Int32? USER_TYPE_CODE_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}
}
public partial class Params_Delete_Answer_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Answer_By_QUESTION_ID
{
public Int32? QUESTION_ID {get;set;}
}
public partial class Params_Delete_Answer_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}
}
public partial class Params_Delete_Answer_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_Category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Category_favorite_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Category_favorite_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_Category_favorite_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
}
public partial class Params_Delete_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Evaluation_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Evaluation_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_Evaluation_By_ANSWER_ID
{
public Int32? ANSWER_ID {get;set;}
}
public partial class Params_Delete_Favorite_teacher_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Favorite_teacher_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_Favorite_teacher_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}
}
public partial class Params_Delete_Loc_l1_By_CODE
{
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Question_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Question_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_Question_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Question_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}
}
public partial class Params_Delete_Question_token_By_PART
{
public string PART {get;set;}
}
public partial class Params_Delete_Question_token_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Question_token_By_QUESTION_ID
{
public Int32? QUESTION_ID {get;set;}
}
public partial class Params_Delete_Student_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Student_By_USER_TYPE_CODE_ID
{
public Int32? USER_TYPE_CODE_ID {get;set;}
}
public partial class Params_Delete_Student_By_USER_ID
{
public long? USER_ID {get;set;}
}
public partial class Params_Delete_Student_report_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Student_report_By_REPORTED_BY_STUDENT_ID
{
public Int32? REPORTED_BY_STUDENT_ID {get;set;}
}
public partial class Params_Delete_Student_report_By_REPORTED_STUDENT_ID
{
public Int32? REPORTED_STUDENT_ID {get;set;}
}
public partial class Params_Delete_Teacher_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Teacher_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Teacher_By_USER_TYPE_CODE_ID
{
public Int32? USER_TYPE_CODE_ID {get;set;}
}
public partial class Params_Delete_Teacher_By_USER_ID
{
public long? USER_ID {get;set;}
}
public partial class Params_Delete_Teacher_category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Teacher_category_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}
}
public partial class Params_Delete_Teacher_category_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Teacher_favorite_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Teacher_favorite_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_Teacher_favorite_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}
}
public partial class Params_Delete_Teacher_report_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Teacher_report_By_TEACHER_ID
{
public Int32? TEACHER_ID {get;set;}
}
public partial class Params_Delete_Teacher_report_By_STUDENT_ID
{
public Int32? STUDENT_ID {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_User_By_USER_TYPE_CODE_ID
{
public Int32? USER_TYPE_CODE_ID {get;set;}
}
public partial class Params_Delete_User_By_EMAIL
{
public string EMAIL {get;set;}
}
public partial class Params_Delete_User_type_code_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
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
}
public partial class Question_token
{
public Int32? QUESTION_TOKEN_ID {get;set;}
public Int32? QUESTION_ID {get;set;}
public string PART {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
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
#region Params_Edit_Address_List
public partial class Params_Edit_Address_List
{
#region Properties
public List<Address> My_List_To_Edit { get; set; }
public List<Address> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Answer_List
public partial class Params_Edit_Answer_List
{
#region Properties
public List<Answer> My_List_To_Edit { get; set; }
public List<Answer> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Category_List
public partial class Params_Edit_Category_List
{
#region Properties
public List<Category> My_List_To_Edit { get; set; }
public List<Category> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Category_favorite_List
public partial class Params_Edit_Category_favorite_List
{
#region Properties
public List<Category_favorite> My_List_To_Edit { get; set; }
public List<Category_favorite> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Contact_List
public partial class Params_Edit_Contact_List
{
#region Properties
public List<Contact> My_List_To_Edit { get; set; }
public List<Contact> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Evaluation_List
public partial class Params_Edit_Evaluation_List
{
#region Properties
public List<Evaluation> My_List_To_Edit { get; set; }
public List<Evaluation> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Favorite_teacher_List
public partial class Params_Edit_Favorite_teacher_List
{
#region Properties
public List<Favorite_teacher> My_List_To_Edit { get; set; }
public List<Favorite_teacher> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l1_List
public partial class Params_Edit_Loc_l1_List
{
#region Properties
public List<Loc_l1> My_List_To_Edit { get; set; }
public List<Loc_l1> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l2_List
public partial class Params_Edit_Loc_l2_List
{
#region Properties
public List<Loc_l2> My_List_To_Edit { get; set; }
public List<Loc_l2> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l3_List
public partial class Params_Edit_Loc_l3_List
{
#region Properties
public List<Loc_l3> My_List_To_Edit { get; set; }
public List<Loc_l3> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l4_List
public partial class Params_Edit_Loc_l4_List
{
#region Properties
public List<Loc_l4> My_List_To_Edit { get; set; }
public List<Loc_l4> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Person_List
public partial class Params_Edit_Person_List
{
#region Properties
public List<Person> My_List_To_Edit { get; set; }
public List<Person> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Question_List
public partial class Params_Edit_Question_List
{
#region Properties
public List<Question> My_List_To_Edit { get; set; }
public List<Question> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Question_token_List
public partial class Params_Edit_Question_token_List
{
#region Properties
public List<Question_token> My_List_To_Edit { get; set; }
public List<Question_token> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Student_List
public partial class Params_Edit_Student_List
{
#region Properties
public List<Student> My_List_To_Edit { get; set; }
public List<Student> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Student_report_List
public partial class Params_Edit_Student_report_List
{
#region Properties
public List<Student_report> My_List_To_Edit { get; set; }
public List<Student_report> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Teacher_List
public partial class Params_Edit_Teacher_List
{
#region Properties
public List<Teacher> My_List_To_Edit { get; set; }
public List<Teacher> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Teacher_category_List
public partial class Params_Edit_Teacher_category_List
{
#region Properties
public List<Teacher_category> My_List_To_Edit { get; set; }
public List<Teacher_category> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Teacher_favorite_List
public partial class Params_Edit_Teacher_favorite_List
{
#region Properties
public List<Teacher_favorite> My_List_To_Edit { get; set; }
public List<Teacher_favorite> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Teacher_report_List
public partial class Params_Edit_Teacher_report_List
{
#region Properties
public List<Teacher_report> My_List_To_Edit { get; set; }
public List<Teacher_report> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_type_code_List
public partial class Params_Edit_User_type_code_List
{
#region Properties
public List<User_type_code> My_List_To_Edit { get; set; }
public List<User_type_code> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
