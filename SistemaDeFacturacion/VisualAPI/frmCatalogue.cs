using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualWebAPI
{
    public partial class frmCatalogue : Form
    {
        public const string PathImageLogo = @"C:\Users\Usuario\GitHub Repositorios\SistemaFacturacionWebAPI\SistemaDeFacturacion\VisualAPI\Resources\Gatito.png";
        public const string PathImageDespedida = @"C:\Users\Usuario\GitHub Repositorios\SistemaFacturacionWebAPI\SistemaDeFacturacion\VisualAPI\Resources\GatitoDespedida.png";

        public frmCatalogue()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Image logo = Image.FromFile(PathImageLogo);
            Image despedida = Image.FromFile(PathImageDespedida);
            Font FuenteNormal = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            Font FuenteNegritas = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font FuenteCursiva = new Font("Arial", 12, FontStyle.Italic, GraphicsUnit.Point);
            int y = 20;
            e.Graphics.DrawImage(logo, new Rectangle(0, y += 30, 30, 30));
            e.Graphics.DrawString("Un ticket feliz", FuenteNormal, Brushes.Black, new RectangleF(0,y+=10,120,20));
            e.Graphics.DrawImage(despedida, new Rectangle(0, y += 30, 30, 30));

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirFactura = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ImprimirFactura.PrinterSettings = ps;
            ImprimirFactura.PrintPage += Imprimir;
            ImprimirFactura.Print();
        }
    }
}
