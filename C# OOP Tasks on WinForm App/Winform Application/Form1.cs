using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          InitializeComponent();
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (confirmPass.Text == password.Text)
            {
                match.Visible = true;
                match.ForeColor = Color.Blue;
                match.Text = "Matched";
                submit.Enabled = true;
            }
            else
            {
                match.Visible = true;
                match.ForeColor = Color.Red;
                match.Text = "Un-Matched";
                submit.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=My-Data-Base;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

            Con.Open();

            if (Con.State == ConnectionState.Open)
            {
                connectionStr.ForeColor = Color.Blue;
                connectionStr.Text = "Successfully Connceted";
                connectionStr.Visible = true;
                submit.Enabled = true;
            }
            else
            {
                connectionStr.ForeColor = Color.Red;
                connectionStr.Text = "Not Successfully Connceted";
                connectionStr.Visible = true;
                submit.Enabled = false;
            }




            string Gender;

            if (male.Checked == true)
            {
                Gender = male.Text;
            }
            else {
                Gender = female.Text;
            }

            //*************************************** insert data in DataBase Code ****************************
            
            string insertQuery = "INSERT INTO myData (id,name,email,contact,gender) VALUES ('" + " 1" + "  ','" + fname.Text + " " + lname.Text + "  ',' " + email.Text + " ','  " + contact.Text + " ','  " + Gender + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, Con);
            int inserUpdate = insertCommand.ExecuteNonQuery();
            Con.Close();
            if (inserUpdate > 0)
            {
                MessageBox.Show("data inserted");
            }
            else
            {
                MessageBox.Show("data not inserted");
            }

            //**************************************************************************************************
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
    }
}


//***************************************Select data from data-base******************************************************************


//string query = "Select * from student";
//            SqlCommand Command = new SqlCommand(query, obj);
//            DataSet DS = new DataSet();

//            SqlDataAdapter DataAddapt = new SqlDataAdapter(Command);
//            DataAddapt.Fill(DS);
//            obj.Close();

//            foreach (DataTable DT in DS.Tables)
//            {
//                foreach (DataRow DR in DT.Rows)
//                {
//                    foreach (DataColumn DC in DT.Columns)
//                    {
//                        Console.WriteLine(DR[DC] + "\t");
//                    }
//                    Console.WriteLine();

//                }
//                Console.WriteLine();
//            }


//*********************************************************************************************************************************


//****************************************Update data from data-base******************************************************************

                    //string Query = "Update student set name = 'salman imran' where studentid ='11111'";
                    //SqlCommand Com = new SqlCommand(Query, obj);

                    //int upd = Com.ExecuteNonQuery();
                    //obj.Close();

                    //if (upd > 0)
                    //{
                    //    Console.WriteLine("Data Updated successfully");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Some issues were faced please ask for help");
                    //}

//***********************************************************************************************************************************


//****************************************Dalete data from data-base******************************************************************

                    //string que = "delete from [Table] where studentid='65513'";
                    //SqlCommand cmd = new SqlCommand(que, obj);
                    //obj.Open();
                    //int del = cmd.ExecuteNonQuery();
                    //obj.Close();

                    //if (del > 0)
                    //{
                    //    Console.WriteLine("Data Deleted successfully");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Some issues were faced please ask for help");
                    //}

//************************************************************************************************************************************