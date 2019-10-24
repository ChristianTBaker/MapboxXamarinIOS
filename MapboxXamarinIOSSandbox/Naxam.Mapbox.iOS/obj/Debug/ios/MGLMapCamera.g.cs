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
	[Register("MGLMapCamera", true)]
	public unsafe partial class MGLMapCamera : NSObject, INSCoding, INSCopying, INSSecureCoding {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapCamera");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapCamera () : base (NSObjectFlag.Empty)
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
		public MGLMapCamera (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLMapCamera (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapCamera (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("camera")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLMapCamera Camera ()
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("camera")));
		}
		
		[Export ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLMapCamera CameraLookingAtCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, global::CoreLocation.CLLocationCoordinate2D eyeCoordinate, double eyeAltitude)
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D_Double (class_ptr, Selector.GetHandle ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:"), centerCoordinate, eyeCoordinate, eyeAltitude));
		}
		
		[Export ("cameraLookingAtCenterCoordinate:acrossDistance:pitch:heading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLMapCamera CameraLookingAtCenterCoordinateAndAcrossDistance (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, double acrossDistance, nfloat pitch, double heading)
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_nfloat_Double (class_ptr, Selector.GetHandle ("cameraLookingAtCenterCoordinate:acrossDistance:pitch:heading:"), centerCoordinate, acrossDistance, pitch, heading));
		}
		
		[Export ("cameraLookingAtCenterCoordinate:altitude:pitch:heading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLMapCamera CameraLookingAtCenterCoordinateAndAltitude (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, double altitude, nfloat pitch, double heading)
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_nfloat_Double (class_ptr, Selector.GetHandle ("cameraLookingAtCenterCoordinate:altitude:pitch:heading:"), centerCoordinate, altitude, pitch, heading));
		}
		
		[Export ("copyWithZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual NSObject Copy (NSZone zone)
		{
			if (zone == null)
				throw new ArgumentNullException ("zone");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			}
		}
		
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException ("encoder");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			}
		}
		
		[Export ("isEqualToMapCamera:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualToMapCamera (MGLMapCamera otherCamera)
		{
			if (otherCamera == null)
				throw new ArgumentNullException ("otherCamera");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToMapCamera:"), otherCamera.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToMapCamera:"), otherCamera.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Altitude {
			[Export ("altitude")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("altitude"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("altitude"));
				}
			}
			
			[Export ("setAltitude:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setAltitude:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setAltitude:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D CenterCoordinate {
			[Export ("centerCoordinate", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					}
				}
				return ret;
			}
			
			[Export ("setCenterCoordinate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("setCenterCoordinate:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Heading {
			[Export ("heading")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("heading"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heading"));
				}
			}
			
			[Export ("setHeading:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setHeading:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setHeading:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Pitch {
			[Export ("pitch")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pitch"));
				} else {
					return global::ApiDefinitions.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pitch"));
				}
			}
			
			[Export ("setPitch:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPitch:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPitch:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ViewingDistance {
			[Export ("viewingDistance")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("viewingDistance"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewingDistance"));
				}
			}
			
			[Export ("setViewingDistance:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setViewingDistance:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setViewingDistance:"), value);
				}
			}
		}
		
	} /* class MGLMapCamera */
}
