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
	[Register("MGLCircleStyleLayer", true)]
	public unsafe partial class MGLCircleStyleLayer : MGLVectorStyleLayer {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLCircleStyleLayer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLCircleStyleLayer () : base (NSObjectFlag.Empty)
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
		protected MGLCircleStyleLayer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLCircleStyleLayer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:source:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLCircleStyleLayer (string identifier, MGLSource source)
			: base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (source == null)
				throw new ArgumentNullException ("source");
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:source:"), nsidentifier, source.Handle), "initWithIdentifier:source:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentifier:source:"), nsidentifier, source.Handle), "initWithIdentifier:source:");
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleBlur_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleBlur {
			[Export ("circleBlur", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleBlur")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleBlur")));
				}
				MarkDirty ();
				__mt_CircleBlur_var = ret;
				return ret;
			}
			
			[Export ("setCircleBlur:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleBlur:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleBlur:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleBlur_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleBlurTransition {
			[Export ("circleBlurTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleBlurTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleBlurTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleBlurTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleBlurTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleBlurTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleBlurTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleBlurTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleBlurTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleBlurTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleBlurTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleBlurTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleColor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleColor {
			[Export ("circleColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleColor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleColor")));
				}
				MarkDirty ();
				__mt_CircleColor_var = ret;
				return ret;
			}
			
			[Export ("setCircleColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleColor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleColorTransition {
			[Export ("circleColorTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleColorTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleColorTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleColorTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleColorTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleColorTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleOpacity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleOpacity {
			[Export ("circleOpacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleOpacity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleOpacity")));
				}
				MarkDirty ();
				__mt_CircleOpacity_var = ret;
				return ret;
			}
			
			[Export ("setCircleOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleOpacity:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleOpacity:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleOpacity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleOpacityTransition {
			[Export ("circleOpacityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleOpacityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleOpacityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleOpacityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleOpacityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleOpacityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CirclePitchAlignment_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CirclePitchAlignment {
			[Export ("circlePitchAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circlePitchAlignment")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circlePitchAlignment")));
				}
				MarkDirty ();
				__mt_CirclePitchAlignment_var = ret;
				return ret;
			}
			
			[Export ("setCirclePitchAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCirclePitchAlignment:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCirclePitchAlignment:"), value.Handle);
				}
				MarkDirty ();
				__mt_CirclePitchAlignment_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleRadius_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleRadius {
			[Export ("circleRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleRadius")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleRadius")));
				}
				MarkDirty ();
				__mt_CircleRadius_var = ret;
				return ret;
			}
			
			[Export ("setCircleRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleRadius:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleRadius:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleRadius_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleRadiusTransition {
			[Export ("circleRadiusTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleRadiusTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleRadiusTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleRadiusTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleRadiusTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleRadiusTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleRadiusTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleRadiusTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleRadiusTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleRadiusTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleRadiusTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleRadiusTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleScaleAlignment_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleScaleAlignment {
			[Export ("circleScaleAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleScaleAlignment")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleScaleAlignment")));
				}
				MarkDirty ();
				__mt_CircleScaleAlignment_var = ret;
				return ret;
			}
			
			[Export ("setCircleScaleAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleScaleAlignment:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleScaleAlignment:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleScaleAlignment_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleStrokeColor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleStrokeColor {
			[Export ("circleStrokeColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeColor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeColor")));
				}
				MarkDirty ();
				__mt_CircleStrokeColor_var = ret;
				return ret;
			}
			
			[Export ("setCircleStrokeColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleStrokeColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleStrokeColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleStrokeColor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleStrokeColorTransition {
			[Export ("circleStrokeColorTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleStrokeColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleStrokeColorTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleStrokeColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleStrokeColorTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleStrokeColorTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleStrokeColorTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleStrokeColorTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleStrokeOpacity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleStrokeOpacity {
			[Export ("circleStrokeOpacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeOpacity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeOpacity")));
				}
				MarkDirty ();
				__mt_CircleStrokeOpacity_var = ret;
				return ret;
			}
			
			[Export ("setCircleStrokeOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleStrokeOpacity:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleStrokeOpacity:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleStrokeOpacity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleStrokeOpacityTransition {
			[Export ("circleStrokeOpacityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleStrokeOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleStrokeOpacityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleStrokeOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleStrokeOpacityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleStrokeOpacityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleStrokeOpacityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleStrokeOpacityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleStrokeWidth_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleStrokeWidth {
			[Export ("circleStrokeWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeWidth")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeWidth")));
				}
				MarkDirty ();
				__mt_CircleStrokeWidth_var = ret;
				return ret;
			}
			
			[Export ("setCircleStrokeWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleStrokeWidth:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleStrokeWidth:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleStrokeWidth_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleStrokeWidthTransition {
			[Export ("circleStrokeWidthTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeWidthTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleStrokeWidthTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleStrokeWidthTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleStrokeWidthTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeWidthTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleStrokeWidthTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleStrokeWidthTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleStrokeWidthTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleStrokeWidthTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleStrokeWidthTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleStrokeWidthTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleTranslation_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleTranslation {
			[Export ("circleTranslation", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleTranslation")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleTranslation")));
				}
				MarkDirty ();
				__mt_CircleTranslation_var = ret;
				return ret;
			}
			
			[Export ("setCircleTranslation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleTranslation:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleTranslation:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleTranslation_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CircleTranslationAnchor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression CircleTranslationAnchor {
			[Export ("circleTranslationAnchor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("circleTranslationAnchor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleTranslationAnchor")));
				}
				MarkDirty ();
				__mt_CircleTranslationAnchor_var = ret;
				return ret;
			}
			
			[Export ("setCircleTranslationAnchor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCircleTranslationAnchor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCircleTranslationAnchor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CircleTranslationAnchor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition CircleTranslationTransition {
			[Export ("circleTranslationTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleTranslationTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleTranslationTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("circleTranslationTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("circleTranslationTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleTranslationTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleTranslationTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("circleTranslationTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("circleTranslationTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setCircleTranslationTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setCircleTranslationTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setCircleTranslationTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CircleBlur_var = null;
				__mt_CircleColor_var = null;
				__mt_CircleOpacity_var = null;
				__mt_CirclePitchAlignment_var = null;
				__mt_CircleRadius_var = null;
				__mt_CircleScaleAlignment_var = null;
				__mt_CircleStrokeColor_var = null;
				__mt_CircleStrokeOpacity_var = null;
				__mt_CircleStrokeWidth_var = null;
				__mt_CircleTranslationAnchor_var = null;
				__mt_CircleTranslation_var = null;
			}
		}
	} /* class MGLCircleStyleLayer */
}
