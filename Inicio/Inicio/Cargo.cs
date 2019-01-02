using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Inicio
{
    public partial class Cargo : Form
    {
        CDCargo objCargo = new CDCargo();
        

        public Cargo()
        {
            InitializeComponent();
            comboCargoDepartamento.Items.Add("Academico");
            //comboCargoDepartamento.Items.Add("Administrativo");

        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            MostrarCargo();
        }

        private void textCargoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void buttonCargoGuardar_Click(object sender, EventArgs e)
        {
            objCargo.insertarCargo(
                textCargoClave.Text,
                textCargoNombre.Text,
                textCargoDescripcion.Text,
                comboCargoDepartamento.Text);
            MessageBox.Show("Insertado Correctamente");
            MostrarCargo();
        }

        private void MostrarCargo()
        {
            CDCargo objCar = new CDCargo();
            dataGridViewCargo.DataSource = objCar.MostrarCargo();
        }

        private void panelCargoVertical2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCargoBuscar_Click(object sender, EventArgs e)
        {
            //dataGridViewCargo.DataSource= bd.
        }

        private void textCargoBuscar_TextChanged(object sender, EventArgs e)
        {
           // CDCargo objCargo3 = new CDCargo();
            //if (textCargoBuscar.Text!="" )
            //{
            //    dataGridViewCargo.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridViewCargo.Rows)
            //    {
            //        r.Visible = false;
            //    }
            //    foreach (DataGridViewRow r in dataGridViewCargo.Rows)
            //    {
            //        foreach(DataGridViewCell ce in r.Cells)
            //        {
            //            if(( ce.Value.ToString().ToUpper()).IndexOf (textCargoBuscar.Text.ToUpper()) ==0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
                
            //}
            //else
            //{
            //    CDCargo objCargo3 = new CDCargo();
            //    dataGridViewCargo.DataSource = objCargo3.MostrarCargo();
            //}
           
        }

        private void dataGridViewCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
