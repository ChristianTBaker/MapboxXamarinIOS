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
	[Register("MGLLineStyleLayer", true)]
	public unsafe partial class MGLLineStyleLayer : MGLVectorStyleLayer {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLLineStyleLayer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLLineStyleLayer () : base (NSObjectFlag.Empty)
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
		protected MGLLineStyleLayer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLLineStyleLayer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:source:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLLineStyleLayer (string identifier, MGLSource source)
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
		object __mt_LineBlur_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineBlur {
			[Export ("lineBlur", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineBlur")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineBlur")));
				}
				MarkDirty ();
				__mt_LineBlur_var = ret;
				return ret;
			}
			
			[Export ("setLineBlur:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineBlur:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineBlur:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineBlur_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineBlurTransition {
			[Export ("lineBlurTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineBlurTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineBlurTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineBlurTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineBlurTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineBlurTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineBlurTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineBlurTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineBlurTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineBlurTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineBlurTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineBlurTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineCap_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineCap {
			[Export ("lineCap", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineCap")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineCap")));
				}
				MarkDirty ();
				__mt_LineCap_var = ret;
				return ret;
			}
			
			[Export ("setLineCap:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineCap:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineCap:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineCap_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineColor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineColor {
			[Export ("lineColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineColor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineColor")));
				}
				MarkDirty ();
				__mt_LineColor_var = ret;
				return ret;
			}
			
			[Export ("setLineColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineColor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineColor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineColorTransition {
			[Export ("lineColorTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineColorTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineColorTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineColorTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineColorTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineColorTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineColorTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineColorTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineColorTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineDashPattern_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineDashPattern {
			[Export ("lineDashPattern", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineDashPattern")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineDashPattern")));
				}
				MarkDirty ();
				__mt_LineDashPattern_var = ret;
				return ret;
			}
			
			[Export ("setLineDashPattern:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineDashPattern:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineDashPattern:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineDashPattern_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineDashPatternTransition {
			[Export ("lineDashPatternTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineDashPatternTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineDashPatternTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineDashPatternTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineDashPatternTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineDashPatternTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineDashPatternTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineDashPatternTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineDashPatternTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineDashPatternTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineDashPatternTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineDashPatternTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineGapWidth_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineGapWidth {
			[Export ("lineGapWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineGapWidth")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineGapWidth")));
				}
				MarkDirty ();
				__mt_LineGapWidth_var = ret;
				return ret;
			}
			
			[Export ("setLineGapWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineGapWidth:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineGapWidth:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineGapWidth_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineGapWidthTransition {
			[Export ("lineGapWidthTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineGapWidthTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineGapWidthTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineGapWidthTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineGapWidthTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineGapWidthTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineGapWidthTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineGapWidthTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineGapWidthTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineGapWidthTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineGapWidthTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineGapWidthTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineGradient {
			[Export ("lineGradient")]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineGradient")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineGradient")));
				}
				return ret;
			}
			
			[Export ("setLineGradient:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineGradient:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineGradient:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineJoin_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineJoin {
			[Export ("lineJoin", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineJoin")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineJoin")));
				}
				MarkDirty ();
				__mt_LineJoin_var = ret;
				return ret;
			}
			
			[Export ("setLineJoin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineJoin:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineJoin:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineJoin_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineMiterLimit_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineMiterLimit {
			[Export ("lineMiterLimit", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineMiterLimit")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineMiterLimit")));
				}
				MarkDirty ();
				__mt_LineMiterLimit_var = ret;
				return ret;
			}
			
			[Export ("setLineMiterLimit:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineMiterLimit:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineMiterLimit:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineMiterLimit_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineOffset_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineOffset {
			[Export ("lineOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineOffset")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineOffset")));
				}
				MarkDirty ();
				__mt_LineOffset_var = ret;
				return ret;
			}
			
			[Export ("setLineOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineOffset:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineOffset:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineOffset_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineOffsetTransition {
			[Export ("lineOffsetTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineOffsetTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineOffsetTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineOffsetTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineOffsetTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineOffsetTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineOffsetTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineOffsetTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineOffsetTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineOffsetTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineOffsetTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineOffsetTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineOpacity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineOpacity {
			[Export ("lineOpacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineOpacity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineOpacity")));
				}
				MarkDirty ();
				__mt_LineOpacity_var = ret;
				return ret;
			}
			
			[Export ("setLineOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineOpacity:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineOpacity:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineOpacity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineOpacityTransition {
			[Export ("lineOpacityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineOpacityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineOpacityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineOpacityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineOpacityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineOpacityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LinePattern_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LinePattern {
			[Export ("linePattern", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linePattern")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linePattern")));
				}
				MarkDirty ();
				__mt_LinePattern_var = ret;
				return ret;
			}
			
			[Export ("setLinePattern:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinePattern:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinePattern:"), value.Handle);
				}
				MarkDirty ();
				__mt_LinePattern_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LinePatternTransition {
			[Export ("linePatternTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("linePatternTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("linePatternTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("linePatternTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("linePatternTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linePatternTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("linePatternTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linePatternTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("linePatternTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLinePatternTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLinePatternTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLinePatternTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineRoundLimit_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineRoundLimit {
			[Export ("lineRoundLimit", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineRoundLimit")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineRoundLimit")));
				}
				MarkDirty ();
				__mt_LineRoundLimit_var = ret;
				return ret;
			}
			
			[Export ("setLineRoundLimit:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineRoundLimit:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineRoundLimit:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineRoundLimit_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineTranslation_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineTranslation {
			[Export ("lineTranslation", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineTranslation")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineTranslation")));
				}
				MarkDirty ();
				__mt_LineTranslation_var = ret;
				return ret;
			}
			
			[Export ("setLineTranslation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineTranslation:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineTranslation:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineTranslation_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineTranslationAnchor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineTranslationAnchor {
			[Export ("lineTranslationAnchor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineTranslationAnchor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineTranslationAnchor")));
				}
				MarkDirty ();
				__mt_LineTranslationAnchor_var = ret;
				return ret;
			}
			
			[Export ("setLineTranslationAnchor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineTranslationAnchor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineTranslationAnchor:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineTranslationAnchor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineTranslationTransition {
			[Export ("lineTranslationTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineTranslationTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineTranslationTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineTranslationTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineTranslationTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineTranslationTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineTranslationTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineTranslationTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineTranslationTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineTranslationTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineTranslationTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineTranslationTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_LineWidth_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LineWidth {
			[Export ("lineWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineWidth")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineWidth")));
				}
				MarkDirty ();
				__mt_LineWidth_var = ret;
				return ret;
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineWidth:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineWidth:"), value.Handle);
				}
				MarkDirty ();
				__mt_LineWidth_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition LineWidthTransition {
			[Export ("lineWidthTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineWidthTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineWidthTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("lineWidthTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("lineWidthTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineWidthTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineWidthTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineWidthTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("lineWidthTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setLineWidthTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setLineWidthTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setLineWidthTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LineBlur_var = null;
				__mt_LineCap_var = null;
				__mt_LineColor_var = null;
				__mt_LineDashPattern_var = null;
				__mt_LineGapWidth_var = null;
				__mt_LineJoin_var = null;
				__mt_LineMiterLimit_var = null;
				__mt_LineOffset_var = null;
				__mt_LineOpacity_var = null;
				__mt_LinePattern_var = null;
				__mt_LineRoundLimit_var = null;
				__mt_LineTranslationAnchor_var = null;
				__mt_LineTranslation_var = null;
				__mt_LineWidth_var = null;
			}
		}
	} /* class MGLLineStyleLayer */
}
