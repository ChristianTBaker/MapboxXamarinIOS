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
	[Protocol (Name = "MGLCluster", WrapperType = typeof (MGLClusterWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ClusterIdentifier", Selector = "clusterIdentifier", PropertyType = typeof (uint), GetterSelector = "clusterIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ClusterPointCount", Selector = "clusterPointCount", PropertyType = typeof (uint), GetterSelector = "clusterPointCount", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLCluster : INativeObject, IDisposable, 
		Mapbox.IMGLAnnotation
		, Mapbox.IMGLFeature
		
	{
		[Preserve (Conditional = true)]
		uint ClusterIdentifier {
			[Export ("clusterIdentifier")]
			get;
		}
		
		[Preserve (Conditional = true)]
		uint ClusterPointCount {
			[Export ("clusterPointCount")]
			get;
		}
		
	}
	
	internal sealed class MGLClusterWrapper : BaseWrapper, IMGLCluster {
		[Preserve (Conditional = true)]
		public MGLClusterWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("attributeForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject AttributeForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("attributeForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public uint ClusterIdentifier {
			[Export ("clusterIdentifier")]
			get {
				return global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("clusterIdentifier"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public uint ClusterPointCount {
			[Export ("clusterPointCount")]
			get {
				return global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("clusterPointCount"));
			}
			
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
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")));
			}
			
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			set {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIdentifier:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject> Attributes {
			[Export ("attributes", ArgumentSemantic.Copy)]
			get {
				return  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributes")));
			}
			
			[Export ("setAttributes:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAttributes:"), value.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject> GeoJSONDictionary {
			[Export ("geoJSONDictionary")]
			get {
				return  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("geoJSONDictionary")));
			}
			
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLCluster", false)]
	[Model]
	public unsafe abstract partial class MGLCluster : NSObject, IMGLCluster, IMGLAnnotation, IMGLFeature {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MGLCluster () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLCluster (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLCluster (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("attributeForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject AttributeForKey (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> Attributes {
			[Export ("attributes", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setAttributes:", ArgumentSemantic.Copy)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract uint ClusterIdentifier {
			[Export ("clusterIdentifier")]
			get; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract uint ClusterPointCount {
			[Export ("clusterPointCount")]
			get; 
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> GeoJSONDictionary {
			[Export ("geoJSONDictionary")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			set {
				throw new ModelNotImplementedException ();
			}
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
		
	} /* class MGLCluster */
}
