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
	[Protocol (Name = "MGLCalloutViewDelegate", WrapperType = typeof (MGLCalloutViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalloutViewShouldHighlight", Selector = "calloutViewShouldHighlight:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLCalloutView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalloutViewTapped", Selector = "calloutViewTapped:", ParameterType = new Type [] { typeof (Mapbox.MGLCalloutView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalloutViewWillAppear", Selector = "calloutViewWillAppear:", ParameterType = new Type [] { typeof (Mapbox.MGLCalloutView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalloutViewDidAppear", Selector = "calloutViewDidAppear:", ParameterType = new Type [] { typeof (Mapbox.MGLCalloutView) }, ParameterByRef = new bool [] { false })]
	public interface IMGLCalloutViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MGLCalloutViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CalloutViewShouldHighlight (this IMGLCalloutViewDelegate This, MGLCalloutView calloutView)
		{
			if (calloutView == null)
				throw new ArgumentNullException ("calloutView");
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("calloutViewShouldHighlight:"), calloutView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CalloutViewTapped (this IMGLCalloutViewDelegate This, MGLCalloutView calloutView)
		{
			if (calloutView == null)
				throw new ArgumentNullException ("calloutView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("calloutViewTapped:"), calloutView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CalloutViewWillAppear (this IMGLCalloutViewDelegate This, MGLCalloutView calloutView)
		{
			if (calloutView == null)
				throw new ArgumentNullException ("calloutView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("calloutViewWillAppear:"), calloutView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CalloutViewDidAppear (this IMGLCalloutViewDelegate This, MGLCalloutView calloutView)
		{
			if (calloutView == null)
				throw new ArgumentNullException ("calloutView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("calloutViewDidAppear:"), calloutView.Handle);
		}
		
	}
	
	internal sealed class MGLCalloutViewDelegateWrapper : BaseWrapper, IMGLCalloutViewDelegate {
		[Preserve (Conditional = true)]
		public MGLCalloutViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLCalloutViewDelegate", false)]
	[Model]
	public unsafe partial class MGLCalloutViewDelegate : NSObject, IMGLCalloutViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLCalloutViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLCalloutViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLCalloutViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("calloutViewDidAppear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalloutViewDidAppear (MGLCalloutView calloutView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("calloutViewShouldHighlight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CalloutViewShouldHighlight (MGLCalloutView calloutView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("calloutViewTapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalloutViewTapped (MGLCalloutView calloutView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("calloutViewWillAppear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalloutViewWillAppear (MGLCalloutView calloutView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MGLCalloutViewDelegate */
}
