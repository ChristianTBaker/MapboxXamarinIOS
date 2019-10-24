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
	[Register("MGLShapeOfflineRegion", true)]
	public unsafe partial class MGLShapeOfflineRegion : NSObject, IMGLOfflineRegion, INSCoding, INSCopying, INSSecureCoding {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLShapeOfflineRegion");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLShapeOfflineRegion () : base (NSObjectFlag.Empty)
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
		public MGLShapeOfflineRegion (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLShapeOfflineRegion (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLShapeOfflineRegion (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithStyleURL:shape:fromZoomLevel:toZoomLevel:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLShapeOfflineRegion (NSUrl styleUrl, MGLShape shape, double fromZoomLevel, double maximumZoomLevel)
			: base (NSObjectFlag.Empty)
		{
			if (shape == null)
				throw new ArgumentNullException ("shape");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double_Double (this.Handle, Selector.GetHandle ("initWithStyleURL:shape:fromZoomLevel:toZoomLevel:"), styleUrl == null ? IntPtr.Zero : styleUrl.Handle, shape.Handle, fromZoomLevel, maximumZoomLevel), "initWithStyleURL:shape:fromZoomLevel:toZoomLevel:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double_Double (this.SuperHandle, Selector.GetHandle ("initWithStyleURL:shape:fromZoomLevel:toZoomLevel:"), styleUrl == null ? IntPtr.Zero : styleUrl.Handle, shape.Handle, fromZoomLevel, maximumZoomLevel), "initWithStyleURL:shape:fromZoomLevel:toZoomLevel:");
			}
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
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IncludesIdeographicGlyphs {
			[Export ("includesIdeographicGlyphs")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("includesIdeographicGlyphs"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("includesIdeographicGlyphs"));
				}
			}
			
			[Export ("setIncludesIdeographicGlyphs:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIncludesIdeographicGlyphs:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIncludesIdeographicGlyphs:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MaximumZoomLevel {
			[Export ("maximumZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("maximumZoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumZoomLevel"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MinimumZoomLevel {
			[Export ("minimumZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("minimumZoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumZoomLevel"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLShape Shape {
			[Export ("shape")]
			get {
				MGLShape ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLShape> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shape")));
				} else {
					ret =  Runtime.GetNSObject<MGLShape> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shape")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl StyleURL {
			[Export ("styleURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleURL")));
				}
				return ret;
			}
			
		}
		
	} /* class MGLShapeOfflineRegion */
}
