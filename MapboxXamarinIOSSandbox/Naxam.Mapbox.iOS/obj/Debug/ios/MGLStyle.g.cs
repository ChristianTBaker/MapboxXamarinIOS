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
	[Register("MGLStyle", true)]
	public unsafe partial class MGLStyle : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLStyle");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLStyle () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLStyle (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLStyle (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddLayer (MGLStyleLayer layer)
		{
			if (layer == null)
				throw new ArgumentNullException ("layer");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addLayer:"), layer.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addLayer:"), layer.Handle);
			}
		}
		
		[Export ("addSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSource (MGLSource source)
		{
			if (source == null)
				throw new ArgumentNullException ("source");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addSource:"), source.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addSource:"), source.Handle);
			}
		}
		
		[Export ("darkStyleURLWithVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl DarkStyleURLWithVersion (nint version)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nint (class_ptr, Selector.GetHandle ("darkStyleURLWithVersion:"), version));
		}
		
		[Export ("imageForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage ImageForName (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("imageForName:"), nsname));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("imageForName:"), nsname));
			}
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("insertLayer:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertLayer (MGLStyleLayer layer, nuint index)
		{
			if (layer == null)
				throw new ArgumentNullException ("layer");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("insertLayer:atIndex:"), layer.Handle, index);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("insertLayer:atIndex:"), layer.Handle, index);
			}
		}
		
		[Export ("insertLayer:aboveLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertLayerAbove (MGLStyleLayer layer, MGLStyleLayer sibling)
		{
			if (layer == null)
				throw new ArgumentNullException ("layer");
			if (sibling == null)
				throw new ArgumentNullException ("sibling");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertLayer:aboveLayer:"), layer.Handle, sibling.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("insertLayer:aboveLayer:"), layer.Handle, sibling.Handle);
			}
		}
		
		[Export ("insertLayer:belowLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertLayerBelow (MGLStyleLayer layer, MGLStyleLayer sibling)
		{
			if (layer == null)
				throw new ArgumentNullException ("layer");
			if (sibling == null)
				throw new ArgumentNullException ("sibling");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertLayer:belowLayer:"), layer.Handle, sibling.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("insertLayer:belowLayer:"), layer.Handle, sibling.Handle);
			}
		}
		
		[Export ("layerWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLStyleLayer LayerWithIdentifier (string identifier)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			MGLStyleLayer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MGLStyleLayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("layerWithIdentifier:"), nsidentifier));
			} else {
				ret =  Runtime.GetNSObject<MGLStyleLayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("layerWithIdentifier:"), nsidentifier));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("lightStyleURLWithVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl LightStyleURLWithVersion (nint version)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nint (class_ptr, Selector.GetHandle ("lightStyleURLWithVersion:"), version));
		}
		
		[Export ("localizeLabelsIntoLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalizeLabelsIntoLocale (NSLocale locale)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("localizeLabelsIntoLocale:"), locale == null ? IntPtr.Zero : locale.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("localizeLabelsIntoLocale:"), locale == null ? IntPtr.Zero : locale.Handle);
			}
		}
		
		[Export ("outdoorsStyleURLWithVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl OutdoorsStyleURLWithVersion (nint version)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nint (class_ptr, Selector.GetHandle ("outdoorsStyleURLWithVersion:"), version));
		}
		
		[Export ("removeImageForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveImageForName (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeImageForName:"), nsname);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeImageForName:"), nsname);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("removeLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveLayer (MGLStyleLayer layer)
		{
			if (layer == null)
				throw new ArgumentNullException ("layer");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeLayer:"), layer.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeLayer:"), layer.Handle);
			}
		}
		
		[Export ("removeSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSource (MGLSource source)
		{
			if (source == null)
				throw new ArgumentNullException ("source");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeSource:"), source.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeSource:"), source.Handle);
			}
		}
		
		[Export ("removeSource:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveSource (MGLSource source, NSError outError)
		{
			if (source == null)
				throw new ArgumentNullException ("source");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeSource:error:"), source.Handle, outError == null ? IntPtr.Zero : outError.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeSource:error:"), source.Handle, outError == null ? IntPtr.Zero : outError.Handle);
			}
		}
		
		[Export ("satelliteStreetsStyleURLWithVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl SatelliteStreetsStyleURLWithVersion (nint version)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nint (class_ptr, Selector.GetHandle ("satelliteStreetsStyleURLWithVersion:"), version));
		}
		
		[Export ("satelliteStyleURLWithVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl SatelliteStyleURLWithVersion (nint version)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nint (class_ptr, Selector.GetHandle ("satelliteStyleURLWithVersion:"), version));
		}
		
		[Export ("setImage:forName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImage (global::UIKit.UIImage image, string name)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setImage:forName:"), image.Handle, nsname);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setImage:forName:"), image.Handle, nsname);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("sourceWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLSource SourceWithIdentifier (string identifier)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			MGLSource ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MGLSource> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sourceWithIdentifier:"), nsidentifier));
			} else {
				ret =  Runtime.GetNSObject<MGLSource> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sourceWithIdentifier:"), nsidentifier));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("streetsStyleURLWithVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl StreetsStyleURLWithVersion (nint version)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nint (class_ptr, Selector.GetHandle ("streetsStyleURLWithVersion:"), version));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl DarkStyleURL {
			[Export ("darkStyleURL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("darkStyleURL")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLStyleLayer[] Layers {
			[Export ("layers", ArgumentSemantic.Retain)]
			get {
				MGLStyleLayer[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MGLStyleLayer>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("layers")));
				} else {
					ret = NSArray.ArrayFromHandle<MGLStyleLayer>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("layers")));
				}
				return ret;
			}
			
			[Export ("setLayers:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLayers:"), nsa_value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLayers:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLLight Light {
			[Export ("light", ArgumentSemantic.Retain)]
			get {
				MGLLight ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLLight> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("light")));
				} else {
					ret =  Runtime.GetNSObject<MGLLight> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("light")));
				}
				return ret;
			}
			
			[Export ("setLight:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLight:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLight:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl LightStyleURL {
			[Export ("lightStyleURL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("lightStyleURL")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl OutdoorsStyleURL {
			[Export ("outdoorsStyleURL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("outdoorsStyleURL")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformsPlacementTransitions {
			[Export ("performsPlacementTransitions")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("performsPlacementTransitions"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("performsPlacementTransitions"));
				}
			}
			
			[Export ("setPerformsPlacementTransitions:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPerformsPlacementTransitions:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPerformsPlacementTransitions:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl SatelliteStreetsStyleURL {
			[Export ("satelliteStreetsStyleURL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("satelliteStreetsStyleURL")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl SatelliteStyleURL {
			[Export ("satelliteStyleURL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("satelliteStyleURL")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet Sources {
			[Export ("sources", ArgumentSemantic.Retain)]
			get {
				NSSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sources")));
				} else {
					ret =  Runtime.GetNSObject<NSSet> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sources")));
				}
				return ret;
			}
			
			[Export ("setSources:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSources:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSources:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl StreetsStyleURL {
			[Export ("streetsStyleURL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("streetsStyleURL")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLTransition Transition {
			[Export ("transition", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLTransition ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("transition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("transition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend (this.Handle, Selector.GetHandle ("transition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("transition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transition"));
						} else {
							global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("transition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transition"));
					} else {
						global::ApiDefinitions.Messaging.MGLTransition_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("transition"));
					}
				}
				return ret;
			}
			
			[Export ("setTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLTransition (this.Handle, Selector.GetHandle ("setTransition:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLTransition (this.SuperHandle, Selector.GetHandle ("setTransition:"), value);
				}
			}
		}
		
	} /* class MGLStyle */
}
