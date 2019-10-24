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
	[Register("MGLUserLocationAnnotationView", true)]
	public unsafe partial class MGLUserLocationAnnotationView : MGLAnnotationView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLUserLocationAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLUserLocationAnnotationView () : base (NSObjectFlag.Empty)
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
		public MGLUserLocationAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLUserLocationAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLUserLocationAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("update")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("update"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("update"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_HitTestLayer_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CALayer HitTestLayer {
			[Export ("hitTestLayer", ArgumentSemantic.Weak)]
			get {
				global::CoreAnimation.CALayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hitTestLayer")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hitTestLayer")));
				}
				MarkDirty ();
				__mt_HitTestLayer_var = ret;
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_MapView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapView MapView {
			[Export ("mapView", ArgumentSemantic.Weak)]
			get {
				MGLMapView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLMapView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mapView")));
				} else {
					ret =  Runtime.GetNSObject<MGLMapView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mapView")));
				}
				MarkDirty ();
				__mt_MapView_var = ret;
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_UserLocation_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLUserLocation UserLocation {
			[Export ("userLocation", ArgumentSemantic.Weak)]
			get {
				MGLUserLocation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLUserLocation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userLocation")));
				} else {
					ret =  Runtime.GetNSObject<MGLUserLocation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLocation")));
				}
				MarkDirty ();
				__mt_UserLocation_var = ret;
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_HitTestLayer_var = null;
				__mt_MapView_var = null;
				__mt_UserLocation_var = null;
			}
		}
		public partial class MGLUserLocationAnnotationViewAppearance : global::Mapbox.MGLAnnotationView.MGLAnnotationViewAppearance {
			protected internal MGLUserLocationAnnotationViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MGLUserLocationAnnotationViewAppearance Appearance {
			get { return new MGLUserLocationAnnotationViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MGLUserLocationAnnotationViewAppearance GetAppearance<T> () where T: MGLUserLocationAnnotationView {
			return new MGLUserLocationAnnotationViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MGLUserLocationAnnotationViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MGLUserLocationAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MGLUserLocationAnnotationViewAppearance GetAppearance (UITraitCollection traits) {
			return new MGLUserLocationAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MGLUserLocationAnnotationViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MGLUserLocationAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MGLUserLocationAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MGLUserLocationAnnotationView {
			return new MGLUserLocationAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MGLUserLocationAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MGLUserLocationAnnotationView{
			return new MGLUserLocationAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MGLUserLocationAnnotationView */
}
