using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalPayment", DoNotGenerateAcw=true)]
	public sealed partial class PayPalPayment : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/field[@name='PAYMENT_INTENT_AUTHORIZE']"
		[Register ("PAYMENT_INTENT_AUTHORIZE")]
		public const string PaymentIntentAuthorize = (string) "authorize";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/field[@name='PAYMENT_INTENT_ORDER']"
		[Register ("PAYMENT_INTENT_ORDER")]
		public const string PaymentIntentOrder = (string) "order";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/field[@name='PAYMENT_INTENT_SALE']"
		[Register ("PAYMENT_INTENT_SALE")]
		public const string PaymentIntentSale = (string) "sale";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalPayment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalPayment); }
		}

		internal PayPalPayment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/constructor[@name='PayPalPayment' and count(parameter)=4 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PayPalPayment (global::Java.Math.BigDecimal p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (PayPalPayment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getAmountAsLocalizedString;
		public unsafe string AmountAsLocalizedString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='getAmountAsLocalizedString' and count(parameter)=0]"
			[Register ("getAmountAsLocalizedString", "()Ljava/lang/String;", "GetGetAmountAsLocalizedStringHandler")]
			get {
				if (id_getAmountAsLocalizedString == IntPtr.Zero)
					id_getAmountAsLocalizedString = JNIEnv.GetMethodID (class_ref, "getAmountAsLocalizedString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmountAsLocalizedString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isEnablePayPalShippingAddressesRetrieval;
		public unsafe bool IsEnablePayPalShippingAddressesRetrieval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='isEnablePayPalShippingAddressesRetrieval' and count(parameter)=0]"
			[Register ("isEnablePayPalShippingAddressesRetrieval", "()Z", "GetIsEnablePayPalShippingAddressesRetrievalHandler")]
			get {
				if (id_isEnablePayPalShippingAddressesRetrieval == IntPtr.Zero)
					id_isEnablePayPalShippingAddressesRetrieval = JNIEnv.GetMethodID (class_ref, "isEnablePayPalShippingAddressesRetrieval", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnablePayPalShippingAddressesRetrieval);
				} finally {
				}
			}
		}

		static IntPtr id_isNoShipping;
		public unsafe bool IsNoShipping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='isNoShipping' and count(parameter)=0]"
			[Register ("isNoShipping", "()Z", "GetIsNoShippingHandler")]
			get {
				if (id_isNoShipping == IntPtr.Zero)
					id_isNoShipping = JNIEnv.GetMethodID (class_ref, "isNoShipping", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNoShipping);
				} finally {
				}
			}
		}

		static IntPtr id_isProcessable;
		public unsafe bool IsProcessable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='isProcessable' and count(parameter)=0]"
			[Register ("isProcessable", "()Z", "GetIsProcessableHandler")]
			get {
				if (id_isProcessable == IntPtr.Zero)
					id_isProcessable = JNIEnv.GetMethodID (class_ref, "isProcessable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProcessable);
				} finally {
				}
			}
		}

		static IntPtr id_getProvidedShippingAddress;
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress ProvidedShippingAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='getProvidedShippingAddress' and count(parameter)=0]"
			[Register ("getProvidedShippingAddress", "()Lcom/paypal/android/sdk/payments/ShippingAddress;", "GetGetProvidedShippingAddressHandler")]
			get {
				if (id_getProvidedShippingAddress == IntPtr.Zero)
					id_getProvidedShippingAddress = JNIEnv.GetMethodID (class_ref, "getProvidedShippingAddress", "()Lcom/paypal/android/sdk/payments/ShippingAddress;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvidedShippingAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/math/BigDecimal;", "")]
		protected unsafe global::Java.Math.BigDecimal A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/math/BigDecimal;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "")]
		protected unsafe string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_bnCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='bnCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bnCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment BnCode (string p0)
		{
			if (id_bnCode_Ljava_lang_String_ == IntPtr.Zero)
				id_bnCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bnCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_bnCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		protected unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_custom_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("custom", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment Custom (string p0)
		{
			if (id_custom_Ljava_lang_String_ == IntPtr.Zero)
				id_custom_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "custom", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_custom_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "")]
		protected unsafe string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "")]
		protected unsafe string E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_e), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_enablePayPalShippingAddressesRetrieval_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='enablePayPalShippingAddressesRetrieval' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enablePayPalShippingAddressesRetrieval", "(Z)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment EnablePayPalShippingAddressesRetrieval (bool p0)
		{
			if (id_enablePayPalShippingAddressesRetrieval_Z == IntPtr.Zero)
				id_enablePayPalShippingAddressesRetrieval_Z = JNIEnv.GetMethodID (class_ref, "enablePayPalShippingAddressesRetrieval", "(Z)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enablePayPalShippingAddressesRetrieval_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/paypal/android/sdk/payments/PayPalPaymentDetails;", "")]
		protected unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPaymentDetails F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/paypal/android/sdk/payments/PayPalPaymentDetails;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPaymentDetails> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_f), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()[Lcom/paypal/android/sdk/payments/PayPalItem;", "")]
		protected unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalItem[] G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()[Lcom/paypal/android/sdk/payments/PayPalItem;");
			try {
				return (global::Com.Paypal.Android.Sdk.Payments.PayPalItem[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_g), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Paypal.Android.Sdk.Payments.PayPalItem));
			} finally {
			}
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "")]
		protected unsafe string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_h), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "")]
		protected unsafe string I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_i), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_invoiceNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='invoiceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invoiceNumber", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment InvoiceNumber (string p0)
		{
			if (id_invoiceNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_invoiceNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "invoiceNumber", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoiceNumber_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_items_arrayLcom_paypal_android_sdk_payments_PayPalItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='items' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.payments.PayPalItem[]']]"
		[Register ("items", "([Lcom/paypal/android/sdk/payments/PayPalItem;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment Items (global::Com.Paypal.Android.Sdk.Payments.PayPalItem[] p0)
		{
			if (id_items_arrayLcom_paypal_android_sdk_payments_PayPalItem_ == IntPtr.Zero)
				id_items_arrayLcom_paypal_android_sdk_payments_PayPalItem_ = JNIEnv.GetMethodID (class_ref, "items", "([Lcom/paypal/android/sdk/payments/PayPalItem;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_items_arrayLcom_paypal_android_sdk_payments_PayPalItem_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/lang/String;", "")]
		protected unsafe string J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_j), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_paymentDetails_Lcom_paypal_android_sdk_payments_PayPalPaymentDetails_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='paymentDetails' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.payments.PayPalPaymentDetails']]"
		[Register ("paymentDetails", "(Lcom/paypal/android/sdk/payments/PayPalPaymentDetails;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment PaymentDetails (global::Com.Paypal.Android.Sdk.Payments.PayPalPaymentDetails p0)
		{
			if (id_paymentDetails_Lcom_paypal_android_sdk_payments_PayPalPaymentDetails_ == IntPtr.Zero)
				id_paymentDetails_Lcom_paypal_android_sdk_payments_PayPalPaymentDetails_ = JNIEnv.GetMethodID (class_ref, "paymentDetails", "(Lcom/paypal/android/sdk/payments/PayPalPaymentDetails;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_paymentDetails_Lcom_paypal_android_sdk_payments_PayPalPaymentDetails_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_providedShippingAddress_Lcom_paypal_android_sdk_payments_ShippingAddress_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='providedShippingAddress' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.payments.ShippingAddress']]"
		[Register ("providedShippingAddress", "(Lcom/paypal/android/sdk/payments/ShippingAddress;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment InvokeProvidedShippingAddress (global::Com.Paypal.Android.Sdk.Payments.ShippingAddress p0)
		{
			if (id_providedShippingAddress_Lcom_paypal_android_sdk_payments_ShippingAddress_ == IntPtr.Zero)
				id_providedShippingAddress_Lcom_paypal_android_sdk_payments_ShippingAddress_ = JNIEnv.GetMethodID (class_ref, "providedShippingAddress", "(Lcom/paypal/android/sdk/payments/ShippingAddress;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_providedShippingAddress_Lcom_paypal_android_sdk_payments_ShippingAddress_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_softDescriptor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='softDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("softDescriptor", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalPayment SoftDescriptor (string p0)
		{
			if (id_softDescriptor_Ljava_lang_String_ == IntPtr.Zero)
				id_softDescriptor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "softDescriptor", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalPayment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalPayment __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalPayment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_softDescriptor_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPayment']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
