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
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Sem_3\Software_Process\FoodOrderingSystem\HLM_6\WindowsFormsApp1\PizzaMenu.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        public void Display_data()
        {
            Con.Open(); 
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table]";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(data);
            dataGridView1.DataSource = data;
            Con.Close();
        }

        public void ClearTable ()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear(); 
        }

        //Add 
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into [Table] values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                Con.Close();
                ClearTable(); 
                Display_data();
            }
            else
            {
                MessageBox.Show("The field is blank.");
                return; 
            }
        }
       
        //Remove 
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                Con.Open();
                SqlCommand con = new SqlCommand("Select * from [Table] where name = '" + textBox1.Text + "'", Con);
                SqlDataReader dataReader = con.ExecuteReader();

                if (dataReader.HasRows)
                {
                    Con.Close();
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from [Table] where name = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery(); 
                    Con.Close();
                    ClearTable();
                    Display_data();
                    MessageBox.Show("Data Deleted."); 
                }
                else
                {
                    MessageBox.Show("No Data Found.");
                    ClearTable();
                    Con.Close(); 
                }
            } 
            else
            {
                MessageBox.Show("The name field is blank.");
                ClearTable(); 
                return;
            }
        }

        //Update 
        private void button3_Click(object sender, EventArgs e)
        { 
            Form2 frm2 = new Form2(this); 
            frm2.Show();
        }

        //Display 
        private void button4_Click(object sender, EventArgs e)
        {
            Display_data();
            ClearTable(); 
        }

        //Search 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Con;
            command.CommandText = "SELECT * from [Table] where name LIKE '%'+@name+'%'";
            command.Parameters.AddWithValue("@name", textBox4.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            data.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            Con.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display_data(); 
        } 
    }
}
