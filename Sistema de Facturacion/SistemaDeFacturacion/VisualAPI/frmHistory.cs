using Controler.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualWebAPI
{
    public partial class frmHistory : Form
    {
        ControlHistorical ch = new ControlHistorical();
        public frmHistory()
        {
            InitializeComponent();
            Llenado();
        }

        public async void Llenado()
        {
            await ch.ObtencionFacturas(dgvDatos);
        }
    }
}
