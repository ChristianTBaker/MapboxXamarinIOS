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
	[Register("MGLBackgroundStyleLayer", true)]
	public unsafe partial class MGLBackgroundStyleLayer : MGLStyleLayer {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLBackgroundStyleLayer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLBackgroundStyleLayer () : base (NSObjectFlag.Empty)
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
		protected MGLBackgroundStyleLayer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLBackgroundStyleLayer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLBackgroundStyleLayer (string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:"), nsidentifier), "initWithIdentifier:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:"), nsidentifier), "initWithIdentifier:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_BackgroundColor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression BackgroundColor {
			[Export ("backgroundColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColor")));
				}
				MarkDirty ();
				__mt_BackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundColor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition BackgroundColorTransition {
			[Export ("backgroundColorTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("backgroundColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("backgroundColorTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("backgroundColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("backgroundColorTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setBackgroundColorTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setBackgroundColorTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setBackgroundColorTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_BackgroundOpacity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression BackgroundOpacity {
			[Export ("backgroundOpacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundOpacity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundOpacity")));
				}
				MarkDirty ();
				__mt_BackgroundOpacity_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundOpacity:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundOpacity:"), value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundOpacity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition BackgroundOpacityTransition {
			[Export ("backgroundOpacityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("backgroundOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("backgroundOpacityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("backgroundOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("backgroundOpacityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setBackgroundOpacityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setBackgroundOpacityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setBackgroundOpacityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_BackgroundPattern_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression BackgroundPattern {
			[Export ("backgroundPattern", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundPattern")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundPattern")));
				}
				MarkDirty ();
				__mt_BackgroundPattern_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundPattern:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundPattern:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundPattern:"), value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundPattern_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition BackgroundPatternTransition {
			[Export ("backgroundPatternTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundPatternTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("backgroundPatternTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundPatternTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("backgroundPatternTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundPatternTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("backgroundPatternTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundPatternTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("backgroundPatternTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setBackgroundPatternTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setBackgroundPatternTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setBackgroundPatternTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackgroundColor_var = null;
				__mt_BackgroundOpacity_var = null;
				__mt_BackgroundPattern_var = null;
			}
		}
	} /* class MGLBackgroundStyleLayer */
}
