using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformesSubinforme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestroDetalle.CochesVendidos' Puede moverla o quitarla según sea necesario.
            this.cochesVendidosTableAdapter.Fill(this.dataSetMaestroDetalle.CochesVendidos);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            //Guardamos el id del comercial
            var idComercial = int.Parse(e.Parameters["idComercial"].Values.First());
            
            //Creamos un dataset y lo rellenamos con la consulta
            DataSetMaestroDetalle.CochesVendidosDataTable coches = new DataSetMaestroDetalle.CochesVendidosDataTable();
            this.cochesVendidosTableAdapter.FillBy(coches, idComercial.ToString());
            //Enlazamos con el DataSet del conjunto de datos del subinforme
            e.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)coches));
        }
    }
}
