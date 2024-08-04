using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace ServiceReport.CLSReport
{
    public class CLsListExpert
    {
        ServiceMetier.Service1Client metier = new ServiceMetier.Service1Client();

        public DataTable GetTableListExpert()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PrenomExpert", typeof(string));
            table.Columns.Add("NomExpert", typeof(string));
            table.Columns.Add("SpecialisteExpeert", typeof(float));

            var liste = metier.getAllExpert();


            foreach (var i in liste)
            {
                table.Rows.Add(i.Prenom, "", i.Nom, i.Specialiste, "");
            }

            return table;
        }

        public byte[] FileListeExpert()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                rpt.Load("~/Report/rptListeProduit.rpt");
                rpt.SetDataSource(GetTableListExpert());
                Stream stream =
                rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                var taille = stream.Length - 1;
                byte[] buffer = new byte[taille];
                using (MemoryStream ms = new MemoryStream())
                {
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                    return ms.ToArray();
                }
            }
            finally
            {
                rpt.Dispose();
                rpt.Close();
            }
        }
    }
}