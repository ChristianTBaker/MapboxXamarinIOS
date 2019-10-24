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
	public unsafe static partial class NSValue_MGLHillshadeStyleLayerAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSValue");
		
		[Export ("MGLHillshadeIlluminationAnchorValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLHillshadeIlluminationAnchor MGLHillshadeIlluminationAnchorValue (this NSValue This)
		{
			MGLHillshadeIlluminationAnchor ret;
			if (IntPtr.Size == 8) {
				ret = (MGLHillshadeIlluminationAnchor) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLHillshadeIlluminationAnchorValue"));
			} else {
				ret = (MGLHillshadeIlluminationAnchor) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLHillshadeIlluminationAnchorValue"));
			}
			return ret;
		}
		
		[Export ("valueWithMGLHillshadeIlluminationAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLHillshadeIlluminationAnchor (this NSValue This, MGLHillshadeIlluminationAnchor hillshadeIlluminationAnchor)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLHillshadeIlluminationAnchor:"), (UInt64)hillshadeIlluminationAnchor));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLHillshadeIlluminationAnchor:"), (UInt32)hillshadeIlluminationAnchor));
			}
		}
		
	} /* class NSValue_MGLHillshadeStyleLayerAdditions */
}
