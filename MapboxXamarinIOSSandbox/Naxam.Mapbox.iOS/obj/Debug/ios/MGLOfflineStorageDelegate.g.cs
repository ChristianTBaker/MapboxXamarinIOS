//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace Mapbox {
	[Protocol (Name = "MGLOfflineStorageDelegate", WrapperType = typeof (MGLOfflineStorageDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "URLForResourceOfKind", Selector = "offlineStorage:URLForResourceOfKind:withURL:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (Mapbox.MGLOfflineStorage), typeof (Mapbox.MGLResourceKind), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IMGLOfflineStorageDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("offlineStorage:URLForResourceOfKind:withURL:")]
		[Preserve (Conditional = true)]
		NSUrl URLForResourceOfKind (MGLOfflineStorage storage, MGLResourceKind kind, NSUrl url);
		
	}
	
	internal sealed class MGLOfflineStorageDelegateWrapper : BaseWrapper, IMGLOfflineStorageDelegate {
		[Preserve (Conditional = true)]
		public MGLOfflineStorageDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("offlineStorage:URLForResourceOfKind:withURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl URLForResourceOfKind (MGLOfflineStorage storage, MGLResourceKind kind, NSUrl url)
		{
			if (storage == null)
				throw new ArgumentNullException ("storage");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("offlineStorage:URLForResourceOfKind:withURL:"), storage.Handle, (UInt64)kind, url.Handle));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("offlineStorage:URLForResourceOfKind:withURL:"), storage.Handle, (UInt32)kind, url.Handle));
			}
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLOfflineStorageDelegate", false)]
	[Model]
	public unsafe abstract partial class MGLOfflineStorageDelegate : NSObject, IMGLOfflineStorageDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MGLOfflineStorageDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLOfflineStorageDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLOfflineStorageDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("offlineStorage:URLForResourceOfKind:withURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract NSUrl URLForResourceOfKind (MGLOfflineStorage storage, MGLResourceKind kind, NSUrl url);
	} /* class MGLOfflineStorageDelegate */
}
