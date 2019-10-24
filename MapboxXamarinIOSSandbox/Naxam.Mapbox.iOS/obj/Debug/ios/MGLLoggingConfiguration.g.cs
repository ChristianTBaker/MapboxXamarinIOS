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
	[Register("MGLLoggingConfiguration", true)]
	public unsafe partial class MGLLoggingConfiguration : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLLoggingConfiguration");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLLoggingConfiguration () : base (NSObjectFlag.Empty)
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
		protected MGLLoggingConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLLoggingConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MGLLoggingBlockHandler Handler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDMGLLoggingBlockHandler))]
			[Export ("handler")]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("handler"));
				} else {
					ret = global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("handler"));
				}
				return global::ObjCRuntime.Trampolines.NIDMGLLoggingBlockHandler.Create (ret);
			}
			
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLLoggingBlockHandler))]
			[Export ("setHandler:")]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDMGLLoggingBlockHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHandler:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLLoggingLevel LoggingLevel {
			[Export ("loggingLevel")]
			get {
				MGLLoggingLevel ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLLoggingLevel) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("loggingLevel"));
					} else {
						ret = (MGLLoggingLevel) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("loggingLevel"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLLoggingLevel) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loggingLevel"));
					} else {
						ret = (MGLLoggingLevel) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loggingLevel"));
					}
				}
				return ret;
			}
			
			[Export ("setLoggingLevel:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setLoggingLevel:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setLoggingLevel:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setLoggingLevel:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setLoggingLevel:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLLoggingConfiguration sharedConfiguration {
			[Export ("MGLLoggingConfiguration")]
			get {
				MGLLoggingConfiguration ret;
				ret =  Runtime.GetNSObject<MGLLoggingConfiguration> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("MGLLoggingConfiguration")));
				return ret;
			}
			
		}
		
	} /* class MGLLoggingConfiguration */
}
