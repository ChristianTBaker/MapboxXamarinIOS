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
	[Register("MGLOpenGLStyleLayer", true)]
	public unsafe partial class MGLOpenGLStyleLayer : MGLStyleLayer {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLOpenGLStyleLayer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLOpenGLStyleLayer () : base (NSObjectFlag.Empty)
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
		protected MGLOpenGLStyleLayer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLOpenGLStyleLayer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLOpenGLStyleLayer (string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:"), nsidentifier), "initWithIdentifier:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:"), nsidentifier), "initWithIdentifier:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("didMoveToMapView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMoveToMapView (MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didMoveToMapView:"), mapView.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didMoveToMapView:"), mapView.Handle);
			}
		}
		
		[Export ("drawInMapView:withContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawInMapView (MGLMapView mapView, MGLStyleLayerDrawingContext context)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_MGLStyleLayerDrawingContext (this.Handle, Selector.GetHandle ("drawInMapView:withContext:"), mapView.Handle, context);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_MGLStyleLayerDrawingContext (this.SuperHandle, Selector.GetHandle ("drawInMapView:withContext:"), mapView.Handle, context);
			}
		}
		
		[Export ("setNeedsDisplay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsDisplay"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNeedsDisplay"));
			}
		}
		
		[Export ("willMoveFromMapView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMoveFromMapView (MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("willMoveFromMapView:"), mapView.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("willMoveFromMapView:"), mapView.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::OpenGLES.EAGLContext Context {
			[Export ("context")]
			get {
				global::OpenGLES.EAGLContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::OpenGLES.EAGLContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("context")));
				} else {
					ret =  Runtime.GetNSObject<global::OpenGLES.EAGLContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("context")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Style_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLStyle Style {
			[Export ("style", ArgumentSemantic.Weak)]
			get {
				MGLStyle ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLStyle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("style")));
				} else {
					ret =  Runtime.GetNSObject<MGLStyle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("style")));
				}
				MarkDirty ();
				__mt_Style_var = ret;
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Style_var = null;
			}
		}
	} /* class MGLOpenGLStyleLayer */
}
