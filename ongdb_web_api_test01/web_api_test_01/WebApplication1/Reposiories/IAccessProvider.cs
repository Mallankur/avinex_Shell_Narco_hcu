using WebApplication1.Model;

namespace Avinex_Shell_Norco_HCU.Reposiories
{
    public interface IAccessProvider
    {
        // <summary>
        /// Get-all-data_from_database
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Refinery_Information>> GetALLRefineryInformationAsync();
        /// <summary>
        /// create_the_node_inthe_database
        /// </summary>
        /// <param name="refineryInformation"></param>
        /// <returns></returns>
        Task CreateRefineryInformation(Refinery_Information refineryInformation);

        //Task createvarable(Refinery_Information refineryInformationdel);   
    }
}
