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
	public unsafe static partial class NSValue_MGLLineStyleLayerAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSValue");
		
		[Export ("MGLLineCapValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLLineCap MGLLineCapValue (this NSValue This)
		{
			MGLLineCap ret;
			if (IntPtr.Size == 8) {
				ret = (MGLLineCap) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLineCapValue"));
			} else {
				ret = (MGLLineCap) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLineCapValue"));
			}
			return ret;
		}
		
		[Export ("MGLLineJoinValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLLineJoin MGLLineJoinValue (this NSValue This)
		{
			MGLLineJoin ret;
			if (IntPtr.Size == 8) {
				ret = (MGLLineJoin) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLineJoinValue"));
			} else {
				ret = (MGLLineJoin) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLineJoinValue"));
			}
			return ret;
		}
		
		[Export ("MGLLineTranslationAnchorValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLLineTranslationAnchor MGLLineTranslationAnchorValue (this NSValue This)
		{
			MGLLineTranslationAnchor ret;
			if (IntPtr.Size == 8) {
				ret = (MGLLineTranslationAnchor) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLineTranslationAnchorValue"));
			} else {
				ret = (MGLLineTranslationAnchor) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLLineTranslationAnchorValue"));
			}
			return ret;
		}
		
		[Export ("valueWithMGLLineCap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLLineCap (this NSValue This, MGLLineCap lineCap)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLLineCap:"), (UInt64)lineCap));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLLineCap:"), (UInt32)lineCap));
			}
		}
		
		[Export ("valueWithMGLLineJoin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLLineJoin (this NSValue This, MGLLineJoin lineJoin)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLLineJoin:"), (UInt64)lineJoin));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLLineJoin:"), (UInt32)lineJoin));
			}
		}
		
		[Export ("valueWithMGLLineTranslationAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLLineTranslationAnchor (this NSValue This, MGLLineTranslationAnchor lineTranslationAnchor)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLLineTranslationAnchor:"), (UInt64)lineTranslationAnchor));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLLineTranslationAnchor:"), (UInt32)lineTranslationAnchor));
			}
		}
		
	} /* class NSValue_MGLLineStyleLayerAdditions */
}
