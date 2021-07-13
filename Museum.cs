using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Museum
    {

        private List<Artefacts> mArtefactslist = new List<Artefacts>();
        Artefacts donator1 = new Artefacts("Dick Richard", "Victorian", "A lump of wood with some 100-year-old stilton attached.");
        Artefacts donator2 = new Artefacts("Jesse McCree", "Edwardian Clock", "Wooden clock 16 inches in diameter. Hands are stuck at 12:00.");
        Artefacts donator3 = new Artefacts("Joan Blonde", "Old Fossil", "Picture of Gerald Stock in an Art Deco style frame.");
        Artefacts donator4 = new Artefacts("Phil Stevens", "Artful Dodger", "A painting of a gentleman who appears to be holding both a cup of coffee and a mobile phone.");
        Artefacts donator5 = new Artefacts("Emma Weaver", "Traditional Basket", "A basket created on the Introduction to Basket Weaving course at the University of Sarre.");
        private string mDonfind;



        public Museum(string donator)
        {
            mDonfind = donator;

            mArtefactslist.Add(donator1);
            mArtefactslist.Add(donator2);
            mArtefactslist.Add(donator3);
            mArtefactslist.Add(donator4);
            mArtefactslist.Add(donator5);

        }
        public void AddDonator(Artefacts artefactsAdd,string donator, string artefact)
        {
            if(ValTrue(donator,artefact) == true)
            {
                mArtefactslist.Add(artefactsAdd);
                
            }
            else if(ValTrue(donator, artefact) == false)
            {

            }
               
                    
        }

        public void RemoveArtefact(string donator, string artefact, Artefacts artRemove)
        {
            Artefacts tempArt = null;
            foreach (Artefacts remove in mArtefactslist)
            {
                if (remove.GetDonator() == donator && remove.GetArtefact() == artefact)
                {
                    tempArt = remove;
                    break;
                }
            }
            mArtefactslist.Remove(tempArt);

        }



        public List<Artefacts> FindDonator(string donator)
        {

            List<Artefacts> findDon = new List<Artefacts>();

            foreach (Artefacts donFind in mArtefactslist)
            {
                if (donFind.GetDonator() == donator)
                {
                    findDon.Add(donFind);
                }

            }
            return findDon;
        }
        public List<Artefacts> artFind(string artefactFind)
        {

            List<Artefacts> artLook = new List<Artefacts>();

            foreach (Artefacts findArt in mArtefactslist)
            {
                if (findArt.GetArtefact() == artefactFind)
                {
                    artLook.Add(findArt);
                }

            }
            return artLook;
        }
        public List<Artefacts> ShowAll()
        {

            List<Artefacts> showInfo = mArtefactslist;


            return showInfo;

        }

        public Boolean ValMessage(string donator, string artefact)
        {
            bool valBool = true;
            
         
            foreach (Artefacts val in mArtefactslist)
            {
              if (donator == val.GetDonator() && artefact == val.GetArtefact())
            {

                    valBool = true;
                    break;
                   
            }
            else
            {
                    valBool = false;
                    break;
                }       
            }

            return valBool;
        }
        public Boolean ValTrue (string donator, string artefact)
        {
            bool valBool = true;


            foreach (Artefacts val in mArtefactslist)
            {
                if (donator != val.GetDonator() && artefact != val.GetArtefact()|| donator != val.GetDonator() && artefact == val.GetArtefact()|| donator == val.GetDonator() && artefact != val.GetArtefact())
                {
                    if(donator == val.GetDonator() && artefact != val.GetArtefact() || donator != val.GetDonator() && artefact == val.GetArtefact())
                    {
                    valBool = true;
                    break;

                    }
                        
                }
                else
                {
                    valBool = false;
                    break;
                }
            }

            return valBool;
        }
    }
       
 }

