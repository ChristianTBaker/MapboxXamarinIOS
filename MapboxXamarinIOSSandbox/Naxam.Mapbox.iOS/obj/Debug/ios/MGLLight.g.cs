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
	[Register("MGLLight", true)]
	public unsafe partial class MGLLight : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLLight");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLLight () : base (NSObjectFlag.Empty)
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
		protected MGLLight (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLLight (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Anchor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression Anchor {
			[Export ("anchor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("anchor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("anchor")));
				}
				MarkDirty ();
				__mt_Anchor_var = ret;
				return ret;
			}
			
			[Export ("setAnchor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnchor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnchor:"), value.Handle);
				}
				MarkDirty ();
				__mt_Anchor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Color_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression Color {
			[Export ("color", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("color")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("color")));
				}
				MarkDirty ();
				__mt_Color_var = ret;
				return ret;
			}
			
			[Export ("setColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setColor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_Color_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition ColorTransition {
			[Export ("colorTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("colorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("colorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("colorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("colorTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("colorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("colorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("colorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("colorTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setColorTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setColorTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setColorTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Intensity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression Intensity {
			[Export ("intensity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("intensity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("intensity")));
				}
				MarkDirty ();
				__mt_Intensity_var = ret;
				return ret;
			}
			
			[Export ("setIntensity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIntensity:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setIntensity:"), value.Handle);
				}
				MarkDirty ();
				__mt_Intensity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition IntensityTransition {
			[Export ("intensityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("intensityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("intensityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("intensityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("intensityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("intensityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("intensityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("intensityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("intensityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setIntensityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setIntensityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setIntensityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Position_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression Position {
			[Export ("position", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("position")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("position")));
				}
				MarkDirty ();
				__mt_Position_var = ret;
				return ret;
			}
			
			[Export ("setPosition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPosition:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPosition:"), value.Handle);
				}
				MarkDirty ();
				__mt_Position_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition PositionTransition {
			[Export ("positionTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("positionTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("positionTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("positionTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("positionTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("positionTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("positionTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("positionTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("positionTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setPositionTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setPositionTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setPositionTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Anchor_var = null;
				__mt_Color_var = null;
				__mt_Intensity_var = null;
				__mt_Position_var = null;
			}
		}
	} /* class MGLLight */
}
