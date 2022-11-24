using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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

        //convert grams of fat to calories
        public int FatCalories(int gramsFat)
        {
            return gramsFat * 9;
        }

        //convert grams of carbs to calories
        public int CarbCalories(int gramsCarbs)
        {
            return gramsCarbs * 4;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int convertedGramsFat;
            int convertedGramsCarbs;

            Boolean validGramsFat = int.TryParse(fatGrams.Text, out convertedGramsFat) && convertedGramsFat > -1;
            Boolean validGramsCarbs = int.TryParse(carbGrams.Text, out convertedGramsCarbs) && convertedGramsCarbs > -1;

            //if gramsFat and gramsCarbs are above -1 and an integer, calculate results
            if(validGramsFat && validGramsCarbs)
            {
                gramsFatError.Text = "";
                gramsCarbsError.Text = "";
   
                fatCals.Text = FatCalories(convertedGramsFat).ToString();
                carbCals.Text = CarbCalories(convertedGramsCarbs).ToString();
                totalCals.Text = (FatCalories(convertedGramsFat) + CarbCalories(convertedGramsCarbs)).ToString();
            }

            //if gramsFat is not valid, display error, set all cals to blank
            if (!validGramsFat)
            {
                gramsFatError.Text = "ERROR: Please enter valid number of fat";
                fatCals.Text = "";
                carbCals.Text = "";
                totalCals.Text = "";
            }
            //if gramsFat is valid, ensure error is blank
            else if (validGramsFat) gramsFatError.Text = "";
            //if gramsCarbs is not valid, display error, set all cals to blank
            if (!validGramsCarbs)
            {
                gramsCarbsError.Text = "ERROR: Please enter valid number of carbs";
                fatCals.Text = "";
                carbCals.Text = "";
                totalCals.Text = "";
            }
            //if gramsCarbs is valid, set error to blank
            else if (validGramsCarbs) gramsCarbsError.Text = "";
        }
    }
}
