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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Mapbox.MGLBatchedOfflinePackAdditionCompletionHandler))]
		internal delegate void DMGLBatchedOfflinePackAdditionCompletionHandler (IntPtr block, IntPtr fileUrl, IntPtr packages, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMGLBatchedOfflinePackAdditionCompletionHandler {
			static internal readonly DMGLBatchedOfflinePackAdditionCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMGLBatchedOfflinePackAdditionCompletionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr fileUrl, IntPtr packages, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Mapbox.MGLBatchedOfflinePackAdditionCompletionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSUrl> (fileUrl), NSArray.ArrayFromHandle<global::Mapbox.MGLOfflinePack> (packages),  Runtime.GetNSObject<NSError> (error));
			}
		} /* class SDMGLBatchedOfflinePackAdditionCompletionHandler */
		
		internal class NIDMGLBatchedOfflinePackAdditionCompletionHandler {
			IntPtr blockPtr;
			DMGLBatchedOfflinePackAdditionCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMGLBatchedOfflinePackAdditionCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMGLBatchedOfflinePackAdditionCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDMGLBatchedOfflinePackAdditionCompletionHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Mapbox.MGLBatchedOfflinePackAdditionCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Mapbox.MGLBatchedOfflinePackAdditionCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMGLBatchedOfflinePackAdditionCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSUrl fileUrl, global::Mapbox.MGLOfflinePack[] packages, NSError error)
			{
				var nsa_packages = packages == null ? null : NSArray.FromNSObjects (packages);
				
				invoker (blockPtr, fileUrl == null ? IntPtr.Zero : fileUrl.Handle, nsa_packages == null ? IntPtr.Zero : nsa_packages.Handle, error == null ? IntPtr.Zero : error.Handle);
				if (nsa_packages != null)
					nsa_packages.Dispose ();
				
			}
		} /* class NIDMGLBatchedOfflinePackAdditionCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Mapbox.MGLLoggingBlockHandler))]
		internal delegate void DMGLLoggingBlockHandler (IntPtr block, nuint loggingLevel, IntPtr filePath, nuint line, IntPtr message);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMGLLoggingBlockHandler {
			static internal readonly DMGLLoggingBlockHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMGLLoggingBlockHandler))]
			static unsafe void Invoke (IntPtr block, nuint loggingLevel, IntPtr filePath, nuint line, IntPtr message) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Mapbox.MGLLoggingBlockHandler) (descriptor->Target);
				if (del != null)
					del ((global::Mapbox.MGLLoggingLevel) (ulong) loggingLevel, NSString.FromHandle (filePath), line, NSString.FromHandle (message));
			}
		} /* class SDMGLLoggingBlockHandler */
		
		internal class NIDMGLLoggingBlockHandler {
			IntPtr blockPtr;
			DMGLLoggingBlockHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMGLLoggingBlockHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMGLLoggingBlockHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDMGLLoggingBlockHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Mapbox.MGLLoggingBlockHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Mapbox.MGLLoggingBlockHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMGLLoggingBlockHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Mapbox.MGLLoggingLevel loggingLevel, string filePath, nuint line, string message)
			{
				var nsfilePath = NSString.CreateNative (filePath);
				var nsmessage = NSString.CreateNative (message);
				
				invoker (blockPtr, (nuint) (UInt64) loggingLevel, nsfilePath, line, nsmessage);
				NSString.ReleaseNative (nsfilePath);
				NSString.ReleaseNative (nsmessage);
				
			}
		} /* class NIDMGLLoggingBlockHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Mapbox.MGLMapSnapshotCompletionHandler))]
		internal delegate void DMGLMapSnapshotCompletionHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMGLMapSnapshotCompletionHandler {
			static internal readonly DMGLMapSnapshotCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMGLMapSnapshotCompletionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Mapbox.MGLMapSnapshotCompletionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Mapbox.MGLMapSnapshot> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMGLMapSnapshotCompletionHandler */
		
		internal class NIDMGLMapSnapshotCompletionHandler {
			IntPtr blockPtr;
			DMGLMapSnapshotCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMGLMapSnapshotCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMGLMapSnapshotCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDMGLMapSnapshotCompletionHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Mapbox.MGLMapSnapshotCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Mapbox.MGLMapSnapshotCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMGLMapSnapshotCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Mapbox.MGLMapSnapshot arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMGLMapSnapshotCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Mapbox.MGLMapSnapshotOverlayHandler))]
		internal delegate void DMGLMapSnapshotOverlayHandler (IntPtr block, IntPtr snapshotOverlay);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMGLMapSnapshotOverlayHandler {
			static internal readonly DMGLMapSnapshotOverlayHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMGLMapSnapshotOverlayHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr snapshotOverlay) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Mapbox.MGLMapSnapshotOverlayHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Mapbox.MGLMapSnapshotOverlay> (snapshotOverlay));
			}
		} /* class SDMGLMapSnapshotOverlayHandler */
		
		internal class NIDMGLMapSnapshotOverlayHandler {
			IntPtr blockPtr;
			DMGLMapSnapshotOverlayHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMGLMapSnapshotOverlayHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMGLMapSnapshotOverlayHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDMGLMapSnapshotOverlayHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Mapbox.MGLMapSnapshotOverlayHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Mapbox.MGLMapSnapshotOverlayHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMGLMapSnapshotOverlayHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Mapbox.MGLMapSnapshotOverlay snapshotOverlay)
			{
				invoker (blockPtr, snapshotOverlay == null ? IntPtr.Zero : snapshotOverlay.Handle);
			}
		} /* class NIDMGLMapSnapshotOverlayHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Mapbox.MGLOfflinePackAdditionCompletionHandler))]
		internal delegate void DMGLOfflinePackAdditionCompletionHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMGLOfflinePackAdditionCompletionHandler {
			static internal readonly DMGLOfflinePackAdditionCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMGLOfflinePackAdditionCompletionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Mapbox.MGLOfflinePackAdditionCompletionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Mapbox.MGLOfflinePack> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMGLOfflinePackAdditionCompletionHandler */
		
		internal class NIDMGLOfflinePackAdditionCompletionHandler {
			IntPtr blockPtr;
			DMGLOfflinePackAdditionCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMGLOfflinePackAdditionCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMGLOfflinePackAdditionCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDMGLOfflinePackAdditionCompletionHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Mapbox.MGLOfflinePackAdditionCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Mapbox.MGLOfflinePackAdditionCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMGLOfflinePackAdditionCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Mapbox.MGLOfflinePack arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMGLOfflinePackAdditionCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Mapbox.MGLOfflinePackRemovalCompletionHandler))]
		internal delegate void DMGLOfflinePackRemovalCompletionHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMGLOfflinePackRemovalCompletionHandler {
			static internal readonly DMGLOfflinePackRemovalCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMGLOfflinePackRemovalCompletionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Mapbox.MGLOfflinePackRemovalCompletionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDMGLOfflinePackRemovalCompletionHandler */
		
		internal class NIDMGLOfflinePackRemovalCompletionHandler {
			IntPtr blockPtr;
			DMGLOfflinePackRemovalCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMGLOfflinePackRemovalCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMGLOfflinePackRemovalCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDMGLOfflinePackRemovalCompletionHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Mapbox.MGLOfflinePackRemovalCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Mapbox.MGLOfflinePackRemovalCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMGLOfflinePackRemovalCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMGLOfflinePackRemovalCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDAction ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
	}
}
