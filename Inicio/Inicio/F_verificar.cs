using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;

namespace Inicio
{
    public partial class F_verificar : CaptureForm 
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificador;
        private SqlDataReader myReader = null;
        private OleDbDataReader lector = null;
        private consultasSQL con = new consultasSQL();
        private string cadena = "", caja="", sucursal="",  empleado = "", cve_empleado = "";

        public void Verify(DPFP.Template template)
        {
            Template = template;
            
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            base.TopMost = false;            
            SetStatus("", false);
            Verificador = new DPFP.Verification.Verification();
            UpdateStatus(70);
        }

        private void clave_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            con.cerrar();
            this.Close();
        }

        protected override void Process(Sample Sample)
        {
            try
            {

                base.Process(Sample);

                DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                if (features != null)
                {
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    DPFP.Template template = new DPFP.Template();
                    Stream stream;


                    cadena = "select NPersonal, concat(Nombre, ' ', ApellidoP, ' ', ApellidoM) as nombre from Empleado " +
                    "where Cargo_id = '02C'";

                    myReader = con.Consultar(cadena);

                    while (myReader.Read())
                    {

                        cve_empleado = myReader.GetValue(0).ToString();
                        empleado = myReader.GetValue(1).ToString();
                        //byte[] huella = Convert.FromBase64String(myReader.GetValue(2).ToString());
                        myReader.Close();
                        cadena = "select Huellas " +
                            "from Empleado where NPersonal = '" + empleado + "'";

                        //string algo = myReader.GetValue(1).ToString();                    

                        stream = new MemoryStream(con.Obtener_huella(cadena));
                        template = new DPFP.Template(stream);
                        //template.DeSerialize(huella);




                        Verificador.Verify(features, template, ref result);

                        UpdateStatus(result.FARAchieved);


                        if (result.Verified)
                        {
                            MakeReport("Capturado: " + empleado.ToUpper());
                            cadena = "exec sp_captura_asistencia '" + cve_empleado + "', " + sucursal + "";
                            MessageBox.Show("Bienvenido: " + empleado.ToUpper());
                            //myReader = con.Consultar(cadena);

                            //if (myReader.Read())
                            //{

                            //}

                            //myReader.Close();
                            //con.InsertActElim(cadena);
                            //MessageBox.Show("Bienvenido (a) " + empleado.ToUpper(), "Asistencia");                        
                        }
                    }
                    myReader.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se le ha asignado la huella a este docente", "Asistencia");
                Console.WriteLine("Excepción producida: " + ex);
            }
        }


        public F_verificar()
        {

            InitializeComponent();
        }

        private void F_verificar_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectarRemoto("Sicee", "geralmiguel", "tecnologico01", "192.168.0.15") == 0)
                {
                    MessageBox.Show("Sin conexión al servidor de base de datos, reintente más tarde", "Asistencia");
                    Application.Exit();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Excepción producidaaaaa: " + ex.Message, "ERROR");
            }


        }


        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
