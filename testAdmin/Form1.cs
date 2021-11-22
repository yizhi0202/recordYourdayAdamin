using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;
using RestSharp.Authenticators;
using System.Collections;

using Newtonsoft.Json;
using testAdmin.Properties;

namespace testAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://hello-cloudbase-7gk3odah3c13f4d1-1306308742.ap-shanghai.app.tcloudbase.com/");
            var request = new RestRequest("test", Method.POST);
            Dictionary<string, string> mydic = new Dictionary<string, string>();
            mydic.Add("userID", "2653311274@qq.com");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonStr = serializer.Serialize(mydic);
            //client.Authenticator = new SimpleAuthenticator("userID", "2653311274@qq.com","pass","");
            //request.AddParameter("application/json",jsonStr ,ParameterType.RequestBody);
            try
            {
                var response = client.Execute(request);
                Console.WriteLine(response.StatusCode);
                if (response.ErrorException != null)
                {
                    const string message = "Error retrieving response.  Check inner details for more info.";
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }
                //Console.WriteLine(response.Content);
                Root rt = JsonConvert.DeserializeObject<Root>(response.Content);
                Console.WriteLine(rt.requestId);
                Console.WriteLine("结束");

            }
            catch
            {

            }
        }


        private void login_Click(object sender, EventArgs e)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://hello-cloudbase-7gk3odah3c13f4d1-1306308742.ap-shanghai.app.tcloudbase.com/");
            var request = new RestRequest("adminLogin", Method.POST);
            Dictionary<string, string> mydic = new Dictionary<string, string>();
            mydic.Add("account", accountBox.Text);
            mydic.Add("pass", passBox.Text);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonStr = serializer.Serialize(mydic);
            request.AddParameter("application/json",jsonStr ,ParameterType.RequestBody);

            try
            {
                var response = client.Execute(request);
                Console.WriteLine(response.Content);
                Console.WriteLine(response.StatusCode.ToString());
                if(response.StatusCode.ToString()!="OK")
                {
                    MessageBox.Show("网络故障，请稍后再试");
                }
                else
                {
                    if(response.Content =="success")
                    {
                        mainAdaminPage mainPage = new mainAdaminPage();
                        this.Hide();
                        mainPage.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码有误，请检查后再试");
                    }
                }
            }
            catch
            {

            }
           
        }


        private void accountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
