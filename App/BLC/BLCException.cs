using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLC;

namespace BLC
{
public partial class BLCException : Exception
{
public string Code { get; set; }
#region Constructors
public BLCException(string i_MessageContent): base(i_MessageContent)
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
#endregion
}
#endregion
}
}
