using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace MetierPM.Utils
{
    public class Logger
    {
        BdMemoireContext db = new BdMemoireContext();
        /// <summary>
        /// Permet de faire la journalisation au niveau de la base de donnees
        /// </summary>
        /// <param name="TitreErreur">Titre de message</param>
        /// <param name="erreur">Cpntenu de Messae</param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 3000 ? erreur.Substring(0, 1000) : erreur;
                log.TitreErreur = TitreErreur;
                db.td_erreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>

        public static void WriteFileError(string message)
        {
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/erreur.txt");
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(message);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>

        public bool CreateFile(string message)
        {
            bool rep = false;
            string fileName = string.Format("{0}{1}{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/" + fileName + ".txt");
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.Create(path);
                bool fileUse = true;
                while (fileUse)
                {
                    try
                    {
                        System.IO.TextWriter writeFile = new StreamWriter(path, true);
                        writeFile.WriteLine("" + DateTime.Now);
                        writeFile.WriteLine(message);
                        writeFile.WriteLine("-------------------------------------------");
                        writeFile.Flush();
                        writeFile.Close();
                        writeFile = null;
                        fileUse = false;
                    }
                    catch (Exception e)
                    {
                        WriteLogSystem(e.ToString(), "CreateFile");
                    }
                }
                rep = true;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
            return rep;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="theFile"></param>

        public void WriteErrorLoad(List<string> message, string theFile)
        {
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/" + theFile + ".txt");
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                //writeFile.WriteLine("" + DateTime.Now);
                //while (!IsFileReady(path))
                //{
                //    System.Threading.Thread.Sleep(1000);
                //}
                writeFile.WriteLine("---------------------DEBUT----------------------");
                foreach (var item in message)
                {
                    writeFile.WriteLine(item);
                }
                writeFile.WriteLine("----------------------FIN---------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteErrorLoad");
            }
        }



        /// <summary>
        /// permet d'enregistrer les logs dans la base de donnees
        /// </summary>
        /// <param name="erreur"></param>
        /// <param name="libelle"></param>

        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Web Immobilier";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}