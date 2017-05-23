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
	[Protocol (Name = "PayPalPayment", WrapperType = typeof (PayPalPaymentWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PaymentWithAmount", Selector = "paymentWithAmount:currencyCode:shortDescription", ReturnType = typeof (PaypaliOSBinding.PayPalPayment), ParameterType = new Type [] { typeof (NSDecimalNumber), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrencyCode", Selector = "currencyCode", PropertyType = typeof (string), GetterSelector = "currencyCode", SetterSelector = "setCurrencyCode:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Amount", Selector = "amount", PropertyType = typeof (NSDecimalNumber), GetterSelector = "amount", SetterSelector = "setAmount:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ShortDescription", Selector = "shortDescription", PropertyType = typeof (string), GetterSelector = "shortDescription", SetterSelector = "setShortDescription:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Processable", Selector = "processable", PropertyType = typeof (bool), GetterSelector = "processable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "LocalizedAmountForDisplay", Selector = "localizedAmountForDisplay", PropertyType = typeof (string), GetterSelector = "localizedAmountForDisplay", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Confirmation", Selector = "confirmation", PropertyType = typeof (NSDictionary), GetterSelector = "confirmation", ArgumentSemantic = ArgumentSemantic.Copy)]
	public interface IPayPalPayment : INativeObject, IDisposable
	{
	}
	
	public static partial class PayPalPayment_Extensions {
		[CompilerGenerated]
		public static string GetCurrencyCode (this IPayPalPayment This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("currencyCode")));
		}
		
		[CompilerGenerated]
		public static void SetCurrencyCode (this IPayPalPayment This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCurrencyCode:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber GetAmount (this IPayPalPayment This)
		{
			return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("amount")));
		}
		
		[CompilerGenerated]
		public static void SetAmount (this IPayPalPayment This, NSDecimalNumber value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAmount:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static string GetShortDescription (this IPayPalPayment This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("shortDescription")));
		}
		
		[CompilerGenerated]
		public static void SetShortDescription (this IPayPalPayment This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setShortDescription:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static bool GetProcessable (this IPayPalPayment This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("processable"));
		}
		
		[CompilerGenerated]
		public static string GetLocalizedAmountForDisplay (this IPayPalPayment This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("localizedAmountForDisplay")));
		}
		
		[CompilerGenerated]
		public static NSDictionary GetConfirmation (this IPayPalPayment This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("confirmation")));
		}
		
	}
	
	internal sealed class PayPalPaymentWrapper : BaseWrapper, IPayPalPayment {
		[Preserve (Conditional = true)]
		public PayPalPaymentWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PaypaliOSBinding {
	[Protocol]
	[Register("PayPalPayment", true)]
	public unsafe partial class PayPalPayment : NSObject, IPayPalPayment {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PayPalPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PayPalPayment () : base (NSObjectFlag.Empty)
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
		protected PayPalPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PayPalPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("paymentWithAmount:currencyCode:shortDescription")]
		[CompilerGenerated]
		public static PayPalPayment PaymentWithAmount (NSDecimalNumber amount, string currencyCode, string shortDescription)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (currencyCode == null)
				throw new ArgumentNullException ("currencyCode");
			if (shortDescription == null)
				throw new ArgumentNullException ("shortDescription");
			var nscurrencyCode = NSString.CreateNative (currencyCode);
			var nsshortDescription = NSString.CreateNative (shortDescription);
			
			PayPalPayment ret;
			ret =  Runtime.GetNSObject<PayPalPayment> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("paymentWithAmount:currencyCode:shortDescription"), amount.Handle, nscurrencyCode, nsshortDescription));
			NSString.ReleaseNative (nscurrencyCode);
			NSString.ReleaseNative (nsshortDescription);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber Amount {
			[Export ("amount", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("amount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("amount")));
				}
				return ret;
			}
			
			[Export ("setAmount:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAmount:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAmount:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDictionary Confirmation {
			[Export ("confirmation", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("confirmation")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("confirmation")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CurrencyCode {
			[Export ("currencyCode", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currencyCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currencyCode")));
				}
			}
			
			[Export ("setCurrencyCode:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCurrencyCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCurrencyCode:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string LocalizedAmountForDisplay {
			[Export ("localizedAmountForDisplay", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("localizedAmountForDisplay")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("localizedAmountForDisplay")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Processable {
			[Export ("processable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("processable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("processable"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ShortDescription {
			[Export ("shortDescription", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shortDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shortDescription")));
				}
			}
			
			[Export ("setShortDescription:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShortDescription:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShortDescription:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class PayPalPayment */
}
