﻿using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace PaypaliOSBinding
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
	[Protocol]
	[BaseType (typeof (NSObject))]
	public partial interface PayPalPayment {

		[Static, Export ("paymentWithAmount:currencyCode:shortDescription")]
		PayPalPayment PaymentWithAmount (NSDecimalNumber amount, string currencyCode, string shortDescription);

		[Export ("currencyCode", ArgumentSemantic.Copy)]
		string CurrencyCode { get; set; }

		[Export ("amount", ArgumentSemantic.Copy)]
		NSDecimalNumber Amount { get; set; }

		[Export ("shortDescription", ArgumentSemantic.Copy)]
		string ShortDescription { get; set; }

		[Export ("processable")]
		bool Processable { get; }

		[Export ("localizedAmountForDisplay", ArgumentSemantic.Copy)]
		string LocalizedAmountForDisplay { get; }

		[Export ("confirmation", ArgumentSemantic.Copy)]
		NSDictionary Confirmation { get; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface PayPalPaymentDelegate {

		[Export ("payPalPaymentDidCancel")]
		void PayPalPaymentDidCancel ();

		[Export ("payPalPaymentDidComplete:")]
		void PayPalPaymentDidComplete (PayPalPayment completedPayment);

		[Notification, Field ("PayPalTransactionDidSucceedNotification", "__Internal")]
		NSString PayPalTransactionDidSucceedNotification { get; }

		[Field ("PayPalEnvironmentProduction", "__Internal")]
		NSString PayPalEnvironmentProduction { get; }

		[Field ("PayPalEnvironmentSandbox", "__Internal")]
		NSString PayPalEnvironmentSandbox { get; }

		[Field ("PayPalEnvironmentNoNetwork", "__Internal")]
		NSString PayPalEnvironmentNoNetwork { get; }
	}
	[Protocol]
	[BaseType (typeof (UINavigationController))]
	public partial interface PayPalPaymentViewController {

		[Export ("initWithClientId:receiverEmail:payerId:payment:delegate:")]
		IntPtr Constructor (string clientId, string payPalAccountEmailAddress, string payerId, PayPalPayment payment, PayPalPaymentDelegate del);

		[Export ("paymentDelegate", ArgumentSemantic.Assign)]
		PayPalPaymentDelegate PaymentDelegate { get; set; }

		[Export ("languageOrLocale", ArgumentSemantic.Copy)]
		string LanguageOrLocale { get; set; }

		[Static, Export ("environment")]
		string Environment { get; set; }

		[Static, Export ("prepareForPaymentUsingClientId:")]
		void PrepareForPaymentUsingClientId (string clientId);

		[Export ("defaultUserEmail", ArgumentSemantic.Copy)]
		string DefaultUserEmail { get; set; }

		[Export ("defaultUserPhoneCountryCode", ArgumentSemantic.Copy)]
		string DefaultUserPhoneCountryCode { get; set; }

		[Export ("defaultUserPhoneNumber", ArgumentSemantic.Copy)]
		string DefaultUserPhoneNumber { get; set; }

		[Export ("hideCreditCardButton")]
		bool HideCreditCardButton { get; set; }

		[Export ("disableBlurWhenBackgrounding")]
		bool DisableBlurWhenBackgrounding { get; set; }

		[Export ("state")]
		PayPalPaymentViewControllerState State { get; }

		[Static, Export ("libraryVersion")]
		string LibraryVersion { get; }
	}
}

