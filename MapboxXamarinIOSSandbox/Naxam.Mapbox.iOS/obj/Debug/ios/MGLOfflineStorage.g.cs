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
	[Register("MGLOfflineStorage", true)]
	public unsafe partial class MGLOfflineStorage : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLOfflineStorage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLOfflineStorage () : base (NSObjectFlag.Empty)
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
		protected MGLOfflineStorage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLOfflineStorage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addContentsOfURL:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddContentsOfURL (NSUrl fileURL, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLBatchedOfflinePackAdditionCompletionHandler))]MGLBatchedOfflinePackAdditionCompletionHandler completion)
		{
			if (fileURL == null)
				throw new ArgumentNullException ("fileURL");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDMGLBatchedOfflinePackAdditionCompletionHandler.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addContentsOfURL:withCompletionHandler:"), fileURL.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addContentsOfURL:withCompletionHandler:"), fileURL.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("addContentsOfFile:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddPackForRegion (string filePath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLBatchedOfflinePackAdditionCompletionHandler))]MGLBatchedOfflinePackAdditionCompletionHandler completion)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDMGLBatchedOfflinePackAdditionCompletionHandler.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addContentsOfFile:withCompletionHandler:"), nsfilePath, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addContentsOfFile:withCompletionHandler:"), nsfilePath, (IntPtr) block_ptr_completion);
			}
			NSString.ReleaseNative (nsfilePath);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("addPackForRegion:withContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddPackForRegion (IMGLOfflineRegion region, NSData context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackAdditionCompletionHandler))]MGLOfflinePackAdditionCompletionHandler completion)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (context == null)
				throw new ArgumentNullException ("context");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackAdditionCompletionHandler.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addPackForRegion:withContext:completionHandler:"), region.Handle, context.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addPackForRegion:withContext:completionHandler:"), region.Handle, context.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("clearAmbientCacheWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ClearAmbientCacheWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackRemovalCompletionHandler))]MGLOfflinePackRemovalCompletionHandler completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackRemovalCompletionHandler.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("clearAmbientCacheWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("clearAmbientCacheWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("invalidateAmbientCacheWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InvalidateAmbientCacheWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackRemovalCompletionHandler))]MGLOfflinePackRemovalCompletionHandler completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackRemovalCompletionHandler.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("invalidateAmbientCacheWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("invalidateAmbientCacheWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("invalidatePack:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InvalidatePack (MGLOfflinePack pack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackRemovalCompletionHandler))]MGLOfflinePackRemovalCompletionHandler completion)
		{
			if (pack == null)
				throw new ArgumentNullException ("pack");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackRemovalCompletionHandler.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("invalidatePack:withCompletionHandler:"), pack.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("invalidatePack:withCompletionHandler:"), pack.Handle, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("preloadData:forURL:modificationDate:expirationDate:eTag:mustRevalidate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PreloadData (NSData data, NSUrl url, NSDate modificationDate, NSDate expirationDate, string etag, bool mustRevalidate)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsetag = NSString.CreateNative (etag);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("preloadData:forURL:modificationDate:expirationDate:eTag:mustRevalidate:"), data.Handle, url.Handle, modificationDate == null ? IntPtr.Zero : modificationDate.Handle, expirationDate == null ? IntPtr.Zero : expirationDate.Handle, nsetag, mustRevalidate);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("preloadData:forURL:modificationDate:expirationDate:eTag:mustRevalidate:"), data.Handle, url.Handle, modificationDate == null ? IntPtr.Zero : modificationDate.Handle, expirationDate == null ? IntPtr.Zero : expirationDate.Handle, nsetag, mustRevalidate);
			}
			NSString.ReleaseNative (nsetag);
			
		}
		
		[Export ("reloadPacks")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadPacks ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadPacks"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reloadPacks"));
			}
		}
		
		[Export ("removePack:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemovePack (MGLOfflinePack pack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackRemovalCompletionHandler))]MGLOfflinePackRemovalCompletionHandler completion)
		{
			if (pack == null)
				throw new ArgumentNullException ("pack");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackRemovalCompletionHandler.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removePack:withCompletionHandler:"), pack.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removePack:withCompletionHandler:"), pack.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("resetDatabaseWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResetDatabaseWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackRemovalCompletionHandler))]MGLOfflinePackRemovalCompletionHandler completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackRemovalCompletionHandler.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("resetDatabaseWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("resetDatabaseWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setMaximumAllowedMapboxTiles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMaximumAllowedMapboxTiles (ulong maximumCount)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setMaximumAllowedMapboxTiles:"), maximumCount);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setMaximumAllowedMapboxTiles:"), maximumCount);
			}
		}
		
		[Export ("setMaximumAmbientCacheSize:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetMaximumAmbientCacheSize (uint cacheSize, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMGLOfflinePackRemovalCompletionHandler))]MGLOfflinePackRemovalCompletionHandler completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDMGLOfflinePackRemovalCompletionHandler.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("setMaximumAmbientCacheSize:withCompletionHandler:"), cacheSize, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("setMaximumAmbientCacheSize:withCompletionHandler:"), cacheSize, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong CountOfBytesCompleted {
			[Export ("countOfBytesCompleted")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("countOfBytesCompleted"));
				} else {
					return global::ApiDefinitions.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("countOfBytesCompleted"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MGLOfflineStorageDelegate Delegate {
			get {
				return WeakDelegate as MGLOfflineStorageDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MGLOfflinePack[] Packs {
			[Export ("packs", ArgumentSemantic.Retain)]
			get {
				MGLOfflinePack[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MGLOfflinePack>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("packs")));
				} else {
					ret = NSArray.ArrayFromHandle<MGLOfflinePack>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("packs")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MGLOfflineStorage SharedOfflineStorage {
			[Export ("sharedOfflineStorage")]
			get {
				MGLOfflineStorage ret;
				ret =  Runtime.GetNSObject<MGLOfflineStorage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedOfflineStorage")));
				return ret;
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MGLOfflineStorage */
}
