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
using System.Data.SqlClient;
using System.IO;
using DPFP;

namespace Inicio
{
    public partial class Empleado : Form
    {
       CDEmpleado objEmpleado = new CDEmpleado();
        private DPFP.Template Template;
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
      private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";

        public Empleado()
        {
            InitializeComponent();
            comboEmpleadoSexo.Items.Add("Femenino");
            comboEmpleadoSexo.Items.Add("Masculino");



        //    Core = new FingerprintCore();
        //    templateHuella = new FingerprintTemplate();
        //    Core.onStatus += new StatusEventHandler(core_onStatus);
        //    Core.onImage += new ImageEventHandler(core_onImage);
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                //btnAgregar.Enabled = (Template != null);

                if (Template != null)
                {
                    //Console.WriteLine("Huella: " + Templ);
                    //MessageBox.Show("La huella está lista para ser verificada");
                    //Registra_Huella();
                    //txtHuella.Text = "Huella capturada correctamente";

                }
                else
                {
                    MessageBox.Show("Huella no válida, inténtelo de nuevo");
                }
            }));
        }
        

        //FingerprintRawImage imagenHuella;
        //FingerprintCore Core;
        //FingerprintTemplate templateHuella;

        //private void core_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        //{
        //    if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
        //    {
        //        Core.StartCapture(source);
        //    }
        //    else
        //    {
        //        Core.StopCapture(source);
        //    }
        //}

        //private void core_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        //{

        //    try
        //    {
        //        imagenHuella = ie.RawImage;
        //        Huella(ie.RawImage.Image);
        //        Extract();
        //    }
        //    catch (System.Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //}

        //private void Extract()
        //{
        //    if (imagenHuella != null)
        //    {
        //        try
        //        {

        //            Core.Extract(imagenHuella, ref templateHuella);

        //            SetQualityBar(templateHuella.Quality);

        //            DisplayImage(templateHuella, false);

        //        }
        //        catch
        //        {
        //            SetQualityBar(-1);
        //        }
        //    }
        //}

        //private void DisplayImage(FingerprintTemplate template, bool identify)
        //{
        //    IntPtr hdc = FingerprintCore.GetDC();
        //    IntPtr image = new IntPtr();

        //    if (identify)
        //    {
        //        Core.GetBiometricDisplay(template, imagenHuella, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
        //    }
        //    else
        //    {
        //        Core.GetBiometricDisplay(template, imagenHuella, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
        //    }
        //    Huella(Bitmap.FromHbitmap(image));

        //    FingerprintCore.ReleaseDC(hdc);
        //}


        //delegate void delsetQuality(int quality);
        //private void SetQualityBar(int quality)
        //{
        //    if (progressBar1.InvokeRequired == true)
        //    {
        //        this.Invoke(new delsetQuality(SetQualityBar), new object[] { quality });
        //    }
        //    else
        //    {
        //        switch (quality)
        //        {
        //            case 0:
        //                {
        //                    progressBar1.Value = progressBar1.Maximum / 3;
        //                   // progressBar1.ForeColor = Color.Red;
        //                }
        //                break;

        //            case 1:
        //                {

        //                    progressBar1.Value = (progressBar1.Maximum / 3) * 2;
        //                   // progressBar1.ForeColor = Color.GreenYellow;
        //                }
        //                break;

        //            case 2:
        //                {
        //                    progressBar1.Value = progressBar1.Maximum;
        //                  //  progressBar1.ForeColor = Color.Green;
        //                }
        //                break;

        //            default:
        //                {
        //                    progressBar1.Value = 0;
        //                    progressBar1.BackColor = Color.Gray;
        //                }
        //                break;
        //        }
        //    }
        //}


        //private delegate void delSetImage(Image img);
        //void Huella(Image img)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new delSetImage(Huella), new object[] { img });
        //    }
        //    else
        //    {
        //        Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
        //        pictureBox1.Image = bmp;
        //    }
        //} 


        private void Empleado_Load(object sender, EventArgs e)
        {


            //try
            //{
            //    Core.Initialize();
            //    Core.CaptureInitialize();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}

            
            MostrarEmpleado();
        }


        private void textEmpleadoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e); }

        private void textEmpleadoApellidosP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textEmpleadoApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textEmpleadoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void ListarCargo()
        {
            CDEmpleado objEmpleado1 = new CDEmpleado();
            comboCargo.DataSource = objEmpleado1.ListarCargo();
            comboCargo.DisplayMember = "Nombre";
            comboCargo.ValueMember = "Clave";
        }

        private void buttonEmpleadoGuardar_Click(object sender, EventArgs e)
        {
            if (textEmpleadoTelefono.Text=="" || comboEmpleadoSexo.Text=="" || comboCargo.Text=="" || textEmpleadoNPersonal.Text=="" || textEmpleadoNombre.Text=="" || textEmpleadoApellidosP.Text=="" || textEmpleadoApellidoM.Text=="" )
            {
                MessageBox.Show("Llenar los campos obligatorios");

            }
            else
            {
                try
                {
                    objEmpleado.insertarEmpleado(
                        textEmpleadoNPersonal.Text,
                        textEmpleadoNombre.Text,
                        textEmpleadoApellidosP.Text,
                        textEmpleadoApellidoM.Text,
                        textEmpleadoTelefono.Text,
                        comboEmpleadoSexo.Text,
                        textEmpleadoDireccion.Text,
                        comboCargo.SelectedValue.ToString(),
                        textEmpleadoEmail.Text,
                        textEmpleadoHuella.Text
                        );

                    MessageBox.Show("Insertado Correctamente");
                    MostrarEmpleado();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se puede repetir la misma Clave ");
                }
                textEmpleadoNombre.Clear();
                textEmpleadoApellidosP.Clear();
                textEmpleadoApellidoM.Clear();
                textEmpleadoDireccion.Clear();
                textEmpleadoEmail.Clear();
                textEmpleadoNPersonal.Clear();
                textEmpleadoTelefono.Clear();
                comboCargo.Text = string.Empty;
                comboEmpleadoSexo.Text = string.Empty;
                }

        }

        private void MostrarEmpleado()
        {
            CDEmpleado objEmpleado2 = new CDEmpleado();
            dataGridEmpleado.DataSource = objEmpleado2.MostrarEmpleado();
        }

        private void textEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textEmpleadoBuscar.Text;
            dataGridEmpleado.DataSource = bindingSource1;            
            GetData("select * from Empleado where NPersonal like '" + filtrado + "%' or Nombre like '" +
                  filtrado +   "%' or ApellidoP like '" +filtrado +  "%' or ApellidoM like '" + filtrado +  "%';");

        }
        private void GetData(string sql)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // dataGridCEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción: " + ex);
            }

        }

        private void comboEmpleadoSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   e.Handled = true;
        }

        

        private void buttonEmpleadoCancelar_Click(object sender, EventArgs e)
        {
            textEmpleadoNombre.Clear();
            textEmpleadoApellidosP.Clear();
            textEmpleadoApellidoM.Clear();
            textEmpleadoDireccion.Clear();
            textEmpleadoEmail.Clear();
            textEmpleadoNPersonal.Clear();
            textEmpleadoTelefono.Clear();
            comboCargo.Text = string.Empty;
            comboEmpleadoSexo.Text = string.Empty;
            
       
        }

        private void comboCargo_MouseCaptureChanged(object sender, EventArgs e)
        {
            ListarCargo();
        }

        private void buttonEmpleadoHuella_Click(object sender, EventArgs e)
        {
            CapturarHuella capturaH = new CapturarHuella();
            capturaH.OnTemplate += this.OnTemplate;
            capturaH.TopMost = true;
            capturaH.ShowDialog();
        }
    }
}
