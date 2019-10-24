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
	[Register("MGLShapeSource", true)]
	public unsafe partial class MGLShapeSource : MGLSource {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLShapeSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLShapeSource () : base (NSObjectFlag.Empty)
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
		protected MGLShapeSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLShapeSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:URL:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLShapeSource (string identifier, NSUrl url, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:URL:options:"), nsidentifier, url.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:URL:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:URL:options:"), nsidentifier, url.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:URL:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithIdentifier:shape:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLShapeSource (string identifier, MGLShape shape, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:shape:options:"), nsidentifier, shape == null ? IntPtr.Zero : shape.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:shape:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:shape:options:"), nsidentifier, shape == null ? IntPtr.Zero : shape.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:shape:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithIdentifier:features:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLShapeSource (string identifier, NSObject[] features, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (features == null)
				throw new ArgumentNullException ("features");
			var nsidentifier = NSString.CreateNative (identifier);
			var nsa_features = NSArray.FromNSObjects (features);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:features:options:"), nsidentifier, nsa_features.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:features:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:features:options:"), nsidentifier, nsa_features.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:features:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			nsa_features.Dispose ();
			
		}
		
		[Export ("initWithIdentifier:shapes:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLShapeSource (string identifier, MGLShape[] shapes, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (shapes == null)
				throw new ArgumentNullException ("shapes");
			var nsidentifier = NSString.CreateNative (identifier);
			var nsa_shapes = NSArray.FromNSObjects (shapes);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:shapes:options:"), nsidentifier, nsa_shapes.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:shapes:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:shapes:options:"), nsidentifier, nsa_shapes.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:shapes:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			nsa_shapes.Dispose ();
			
		}
		
		[Export ("childrenOfCluster:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] ChildrenOfCluster (MGLPointFeatureCluster cluster)
		{
			if (cluster == null)
				throw new ArgumentNullException ("cluster");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("childrenOfCluster:"), cluster.Handle));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("childrenOfCluster:"), cluster.Handle));
			}
		}
		
		[Export ("featuresMatchingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] FeaturesMatchingPredicate (NSPredicate predicate)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("featuresMatchingPredicate:"), predicate == null ? IntPtr.Zero : predicate.Handle));
			} else {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("featuresMatchingPredicate:"), predicate == null ? IntPtr.Zero : predicate.Handle));
			}
		}
		
		[Export ("leavesOfCluster:offset:limit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] LeavesOfCluster (MGLPointFeatureCluster cluster, nuint offset, nuint limit)
		{
			if (cluster == null)
				throw new ArgumentNullException ("cluster");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint (this.Handle, Selector.GetHandle ("leavesOfCluster:offset:limit:"), cluster.Handle, offset, limit));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint (this.SuperHandle, Selector.GetHandle ("leavesOfCluster:offset:limit:"), cluster.Handle, offset, limit));
			}
		}
		
		[Export ("zoomLevelForExpandingCluster:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ZoomLevelForExpandingCluster (MGLPointFeatureCluster cluster)
		{
			if (cluster == null)
				throw new ArgumentNullException ("cluster");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("zoomLevelForExpandingCluster:"), cluster.Handle);
			} else {
				return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("zoomLevelForExpandingCluster:"), cluster.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLShape Shape {
			[Export ("shape", ArgumentSemantic.Copy)]
			get {
				MGLShape ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLShape> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shape")));
				} else {
					ret =  Runtime.GetNSObject<MGLShape> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shape")));
				}
				return ret;
			}
			
			[Export ("setShape:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShape:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShape:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl URL {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("URL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("URL")));
				}
				return ret;
			}
			
			[Export ("setURL:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setURL:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setURL:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class MGLShapeSource */
}
