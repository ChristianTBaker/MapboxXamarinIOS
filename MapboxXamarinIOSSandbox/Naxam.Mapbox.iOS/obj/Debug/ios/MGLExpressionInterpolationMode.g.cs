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
	public unsafe static partial class MGLExpressionInterpolationMode  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _CubicBezier;
		[Field ("MGLExpressionInterpolationModeCubicBezier",  "__Internal")]
		public static NSString CubicBezier {
			get {
				if (_CubicBezier == null)
					_CubicBezier = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLExpressionInterpolationModeCubicBezier");
				return _CubicBezier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _Exponential;
		[Field ("MGLExpressionInterpolationModeExponential",  "__Internal")]
		public static NSString Exponential {
			get {
				if (_Exponential == null)
					_Exponential = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLExpressionInterpolationModeExponential");
				return _Exponential;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _Linear;
		[Field ("MGLExpressionInterpolationModeLinear",  "__Internal")]
		public static NSString Linear {
			get {
				if (_Linear == null)
					_Linear = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLExpressionInterpolationModeLinear");
				return _Linear;
			}
		}
	} /* class MGLExpressionInterpolationMode */
}
