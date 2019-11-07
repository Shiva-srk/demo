#region snippet_DataPOCServiceClass
using POCCosmosDB.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace POCCosmosDB.Services
{
    public class DataPOCService
    {
        private readonly IMongoCollection<DataPOC> _DataPOCs;

        #region snippet_DataPOCServiceConstructor
        public DataPOCService(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _DataPOCs = database.GetCollection<DataPOC>(settings.BooksCollectionName);
        }
        #endregion

        public List<DataPOC> Get() =>
            _DataPOCs.Find(DataPOC => true).ToList();

        public DataPOC Get(string id) =>
            _DataPOCs.Find<DataPOC>(DataPOC => DataPOC.Id == id).FirstOrDefault();

        public DataPOC Create(DataPOC DataPOC)
        {
            _DataPOCs.InsertOne(DataPOC);
            return DataPOC;
        }

        public void Update(string id, DataPOC DataPOCIn) =>
            _DataPOCs.ReplaceOne(DataPOC => DataPOC.Id == id, DataPOCIn);

        public void Remove(DataPOC DataPOCIn) =>
            _DataPOCs.DeleteOne(DataPOC => DataPOC.Id == DataPOCIn.ProductClassCd);

        public void Remove(string id) => 
            _DataPOCs.DeleteOne(DataPOC => DataPOC.Id == id);
    }
}
#endregion
