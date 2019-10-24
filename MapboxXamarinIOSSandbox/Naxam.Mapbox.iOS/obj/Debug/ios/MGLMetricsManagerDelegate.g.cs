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
	[Protocol (Name = "MGLMetricsManagerDelegate", WrapperType = typeof (MGLMetricsManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MetricsManagerShouldHandleMetric", Selector = "metricsManager:shouldHandleMetric:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Mapbox.MGLMetricsManager), typeof (Mapbox.MGLMetricType) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MetricsManagerShouldHandleMetric", Selector = "metricsManager:didCollectMetric:withAttributes:", ParameterType = new Type [] { typeof (Mapbox.MGLMetricsManager), typeof (Mapbox.MGLMetricType), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IMGLMetricsManagerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("metricsManager:shouldHandleMetric:")]
		[Preserve (Conditional = true)]
		bool MetricsManagerShouldHandleMetric (MGLMetricsManager metricsManager, MGLMetricType metricType);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("metricsManager:didCollectMetric:withAttributes:")]
		[Preserve (Conditional = true)]
		void MetricsManagerShouldHandleMetric (MGLMetricsManager metricsManager, MGLMetricType metricType, NSDictionary attributes);
		
	}
	
	internal sealed class MGLMetricsManagerDelegateWrapper : BaseWrapper, IMGLMetricsManagerDelegate {
		[Preserve (Conditional = true)]
		public MGLMetricsManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("metricsManager:shouldHandleMetric:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool MetricsManagerShouldHandleMetric (MGLMetricsManager metricsManager, MGLMetricType metricType)
		{
			if (metricsManager == null)
				throw new ArgumentNullException ("metricsManager");
			if (IntPtr.Size == 8) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("metricsManager:shouldHandleMetric:"), metricsManager.Handle, (UInt64)metricType);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("metricsManager:shouldHandleMetric:"), metricsManager.Handle, (UInt32)metricType);
			}
		}
		
		[Export ("metricsManager:didCollectMetric:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MetricsManagerShouldHandleMetric (MGLMetricsManager metricsManager, MGLMetricType metricType, NSDictionary attributes)
		{
			if (metricsManager == null)
				throw new ArgumentNullException ("metricsManager");
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("metricsManager:didCollectMetric:withAttributes:"), metricsManager.Handle, (UInt64)metricType, attributes.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("metricsManager:didCollectMetric:withAttributes:"), metricsManager.Handle, (UInt32)metricType, attributes.Handle);
			}
		}
		
	}
}
namespace Mapbox {
	[Protocol()]
	[Register("MGLMetricsManagerDelegate", false)]
	[Model]
	public unsafe abstract partial class MGLMetricsManagerDelegate : NSObject, IMGLMetricsManagerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MGLMetricsManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLMetricsManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMetricsManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("metricsManager:shouldHandleMetric:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract bool MetricsManagerShouldHandleMetric (MGLMetricsManager metricsManager, MGLMetricType metricType);
		[Export ("metricsManager:didCollectMetric:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void MetricsManagerShouldHandleMetric (MGLMetricsManager metricsManager, MGLMetricType metricType, NSDictionary attributes);
	} /* class MGLMetricsManagerDelegate */
}
