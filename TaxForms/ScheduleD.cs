// Auth: Christian B
// Date: 4/4/24

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Application.Forms
{
    public partial class ScheduleD : UserControl
    {
        public ScheduleD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool parsed;

            //For short proceeds
            float shortP;
            parsed = float.TryParse(shortProceeds.Text, out shortP);
            if (!parsed)
            {
                //Handle parse failure
                shortP = 0; 
            }

            //For short cost
            float shortC;
            parsed = float.TryParse(shortCost.Text, out shortC);
            if (!parsed)
            {
                shortC = 0; 
            }

            //Calculating short gain/loss
            float shortGL = shortP + shortC;

            //For long proceeds
            float longP;
            parsed = float.TryParse(longProceeds.Text, out longP);
            if (!parsed)
            {
                longP = 0; 
            }

            //For long cost
            float longC;
            parsed = float.TryParse(lonCost.Text, out longC); 
            if (!parsed)
            {
                longC = 0; 
            }

            //Calculating long gain/loss
            float longGL = longP + longC;

            float totalGL = longGL + shortGL;

            //Adjusting
            longGainOrLoss.Text = longGL.ToString();
            shortGainOrLoss.Text = shortGL.ToString();
            summary.Text = totalGL.ToString();

        }
    }
}
