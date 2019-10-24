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
	public delegate void MGLBatchedOfflinePackAdditionCompletionHandler (NSUrl fileUrl, Mapbox.MGLOfflinePack[] packages, NSError error);
	public delegate void MGLLoggingBlockHandler (Mapbox.MGLLoggingLevel loggingLevel, string filePath, nuint line, string message);
	public delegate void MGLMapSnapshotCompletionHandler (Mapbox.MGLMapSnapshot arg0, NSError arg1);
	public delegate void MGLMapSnapshotOverlayHandler (Mapbox.MGLMapSnapshotOverlay snapshotOverlay);
	public delegate void MGLOfflinePackAdditionCompletionHandler (Mapbox.MGLOfflinePack arg0, NSError arg1);
	public delegate void MGLOfflinePackRemovalCompletionHandler (NSError arg0);
}

