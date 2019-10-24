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
	[Protocol (Name = "MGLCalloutView", WrapperType = typeof (MGLCalloutViewWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentCalloutFromRect", Selector = "presentCalloutFromRect:inView:constrainedToRect:animated:", ParameterType = new Type [] { typeof (CGRect), typeof (UIView), typeof (CGRect), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DismissCalloutAnimated", Selector = "dismissCalloutAnimated:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MarginInsetsHintForPresentationFromRect", Selector = "marginInsetsHintForPresentationFromRect:", ReturnType = typeof (UIEdgeInsets), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepresentedObject", Selector = "representedObject", PropertyType = typeof (Mapbox.MGLAnnotation), GetterSelector = "representedObject", SetterSelector = "setRepresentedObject:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LeftAccessoryView", Selector = "leftAccessoryView", PropertyType = typeof (UIView), GetterSelector = "leftAccessoryView", SetterSelector = "setLeftAccessoryView:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RightAccessoryView", Selector = "rightAccessoryView", PropertyType = typeof (UIView), GetterSelector = "rightAccessoryView", SetterSelector = "setRightAccessoryView:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AnchoredToAnnotation", Selector = "anchoredToAnnotation", PropertyType = typeof (bool), GetterSelector = "isAnchoredToAnnotation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DismissesAutomatically", Selector = "dismissesAutomatically", PropertyType = typeof (bool), GetterSelector = "dismissesAutomatically", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLCalloutView : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("presentCalloutFromRect:inView:constrainedToRect:animated:")]
		[Preserve (Conditional = true)]
		void PresentCalloutFromRect (CGRect rect, global::UIKit.UIView view, CGRect constrainedRect, bool animated);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("dismissCalloutAnimated:")]
		[Preserve (Conditional = true)]
		void DismissCalloutAnimated (bool animated);
		
		[Preserve (Conditional = true)]
		MGLAnnotation RepresentedObject {
			[Export ("representedObject", ArgumentSemantic.Retain)]
			get;
			[Export ("setRepresentedObject:", ArgumentSemantic.Retain)]
			set;
		}
		
		[Preserve (Conditional = true)]
		global::UIKit.UIView LeftAccessoryView {
			[Export ("leftAccessoryView", ArgumentSemantic.Retain)]
			get;
			[Export ("setLeftAccessoryView:", ArgumentSemantic.Retain)]
			set;
		}
		
		[Preserve (Conditional = true)]
		global::UIKit.UIView RightAccessoryView {
			[Export ("rightAccessoryView", ArgumentSemantic.Retain)]
			get;
			[Export ("setRightAccessoryView:", ArgumentSemantic.Retain)]
			set;
		}
		
		[Preserve (Conditional = true)]
		NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get;
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set;
		}
		
	}
	
	public static partial class MGLCalloutView_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIEdgeInsets MarginInsetsHintForPresentationFromRect (this IMGLCalloutView This, CGRect rect)
		{
			global::UIKit.UIEdgeInsets ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("marginInsetsHintForPresentationFromRect:"), rect);
				} else {
					global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_stret_CGRect (out ret, This.Handle, Selector.GetHandle ("marginInsetsHintForPresentationFromRect:"), rect);
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_stret_CGRect (out ret, This.Handle, Selector.GetHandle ("marginInsetsHintForPresentationFromRect:"), rect);
			} else {
				global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_stret_CGRect (out ret, This.Handle, Selector.GetHandle ("marginInsetsHintForPresentationFromRect:"), rect);
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAnchoredToAnnotation (this IMGLCalloutView This)
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("anchoredToAnnotation"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDismissesAutomatically (this IMGLCalloutView This)
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("dismissesAutomatically"));
		}
		
	}
	
	internal sealed class MGLCalloutViewWrapper : BaseWrapper, IMGLCalloutView {
		[Preserve (Conditional = true)]
		public MGLCalloutViewWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("presentCalloutFromRect:inView:constrainedToRect:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PresentCalloutFromRect (CGRect rect, global::UIKit.UIView view, CGRect constrainedRect, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			global::ApiDefinitions.Messaging.void_objc_msgSend_CGRect_IntPtr_CGRect_bool (this.Handle, Selector.GetHandle ("presentCalloutFromRect:inView:constrainedToRect:animated:"), rect, view.Handle, constrainedRect, animated);
		}
		
		[Export ("dismissCalloutAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DismissCalloutAnimated (bool animated)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("dismissCalloutAnimated:"), animated);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLAnnotation RepresentedObject {
			[Export ("representedObject", ArgumentSemantic.Retain)]
			get {
				return  Runtime.GetNSObject<MGLAnnotation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("representedObject")));
			}
			
			[Export ("setRepresentedObject:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRepresentedObject:"), value.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView LeftAccessoryView {
			[Export ("leftAccessoryView", ArgumentSemantic.Retain)]
			get {
				return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftAccessoryView")));
			}
			
			[Export ("setLeftAccessoryView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftAccessoryView:"), value.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView RightAccessoryView {
			[Export ("rightAccessoryView", ArgumentSemantic.Retain)]
			get {
				return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightAccessoryView")));
			}
			
			[Export ("setRightAccessoryView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightAccessoryView:"), value.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLCalloutView", false)]
	[Model]
	public unsafe abstract partial class MGLCalloutView : NSObject, IMGLCalloutView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MGLCalloutView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLCalloutView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLCalloutView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("dismissCalloutAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DismissCalloutAnimated (bool animated);
		[Export ("marginInsetsHintForPresentationFromRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIEdgeInsets MarginInsetsHintForPresentationFromRect (CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("presentCalloutFromRect:inView:constrainedToRect:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PresentCalloutFromRect (CGRect rect, global::UIKit.UIView view, CGRect constrainedRect, bool animated);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AnchoredToAnnotation {
			[Export ("isAnchoredToAnnotation")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DismissesAutomatically {
			[Export ("dismissesAutomatically")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIView LeftAccessoryView {
			[Export ("leftAccessoryView", ArgumentSemantic.Retain)]
			get; 
			[Export ("setLeftAccessoryView:", ArgumentSemantic.Retain)]
			set; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract MGLAnnotation RepresentedObject {
			[Export ("representedObject", ArgumentSemantic.Retain)]
			get; 
			[Export ("setRepresentedObject:", ArgumentSemantic.Retain)]
			set; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIView RightAccessoryView {
			[Export ("rightAccessoryView", ArgumentSemantic.Retain)]
			get; 
			[Export ("setRightAccessoryView:", ArgumentSemantic.Retain)]
			set; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get; 
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set; 
		}
		
	} /* class MGLCalloutView */
}
