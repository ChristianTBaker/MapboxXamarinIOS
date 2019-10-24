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
	[Protocol (Name = "MGLAnnotation", WrapperType = typeof (MGLAnnotationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Coordinate", Selector = "coordinate", PropertyType = typeof (CLLocationCoordinate2D), GetterSelector = "coordinate", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Subtitle", Selector = "subtitle", PropertyType = typeof (string), GetterSelector = "subtitle", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLAnnotation : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get;
		}
		
	}
	
	public static partial class MGLAnnotation_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetTitle (this IMGLAnnotation This)
		{
			return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("title")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSubtitle (this IMGLAnnotation This)
		{
			return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("subtitle")));
		}
		
	}
	
	internal sealed class MGLAnnotationWrapper : BaseWrapper, IMGLAnnotation {
		[Preserve (Conditional = true)]
		public MGLAnnotationWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
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
namespace Mapbox {
	[Protocol()]
	[Register("MGLAnnotation", false)]
	[Model]
	public unsafe abstract partial class MGLAnnotation : NSObject, IMGLAnnotation {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MGLAnnotation () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Subtitle {
			[Export ("subtitle")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class MGLAnnotation */
}
