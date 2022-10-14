using FulaClient.Core;
using Foundation;
using FulaClient.iOSBinding;

namespace FulaClient.iOS
{
    // All the code in this file is included in all platforms.
    public class FulaClient : IFulaClient
    {
        public void CreateBox(string name)
        {
            var m = new MobileFula("test");
            m.AddBox(name,out var error);
            if (error != null)
                throw new Exception(error.ToString());
        }
    }
}