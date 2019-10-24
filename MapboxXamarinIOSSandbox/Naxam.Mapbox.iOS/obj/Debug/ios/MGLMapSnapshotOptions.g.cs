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
	[Register("MGLMapSnapshotOptions", true)]
	public unsafe partial class MGLMapSnapshotOptions : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapSnapshotOptions");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapSnapshotOptions () : base (NSObjectFlag.Empty)
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
		protected MGLMapSnapshotOptions (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapSnapshotOptions (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithStyleURL:camera:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLMapSnapshotOptions (NSUrl styleURL, MGLMapCamera camera, CGSize size)
			: base (NSObjectFlag.Empty)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize (this.Handle, Selector.GetHandle ("initWithStyleURL:camera:size:"), styleURL == null ? IntPtr.Zero : styleURL.Handle, camera.Handle, size), "initWithStyleURL:camera:size:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGSize (this.SuperHandle, Selector.GetHandle ("initWithStyleURL:camera:size:"), styleURL == null ? IntPtr.Zero : styleURL.Handle, camera.Handle, size), "initWithStyleURL:camera:size:");
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Camera_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera Camera {
			[Export ("camera", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLMapCamera ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("camera")));
				} else {
					ret =  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("camera")));
				}
				MarkDirty ();
				__mt_Camera_var = ret;
				return ret;
			}
			
			[Export ("setCamera:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCamera:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:"), value.Handle);
				}
				MarkDirty ();
				__mt_Camera_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCoordinateBounds CoordinateBounds {
			[Export ("coordinateBounds", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLCoordinateBounds ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend (this.Handle, Selector.GetHandle ("coordinateBounds"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinateBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinateBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinateBounds"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coordinateBounds"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinateBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinateBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinateBounds"));
					}
				}
				return ret;
			}
			
			[Export ("setCoordinateBounds:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLCoordinateBounds (this.Handle, Selector.GetHandle ("setCoordinateBounds:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLCoordinateBounds (this.SuperHandle, Selector.GetHandle ("setCoordinateBounds:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Scale {
			[Export ("scale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("scale"));
				} else {
					return global::ApiDefinitions.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scale"));
				}
			}
			
			[Export ("setScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setScale:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize Size {
			[Export ("size")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
						} else {
							global::ApiDefinitions.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("size"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("size"));
						} else {
							global::ApiDefinitions.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("size"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("size"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("size"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl StyleURL {
			[Export ("styleURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleURL")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ZoomLevel {
			[Export ("zoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("zoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomLevel"));
				}
			}
			
			[Export ("setZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setZoomLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setZoomLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Camera_var = null;
			}
		}
	} /* class MGLMapSnapshotOptions */
}
