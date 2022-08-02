using ExamenQuarkCSharp.Models;
using ExamenQuarkCSharp.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuarkCSharp.View
{
    public partial class Historial : Form
    {
        string _historial;
        public Historial(string historial)
        {
            InitializeComponent();
            _historial = historial;
        }
        private void Historial_Load(object sender, EventArgs e)
        {
            TextBoxList.Text = _historial;
        }
       
    }
}
