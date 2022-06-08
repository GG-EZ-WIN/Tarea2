using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerberiaVacana
{
    public partial class Form1 : Form
    {
        //Listas
        List<string> ListaBarberos = new List<string>();
        List<string> Hora = new List<string>();
        List<Appoinment> Appoiments = new List<Appoinment>();

        //Inicios
        public Form1()
        {
            InitializeComponent();

            LLenarBarbero();
            LlenarHora();
        }
        private void LLenarBarbero()
        {
            ListaBarberos.Add("Los Barberos ma Vacano");
            ListaBarberos.Add("Juan");
            ListaBarberos.Add("Yuan");
            ListaBarberos.Add("John");
            listabarbero.DataSource = ListaBarberos;
        }

        private void LlenarHora()
        {
            Hora = Enumerable.Range(09, 09).Select(i => (DateTime.MinValue.AddHours(i)).ToString("hh.mm tt")).ToList();
            ListaHora.DataSource = Hora;
        }
        private void BotonCrearCita_Click(object sender, EventArgs e)
        {
            Empty();
            Default();
            GrupoCaja.Enabled = true;
        }

        private void Empty()
        {
            ClienteTexto.Text = string.Empty;
            CedulaTexto.Text = string.Empty;
            CorreoTexto.Text = string.Empty;
            TelefonoTexto.Text = string.Empty;
        }

        private void Default()
        {
            listabarbero.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void BotonCancelarCita_Click(object sender, EventArgs e)
        {
            GrupoCaja.Enabled = false;

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            SAppoinment();

        }

        public class Appoinment
        {
            public string ID { get; set; }
            public string Code { get; set; }
            public string NombreCliente { get; set; }
            public string TelefonoCliente { get; set; }
            public string MailCliente { get; set; }
            public string Barbero { get; set; }
            public DateTime Fecha { get; set; }
            public string DateCustom
            {
                get
                {
                    return Fecha.ToString("MMM dd, yyyy");
                }
            }
            public string Hora { get; set; }
            public DateTime FechaCreacion { get; set; }
        }

        private void GAppoinment()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Appoiments;
            dataGridView1.Columns["ID"].HeaderText = "Cedula";
            dataGridView1.Columns["Code"].HeaderText = "Codigo";
            dataGridView1.Columns["NombreCliente"].HeaderText = "Cliente";
            dataGridView1.Columns["TelefonoCliente"].HeaderText = "Telefono";
            dataGridView1.Columns["MailCliente"].HeaderText = "Correo";
            dataGridView1.Columns["Barbero"].HeaderText = "Barbero";
            dataGridView1.Columns["Fecha Pautada"].HeaderText = "Fecha Pautada";
            dataGridView1.Columns["Hora"].HeaderText = "Hora";
            dataGridView1.Columns["FechaCreacion"].HeaderText = "Fecha de Creacion";
        }


        private void SAppoinment()
        {
            var random = new Random();
            var appoinment = new Appoinment
            {
                ID = CedulaTexto.Text,
                Code = random.Next(1000000, 9999999).ToString(),
                NombreCliente = ClienteTexto.Text,
                TelefonoCliente = TelefonoTexto.Text,
                MailCliente = CorreoTexto.Text,
                Barbero = listabarbero.SelectedValue.ToString(),
                Hora = ListaHora.SelectedValue.ToString(),
                FechaCreacion = DateTime.Now,
            };

            var enabledAppoinments = Appoiments.Count(x => x.Fecha.ToString("dd/mm/yyyy") == dateTimePicker1.Value.ToString("dd/mm/yyyy")
            && x.Hora == ListaHora.SelectedValue.ToString());

            if (enabledAppoinments > 0)
            {
                MessageBox.Show("El horario no esta disponible");
                return;
            }

            Appoiments.Add(appoinment);
            var hourvalue = Hora.FirstOrDefault(x => x.ToString() == ListaHora.SelectedValue.ToString());
            Hora.Remove(hourvalue);
            ListaHora.DataSource = null;
            ListaHora.DataSource = Hora;
            GAppoinment();
            GrupoCaja.Enabled = false;
            Empty();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClienteTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
