using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Utilities;
using OUDAL;
using OUDAL.Model;

namespace SesTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context db = new Context();
        private DataTable excelTable = null;

        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            string path = "员工名册20160823.xls";
            DataSet ds = MyExcelUtls.GetExcelToDataSet(path, false);
            dataGridView1.DataSource = ds.Tables["上海总部$"];
            excelTable = ds.Tables["上海总部$"];
            btnToDB.Enabled = true;
        }

        const string threeStarSkill = "舒缓按摩,心理辅导,幼儿早教";
        const string fourStarSkill = "月子餐,舒缓按摩,心理辅导 ,幼儿早教";
        const string fiveStarSkill = "月子餐,舒缓按摩,心理辅导,小儿抚触 ,幼儿早教";
        const string fivepfiveStarSkill = "月子餐,舒缓按摩,心理辅导,小儿抚触,幼儿早教,乳房护理，生理指标观察，宝宝游泳，双胞胎，早产儿";
        const string sixStarSkill = "月子餐,舒缓按摩,心理辅导,小儿抚触 ,辅食制作,幼儿早教,乳房护理，宝宝游泳，双胞胎，早产儿，高龄产妇，生理指标观察";
        const string sixpsixStarSkill = "月子餐,舒缓按摩,心理辅导,小儿抚触 ,辅食制作,幼儿早教,乳房护理，宝宝游泳，双胞胎，早产儿，贫血，高龄产妇，生理指标观察";
        const string sevenStarSkill = "月子餐,舒缓按摩,心理辅导,小儿抚触 ,辅食制作,幼儿早教,乳房护理，宝宝游泳，双胞胎，早产儿，贫血，高龄产妇，，紧急情况处理，生理指标观察";

        private void btnToDB_Click(object sender, EventArgs e)
        {
            #region 导入员工数据

            try
            {
                List<GuYuanUser> yss = new List<GuYuanUser>();

                StringBuilder sb = new StringBuilder();
                int total = 0;
                foreach (DataRow dr in excelTable.Rows)
                {
                    GuYuanUser ys = new GuYuanUser();
                    ys.DepartmentName = dr["部门"] + "";
                    ys.Name = dr["姓名"] + "";
                    ys.PositionName = dr["岗位"] + "";
                    ys.Sex = dr["性别"] + "";
                    DateTime onboard;
                    if (DateTime.TryParse(dr["入职日期"] + "", out onboard))
                    {
                        ys.OnboardDate = onboard;
                    }

                    DateTime zhuanzheng;
                    if (DateTime.TryParse(dr["转正日期"] + "", out zhuanzheng))
                    {
                        ys.FullMemberDate = zhuanzheng;
                    }

                    DateTime birthday;
                    if (DateTime.TryParse(dr["出生日期"] + "", out birthday))
                    {
                        ys.Birthday = birthday;
                    }
                    ys.WorkAge = dr["工龄"] + "";
                    ys.Nationality = dr["民族"] + "";
                    ys.Polity = dr["政治面貌"] + "";
                    ys.IDCard = dr["身份证号码"] + "";
                    int tempage;
                    if (int.TryParse(dr["年龄"] + "", out tempage))
                    {
                        ys.Age = tempage;
                    }

                    ys.Phone = dr["手机"] + "";
                    ys.Marry = dr["婚姻状况"] + "";
                    ys.Education = dr["学历"] + "";
                    ys.EmergencyName = dr["紧急联系人"] + "";
                    ys.EmergencyRelation = dr["关系"] + "";
                    ys.EmergencyPhone = dr["电话"] + "";
                    ys.YongGongType = dr["用工类型"] + "";
                    DateTime tempContractExpireDate;
                    if (DateTime.TryParse(dr["合同到期日"] + "", out tempContractExpireDate))
                    {
                        ys.ContractExpireDate = tempContractExpireDate;
                    }
                    decimal tempcmoney;
                    if (Decimal.TryParse(dr["合同工资"] + "", out tempcmoney))
                    {
                        ys.ContractMoney = tempcmoney;
                    }

                    ys.BankCard = dr["银行卡号"] + "";

                    ys.HeTongQiXian = GetHeTongQixian(dr);
                    ys.HuJi = dr["户藉"] + "";
                    ys.HuJiLiving = dr["户籍地址"] + "";
                    ys.CurrentLiving = dr["现住地址"] + "";
                    ys.HuJiType = dr["户籍性质"] + "";
                    ys.SheBaoType = dr["社保类型"] + "";
                    decimal tempsbmoney;
                    if (Decimal.TryParse(dr["基数"] + "", out tempsbmoney))
                    {
                        ys.BaseSheBaoMoney = tempsbmoney;
                    }

                    DateTime shebaostart;
                    if (DateTime.TryParse(dr["社保起缴年月"] + "", out shebaostart))
                    {
                        ys.SheBaoStartDate = shebaostart;
                    }

                    ys.GongJiJingNumber = dr["公积金账号"] + "";
                    ys.Mark = dr["备注"] + "";


                    db.Database.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };


                    db.GuYuanUser.Add(ys);
                    total++;

                }
                //todo
                db.SaveChanges();
                label1.Text = string.Format("总共导入{0},条数据", total);
            }
            catch (DbUpdateException ex)
            {

            }
            #endregion
        }

        string GetHeTongQixian(DataRow dr)
        {
            string retData = "";
            retData = string.Format("{0},{1},{2},{3},{4},{5}", dr["第一次合同期限"], dr["第二次合同签"], dr["第三次合同签"], dr["第四次合同签"], dr["第五次合同签"], dr["第六次合同签"]);

            return retData;
        }

        private void btnny_Click(object sender, EventArgs e)
        {
            string path = "20160425学员名单宁阳.xls";
            DataSet ds = MyExcelUtls.GetExcelToDataSet(path, false);
            dataGridView1.DataSource = ds.Tables[0];
            excelTable = ds.Tables[0];


            //btnToDB.Enabled = true;

        }

        private void btnnyImport_Click(object sender, EventArgs e)
        {
            //#region 宁阳数据

            //db.Database.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };
            //try
            //{
            //    List<YueSaoInfos> yss = new List<YueSaoInfos>();

            //    StringBuilder sb = new StringBuilder();
            //    int total = 0;

            //    foreach (DataRow dr in excelTable.Rows)
            //    {
            //        YueSaoInfos ys = new YueSaoInfos();
            //        string zizhi = "月嫂";

            //        #region 拼model 

            //        //ys.eYS = dr[""]
            //        ys.ysTrueName = dr["姓名"] + "";
            //        if (string.IsNullOrEmpty(ys.ysTrueName.Trim())) continue;
            //        ys.ysCID = dr["身份证号"] + "";
            //        ys.ysZiZhi = zizhi;

            //        DateTime birthday = DateTime.MinValue;
            //        if (DateTime.TryParse(dr["出生年月"] + "", out birthday))
            //        {
            //            ys.ysBirthDay = birthday;
            //        }
            //        //  ys.ysPhoneNumber = dr["手机"] + "";
            //        ys.ysEducation = dr["学历"] + "";
            //        ys.ysNativePlace = "山东";
            //        ys.ysNation = "汉";
            //        ys.ysPhoneNumber = dr["联系方式"] + "";
            //        ys.ysRenYuanState = "在职";
            //        ys.ysHeZuoTypes = "自营";
            //        ys.ysZhengjian = "母婴护理师,身份证,健康证";
            //        ys.optDateTime = DateTime.Now;
            //        ys.optName = "SesTools_ningyang";


            //        ///默认三年，四星
            //        int workingyear = 3;
            //        int starVal = 1;
            //        string ysJineng = "";
            //        string ysFuWuJiNeng = "1073,1070";
            //        //星级
            //        //获取星级 
            //        if (workingyear <= 2)
            //        {
            //            ysJineng = threeStarSkill;
            //            ysFuWuJiNeng = "1073,1070";
            //            starVal = 1;
            //        }
            //        else if (workingyear <= 3)
            //        {
            //            ysJineng = fourStarSkill;
            //            ysFuWuJiNeng = "1065,1069 1073,1070";
            //            starVal = 2;
            //        }
            //        else if (workingyear <= 5)
            //        {
            //            ysJineng = fiveStarSkill;
            //            ysFuWuJiNeng = "1060,1072,1065,1069 1073,1070";
            //            starVal = 3;
            //        }
            //        else if (workingyear <= 6)
            //        {
            //            ysJineng = fivepfiveStarSkill;
            //            ysFuWuJiNeng = "1074,2098,1066,1060,1072,1065,1069 1073,1070";
            //            starVal = 4;
            //        }
            //        else if (workingyear <= 7)
            //        {
            //            ysJineng = sixStarSkill;
            //            ysFuWuJiNeng = "1071,1074,2098,1066,1060,1072,1065,1069 1073,1070";
            //            starVal = 5;
            //        }
            //        else
            //        {
            //            ysJineng = sevenStarSkill;
            //            ysFuWuJiNeng = "1071,1074,2098,1066,1060,1072,1065,1069 1073,1070";
            //            starVal = 7;
            //        }

            //        ys.ysInCityJiaGe = 6000;

            //        ys.ysXingjiLevelID = starVal;
            //        ys.ysJineng = ysJineng;
            //        ys.ysFuWuJiNeng = ysFuWuJiNeng;
            //        ys.ysIsTuiJian = 0;
            //        ys.eYS = 0;
            //        ys.ysJiFen = 0;
            //        ys.ysInCity = 11;
            //        ys.ysServiceCity = "11";
            //        ys.ProjectId = 9;
            //        ys.ysPic = "/Images/defaultys.png";

            //        total++;
            //        ys.ysJobNum = "ny" + total.ToString().PadLeft(5, '0');

            //        db.YueSaoInfos.Add(ys);

            //        if (label1.InvokeRequired)
            //        {


            //            label1.Invoke(new Action(() =>
            //            {
            //                label1.Text = string.Format("总共导入{0},条数据", total);
            //            }));
            //        }
            //        db.SaveChanges();

            //        #endregion
            //    }
            //    label1.Text = string.Format("总共导入{0},条数据", total);
            //}
            //catch (DbUpdateException ex)
            //{

            //}

            //#endregion
        }

        void setMsg(string msg)
        {
            label1.Text = msg;//string.Format("总共导入{0},条数据", total);
        }

        private void btnToDB_Click_1(object sender, EventArgs e)
        {

        }
        // --陈志刚 10    ,马鑫9, 王彬11 ，周悦琪14
        int optid = 10;
        private void btnjmsadd_Click(object sender, EventArgs e)
        {
            //if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //string path = "加盟信息记录表_陈志刚.xls";
                //string path = "加盟信息记录表_马鑫.xls";
                //string path = "加盟信息记录表_王彬.xls";
                //string path = "加盟信息记录表_吴华强.xls";
                string path = "加盟信息记录表_周悦琪.xls";
                DataSet ds = MyExcelUtls.GetExcelToDataSet(path, false);
                dataGridView1.DataSource = ds.Tables["Sheet1$"];
                excelTable = ds.Tables["Sheet1$"];
                btnImportJms.Enabled = true;
                btnImportJmsGenzong.Enabled = true;
            }
        }

        public int GetStateId(string name)
        {
            switch (name)
            {
                case "重点关注": return 1;
                case "持续跟踪": return 2;
                case "无效客户": return 3;
            }
            return 0;
            throw new Exception("stateid error");
        }

        public string GetWuyeClass(string name)
        {
            if (name.IndexOf("独栋物业") >= 0) return "独栋物业";
            if (name.IndexOf("酒店") >= 0) return "酒店及酒店式公寓";
            if (name.IndexOf("商铺") >= 0) return "商铺商务楼";
            if (name.IndexOf("其他") >= 0) return "其他";
            return name;
        }

        public string GetXixiVisit(string name)
        {
            if (name.IndexOf("没有参观过") >= 0) return "无";
            if (name.IndexOf("上海参观过") >= 0) return "来上海参观过";
            if (name.IndexOf("外地门店参观过") >= 0) return "外地门店参观过";
            return name;
        }

        //new SelectListItem { Text = "重点关注", Value = "1" } , new SelectListItem { Text = "持续跟踪", Value = "2" }  ,
        //   new SelectListItem { Text = "无效客户", Value = "3" }  

        private void btnImportJms_Click(object sender, EventArgs e)
        {
            #region 导入加盟商数据

            db.Database.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };

            try
            {

                int total = 0;
                foreach (DataRow dr in excelTable.Rows)
                {
                    JiaMengShangInfo jms = new JiaMengShangInfo();
                    JMSLXR lxr = new JMSLXR();
                    if (string.IsNullOrEmpty(dr["序号"] + "")) continue;

                    jms.JmsName = dr["加盟商姓名"] + "";

                    jms.JmsStateID = GetStateId(dr["客户状态"] + "");


                    jms.JmsPhone = dr["加盟商联系方式"] + "";
                    if (db.JiaMengShangInfo.Count(j => j.JmsPhone == jms.JmsPhone) > 0)
                    {
                        Logger.Info("加盟商有相同电话", ":" + jms.JmsName + " :" + jms.JmsPhone);
                        continue;
                    }

                    jms.JmsQuDaoLaiYuan = dr[6] + ""; //dr["渠道来源"] + "";
                    jms.SaleName = dr["跟单人"] + "";
                    jms.FromType = "software_" + jms.SaleName;

                    jms.SaleId = optid;
                    jms.JmsProvince = dr["省"] + "";
                    jms.JmsCity = dr["市"] + "";
                    jms.JmsArea = dr["区/县"] + "";
                    jms.JmsConShiHangYe = dr["从事行业"] + "";
                    jms.JmsGuDongGouCheng = dr["股东构成"] + "";
                    if (string.IsNullOrEmpty(jms.JmsGuDongGouCheng))
                    {
                        jms.JmsGuDongGouCheng = "未知";
                    }

                    jms.JmsYiXiang = dr["加盟意向"] + "";
                    if (string.IsNullOrEmpty(jms.JmsYiXiang))
                    {
                        jms.JmsYiXiang = "未知";
                    }


                    jms.JmsHasWuYe = (dr["目前是否有合适的物业"] + "") == "是" ? "1" : "2";
                    ;
                    jms.JmsWuYeClass = GetWuyeClass(dr["物业类型"] + "");
                    jms.JmsWuYeQuYu = dr["物业在城市哪个区域"] + "";
                    jms.JmsZiJinYuSuan = (dr["预计投入资金"] + "").Replace("~", "-");
                    if (string.IsNullOrEmpty(jms.JmsZiJinYuSuan))
                    {
                        jms.JmsZiJinYuSuan = "未知";
                    }


                    jms.JmsHeZuoModel = dr["加盟/合作模式"] + "";

                    jms.JmsXiaoFeiLi = dr["加盟地消费能力"] + "";
                    if (string.IsNullOrEmpty(jms.JmsXiaoFeiLi))
                    {
                        jms.JmsXiaoFeiLi = "未知";
                    }


                    jms.JmsYZHSShuLiang = dr["加盟地现有月子会所数量"] + "";

                    if (string.IsNullOrEmpty(jms.JmsYZHSShuLiang))
                    {
                        jms.JmsYZHSShuLiang = "未知";
                    }

                    jms.JmsYZHSJunJia = dr["加盟地月子会所平均价格"] + "";
                    if (string.IsNullOrEmpty(jms.JmsYZHSJunJia))
                    {
                        jms.JmsYZHSJunJia = "未知";
                    }
                    jms.JmsYongYouZiYuan = dr["加盟商拥有哪些资源"] + "";

                    if (string.IsNullOrEmpty(jms.JmsYongYouZiYuan))
                    {
                        jms.JmsYongYouZiYuan = "没有任何资源";
                    }

                    jms.JmsVisitedXiXi = GetXixiVisit(dr["是否参观过喜喜？"] + "");
                    jms.optName = jms.SaleName;

                    jms.optDateTime = DateTime.Now;
                    //jms.JmsYZHSJunJia
                    db.JiaMengShangInfo.Add(jms);

                    db.SaveChanges();

                    lxr.LxrSex = dr["加盟商性别"] + "";
                    lxr.JmsName = jms.JmsName;
                    lxr.JmsID = jms.id;
                    lxr.LxrPhone = jms.JmsPhone;
                    lxr.optDateTime = DateTime.Now;
                    lxr.LxrSex = dr["加盟商性别"] + "";
                    lxr.LxrName = "默认联系人" + jms.JmsName;
                    lxr.LxrPwd = jms.JmsPhone;
                    lxr.LxrStateID = 1;
                    lxr.FromType = "software_" + jms.SaleName;
                    lxr.optName = jms.SaleName;
                    lxr.optId = optid;
                    db.JMSLXR.Add(lxr);
                    db.SaveChanges();
                    total++;

                }
                //todo
                db.SaveChanges();
                label1.Text = string.Format("总共导入{0},条数据", total);
            }
            catch (DbEntityValidationException ed)
            {
                throw ed;
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
            #endregion
        }

        private void btnImportJmsGenzong_Click(object sender, EventArgs e)
        {
            #region 导入加盟商跟踪数据
            db.Database.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };

            try
            {

                int total = 0;
                foreach (DataRow dr in excelTable.Rows)
                {
                    string jmsPhone = dr["加盟商联系方式"].ToString();
                    JiaMengShangInfo jms = db.JiaMengShangInfo.FirstOrDefault(x => x.JmsPhone == jmsPhone);
                    JMSGengZong jmsgz = new JMSGengZong();
                    JMSGengZong lastjmsgz = new JMSGengZong();
                    if (jms != null)
                    {
                        JMSLXR jmslxr = db.JMSLXR.FirstOrDefault(x => x.JmsID == jms.id);

                        if (jmslxr != null)
                        {
                            DateTime shijian = Convert.ToDateTime(dr["第一次电话日期"]);
                            string jilu = dr["第一次电话记录"] + "";
                            jmsgz.JmsID = jms.id;
                            jmsgz.JmsName = jms.JmsName;
                            jmsgz.LxrID = jmslxr.id;
                            jmsgz.LxrName = jmslxr.JmsName;
                            jmsgz.GengzongDateTime = shijian;
                            jmsgz.GenzongInfo = jilu;
                            jmsgz.optDateTime = shijian;

                            jmsgz.GenzongStateID = 1;
                            jmsgz.optName = dr["跟单人"] + "";
                            jmsgz.FromType = "software_" + jmsgz.optName;
                            db.JMSGengZong.Add(jmsgz);
                            total += db.SaveChanges();

                            if (dr["最近一次回访电话日期"] != null)
                            {
                                if (dr["最近一次回访电话日期"].ToString().Length >= 8)
                                {
                                    DateTime shijian2 = Convert.ToDateTime(dr["最近一次回访电话日期"]);
                                    string jilu2 = dr["回访电话记录"] + "";
                                    if (string.IsNullOrWhiteSpace(jilu2))
                                        jilu2 = "未填跟踪记录";
                                    lastjmsgz.JmsID = jms.id;
                                    lastjmsgz.JmsName = jms.JmsName;
                                    lastjmsgz.LxrID = jmslxr.id;
                                    lastjmsgz.LxrName = jmslxr.JmsName;
                                    lastjmsgz.GengzongDateTime = shijian2;
                                    lastjmsgz.GenzongInfo = jilu2;
                                    lastjmsgz.optDateTime = shijian2;

                                    lastjmsgz.GenzongStateID = 1;
                                    lastjmsgz.optName = dr["跟单人"] + "";
                                    lastjmsgz.FromType = "software_" + lastjmsgz.optName;
                                    db.JMSGengZong.Add(lastjmsgz);
                                    total += db.SaveChanges();
                                }
                            }
                        }
                    }
                }
                label1.Text = string.Format("总共导入{0},条数据", total);
            }
            catch (DbEntityValidationException ed)
            {
                throw ed;
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
            #endregion
        }
    }
}
