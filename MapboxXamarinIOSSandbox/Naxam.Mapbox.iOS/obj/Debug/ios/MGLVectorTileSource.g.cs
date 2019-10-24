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
	[Register("MGLVectorTileSource", true)]
	public unsafe partial class MGLVectorTileSource : MGLTileSource {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLVectorTileSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLVectorTileSource () : base (NSObjectFlag.Empty)
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
		protected MGLVectorTileSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLVectorTileSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:configurationURL:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLVectorTileSource (string identifier, NSUrl configurationURL)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (configurationURL == null)
				throw new ArgumentNullException ("configurationURL");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:configurationURL:"), nsidentifier, configurationURL.Handle), "initWithIdentifier:configurationURL:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:configurationURL:"), nsidentifier, configurationURL.Handle), "initWithIdentifier:configurationURL:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithIdentifier:tileURLTemplates:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLVectorTileSource (string identifier, string[] tileURLTemplates, NSDictionary<NSString, NSObject> options)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (tileURLTemplates == null)
				throw new ArgumentNullException ("tileURLTemplates");
			var nsidentifier = NSString.CreateNative (identifier);
			var nsa_tileURLTemplates = NSArray.FromStrings (tileURLTemplates);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:tileURLTemplates:options:"), nsidentifier, nsa_tileURLTemplates.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:tileURLTemplates:options:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:tileURLTemplates:options:"), nsidentifier, nsa_tileURLTemplates.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithIdentifier:tileURLTemplates:options:");
			}
			NSString.ReleaseNative (nsidentifier);
			nsa_tileURLTemplates.Dispose ();
			
		}
		
		[Export ("featuresInSourceLayersWithIdentifiers:predicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] FeaturesInSourceLayersWithIdentifiers (NSSet<NSString> sourceLayerIdentifiers, NSPredicate predicate)
		{
			if (sourceLayerIdentifiers == null)
				throw new ArgumentNullException ("sourceLayerIdentifiers");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("featuresInSourceLayersWithIdentifiers:predicate:"), sourceLayerIdentifiers.Handle, predicate == null ? IntPtr.Zero : predicate.Handle));
			} else {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("featuresInSourceLayersWithIdentifiers:predicate:"), sourceLayerIdentifiers.Handle, predicate == null ? IntPtr.Zero : predicate.Handle));
			}
		}
		
	} /* class MGLVectorTileSource */
}
