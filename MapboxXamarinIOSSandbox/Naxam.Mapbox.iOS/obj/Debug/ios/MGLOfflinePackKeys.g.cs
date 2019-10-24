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
	public unsafe static partial class MGLOfflinePackKeys  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ErrorNotification;
		[Field ("MGLOfflinePackErrorNotification",  "__Internal")]
		public static NSString ErrorNotification {
			get {
				if (_ErrorNotification == null)
					_ErrorNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackErrorNotification");
				return _ErrorNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _MaximumMapboxTilesReachedNotification;
		[Field ("MGLOfflinePackMaximumMapboxTilesReachedNotification",  "__Internal")]
		public static NSString MaximumMapboxTilesReachedNotification {
			get {
				if (_MaximumMapboxTilesReachedNotification == null)
					_MaximumMapboxTilesReachedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackMaximumMapboxTilesReachedNotification");
				return _MaximumMapboxTilesReachedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ProgressChangedNotification;
		[Field ("MGLOfflinePackProgressChangedNotification",  "__Internal")]
		public static NSString ProgressChangedNotification {
			get {
				if (_ProgressChangedNotification == null)
					_ProgressChangedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackProgressChangedNotification");
				return _ProgressChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _UserInfoKeyError;
		[Field ("MGLOfflinePackUserInfoKeyError",  "__Internal")]
		public static NSString UserInfoKeyError {
			get {
				if (_UserInfoKeyError == null)
					_UserInfoKeyError = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackUserInfoKeyError");
				return _UserInfoKeyError;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _UserInfoKeyMaximumCount;
		[Field ("MGLOfflinePackUserInfoKeyMaximumCount",  "__Internal")]
		public static NSString UserInfoKeyMaximumCount {
			get {
				if (_UserInfoKeyMaximumCount == null)
					_UserInfoKeyMaximumCount = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackUserInfoKeyMaximumCount");
				return _UserInfoKeyMaximumCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _UserInfoKeyProgress;
		[Field ("MGLOfflinePackUserInfoKeyProgress",  "__Internal")]
		public static NSString UserInfoKeyProgress {
			get {
				if (_UserInfoKeyProgress == null)
					_UserInfoKeyProgress = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackUserInfoKeyProgress");
				return _UserInfoKeyProgress;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _UserInfoKeyState;
		[Field ("MGLOfflinePackUserInfoKeyState",  "__Internal")]
		public static NSString UserInfoKeyState {
			get {
				if (_UserInfoKeyState == null)
					_UserInfoKeyState = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "MGLOfflinePackUserInfoKeyState");
				return _UserInfoKeyState;
			}
		}
	} /* class MGLOfflinePackKeys */
}
