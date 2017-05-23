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
	[Protocol (Name = "PayPalPaymentViewController", WrapperType = typeof (PayPalPaymentViewControllerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PrepareForPaymentUsingClientId", Selector = "prepareForPaymentUsingClientId:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PaymentDelegate", Selector = "paymentDelegate", PropertyType = typeof (PaypaliOSBinding.PayPalPaymentDelegate), GetterSelector = "paymentDelegate", SetterSelector = "setPaymentDelegate:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "LanguageOrLocale", Selector = "languageOrLocale", PropertyType = typeof (string), GetterSelector = "languageOrLocale", SetterSelector = "setLanguageOrLocale:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Environment", Selector = "environment", PropertyType = typeof (string), GetterSelector = "environment", SetterSelector = "setEnvironment:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DefaultUserEmail", Selector = "defaultUserEmail", PropertyType = typeof (string), GetterSelector = "defaultUserEmail", SetterSelector = "setDefaultUserEmail:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DefaultUserPhoneCountryCode", Selector = "defaultUserPhoneCountryCode", PropertyType = typeof (string), GetterSelector = "defaultUserPhoneCountryCode", SetterSelector = "setDefaultUserPhoneCountryCode:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DefaultUserPhoneNumber", Selector = "defaultUserPhoneNumber", PropertyType = typeof (string), GetterSelector = "defaultUserPhoneNumber", SetterSelector = "setDefaultUserPhoneNumber:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HideCreditCardButton", Selector = "hideCreditCardButton", PropertyType = typeof (bool), GetterSelector = "hideCreditCardButton", SetterSelector = "setHideCreditCardButton:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisableBlurWhenBackgrounding", Selector = "disableBlurWhenBackgrounding", PropertyType = typeof (bool), GetterSelector = "disableBlurWhenBackgrounding", SetterSelector = "setDisableBlurWhenBackgrounding:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "State", Selector = "state", PropertyType = typeof (PaypaliOSBinding.PayPalPaymentViewControllerState), GetterSelector = "state", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "LibraryVersion", Selector = "libraryVersion", PropertyType = typeof (string), GetterSelector = "libraryVersion", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IPayPalPaymentViewController : INativeObject, IDisposable
	{
	}
	
	public static partial class PayPalPaymentViewController_Extensions {
		[CompilerGenerated]
		public static PayPalPaymentDelegate GetPaymentDelegate (this IPayPalPaymentViewController This)
		{
			return  Runtime.GetNSObject<PayPalPaymentDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("paymentDelegate")));
		}
		
		[CompilerGenerated]
		public static void SetPaymentDelegate (this IPayPalPaymentViewController This, PayPalPaymentDelegate value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPaymentDelegate:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static string GetLanguageOrLocale (this IPayPalPaymentViewController This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("languageOrLocale")));
		}
		
		[CompilerGenerated]
		public static void SetLanguageOrLocale (this IPayPalPaymentViewController This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLanguageOrLocale:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static string GetDefaultUserEmail (this IPayPalPaymentViewController This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("defaultUserEmail")));
		}
		
		[CompilerGenerated]
		public static void SetDefaultUserEmail (this IPayPalPaymentViewController This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDefaultUserEmail:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static string GetDefaultUserPhoneCountryCode (this IPayPalPaymentViewController This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("defaultUserPhoneCountryCode")));
		}
		
		[CompilerGenerated]
		public static void SetDefaultUserPhoneCountryCode (this IPayPalPaymentViewController This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDefaultUserPhoneCountryCode:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static string GetDefaultUserPhoneNumber (this IPayPalPaymentViewController This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("defaultUserPhoneNumber")));
		}
		
		[CompilerGenerated]
		public static void SetDefaultUserPhoneNumber (this IPayPalPaymentViewController This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDefaultUserPhoneNumber:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static bool GetHideCreditCardButton (this IPayPalPaymentViewController This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hideCreditCardButton"));
		}
		
		[CompilerGenerated]
		public static void SetHideCreditCardButton (this IPayPalPaymentViewController This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setHideCreditCardButton:"), value);
		}
		
		[CompilerGenerated]
		public static bool GetDisableBlurWhenBackgrounding (this IPayPalPaymentViewController This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("disableBlurWhenBackgrounding"));
		}
		
		[CompilerGenerated]
		public static void SetDisableBlurWhenBackgrounding (this IPayPalPaymentViewController This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDisableBlurWhenBackgrounding:"), value);
		}
		
		[CompilerGenerated]
		public static PayPalPaymentViewControllerState GetState (this IPayPalPaymentViewController This)
		{
			return (PayPalPaymentViewControllerState) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("state"));
		}
		
	}
	
	internal sealed class PayPalPaymentViewControllerWrapper : BaseWrapper, IPayPalPaymentViewController {
		[Preserve (Conditional = true)]
		public PayPalPaymentViewControllerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PaypaliOSBinding {
	[Protocol]
	[Register("PayPalPaymentViewController", true)]
	public unsafe partial class PayPalPaymentViewController : global::UIKit.UINavigationController, IPayPalPaymentViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PayPalPaymentViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PayPalPaymentViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PayPalPaymentViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PayPalPaymentViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PayPalPaymentViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithClientId:receiverEmail:payerId:payment:delegate:")]
		[CompilerGenerated]
		public PayPalPaymentViewController (string clientId, string payPalAccountEmailAddress, string payerId, PayPalPayment payment, PayPalPaymentDelegate del)
			: base (NSObjectFlag.Empty)
		{
			if (clientId == null)
				throw new ArgumentNullException ("clientId");
			if (payPalAccountEmailAddress == null)
				throw new ArgumentNullException ("payPalAccountEmailAddress");
			if (payerId == null)
				throw new ArgumentNullException ("payerId");
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclientId = NSString.CreateNative (clientId);
			var nspayPalAccountEmailAddress = NSString.CreateNative (payPalAccountEmailAddress);
			var nspayerId = NSString.CreateNative (payerId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithClientId:receiverEmail:payerId:payment:delegate:"), nsclientId, nspayPalAccountEmailAddress, nspayerId, payment.Handle, del.Handle), "initWithClientId:receiverEmail:payerId:payment:delegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithClientId:receiverEmail:payerId:payment:delegate:"), nsclientId, nspayPalAccountEmailAddress, nspayerId, payment.Handle, del.Handle), "initWithClientId:receiverEmail:payerId:payment:delegate:");
			}
			NSString.ReleaseNative (nsclientId);
			NSString.ReleaseNative (nspayPalAccountEmailAddress);
			NSString.ReleaseNative (nspayerId);
			
		}
		
		[Export ("prepareForPaymentUsingClientId:")]
		[CompilerGenerated]
		public static void PrepareForPaymentUsingClientId (string clientId)
		{
			if (clientId == null)
				throw new ArgumentNullException ("clientId");
			var nsclientId = NSString.CreateNative (clientId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("prepareForPaymentUsingClientId:"), nsclientId);
			NSString.ReleaseNative (nsclientId);
			
		}
		
		[CompilerGenerated]
		public virtual string DefaultUserEmail {
			[Export ("defaultUserEmail", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultUserEmail")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultUserEmail")));
				}
			}
			
			[Export ("setDefaultUserEmail:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDefaultUserEmail:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDefaultUserEmail:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string DefaultUserPhoneCountryCode {
			[Export ("defaultUserPhoneCountryCode", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultUserPhoneCountryCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultUserPhoneCountryCode")));
				}
			}
			
			[Export ("setDefaultUserPhoneCountryCode:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDefaultUserPhoneCountryCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDefaultUserPhoneCountryCode:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string DefaultUserPhoneNumber {
			[Export ("defaultUserPhoneNumber", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultUserPhoneNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultUserPhoneNumber")));
				}
			}
			
			[Export ("setDefaultUserPhoneNumber:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDefaultUserPhoneNumber:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDefaultUserPhoneNumber:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisableBlurWhenBackgrounding {
			[Export ("disableBlurWhenBackgrounding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disableBlurWhenBackgrounding"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableBlurWhenBackgrounding"));
				}
			}
			
			[Export ("setDisableBlurWhenBackgrounding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisableBlurWhenBackgrounding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisableBlurWhenBackgrounding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public static string Environment {
			[Export ("environment")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("environment")));
			}
			
			[Export ("setEnvironment:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setEnvironment:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool HideCreditCardButton {
			[Export ("hideCreditCardButton")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hideCreditCardButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideCreditCardButton"));
				}
			}
			
			[Export ("setHideCreditCardButton:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHideCreditCardButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHideCreditCardButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string LanguageOrLocale {
			[Export ("languageOrLocale", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("languageOrLocale")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("languageOrLocale")));
				}
			}
			
			[Export ("setLanguageOrLocale:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLanguageOrLocale:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLanguageOrLocale:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static string LibraryVersion {
			[Export ("libraryVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("libraryVersion")));
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PaymentDelegate_var;
		[CompilerGenerated]
		public virtual PayPalPaymentDelegate PaymentDelegate {
			[Export ("paymentDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				PayPalPaymentDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PayPalPaymentDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paymentDelegate")));
				} else {
					ret =  Runtime.GetNSObject<PayPalPaymentDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentDelegate")));
				}
				MarkDirty ();
				__mt_PaymentDelegate_var = ret;
				return ret;
			}
			
			[Export ("setPaymentDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPaymentDelegate:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPaymentDelegate:"), value.Handle);
				}
				MarkDirty ();
				__mt_PaymentDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PayPalPaymentViewControllerState State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return (PayPalPaymentViewControllerState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				} else {
					return (PayPalPaymentViewControllerState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PaymentDelegate_var = null;
			}
		}
	} /* class PayPalPaymentViewController */
}
