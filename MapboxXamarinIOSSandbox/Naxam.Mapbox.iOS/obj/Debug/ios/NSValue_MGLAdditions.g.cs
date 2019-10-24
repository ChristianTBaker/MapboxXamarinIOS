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
	public unsafe static partial class NSValue_MGLAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSValue");
		
		[Export ("MGLCoordinateBoundsValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCoordinateBounds MGLCoordinateBoundsValue (this NSValue This)
		{
			MGLCoordinateBounds ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCoordinateBoundsValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateBoundsValue"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateBoundsValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateBoundsValue"));
			}
			return ret;
		}
		
		[Export ("MGLCoordinateQuadValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCoordinateQuad MGLCoordinateQuadValue (this NSValue This)
		{
			MGLCoordinateQuad ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCoordinateQuadValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateQuadValue"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateQuadValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLCoordinateQuad_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateQuadValue"));
			}
			return ret;
		}
		
		[Export ("MGLCoordinateSpanValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCoordinateSpan MGLCoordinateSpanValue (this NSValue This)
		{
			MGLCoordinateSpan ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLCoordinateSpan_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCoordinateSpanValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLCoordinateSpan_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateSpanValue"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinitions.Messaging.MGLCoordinateSpan_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCoordinateSpanValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLCoordinateSpan_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateSpanValue"));
			}
			return ret;
		}
		
		[Export ("MGLCoordinateValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreLocation.CLLocationCoordinate2D MGLCoordinateValue (this NSValue This)
		{
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCoordinateValue"));
				} else {
					global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateValue"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCoordinateValue"));
			} else {
				global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLCoordinateValue"));
			}
			return ret;
		}
		
		[Export ("MGLLightAnchorValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLLightAnchor MGLLightAnchorValue (this NSValue This)
		{
			MGLLightAnchor ret;
			if (IntPtr.Size == 8) {
				ret = (MGLLightAnchor) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLightAnchorValue"));
			} else {
				ret = (MGLLightAnchor) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLightAnchorValue"));
			}
			return ret;
		}
		
		[Export ("MGLMapPointValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLMapPoint MGLMapPointValue (this NSValue This)
		{
			MGLMapPoint ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLMapPoint_objc_msgSend (This.Handle, Selector.GetHandle ("MGLMapPointValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLMapPoint_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLMapPointValue"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.MGLMapPoint_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLMapPointValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLMapPoint_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLMapPointValue"));
			}
			return ret;
		}
		
		[Export ("MGLOfflinePackProgressValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLOfflinePackProgress MGLOfflinePackProgressValue (this NSValue This)
		{
			MGLOfflinePackProgress ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend (This.Handle, Selector.GetHandle ("MGLOfflinePackProgressValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLOfflinePackProgressValue"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLOfflinePackProgressValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLOfflinePackProgress_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLOfflinePackProgressValue"));
			}
			return ret;
		}
		
		[Export ("MGLSphericalPositionValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLSphericalPosition MGLSphericalPositionValue (this NSValue This)
		{
			MGLSphericalPosition ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLSphericalPosition_objc_msgSend (This.Handle, Selector.GetHandle ("MGLSphericalPositionValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLSphericalPosition_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLSphericalPositionValue"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.MGLSphericalPosition_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLSphericalPositionValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLSphericalPosition_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLSphericalPositionValue"));
			}
			return ret;
		}
		
		[Export ("MGLTransitionValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLTransition MGLTransitionValue (this NSValue This)
		{
			MGLTransition ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (This.Handle, Selector.GetHandle ("MGLTransitionValue"));
				} else {
					global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLTransitionValue"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (This.Handle, Selector.GetHandle ("MGLTransitionValue"));
			} else {
				global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("MGLTransitionValue"));
			}
			return ret;
		}
		
		[Export ("valueWithMGLCoordinate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCoordinate (this NSValue This, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D (class_ptr, Selector.GetHandle ("valueWithMGLCoordinate:"), coordinate));
		}
		
		[Export ("valueWithMGLCoordinateBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCoordinateBounds (this NSValue This, MGLCoordinateBounds bounds)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLCoordinateBounds (class_ptr, Selector.GetHandle ("valueWithMGLCoordinateBounds:"), bounds));
		}
		
		[Export ("valueWithMGLCoordinateQuad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCoordinateQuad (this NSValue This, MGLCoordinateQuad quad)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLCoordinateQuad (class_ptr, Selector.GetHandle ("valueWithMGLCoordinateQuad:"), quad));
		}
		
		[Export ("valueWithMGLCoordinateSpan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCoordinateSpan (this NSValue This, MGLCoordinateSpan span)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLCoordinateSpan (class_ptr, Selector.GetHandle ("valueWithMGLCoordinateSpan:"), span));
		}
		
		[Export ("valueWithMGLLightAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLLightAnchor (this NSValue This, MGLLightAnchor lightAnchor)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLLightAnchor:"), (UInt64)lightAnchor));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLLightAnchor:"), (UInt32)lightAnchor));
			}
		}
		
		[Export ("valueWithMGLMapPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLMapPoint (this NSValue This, MGLMapPoint point)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLMapPoint (class_ptr, Selector.GetHandle ("valueWithMGLMapPoint:"), point));
		}
		
		[Export ("valueWithMGLOfflinePackProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLOfflinePackProgress (this NSValue This, MGLOfflinePackProgress progress)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLOfflinePackProgress (class_ptr, Selector.GetHandle ("valueWithMGLOfflinePackProgress:"), progress));
		}
		
		[Export ("valueWithMGLSphericalPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLSphericalPosition (this NSValue This, MGLSphericalPosition lightPosition)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLSphericalPosition (class_ptr, Selector.GetHandle ("valueWithMGLSphericalPosition:"), lightPosition));
		}
		
		[Export ("valueWithMGLTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLTransition (this NSValue This, MGLTransition transition)
		{
			return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLTransition (class_ptr, Selector.GetHandle ("valueWithMGLTransition:"), transition));
		}
		
	} /* class NSValue_MGLAdditions */
}
