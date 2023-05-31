using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3(params string[] value)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7LH9F75; Initial Catalog=ResultsP; Integrated Security=True");
            con.Open();

            SqlCommand count_cmd = new SqlCommand("SELECT COUNT(*) FROM TablePr", con);
            SqlCommand avage_cmd = new SqlCommand("SELECT AVG(age) FROM TablePr", con);
            SqlCommand maxage_cmd = new SqlCommand("SELECT MAX(age) FROM TablePr", con);
            SqlCommand minage_cmd = new SqlCommand("SELECT MIN(age) FROM TablePr", con);

            //SqlCommand pizza_cmd = new SqlCommand("SELECT COUNT(favfood) FROM TablePr WHERE favfood = 'Pizza'", con);
            SqlCommand pizza_cmd = new SqlCommand("SELECT 100 * (SELECT COUNT(favfood) FROM TablePr WHERE favfood = 'Pizza')/COUNT(*) FROM TablePr", con);
            SqlCommand pasta_cmd = new SqlCommand("SELECT 100 * (SELECT COUNT(favfood) FROM TablePr WHERE favfood = 'Pasta')/COUNT(*) FROM TablePr", con);
            SqlCommand pnw_cmd = new SqlCommand("SELECT 100 * (SELECT COUNT(favfood) FROM TablePr WHERE favfood = 'Pap and Wors')/COUNT(*) FROM TablePr", con);

            //SqlCommand eat_cmd = new SqlCommand("SELECT CAST(AVG(eat) AS INT) FROM TablePr WHERE hobbies = '1E'", con);
            SqlCommand eat_cmd = new SqlCommand("SELECT TOP 1 eat FROM TablePr GROUP BY eat ORDER BY COUNT(eat) DESC", con);
            SqlCommand movie_cmd = new SqlCommand("SELECT TOP 1 movies FROM TablePr GROUP BY movies ORDER BY COUNT(movies) DESC", con);
            SqlCommand tv_cmd = new SqlCommand("SELECT TOP 1 tv FROM TablePr GROUP BY tv ORDER BY COUNT(tv) DESC", con);
            SqlCommand radio_cmd = new SqlCommand("SELECT TOP 1 radio FROM TablePr GROUP BY radio ORDER BY COUNT(radio) DESC", con);

            InitializeComponent();

            results1.Text = count_cmd.ExecuteScalar().ToString();
            results2.Text = avage_cmd.ExecuteScalar().ToString();
            results3.Text = maxage_cmd.ExecuteScalar().ToString();
            results4.Text = minage_cmd.ExecuteScalar().ToString();
            results5.Text = pizza_cmd.ExecuteScalar().ToString() + "%";
            results6.Text = pasta_cmd.ExecuteScalar().ToString() + "%";
            results7.Text = pnw_cmd.ExecuteScalar().ToString() + "%";
            results8.Text = eat_cmd.ExecuteScalar().ToString();
            results9.Text = movie_cmd.ExecuteScalar().ToString();
            results10.Text = tv_cmd.ExecuteScalar().ToString();
            results11.Text = radio_cmd.ExecuteScalar().ToString();

            //results1.Text = value[0];
            //results2.Text = value[1];
            //results3.Text = value[2];
        }


        private void button1_Click(object sender, EventArgs e)
        {



            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
