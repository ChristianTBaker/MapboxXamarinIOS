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
	public unsafe static partial class NSValue_MGLRasterStyleLayerAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSValue");
		
		[Export ("valueWithMGLRasterResamplingMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLRasterResamplingMode (this NSValue This, MGLRasterResamplingMode rasterResamplingMode)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLRasterResamplingMode:"), (UInt64)rasterResamplingMode));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLRasterResamplingMode:"), (UInt32)rasterResamplingMode));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLRasterResamplingMode MGLRasterResamplingModeValue {
			[Export ("MGLRasterResamplingModeValue")]
			get {
				MGLRasterResamplingMode ret;
				if (IntPtr.Size == 8) {
					ret = (MGLRasterResamplingMode) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (class_ptr, Selector.GetHandle ("MGLRasterResamplingModeValue"));
				} else {
					ret = (MGLRasterResamplingMode) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (class_ptr, Selector.GetHandle ("MGLRasterResamplingModeValue"));
				}
				return ret;
			}
			
		}
		
	} /* class NSValue_MGLRasterStyleLayerAdditions */
}
