using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    public class CloudFoundryInfo 
    {
        public string Port;
        public string MemoryLimit;
        public string CfInstanceIndex;
        public string CfInstanceAddr;
         
        public CloudFoundryInfo(string Port, string MemoryLimit , string CfInstanceIndex, string CfInstanceAddr){
            this.Port = Port;
            this.MemoryLimit = MemoryLimit;
            this.CfInstanceIndex = CfInstanceIndex;
            this.CfInstanceAddr = CfInstanceAddr;
        }
    }
    



}