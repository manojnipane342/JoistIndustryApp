using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace PickAny.Helpers
{
    public class Common
    {
        public string SaveBase64AsImage(string base64, string imageFolderPath)
        {
            try
            {
                if (base64.IndexOf(".png") == -1)
                {
                    if (!System.IO.Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + imageFolderPath)))
                    {
                        System.IO.Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + imageFolderPath));
                    }
                    var bytes = Convert.FromBase64String(base64);
                    var filename = string.Format("{0:yyyy-MM-dd-H-mm-dd}_{1}.png", DateTime.Now, DateTime.Now.Millisecond);
                    File.WriteAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + imageFolderPath, filename), bytes);
                    return imageFolderPath + "/" + filename;
                }
                else
                {
                    return base64;
                }
            }
            catch (Exception ex)
            {
                return base64;
            }
        }

        public string SaveFileIfPresent(HttpPostedFileBase httpPostedFileBase, string resumeFolder)
        {
            string ret = null;

            try
            {
                if (httpPostedFileBase != null && httpPostedFileBase.InputStream != null)
                {
                    string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resumeFolder.TrimStart(new[] { '/' }));
                    string fileName = DateTime.Now.Ticks.ToString() + Path.GetExtension(httpPostedFileBase.FileName);
                    string webpath = Path.Combine(resumeFolder, fileName).Replace("\\", "/");
                    Directory.CreateDirectory(folder);
                    httpPostedFileBase.SaveAs(Path.Combine(folder, fileName));
                    ret = webpath;
                }
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message.ToString());
            }
            return ret;
        }
    }
}