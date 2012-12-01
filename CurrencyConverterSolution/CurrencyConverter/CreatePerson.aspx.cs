using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Data;
//using CurrencyConverter.model.Person;

namespace CurrencyConverter
{

    /**
     this class is the controller for CreatePerson.asp
    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePerson.aspx.cs" Inherits="CurrencyConverter.WebForm1" %>
     */
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection myConnection;
        public WebForm1()
        {
            System.Diagnostics.Trace.WriteLine("init new page controller");
            // @ skip '\' as escape chacacter and use is for the char it is.
            //string connectionString=@"Data Source=VM-XP-VS2010-RS\SQLEXPRESS;Initial Catalog=prova;Integrated Security=True";
            string webConfigConnectionString = WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;
            myConnection = new SqlConnection(webConfigConnectionString);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("page load");
            // Define the ADO.NET objects.
            string selectSQL = "SELECT * FROM person";
            SqlCommand cmd = new SqlCommand(selectSQL, myConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // Fill the DataSet.
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Products");
            // Perform the binding.
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void storePerson(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("name: ");
            sb.Append("[" + txtName.Text + "], ");
            sb.Append("surname: ");
            sb.Append("["+txtSurname.Text+"], ");
            sb.Append("dirthData: ");
            sb.Append("[" + txtBirthDate.Text + "]");

            String incomingData = sb.ToString();

            //Person person = new Person(name, surname, birthDate);
            //personService.store(person);
            System.Diagnostics.Trace.WriteLine(/*person.toString()*/ String.Format("incomingData:[{0}]",incomingData));

            insertPerson();
            List<string> persons = readAllPersons();
            persons.ForEach(delegate(String name) {
                Console.WriteLine("ddd_"+name);
                System.Diagnostics.Trace.WriteLine(name);
            });
        }

        private List<string> readAllPersons()
        {
            List<string> data = new List<String>();
            String sql = "select * from Person";
            SqlCommand sqlCmd = new SqlCommand(sql, myConnection);
            
            myConnection.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while(reader.Read()){
                data.Add(reader[0].ToString());
            }

            reader.Close();
            myConnection.Close();
            return data;
        }


        private void insertPerson()
        {
            try {
                myConnection.Open();

                string format = "MM/dd/yyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime birthDate = DateTime.ParseExact(txtBirthDate.Text, format, provider);
                
                String sql = "insert into  [prova].[dbo].[Person] (name, surname, birthDate) values (@name,@surname,@birthDate)";

                SqlCommand sqlCmd = new SqlCommand(sql, myConnection);
                sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                sqlCmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                sqlCmd.Parameters.AddWithValue("@birthDate", birthDate);
                sqlCmd.ExecuteNonQuery();
            } catch (Exception err) {
                // Handle an error by displaying the information.
                lblInfo.Text = "Error reading the database. ";
                lblInfo.Text += err.Message;
            } finally {
                // Either way, make sure the connection is properly closed.
                // (Even if the connection wasn't opened successfully,
                // calling Close() won't cause an error.)
                myConnection.Close();
                lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
                lblInfo.Text += myConnection.State.ToString();
            }
        }
       }
}