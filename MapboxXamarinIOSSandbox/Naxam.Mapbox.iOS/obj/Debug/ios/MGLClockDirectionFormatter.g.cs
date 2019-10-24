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
	[Register("MGLClockDirectionFormatter", true)]
	public unsafe partial class MGLClockDirectionFormatter : NSFormatter {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLClockDirectionFormatter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLClockDirectionFormatter () : base (NSObjectFlag.Empty)
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
		public MGLClockDirectionFormatter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLClockDirectionFormatter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLClockDirectionFormatter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("getObjectValue:forString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetObjectValue (out NSObject obj, string @string, out string error)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			IntPtr objValue = IntPtr.Zero;
			IntPtr errorValue = IntPtr.Zero;
			
			var nsstring = NSString.CreateNative (@string);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("getObjectValue:forString:errorDescription:"), ref objValue, nsstring, ref errorValue);
			} else {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("getObjectValue:forString:errorDescription:"), ref objValue, nsstring, ref errorValue);
			}
			NSString.ReleaseNative (nsstring);
			
			obj = Runtime.GetNSObject<NSObject> (objValue);
			error = NSString.FromHandle (errorValue);
			
			return ret;
		}
		
		[Export ("stringFromDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringFromDirection (double direction)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_Double (this.Handle, Selector.GetHandle ("stringFromDirection:"), direction));
			} else {
				return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("stringFromDirection:"), direction));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFormattingUnitStyle UnitStyle {
			[Export ("unitStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSFormattingUnitStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (NSFormattingUnitStyle) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("unitStyle"));
					} else {
						ret = (NSFormattingUnitStyle) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("unitStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (NSFormattingUnitStyle) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unitStyle"));
					} else {
						ret = (NSFormattingUnitStyle) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unitStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setUnitStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setUnitStyle:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setUnitStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setUnitStyle:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setUnitStyle:"), (int)value);
					}
				}
			}
		}
		
	} /* class MGLClockDirectionFormatter */
}
