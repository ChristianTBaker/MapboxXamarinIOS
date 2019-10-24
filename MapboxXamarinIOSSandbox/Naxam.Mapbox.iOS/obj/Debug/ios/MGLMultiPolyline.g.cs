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
	[Register("MGLMultiPolyline", true)]
	public unsafe partial class MGLMultiPolyline : MGLShape, IMGLAnnotation, IMGLOverlay {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMultiPolyline");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMultiPolyline () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MGLMultiPolyline (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLMultiPolyline (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMultiPolyline (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("intersectsOverlayBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IntersectsOverlayBounds (MGLCoordinateBounds overlayBounds)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_MGLCoordinateBounds (this.Handle, Selector.GetHandle ("intersectsOverlayBounds:"), overlayBounds);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_MGLCoordinateBounds (this.SuperHandle, Selector.GetHandle ("intersectsOverlayBounds:"), overlayBounds);
			}
		}
		
		[Export ("multiPolylineWithPolylines:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLMultiPolyline MultiPolylineWithPolylines (MGLPolyline[] polylines)
		{
			if (polylines == null)
				throw new ArgumentNullException ("polylines");
			var nsa_polylines = NSArray.FromNSObjects (polylines);
			
			MGLMultiPolyline ret;
			ret =  Runtime.GetNSObject<MGLMultiPolyline> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("multiPolylineWithPolylines:"), nsa_polylines.Handle));
			nsa_polylines.Dispose ();
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("coordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("coordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinate"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coordinate"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCoordinateBounds OverlayBounds {
			[Export ("overlayBounds")]
			get {
				MGLCoordinateBounds ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend (this.Handle, Selector.GetHandle ("overlayBounds"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("overlayBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("overlayBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("overlayBounds"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("overlayBounds"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("overlayBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("overlayBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("overlayBounds"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLPolyline[] Polylines {
			[Export ("polylines", ArgumentSemantic.Copy)]
			get {
				MGLPolyline[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MGLPolyline>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("polylines")));
				} else {
					ret = NSArray.ArrayFromHandle<MGLPolyline>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("polylines")));
				}
				return ret;
			}
			
		}
		
	} /* class MGLMultiPolyline */
}
