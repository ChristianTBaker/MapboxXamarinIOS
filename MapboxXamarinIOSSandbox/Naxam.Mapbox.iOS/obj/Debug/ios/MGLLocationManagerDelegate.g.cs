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
	[Protocol (Name = "MGLLocationManagerDelegate", WrapperType = typeof (MGLLocationManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateLocations", Selector = "locationManager:didUpdateLocations:", ParameterType = new Type [] { typeof (Mapbox.MGLLocationManager), typeof (CLLocation[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateHeading", Selector = "locationManager:didUpdateHeading:", ParameterType = new Type [] { typeof (Mapbox.MGLLocationManager), typeof (CLHeading) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDisplayHeadingCalibration", Selector = "locationManagerShouldDisplayHeadingCalibration:", ParameterType = new Type [] { typeof (Mapbox.MGLLocationManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailWithError", Selector = "locationManager:didFailWithError:", ParameterType = new Type [] { typeof (Mapbox.MGLLocationManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public interface IMGLLocationManagerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MGLLocationManagerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateLocations (this IMGLLocationManagerDelegate This, MGLLocationManager manager, global::CoreLocation.CLLocation[] locations)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (locations == null)
				throw new ArgumentNullException ("locations");
			var nsa_locations = NSArray.FromNSObjects (locations);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("locationManager:didUpdateLocations:"), manager.Handle, nsa_locations.Handle);
			nsa_locations.Dispose ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateHeading (this IMGLLocationManagerDelegate This, MGLLocationManager manager, global::CoreLocation.CLHeading newHeading)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (newHeading == null)
				throw new ArgumentNullException ("newHeading");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("locationManager:didUpdateHeading:"), manager.Handle, newHeading.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShouldDisplayHeadingCalibration (this IMGLLocationManagerDelegate This, MGLLocationManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("locationManagerShouldDisplayHeadingCalibration:"), manager.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailWithError (this IMGLLocationManagerDelegate This, MGLLocationManager manager, NSError error)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("locationManager:didFailWithError:"), manager.Handle, error.Handle);
		}
		
	}
	
	internal sealed class MGLLocationManagerDelegateWrapper : BaseWrapper, IMGLLocationManagerDelegate {
		[Preserve (Conditional = true)]
		public MGLLocationManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLLocationManagerDelegate", false)]
	[Model]
	public unsafe partial class MGLLocationManagerDelegate : NSObject, IMGLLocationManagerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLLocationManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLLocationManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLLocationManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("locationManager:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailWithError (MGLLocationManager manager, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("locationManager:didUpdateHeading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateHeading (MGLLocationManager manager, global::CoreLocation.CLHeading newHeading)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("locationManager:didUpdateLocations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateLocations (MGLLocationManager manager, global::CoreLocation.CLLocation[] locations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShouldDisplayHeadingCalibration (MGLLocationManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MGLLocationManagerDelegate */
}
