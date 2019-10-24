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
	public unsafe static partial class NSValue_MGLCircleStyleLayerAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSValue");
		
		[Export ("MGLCirclePitchAlignmentValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCirclePitchAlignment MGLCirclePitchAlignmentValue (this NSValue This)
		{
			MGLCirclePitchAlignment ret;
			if (IntPtr.Size == 8) {
				ret = (MGLCirclePitchAlignment) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCirclePitchAlignmentValue"));
			} else {
				ret = (MGLCirclePitchAlignment) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCirclePitchAlignmentValue"));
			}
			return ret;
		}
		
		[Export ("MGLCircleScaleAlignmentValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCircleScaleAlignment MGLCircleScaleAlignmentValue (this NSValue This)
		{
			MGLCircleScaleAlignment ret;
			if (IntPtr.Size == 8) {
				ret = (MGLCircleScaleAlignment) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCircleScaleAlignmentValue"));
			} else {
				ret = (MGLCircleScaleAlignment) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCircleScaleAlignmentValue"));
			}
			return ret;
		}
		
		[Export ("MGLCircleTranslationAnchorValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCircleTranslationAnchor MGLCircleTranslationAnchorValue (this NSValue This)
		{
			MGLCircleTranslationAnchor ret;
			if (IntPtr.Size == 8) {
				ret = (MGLCircleTranslationAnchor) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCircleTranslationAnchorValue"));
			} else {
				ret = (MGLCircleTranslationAnchor) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLCircleTranslationAnchorValue"));
			}
			return ret;
		}
		
		[Export ("valueWithMGLCirclePitchAlignment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCirclePitchAlignment (this NSValue This, MGLCirclePitchAlignment circlePitchAlignment)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLCirclePitchAlignment:"), (UInt64)circlePitchAlignment));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLCirclePitchAlignment:"), (UInt32)circlePitchAlignment));
			}
		}
		
		[Export ("valueWithMGLCircleScaleAlignment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCircleScaleAlignment (this NSValue This, MGLCircleScaleAlignment circleScaleAlignment)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLCircleScaleAlignment:"), (UInt64)circleScaleAlignment));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLCircleScaleAlignment:"), (UInt32)circleScaleAlignment));
			}
		}
		
		[Export ("valueWithMGLCircleTranslationAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLCircleTranslationAnchor (this NSValue This, MGLCircleTranslationAnchor circleTranslationAnchor)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLCircleTranslationAnchor:"), (UInt64)circleTranslationAnchor));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLCircleTranslationAnchor:"), (UInt32)circleTranslationAnchor));
			}
		}
		
	} /* class NSValue_MGLCircleStyleLayerAdditions */
}
