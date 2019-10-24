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
	[Protocol (Name = "MGLOfflineRegion", WrapperType = typeof (MGLOfflineRegionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StyleURL", Selector = "styleURL", PropertyType = typeof (NSUrl), GetterSelector = "styleURL", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IncludesIdeographicGlyphs", Selector = "includesIdeographicGlyphs", PropertyType = typeof (bool), GetterSelector = "includesIdeographicGlyphs", SetterSelector = "setIncludesIdeographicGlyphs:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLOfflineRegion : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		NSUrl StyleURL {
			[Export ("styleURL")]
			get;
		}
		
		[Preserve (Conditional = true)]
		bool IncludesIdeographicGlyphs {
			[Export ("includesIdeographicGlyphs")]
			get;
			[Export ("setIncludesIdeographicGlyphs:")]
			set;
		}
		
	}
	
	internal sealed class MGLOfflineRegionWrapper : BaseWrapper, IMGLOfflineRegion {
		[Preserve (Conditional = true)]
		public MGLOfflineRegionWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl StyleURL {
			[Export ("styleURL")]
			get {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleURL")));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IncludesIdeographicGlyphs {
			[Export ("includesIdeographicGlyphs")]
			get {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("includesIdeographicGlyphs"));
			}
			
			[Export ("setIncludesIdeographicGlyphs:")]
			set {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIncludesIdeographicGlyphs:"), value);
			}
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLOfflineRegion", false)]
	[Model]
	public unsafe abstract partial class MGLOfflineRegion : NSObject, IMGLOfflineRegion {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MGLOfflineRegion () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLOfflineRegion (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLOfflineRegion (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract bool IncludesIdeographicGlyphs {
			[Export ("includesIdeographicGlyphs")]
			get; 
			[Export ("setIncludesIdeographicGlyphs:")]
			set; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract NSUrl StyleURL {
			[Export ("styleURL")]
			get; 
		}
		
	} /* class MGLOfflineRegion */
}
