using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Foundation;
using UIKit;


namespace FulaClient.iOSSdk
{
	static class CFunctions
	{
		// extern MobileFula * _Nullable MobileNewFula (NSString * _Nullable repoPath, NSError * _Nullable * _Nullable error);
		[DllImport ("__Internal")]
		
		
		static extern MobileFula MobileNewFula (NSString repoPath,  out NSError error);
		
	}
}
