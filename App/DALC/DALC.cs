using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DALC
{
    
    public class DBHit
    {
        public string Token { get; set; }
        public string Procedure { get; set; }
    }
    public partial interface IDALC
    {
        #region Properties       
        bool ObjectTrackingEnabled { get; set; }
        int CommandTimeout { get; set; }
        string Token { get; set; }
        List<DBHit> DBHits { get; set; }
        #endregion

        void ExecuteEdit(string commandtext, object i_object, string pk = "");
        void ExecuteDelete(string commandtext, object i_object);
        IEnumerable<IDataRecord> ExecuteSelectQuery(string commandtext, object i_object);
        IEnumerable<IDataRecord> ExecuteSelectQuery2(string commandtext, object i_object);
        void Dispose();
    }
    public partial class MSSQL_DALC : IDALC
    {
        #region Properties
        String _ConnectionString;
        public bool ObjectTrackingEnabled { get; set; }
        public int CommandTimeout { get; set; }
        public Tools.Tools oTools;
        public string Token { get; set; }
        public List<DBHit> DBHits { get; set; }
        #endregion
        #region Constructor
        public MSSQL_DALC(string i_ConnectionString)
        {
            this._ConnectionString = i_ConnectionString;
			oTools = new Tools.Tools();
            this.CommandTimeout = 10 * 60; // 10 * 60 Seconds = 10 Minutes
            this.DBHits = new List<DBHit>();
        }
        #endregion

		#region Dispose
		public void Dispose()
		{
		}
		#endregion

        #region GV (Get Value From Data Record)
        T GV<T>(object input)
        {
           return (Convert.IsDBNull(input) == true) ? default(T) : (T)Convert.ChangeType(input, typeof(T));
        }
        #endregion
        

        #region MS SQL Server Specific Generic
        static SqlParameter ToConvertSqlParams(SqlCommand command, string name, object value, ParameterDirection pd = ParameterDirection.Input)
        {
            var p = command.CreateParameter();            
            p.ParameterName = name;
            p.Value = value;
            p.Direction = pd;
            if (p.Direction == ParameterDirection.Output || p.Direction == ParameterDirection.InputOutput)
            {
                if (p.SqlDbType == SqlDbType.NVarChar)
                {
                    p.Size = -1;
                }
            }
            
            return p;
        }
        public void Assure_SP_Existence(string sp)
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            SqlConnection oConn = new SqlConnection(this._ConnectionString);
            using (var connection = oConn)
            {

                using (var command = new SqlCommand(string.Format("EXEC UP_ASSURE_ROUTINE_EXISTENCE '{0}'", sp), connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            #endregion
        }
        public void ExecuteEdit(string commandtext, object i_object, string pk = "")
        {
            if (!string.IsNullOrEmpty(this.Token)) { this.DBHits.Add(new DBHit() { Token = this.Token, Procedure = commandtext }); }
            #region Declaration And Initialization Section.
            Dictionary<string, object> args = new Dictionary<string, object>();
            SqlConnection oConn = new SqlConnection(this._ConnectionString);
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Body Section.
            #endregion

            #region Assure Procedure Existence
            //Assure_SP_Existence(commandtext);
            #endregion

            #region Prepare Parameters
            //args = (from x in i_object.GetType().GetProperties() select x).ToDictionary(x => string.Format("P__{0}", x.Name), x => (x.GetGetMethod().Invoke(i_object, null) == null ? "" : x.GetGetMethod().Invoke(i_object, null).ToString()));
            #endregion

            using (var connection = oConn)
            {
                using (var command = new SqlCommand(commandtext, connection))
                {
                    SqlCommand cmd = new SqlCommand(commandtext, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = this.CommandTimeout;
                    connection.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);

                    string s = "";
                    foreach (SqlParameter p in cmd.Parameters)
                    {
                        if (p.ParameterName.StartsWith("@P__"))
                        {
                            args.Add
                                (
                                    p.ParameterName, 
                                    oTools.GetPropValue(i_object, p.ParameterName.Replace("@P__", "")) == null ? DBNull.Value : oTools.GetPropValue(i_object, p.ParameterName.Replace("@P__", ""))
                                );
                        }
                    }

                    //throw new BLCException(s);
                    var Parameters = args.Select
                                        (
                                            x => ToConvertSqlParams
                                                    (
                                                        command,
                                                        x.Key,
                                                        x.Value,
                                                        x.Key == string.Format("@P__{0}", pk) ? ParameterDirection.InputOutput : ParameterDirection.Input
                                                    )
                                        );
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters.ToArray());
                    //connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
					if (!string.IsNullOrEmpty(pk))
                    {
                      oTools.SetPropValue(i_object, pk, command.Parameters[command.Parameters.IndexOf(string.Format("@P__{0}", pk.ToUpper()))].Value);                    
					}
                }
            }
        }
        public void ExecuteDelete(string commandtext, object i_object)
        {
            if (!string.IsNullOrEmpty(this.Token)) { this.DBHits.Add(new DBHit() { Token = this.Token, Procedure = commandtext }); }
            #region Declaration And Initialization Section.
            Dictionary<string, object> args = new Dictionary<string, object>();
            SqlConnection oConn = new SqlConnection(this._ConnectionString);
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Body Section.
            #endregion

            #region Assure Procedure Existence
            //Assure_SP_Existence(commandtext);
            #endregion

            #region Prepare Parameters
            //args = (from x in i_object.GetType().GetProperties() select x).ToDictionary(x => string.Format("P__{0}", x.Name), x => (x.GetGetMethod().Invoke(i_object, null) == null ? "" : x.GetGetMethod().Invoke(i_object, null).ToString()));
            #endregion

            using (var connection = oConn)
            {
                using (var command = new SqlCommand(commandtext, connection))
                {

                    SqlCommand cmd = new SqlCommand(commandtext, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = this.CommandTimeout;
                    connection.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    foreach (SqlParameter p in cmd.Parameters)
                    {
                        if (p.ParameterName.StartsWith("@P_"))
                        {
                            //args.Add(p.ParameterName, oTools.GetPropValue(i_object, p.ParameterName.Replace("@P__", "")).ToString());
                            args.Add(p.ParameterName, oTools.GetPropValue(i_object, p.ParameterName.Replace("@P__", "")) == null ? DBNull.Value : oTools.GetPropValue(i_object, p.ParameterName.Replace("@P__", "")));
                        }
                    }

                    var Parameters = args.Select
                                        (
                                            x => ToConvertSqlParams
                                                    (
                                                        command,
                                                        x.Key,
                                                        x.Value
                                                    )
                                        );
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters.ToArray());
                    //connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        public IEnumerable<IDataRecord> ExecuteSelectQuery(string commandtext, object i_object)
        {
            if (!string.IsNullOrEmpty(this.Token)) { this.DBHits.Add(new DBHit() { Token = this.Token, Procedure = commandtext }); }
            Tools.Tools oTools = new Tools.Tools();
            #region Assure Procedure Existence
            //Assure_SP_Existence(commandtext);
            #endregion

            SqlConnection oConn = new SqlConnection(this._ConnectionString);
            Dictionary<string, object> args = new Dictionary<string, object>();
            //args = (from x in i_object.GetType().GetProperties() select x).ToDictionary(x => string.Format("P__{0}", x.Name), x => (x.GetGetMethod().Invoke(i_object, null) == null ? "" : x.GetGetMethod().Invoke(i_object, null).ToString()));

            using (var connection = oConn)
            {
                SqlCommand cmd = new SqlCommand(commandtext, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = this.CommandTimeout;
                connection.Open();
                SqlCommandBuilder.DeriveParameters(cmd);

                foreach (SqlParameter p in cmd.Parameters)
                {
                    if (p.ParameterName.StartsWith("@P__"))
                    {
						var x = ((IDictionary<string, object>)i_object)[p.ParameterName.Replace("@P__", "")] == null ? DBNull.Value : ((IDictionary<string, object>)i_object)[p.ParameterName.Replace("@P__", "")];
                         args.Add
                            (
                                p.ParameterName, 
                                x
                            );

                    }
                }

                using (var command = new SqlCommand(commandtext, connection))
                {

                    //use index,values to convert parameters passed  to sqlparameters         
                    var Parameters = args.Select
                                         (
                                             x => ToConvertSqlParams
                                                     (
                                                         command,
                                                         x.Key,
                                                         x.Value,
														 cmd.Parameters[x.Key].Direction
                                                     )
                                         );
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters.ToArray());
                    //connection.Open();
                    //Execute the query 
                    using (var reader = command.ExecuteReader())
                    {
                        foreach (IDataRecord record in reader)
                            yield return record;
                    }

					foreach (SqlParameter param in cmd.Parameters)
                    {
                        if (
                                (param.Direction == ParameterDirection.InputOutput) || 
                                (param.Direction == ParameterDirection.Output)
                            )
                        {
                            // Console.WriteLine(command.Parameters[param.ParameterName].Value);
                            ((IDictionary<string, object>)i_object)[param.ParameterName.Replace("@P__", "")] = command.Parameters[param.ParameterName].Value;
                        }
                    }

                    connection.Close();
                }
            }
        }
        public IEnumerable<IDataRecord> ExecuteSelectQuery2(string commandtext, object i_object)
        {
            if (!string.IsNullOrEmpty(this.Token)) { this.DBHits.Add(new DBHit() { Token = this.Token, Procedure = commandtext }); }
            Tools.Tools oTools = new Tools.Tools();

            SqlConnection oConn = new SqlConnection(this._ConnectionString);
            Dictionary<string, object> args = new Dictionary<string, object>();
            //args = (from x in i_object.GetType().GetProperties() select x).ToDictionary(x => string.Format("P__{0}", x.Name), x => (x.GetGetMethod().Invoke(i_object, null) == null ? "" : x.GetGetMethod().Invoke(i_object, null).ToString()));

            using (var connection = oConn)
            {
                SqlCommand cmd = new SqlCommand(commandtext, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = this.CommandTimeout;
                connection.Open();
                SqlCommandBuilder.DeriveParameters(cmd);

                foreach (SqlParameter p in cmd.Parameters)
                {
                    if (p.ParameterName != "@RETURN_VALUE")
                    {
                        if (p.ParameterName.StartsWith("@"))
                        {
                            args.Add(p.ParameterName, oTools.GetPropValue(i_object, p.ParameterName.Replace("@", "")) == null ? DBNull.Value : oTools.GetPropValue(i_object, p.ParameterName.Replace("@", "")));

                        }
                    }
                }

                using (var command = new SqlCommand(commandtext, connection))
                {

                    //use index,values to convert parameters passed  to sqlparameters         
                    var Parameters = args.Select
                                         (
                                             x => ToConvertSqlParams
                                                     (
                                                         command,
                                                         x.Key,
                                                         x.Value
                                                     )
                                         );
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters.ToArray());
                    //connection.Open();
                    //Execute the query 
                    using (var reader = command.ExecuteReader())
                    {
                        foreach (IDataRecord record in reader)
                            yield return record;
                    }
                    connection.Close();
                }
            }
        }

        #endregion
    }
}





