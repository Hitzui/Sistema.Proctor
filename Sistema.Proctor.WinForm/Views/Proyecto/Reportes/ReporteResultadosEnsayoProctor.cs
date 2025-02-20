﻿using System.Data;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Sistema.Proctor.WinForm.Data;
using DataTable = DevExpress.DataAccess.Native.Data.DataTable;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Reportes
{
    public partial class ReporteResultadosEnsayoProctor : XtraReport
    {
        public ReporteResultadosEnsayoProctor()
        {
            InitializeComponent();
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var conn = DependenciasGlobalesForm.Instance.GetConnectionString("DefaultConnectionReport");
            e.ConnectionParameters=new CustomStringConnectionParameters(conn);
        }
    }
}
