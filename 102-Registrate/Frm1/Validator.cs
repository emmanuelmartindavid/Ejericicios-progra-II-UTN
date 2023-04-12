using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm1
{
    internal class Validator
    {


        public static bool ValidateEntrantData(string name, string address, string gender, string country, string[] courses, int age)
        {
            /*            return (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(address)
                    && string.IsNullOrEmpty(gender) && string.IsNullOrEmpty(country)
                    && courses != null && courses.Length != 0 && age > 18);*/
            return (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address)
                || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(country)
                || courses == null || courses.Length == 0 || age <= 18);

        }

        public static string[] GetSelectedCourses(GroupBox coursesGroupBox)
        {
            List<string> selectedCourses = new();

            foreach (CheckBox checkBox in coursesGroupBox.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    selectedCourses.Add(checkBox.Text);
                }
            }

            return selectedCourses.ToArray();
        }
    }
}
