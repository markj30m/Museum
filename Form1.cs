using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class Form1 : Form
    {
        
        private Museum museum = new Museum("");
       


        public Form1()
        {
            InitializeComponent();

            
        }

        private void uiShowallbutton_Click(object sender, EventArgs e)
        {
                                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uiSelectcombobox.SelectedIndex = 0;
           

        }

        private void uiSearchbutton_Click(object sender, EventArgs e)
        {
            string donator = uiArtordonsearchtextbox.Text;
            string artefact = uiArtordonsearchtextbox.Text;
         

            uiShowinfotextbox.Text = String.Empty;
            
            
        

            
                          
            
                if (uiSelectcombobox.Text == "All")
                {
                List<Artefacts> showInfo = museum.ShowAll();
                
               
                foreach(Artefacts all in showInfo)
                {
                 uiShowinfotextbox.AppendText(all.GetDonator() + " | " + all.GetArtefact() + " | " + all.GetCatalog() + " | " + all.GetDescrip() + "\r\n\r\n");
                }
                


                }
                else if (uiSelectcombobox.Text == "Donator")
                {
                List<Artefacts> search = museum.FindDonator(donator);


                if (search.Count == 0) return;
                
                    string donatorSearch = searchInfo(search);
                    uiShowinfotextbox.Text = donatorSearch;
                

                }
                else if (uiSelectcombobox.Text == "Artefact")
                {
                List<Artefacts> artSearch = museum.artFind(artefact);
                if (artSearch.Count == 0) return;
                
                string findArt = searchInfo(artSearch);
                uiShowinfotextbox.Text = findArt;
              


            }
        }
        

        private void uiArtefactaddbutton_Click(object sender, EventArgs e)
        {
            uiShowinfotextbox.Text = String.Empty;
            List<Artefacts> refresh = museum.ShowAll(); 
            string donator = uiDonatortextbox.Text;
            string artefact = uiArtefactnametextbox.Text;
            string descrip = uiAdddescrip.Text;

            if (String.IsNullOrWhiteSpace(donator))
            {
                MessageBox.Show("Donator must be added");
            }
            else if(String.IsNullOrWhiteSpace(artefact))
            {
                MessageBox.Show("Artefact must be added");
            }
            else if(String.IsNullOrWhiteSpace(descrip))
            {
                MessageBox.Show("description must be added");
            }
            else
            {
                if (museum.ValTrue(donator, artefact))
                {
                    museum.AddDonator(new Artefacts(donator, artefact, descrip), donator, artefact);

                    MessageBox.Show("Artefact Added");

                }
                else
                {


                    MessageBox.Show("Error Donator already donated this artefact");
                }
            }

            uiDonatortextbox.Text = String.Empty;
            uiArtefactnametextbox.Text = String.Empty;
            uiAdddescrip.Text = String.Empty;

            foreach (Artefacts all in refresh)
            {
                uiShowinfotextbox.AppendText(all.GetDonator() + " | " + all.GetArtefact() + " | " + all.GetCatalog() + " | " + all.GetDescrip() + "\r\n\r\n");
            }
        }



        private void uiArtefactremovebutton_Click(object sender, EventArgs e)
        {
            uiShowinfotextbox.Text = String.Empty;
            List<Artefacts> refresh = museum.ShowAll();
            string donator = uiDonatortextbox.Text;
            string artefact = uiArtefactnametextbox.Text;
            string descrip = uiAdddescrip.Text;

            


            if (museum.ValMessage(donator, artefact))
            {

               

            }
            else
            {
                Artefacts remove = new Artefacts(donator, artefact, descrip);

                museum.RemoveArtefact(donator, artefact, remove);
                MessageBox.Show("Artefact Removed");
            }

            uiDonatortextbox.Text = String.Empty;
            uiArtefactnametextbox.Text = String.Empty;
            uiAdddescrip.Text = String.Empty;

            foreach (Artefacts all in refresh)
            {
                uiShowinfotextbox.AppendText(all.GetDonator() + " | " + all.GetArtefact() + " | " + all.GetCatalog() + " | " + all.GetDescrip() + "\r\n\r\n");
            }

        }

        private string searchInfo(List<Artefacts> donFind)
        {
            string formattedDon = "";
            foreach (Artefacts FindInfo in donFind)
            {
                
                formattedDon += FindInfo.GetDonator() + " | " + FindInfo.GetArtefact() + " | " + FindInfo.GetCatalog() + " | " + FindInfo.GetDescrip()  + Environment.NewLine;
            }
            return formattedDon;
        }

        private void uiDonatortextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiArtefactnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiAdddescrip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
