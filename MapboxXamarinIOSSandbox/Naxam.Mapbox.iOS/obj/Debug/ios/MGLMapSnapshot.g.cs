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
	[Register("MGLMapSnapshot", true)]
	public unsafe partial class MGLMapSnapshot : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapSnapshot");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapSnapshot () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLMapSnapshot (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapSnapshot (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("pointForCoordinate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint PointForCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
					} else {
						global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret_CLLocationCoordinate2D (out ret, this.Handle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
				} else {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
					} else {
						global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret_CLLocationCoordinate2D (out ret, this.SuperHandle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
				} else {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("pointForCoordinate:"), coordinate);
				}
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage Image {
			[Export ("image")]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("image")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("image")));
				}
				return ret;
			}
			
		}
		
	} /* class MGLMapSnapshot */
}
