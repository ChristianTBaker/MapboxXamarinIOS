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
	[Register("MGLAttributionInfo", true)]
	public unsafe partial class MGLAttributionInfo : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLAttributionInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLAttributionInfo () : base (NSObjectFlag.Empty)
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
		protected MGLAttributionInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLAttributionInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithTitle:URL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLAttributionInfo (NSAttributedString title, NSUrl URL)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:URL:"), title.Handle, URL == null ? IntPtr.Zero : URL.Handle), "initWithTitle:URL:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:URL:"), title.Handle, URL == null ? IntPtr.Zero : URL.Handle), "initWithTitle:URL:");
			}
		}
		
		[Export ("feedbackURLAtCenterCoordinate:zoomLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl FeedbackURLAtCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, double zoomLevel)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double (this.Handle, Selector.GetHandle ("feedbackURLAtCenterCoordinate:zoomLevel:"), centerCoordinate, zoomLevel));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double (this.SuperHandle, Selector.GetHandle ("feedbackURLAtCenterCoordinate:zoomLevel:"), centerCoordinate, zoomLevel));
			}
		}
		
		[Export ("titleWithStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString TitleWithStyle (MGLAttributionInfoStyle style)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("titleWithStyle:"), (UInt64)style));
				} else {
					return  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("titleWithStyle:"), (UInt32)style));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("titleWithStyle:"), (UInt64)style));
				} else {
					return  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("titleWithStyle:"), (UInt32)style));
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FeedbackLink {
			[Export ("isFeedbackLink")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFeedbackLink"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFeedbackLink"));
				}
			}
			
			[Export ("setFeedbackLink:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFeedbackLink:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFeedbackLink:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Title_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString Title {
			[Export ("title", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSAttributedString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
				MarkDirty ();
				__mt_Title_var = ret;
				return ret;
			}
			
			[Export ("setTitle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitle:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitle:"), value.Handle);
				}
				MarkDirty ();
				__mt_Title_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_URL_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl URL {
			[Export ("URL", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("URL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("URL")));
				}
				MarkDirty ();
				__mt_URL_var = ret;
				return ret;
			}
			
			[Export ("setURL:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setURL:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setURL:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_URL_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Title_var = null;
				__mt_URL_var = null;
			}
		}
	} /* class MGLAttributionInfo */
}
