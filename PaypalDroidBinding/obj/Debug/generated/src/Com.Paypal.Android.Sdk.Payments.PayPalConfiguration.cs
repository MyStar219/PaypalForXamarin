using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalConfiguration", DoNotGenerateAcw=true)]
	public sealed partial class PayPalConfiguration : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/field[@name='ENVIRONMENT_NO_NETWORK']"
		[Register ("ENVIRONMENT_NO_NETWORK")]
		public const string EnvironmentNoNetwork = (string) "mock";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/field[@name='ENVIRONMENT_PRODUCTION']"
		[Register ("ENVIRONMENT_PRODUCTION")]
		public const string EnvironmentProduction = (string) "live";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/field[@name='ENVIRONMENT_SANDBOX']"
		[Register ("ENVIRONMENT_SANDBOX")]
		public const string EnvironmentSandbox = (string) "sandbox";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalConfiguration); }
		}

		internal PayPalConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/constructor[@name='PayPalConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayPalConfiguration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayPalConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getLibraryVersion;
		public static unsafe string LibraryVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='getLibraryVersion' and count(parameter)=0]"
			[Register ("getLibraryVersion", "()Ljava/lang/String;", "GetGetLibraryVersionHandler")]
			get {
				if (id_getLibraryVersion == IntPtr.Zero)
					id_getLibraryVersion = JNIEnv.GetStaticMethodID (class_ref, "getLibraryVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLibraryVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_acceptCreditCards_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='acceptCreditCards' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("acceptCreditCards", "(Z)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration AcceptCreditCards (bool p0)
		{
			if (id_acceptCreditCards_Z == IntPtr.Zero)
				id_acceptCreditCards_Z = JNIEnv.GetMethodID (class_ref, "acceptCreditCards", "(Z)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acceptCreditCards_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_clientId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='clientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clientId", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration ClientId (string p0)
		{
			if (id_clientId_Ljava_lang_String_ == IntPtr.Zero)
				id_clientId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clientId", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clientId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_defaultUserEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='defaultUserEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defaultUserEmail", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration DefaultUserEmail (string p0)
		{
			if (id_defaultUserEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_defaultUserEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "defaultUserEmail", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_defaultUserEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_defaultUserPhone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='defaultUserPhone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defaultUserPhone", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration DefaultUserPhone (string p0)
		{
			if (id_defaultUserPhone_Ljava_lang_String_ == IntPtr.Zero)
				id_defaultUserPhone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "defaultUserPhone", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_defaultUserPhone_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_defaultUserPhoneCountryCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='defaultUserPhoneCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defaultUserPhoneCountryCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration DefaultUserPhoneCountryCode (string p0)
		{
			if (id_defaultUserPhoneCountryCode_Ljava_lang_String_ == IntPtr.Zero)
				id_defaultUserPhoneCountryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "defaultUserPhoneCountryCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_defaultUserPhoneCountryCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_environment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='environment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("environment", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration Environment (string p0)
		{
			if (id_environment_Ljava_lang_String_ == IntPtr.Zero)
				id_environment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "environment", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_environment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_forceDefaultsOnSandbox_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='forceDefaultsOnSandbox' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("forceDefaultsOnSandbox", "(Z)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration ForceDefaultsOnSandbox (bool p0)
		{
			if (id_forceDefaultsOnSandbox_Z == IntPtr.Zero)
				id_forceDefaultsOnSandbox_Z = JNIEnv.GetMethodID (class_ref, "forceDefaultsOnSandbox", "(Z)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forceDefaultsOnSandbox_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getApplicationCorrelationId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='getApplicationCorrelationId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getApplicationCorrelationId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetApplicationCorrelationId (global::Android.Content.Context p0)
		{
			if (id_getApplicationCorrelationId_Landroid_content_Context_ == IntPtr.Zero)
				id_getApplicationCorrelationId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getApplicationCorrelationId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationCorrelationId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getClientMetadataId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='getClientMetadataId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getClientMetadataId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetClientMetadataId (global::Android.Content.Context p0)
		{
			if (id_getClientMetadataId_Landroid_content_Context_ == IntPtr.Zero)
				id_getClientMetadataId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getClientMetadataId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClientMetadataId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_languageOrLocale_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='languageOrLocale' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("languageOrLocale", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration LanguageOrLocale (string p0)
		{
			if (id_languageOrLocale_Ljava_lang_String_ == IntPtr.Zero)
				id_languageOrLocale_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "languageOrLocale", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_languageOrLocale_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_merchantName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='merchantName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("merchantName", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration MerchantName (string p0)
		{
			if (id_merchantName_Ljava_lang_String_ == IntPtr.Zero)
				id_merchantName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "merchantName", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_merchantName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_merchantPrivacyPolicyUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='merchantPrivacyPolicyUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("merchantPrivacyPolicyUri", "(Landroid/net/Uri;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration MerchantPrivacyPolicyUri (global::Android.Net.Uri p0)
		{
			if (id_merchantPrivacyPolicyUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_merchantPrivacyPolicyUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "merchantPrivacyPolicyUri", "(Landroid/net/Uri;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_merchantPrivacyPolicyUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merchantUserAgreementUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='merchantUserAgreementUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("merchantUserAgreementUri", "(Landroid/net/Uri;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration MerchantUserAgreementUri (global::Android.Net.Uri p0)
		{
			if (id_merchantUserAgreementUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_merchantUserAgreementUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "merchantUserAgreementUri", "(Landroid/net/Uri;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_merchantUserAgreementUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rememberUser_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='rememberUser' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rememberUser", "(Z)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration RememberUser (bool p0)
		{
			if (id_rememberUser_Z == IntPtr.Zero)
				id_rememberUser_Z = JNIEnv.GetMethodID (class_ref, "rememberUser", "(Z)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rememberUser_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sandboxUserPassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='sandboxUserPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sandboxUserPassword", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration SandboxUserPassword (string p0)
		{
			if (id_sandboxUserPassword_Ljava_lang_String_ == IntPtr.Zero)
				id_sandboxUserPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sandboxUserPassword", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sandboxUserPassword_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sandboxUserPin_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='sandboxUserPin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sandboxUserPin", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration SandboxUserPin (string p0)
		{
			if (id_sandboxUserPin_Ljava_lang_String_ == IntPtr.Zero)
				id_sandboxUserPin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sandboxUserPin", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/PayPalConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.PayPalConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sandboxUserPin_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='toString' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalConfiguration']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
