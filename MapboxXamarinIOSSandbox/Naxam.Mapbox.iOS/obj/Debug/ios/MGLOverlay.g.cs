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
	[Protocol (Name = "MGLOverlay", WrapperType = typeof (MGLOverlayWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IntersectsOverlayBounds", Selector = "intersectsOverlayBounds:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLCoordinateBounds) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OverlayBounds", Selector = "overlayBounds", PropertyType = typeof (Mapbox.MGLCoordinateBounds), GetterSelector = "overlayBounds", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLOverlay : INativeObject, IDisposable, 
		Mapbox.IMGLAnnotation
		
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("intersectsOverlayBounds:")]
		[Preserve (Conditional = true)]
		bool IntersectsOverlayBounds (MGLCoordinateBounds overlayBounds);
		
		[Preserve (Conditional = true)]
		MGLCoordinateBounds OverlayBounds {
			[Export ("overlayBounds")]
			get;
		}
		
	}
	
	internal sealed class MGLOverlayWrapper : BaseWrapper, IMGLOverlay {
		[Preserve (Conditional = true)]
		public MGLOverlayWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("intersectsOverlayBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IntersectsOverlayBounds (MGLCoordinateBounds overlayBounds)
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_MGLCoordinateBounds (this.Handle, Selector.GetHandle ("intersectsOverlayBounds:"), overlayBounds);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLCoordinateBounds OverlayBounds {
			[Export ("overlayBounds")]
			get {
				MGLCoordinateBounds ret;
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend (this.Handle, Selector.GetHandle ("overlayBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("overlayBounds"));
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("overlayBounds"));
				} else {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("overlayBounds"));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("coordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinate"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("coordinate"));
				} else {
					global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coordinate"));
				}
				return ret;
			}
			
		}
		
	}
}
