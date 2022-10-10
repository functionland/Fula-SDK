using ObjCRuntime;
using Foundation;
using UIKit;

namespace FulaClient.iOSSdk
{
   

    // @interface MobileFula : NSObject <goSeqRefInterface, MobileIFula>
    [BaseType(typeof(NSObject))]
    interface MobileFula 
    {
        // @property (readonly, strong) id _Nonnull _ref;
        [Export("_ref", ArgumentSemantic.Strong)]
        NSObject _ref { get; }

        // -(instancetype _Nonnull)initWithRef:(id _Nonnull)ref;
        [Export("initWithRef:")]
        NativeHandle Constructor(NSObject @ref);

        // -(instancetype _Nullable)init:(NSString * _Nullable)repoPath;
        [Export("init:")]
        NativeHandle Constructor([NullAllowed] string repoPath);

        // -(BOOL)addBox:(NSString * _Nullable)boxAddr error:(NSError * _Nullable * _Nullable)error;
        [Export("addBox:error:")]
        bool AddBox([NullAllowed] string boxAddr, [NullAllowed] out NSError error);

        // -(BOOL)delete:(NSString * _Nullable)userDID path:(NSString * _Nullable)path error:(NSError * _Nullable * _Nullable)error;
        [Export("delete:path:error:")]
        bool Delete([NullAllowed] string userDID, [NullAllowed] string path, [NullAllowed] out NSError error);

        // -(BOOL)mkDir:(NSString * _Nullable)userDID path:(NSString * _Nullable)path error:(NSError * _Nullable * _Nullable)error;
        [Export("mkDir:path:error:")]
        bool MkDir([NullAllowed] string userDID, [NullAllowed] string path, [NullAllowed] out NSError error);

        // -(BOOL)read:(NSString * _Nullable)userDID filePath:(NSString * _Nullable)filePath destPath:(NSString * _Nullable)destPath error:(NSError * _Nullable * _Nullable)error;
        [Export("read:filePath:destPath:error:")]
        bool Read([NullAllowed] string userDID, [NullAllowed] string filePath, [NullAllowed] string destPath, [NullAllowed] out NSError error);

        // -(BOOL)write:(NSString * _Nullable)userDID srcPath:(NSString * _Nullable)srcPath destPath:(NSString * _Nullable)destPath error:(NSError * _Nullable * _Nullable)error;
        [Export("write:srcPath:destPath:error:")]
        bool Write([NullAllowed] string userDID, [NullAllowed] string srcPath, [NullAllowed] string destPath, [NullAllowed] out NSError error);
    }

   
}
