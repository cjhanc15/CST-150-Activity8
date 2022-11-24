using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity8
{
    public partial class calorieConverter : Form
    {
        public calorieConverter()
        {
            InitializeComponent();
        }

        public int FatCalories(int gramsFat)
        {
            return gramsFat * 9;
        }

        public int CarbCalories(int gramsCarbs)
        {
            return gramsCarbs * 4;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int convertedGramsFat;
            int convertedGramsCarbs;

            Boolean validGramsFat = int.TryParse(fatGrams.Text, out convertedGramsFat);
            Boolean validGCarbsFat = int.TryParse(carbGrams.Text, out convertedGramsCarbs);

            if(validGramsFat && validGCarbsFat)
            {
                fatCals.Text = FatCalories(convertedGramsFat).ToString();
                carbCals.Text = CarbCalories(convertedGramsCarbs).ToString();
                totalCals.Text = (FatCalories(convertedGramsFat) + CarbCalories(convertedGramsCarbs)).ToString();
            }
        }
    }
}
