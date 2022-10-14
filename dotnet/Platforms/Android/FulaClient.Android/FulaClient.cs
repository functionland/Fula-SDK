using FulaClient.Core;

namespace FulaClient.Android
{
    // All the code in this file is included in all platforms.
    public class FulaClient : IFulaClient
    {
        public void CreateBox(string name)
        { 
            var f = FulaMobile.FulaMobile.NewFula($"/storage/emulated/0/{name}");
            f.AddBox(name);
        }
    }
}