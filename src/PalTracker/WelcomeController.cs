using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        public WelcomeMessage message;
        public WelcomeController(WelcomeMessage message){
            this.message = message;
        }
        [HttpGet]
        public string SayHello(){ 
            return this.message.message;
        }
    }
}