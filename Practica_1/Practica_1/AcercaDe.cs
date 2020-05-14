using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            lblDescripción.Text = "Curso: Lenguajes Formales y de Programación.\n"+
                "Nombre: Elian Saúl Estrada Urbina \t Carné: 201806838";

        }
    }
}
