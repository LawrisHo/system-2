using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Sem_3\Software_Process\FoodOrderingSystem\HLM_6\WindowsFormsApp1\PizzaMenu.mdf;Integrated Security=True");
        Form1 frm;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        public void ClearData()
        {
            txtUpdateName.Clear();
            txtUpdatePrice.Clear();
            txtUpdateDescription.Clear(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Con.Open(); 

            if(txtSearch.Text != string.Empty)
            {
                SqlCommand con = new SqlCommand("Select * from [Table] where name = '" + txtSearch.Text + "'", Con);
                SqlDataReader dataReader = con.ExecuteReader(); 

                if(dataReader.HasRows)
                {
                    Con.Close();
                    Con.Open(); 
                    SqlCommand cmd = new SqlCommand("select name from [table] where name = '" + txtSearch.Text + "'", Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    txtUpdateName.Text = reader["name"].ToString();
                    reader.Close();

                    cmd = new SqlCommand("select price from [table] where name = '" + txtSearch.Text + "'", Con);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    txtUpdatePrice.Text = reader["price"].ToString();
                    reader.Close();

                    cmd = new SqlCommand("select description from [table] where name = '" + txtSearch.Text + "'", Con);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    txtUpdateDescription.Text = reader["description"].ToString();
                    reader.Close();

                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Found.");
                    txtSearch.Clear(); 
                    Con.Close(); 
                }
            }
            else
            {
                MessageBox.Show("The field is blank.");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                Con.Open();
                SqlCommand con = new SqlCommand("Select * from [Table] where name = '" + txtSearch.Text + "'", Con);
                SqlDataReader dataReader = con.ExecuteReader();

                if(dataReader.HasRows)
                {
                    Con.Close(); 
                    if (txtUpdateName.Text != string.Empty && txtUpdatePrice.Text != string.Empty && txtUpdateDescription.Text != string.Empty)
                    {
                        Con.Open(); 
                        SqlCommand cmd = new SqlCommand("UPDATE [table] SET name = '" + txtUpdateName.Text + "', price = '" + txtUpdatePrice.Text + "', " +
                        "description = '" + txtUpdateDescription.Text + "' WHERE name = '" + txtSearch.Text + "'", Con);
                        cmd.ExecuteNonQuery();
                        Con.Close();

                        frm.Display_data();

                        MessageBox.Show("Update Data Successfully");
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("The field is blank.");
                    }
                }
                else
                {
                    MessageBox.Show("No Data Found."); 
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("You must search for the data first.");
                ClearData(); 
                return;
            }
        } 
    }
}
