using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using OUDAL.Properties;

namespace OUDAL.MongoProxy
{
    public class MongoProxy
    {
        private static MongoClient client;

        private static IMongoDatabase GetDB()
        {
            return client.GetDatabase(Resources.DatabaseName);
        }

        private static IMongoCollection<Campaign> GetCampaignCollection()
        {
            return client.GetDatabase(OUDAL.Properties.Resources.DatabaseName).GetCollection<Campaign>("Campaign");
        }
       
        public static void Init()
        {
             //System.Runtime.InteropServices.RuntimeInformation
            client = new MongoClient(OUDAL.Properties.Resources.MongoDB);
        }

        public static bool IsNotValidObjectId(string id)
        {
            ObjectId targetId;
            return !ObjectId.TryParse(id, out targetId);
        }

        #region Campaign

        public static Campaign InsertCampaign(Campaign campaign)
        {
            var cols = GetCampaignCollection();
            cols.InsertOne(campaign);

            return campaign;
        }

        public static UpdateResult UpdateCampaign(Campaign campaign)
        {
            var cols = GetCampaignCollection();
            var filter = Builders<Campaign>.Filter.Eq(a => a.Id, campaign.Id);
            var update = Builders<Campaign>.Update
                .Set(a => a.Title, campaign.Title)
                .Set(a => a.PageType, campaign.PageType)
                .Set(a => a.ImageUrl, campaign.ImageUrl)
                .Set(a => a.RedirectUrl, campaign.RedirectUrl)
                .Set(a => a.Description, campaign.Description)
                .Set(a => a.Seq, campaign.Seq)
                .Set(a => a.StartTime, campaign.StartTime)
                .Set(a => a.EndTime, campaign.EndTime)
                .Set(a => a.CreateTime, campaign.CreateTime);

            return cols.UpdateOne(filter, update);
        }

        public static DeleteResult DeleteCampaign(string campaignId)
        {
            var cols = GetCampaignCollection();
            var filter = Builders<Campaign>.Filter.Eq(a => a.Id, ObjectId.Parse(campaignId));

            return cols.DeleteOne(filter);
        }

        public static List<Campaign> GetCampaigns(DateTime? startTime, DateTime? endTime, int start, int rows, out int totalCount)
        {
            var cols = GetCampaignCollection();
            var filter = Builders<Campaign>.Filter.Empty;
            if (startTime.HasValue)
            {
                filter = filter & Builders<Campaign>.Filter.Lte(a => a.StartTime, startTime.Value);
            }
            if (endTime.HasValue)
            {
                filter = filter & Builders<Campaign>.Filter.Gte(a => a.EndTime, endTime.Value);
            }
            var cursor = cols.Find(filter);

            totalCount = (int)cursor.Count();
            var temp = cursor.Sort(Builders<Campaign>.Sort.Descending(a => a.CreateTime)).Skip(start).Limit(rows);

            return temp.ToList();
        }

        public static Campaign GetCampaign(string id)
        {
            var cols = GetCampaignCollection();
            var filter = Builders<Campaign>.Filter.Eq(a => a.Id, ObjectId.Parse(id));
            var cursor = cols.Find(filter);

            return cursor.FirstOrDefault();
        }

        #endregion
         

    }
}
