using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpendingBooks;

namespace Machine
{
    public class ImageHelper
    { 
        public static void RemoveImagesForEmptyProducts(Dictionary<int, Stack<Product>> expendingMachine, Dictionary<int, PictureBox[]> pictureBoxes, int key)
        {
            if (expendingMachine.TryGetValue(key, out Stack<Product> resorte))
            {
                PictureBox[] pbProduct = pictureBoxes[key];
                for (int i = 0; i < pbProduct.Length; i++)
                {
                    if (resorte.Count == 0)
                    {
                        pbProduct[i].Image = null;
                    }
                }
            }
        }

    }

}
