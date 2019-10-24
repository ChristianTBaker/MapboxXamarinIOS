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
	[Register("MGLPolygon", true)]
	public unsafe partial class MGLPolygon : MGLMultiPoint, IMGLAnnotation, IMGLOverlay {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLPolygon");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLPolygon () : base (NSObjectFlag.Empty)
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
		public MGLPolygon (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLPolygon (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLPolygon (IntPtr handle) : base (handle)
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
		
		[Export ("polygonWithCoordinates:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLPolygon PolygonWithCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count)
		{
			return  Runtime.GetNSObject<MGLPolygon> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_ref_CLLocationCoordinate2D_nuint (class_ptr, Selector.GetHandle ("polygonWithCoordinates:count:"), ref coords, count));
		}
		
		[Export ("polygonWithCoordinates:count:interiorPolygons:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLPolygon PolygonWithCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count, MGLPolygon[] interiorPolygons)
		{
			var nsa_interiorPolygons = interiorPolygons == null ? null : NSArray.FromNSObjects (interiorPolygons);
			
			MGLPolygon ret;
			ret =  Runtime.GetNSObject<MGLPolygon> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_ref_CLLocationCoordinate2D_nuint_IntPtr (class_ptr, Selector.GetHandle ("polygonWithCoordinates:count:interiorPolygons:"), ref coords, count, nsa_interiorPolygons == null ? IntPtr.Zero : nsa_interiorPolygons.Handle));
			if (nsa_interiorPolygons != null)
				nsa_interiorPolygons.Dispose ();
			
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
		public virtual MGLPolygon[] InteriorPolygons {
			[Export ("interiorPolygons")]
			get {
				MGLPolygon[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MGLPolygon>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("interiorPolygons")));
				} else {
					ret = NSArray.ArrayFromHandle<MGLPolygon>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("interiorPolygons")));
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
		public virtual string Subtitle {
			[Export ("subtitle")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subtitle")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subtitle")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
		}
		
	} /* class MGLPolygon */
}
