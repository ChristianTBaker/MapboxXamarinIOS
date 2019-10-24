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
	[Protocol (Name = "MGLMapViewDelegate", WrapperType = typeof (MGLMapViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewShouldRemoveStyleImage", Selector = "mapView:shouldRemoveStyleImage:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewShouldChangeCamera", Selector = "mapView:shouldChangeFromCamera:toCamera:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLMapCamera), typeof (Mapbox.MGLMapCamera) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewShouldChangeCameraWithReason", Selector = "mapView:shouldChangeFromCamera:toCamera:reason:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLMapCamera), typeof (Mapbox.MGLMapCamera), typeof (Mapbox.MGLCameraChangeReason) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewRegionWillChange", Selector = "mapView:regionWillChangeAnimated:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewRegionWillChangeWithReason", Selector = "mapView:regionWillChangeWithReason:animated:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLCameraChangeReason), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewRegionIsChanging", Selector = "mapViewRegionIsChanging:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewRegionIsChangingWithReason", Selector = "mapView:regionIsChangingWithReason:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLCameraChangeReason) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewRegionDidChange", Selector = "mapView:regionDidChangeAnimated:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewRegionDidChangeWithReason", Selector = "mapView:regionDidChangeWithReason:animated:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLCameraChangeReason), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewWillStartLoadingMap", Selector = "mapViewWillStartLoadingMap:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFinishLoadingMap", Selector = "mapViewDidFinishLoadingMap:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFailLoadingMap", Selector = "mapViewDidFailLoadingMap:withError:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewWillStartRenderingMap", Selector = "mapViewWillStartRenderingMap:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFinishRenderingMap", Selector = "mapViewDidFinishRenderingMap:fullyRendered:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewWillStartRenderingFrame", Selector = "mapViewWillStartRenderingFrame:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFinishRenderingFrame", Selector = "mapViewDidFinishRenderingFrame:fullyRendered:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidBecomeIdle", Selector = "mapViewDidBecomeIdle:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFinishLoadingStyle", Selector = "mapView:didFinishLoadingStyle:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLStyle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFailToLoadImage", Selector = "mapView:didFailToLoadImage:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewWillStartLocatingUser", Selector = "mapViewWillStartLocatingUser:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidStopLocatingUser", Selector = "mapViewDidStopLocatingUser:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidUpdateUserLocation", Selector = "mapView:didUpdateUserLocation:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLUserLocation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidFailToLocateUser", Selector = "mapView:didFailToLocateUserWithError:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidChangeUserTrackingMode", Selector = "mapView:didChangeUserTrackingMode:animated:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLUserTrackingMode), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewUserLocationAnchorPoint", Selector = "mapViewUserLocationAnchorPoint:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (Mapbox.MGLMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_ImageForAnnotation", Selector = "mapView:imageForAnnotation:", ReturnType = typeof (Mapbox.MGLAnnotationImage), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_AlphaForShapeAnnotation", Selector = "mapView:alphaForShapeAnnotation:", ReturnType = typeof (nfloat), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLShape) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_StrokeColorForShapeAnnotation", Selector = "mapView:strokeColorForShapeAnnotation:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLShape) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_FillColorForPolygonAnnotation", Selector = "mapView:fillColorForPolygonAnnotation:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLPolygon) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_LineWidthForPolylineAnnotation", Selector = "mapView:lineWidthForPolylineAnnotation:", ReturnType = typeof (nfloat), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLPolyline) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_ViewForAnnotation", Selector = "mapView:viewForAnnotation:", ReturnType = typeof (Mapbox.MGLAnnotationView), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidAddAnnotationViews", Selector = "mapView:didAddAnnotationViews:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLAnnotationView[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewShapeAnnotationIsEnabled", Selector = "mapView:shapeAnnotationIsEnabled:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLShape) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidSelectAnnotation", Selector = "mapView:didSelectAnnotation:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidDeselectAnnotation", Selector = "mapView:didDeselectAnnotation:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidSelectAnnotationView", Selector = "mapView:didSelectAnnotationView:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLAnnotationView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapViewDidDeselectAnnotationView", Selector = "mapView:didDeselectAnnotationView:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.MGLAnnotationView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_AnnotationCanShowCallout", Selector = "mapView:annotationCanShowCallout:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_CalloutViewForAnnotation", Selector = "mapView:calloutViewForAnnotation:", ReturnType = typeof (Mapbox.MGLCalloutView), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_LeftCalloutAccessoryViewForAnnotation", Selector = "mapView:leftCalloutAccessoryViewForAnnotation:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_RightCalloutAccessoryViewForAnnotation", Selector = "mapView:rightCalloutAccessoryViewForAnnotation:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_CalloutAccessoryControlTapped", Selector = "mapView:annotation:calloutAccessoryControlTapped:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation), typeof (UIControl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_TapOnCalloutForAnnotation", Selector = "mapView:tapOnCalloutForAnnotation:", ParameterType = new Type [] { typeof (Mapbox.MGLMapView), typeof (Mapbox.IMGLAnnotation) }, ParameterByRef = new bool [] { false, false })]
	public interface IMGLMapViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MGLMapViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MapViewShouldRemoveStyleImage (this IMGLMapViewDelegate This, MGLMapView mapView, string imageName)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (imageName == null)
				throw new ArgumentNullException ("imageName");
			var nsimageName = NSString.CreateNative (imageName);
			
			bool ret;
			ret = global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:shouldRemoveStyleImage:"), mapView.Handle, nsimageName);
			NSString.ReleaseNative (nsimageName);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MapViewShouldChangeCamera (this IMGLMapViewDelegate This, MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (oldCamera == null)
				throw new ArgumentNullException ("oldCamera");
			if (newCamera == null)
				throw new ArgumentNullException ("newCamera");
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:shouldChangeFromCamera:toCamera:"), mapView.Handle, oldCamera.Handle, newCamera.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MapViewShouldChangeCameraWithReason (this IMGLMapViewDelegate This, MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera, MGLCameraChangeReason reason)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (oldCamera == null)
				throw new ArgumentNullException ("oldCamera");
			if (newCamera == null)
				throw new ArgumentNullException ("newCamera");
			if (IntPtr.Size == 8) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("mapView:shouldChangeFromCamera:toCamera:reason:"), mapView.Handle, oldCamera.Handle, newCamera.Handle, (UInt64)reason);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("mapView:shouldChangeFromCamera:toCamera:reason:"), mapView.Handle, oldCamera.Handle, newCamera.Handle, (UInt32)reason);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewRegionWillChange (this IMGLMapViewDelegate This, MGLMapView mapView, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mapView:regionWillChangeAnimated:"), mapView.Handle, animated);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewRegionWillChangeWithReason (this IMGLMapViewDelegate This, MGLMapView mapView, MGLCameraChangeReason reason, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt64_bool (This.Handle, Selector.GetHandle ("mapView:regionWillChangeWithReason:animated:"), mapView.Handle, (UInt64)reason, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32_bool (This.Handle, Selector.GetHandle ("mapView:regionWillChangeWithReason:animated:"), mapView.Handle, (UInt32)reason, animated);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewRegionIsChanging (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewRegionIsChanging:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewRegionIsChangingWithReason (this IMGLMapViewDelegate This, MGLMapView mapView, MGLCameraChangeReason reason)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("mapView:regionIsChangingWithReason:"), mapView.Handle, (UInt64)reason);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("mapView:regionIsChangingWithReason:"), mapView.Handle, (UInt32)reason);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewRegionDidChange (this IMGLMapViewDelegate This, MGLMapView mapView, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mapView:regionDidChangeAnimated:"), mapView.Handle, animated);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewRegionDidChangeWithReason (this IMGLMapViewDelegate This, MGLMapView mapView, MGLCameraChangeReason reason, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt64_bool (This.Handle, Selector.GetHandle ("mapView:regionDidChangeWithReason:animated:"), mapView.Handle, (UInt64)reason, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32_bool (This.Handle, Selector.GetHandle ("mapView:regionDidChangeWithReason:animated:"), mapView.Handle, (UInt32)reason, animated);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewWillStartLoadingMap (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewWillStartLoadingMap:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidFinishLoadingMap (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewDidFinishLoadingMap:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidFailLoadingMap (this IMGLMapViewDelegate This, MGLMapView mapView, NSError error)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapViewDidFailLoadingMap:withError:"), mapView.Handle, error.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewWillStartRenderingMap (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewWillStartRenderingMap:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidFinishRenderingMap (this IMGLMapViewDelegate This, MGLMapView mapView, bool fullyRendered)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mapViewDidFinishRenderingMap:fullyRendered:"), mapView.Handle, fullyRendered);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewWillStartRenderingFrame (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewWillStartRenderingFrame:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidFinishRenderingFrame (this IMGLMapViewDelegate This, MGLMapView mapView, bool fullyRendered)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mapViewDidFinishRenderingFrame:fullyRendered:"), mapView.Handle, fullyRendered);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidBecomeIdle (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewDidBecomeIdle:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidFinishLoadingStyle (this IMGLMapViewDelegate This, MGLMapView mapView, MGLStyle style)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (style == null)
				throw new ArgumentNullException ("style");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didFinishLoadingStyle:"), mapView.Handle, style.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage MapViewDidFailToLoadImage (this IMGLMapViewDelegate This, MGLMapView mapView, NSString imageName)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (imageName == null)
				throw new ArgumentNullException ("imageName");
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didFailToLoadImage:"), mapView.Handle, imageName.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewWillStartLocatingUser (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewWillStartLocatingUser:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidStopLocatingUser (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewDidStopLocatingUser:"), mapView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidUpdateUserLocation (this IMGLMapViewDelegate This, MGLMapView mapView, MGLUserLocation userLocation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didUpdateUserLocation:"), mapView.Handle, userLocation == null ? IntPtr.Zero : userLocation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidFailToLocateUser (this IMGLMapViewDelegate This, MGLMapView mapView, NSError error)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didFailToLocateUserWithError:"), mapView.Handle, error.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidChangeUserTrackingMode (this IMGLMapViewDelegate This, MGLMapView mapView, MGLUserTrackingMode mode, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt64_bool (This.Handle, Selector.GetHandle ("mapView:didChangeUserTrackingMode:animated:"), mapView.Handle, (UInt64)mode, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32_bool (This.Handle, Selector.GetHandle ("mapView:didChangeUserTrackingMode:animated:"), mapView.Handle, (UInt32)mode, animated);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint MapViewUserLocationAnchorPoint (this IMGLMapViewDelegate This, MGLMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			CGPoint ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewUserLocationAnchorPoint:"), mapView.Handle);
				} else {
					global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret_IntPtr (out ret, This.Handle, Selector.GetHandle ("mapViewUserLocationAnchorPoint:"), mapView.Handle);
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewUserLocationAnchorPoint:"), mapView.Handle);
			} else {
				ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapViewUserLocationAnchorPoint:"), mapView.Handle);
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLAnnotationImage MapView_ImageForAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<MGLAnnotationImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:imageForAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat MapView_AlphaForShapeAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, MGLShape annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return global::ApiDefinitions.Messaging.nfloat_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:alphaForShapeAnnotation:"), mapView.Handle, annotation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor MapView_StrokeColorForShapeAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, MGLShape annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:strokeColorForShapeAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor MapView_FillColorForPolygonAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, MGLPolygon annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:fillColorForPolygonAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat MapView_LineWidthForPolylineAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, MGLPolyline annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return global::ApiDefinitions.Messaging.nfloat_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:lineWidthForPolylineAnnotation:"), mapView.Handle, annotation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLAnnotationView MapView_ViewForAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<MGLAnnotationView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:viewForAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidAddAnnotationViews (this IMGLMapViewDelegate This, MGLMapView mapView, MGLAnnotationView[] annotationViews)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotationViews == null)
				throw new ArgumentNullException ("annotationViews");
			var nsa_annotationViews = NSArray.FromNSObjects (annotationViews);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didAddAnnotationViews:"), mapView.Handle, nsa_annotationViews.Handle);
			nsa_annotationViews.Dispose ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MapViewShapeAnnotationIsEnabled (this IMGLMapViewDelegate This, MGLMapView mapView, MGLShape annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:shapeAnnotationIsEnabled:"), mapView.Handle, annotation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidSelectAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didSelectAnnotation:"), mapView.Handle, annotation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidDeselectAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didDeselectAnnotation:"), mapView.Handle, annotation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidSelectAnnotationView (this IMGLMapViewDelegate This, MGLMapView mapView, MGLAnnotationView annotationView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didSelectAnnotationView:"), mapView.Handle, annotationView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapViewDidDeselectAnnotationView (this IMGLMapViewDelegate This, MGLMapView mapView, MGLAnnotationView annotationView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:didDeselectAnnotationView:"), mapView.Handle, annotationView.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MapView_AnnotationCanShowCallout (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:annotationCanShowCallout:"), mapView.Handle, annotation.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLCalloutView MapView_CalloutViewForAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<MGLCalloutView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:calloutViewForAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView MapView_LeftCalloutAccessoryViewForAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:leftCalloutAccessoryViewForAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView MapView_RightCalloutAccessoryViewForAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:rightCalloutAccessoryViewForAnnotation:"), mapView.Handle, annotation.Handle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapView_CalloutAccessoryControlTapped (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation, global::UIKit.UIControl control)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (control == null)
				throw new ArgumentNullException ("control");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:annotation:calloutAccessoryControlTapped:"), mapView.Handle, annotation.Handle, control.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapView_TapOnCalloutForAnnotation (this IMGLMapViewDelegate This, MGLMapView mapView, IMGLAnnotation annotation)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("mapView:tapOnCalloutForAnnotation:"), mapView.Handle, annotation.Handle);
		}
		
	}
	
	internal sealed class MGLMapViewDelegateWrapper : BaseWrapper, IMGLMapViewDelegate {
		[Preserve (Conditional = true)]
		public MGLMapViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLMapViewDelegate", false)]
	[Model]
	public unsafe partial class MGLMapViewDelegate : NSObject, IMGLMapViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLMapViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("mapView:didAddAnnotationViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidAddAnnotationViews (MGLMapView mapView, MGLAnnotationView[] annotationViews)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewDidBecomeIdle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidBecomeIdle (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didChangeUserTrackingMode:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidChangeUserTrackingMode (MGLMapView mapView, MGLUserTrackingMode mode, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didDeselectAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidDeselectAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didDeselectAnnotationView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidDeselectAnnotationView (MGLMapView mapView, MGLAnnotationView annotationView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewDidFailLoadingMap:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidFailLoadingMap (MGLMapView mapView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didFailToLoadImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage MapViewDidFailToLoadImage (MGLMapView mapView, NSString imageName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didFailToLocateUserWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidFailToLocateUser (MGLMapView mapView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewDidFinishLoadingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidFinishLoadingMap (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didFinishLoadingStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidFinishLoadingStyle (MGLMapView mapView, MGLStyle style)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewDidFinishRenderingFrame:fullyRendered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidFinishRenderingFrame (MGLMapView mapView, bool fullyRendered)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidFinishRenderingMap (MGLMapView mapView, bool fullyRendered)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didSelectAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidSelectAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didSelectAnnotationView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidSelectAnnotationView (MGLMapView mapView, MGLAnnotationView annotationView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewDidStopLocatingUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidStopLocatingUser (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:didUpdateUserLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewDidUpdateUserLocation (MGLMapView mapView, MGLUserLocation userLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionDidChangeAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewRegionDidChange (MGLMapView mapView, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionDidChangeWithReason:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewRegionDidChangeWithReason (MGLMapView mapView, MGLCameraChangeReason reason, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewRegionIsChanging:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewRegionIsChanging (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionIsChangingWithReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewRegionIsChangingWithReason (MGLMapView mapView, MGLCameraChangeReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionWillChangeAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewRegionWillChange (MGLMapView mapView, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionWillChangeWithReason:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewRegionWillChangeWithReason (MGLMapView mapView, MGLCameraChangeReason reason, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:shapeAnnotationIsEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MapViewShapeAnnotationIsEnabled (MGLMapView mapView, MGLShape annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:shouldChangeFromCamera:toCamera:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MapViewShouldChangeCamera (MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:shouldChangeFromCamera:toCamera:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MapViewShouldChangeCameraWithReason (MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera, MGLCameraChangeReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:shouldRemoveStyleImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MapViewShouldRemoveStyleImage (MGLMapView mapView, string imageName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewUserLocationAnchorPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint MapViewUserLocationAnchorPoint (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewWillStartLoadingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewWillStartLoadingMap (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewWillStartLocatingUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewWillStartLocatingUser (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewWillStartRenderingFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewWillStartRenderingFrame (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapViewWillStartRenderingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapViewWillStartRenderingMap (MGLMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:alphaForShapeAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MapView_AlphaForShapeAnnotation (MGLMapView mapView, MGLShape annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:annotationCanShowCallout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MapView_AnnotationCanShowCallout (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:annotation:calloutAccessoryControlTapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapView_CalloutAccessoryControlTapped (MGLMapView mapView, IMGLAnnotation annotation, global::UIKit.UIControl control)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:calloutViewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCalloutView MapView_CalloutViewForAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:fillColorForPolygonAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor MapView_FillColorForPolygonAnnotation (MGLMapView mapView, MGLPolygon annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:imageForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotationImage MapView_ImageForAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:leftCalloutAccessoryViewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView MapView_LeftCalloutAccessoryViewForAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:lineWidthForPolylineAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MapView_LineWidthForPolylineAnnotation (MGLMapView mapView, MGLPolyline annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:rightCalloutAccessoryViewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView MapView_RightCalloutAccessoryViewForAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:strokeColorForShapeAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor MapView_StrokeColorForShapeAnnotation (MGLMapView mapView, MGLShape annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:tapOnCalloutForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapView_TapOnCalloutForAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:viewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotationView MapView_ViewForAnnotation (MGLMapView mapView, IMGLAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MGLMapViewDelegate */
}
