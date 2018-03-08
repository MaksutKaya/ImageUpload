using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageUpload
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            
            if (flSmallPhoto.HasFile)
            {
                if (flSmallPhoto.PostedFile.ContentType == "image/jpeg" || flSmallPhoto.PostedFile.ContentType == "image/png")
                {
                    if (flSmallPhoto.PostedFile.ContentLength < 1024000)
                    {
                        fileName = Path.GetFileName(flSmallPhoto.FileName);

                        flSmallPhoto.PostedFile.SaveAs(Server.MapPath("images/") + fileName.ToString());
                        lblUyari.Text = "";

                        // silme işlemi
                        if (imgSmall.ImageUrl != "images/No_Image_Small.jpg" & imgSmall.ImageUrl != "" && flSmallPhoto.FileName != "")
                        {
                            File.Delete(Server.MapPath(imgSmall.ImageUrl));
                        }

                    }
                    else
                    {
                        lblUyari.Text = "Resim 100 kb'dan büyüktür...";
                    }
                }
                else
                {
                    lblUyari.Text = "Resim .jpeg/.png dosyası olmalıdır";
                }
            }
            
            if (fileName == null)
            {
                imgSmall.ImageUrl = "images/No_Image_Small.jpg";
            }
            else
            {
                imgSmall.ImageUrl = "images/" + fileName.ToString();
            }
        }

        public string fileName { get; set; }

    }
}