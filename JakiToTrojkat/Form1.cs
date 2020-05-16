using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakiToTrojkat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void OnWrongSidesKomunikat(WhichTriangle tr)
        {
            MessageBox.Show("Podano złe wartości długości boków,\n kliknij OK, a następnie popraw", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearTxtSide();
        }
        private void ClearTxtSide()
        {
            txtSide0.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
        }
        private void btnCheckTriangle_Click(object sender, EventArgs e)
        {
            lblAnglesKind.Text = "";
            lblSidesKind.Text = "";
            double[] sides = new double[] { double.Parse(txtSide0.Text), double.Parse(txtSide1.Text), double.Parse(txtSide2.Text) };
            WhichTriangle triangle = new WhichTriangle();
            triangle.OnWrongSides += OnWrongSidesKomunikat;
            triangle.sides = sides;
            switch (triangle.WhichTriangleAngle())
            {
                case AngleTriangle.ACUTE_A: 
                    lblAnglesKind.Text = "To jest trójkąt ostrokątny";
                    break;
                case AngleTriangle.OBTUSE_A:
                    lblAnglesKind.Text = "To jest trójkąt rozwartokątny";
                    break;
                case AngleTriangle.RIGHT_A:
                    lblAnglesKind.Text = "To jest trójkąt prostokątny";
                    break;
            }
            switch (triangle.WhichTriangleSide())
            {
                case SideTriangle.EQUILATERAL:
                    lblSidesKind.Text = "To jest trójkąt równoboczny";
                    break;
                case SideTriangle.ISOSCELES:
                    lblSidesKind.Text = "To jest trójkąt równoramienny";
                    break;
                case SideTriangle.MULTILATERAL:
                    lblSidesKind.Text = "To jest trójkąt różnoboczny";
                    break;
            }
        }
    }
}
