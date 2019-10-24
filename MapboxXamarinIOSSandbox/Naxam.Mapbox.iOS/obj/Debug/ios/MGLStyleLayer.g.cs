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
	[Register("MGLStyleLayer", true)]
	public unsafe partial class MGLStyleLayer : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLStyleLayer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLStyleLayer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLStyleLayer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("identifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("identifier")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaximumZoomLevel {
			[Export ("maximumZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maximumZoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumZoomLevel"));
				}
			}
			
			[Export ("setMaximumZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaximumZoomLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMaximumZoomLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinimumZoomLevel {
			[Export ("minimumZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minimumZoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumZoomLevel"));
				}
			}
			
			[Export ("setMinimumZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinimumZoomLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMinimumZoomLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Visible {
			[Export ("isVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVisible"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isVisible"));
				}
			}
			
			[Export ("setVisible:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setVisible:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setVisible:"), value);
				}
			}
		}
		
	} /* class MGLStyleLayer */
}
