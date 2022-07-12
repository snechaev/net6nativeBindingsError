# net6nativeBindingsError

this is test project for stackoverflow questing about the problem building native bindings library targeting tfm=net6-macos. The problem is the following build errors


```
ILLINK: Error MM0140: File '/Users/user/work/MonoBindingTest/net6/app/obj/Debug/net6.0-macos/osx-x64/linker-cache/NativeBindingsLib.resources/ScriptingBridge.framework/ScriptingBridge' is not a valid framework. (MM0140) (app)

ILLINK: Error MM2342: The linker step 'Extract Binding Libraries' failed during processing: File '/Users/user/work/MonoBindingTest/net6/app/obj/Debug/net6.0-macos/osx-x64/linker-cache/NativeBindingsLib.resources/ScriptingBridge.framework/ScriptingBridge' is not a valid framework. (MM2342) (app)
```
Here we have two solutions
* mono - targeting old mono-based xamarin.mac. Works fine and the test app should show Finder's version on startup to show the bindings works as expected.
* net6 - the same solution, but migrated to sdk-style project and targeting `net6-macos`. This won't build with errors mentioned above.
