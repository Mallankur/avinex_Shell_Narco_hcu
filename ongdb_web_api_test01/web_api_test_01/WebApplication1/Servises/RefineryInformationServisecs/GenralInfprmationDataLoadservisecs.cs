using Avinex_Shell_Norco_HCU.Reposiories;
using Microsoft.Extensions.Options;
using Neo4j.Driver;
using WebApplication1.ConnectionString;
using WebApplication1.Model;

namespace Avinex_Shell_Norco_HCU.Servises.RefineryInformationServisecs
{
    public class GenralInfprmationDataLoadservisecs : IAccessProvider
    {
        private readonly IDriver _driver;
       // private readonly Neo4jService _neo4jService;

        public GenralInfprmationDataLoadservisecs(IOptions<OngdbConnector> ongdbOptions)
        {
            var connectionString = ongdbOptions.Value.ConnectionString;
            var userName = ongdbOptions.Value.UserName;
            var password = ongdbOptions.Value.Password;

            _driver = GraphDatabase.Driver(connectionString, AuthTokens.Basic(userName, password));
           // _neo4jService = new Neo4jService(_driver);
        }

        public async Task CreateRefineryInformation(Refinery_Information refineryInformation)
        {

            using (var session = _driver.AsyncSession())
            {
                var cypherQuery = "CREATE (r:Refinery_Information) SET r = $refineryInformation";

                var parameters = new { refineryInformation };

                await session.RunAsync(cypherQuery, parameters);
            }
        }

        public Task<IEnumerable<Refinery_Information>> GetALLRefineryInformationAsync()
        {
            throw new NotImplementedException();
        }

        //public async  Task<IEnumerable<Refinery_Information>> GetALLRefineryInformationAsync()
        //{
        //    using (var session = _driver.AsyncSession())
        //    {
        //        var cypherQuery = "MATCH (r:Refinery_Information) RETURN r";

        //        var result = await session.RunAsync(cypherQuery);

        //        var refineryInformationList = new List<Refinery_Information>();
        //        await result.ForEachAsync(record =>
        //        {
        //            var refineryInformation = record["r"].As<INode>().Properties;
        //            refineryInformationList.Add(refineryInformation);
        //        });

        //        return refineryInformationList;
        //    }


    }
   
   
}
