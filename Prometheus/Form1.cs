using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prometheus.Factory;
using Prometheus.Models;
using RestSharp.Serialization.Json;
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
            debugOutput("Send button clicked");
            
            var responseObject = apiClient.Get<ListUsers>(txtBxApiEndpoint.Text, "");

            // Deserialize and cast to ListUsers class
            //var result = JsonConvert.DeserializeObject<ListUsers>(responseObject.Content);
            JObject jObject = JObject.Parse(responseObject.Content);
            ListUsers result = jObject.ToObject<ListUsers>();

            var exportString = "";

            if(responseObject != null && responseObject.Content.Contains("data"))
            {
                var outputPath = txtBxOutputFilePath.Text; 
                //@"C:\Users\thulu\Desktop\Projects\GitHub\Prometheus\Prometheus\RecievedData\Result.txt";

                exportString += "id, email, first_name, last_name, avatar";

                for(var i = 0; i < result.data.Count; i++)
                {
                    exportString += result.data[i].id.ToString() + ",";
                    exportString += result.data[i].email.ToString() + ",";
                    exportString += result.data[i].first_name.ToString() + ",";
                    exportString += result.data[i].last_name.ToString() + ",";
                    exportString += result.data[i].avatar.ToString() + ",";
                    exportString += Environment.NewLine;
                }

                WriteToFile(outputPath, exportString);
            }     
        }
        public bool WriteToFile(string outputPath, string data)
        {
            System.IO.File.WriteAllText(outputPath, data);

            return true;
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtMessage.Text = txtMessage.Text + strDebugText + Environment.NewLine;
                txtMessage.SelectionStart = txtMessage.TextLength;
                txtMessage.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
