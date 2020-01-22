using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadTrackingToMagentoApiModel;

namespace LoadTrackingToMagentoAPI
{
    public partial class FormMainUI : Form
    {
        //********************************************************************** Local | Variables
        #region
        // ----------------------------------------------------- Resonse Var
        string responseFromApi = "";
        // ----------------------------------------------------- Hepler Instance
        ApiHelper apiCall = new ApiHelper();
        // ----------------------------------------------------- DataTable
        DataTable dt = new DataTable();
        //-----------------------------------------------------
        #endregion

        //********************************************************************** Init UI Components
        #region
        public FormMainUI()
        {
            InitializeComponent();
        }
        #endregion

        //********************************************************************** Event | Click | Button
        #region
        private void ButtonApiPost_Click(object sender, EventArgs e)
        {
            GetDeliveryNumData();
            ProcessApiPostRequest();
        }
        #endregion

        //********************************************************************** Methods | Local
        #region
        //------------------------------------------------ Get Data
        private void GetDeliveryNumData()
        {
            //
            // Add Column Header
            //
            dt.Columns.Add("DeliveryNum", typeof(string));
            //
            // Static Del-Num Load 
            // Save to Table
            //
            dt.Rows.Add("1WEB20001900");
            dt.Rows.Add("1WEB20001900");
        }

        //------------------------------------------------ Process API
        private void ProcessApiPostRequest()
        {          
            //
            // Api Call | Loop through DT
            //
            foreach (DataRow row in dt.Rows)
            {
                responseFromApi = apiCall.ValidateAndPostTracking(row.Field<string>(0));
            }
            //
            // Print API Repsonse
            //
            label1.Text = $"Simple Response from API = { responseFromApi }";          
        }
        #endregion
    }
}
