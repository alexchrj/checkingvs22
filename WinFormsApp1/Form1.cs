using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0TNBD5T\\SQLEXPRESS;Initial Catalog=form;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertquery = "INSERT INTO Table_1 VALUES (@name, @age)";
            SqlCommand cmd = new SqlCommand(insertquery, con);
            cmd.Parameters.AddWithValue("name",textBox1.Text);
            cmd.Parameters.AddWithValue("age",textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("registered successfully","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            con.Close();
        }
    }
}
