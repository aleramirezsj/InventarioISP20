using Desktop.Services;
using Microsoft.Reporting.WinForms;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.ViewReports
{
    public partial class ClientesAgrupadoPorLocalidadViewReport : Form
    {
        ReportViewer _report;
        ClientesApiService clientesService = new ClientesApiService();
        List<Cliente>? listadoClientes ;
        public ClientesAgrupadoPorLocalidadViewReport()//sin recepción de parametros
        {
            InitializeComponent();
            _report = new ReportViewer();
            _report.Dock = DockStyle.Fill;
            this.Controls.Add(_report);
        }

        public ClientesAgrupadoPorLocalidadViewReport(List<Cliente>? clientes)//con recepción de parametros
        {
            InitializeComponent();
            _report = new ReportViewer();
            _report.Dock = DockStyle.Fill;
            this.Controls.Add(_report);
            listadoClientes = clientes;
        }

        private async void ClientesViewReport_Load(object sender, EventArgs e)
        {
            _report.LocalReport.ReportEmbeddedResource = "Desktop.Reports.Clientesxlocalidad.rdlc";

            var clientes = listadoClientes ?? await clientesService.GetAllAsync();

            //construimos la lista de clientes para el reporte sumandole el campo localidad
            var listaClientes = clientes?.Select(c => new
            {
                c.Id,
                c.Firstname,
                c.Lastname,
                c.Dni,
                c.Address,
                Localidad = c.Localidad?.Name
            }).OrderBy(c => c.Localidad)
                .ThenBy(c => c.Lastname)
                .ThenBy(c => c.Firstname).ToList();

            _report.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", listaClientes));
            _report.SetDisplayMode(DisplayMode.PrintLayout);
            _report.ZoomMode = ZoomMode.Percent;
            _report.ZoomPercent = 100;

            _report.RefreshReport();
        }
    }
}
