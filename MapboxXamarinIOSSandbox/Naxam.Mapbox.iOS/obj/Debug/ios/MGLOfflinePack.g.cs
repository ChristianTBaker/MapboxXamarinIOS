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
	[Register("MGLOfflinePack", true)]
	public unsafe partial class MGLOfflinePack : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLOfflinePack");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLOfflinePack () : base (NSObjectFlag.Empty)
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
		protected MGLOfflinePack (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLOfflinePack (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("requestProgress")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestProgress ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestProgress"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestProgress"));
			}
		}
		
		[Export ("resume")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resume"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resume"));
			}
		}
		
		[Export ("suspend")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Suspend ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("suspend"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("suspend"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData Context {
			[Export ("context")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("context")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("context")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOfflinePackProgress Progress {
			[Export ("progress")]
			get {
				MGLOfflinePackProgress ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend (this.Handle, Selector.GetHandle ("progress"));
						} else {
							global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("progress"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("progress"));
					} else {
						global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("progress"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progress"));
						} else {
							global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("progress"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("progress"));
					} else {
						global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("progress"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLOfflineRegion Region {
			[Export ("region")]
			get {
				IMGLOfflineRegion ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMGLOfflineRegion> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("region")), false);
				} else {
					ret =  Runtime.GetINativeObject<IMGLOfflineRegion> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("region")), false);
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOfflinePackState State {
			[Export ("state")]
			get {
				MGLOfflinePackState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLOfflinePackState) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					} else {
						ret = (MGLOfflinePackState) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLOfflinePackState) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					} else {
						ret = (MGLOfflinePackState) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					}
				}
				return ret;
			}
			
		}
		
	} /* class MGLOfflinePack */
}
