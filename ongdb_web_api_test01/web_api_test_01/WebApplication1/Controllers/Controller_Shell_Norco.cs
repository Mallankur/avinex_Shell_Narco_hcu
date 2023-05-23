using Avinex_Shell_Norco_HCU.Servises.RefineryInformationServisecs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller_Shell_Norco : ControllerBase
    {
        private readonly GenralInfprmationDataLoadservisecs _ongdbservies;
        public Controller_Shell_Norco(GenralInfprmationDataLoadservisecs ongdbservies)
        {
            _ongdbservies = ongdbservies;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<List<Refinery_Information>> GetAllDataAsync()
        {
            return NotImplementedException("djfefc");
        }

        private List<Refinery_Information> NotImplementedException(string v)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="refinaryinformation"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]

        public async Task<ActionResult>AssiganRefinaryInformation(Refinery_Information refinaryinformation)
        {
            await _ongdbservies.CreateRefineryInformation(refinaryinformation);
           
            return Ok(refinaryinformation);
          
              

        }

    }
}
