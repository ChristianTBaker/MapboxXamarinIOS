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
	public unsafe static partial class NSPredicate_MGLAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSPredicate");
		
		[Export ("mgl_jsonExpressionObject")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject Mgl_jsonExpressionObject (this NSPredicate This)
		{
			return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mgl_jsonExpressionObject")));
		}
		
		[Export ("predicateWithMGLJSONObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate PredicateWithMGLJSONObject (this NSPredicate This, NSObject @object)
		{
			if (@object == null)
				throw new ArgumentNullException ("@object");
			return  Runtime.GetNSObject<NSPredicate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("predicateWithMGLJSONObject:"), @object.Handle));
		}
		
	} /* class NSPredicate_MGLAdditions */
}
