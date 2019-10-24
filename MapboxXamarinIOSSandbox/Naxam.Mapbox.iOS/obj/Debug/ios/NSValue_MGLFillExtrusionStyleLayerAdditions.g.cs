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
	public unsafe static partial class NSValue_MGLFillExtrusionStyleLayerAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSValue");
		
		[Export ("MGLFillExtrusionTranslationAnchorValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLFillExtrusionTranslationAnchor MGLFillExtrusionTranslationAnchorValue (this NSValue This)
		{
			MGLFillExtrusionTranslationAnchor ret;
			if (IntPtr.Size == 8) {
				ret = (MGLFillExtrusionTranslationAnchor) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("MGLFillExtrusionTranslationAnchorValue"));
			} else {
				ret = (MGLFillExtrusionTranslationAnchor) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("MGLFillExtrusionTranslationAnchorValue"));
			}
			return ret;
		}
		
		[Export ("valueWithMGLFillExtrusionTranslationAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueWithMGLFillExtrusionTranslationAnchor (this NSValue This, MGLFillExtrusionTranslationAnchor fillExtrusionTranslationAnchor)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("valueWithMGLFillExtrusionTranslationAnchor:"), (UInt64)fillExtrusionTranslationAnchor));
			} else {
				return  Runtime.GetNSObject<NSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("valueWithMGLFillExtrusionTranslationAnchor:"), (UInt32)fillExtrusionTranslationAnchor));
			}
		}
		
	} /* class NSValue_MGLFillExtrusionStyleLayerAdditions */
}
