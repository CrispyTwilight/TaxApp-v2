using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxApp_v2.Models.DataLayer;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class UserControl1 : UserControl
    {

        TaxAppContext context = new TaxAppContext();
        User user = new User();

        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
