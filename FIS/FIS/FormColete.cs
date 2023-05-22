using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIS
{
    public partial class FormColete : Form
    {
        private Colet _colet;
        public FormColete(Colet colet)
        {
            InitializeComponent();
            _colet = colet;
        }

        private void FormColete_Load(object sender, EventArgs e)
        {
            label1.Text = _colet.AfiseazaInformatiiColet();

        }
    }
}
