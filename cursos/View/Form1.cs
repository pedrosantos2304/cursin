using cursos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PTCV = new cursin();
            PTCV.professores = textBox1.Text;
            PTCV.cursos = textBox2.Text;
            PTCV.turma = textBox3.Text;
            PTCV.Criar();
            dataGridView1.DataSource = PTCV.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var PTCV = new cursin();
            dataGridView1.DataSource = PTCV.Listar();
        }
    }
}
