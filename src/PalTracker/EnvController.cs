using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{  
    [Route("/env")]
    public class EnvController 
    { 
        private CloudFoundryInfo _cloudFoundryInfo;
        public EnvController(CloudFoundryInfo cloudFoundryInfo)
        {
            this._cloudFoundryInfo = cloudFoundryInfo;
        }
        public CloudFoundryInfo Get(){
            return  _cloudFoundryInfo;
        }
    }
}