// Auth: John O'Neal and Christian Baack
// Date: 04/05/2024
// Desc: This form will allow the user to enter W2 information and save it to the database.

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TaxApp_v2.TaxForms
{
    public partial class W2UserControl : UserControl
    {
        public W2UserControl()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                float wtp, federalWH, ssw, ssWH, medWT, medWH, ssT, at, dpb;

                if (!float.TryParse(WagesTipsOtherCompensationTextBox.Text, out wtp) ||
                    !float.TryParse(FederalIncomeTaxWithheldTextBox.Text, out federalWH) ||
                    !float.TryParse(SocialSecurityWagesTextBox.Text, out ssw) ||
                    !float.TryParse(SocialSecurityTaxWithheldTextBox.Text, out ssWH) ||
                    !float.TryParse(MedicareWagesAndTipsTextBox.Text, out medWT) ||
                    !float.TryParse(MedicareTaxWithheldTextBox.Text, out medWH) ||
                    !float.TryParse(SocialSecurityTipsTextBox.Text, out ssT) ||
                    !float.TryParse(AllocatedTipsTextBox.Text, out at) ||
                    !float.TryParse(DependentCareBenefitsTextBox.Text, out dpb))
                {
                    MessageBox.Show("Please enter valid numbers in all boxes. Enter 0 if blank.");
                    return;
                }

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@EmployerIdentificationNumberTextBox", EmployerIdentificationNumberTextBox.Text },
                    { "@EmployersNameAddressAndZipCodeTextBox", EmployersNameAddressAndZipCodeTextBox.Text },
                    { "@ControlNumberTextBox", ControlNumberTextBox.Text},
                    { "@wtp", wtp },
                    { "@federalWH", federalWH },
                    { "@ssw", ssw },
                    { "@ssWH", ssWH },
                    { "@medWT", medWT },
                    { "@medWH", medWH },
                    { "@ssT", ssT },
                    { "@at", at },
                    { "@dpb", dpb }
                };

                string query = "UPDATE w2 SET " +
                       "employer_ein = @EmployerIdentificationNumberTextBox, " +
                       "employer_name = @EmployersNameAddressAndZipCodeTextBox, " +
                       "control_number = @ControlNumberTextBox, " +
                       "wages = @wtp, " +
                       "federal_tax_withheld = @federalWH, " +
                       "social_security_wages = @ssw, " +
                       "social_security_tax_withheld = @ssWH, " +
                       "medicare_wages_and_tips = @medWT, " +
                       "medicare_tax_withheld = @medWH, " +
                       "social_security_tips = @ssT, " +
                       "allocated_tips = @at, " +
                       "dependent_care_benefits = @dpb " +
                       "WHERE w2_id = @w2_id";

                parameters.Add("@w2_id", 1); // Replace with the actual ID

                //DatabaseHelper.ExecuteNonSelectQuery(query, parameters);

                MessageBox.Show("Data updated successfully.");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@w2_id", 1 } // Replace with an actual ID which will be passed from the DashboardControl
            };

            /*DataTable dt = DatabaseHelper.ExecuteSelectQuery("SELECT * FROM w2 WHERE w2_id = @w2_id", parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                EmployerIdentificationNumberTextBox.Text = dr["employer_ein"].ToString();
                EmployersNameAddressAndZipCodeTextBox.Text = dr["employer_name"].ToString();
                ControlNumberTextBox.Text = dr["control_number"].ToString();
                WagesTipsOtherCompensationTextBox.Text = dr["wages"].ToString();
                FederalIncomeTaxWithheldTextBox.Text = dr["federal_tax_withheld"].ToString();
                SocialSecurityWagesTextBox.Text = dr["social_security_wages"].ToString();
                SocialSecurityTaxWithheldTextBox.Text = dr["social_security_tax_withheld"].ToString();
                MedicareWagesAndTipsTextBox.Text = dr["medicare_wages_and_tips"].ToString();
                MedicareTaxWithheldTextBox.Text = dr["medicare_tax_withheld"].ToString();
                SocialSecurityTipsTextBox.Text = dr["social_security_tips"].ToString();
                AllocatedTipsTextBox.Text = dr["allocated_tips"].ToString();
                DependentCareBenefitsTextBox.Text = dr["dependent_care_benefits"].ToString();
            }
            else
            {
                Console.WriteLine("No rows returned from the database.");
            }*/
        }
    }
}
