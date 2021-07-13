using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
  
    class Artefacts
    {
        private string mDonator;
        private string mArtefact;
        private string mCatalog;
        private static int mCatnumber = 0;
        private string mDescription;
       
        public Artefacts(string donator, string artefact, string descrip)
        {
                                               
            mDonator = donator;
            mArtefact = artefact;                     
            mDescription = descrip;

            mCatnumber++;
            mCatalog = mDonator[0].ToString().Substring(0, 1) + mArtefact[0].ToString().Substring(0, 1) + mCatnumber + DateTime.Now.ToString("yyyyMMddHHmmss");

            
        }

        public string GetDonator()
        {
            return mDonator;
        }
        public string GetArtefact()
        {
            return mArtefact;
        }
        public string GetCatalog()
        {
            return mCatalog;
        }   
        public int GetCatnumber()
        {
            return mCatnumber;
        }     
        public string GetDescrip()
        {
            return mDescription;
        } 
        

       


    }
}
