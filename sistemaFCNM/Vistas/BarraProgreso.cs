using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Vistas
{
    public partial class BarraProgreso : Form
    {
        public BarraProgreso()
        {
            InitializeComponent();
        }
        private Task ProcessData(List<String> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(i.ToString());
            }
            lblStatus.Text = "Working..";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = String.Format("Processing..{0}%", report.PercentComplete);
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
            };
            await ProcessData(list, progress);
            lblStatus.Text = "Done !";
        }
    }
}
