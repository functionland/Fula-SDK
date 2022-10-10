
sharpie bind --sdk=iphoneos15.5 --output="ApiDef2" --namespace="Binding" --scope="Mobile.xcframework/ios-arm64/Mobile.framework/Versions/A/Headers/" "Mobile.xcframework/ios-arm64/Mobile.framework/Versions/A/Headers/Mobile.objc.h"
sharpie bind -framework Mobile.xcframework/ios-arm64/Mobile.framework  -sdk iphoneos15.5 --output="ApiDef3" --namespace="Binding"
