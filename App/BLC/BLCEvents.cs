using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using BLC;
namespace BLC
{
public partial class BLC
{

#region Enum_API_Method
public enum Enum_API_Method
{

}
#endregion

#region Prepare_BLCInitializer
public BLCInitializer Prepare_BLCInitializer(string i_Ticket, Enum_API_Method i_Enum_API_Method)
{
#region Declaration And Initialization Section.
BLCInitializer oBLCInitializer = new BLCInitializer();
BLC oBLC_Default = new BLC();
string str_CUSTOM_BLC_INIT = string.Empty;
#endregion
#region Body Section.
if (this.OnPreEvent_BLC_Init != null)
{
oBLCInitializer = this.OnPreEvent_BLC_Init(i_Ticket, i_Enum_API_Method);
return oBLCInitializer;
}
else
{
oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
}
#endregion
#region Return Section.
return oBLCInitializer;
#endregion
}
#endregion

#region General Pre/Post events
public delegate void PreEvent_Handler_General(string i_MethodName);
public delegate void PostEvent_Handler_General(string i_MethodName);
public event PreEvent_Handler_General OnPreEvent_General;
public event PostEvent_Handler_General OnPostEvent_General;
#endregion
#region General Pre/Post BLC_Init
public delegate BLCInitializer PreEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public delegate BLCInitializer PostEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
#endregion
}
}
