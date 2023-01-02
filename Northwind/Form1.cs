using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        DataTable tablo = new DataTable();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            VeritabaniBagla();
        }
        SqlConnection conn;
        private void VeritabaniBagla()
        {
            
            conn = new SqlConnection("server=.;database=NORTHWND;Trusted_Connection=True;");
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from Employees", conn);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into (LastName,FirstName,Title,TitleOfCourtesy,Birthdate,Hiredate,Address,City,Region,postalcode,country,HomePhone,Extension) values (@lastname,@firstname,@title,@titleof,@birthdate,@hiredate,@adres,@city,@region,@postacode,@country,@homephone,@extension)");

            cmd.Parameters.AddWithValue("@lastname",txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@firstname",txtAdi.Text);
            cmd.Parameters.AddWithValue("@title",txtTitle.Text);
            cmd.Parameters.AddWithValue("@titleof",txtTitleOfCoursy.Text);
            cmd.Parameters.AddWithValue("@birthdate",Convert.ToDateTime(dtDogumTarihi.Text));
            cmd.Parameters.AddWithValue("@hiredate", Convert.ToDateTime(dtIseBaslamaTarihi.Text));
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@city", txtSehir.Text);
            cmd.Parameters.AddWithValue("@region", txtBolge.Text);
            cmd.Parameters.AddWithValue("@country", txtUlke.Text);

            cmd.Connection = conn;
            if(conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                int satirSayisi = cmd.ExecuteNonQuery();
                MessageBox.Show(satirSayisi + "Satýr güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Employees set FirstName=@firstname,LastName=@lastnameTitle=@title, TitleOfCourtesy=@titleof, Birthdate=@birthdate, Hiredate=@hiredate,Address=@adres,City=@city,Region=@region,postalcode=@postacode,country=@country,HomePhone=@homephone,Extension=@extension where EmployeeID = @employeeId");

            cmd.Parameters.AddWithValue("@employeeId",txtCalisanId.Text);
            cmd.Parameters.AddWithValue("@lastname", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@firstname", txtAdi.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@titleof", txtTitleOfCoursy.Text);
            cmd.Parameters.AddWithValue("@birthdate", Convert.ToDateTime(dtDogumTarihi.Text));
            cmd.Parameters.AddWithValue("@hiredate", Convert.ToDateTime(dtIseBaslamaTarihi.Text));
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@city", txtSehir.Text);
            cmd.Parameters.AddWithValue("@region", txtBolge.Text);
            cmd.Parameters.AddWithValue("@country", txtUlke.Text);

            cmd.Connection = conn;
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                int satirSayisi = cmd.ExecuteNonQuery();
                MessageBox.Show(satirSayisi + "Satýr güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete Employees where EmployeeID=@employeeId");
            cmd.Parameters.AddWithValue("@employeeId", txtCalisanId.Text);

            cmd.Connection = conn;
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                int satirSayisi = cmd.ExecuteNonQuery();
                MessageBox.Show(satirSayisi + "Satýr güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCalisanId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTitleOfCoursy.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtDogumTarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dtIseBaslamaTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSehir.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBolge.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtUlke.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
    }
}