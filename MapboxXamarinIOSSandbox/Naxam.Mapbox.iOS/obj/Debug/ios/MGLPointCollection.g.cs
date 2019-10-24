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
	[Register("MGLPointCollection", true)]
	public unsafe partial class MGLPointCollection : MGLShape, IMGLAnnotation, IMGLOverlay {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLPointCollection");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLPointCollection () : base (NSObjectFlag.Empty)
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
		public MGLPointCollection (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLPointCollection (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLPointCollection (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("getCoordinates:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, NSRange range)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_NSRange (this.Handle, Selector.GetHandle ("getCoordinates:range:"), ref coords, range);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_NSRange (this.SuperHandle, Selector.GetHandle ("getCoordinates:range:"), ref coords, range);
			}
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
		
		[Export ("pointCollectionWithCoordinates:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLPointCollection PointCollectionWithCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count)
		{
			return  Runtime.GetNSObject<MGLPointCollection> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_ref_CLLocationCoordinate2D_nuint (class_ptr, Selector.GetHandle ("pointCollectionWithCoordinates:count:"), ref coords, count));
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
		public virtual NSArray Coordinates {
			[Export ("coordinates")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("coordinates")));
				} else {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coordinates")));
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
		public virtual nuint PointCount {
			[Export ("pointCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pointCount"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pointCount"));
				}
			}
			
		}
		
	} /* class MGLPointCollection */
}
