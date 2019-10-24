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
	[Register("MGLMapSnapshotter", true)]
	public unsafe partial class MGLMapSnapshotter : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapSnapshotter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapSnapshotter () : base (NSObjectFlag.Empty)
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
		protected MGLMapSnapshotter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapSnapshotter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithOptions:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLMapSnapshotter (MGLMapSnapshotOptions options)
			: base (NSObjectFlag.Empty)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithOptions:"), options.Handle), "initWithOptions:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithOptions:"), options.Handle), "initWithOptions:");
			}
		}
		
		[Export ("cancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancel"));
			}
		}
		
		[Export ("coordinateForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D CoordinateForPoint (CGPoint point)
		{
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("coordinateForPoint:"), point);
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("coordinateForPoint:"), point);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("coordinateForPoint:"), point);
				} else {
					global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("coordinateForPoint:"), point);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("coordinateForPoint:"), point);
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("coordinateForPoint:"), point);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("coordinateForPoint:"), point);
				} else {
					global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("coordinateForPoint:"), point);
				}
			}
			return ret;
		}
		
		[Export ("startWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLMapSnapshotCompletionHandler))]MGLMapSnapshotCompletionHandler completionHandler)
		{
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDMGLMapSnapshotCompletionHandler.Handler, completionHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("startWithOverlayHandler:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartWithOverlayHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLMapSnapshotOverlayHandler))]MGLMapSnapshotOverlayHandler overlayHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLMapSnapshotCompletionHandler))]MGLMapSnapshotCompletionHandler completionHandler)
		{
			if (overlayHandler == null)
				throw new ArgumentNullException ("overlayHandler");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_overlayHandler;
			BlockLiteral block_overlayHandler;
			block_overlayHandler = new BlockLiteral ();
			block_ptr_overlayHandler = &block_overlayHandler;
			block_overlayHandler.SetupBlockUnsafe (Trampolines.SDMGLMapSnapshotOverlayHandler.Handler, overlayHandler);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDMGLMapSnapshotCompletionHandler.Handler, completionHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startWithOverlayHandler:completionHandler:"), (IntPtr) block_ptr_overlayHandler, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startWithOverlayHandler:completionHandler:"), (IntPtr) block_ptr_overlayHandler, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_overlayHandler->CleanupBlock ();
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("startWithQueue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartWithQueue (global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLMapSnapshotCompletionHandler))]MGLMapSnapshotCompletionHandler completionHandler)
		{
			if (queue == null)
				throw new ArgumentNullException ("queue");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDMGLMapSnapshotCompletionHandler.Handler, completionHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startWithQueue:completionHandler:"), queue.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startWithQueue:completionHandler:"), queue.Handle, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Loading {
			[Export ("isLoading")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLoading"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLoading"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Options_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapSnapshotOptions Options {
			[Export ("options", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLMapSnapshotOptions ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLMapSnapshotOptions> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("options")));
				} else {
					ret =  Runtime.GetNSObject<MGLMapSnapshotOptions> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("options")));
				}
				MarkDirty ();
				__mt_Options_var = ret;
				return ret;
			}
			
			[Export ("setOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOptions:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOptions:"), value.Handle);
				}
				MarkDirty ();
				__mt_Options_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Options_var = null;
			}
		}
	} /* class MGLMapSnapshotter */
}
