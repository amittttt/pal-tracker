using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    public class WelcomeMessage 
    {
        public string message;
        public WelcomeMessage(string message){
            this.message = message;
        }
    }
}