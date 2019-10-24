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
	[Register("MGLMapView", true)]
	public unsafe partial class MGLMapView : global::UIKit.UIView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MGLMapView (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLMapView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLMapView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("initWithFrame:styleURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLMapView (CGRect frame, NSUrl styleURL)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:styleURL:"), frame, styleURL == null ? IntPtr.Zero : styleURL.Handle), "initWithFrame:styleURL:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:styleURL:"), frame, styleURL == null ? IntPtr.Zero : styleURL.Handle), "initWithFrame:styleURL:");
			}
		}
		
		[Export ("addAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (IMGLAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAnnotation:"), annotation.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotation:"), annotation.Handle);
			}
		}
		
		[Export ("addAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotations (IMGLAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("addOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlay (IMGLOverlay overlay)
		{
			if (overlay == null)
				throw new ArgumentNullException ("overlay");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addOverlay:"), overlay.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addOverlay:"), overlay.Handle);
			}
		}
		
		[Export ("addOverlays:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlays (IMGLOverlay[] overlays)
		{
			if (overlays == null)
				throw new ArgumentNullException ("overlays");
			var nsa_overlays = NSArray.FromNSObjects (overlays);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addOverlays:"), nsa_overlays.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addOverlays:"), nsa_overlays.Handle);
			}
			nsa_overlays.Dispose ();
			
		}
		
		[Export ("anchorPointForGesture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint AnchorPointForGesture (global::UIKit.UIGestureRecognizer gesture)
		{
			if (gesture == null)
				throw new ArgumentNullException ("gesture");
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
					} else {
						global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret_IntPtr (out ret, this.Handle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
				} else {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
					} else {
						global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
				} else {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("anchorPointForGesture:"), gesture.Handle);
				}
			}
			return ret;
		}
		
		[Export ("camera:fittingCoordinateBounds:edgePadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera CameraFittingCoordinateBounds (MGLMapCamera camera, MGLCoordinateBounds bounds, global::UIKit.UIEdgeInsets insets)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_MGLCoordinateBounds_UIEdgeInsets (this.Handle, Selector.GetHandle ("camera:fittingCoordinateBounds:edgePadding:"), camera.Handle, bounds, insets));
			} else {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_MGLCoordinateBounds_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("camera:fittingCoordinateBounds:edgePadding:"), camera.Handle, bounds, insets));
			}
		}
		
		[Export ("camera:fittingShape:edgePadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera CameraFittingShape (MGLMapCamera camera, MGLShape shape, global::UIKit.UIEdgeInsets insets)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (shape == null)
				throw new ArgumentNullException ("shape");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UIEdgeInsets (this.Handle, Selector.GetHandle ("camera:fittingShape:edgePadding:"), camera.Handle, shape.Handle, insets));
			} else {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("camera:fittingShape:edgePadding:"), camera.Handle, shape.Handle, insets));
			}
		}
		
		[Export ("cameraThatFitsCoordinateBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera CameraThatFitsCoordinateBounds (MGLCoordinateBounds bounds)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLCoordinateBounds (this.Handle, Selector.GetHandle ("cameraThatFitsCoordinateBounds:"), bounds));
			} else {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_MGLCoordinateBounds (this.SuperHandle, Selector.GetHandle ("cameraThatFitsCoordinateBounds:"), bounds));
			}
		}
		
		[Export ("cameraThatFitsCoordinateBounds:edgePadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera CameraThatFitsCoordinateBounds (MGLCoordinateBounds bounds, global::UIKit.UIEdgeInsets insets)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_MGLCoordinateBounds_UIEdgeInsets (this.Handle, Selector.GetHandle ("cameraThatFitsCoordinateBounds:edgePadding:"), bounds, insets));
			} else {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_MGLCoordinateBounds_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("cameraThatFitsCoordinateBounds:edgePadding:"), bounds, insets));
			}
		}
		
		[Export ("cameraThatFitsShape:direction:edgePadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera CameraThatFitsShape (MGLShape shape, double direction, global::UIKit.UIEdgeInsets insets)
		{
			if (shape == null)
				throw new ArgumentNullException ("shape");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_Double_UIEdgeInsets (this.Handle, Selector.GetHandle ("cameraThatFitsShape:direction:edgePadding:"), shape.Handle, direction, insets));
			} else {
				return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("cameraThatFitsShape:direction:edgePadding:"), shape.Handle, direction, insets));
			}
		}
		
		[Export ("convertCoordinate:toPointToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, global::UIKit.UIView view)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret_CLLocationCoordinate2D_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				} else {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret_CLLocationCoordinate2D_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				} else {
					ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("convertCoordinateBounds:toRectToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertCoordinateBounds (MGLCoordinateBounds bounds, global::UIKit.UIView view)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGRect_objc_msgSend_MGLCoordinateBounds_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.CGRect_objc_msgSend_stret_MGLCoordinateBounds_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.CGRect_objc_msgSend_stret_MGLCoordinateBounds_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinitions.Messaging.CGRect_objc_msgSend_stret_MGLCoordinateBounds_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGRect_objc_msgSendSuper_MGLCoordinateBounds_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.CGRect_objc_msgSendSuper_stret_MGLCoordinateBounds_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.CGRect_objc_msgSendSuper_stret_MGLCoordinateBounds_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinitions.Messaging.CGRect_objc_msgSendSuper_stret_MGLCoordinateBounds_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertCoordinateBounds:toRectToView:"), bounds, view == null ? IntPtr.Zero : view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("convertPoint:toCoordinateFromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D ConvertPoint (CGPoint point, global::UIKit.UIView view)
		{
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_CGPoint_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_CGPoint_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_IntPtr (this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_IntPtr (this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("convertRect:toCoordinateBoundsFromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCoordinateBounds ConvertRect (CGRect rect, global::UIKit.UIView view)
		{
			MGLCoordinateBounds ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret_CGRect_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret_CGRect_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret_CGRect_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret_CGRect_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret_CGRect_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret_CGRect_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertRect:toCoordinateBoundsFromView:"), rect, view == null ? IntPtr.Zero : view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("dequeueReusableAnnotationImageWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier (string identifier)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			MGLAnnotationImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MGLAnnotationImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dequeueReusableAnnotationImageWithIdentifier:"), nsidentifier));
			} else {
				ret =  Runtime.GetNSObject<MGLAnnotationImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dequeueReusableAnnotationImageWithIdentifier:"), nsidentifier));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("dequeueReusableAnnotationViewWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotationView DequeueReusableAnnotationViewWithIdentifier (string identifier)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			MGLAnnotationView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MGLAnnotationView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:"), nsidentifier));
			} else {
				ret =  Runtime.GetNSObject<MGLAnnotationView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:"), nsidentifier));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("deselectAnnotation:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectAnnotation (IMGLAnnotation annotation, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("deselectAnnotation:animated:"), annotation == null ? IntPtr.Zero : annotation.Handle, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("deselectAnnotation:animated:"), annotation == null ? IntPtr.Zero : annotation.Handle, animated);
			}
		}
		
		[Export ("flyToCamera:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FlyToCamera (MGLMapCamera camera, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("flyToCamera:completionHandler:"), camera.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("flyToCamera:completionHandler:"), camera.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("flyToCamera:withDuration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FlyToCamera (MGLMapCamera camera, double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (this.Handle, Selector.GetHandle ("flyToCamera:withDuration:completionHandler:"), camera.Handle, duration, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("flyToCamera:withDuration:completionHandler:"), camera.Handle, duration, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("flyToCamera:withDuration:peakAltitude:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FlyToCamera (MGLMapCamera camera, double duration, double peakAltitude, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Double_Double_IntPtr (this.Handle, Selector.GetHandle ("flyToCamera:withDuration:peakAltitude:completionHandler:"), camera.Handle, duration, peakAltitude, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_Double_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("flyToCamera:withDuration:peakAltitude:completionHandler:"), camera.Handle, duration, peakAltitude, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("metersPerPointAtLatitude:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MetersPerPointAtLatitude (double latitude)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.Double_objc_msgSend_Double (this.Handle, Selector.GetHandle ("metersPerPointAtLatitude:"), latitude);
			} else {
				return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("metersPerPointAtLatitude:"), latitude);
			}
		}
		
		[Export ("reloadStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadStyle (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("reloadStyle:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("reloadStyle:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("removeAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotation (IMGLAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotation:"), annotation.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotation:"), annotation.Handle);
			}
		}
		
		[Export ("removeAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotations (IMGLAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("removeOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOverlay (IMGLOverlay overlay)
		{
			if (overlay == null)
				throw new ArgumentNullException ("overlay");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeOverlay:"), overlay.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeOverlay:"), overlay.Handle);
			}
		}
		
		[Export ("removeOverlays:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOverlays (IMGLOverlay[] overlays)
		{
			if (overlays == null)
				throw new ArgumentNullException ("overlays");
			var nsa_overlays = NSArray.FromNSObjects (overlays);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeOverlays:"), nsa_overlays.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeOverlays:"), nsa_overlays.Handle);
			}
			nsa_overlays.Dispose ();
			
		}
		
		[Export ("resetNorth")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetNorth ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetNorth"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetNorth"));
			}
		}
		
		[Export ("resetPosition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetPosition ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetPosition"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetPosition"));
			}
		}
		
		[Export ("selectAnnotation:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectAnnotation (IMGLAnnotation annotation, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("selectAnnotation:animated:completionHandler:"), annotation.Handle, animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("selectAnnotation:animated:completionHandler:"), annotation.Handle, animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("selectAnnotation:moveIntoView:animateSelection:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectAnnotation (IMGLAnnotation annotation, bool moveIntoView, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool_bool_IntPtr (this.Handle, Selector.GetHandle ("selectAnnotation:moveIntoView:animateSelection:completionHandler:"), annotation.Handle, moveIntoView, animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("selectAnnotation:moveIntoView:animateSelection:completionHandler:"), annotation.Handle, moveIntoView, animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("setCamera:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCamera (MGLMapCamera camera, bool animated)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setCamera:animated:"), camera.Handle, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setCamera:animated:"), camera.Handle, animated);
			}
		}
		
		[Export ("setCamera:withDuration:animationTimingFunction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCamera (MGLMapCamera camera, double duration, global::CoreAnimation.CAMediaTimingFunction function)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (this.Handle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle);
			}
		}
		
		[Export ("setCamera:withDuration:animationTimingFunction:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetCamera (MGLMapCamera camera, double duration, global::CoreAnimation.CAMediaTimingFunction function, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:completionHandler:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:completionHandler:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setCamera:withDuration:animationTimingFunction:edgePadding:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetCamera (MGLMapCamera camera, double duration, global::CoreAnimation.CAMediaTimingFunction function, global::UIKit.UIEdgeInsets edgePadding, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr_UIEdgeInsets_IntPtr (this.Handle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:edgePadding:completionHandler:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle, edgePadding, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr_UIEdgeInsets_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:edgePadding:completionHandler:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle, edgePadding, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setCenterCoordinate:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated);
			}
		}
		
		[Export ("setCenterCoordinate:zoomLevel:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, double zoomLevel, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D_Double_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:animated:"), centerCoordinate, zoomLevel, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_Double_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:animated:"), centerCoordinate, zoomLevel, animated);
			}
		}
		
		[Export ("setCenterCoordinate:zoomLevel:direction:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D_Double_Double_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:direction:animated:"), centerCoordinate, zoomLevel, direction, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:direction:animated:"), centerCoordinate, zoomLevel, direction, animated);
			}
		}
		
		[Export ("setCenterCoordinate:zoomLevel:direction:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D_Double_Double_bool_IntPtr (this.Handle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:direction:animated:completionHandler:"), centerCoordinate, zoomLevel, direction, animated, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:direction:animated:completionHandler:"), centerCoordinate, zoomLevel, direction, animated, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setContentInset:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetContentInset (global::UIKit.UIEdgeInsets contentInset, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_UIEdgeInsets_bool_IntPtr (this.Handle, Selector.GetHandle ("setContentInset:animated:completionHandler:"), contentInset, animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UIEdgeInsets_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("setContentInset:animated:completionHandler:"), contentInset, animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("setDirection:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDirection (double direction, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_Double_bool (this.Handle, Selector.GetHandle ("setDirection:animated:"), direction, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double_bool (this.SuperHandle, Selector.GetHandle ("setDirection:animated:"), direction, animated);
			}
		}
		
		[Export ("setTargetCoordinate:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetTargetCoordinate (global::CoreLocation.CLLocationCoordinate2D targetCoordinate, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool_IntPtr (this.Handle, Selector.GetHandle ("setTargetCoordinate:animated:completionHandler:"), targetCoordinate, animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("setTargetCoordinate:animated:completionHandler:"), targetCoordinate, animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("setUserLocationVerticalAlignment:animated:")]
		[Deprecated (PlatformName.iOS, PlatformArchitecture.All, message: "Use `-[MGLMapViewDelegate mapViewUserLocationAnchorPoint:]` instead.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetUserLocationVerticalAlignment (MGLAnnotationVerticalAlignment alignment, bool animated)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setUserLocationVerticalAlignment:animated:"), (UInt64)alignment, animated);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, Selector.GetHandle ("setUserLocationVerticalAlignment:animated:"), (UInt32)alignment, animated);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64_bool (this.SuperHandle, Selector.GetHandle ("setUserLocationVerticalAlignment:animated:"), (UInt64)alignment, animated);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, Selector.GetHandle ("setUserLocationVerticalAlignment:animated:"), (UInt32)alignment, animated);
				}
			}
		}
		
		[Export ("setUserTrackingMode:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetUserTrackingMode (MGLUserTrackingMode mode, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64_bool_IntPtr (this.Handle, Selector.GetHandle ("setUserTrackingMode:animated:completionHandler:"), (UInt64)mode, animated, (IntPtr) block_ptr_completionHandler);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32_bool_IntPtr (this.Handle, Selector.GetHandle ("setUserTrackingMode:animated:completionHandler:"), (UInt32)mode, animated, (IntPtr) block_ptr_completionHandler);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserTrackingMode:animated:completionHandler:"), (UInt64)mode, animated, (IntPtr) block_ptr_completionHandler);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserTrackingMode:animated:completionHandler:"), (UInt32)mode, animated, (IntPtr) block_ptr_completionHandler);
				}
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("setVisibleCoordinateBounds:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetVisibleCoordinateBounds (MGLCoordinateBounds bounds, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_MGLCoordinateBounds_bool_IntPtr (this.Handle, Selector.GetHandle ("setVisibleCoordinateBounds:animated:completionHandler:"), bounds, animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLCoordinateBounds_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("setVisibleCoordinateBounds:animated:completionHandler:"), bounds, animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("setVisibleCoordinateBounds:edgePadding:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleCoordinateBounds (MGLCoordinateBounds bounds, global::UIKit.UIEdgeInsets insets, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_MGLCoordinateBounds_UIEdgeInsets_bool (this.Handle, Selector.GetHandle ("setVisibleCoordinateBounds:edgePadding:animated:"), bounds, insets, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLCoordinateBounds_UIEdgeInsets_bool (this.SuperHandle, Selector.GetHandle ("setVisibleCoordinateBounds:edgePadding:animated:"), bounds, insets, animated);
			}
		}
		
		[Export ("setVisibleCoordinates:count:edgePadding:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coordinates, nuint count, global::UIKit.UIEdgeInsets insets, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_nuint_UIEdgeInsets_bool (this.Handle, Selector.GetHandle ("setVisibleCoordinates:count:edgePadding:animated:"), ref coordinates, count, insets, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_nuint_UIEdgeInsets_bool (this.SuperHandle, Selector.GetHandle ("setVisibleCoordinates:count:edgePadding:animated:"), ref coordinates, count, insets, animated);
			}
		}
		
		[Export ("setVisibleCoordinates:count:edgePadding:direction:duration:animationTimingFunction:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetVisibleCoordinates (ref global::CoreLocation.CLLocationCoordinate2D coordinates, nuint count, global::UIKit.UIEdgeInsets insets, double direction, double duration, global::CoreAnimation.CAMediaTimingFunction function, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_ref_CLLocationCoordinate2D_nuint_UIEdgeInsets_Double_Double_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setVisibleCoordinates:count:edgePadding:direction:duration:animationTimingFunction:completionHandler:"), ref coordinates, count, insets, direction, duration, function == null ? IntPtr.Zero : function.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_ref_CLLocationCoordinate2D_nuint_UIEdgeInsets_Double_Double_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setVisibleCoordinates:count:edgePadding:direction:duration:animationTimingFunction:completionHandler:"), ref coordinates, count, insets, direction, duration, function == null ? IntPtr.Zero : function.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setZoomLevel:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetZoomLevel (double zoomLevel, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_Double_bool (this.Handle, Selector.GetHandle ("setZoomLevel:animated:"), zoomLevel, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double_bool (this.SuperHandle, Selector.GetHandle ("setZoomLevel:animated:"), zoomLevel, animated);
			}
		}
		
		[Export ("showAnnotations:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnnotations (IMGLAnnotation[] annotations, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("showAnnotations:animated:"), nsa_annotations.Handle, animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showAnnotations:animated:"), nsa_annotations.Handle, animated);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("showAnnotations:edgePadding:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowAnnotations (IMGLAnnotation[] annotations, global::UIKit.UIEdgeInsets insets, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UIEdgeInsets_bool_IntPtr (this.Handle, Selector.GetHandle ("showAnnotations:edgePadding:animated:completionHandler:"), nsa_annotations.Handle, insets, animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_UIEdgeInsets_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("showAnnotations:edgePadding:animated:completionHandler:"), nsa_annotations.Handle, insets, animated, (IntPtr) block_ptr_completionHandler);
			}
			nsa_annotations.Dispose ();
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("showAttribution:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAttribution (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showAttribution:"), sender.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showAttribution:"), sender.Handle);
			}
		}
		
		[Export ("updateUserLocationAnnotationView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateUserLocationAnnotationView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateUserLocationAnnotationView"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateUserLocationAnnotationView"));
			}
		}
		
		[Export ("updateUserLocationAnnotationViewAnimatedWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateUserLocationAnnotationViewAnimatedWithDuration (double duration)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("updateUserLocationAnnotationViewAnimatedWithDuration:"), duration);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("updateUserLocationAnnotationViewAnimatedWithDuration:"), duration);
			}
		}
		
		[Export ("viewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLAnnotationView ViewForAnnotation (IMGLAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MGLAnnotationView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("viewForAnnotation:"), annotation.Handle));
			} else {
				return  Runtime.GetNSObject<MGLAnnotationView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("viewForAnnotation:"), annotation.Handle));
			}
		}
		
		[Export ("visibleAnnotationsInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLAnnotation[] VisibleAnnotationsInRect (CGRect rect)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("visibleAnnotationsInRect:"), rect));
			} else {
				return NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("visibleAnnotationsInRect:"), rect));
			}
		}
		
		[Export ("visibleFeaturesAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] VisibleFeaturesAtPoint (CGPoint point)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("visibleFeaturesAtPoint:"), point));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("visibleFeaturesAtPoint:"), point));
			}
		}
		
		[Export ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] VisibleFeaturesAtPoint (CGPoint point, NSSet<NSString> styleLayerIdentifiers)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:"), point, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGPoint_IntPtr (this.SuperHandle, Selector.GetHandle ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:"), point, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle));
			}
		}
		
		[Export ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:predicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] VisibleFeaturesAtPoint (CGPoint point, NSSet<NSString> styleLayerIdentifiers, NSPredicate predicate)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:predicate:"), point, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle, predicate == null ? IntPtr.Zero : predicate.Handle));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGPoint_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:predicate:"), point, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle, predicate == null ? IntPtr.Zero : predicate.Handle));
			}
		}
		
		[Export ("visibleFeaturesInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] VisibleFeaturesInRect (CGRect rect)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("visibleFeaturesInRect:"), rect));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("visibleFeaturesInRect:"), rect));
			}
		}
		
		[Export ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] VisibleFeaturesInRect (CGRect rect, NSSet<NSString> styleLayerIdentifiers)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:"), rect, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:"), rect, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle));
			}
		}
		
		[Export ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:predicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLFeature[] VisibleFeaturesInRect (CGRect rect, NSSet<NSString> styleLayerIdentifiers, NSPredicate predicate)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:predicate:"), rect, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle, predicate == null ? IntPtr.Zero : predicate.Handle));
			} else {
				return NSArray.ArrayFromHandle<IMGLFeature>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:predicate:"), rect, styleLayerIdentifiers == null ? IntPtr.Zero : styleLayerIdentifiers.Handle, predicate == null ? IntPtr.Zero : predicate.Handle));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLAnnotation[] Annotations {
			[Export ("annotations")]
			get {
				IMGLAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotations")));
				} else {
					ret = NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotations")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIButton AttributionButton {
			[Export ("attributionButton")]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButton")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint AttributionButtonMargins {
			[Export ("attributionButtonMargins")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButtonMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("attributionButtonMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButtonMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButtonMargins"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButtonMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("attributionButtonMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButtonMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButtonMargins"));
					}
				}
				return ret;
			}
			
			[Export ("setAttributionButtonMargins:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAttributionButtonMargins:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setAttributionButtonMargins:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOrnamentPosition AttributionButtonPosition {
			[Export ("attributionButtonPosition")]
			get {
				MGLOrnamentPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButtonPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButtonPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButtonPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButtonPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setAttributionButtonPosition:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAttributionButtonPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAttributionButtonPosition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAttributionButtonPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAttributionButtonPosition:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapCamera Camera {
			[Export ("camera", ArgumentSemantic.Copy)]
			get {
				MGLMapCamera ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("camera")));
				} else {
					ret =  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("camera")));
				}
				return ret;
			}
			
			[Export ("setCamera:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCamera:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D CenterCoordinate {
			[Export ("centerCoordinate", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					}
				}
				return ret;
			}
			
			[Export ("setCenterCoordinate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("setCenterCoordinate:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCompassButton CompassView {
			[Export ("compassView")]
			get {
				MGLCompassButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLCompassButton> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("compassView")));
				} else {
					ret =  Runtime.GetNSObject<MGLCompassButton> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassView")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint CompassViewMargins {
			[Export ("compassViewMargins")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("compassViewMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("compassViewMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("compassViewMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("compassViewMargins"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassViewMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("compassViewMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassViewMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassViewMargins"));
					}
				}
				return ret;
			}
			
			[Export ("setCompassViewMargins:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setCompassViewMargins:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setCompassViewMargins:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIEdgeInsets ContentInset {
			[Export ("contentInset", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("contentInset"));
						} else {
							global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentInset"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentInset"));
					} else {
						global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentInset"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentInset"));
						} else {
							global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentInset"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentInset"));
					} else {
						global::ApiDefinitions.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentInset"));
					}
				}
				return ret;
			}
			
			[Export ("setContentInset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setContentInset:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setContentInset:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapDebugMaskOptions DebugMask {
			[Export ("debugMask", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLMapDebugMaskOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLMapDebugMaskOptions) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("debugMask"));
					} else {
						ret = (MGLMapDebugMaskOptions) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("debugMask"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLMapDebugMaskOptions) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("debugMask"));
					} else {
						ret = (MGLMapDebugMaskOptions) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("debugMask"));
					}
				}
				return ret;
			}
			
			[Export ("setDebugMask:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setDebugMask:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setDebugMask:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setDebugMask:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setDebugMask:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat DecelerationRate {
			[Export ("decelerationRate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("decelerationRate"));
				} else {
					return global::ApiDefinitions.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("decelerationRate"));
				}
			}
			
			[Export ("setDecelerationRate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setDecelerationRate:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setDecelerationRate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLMapViewDelegate Delegate {
			get {
				return WeakDelegate as MGLMapViewDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Direction {
			[Export ("direction")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("direction"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("direction"));
				}
			}
			
			[Export ("setDirection:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setDirection:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setDirection:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplayHeadingCalibration {
			[Export ("displayHeadingCalibration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayHeadingCalibration"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayHeadingCalibration"));
				}
			}
			
			[Export ("setDisplayHeadingCalibration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayHeadingCalibration:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayHeadingCalibration:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HapticFeedbackEnabled {
			[Export ("isHapticFeedbackEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHapticFeedbackEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHapticFeedbackEnabled"));
				}
			}
			
			[Export ("setHapticFeedbackEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHapticFeedbackEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHapticFeedbackEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLLocationManager LocationManager {
			[Export ("locationManager")]
			get {
				MGLLocationManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLLocationManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("locationManager")));
				} else {
					ret =  Runtime.GetNSObject<MGLLocationManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("locationManager")));
				}
				return ret;
			}
			
			[Export ("setLocationManager:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLocationManager:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLocationManager:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImageView LogoView {
			[Export ("logoView")]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("logoView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoView")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint LogoViewMargins {
			[Export ("logoViewMargins")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("logoViewMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("logoViewMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("logoViewMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("logoViewMargins"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoViewMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("logoViewMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoViewMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoViewMargins"));
					}
				}
				return ret;
			}
			
			[Export ("setLogoViewMargins:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setLogoViewMargins:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setLogoViewMargins:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOrnamentPosition LogoViewPosition {
			[Export ("logoViewPosition")]
			get {
				MGLOrnamentPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("logoViewPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("logoViewPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoViewPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoViewPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setLogoViewPosition:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setLogoViewPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setLogoViewPosition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setLogoViewPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setLogoViewPosition:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MaximumZoomLevel {
			[Export ("maximumZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("maximumZoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumZoomLevel"));
				}
			}
			
			[Export ("setMaximumZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setMaximumZoomLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setMaximumZoomLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MinimumZoomLevel {
			[Export ("minimumZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("minimumZoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumZoomLevel"));
				}
			}
			
			[Export ("setMinimumZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setMinimumZoomLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setMinimumZoomLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Overlays {
			[Export ("overlays")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("overlays")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("overlays")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PitchEnabled {
			[Export ("isPitchEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPitchEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPitchEnabled"));
				}
			}
			
			[Export ("setPitchEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPitchEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPitchEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLMapViewPreferredFramesPerSecond PreferredFramesPerSecond {
			[Export ("preferredFramesPerSecond", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLMapViewPreferredFramesPerSecond ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLMapViewPreferredFramesPerSecond) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFramesPerSecond"));
					} else {
						ret = (MGLMapViewPreferredFramesPerSecond) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFramesPerSecond"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLMapViewPreferredFramesPerSecond) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("preferredFramesPerSecond"));
					} else {
						ret = (MGLMapViewPreferredFramesPerSecond) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("preferredFramesPerSecond"));
					}
				}
				return ret;
			}
			
			[Export ("setPreferredFramesPerSecond:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setPreferredFramesPerSecond:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPreferredFramesPerSecond:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setPreferredFramesPerSecond:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPreferredFramesPerSecond:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefetchesTiles {
			[Export ("prefetchesTiles")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefetchesTiles"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prefetchesTiles"));
				}
			}
			
			[Export ("setPrefetchesTiles:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPrefetchesTiles:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPrefetchesTiles:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RotateEnabled {
			[Export ("isRotateEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRotateEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRotateEnabled"));
				}
			}
			
			[Export ("setRotateEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotateEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView ScaleBar {
			[Export ("scaleBar")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scaleBar")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleBar")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ScaleBarMargins {
			[Export ("scaleBarMargins")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("scaleBarMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scaleBarMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("scaleBarMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("scaleBarMargins"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleBarMargins"));
						} else {
							global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scaleBarMargins"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleBarMargins"));
					} else {
						ret = global::ApiDefinitions.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleBarMargins"));
					}
				}
				return ret;
			}
			
			[Export ("setScaleBarMargins:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setScaleBarMargins:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setScaleBarMargins:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOrnamentPosition ScaleBarPosition {
			[Export ("scaleBarPosition")]
			get {
				MGLOrnamentPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("scaleBarPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("scaleBarPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleBarPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleBarPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setScaleBarPosition:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setScaleBarPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setScaleBarPosition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setScaleBarPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setScaleBarPosition:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ScrollEnabled {
			[Export ("isScrollEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScrollEnabled"));
				}
			}
			
			[Export ("setScrollEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLAnnotation[] SelectedAnnotations {
			[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
			get {
				IMGLAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedAnnotations")));
				} else {
					ret = NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedAnnotations")));
				}
				return ret;
			}
			
			[Export ("setSelectedAnnotations:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsScale {
			[Export ("showsScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsScale"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsScale"));
				}
			}
			
			[Export ("setShowsScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsScale:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsUserHeadingIndicator {
			[Export ("showsUserHeadingIndicator")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsUserHeadingIndicator"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsUserHeadingIndicator"));
				}
			}
			
			[Export ("setShowsUserHeadingIndicator:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsUserHeadingIndicator:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsUserHeadingIndicator:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsUserLocation {
			[Export ("showsUserLocation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsUserLocation"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsUserLocation"));
				}
			}
			
			[Export ("setShowsUserLocation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsUserLocation:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsUserLocation:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLStyle Style {
			[Export ("style")]
			get {
				MGLStyle ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLStyle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("style")));
				} else {
					ret =  Runtime.GetNSObject<MGLStyle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("style")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_StyleURL_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl StyleURL {
			[Export ("styleURL", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleURL")));
				}
				MarkDirty ();
				__mt_StyleURL_var = ret;
				return ret;
			}
			
			[Export ("setStyleURL:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStyleURL:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStyleURL:"), value.Handle);
				}
				MarkDirty ();
				__mt_StyleURL_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D TargetCoordinate {
			[Export ("targetCoordinate", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("targetCoordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("targetCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("targetCoordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("targetCoordinate"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("targetCoordinate"));
						} else {
							global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("targetCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("targetCoordinate"));
					} else {
						global::ApiDefinitions.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("targetCoordinate"));
					}
				}
				return ret;
			}
			
			[Export ("setTargetCoordinate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("setTargetCoordinate:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("setTargetCoordinate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLUserLocation UserLocation {
			[Export ("userLocation")]
			get {
				MGLUserLocation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLUserLocation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userLocation")));
				} else {
					ret =  Runtime.GetNSObject<MGLUserLocation> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLocation")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Deprecated (PlatformName.iOS, PlatformArchitecture.All, message: "Use `-[MGLMapViewDelegate mapViewUserLocationAnchorPoint:]` instead.")]
		public virtual MGLAnnotationVerticalAlignment UserLocationVerticalAlignment {
			[Deprecated (PlatformName.iOS, PlatformArchitecture.All, message: "Use `-[MGLMapViewDelegate mapViewUserLocationAnchorPoint:]` instead.")]
			[Export ("userLocationVerticalAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLAnnotationVerticalAlignment ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLAnnotationVerticalAlignment) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("userLocationVerticalAlignment"));
					} else {
						ret = (MGLAnnotationVerticalAlignment) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("userLocationVerticalAlignment"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLAnnotationVerticalAlignment) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLocationVerticalAlignment"));
					} else {
						ret = (MGLAnnotationVerticalAlignment) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLocationVerticalAlignment"));
					}
				}
				return ret;
			}
			
			[Deprecated (PlatformName.iOS, PlatformArchitecture.All, message: "Use `-[MGLMapViewDelegate mapViewUserLocationAnchorPoint:]` instead.")]
			[Export ("setUserLocationVerticalAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setUserLocationVerticalAlignment:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setUserLocationVerticalAlignment:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setUserLocationVerticalAlignment:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setUserLocationVerticalAlignment:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserLocationVisible {
			[Export ("isUserLocationVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUserLocationVisible"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isUserLocationVisible"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLUserTrackingMode UserTrackingMode {
			[Export ("userTrackingMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLUserTrackingMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLUserTrackingMode) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("userTrackingMode"));
					} else {
						ret = (MGLUserTrackingMode) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("userTrackingMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLUserTrackingMode) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userTrackingMode"));
					} else {
						ret = (MGLUserTrackingMode) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userTrackingMode"));
					}
				}
				return ret;
			}
			
			[Export ("setUserTrackingMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setUserTrackingMode:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setUserTrackingMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setUserTrackingMode:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setUserTrackingMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMGLAnnotation[] VisibleAnnotations {
			[Export ("visibleAnnotations")]
			get {
				IMGLAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visibleAnnotations")));
				} else {
					ret = NSArray.ArrayFromHandle<IMGLAnnotation>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibleAnnotations")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLCoordinateBounds VisibleCoordinateBounds {
			[Export ("visibleCoordinateBounds", ArgumentSemantic.UnsafeUnretained)]
			get {
				MGLCoordinateBounds ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend (this.Handle, Selector.GetHandle ("visibleCoordinateBounds"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("visibleCoordinateBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("visibleCoordinateBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("visibleCoordinateBounds"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibleCoordinateBounds"));
						} else {
							global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("visibleCoordinateBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("visibleCoordinateBounds"));
					} else {
						global::ApiDefinitions.Messaging.MGLCoordinateBounds_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("visibleCoordinateBounds"));
					}
				}
				return ret;
			}
			
			[Export ("setVisibleCoordinateBounds:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_MGLCoordinateBounds (this.Handle, Selector.GetHandle ("setVisibleCoordinateBounds:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_MGLCoordinateBounds (this.SuperHandle, Selector.GetHandle ("setVisibleCoordinateBounds:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ZoomEnabled {
			[Export ("isZoomEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isZoomEnabled"));
				}
			}
			
			[Export ("setZoomEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setZoomEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ZoomLevel {
			[Export ("zoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("zoomLevel"));
				} else {
					return global::ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomLevel"));
				}
			}
			
			[Export ("setZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setZoomLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setZoomLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOrnamentPosition compassViewPosition {
			[Export ("compassViewPosition")]
			get {
				MGLOrnamentPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("compassViewPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("compassViewPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassViewPosition"));
					} else {
						ret = (MGLOrnamentPosition) global::ApiDefinitions.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassViewPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setCompassViewPosition:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setCompassViewPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setCompassViewPosition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setCompassViewPosition:"), (UInt64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setCompassViewPosition:"), (UInt32)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_StyleURL_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class MGLMapViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MGLMapViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MGLMapViewAppearance Appearance {
			get { return new MGLMapViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MGLMapViewAppearance GetAppearance<T> () where T: MGLMapView {
			return new MGLMapViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MGLMapViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MGLMapViewAppearance GetAppearance (UITraitCollection traits) {
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MGLMapViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MGLMapViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MGLMapView {
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MGLMapViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MGLMapView{
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MGLMapView */
}
