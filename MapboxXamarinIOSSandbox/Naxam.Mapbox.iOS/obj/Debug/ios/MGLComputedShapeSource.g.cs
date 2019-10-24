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
	[Register("MGLComputedShapeSource", true)]
	public unsafe partial class MGLComputedShapeSource : MGLSource {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLComputedShapeSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLComputedShapeSource () : base (NSObjectFlag.Empty)
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
		protected MGLComputedShapeSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLComputedShapeSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLComputedShapeSource (string identifier, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:options:"), nsidentifier, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:options:"), nsidentifier, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithIdentifier:dataSource:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLComputedShapeSource (string identifier, IMGLComputedShapeSourceDataSource dataSource, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (dataSource == null)
				throw new ArgumentNullException ("dataSource");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:dataSource:options:"), nsidentifier, dataSource.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:dataSource:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:dataSource:options:"), nsidentifier, dataSource.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:dataSource:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("invalidateBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateBounds (MGLCoordinateBounds bounds)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_MGLCoordinateBounds (this.Handle, Selector.GetHandle ("invalidateBounds:"), bounds);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLCoordinateBounds (this.SuperHandle, Selector.GetHandle ("invalidateBounds:"), bounds);
			}
		}
		
		[Export ("invalidateTileAtX:y:zoomLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateTileAtX (nuint x, nuint y, nuint zoomLevel)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("invalidateTileAtX:y:zoomLevel:"), x, y, zoomLevel);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("invalidateTileAtX:y:zoomLevel:"), x, y, zoomLevel);
			}
		}
		
		[Export ("setFeatures:inTileAtX:y:zoomLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFeatures (NSObject[] features, nuint x, nuint y, nuint zoomLevel)
		{
			if (features == null)
				throw new ArgumentNullException ("features");
			var nsa_features = NSArray.FromNSObjects (features);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("setFeatures:inTileAtX:y:zoomLevel:"), nsa_features.Handle, x, y, zoomLevel);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("setFeatures:inTileAtX:y:zoomLevel:"), nsa_features.Handle, x, y, zoomLevel);
			}
			nsa_features.Dispose ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOperationQueue RequestQueue {
			[Export ("requestQueue")]
			get {
				NSOperationQueue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("requestQueue")));
				} else {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestQueue")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataSource")));
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret;
			}
			
			[Export ("setDataSource:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataSource:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataSource:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDataSource_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDataSource_var = null;
			}
		}
	} /* class MGLComputedShapeSource */
}
