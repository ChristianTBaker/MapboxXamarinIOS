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
	[Register("MGLAnnotationView", true)]
	public unsafe partial class MGLAnnotationView : global::UIKit.UIView, INSCoding, INSSecureCoding {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLAnnotationView () : base (NSObjectFlag.Empty)
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
		public MGLAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithReuseIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLAnnotationView (string reuseIdentifier)
			: base (NSObjectFlag.Empty)
		{
			var nsreuseIdentifier = NSString.CreateNative (reuseIdentifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithReuseIdentifier:"), nsreuseIdentifier), "initWithReuseIdentifier:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithReuseIdentifier:"), nsreuseIdentifier), "initWithReuseIdentifier:");
			}
			NSString.ReleaseNative (nsreuseIdentifier);
			
		}
		
		[Export ("initWithAnnotation:reuseIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLAnnotationView (IMGLAnnotation annotation, string reuseIdentifier)
			: base (NSObjectFlag.Empty)
		{
			var nsreuseIdentifier = NSString.CreateNative (reuseIdentifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithAnnotation:reuseIdentifier:"), annotation == null ? IntPtr.Zero : annotation.Handle, nsreuseIdentifier), "initWithAnnotation:reuseIdentifier:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAnnotation:reuseIdentifier:"), annotation == null ? IntPtr.Zero : annotation.Handle, nsreuseIdentifier), "initWithAnnotation:reuseIdentifier:");
			}
			NSString.ReleaseNative (nsreuseIdentifier);
			
		}
		
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual void EncodeTo (NSCoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException ("encoder");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			}
		}
		
		[Export ("prepareForReuse")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForReuse ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareForReuse"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prepareForReuse"));
			}
		}
		
		[Export ("setDragState:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void SetDragState (MGLAnnotationViewDragState dragState, bool animated)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setDragState:animated:"), (UInt64)dragState, animated);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, Selector.GetHandle ("setDragState:animated:"), (UInt32)dragState, animated);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64_bool (this.SuperHandle, Selector.GetHandle ("setDragState:animated:"), (UInt64)dragState, animated);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, Selector.GetHandle ("setDragState:animated:"), (UInt32)dragState, animated);
				}
			}
		}
		
		[Export ("setSelected:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelected (bool selected, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setSelected:animated:"), selected, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setSelected:animated:"), selected, animated);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Annotation_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotation Annotation {
			[Export ("annotation", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLAnnotation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
				} else {
					ret =  Runtime.GetNSObject<MGLAnnotation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
			[Export ("setAnnotation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotation:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotation:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Annotation_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGVector CenterOffset {
			[Export ("centerOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGVector ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGVector_objc_msgSend (this.Handle, Selector.GetHandle ("centerOffset"));
						} else {
							global::ApiDefinitions.Messaging.CGVector_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerOffset"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGVector_objc_msgSend (this.Handle, Selector.GetHandle ("centerOffset"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGVector_objc_msgSend (this.Handle, Selector.GetHandle ("centerOffset"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGVector_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerOffset"));
						} else {
							global::ApiDefinitions.Messaging.CGVector_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerOffset"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGVector_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerOffset"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGVector_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerOffset"));
					}
				}
				return ret;
			}
			
			[Export ("setCenterOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CGVector (this.Handle, Selector.GetHandle ("setCenterOffset:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CGVector (this.SuperHandle, Selector.GetHandle ("setCenterOffset:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotationViewDragState DragState {
			[Export ("dragState")]
			get {
				MGLAnnotationViewDragState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLAnnotationViewDragState) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("dragState"));
					} else {
						ret = (MGLAnnotationViewDragState) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("dragState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLAnnotationViewDragState) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dragState"));
					} else {
						ret = (MGLAnnotationViewDragState) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dragState"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Draggable {
			[Export ("isDraggable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDraggable"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDraggable"));
				}
			}
			
			[Export ("setDraggable:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDraggable:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDraggable:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEnabled"));
				}
			}
			
			[Export ("setEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ReuseIdentifier {
			[Export ("reuseIdentifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reuseIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reuseIdentifier")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RotatesToMatchCamera {
			[Export ("rotatesToMatchCamera")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("rotatesToMatchCamera"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotatesToMatchCamera"));
				}
			}
			
			[Export ("setRotatesToMatchCamera:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotatesToMatchCamera:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotatesToMatchCamera:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ScalesWithViewingDistance {
			[Export ("scalesWithViewingDistance")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("scalesWithViewingDistance"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scalesWithViewingDistance"));
				}
			}
			
			[Export ("setScalesWithViewingDistance:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScalesWithViewingDistance:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScalesWithViewingDistance:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Selected {
			[Export ("isSelected")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelected"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSelected"));
				}
			}
			
			[Export ("setSelected:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSelected:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSelected:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
			}
		}
		public partial class MGLAnnotationViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MGLAnnotationViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MGLAnnotationViewAppearance Appearance {
			get { return new MGLAnnotationViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MGLAnnotationViewAppearance GetAppearance<T> () where T: MGLAnnotationView {
			return new MGLAnnotationViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MGLAnnotationViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MGLAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MGLAnnotationViewAppearance GetAppearance (UITraitCollection traits) {
			return new MGLAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MGLAnnotationViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MGLAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MGLAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MGLAnnotationView {
			return new MGLAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MGLAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MGLAnnotationView{
			return new MGLAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MGLAnnotationView */
}
