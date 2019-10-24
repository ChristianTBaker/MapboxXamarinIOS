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
	[Register("MGLHeatmapStyleLayer", true)]
	public unsafe partial class MGLHeatmapStyleLayer : MGLVectorStyleLayer {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLHeatmapStyleLayer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLHeatmapStyleLayer () : base (NSObjectFlag.Empty)
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
		protected MGLHeatmapStyleLayer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLHeatmapStyleLayer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithIdentifier:source:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLHeatmapStyleLayer (string identifier, MGLSource source)
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
		object __mt_HeatmapColor_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression HeatmapColor {
			[Export ("heatmapColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapColor")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapColor")));
				}
				MarkDirty ();
				__mt_HeatmapColor_var = ret;
				return ret;
			}
			
			[Export ("setHeatmapColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeatmapColor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeatmapColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeatmapColor_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_HeatmapIntensity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression HeatmapIntensity {
			[Export ("heatmapIntensity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapIntensity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapIntensity")));
				}
				MarkDirty ();
				__mt_HeatmapIntensity_var = ret;
				return ret;
			}
			
			[Export ("setHeatmapIntensity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeatmapIntensity:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeatmapIntensity:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeatmapIntensity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition HeatmapIntensityTransition {
			[Export ("heatmapIntensityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapIntensityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("heatmapIntensityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapIntensityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("heatmapIntensityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapIntensityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("heatmapIntensityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapIntensityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("heatmapIntensityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setHeatmapIntensityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setHeatmapIntensityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setHeatmapIntensityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_HeatmapOpacity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression HeatmapOpacity {
			[Export ("heatmapOpacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapOpacity")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapOpacity")));
				}
				MarkDirty ();
				__mt_HeatmapOpacity_var = ret;
				return ret;
			}
			
			[Export ("setHeatmapOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeatmapOpacity:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeatmapOpacity:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeatmapOpacity_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition HeatmapOpacityTransition {
			[Export ("heatmapOpacityTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("heatmapOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("heatmapOpacityTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapOpacityTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("heatmapOpacityTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapOpacityTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("heatmapOpacityTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setHeatmapOpacityTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setHeatmapOpacityTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setHeatmapOpacityTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_HeatmapRadius_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression HeatmapRadius {
			[Export ("heatmapRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapRadius")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapRadius")));
				}
				MarkDirty ();
				__mt_HeatmapRadius_var = ret;
				return ret;
			}
			
			[Export ("setHeatmapRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeatmapRadius:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeatmapRadius:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeatmapRadius_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition HeatmapRadiusTransition {
			[Export ("heatmapRadiusTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapRadiusTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("heatmapRadiusTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapRadiusTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("heatmapRadiusTransition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapRadiusTransition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("heatmapRadiusTransition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapRadiusTransition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("heatmapRadiusTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setHeatmapRadiusTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setHeatmapRadiusTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setHeatmapRadiusTransition:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_HeatmapWeight_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression HeatmapWeight {
			[Export ("heatmapWeight", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heatmapWeight")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heatmapWeight")));
				}
				MarkDirty ();
				__mt_HeatmapWeight_var = ret;
				return ret;
			}
			
			[Export ("setHeatmapWeight:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeatmapWeight:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeatmapWeight:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeatmapWeight_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_HeatmapColor_var = null;
				__mt_HeatmapIntensity_var = null;
				__mt_HeatmapOpacity_var = null;
				__mt_HeatmapRadius_var = null;
				__mt_HeatmapWeight_var = null;
			}
		}
	} /* class MGLHeatmapStyleLayer */
}
