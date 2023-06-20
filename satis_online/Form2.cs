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
    public partial class Form2 : Form
    {
        string id = string.Empty;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FK5OHP1\\OKKES;Initial Catalog=SATIŞ MERKEZ(ONLİNE);Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_SATIŞ_MERKEZ_ONLİNE_DataSet2.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this._SATIŞ_MERKEZ_ONLİNE_DataSet2.urunler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from isim_g_ara(@isim)");
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataReader dr;
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
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from id_g_ara(@id)");
            cmd.Parameters.AddWithValue("@id", id);
            dataGridView1.DataSource = null;
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            dt.Dispose();
            dr.Dispose();
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from siparisler";
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
            dataGridView1.DataSource = null;
            cmd.CommandText = "m_aldi_alma";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            dt.Dispose();
            dr.Dispose();
            cmd.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "indirimli_ekle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urun_id", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@basla_tarihi", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@bitis_tarihi", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@indirimli_orani", Convert.ToInt32(textBox2.Text));
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            con.Close();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand("Select * from indirimliler");
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

        private void button7_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("Select dbo.toplam_satis() as toplam_satis");
            dataGridView1.DataSource = null;
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            dt.Dispose();
            dr.Dispose();
            cmd.Dispose();
        }
    }
}
