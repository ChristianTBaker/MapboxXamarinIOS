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
	[Register("MGLImageSource", true)]
	public unsafe partial class MGLImageSource : MGLSource {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLImageSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLImageSource () : base (NSObjectFlag.Empty)
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
		protected MGLImageSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLImageSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:coordinateQuad:URL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLImageSource (string identifier, MGLCoordinateQuad coordinateQuad, NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_MGLCoordinateQuad_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:coordinateQuad:URL:"), nsidentifier, coordinateQuad, url.Handle), "initWithIdentifier:coordinateQuad:URL:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_MGLCoordinateQuad_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:coordinateQuad:URL:"), nsidentifier, coordinateQuad, url.Handle), "initWithIdentifier:coordinateQuad:URL:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithIdentifier:coordinateQuad:image:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLImageSource (string identifier, MGLCoordinateQuad coordinateQuad, global::UIKit.UIImage image)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (image == null)
				throw new ArgumentNullException ("image");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_MGLCoordinateQuad_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:coordinateQuad:image:"), nsidentifier, coordinateQuad, image.Handle), "initWithIdentifier:coordinateQuad:image:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_MGLCoordinateQuad_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:coordinateQuad:image:"), nsidentifier, coordinateQuad, image.Handle), "initWithIdentifier:coordinateQuad:image:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCoordinateQuad Coordinates {
			[Export ("coordinates", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLCoordinateQuad ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend (this.Handle, Selector.GetHandle ("coordinates"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinates"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinates"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinates"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coordinates"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinates"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinates"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinates"));
					}
				}
				return ret;
			}
			
			[Export ("setCoordinates:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLCoordinateQuad (this.Handle, Selector.GetHandle ("setCoordinates:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLCoordinateQuad (this.SuperHandle, Selector.GetHandle ("setCoordinates:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("image")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("image")));
				}
				return ret;
			}
			
			[Export ("setImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl URL {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("URL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("URL")));
				}
				return ret;
			}
			
			[Export ("setURL:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setURL:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setURL:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class MGLImageSource */
}
