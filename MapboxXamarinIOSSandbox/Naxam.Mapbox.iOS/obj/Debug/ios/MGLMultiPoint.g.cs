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
	[Register("MGLMultiPoint", true)]
	public unsafe partial class MGLMultiPoint : MGLShape {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMultiPoint");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMultiPoint () : base (NSObjectFlag.Empty)
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
		public MGLMultiPoint (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLMultiPoint (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMultiPoint (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("appendCoordinates:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_nuint (this.Handle, Selector.GetHandle ("appendCoordinates:count:"), ref coords, count);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_nuint (this.SuperHandle, Selector.GetHandle ("appendCoordinates:count:"), ref coords, count);
			}
		}
		
		[Export ("getCoordinates:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, NSRange range)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_NSRange (this.Handle, Selector.GetHandle ("getCoordinates:range:"), ref coords, range);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_NSRange (this.SuperHandle, Selector.GetHandle ("getCoordinates:range:"), ref coords, range);
			}
		}
		
		[Export ("insertCoordinates:count:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count, nuint index)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_nuint_nuint (this.Handle, Selector.GetHandle ("insertCoordinates:count:atIndex:"), ref coords, count, index);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_nuint_nuint (this.SuperHandle, Selector.GetHandle ("insertCoordinates:count:atIndex:"), ref coords, count, index);
			}
		}
		
		[Export ("removeCoordinatesInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCoordinatesInRange (NSRange range)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("removeCoordinatesInRange:"), range);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_NSRange (this.SuperHandle, Selector.GetHandle ("removeCoordinatesInRange:"), range);
			}
		}
		
		[Export ("replaceCoordinatesInRange:withCoordinates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceCoordinatesInRange (NSRange range, ref global::CoreLocation.CLLocationCoordinate2D coords)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_NSRange_ref_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("replaceCoordinatesInRange:withCoordinates:"), range, ref coords);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_NSRange_ref_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("replaceCoordinatesInRange:withCoordinates:"), range, ref coords);
			}
		}
		
		[Export ("replaceCoordinatesInRange:withCoordinates:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceCoordinatesInRange (NSRange range, ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_NSRange_ref_CLLocationCoordinate2D_nuint (this.Handle, Selector.GetHandle ("replaceCoordinatesInRange:withCoordinates:count:"), range, ref coords, count);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_NSRange_ref_CLLocationCoordinate2D_nuint (this.SuperHandle, Selector.GetHandle ("replaceCoordinatesInRange:withCoordinates:count:"), range, ref coords, count);
			}
		}
		
		[Export ("setCoordinates:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coords, nuint count)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_nuint (this.Handle, Selector.GetHandle ("setCoordinates:count:"), ref coords, count);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_nuint (this.SuperHandle, Selector.GetHandle ("setCoordinates:count:"), ref coords, count);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray Coordinates {
			[Export ("coordinates")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("coordinates")));
				} else {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coordinates")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PointCount {
			[Export ("pointCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pointCount"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pointCount"));
				}
			}
			
		}
		
	} /* class MGLMultiPoint */
}
