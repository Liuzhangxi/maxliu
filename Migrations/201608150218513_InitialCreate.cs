namespace OUDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DingDan",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CustomId = c.Int(nullable: false),
                        DDName = c.String(),
                        DDNumber = c.String(),
                        DDMoeny = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DDRealMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DDDingJin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DDYuFu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DDYuKuan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ysID = c.Int(),
                        DDStateID = c.String(),
                        DDInfos = c.String(),
                        DDCompanyID = c.Int(),
                        DDLaiYuanID = c.String(),
                        DDFuWuXiangMuID = c.Int(),
                        DDFuWuAddress = c.String(),
                        DDFuWuYuYueBeginTime = c.DateTime(),
                        DDFuWuYuYueEndTime = c.DateTime(),
                        DDFuWuBeginTime = c.DateTime(),
                        DDFuWuEndTime = c.DateTime(),
                        DDKeFuComments = c.String(),
                        OptName = c.String(),
                        DDCreateTime = c.DateTime(nullable: false),
                        DDYeWuName = c.String(),
                        CustomName = c.String(),
                        ysName = c.String(),
                        DDFuWuXiangMuName = c.String(),
                        PayStatus = c.Int(nullable: false),
                        ProjectId = c.Int(),
                        DDLianXiRen = c.String(),
                        DDLianXiRenPhone = c.String(),
                        parentDDID = c.Int(),
                        DDPingJiaState = c.Int(nullable: false),
                        YongjinMoney = c.Decimal(precision: 18, scale: 2),
                        YunxingCheckedName = c.String(),
                        YunxingCheckedDateTime = c.DateTime(),
                        ZongCaiCheckedName = c.String(),
                        ZongCaiCheckedDateTime = c.DateTime(),
                        CaiWuZhiFuName = c.String(),
                        CaiWuZhiFuDateTime = c.DateTime(),
                        CaiWuZhifFuPingZhen = c.String(),
                        YongjinState = c.String(),
                        DingdanStateDateTime = c.DateTime(),
                        DDBaoXianHao = c.String(),
                        DDFuWuDian = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DingDan");
        }
    }
}
