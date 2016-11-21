



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using OUDAL.ModelBase;
namespace OUDAL
{
    ///################################################################################################
    /// <summary>
    /// <para>摘要：JMSJieDianClassModelModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JMSJieDianClassModel
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JdMCName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>大类模型名称</td></tr>
    /// <tr valign="top"><td>3</td><td>JdMCPaiXu</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类排序</td></tr>
    /// <tr valign="top"><td>4</td><td>JdMCStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类模型状态</td></tr>
    /// <tr valign="top"><td>5</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>6</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    
    public partial class JMSJieDianClassModel 
    {
        [NotMapped]
        public List<JMSJieDianModel> JmsJieDianModels { get; set; } 


    }

    public partial class JMSJieDianClassObj
    {
        [NotMapped]
        public List<JMSJieDianObj> JmsJieDianObjs { get; set; }

        public static JMSJieDianClassObj TranferModelToObj(JMSJieDianClassModel model, int jmsId, string jmsName, int projectId)
        {
            JMSJieDianClassObj obj = new JMSJieDianClassObj();
            obj.JdClassModelName = model.JdClassName;
            obj.JdClassModelID = model.id; 
            obj.JdClassPaiXu= model.JdClassPaiXu; 
            obj.JmsID = jmsId;
            obj.JmsName = jmsName;
            obj.ProjectID = projectId; 
            return obj;
        }
         
    }
}
