using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public class PictureBoxManager
    {

        private Dictionary<int, PictureBox[]> pictureBoxes;

        public PictureBoxManager(PictureBox pb_lays, PictureBox pb_doritos, PictureBox pb_pringles, PictureBox pb_pepsi,
                                 PictureBox pb_coca, PictureBox pb_water, PictureBox pb_kinder, PictureBox pb_kat,
                                 PictureBox pb_oreo)
        {
                pictureBoxes = new Dictionary<int, PictureBox[]>
                {
                    { 1, new PictureBox[] { pb_lays } },
                    { 2, new PictureBox[] { pb_doritos } },
                    { 3, new PictureBox[] { pb_pringles } },
                    { 4, new PictureBox[] { pb_pepsi } },
                    { 5, new PictureBox[] { pb_coca } },
                    { 6, new PictureBox[] { pb_water } },
                    { 7, new PictureBox[] { pb_kinder } },
                    { 8, new PictureBox[] { pb_kat } },
                    { 9, new PictureBox[] { pb_oreo } }
                };
        }


      

        public Dictionary<int, PictureBox[]> PictureBoxes
        {
            get { return pictureBoxes; }
        }



    }
}
