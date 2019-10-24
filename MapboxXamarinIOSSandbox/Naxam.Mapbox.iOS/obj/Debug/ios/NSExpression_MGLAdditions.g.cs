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
	public unsafe static partial class NSExpression_MGLAdditions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSExpression");
		
		[Export ("expressionWithMGLJSONObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression ExpressionWithMGLJSONObject (this NSExpression This, NSObject @object)
		{
			if (@object == null)
				throw new ArgumentNullException ("@object");
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("expressionWithMGLJSONObject:"), @object.Handle));
		}
		
		[Export ("featureAttributesVariableExpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FeatureAttributesVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("featureAttributesVariableExpression")));
		}
		
		[Export ("featureIdentifierVariableExpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FeatureIdentifierVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("featureIdentifierVariableExpression")));
		}
		
		[Export ("featurePropertiesVariableExpression")]
		[Deprecated (PlatformName.iOS, PlatformArchitecture.All, message: "Use -featureAttributesVariableExpression.")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FeaturePropertiesVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("featurePropertiesVariableExpression")));
		}
		
		[Export ("geometryTypeVariableExpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression GeometryTypeVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("geometryTypeVariableExpression")));
		}
		
		[Export ("heatmapDensityVariableExpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression HeatmapDensityVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("heatmapDensityVariableExpression")));
		}
		
		[Export ("lineProgressVariableExpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression LineProgressVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("lineProgressVariableExpression")));
		}
		
		[Export ("mgl_expressionByAppendingExpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionByAppendingExpression (this NSExpression This, NSExpression expression)
		{
			if (expression == null)
				throw new ArgumentNullException ("expression");
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mgl_expressionByAppendingExpression:"), expression.Handle));
		}
		
		[Export ("mgl_expressionForAttributedExpressions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionForAttributedExpressions (this NSExpression This, NSExpression[] attributedExpressions)
		{
			if (attributedExpressions == null)
				throw new ArgumentNullException ("attributedExpressions");
			var nsa_attributedExpressions = NSArray.FromNSObjects (attributedExpressions);
			
			NSExpression ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("mgl_expressionForAttributedExpressions:"), nsa_attributedExpressions.Handle));
			nsa_attributedExpressions.Dispose ();
			
			return ret;
		}
		
		[Export ("mgl_expressionForConditional:trueExpression:falseExpresssion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionForConditional (this NSExpression This, NSPredicate conditionPredicate, NSExpression trueExpression, NSExpression falseExpression)
		{
			if (conditionPredicate == null)
				throw new ArgumentNullException ("conditionPredicate");
			if (trueExpression == null)
				throw new ArgumentNullException ("trueExpression");
			if (falseExpression == null)
				throw new ArgumentNullException ("falseExpression");
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("mgl_expressionForConditional:trueExpression:falseExpresssion:"), conditionPredicate.Handle, trueExpression.Handle, falseExpression.Handle));
		}
		
		[Export ("mgl_expressionForInterpolatingExpression:withCurveType:parameters:stops:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionForInterpolatingExpression (this NSExpression This, NSExpression inputExpression, string curveType, NSExpression parameters, NSExpression stops)
		{
			if (inputExpression == null)
				throw new ArgumentNullException ("inputExpression");
			if (curveType == null)
				throw new ArgumentNullException ("curveType");
			if (stops == null)
				throw new ArgumentNullException ("stops");
			var nscurveType = NSString.CreateNative (curveType);
			
			NSExpression ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("mgl_expressionForInterpolatingExpression:withCurveType:parameters:stops:"), inputExpression.Handle, nscurveType, parameters == null ? IntPtr.Zero : parameters.Handle, stops.Handle));
			NSString.ReleaseNative (nscurveType);
			
			return ret;
		}
		
		[Export ("mgl_expressionForMatchingExpression:inDictionary:defaultExpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionForMatchingExpression (this NSExpression This, NSExpression inputExpression, NSDictionary<NSExpression, NSExpression> matchedExpressions, NSExpression defaultExpression)
		{
			if (inputExpression == null)
				throw new ArgumentNullException ("inputExpression");
			if (matchedExpressions == null)
				throw new ArgumentNullException ("matchedExpressions");
			if (defaultExpression == null)
				throw new ArgumentNullException ("defaultExpression");
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("mgl_expressionForMatchingExpression:inDictionary:defaultExpression:"), inputExpression.Handle, matchedExpressions.Handle, defaultExpression.Handle));
		}
		
		[Export ("mgl_expressionForSteppingExpression:fromExpression:stops:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionForSteppingExpression (this NSExpression This, NSExpression steppingExpression, NSExpression minimumExpression, NSExpression stops)
		{
			if (steppingExpression == null)
				throw new ArgumentNullException ("steppingExpression");
			if (minimumExpression == null)
				throw new ArgumentNullException ("minimumExpression");
			if (stops == null)
				throw new ArgumentNullException ("stops");
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("mgl_expressionForSteppingExpression:fromExpression:stops:"), steppingExpression.Handle, minimumExpression.Handle, stops.Handle));
		}
		
		[Export ("mgl_expressionLocalizedIntoLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression Mgl_expressionLocalizedIntoLocale (this NSExpression This, NSLocale locale)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mgl_expressionLocalizedIntoLocale:"), locale == null ? IntPtr.Zero : locale.Handle));
		}
		
		[Export ("mgl_jsonExpressionObject")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject Mgl_jsonExpressionObject (this NSExpression This)
		{
			return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mgl_jsonExpressionObject")));
		}
		
		[Export ("zoomLevelVariableExpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression ZoomLevelVariableExpression (this NSExpression This)
		{
			return  Runtime.GetNSObject<NSExpression> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("zoomLevelVariableExpression")));
		}
		
	} /* class NSExpression_MGLAdditions */
}
