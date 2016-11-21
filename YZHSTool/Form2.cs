using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSDK.DingTalk;
using NetSDK.DingTalk.DataContracts;

namespace YZHSTool
{
    public partial class Form2 : Form
    {
        CorpClient _corpClient;

        public Form2()
        {
            InitializeComponent();

            _corpClient = new CorpClient("ding7fa9f03b22d0cff4", "Gf3dbLXynUbmhQjDJxYIW0gm5MWUr9dmM7U90TWD8KlgKcGZQMYXDFtqMhNRGp76");
            _corpClient = new CorpClient("dinga304e9a0e21eb12835c2f4657eb6378f", "V-CJuamUlvJi-0kMofpvgLr12j3jU5aaC7ZnwVuKkBjjENguEmTHNtCt5s2lF5bu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var media_id = _corpClient.UploadMedia("image", "d:\\ses_logo.png");
            System.Diagnostics.Debug.WriteLine(media_id);
        }

        //创建微应用
        private void button2_Click(object sender, EventArgs e)
        {
            var media_id = _corpClient.UploadMedia("image", "d:\\logo-3.png");
            var agentId = _corpClient.CreateMicroapp(media_id, "系统通知", "喜喜业务通知", "http://weixin.91ses.com/DingTalk?redirectUrl=XixiNoty");
            _corpClient.SetMicroappVisibleScope(agentId, new Microapp.VisibleScope { isHidden = true });
            System.Diagnostics.Debug.WriteLine(agentId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _corpClient.SendMessage(new SendMessageRequest
            {
                touser = "03090013144002|02551155557668",
                message = new TextMessage { text = new TextMessageBody { content = "老张，你的工作完成了没" } },
                agentid = "50287940"
            });

        }
    }
}
