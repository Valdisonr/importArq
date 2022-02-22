using System;
using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace daoDLL
{
    public class Connection
    {
        #region atributes

        protected string _message;

        protected SqlConnection objConnection;

        protected SqlTransaction objTransaction;

        protected IList p_parameters = new List<SqlParameter>();

        protected SqlParameterCollection objParameters;

        protected DataTable objDataTable = new DataTable();

        protected SqlCommand objCommand = new SqlCommand();
        

        #endregion
          #region Methods

        public void connect()
        {
            try
            {
                // Connection to production database - discomment this line!!!
             
                // Connection to test database - comment this line!!!
         //     string strConnectionString = @"Data Source=TI02\SQLEXPRESS;Initial Catalog=acessonet;Integrated Security=True;Max Pool Size=300;Connect Timeout=15;";  // Pooling=True;Max Pool Size=valor;Min Pool Size=valor;Connection lifetime=300
                
          string strConnectionString = "Data Source=10.0.1.5 ;Initial Catalog=SecullumAcessoNet;User ID=sa; pwd=LSe8dk7th5;Max Pool Size=500;Connect Timeout=15;";
                objConnection = new SqlConnection(strConnectionString);
                
                objConnection.Open();
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }

        public string GetConncetion()
        {
            string nm_base = objConnection.Database;
            return nm_base;
        }
        public void disconnect()
        {
            objConnection.Close();
        }

        public void startTransaction()
        {
            objTransaction = objConnection.BeginTransaction();
        }

        public void commitTransaction()
        {
            objTransaction.Commit();
        }

        public void rollbackTransaction()
        {
            objTransaction.Rollback();
        }

        public string message
        {
            get { return _message; }
        }


       
         
     
        public void storedProcedure(string p_storedProcedure)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
          
            objCommand.CommandText = p_storedProcedure;
            
        }

        public bool execute()
        {
            try
            {
                objDataTable = new DataTable();
                objCommand.Parameters.Clear();
                for (int i = 0; i < p_parameters.Count; i++)
                    objCommand.Parameters.Add((SqlParameter)p_parameters[i]);
                objCommand.Connection = objConnection;

                if (objTransaction != null)
                {
                    objCommand.Transaction = objTransaction;
                }

                SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
                objDataAdapter.Fill(objDataTable);
                objParameters = objCommand.Parameters;
                _message = "";
                return true;
            }
            catch (Exception e)
            {
                _message = e.Message;
                return false;
            }
            finally
            {
                p_parameters.Clear();
            }
           
        }

        public void addParameter(string p_name, SqlDbType p_type, object p_value)
        {
            SqlParameter objParameter = new SqlParameter();
            objParameter.ParameterName = p_name;
            objParameter.Direction = ParameterDirection.Input;
            objParameter.SqlDbType = p_type;
            objParameter.Value = p_value;
            p_parameters.Add(objParameter);
        }

        public void addParameterOutput(string p_name, SqlDbType p_type)
        {
            SqlParameter objParameter = new SqlParameter();
            objParameter.ParameterName = p_name;
            objParameter.Direction = ParameterDirection.Output;
            objParameter.SqlDbType = p_type;
            objParameter.Value = DBNull.Value;
            
            p_parameters.Add(objParameter);
        }
        public void addParameterOutput(string p_name, SqlDbType p_type, int Size)
        {
            SqlParameter objParameter = new SqlParameter();
            objParameter.ParameterName = p_name;
            objParameter.Direction = ParameterDirection.Output;
            objParameter.SqlDbType = p_type;
            objParameter.Value = DBNull.Value;
            objParameter.Size = Size;
            p_parameters.Add(objParameter);
        }
        public object getParameter(string p_parameter_name)
        {
            return objParameters[p_parameter_name].Value;
        }
        
        public DataTable getDataTable()
        {
            return objDataTable;
        }

        public Connection()
        {
            connect();
        }

        #endregion
  
    }


}

