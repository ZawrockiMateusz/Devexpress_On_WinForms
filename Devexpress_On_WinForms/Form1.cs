using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devexpress_On_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'gridViewOnWinFormsDataSet2.zamowienia' . Możesz go przenieść lub usunąć.
            this.zamowieniaTableAdapter.Fill(this.gridViewOnWinFormsDataSet2.zamowienia);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
