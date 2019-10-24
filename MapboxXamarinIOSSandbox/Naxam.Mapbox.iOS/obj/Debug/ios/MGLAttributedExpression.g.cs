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
	[Register("MGLAttributedExpression", true)]
	public unsafe partial class MGLAttributedExpression : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLAttributedExpression");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLAttributedExpression () : base (NSObjectFlag.Empty)
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
		protected MGLAttributedExpression (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLAttributedExpression (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithExpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLAttributedExpression (NSExpression expression)
			: base (NSObjectFlag.Empty)
		{
			if (expression == null)
				throw new ArgumentNullException ("expression");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithExpression:"), expression.Handle), "initWithExpression:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithExpression:"), expression.Handle), "initWithExpression:");
			}
		}
		
		[Export ("initWithExpression:attributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLAttributedExpression (NSExpression expression, NSDictionary attrs)
			: base (NSObjectFlag.Empty)
		{
			if (expression == null)
				throw new ArgumentNullException ("expression");
			if (attrs == null)
				throw new ArgumentNullException ("attrs");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithExpression:attributes:"), expression.Handle, attrs.Handle), "initWithExpression:attributes:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithExpression:attributes:"), expression.Handle, attrs.Handle), "initWithExpression:attributes:");
			}
		}
		
		[Export ("attributedExpression:fontNames:fontScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLAttributedExpression AttributedExpression (NSExpression expression, string[] fontNames, double fontScale)
		{
			if (expression == null)
				throw new ArgumentNullException ("expression");
			if (fontNames == null)
				throw new ArgumentNullException ("fontNames");
			var nsa_fontNames = NSArray.FromStrings (fontNames);
			
			MGLAttributedExpression ret;
			ret =  Runtime.GetNSObject<MGLAttributedExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double (class_ptr, Selector.GetHandle ("attributedExpression:fontNames:fontScale:"), expression.Handle, nsa_fontNames.Handle, fontScale));
			nsa_fontNames.Dispose ();
			
			return ret;
		}
		
		[Export ("attributedExpression:attributes:fontNames:fontScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLAttributedExpression AttributedExpression (NSExpression expression, NSDictionary attributes)
		{
			if (expression == null)
				throw new ArgumentNullException ("expression");
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			return  Runtime.GetNSObject<MGLAttributedExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("attributedExpression:attributes:fontNames:fontScale:"), expression.Handle, attributes.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Attributes {
			[Export ("attributes")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributes")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributes")));
				}
				return ret;
			}
			
			[Export ("setAttributes:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAttributes:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAttributes:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression Expression {
			[Export ("expression")]
			get {
				NSExpression ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("expression")));
				} else {
					ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expression")));
				}
				return ret;
			}
			
			[Export ("setExpression:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExpression:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExpression:"), value.Handle);
				}
			}
		}
		
	} /* class MGLAttributedExpression */
}
