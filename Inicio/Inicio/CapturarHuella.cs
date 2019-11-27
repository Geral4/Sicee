using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class CapturarHuella : CaptureForm
    {
        public delegate void OnTemplateEventHandler(DPFP.Template Template);
        public event OnTemplateEventHandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;


        protected override void Init()
        {
            base.Init();
            base.Text = "Capturar huella";
            
            
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
        }

        protected override void Process (DPFP.Sample sample)
        {
            base.Process(sample);

            DPFP.FeatureSet features = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Enrollment);

            if (features != null) try
                {
                    MakeReport("Se crearon el conjunto de características de huellas digitales.");
                    Enroller.AddFeatures(features);
                }
                finally
                {
                    UpdateStatus();

                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            OnTemplate(Enroller.Template);
                            SetPrompt("Proceso terminado, cierre la ventana activa para continuar.");                            
                            Stop();
                            break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;                            
                    }
                }
        }


        private void UpdateStatus()
        {
            SetStatus(String.Format("Capturas necesarias restantes: {0}", Enroller.FeaturesNeeded));
        }


        public CapturarHuella()
        {
            InitializeComponent();
        }

        private void CapturarHuella_Load(object sender, EventArgs e)
        {

        }
    }
}
