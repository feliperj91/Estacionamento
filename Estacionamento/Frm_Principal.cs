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

namespace Estacionamento
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_CadastrarVeiculo_Click(object sender, EventArgs e)
        {
            Frm_CadastrarVeiculo f = new Frm_CadastrarVeiculo();
            f.ShowDialog();
        }
    }
}
