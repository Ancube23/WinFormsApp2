using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        //Form3 f3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7LH9F75; Initial Catalog=ResultsP; Integrated Security=True");
            //con.Open();
            // SqlDataAdapter da = new SqlDataAdapter();
            //da.InsertCommand = new SqlCommand("INSERT COUNT(*) TablePr VALUES(@lastname, @firstname, @pnumber, @date, @age, @favfood, @hobbies)", con);
           // SqlCommand count_cmd = new SqlCommand("SELECT COUNT(*) FROM TablePr", con);
           // SqlCommand avage_cmd = new SqlCommand("SELECT AVG(age) FROM TablePr", con);
            //SqlCommand maxage_cmd = new SqlCommand("SELECT MAX(age) FROM TablePr", con);

            //Form3 countf3 = new Form3(count_cmd.ExecuteScalar().ToString());
            //Form3 avagef3 = new Form3(avage_cmd.ExecuteScalar().ToString());
           // Form3 maxagef3 = new Form3(maxage_cmd.ExecuteScalar().ToString());


            //Form3 f3 = new Form3("");
            //countf3.Show();
            //avagef3.Show();

            //Form3.results1.text = da.ExecuteScalar().ToString();
            //MessageBox.Show(count_cmd.ExecuteScalar().ToString);


            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }
    }

}