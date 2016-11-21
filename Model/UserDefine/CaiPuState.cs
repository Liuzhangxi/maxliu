using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.Model
{
    #region 给阿姨，toserver

    public class ToServerCaipu
    {
        public ToServerCaipu()
        {
            RoomNumberDesc = new List<string>();
        }

        public int CaipuId { get; set; }
        public int Step { get; set; }
        public string StepDesc
        {
            get
            {
                return DietSpecial.GetStepName(Step);
            }
        }
        public string CaipuName { get; set; }
        public List<string> RoomNumberDesc { get; set; }
        public string CaiType { get; set; }
        public string CanType { get; set; }
         
    }

    #endregion

    public class CaipuUseInfo
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class KeRenPeiCanDesc
    {
        public RoomCheckIn RoomCheckIn { get; set; }
        public DietSpecial DietSpecial { get; set; }
        public KeRenPeiCan PeiCan { get; set; }
        public RoomInfo RoomInfo { get; set; }
    }



    public class CaiPuGroup
    {
        public int Step { get; set; }
        public CaiPuGroup(List<CaipuModel> caipus, int step)
        {
            Step = step;
            CaiPingList = new List<CaiPuState>();
            TangPingList = new List<CaiPuState>();
            SetCaiPuModelGroup(caipus, step);
        }
        public CaiPuGroup(List<Caipu> caipus, int step)
        {
            Step = step;
            CaiPingList = new List<CaiPuState>();
            TangPingList = new List<CaiPuState>(); 
            SetCaiPuGroup(caipus, step);
        }


        public string StepDesc
        {
            get { return DietSpecial.GetStepName(Step); }
        }

        public List<CaiPuState> CaiPingList { get; set; }
        public List<CaiPuState> TangPingList { get; set; }

        public List<CaiPuState> TotalCaiList
        {
            get
            {
                List<CaiPuState> total = new List<CaiPuState>();
                total.AddRange(CaiPingList);
                total.AddRange(TangPingList);
                return total; 
            }
        }

        List<CaiPuState> SetCanType(List<Caipu> caipus)
        {
            List<CaiPuState> ret = new List<CaiPuState>();
            List<Caipu> wancanList = caipus.Where(c => c.CanType == "晚餐").ToList();
            List<Caipu> wucanList = caipus.Where(c => c.CanType == "午餐").ToList();

            //前提 晚餐和午餐 数量一致
            int caiCount = wancanList.Count > wucanList.Count ? wancanList.Count : wucanList.Count;
            //设置不一样情况

            while (wucanList.Count > wancanList.Count)
            {
                Caipu c = new Caipu();
                c.Step = Step;
                wancanList.Add(c);
            }

            while (wucanList.Count < wancanList.Count)
            {
                Caipu c = new Caipu();
                c.Step = Step;
                wucanList.Add(c);
            }


            for (int i = 0; i < caiCount; i++)
            {
                CaiPuState caiPuState = new CaiPuState();
                caiPuState.wucanid = wucanList[i].id;
                caiPuState.wancanid = wancanList[i].id;
                caiPuState.CaiType = wucanList[i].CaiType;
                caiPuState.Step = wucanList[i].Step.Value;
                caiPuState.WuCanName = wucanList[i].Name;
                caiPuState.WuCanPeiLiao = wucanList[i].Peiliao;
                caiPuState.WuCanGongXiao = wucanList[i].Gongxiao;

                caiPuState.WanCanName = wancanList[i].Name;
                caiPuState.WanCanPeiLiao = wancanList[i].Peiliao;
                caiPuState.WanCanGongXiao = wancanList[i].Gongxiao;

                ret.Add(caiPuState);
            }
            return ret;
        }

        List<CaiPuState> SetModelCanType(List<CaipuModel> caipus)
        {
            List<CaiPuState> ret = new List<CaiPuState>();
            List<CaipuModel> wancanList = caipus.Where(c => c.CanType == "晚餐").ToList();
            List<CaipuModel> wucanList = caipus.Where(c => c.CanType == "午餐").ToList();

            //前提 晚餐和午餐 数量一致
            int caiCount = wancanList.Count > wucanList.Count ? wancanList.Count : wucanList.Count;
            //设置不一样情况

            while (wucanList.Count > wancanList.Count)
            {
                CaipuModel c = new CaipuModel();
                c.Step = Step;
                wancanList.Add(c);
            }

            while (wucanList.Count < wancanList.Count)
            {
                CaipuModel c = new CaipuModel();
                c.Step = Step;
                wucanList.Add(c);
            }


            for (int i = 0; i < caiCount; i++)
            {
                CaiPuState caiPuState = new CaiPuState();
                caiPuState.wucanid = wucanList[i].id;
                caiPuState.wancanid = wancanList[i].id;
                caiPuState.CaiType = wucanList[i].CaiType;
                caiPuState.Step = wucanList[i].Step.Value;
                caiPuState.WuCanName = wucanList[i].Name;
                caiPuState.WuCanPeiLiao = wucanList[i].Peiliao;
                caiPuState.WuCanGongXiao = wucanList[i].Gongxiao;

                caiPuState.WanCanName = wancanList[i].Name;
                caiPuState.WanCanPeiLiao = wancanList[i].Peiliao;
                caiPuState.WanCanGongXiao = wancanList[i].Gongxiao;

                ret.Add(caiPuState);
            }
            return ret;
        }
        /// <summary>
        /// 设置当前菜谱组
        /// </summary>
        /// <param name="caipus"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        string SetCaiPuGroup(List<Caipu> caipus,int step)
        { 
            #region  设置菜品

            //设置当前菜谱状态
            List<Caipu> caiPings = caipus.Where(c => (c.CaiType == "荤菜" || c.CaiType == "素菜") && c.Step == step).OrderBy(o=>o.CaiType).ToList();
            CaiPingList.AddRange(SetCanType(caiPings));

            List<Caipu> tangPings = caipus.Where(c => c.CaiType == "汤品" && c.Step == step).OrderBy(o => o.CaiType).ToList();
            TangPingList.AddRange(SetCanType(tangPings));
            #endregion 
            return ""; 
        }

        string SetCaiPuModelGroup(List<CaipuModel> caipus, int step)
        {
            #region  设置菜品

            //设置当前菜谱状态
            List<CaipuModel> caiPings = caipus.Where(c => (c.CaiType == "荤菜" || c.CaiType == "素菜") && c.Step == step).OrderBy(o => o.CaiType).ToList();
            CaiPingList.AddRange(SetModelCanType(caiPings));

            List<CaipuModel> tangPings = caipus.Where(c => c.CaiType == "汤品" && c.Step == step).OrderBy(o => o.CaiType).ToList();
            TangPingList.AddRange(SetModelCanType(tangPings));
            #endregion 
            return "";
        }
    }

    public class CaiPuState
    {
        public int wucanid { get; set; }
        public int wancanid{ get; set; }

        /// <summary>
        /// 午餐份数
        /// </summary>
        public int wucanfenshu { get; set; }
        public int wancanfenshu { get; set; }

        public int Step { get; set; }
        public string CaiType { get; set; }

        public string CaiTypeDesc
        {
            get
            {
                if (CaiType == "蔬菜" || CaiType == "荤菜")
                {
                    return "菜品";
                }
                return CaiType;
            }
        }

        public string WuCanName{ get; set; }
        public string WuCanPeiLiao { get; set; }
        public string WuCanGongXiao { get; set; }
        public string WanCanName { get; set; }
        public string WanCanPeiLiao { get; set; }
        public string WanCanGongXiao { get; set; }


    }
}
