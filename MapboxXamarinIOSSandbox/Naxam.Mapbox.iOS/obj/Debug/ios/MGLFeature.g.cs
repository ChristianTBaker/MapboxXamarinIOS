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
	[Protocol (Name = "MGLFeature", WrapperType = typeof (MGLFeatureWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AttributeForKey", Selector = "attributeForKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof (NSObject), GetterSelector = "identifier", SetterSelector = "setIdentifier:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Attributes", Selector = "attributes", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "attributes", SetterSelector = "setAttributes:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GeoJSONDictionary", Selector = "geoJSONDictionary", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "geoJSONDictionary", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLFeature : INativeObject, IDisposable, 
		Mapbox.IMGLAnnotation
		
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("attributeForKey:")]
		[Preserve (Conditional = true)]
		NSObject AttributeForKey (string key);
		
		[Preserve (Conditional = true)]
		NSObject Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get;
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			set;
		}
		
		[Preserve (Conditional = true)]
		NSDictionary<NSString, NSObject> Attributes {
			[Export ("attributes", ArgumentSemantic.Copy)]
			get;
			[Export ("setAttributes:", ArgumentSemantic.Copy)]
			set;
		}
		
		[Preserve (Conditional = true)]
		NSDictionary<NSString, NSObject> GeoJSONDictionary {
			[Export ("geoJSONDictionary")]
			get;
		}
		
	}
	
	internal sealed class MGLFeatureWrapper : BaseWrapper, IMGLFeature {
		[Preserve (Conditional = true)]
		public MGLFeatureWrapper (IntPtr handle, bool owns)
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
