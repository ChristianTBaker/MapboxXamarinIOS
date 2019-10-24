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
	[Protocol (Name = "MGLComputedShapeSourceDataSource", WrapperType = typeof (MGLComputedShapeSourceDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FeaturesInTileAtX", Selector = "featuresInTileAtX:y:zoomLevel:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (nuint), typeof (nuint), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FeaturesInCoordinateBounds", Selector = "featuresInCoordinateBounds:zoomLevel:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (Mapbox.MGLCoordinateBounds), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IMGLComputedShapeSourceDataSource : INativeObject, IDisposable
	{
	}
	
	public static partial class MGLComputedShapeSourceDataSource_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] FeaturesInTileAtX (this IMGLComputedShapeSourceDataSource This, nuint x, nuint y, nuint zoomLevel)
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint (This.Handle, Selector.GetHandle ("featuresInTileAtX:y:zoomLevel:"), x, y, zoomLevel));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] FeaturesInCoordinateBounds (this IMGLComputedShapeSourceDataSource This, MGLCoordinateBounds bounds, nuint zoomLevel)
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLCoordinateBounds_nuint (This.Handle, Selector.GetHandle ("featuresInCoordinateBounds:zoomLevel:"), bounds, zoomLevel));
		}
		
	}
	
	internal sealed class MGLComputedShapeSourceDataSourceWrapper : BaseWrapper, IMGLComputedShapeSourceDataSource {
		[Preserve (Conditional = true)]
		public MGLComputedShapeSourceDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLComputedShapeSourceDataSource", false)]
	[Model]
	public unsafe partial class MGLComputedShapeSourceDataSource : NSObject, IMGLComputedShapeSourceDataSource {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLComputedShapeSourceDataSource () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLComputedShapeSourceDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLComputedShapeSourceDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("featuresInCoordinateBounds:zoomLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] FeaturesInCoordinateBounds (MGLCoordinateBounds bounds, nuint zoomLevel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("featuresInTileAtX:y:zoomLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] FeaturesInTileAtX (nuint x, nuint y, nuint zoomLevel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MGLComputedShapeSourceDataSource */
}
