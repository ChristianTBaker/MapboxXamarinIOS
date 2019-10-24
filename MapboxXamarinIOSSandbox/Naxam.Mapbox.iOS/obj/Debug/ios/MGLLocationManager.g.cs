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
	[Protocol (Name = "MGLLocationManager", WrapperType = typeof (MGLLocationManagerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestAlwaysAuthorization", Selector = "requestAlwaysAuthorization")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestWhenInUseAuthorization", Selector = "requestWhenInUseAuthorization")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartUpdatingLocation", Selector = "startUpdatingLocation")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StopUpdatingLocation", Selector = "stopUpdatingLocation")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartUpdatingHeading", Selector = "startUpdatingHeading")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StopUpdatingHeading", Selector = "stopUpdatingHeading")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DismissHeadingCalibrationDisplay", Selector = "dismissHeadingCalibrationDisplay")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DistanceFilter", Selector = "distanceFilter", PropertyType = typeof (double), GetterSelector = "distanceFilter", SetterSelector = "setDistanceFilter:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "desiredAccuracy", Selector = "desiredAccuracy", PropertyType = typeof (double), GetterSelector = "desiredAccuracy", SetterSelector = "setDesiredAccuracy:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ActivityType", Selector = "activityType", PropertyType = typeof (CLActivityType), GetterSelector = "activityType", SetterSelector = "setActivityType:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Delegate", Selector = "delegate", PropertyType = typeof (Mapbox.MGLLocationManagerDelegate), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AuthorizationStatus", Selector = "authorizationStatus", PropertyType = typeof (CLAuthorizationStatus), GetterSelector = "authorizationStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HeadingOrientation", Selector = "headingOrientation", PropertyType = typeof (CLDeviceOrientation), GetterSelector = "headingOrientation", SetterSelector = "setHeadingOrientation:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLLocationManager : INativeObject, IDisposable
	{
	}
	
	public static partial class MGLLocationManager_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RequestAlwaysAuthorization (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("requestAlwaysAuthorization"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RequestWhenInUseAuthorization (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("requestWhenInUseAuthorization"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartUpdatingLocation (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("startUpdatingLocation"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopUpdatingLocation (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stopUpdatingLocation"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartUpdatingHeading (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("startUpdatingHeading"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopUpdatingHeading (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stopUpdatingHeading"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DismissHeadingCalibrationDisplay (this IMGLLocationManager This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dismissHeadingCalibrationDisplay"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetDistanceFilter (this IMGLLocationManager This)
		{
			return global::ApiDefinitions.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("distanceFilter"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDistanceFilter (this IMGLLocationManager This, double value)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setDistanceFilter:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetdesiredAccuracy (this IMGLLocationManager This)
		{
			return global::ApiDefinitions.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("desiredAccuracy"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetdesiredAccuracy (this IMGLLocationManager This, double value)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setDesiredAccuracy:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreLocation.CLActivityType GetActivityType (this IMGLLocationManager This)
		{
			global::CoreLocation.CLActivityType ret;
			if (IntPtr.Size == 8) {
				ret = (global::CoreLocation.CLActivityType) global::ApiDefinitions.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("activityType"));
			} else {
				ret = (global::CoreLocation.CLActivityType) global::ApiDefinitions.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("activityType"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetActivityType (this IMGLLocationManager This, global::CoreLocation.CLActivityType value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setActivityType:"), (Int64)value);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setActivityType:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLLocationManagerDelegate GetDelegate (this IMGLLocationManager This)
		{
			return  Runtime.GetNSObject<MGLLocationManagerDelegate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDelegate (this IMGLLocationManager This, MGLLocationManagerDelegate value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreLocation.CLAuthorizationStatus GetAuthorizationStatus (this IMGLLocationManager This)
		{
			return (global::CoreLocation.CLAuthorizationStatus) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("authorizationStatus"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreLocation.CLDeviceOrientation GetHeadingOrientation (this IMGLLocationManager This)
		{
			return (global::CoreLocation.CLDeviceOrientation) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("headingOrientation"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetHeadingOrientation (this IMGLLocationManager This, global::CoreLocation.CLDeviceOrientation value)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("setHeadingOrientation:"), (UInt32)value);
		}
		
	}
	
	internal sealed class MGLLocationManagerWrapper : BaseWrapper, IMGLLocationManager {
		[Preserve (Conditional = true)]
		public MGLLocationManagerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLLocationManager", false)]
	[Model]
	public unsafe partial class MGLLocationManager : NSObject, IMGLLocationManager {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLLocationManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLLocationManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLLocationManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("dismissHeadingCalibrationDisplay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissHeadingCalibrationDisplay ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("requestAlwaysAuthorization")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestAlwaysAuthorization ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("requestWhenInUseAuthorization")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestWhenInUseAuthorization ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("startUpdatingHeading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartUpdatingHeading ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("startUpdatingLocation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartUpdatingLocation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stopUpdatingHeading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopUpdatingHeading ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stopUpdatingLocation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopUpdatingLocation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLActivityType ActivityType {
			[Export ("activityType", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setActivityType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLAuthorizationStatus AuthorizationStatus {
			[Export ("authorizationStatus")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLLocationManagerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DistanceFilter {
			[Export ("distanceFilter")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDistanceFilter:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLDeviceOrientation HeadingOrientation {
			[Export ("headingOrientation")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setHeadingOrientation:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double desiredAccuracy {
			[Export ("desiredAccuracy")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDesiredAccuracy:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class MGLLocationManager */
}
