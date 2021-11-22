using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using testAdmin.Properties;

namespace testAdmin
{
    public partial class paceNotePage : Form
    {
        public paceNotePage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void getData()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://hello-cloudbase-7gk3odah3c13f4d1-1306308742.ap-shanghai.app.tcloudbase.com/");
            var request = new RestRequest("adminGetInfo", Method.POST);
            Dictionary<string, string> mydic = new Dictionary<string, string>();
            mydic.Add("recordName", "paceNote");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonStr = serializer.Serialize(mydic);
            //client.Authenticator = new SimpleAuthenticator("userID", "2653311274@qq.com","pass","");
            request.AddParameter("application/json", jsonStr, ParameterType.RequestBody);
            try
            {
                var response = client.Execute(request);
                if (response.ErrorException != null)
                {
                    const string message = "Error retrieving response.  Check inner details for more info.";
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }
                //Console.WriteLine(response.Content);
                paceNote rt = JsonConvert.DeserializeObject<paceNote>(response.Content);
                paceNoteInfoDataGridView.DataSource = rt.data;
            }
            catch
            {

            }
        }
        private void paceNotePage_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!IsCheck())
            {
                MessageBox.Show("请选择要删除的数据");
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);

                //删除表中的数据
                if (dt == DialogResult.OK)
                {

                    for (int i = 0; i < paceNoteInfoDataGridView.Rows.Count; i++)
                    {
                        if (paceNoteInfoDataGridView.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在 
                        {
                            var client = new RestClient();
                            client.BaseUrl = new Uri("https://hello-cloudbase-7gk3odah3c13f4d1-1306308742.ap-shanghai.app.tcloudbase.com/");
                            var request = new RestRequest("services", Method.POST);
                            if (paceNoteInfoDataGridView.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中 
                            {
                                String paceNoteID = paceNoteInfoDataGridView.Rows[i].Cells[1].Value.ToString();
                                Dictionary<string, string> mydic = new Dictionary<string, string>();
                                mydic.Add("objectID", paceNoteID);
                                mydic.Add("action", "delete");
                                mydic.Add("recordName", "paceNote");
                                JavaScriptSerializer serializer = new JavaScriptSerializer();
                                string jsonStr = serializer.Serialize(mydic);
                                request.AddParameter("application/json", jsonStr, ParameterType.RequestBody);
                                try
                                {
                                    var response = client.Execute(request);
                                    if (response.ErrorException != null)
                                    {
                                        const string message = "Error retrieving response.  Check inner details for more info.";
                                        var twilioException = new ApplicationException(message, response.ErrorException);
                                        throw twilioException;
                                    }
                                }
                                catch
                                {

                                }

                            }
                        }
                    }
                    MessageBox.Show("删除成功");
                    getData();
                }
            }
        }

        private void audit_Click(object sender, EventArgs e)
        {
            if (!IsCheck())
            {
                MessageBox.Show("请选择要审核的数据");
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要审核通过吗？", "提示", MessageBoxButtons.OKCancel);

                //审核表中的数据
                if (dt == DialogResult.OK)
                {

                    for (int i = 0; i < paceNoteInfoDataGridView.Rows.Count; i++)
                    {
                        if (paceNoteInfoDataGridView.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在 
                        {
                            var client = new RestClient();
                            client.BaseUrl = new Uri("https://hello-cloudbase-7gk3odah3c13f4d1-1306308742.ap-shanghai.app.tcloudbase.com/");
                            var request = new RestRequest("services", Method.POST);
                            if (paceNoteInfoDataGridView.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中 
                            {
                                String paceNoteID = paceNoteInfoDataGridView.Rows[i].Cells[1].Value.ToString();
                                Dictionary<string, string> mydic = new Dictionary<string, string>();
                                mydic.Add("objectID", paceNoteID);
                                mydic.Add("action", "audit");
                                mydic.Add("recordName", "paceNote");
                                JavaScriptSerializer serializer = new JavaScriptSerializer();
                                string jsonStr = serializer.Serialize(mydic);
                                request.AddParameter("application/json", jsonStr, ParameterType.RequestBody);
                                try
                                {
                                    var response = client.Execute(request);
                                    if (response.ErrorException != null)
                                    {
                                        const string message = "Error retrieving response.  Check inner details for more info.";
                                        var twilioException = new ApplicationException(message, response.ErrorException);
                                        throw twilioException;
                                    }
                                    

                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    MessageBox.Show("审核完成");
                    getData();
                }
            }
        }

        private void comeback_Click(object sender, EventArgs e)
        {
            mainAdaminPage mainPage = new mainAdaminPage();
            this.Hide();
            mainPage.ShowDialog();
            this.Dispose();
        }
        private bool IsCheck()
        {
            bool ischecked = false;
            for (int i = 0; i < paceNoteInfoDataGridView.Rows.Count; i++)
            {
                if (paceNoteInfoDataGridView.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在 
                {
                    if (paceNoteInfoDataGridView.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中 
                    {
                        ischecked = true;
                        return ischecked;
                    }
                }
            }
            return ischecked;
        }
    }
}
