using Npgsql;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace EditProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecation; User Id=postgres; Password=rafisulthan06"))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT name FROM reg_province";
                    cmd.CommandType = CommandType.Text;


                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Provinsi.Items.Add(reader["name"].ToString());
                    }

                    reader.Close();
                    cmd.Dispose();

                    // kabupaten
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT name FROM reg_kabupaten";
                    command.CommandType = CommandType.Text;


                    NpgsqlDataReader rdr = command.ExecuteReader();
                   
                    while (rdr.Read())
                    {
                        Kabupaten.Items.Add(rdr["name"].ToString());
                    }

                    rdr.Close();
                    command.Dispose();

                    // kecamatan
                    NpgsqlCommand cmnd = new NpgsqlCommand();
                    cmnd.Connection = connection;
                    cmnd.CommandText = "SELECT name FROM reg_kecamatan";
                    cmnd.CommandType = CommandType.Text;


                    NpgsqlDataReader rd = cmnd.ExecuteReader();

                    while (rd.Read())
                    {
                        Kecamatan.Items.Add(rd["name"].ToString());
                    }

                    rd.Close();
                    cmnd.Dispose();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                {
                    EditButton.BackColor = Color.Blue;
                }
            }
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox4.Focus();
        }
    }
}