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
	[Register("MGLCompassButton", true)]
	public unsafe partial class MGLCompassButton : global::UIKit.UIImageView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLCompassButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLCompassButton () : base (NSObjectFlag.Empty)
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
		public MGLCompassButton (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLCompassButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLCompassButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOrnamentVisibility CompassVisibility {
			[Export ("compassVisibility", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLOrnamentVisibility ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentVisibility) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("compassVisibility"));
					} else {
						ret = (MGLOrnamentVisibility) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("compassVisibility"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentVisibility) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassVisibility"));
					} else {
						ret = (MGLOrnamentVisibility) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassVisibility"));
					}
				}
				return ret;
			}
			
			[Export ("setCompassVisibility:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setCompassVisibility:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setCompassVisibility:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setCompassVisibility:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setCompassVisibility:"), (UInt32)value);
					}
				}
			}
		}
		
		public partial class MGLCompassButtonAppearance : global::UIKit.UIImageView.UIImageViewAppearance {
			protected internal MGLCompassButtonAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MGLCompassButtonAppearance Appearance {
			get { return new MGLCompassButtonAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MGLCompassButtonAppearance GetAppearance<T> () where T: MGLCompassButton {
			return new MGLCompassButtonAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MGLCompassButtonAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MGLCompassButtonAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MGLCompassButtonAppearance GetAppearance (UITraitCollection traits) {
			return new MGLCompassButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MGLCompassButtonAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MGLCompassButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MGLCompassButtonAppearance GetAppearance<T> (UITraitCollection traits) where T: MGLCompassButton {
			return new MGLCompassButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MGLCompassButtonAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MGLCompassButton{
			return new MGLCompassButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MGLCompassButton */
}
