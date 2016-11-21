using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace OUDAL.MongoProxy
{
    /// <summary>
    /// 活动
    /// </summary>
    [BsonIgnoreExtraElements]
    public class Campaign
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonIgnore]
        [JsonProperty(PropertyName = "Id")]
        public string JsonId
        {
            get { return Id.ToString(); }
            set { Id = ObjectId.Parse(value); }
        }

        /// <summary>
        /// 广告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// WebView类型, Default:简单展示, Article:文章详情
        /// </summary>
        public string PageType { get; set; }

        /// <summary>
        /// 广告图片
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 导向链接,绝对路径
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
