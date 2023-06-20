using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace satis_online
{
    public partial class Form1 : Form
    {
        static string id = string.Empty;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FK5OHP1\\OKKES;Initial Catalog=SATIŞ MERKEZ(ONLİNE);Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_SATIŞ_MERKEZ_ONLİNE_DataSet1.kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter.Fill(this._SATIŞ_MERKEZ_ONLİNE_DataSet1.kategoriler);
            // TODO: This line of code loads data into the '_SATIŞ_MERKEZ_ONLİNE_DataSet.firmalar' table. You can move, or remove it, as needed.
            this.firmalarTableAdapter.Fill(this._SATIŞ_MERKEZ_ONLİNE_DataSet.firmalar);
            // TODO: This line of code loads data into the '_SATIŞ_MERKEZ_ONLİNE_DataSet1.kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter.Fill(this._SATIŞ_MERKEZ_ONLİNE_DataSet1.kategoriler);
            // TODO: This line of code loads data into the '_SATIŞ_MERKEZ_ONLİNE_DataSet.firmalar' table. You can move, or remove it, as needed.
            this.firmalarTableAdapter.Fill(this._SATIŞ_MERKEZ_ONLİNE_DataSet.firmalar);
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "Urun_ekle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urun_adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@urun_fiyati", textBox2.Text);
            cmd.Parameters.AddWithValue("@urun_adedi", textBox3.Text);
            cmd.Parameters.AddWithValue("@ozellik", textBox4.Text);
            cmd.Parameters.AddWithValue("@firma_id", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@kategori_id", comboBox2.SelectedValue);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            con.Close();
            refresh();
        }
        public void refresh()
        {
            cmd.CommandText = "select * from urunler";
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            dt.Dispose();
            dr.Dispose();
            cmd.Dispose();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();

                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.Rows[i].Cells[5].Value.ToString();
                comboBox2.SelectedValue = dataGridView1.Rows[i].Cells[6].Value.ToString();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from urunler where urun_id="+Convert.ToInt32(id),con);
            cmd.ExecuteNonQuery();
            con.Close();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmd.CommandText = "select * from urin_silinen";
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            dt.Dispose();
            dr.Dispose();
            cmd.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "u_guncele";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@fiyat", textBox3.Text);
            cmd.Parameters.AddWithValue("@adeti", textBox2.Text);
            cmd.Parameters.AddWithValue("@ozellik", textBox4.Text);
            cmd.Parameters.AddWithValue("@f_id", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@k_id", comboBox2.SelectedValue);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            con.Close();
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmd.CommandText = "select * from urun_guncelenen";
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            dt.Dispose();
            dr.Dispose();
            cmd.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            refresh();
        }

    }
}
