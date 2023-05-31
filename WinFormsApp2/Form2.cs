using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Sbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7LH9F75; Initial Catalog=ResultsP; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO TablePr VALUES(@lastname, @firstname, @pnumber, @date, @age, @favfood, @eat, @movies, @tv, @radio)", con);
            da.InsertCommand.Parameters.Add("@lastname", SqlDbType.VarChar).Value = textSurname.Text;
            da.InsertCommand.Parameters.Add("@firstname", SqlDbType.VarChar).Value = textName.Text;
            da.InsertCommand.Parameters.Add("@pnumber", SqlDbType.Int).Value = textNumber.Text;
            da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = textDate1.Text;
            da.InsertCommand.Parameters.Add("@age", SqlDbType.Int).Value = textAge.Text;

            //All Checkboxes checked
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pasta, Pap and Wors, Chicken stir-fry, Beef stir-fry, Other";
            }

            //Five Checkboxes Checked
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pasta, Pap and Wors, Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza ,Pap and Wors, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza , Pasta, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza , Pasta, Pap and Wors, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza , Pasta, Pap and Wors, Chicken stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza , Pasta, Pap and Wors, Chicken stir-fry";
            }

            //Four Checkboxes Checked
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pasta, Pap and Wors, Chicken stir-fry";
            }
            else if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors, Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox2.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Chicken stir-fry, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pasta, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pap and Wors, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pap and Wors, Chicken stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox5.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pap and Wors, Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox2.Checked && checkBox3.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors, Beef stir-fry, Other";
            }
            else if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors, Chicken stir-fry, Other";
            }

            //Three Checkboxes Checked
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pasta, Pap and Wors";
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pap and Wors, Chicken stir-fry";
            }
            else if (checkBox1.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox1.Checked && checkBox4.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Chicken stir-fry, Other";
            }
            else if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors, Chicken stir-fry";
            }
            else if (checkBox2.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox2.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Beef stir-fry, Other";
            }
            else if (checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors, Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox3.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors, Beef stir-fry, Other";
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pap and Wors, Other";
            }
            else if (checkBox2.Checked && checkBox3.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors, Other";
            }

            //Two Checkboxes Checked
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pasta";
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Pap and Wors";
            }
            else if (checkBox1.Checked && checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Chicken stir-fry";
            }
            else if (checkBox1.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Beef stir-fry";
            }
            else if (checkBox1.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Other";
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Pap and Wors";
            }
            else if (checkBox2.Checked && checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Chicken stir-fry";
            }
            else if (checkBox2.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza, Beef stir-fry";
            }
            else if (checkBox2.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta, Other";
            }
            else if (checkBox3.Checked && checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors, Chicken stir-fry";
            }
            else if (checkBox3.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors, Beef stir-fry";
            }
            else if (checkBox3.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors, Other";
            }
            else if (checkBox4.Checked && checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Chicken stir-fry, Beef stir-fry";
            }
            else if (checkBox4.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Chicken stir-fry, Other";
            }
            else if (checkBox5.Checked && checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Beef stir-fry, Other";
            }

            //One Checkbox Checked
            else if (checkBox1.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pizza";
            }
            else if (checkBox2.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pasta";
            }
            else if (checkBox3.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Pap and Wors";
            }
            else if (checkBox4.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Chicken stir-fry";
            }
            else if (checkBox5.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Beef stir-fry";
            }
            else if (checkBox6.Checked)
            {
                da.InsertCommand.Parameters.Add("@favfood", SqlDbType.VarChar).Value = "Other";
            }
            else
            {
                MessageBox.Show("Tick Atleast 1 Favourite Food");
            }

            //Coding on Eating rating
            if (radioButton1.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@eat", SqlDbType.Char).Value = "Strongly Agree";
            }
            else if (radioButton5.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@eat", SqlDbType.Char).Value = "Agree";
            }
            else if (radioButton9.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@eat", SqlDbType.Char).Value = "Neautral";
            }
            else if (radioButton13.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@eat", SqlDbType.Char).Value = "Disagree";
            }
            else if (radioButton17.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@eat", SqlDbType.Char).Value = "Strongly Disagree";
            }
            else
            {
                MessageBox.Show("Enter rating on Eating");
            }

            //Coding on Movies rating
            if (radioButton2.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@movies", SqlDbType.Char).Value = "Strongly Agree";
            }
            else if (radioButton6.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@movies", SqlDbType.Char).Value = "Agree";
            }
            else if (radioButton10.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@movies", SqlDbType.Char).Value = "Neautral";
            }
            else if (radioButton14.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@movies", SqlDbType.Char).Value = "Disagree";
            }
            else if (radioButton18.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@movies", SqlDbType.Char).Value = "Strongly Disagree";
            }
            else
            {
                MessageBox.Show("Enter rating on Movies");
            }

            //Coding on Tv rating
            if (radioButton3.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@tv", SqlDbType.Char).Value = "Strongly Agree";
            }
            else if (radioButton7.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@tv", SqlDbType.Char).Value = "Agree";
            }
            else if (radioButton11.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@tv", SqlDbType.Char).Value = "Neautral";
            }
            else if (radioButton15.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@tv", SqlDbType.Char).Value = "Disagree";
            }
            else if (radioButton19.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@tv", SqlDbType.Char).Value = "Strongly Disagree";
            }
            else
            {
                MessageBox.Show("Enter rating on Tv");
            }

            //Coding on Radio rating
            if (radioButton4.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@radio", SqlDbType.Char).Value = "Strong Agree";
            }
            else if (radioButton8.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@radio", SqlDbType.Char).Value = "Agree";
            }
            else if (radioButton12.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@radio", SqlDbType.Char).Value = "Neautral";
            }
            else if (radioButton16.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@radio", SqlDbType.Char).Value = "Disagree";
            }
            else if (radioButton20.Checked == true)
            {
                da.InsertCommand.Parameters.Add("@radio", SqlDbType.Char).Value = "Strongly Disagree";
            }
            else
            {
                MessageBox.Show("Enter rating on Radio");
            }

            if (textSurname.Text == "")
            {
                MessageBox.Show("Enter Your Surname");
            }
            else if (textName.Text == "")
            {
                MessageBox.Show("Enter Your Name");
            }
            else if (textNumber.Text == "")
            {
                MessageBox.Show("Enter Your Phone Number");
            }
            else if (textDate1.Text == "")
            {
                MessageBox.Show("Enter Your Date");
            }
            else if (textAge.Text == "")
            {
             MessageBox.Show("Enter Your Date");
            }
           // else if (textAge.Text <  5)
            //{
            //MessageBox.Show("Age is between 5-120");
            //}
            con.Open();
            da.InsertCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Survey Completed!!");

            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

    }
}
