using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FilePartageMemoire
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool UploadToTempFolder(byte[] pFileBytes, string pFileName, string pathFolder)
        {
            bool isSuccess = false;
            FileStream fileStream = null;

            try
            {
                if (!Directory.Exists(pathFolder))
                {
                    Directory.CreateDirectory(pathFolder);
                }
                if (!string.IsNullOrEmpty(pathFolder))
                {
                    if (!string.IsNullOrEmpty(pFileName))
                    {
                        string strFileFullPath = pathFolder + "//" + pFileName;
                        fileStream = new FileStream(strFileFullPath, FileMode.OpenOrCreate);
                        // write file stream into the specified file  
                        using (System.IO.FileStream fs = fileStream)
                        {
                            fs.Write(pFileBytes, 0, pFileBytes.Length);
                            isSuccess = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                //throw ex;
                WriteLogSystem(ex.ToString(), "UploadToTempFolder");

            }

            return isSuccess;
        }
        public byte[] FichierVersTableauDeByte(string CheminFichier)
        {
            FileInfo MonFichier = new FileInfo(CheminFichier);
            try
            {
                if (MonFichier.Length > 0)
                {
                    FileStream MonFileStream = MonFichier.OpenRead();
                    byte[] TableauDeBytes = new byte[(int)MonFileStream.Length];
                    // On charge le fichier dans un tableau de byte
                    MonFileStream.Read(TableauDeBytes, 0, (int)MonFileStream.Length);
                    // On ferme le stream
                    MonFileStream.Close();
                    return TableauDeBytes;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        ///This method will give you the file content as a byte.  

        public byte[] GetFileFromFolder(string filename)
        {
            byte[] filedetails = new byte[0];
            string strTempFolderPath = System.Configuration.ConfigurationManager.AppSettings.Get("FileUploadPath");
            if (File.Exists(strTempFolderPath + filename))
            {
                return File.ReadAllBytes(strTempFolderPath + filename);
            }
            else return filedetails;
        }

        public bool fileExistOnFolder(string path, string idDossier)
        {
            bool rep = false;
            DirectoryInfo d = new DirectoryInfo(@"E:\ImpressionDocumentOrbus\ZONEDECHANGE");
            FileInfo[] Files = d.GetFiles("*.zip");
            foreach (FileInfo file in Files)
            {
                if (file.Name.StartsWith(idDossier.ToString()))
                {
                    rep = true;
                }
            }
            return rep;
        }

        //public RemoteFileInfo DownloadFile(DownloadRequest request)
        //{
        //    RemoteFileInfo result = new RemoteFileInfo();
        //    try
        //    {
        //        string filePath = System.IO.Path.Combine(@"c:\Uploadfiles", request.FileName);
        //        System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

        //        // check if exists
        //        if (!fileInfo.Exists)
        //            throw new System.IO.FileNotFoundException("File not found",
        //                                                      request.FileName);

        //        // open stream
        //        System.IO.FileStream stream = new System.IO.FileStream(filePath,
        //                  System.IO.FileMode.Open, System.IO.FileAccess.Read);

        //        // return result 
        //        result.FileName = request.FileName;
        //        result.Length = fileInfo.Length;
        //        result.FileByteStream = stream;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return result;
        //}

        //public void UploadFile(RemoteFileInfo request)
        //{
        //    FileStream targetStream = null;
        //    Stream sourceStream = request.FileByteStream;

        //    string uploadFolder = @"C:\upload\";

        //    string filePath = Path.Combine(uploadFolder, request.FileName);

        //    using (targetStream = new FileStream(filePath, FileMode.Create,
        //                          FileAccess.Write, FileShare.None))
        //    {
        //        //read from the input stream in 65000 byte chunks

        //        const int bufferLen = 65000;
        //        byte[] buffer = new byte[bufferLen];
        //        int count = 0;
        //        while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
        //        {
        //            // save to output stream
        //            targetStream.Write(buffer, 0, count);
        //        }
        //        targetStream.Close();
        //        sourceStream.Close();
        //    }

        //}


        public bool TableauDeByteVersFicher(string CheminRep, string CheminFichier, byte[] TableauDeByte)
        {
            //'Using System.ServiceModel.ServiceSecurityContext.Current.WindowsIdentity.Impersonate()
            //'End Using

            bool resultOK = false;

            try
            {
                if (!Directory.Exists(CheminRep))
                {
                    Directory.CreateDirectory(CheminRep);
                }
                string filePath = CheminRep + CheminFichier;
                //if (File.Exists(CheminFichier))
                if (File.Exists(filePath))
                {



                    //string fileNameOnly = Path.GetFileNameWithoutExtension(CheminFichier);
                    //string extension = Path.GetExtension(CheminFichier);
                    //WriteErrorLog(string.Format("Nom du Fichier à remplacer {0}{1}", fileNameOnly, extension));
                    //string path = Path.GetDirectoryName(CheminFichier);
                    //string newFullPath = CheminFichier;
                    //string dateNom = string.Format("{0}{1}{2}{3}{4}",DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);
                    //string tempFileName = string.Format("{0}({1})", fileNameOnly, dateNom);
                    //newFullPath = Path.Combine(path, tempFileName + extension);
                    //var destFileName = Path.Combine(filePath, String.Format("{0}_{1}_{2}{3}{4}{5}", filePath, "Old", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute));           
                    //File.Delete(filePath);
                    //File.Move(filePath, string.Format("{0}_{1}_{2}{3}{4}{5}", filePath, "Old", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute));
                    /*string fileNameOnly = Path.GetFileNameWithoutExtension(filePath);
                    string extension = Path.GetExtension(filePath);
                    string dateNom = string.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                    string newFileName = string.Format("{0}_{1}{2}", fileNameOnly, dateNom, extension);
                    File.Move(filePath, string.Format("{0}{1}", CheminRep, newFileName));*/
                }

                using (System.IO.FileStream MonFileStream = new System.IO.FileStream(CheminRep + "\\" + CheminFichier, System.IO.FileMode.Create))
                {
                    MonFileStream.Write(TableauDeByte, 0, TableauDeByte.Length - 1);
                    resultOK = true;
                };

            }
            catch (Exception ex)
            {
                //NetworkCredential cr = (NetworkCredential) CredentialCache.DefaultCredentials;
                //Console.WriteLine("\n\nUser Credentials:- Domain : {0} , UserName : {1} ", cr.Domain, cr.UserName);
                //WriteErrorLog(string.Format("\n\nUser Credentials:- Domain : {0} , UserName : {1} ", cr.Domain, cr.UserName));
                //string fileName = Path.GetFileNameWithoutExtension(CheminFichier);
                //string ext = Path.GetExtension(CheminFichier);
                //WriteErrorLog(string.Format("Erreur : {0} sur le traitement du document : {1}{2}", ex.Message, fileName, ext));
                WriteLogSystem(ex.ToString(), "TableauDeByteVersFicher");
            }

            return resultOK;

        }

        public static void WriteLogSystem(string erreur, string fonction)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "ServiceFile";
                eventLog.WriteEntry(string.Format("date: {0}, fonction: {1}, description {2}", DateTime.Now, fonction, erreur), EventLogEntryType.Information, 101, 1);
            }
        }

        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        /// <summary>  
        /// 
        /// </summary>  
        /// <param name="Message"></param>  
        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
    }
}
