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
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace PaypaliOSBinding {
	[Register("PayPalPaymentDelegate", false)]
	[Model]
	public unsafe partial class PayPalPaymentDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PayPalPaymentDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PayPalPaymentDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PayPalPaymentDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("payPalPaymentDidCancel")]
		[CompilerGenerated]
		public virtual void PayPalPaymentDidCancel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("payPalPaymentDidComplete:")]
		[CompilerGenerated]
		public virtual void PayPalPaymentDidComplete (PayPalPayment completedPayment)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		static NSString _PayPalEnvironmentNoNetwork;
		[Field ("PayPalEnvironmentNoNetwork",  "__Internal")]
		public static NSString PayPalEnvironmentNoNetwork {
			get {
				if (_PayPalEnvironmentNoNetwork == null)
					_PayPalEnvironmentNoNetwork = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PayPalEnvironmentNoNetwork");
				return _PayPalEnvironmentNoNetwork;
			}
		}
		[CompilerGenerated]
		static NSString _PayPalEnvironmentProduction;
		[Field ("PayPalEnvironmentProduction",  "__Internal")]
		public static NSString PayPalEnvironmentProduction {
			get {
				if (_PayPalEnvironmentProduction == null)
					_PayPalEnvironmentProduction = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PayPalEnvironmentProduction");
				return _PayPalEnvironmentProduction;
			}
		}
		[CompilerGenerated]
		static NSString _PayPalEnvironmentSandbox;
		[Field ("PayPalEnvironmentSandbox",  "__Internal")]
		public static NSString PayPalEnvironmentSandbox {
			get {
				if (_PayPalEnvironmentSandbox == null)
					_PayPalEnvironmentSandbox = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PayPalEnvironmentSandbox");
				return _PayPalEnvironmentSandbox;
			}
		}
		[CompilerGenerated]
		static NSString _PayPalTransactionDidSucceedNotification;
		[Field ("PayPalTransactionDidSucceedNotification",  "__Internal")]
		[Advice ("Use PayPalPaymentDelegate.Notifications.ObservePayPalTransactionDidSucceed helper method instead.")]
		public static NSString PayPalTransactionDidSucceedNotification {
			get {
				if (_PayPalTransactionDidSucceedNotification == null)
					_PayPalTransactionDidSucceedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PayPalTransactionDidSucceedNotification");
				return _PayPalTransactionDidSucceedNotification;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObservePayPalTransactionDidSucceed (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PayPalTransactionDidSucceedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObservePayPalTransactionDidSucceed (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PayPalTransactionDidSucceedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		
		}
	} /* class PayPalPaymentDelegate */
}
