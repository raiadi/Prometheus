using Prometheus.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prometheus
{
    public partial class Send : Form
    {

        #region Declarations

        ApiHelper apiClient = new ApiHelper();

        #endregion

        public Send()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            apiClient.Get("", "");
        }
    }
}
