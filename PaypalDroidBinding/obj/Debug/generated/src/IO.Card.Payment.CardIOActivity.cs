using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Card.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']"
	[global::Android.Runtime.Register ("io/card/payment/CardIOActivity", DoNotGenerateAcw=true)]
	public sealed partial class CardIOActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_CAPTURED_CARD_IMAGE']"
		[Register ("EXTRA_CAPTURED_CARD_IMAGE")]
		public const string ExtraCapturedCardImage = (string) "io.card.payment.capturedCardImage";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_GUIDE_COLOR']"
		[Register ("EXTRA_GUIDE_COLOR")]
		public const string ExtraGuideColor = (string) "io.card.payment.guideColor";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_HIDE_CARDIO_LOGO']"
		[Register ("EXTRA_HIDE_CARDIO_LOGO")]
		public const string ExtraHideCardioLogo = (string) "io.card.payment.hideLogo";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_KEEP_APPLICATION_THEME']"
		[Register ("EXTRA_KEEP_APPLICATION_THEME")]
		public const string ExtraKeepApplicationTheme = (string) "io.card.payment.keepApplicationTheme";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_LANGUAGE_OR_LOCALE']"
		[Register ("EXTRA_LANGUAGE_OR_LOCALE")]
		public const string ExtraLanguageOrLocale = (string) "io.card.payment.languageOrLocale";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_NO_CAMERA']"
		[Register ("EXTRA_NO_CAMERA")]
		public const string ExtraNoCamera = (string) "io.card.payment.noCamera";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_REQUIRE_CVV']"
		[Register ("EXTRA_REQUIRE_CVV")]
		public const string ExtraRequireCvv = (string) "io.card.payment.requireCVV";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_REQUIRE_EXPIRY']"
		[Register ("EXTRA_REQUIRE_EXPIRY")]
		public const string ExtraRequireExpiry = (string) "io.card.payment.requireExpiry";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_REQUIRE_POSTAL_CODE']"
		[Register ("EXTRA_REQUIRE_POSTAL_CODE")]
		public const string ExtraRequirePostalCode = (string) "io.card.payment.requirePostalCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_RETURN_CARD_IMAGE']"
		[Register ("EXTRA_RETURN_CARD_IMAGE")]
		public const string ExtraReturnCardImage = (string) "io.card.payment.returnCardImage";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SCAN_EXPIRY']"
		[Register ("EXTRA_SCAN_EXPIRY")]
		public const string ExtraScanExpiry = (string) "io.card.payment.scanExpiry";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SCAN_INSTRUCTIONS']"
		[Register ("EXTRA_SCAN_INSTRUCTIONS")]
		public const string ExtraScanInstructions = (string) "io.card.payment.scanInstructions";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SCAN_OVERLAY_LAYOUT_ID']"
		[Register ("EXTRA_SCAN_OVERLAY_LAYOUT_ID")]
		public const string ExtraScanOverlayLayoutId = (string) "io.card.payment.scanOverlayLayoutId";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SCAN_RESULT']"
		[Register ("EXTRA_SCAN_RESULT")]
		public const string ExtraScanResult = (string) "io.card.payment.scanResult";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SUPPRESS_CONFIRMATION']"
		[Register ("EXTRA_SUPPRESS_CONFIRMATION")]
		public const string ExtraSuppressConfirmation = (string) "io.card.payment.suppressConfirmation";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SUPPRESS_MANUAL_ENTRY']"
		[Register ("EXTRA_SUPPRESS_MANUAL_ENTRY")]
		public const string ExtraSuppressManualEntry = (string) "io.card.payment.suppressManual";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_SUPPRESS_SCAN']"
		[Register ("EXTRA_SUPPRESS_SCAN")]
		public const string ExtraSuppressScan = (string) "io.card.payment.suppressScan";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_USE_CARDIO_LOGO']"
		[Register ("EXTRA_USE_CARDIO_LOGO")]
		public const string ExtraUseCardioLogo = (string) "io.card.payment.useCardIOLogo";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='EXTRA_USE_PAYPAL_ACTIONBAR_ICON']"
		[Register ("EXTRA_USE_PAYPAL_ACTIONBAR_ICON")]
		public const string ExtraUsePaypalActionbarIcon = (string) "io.card.payment.intentSenderIsPayPal";

		static IntPtr RESULT_CARD_INFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='RESULT_CARD_INFO']"
		[Register ("RESULT_CARD_INFO")]
		public static int ResultCardInfo {
			get {
				if (RESULT_CARD_INFO_jfieldId == IntPtr.Zero)
					RESULT_CARD_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_CARD_INFO", "I");
				return JNIEnv.GetStaticIntField (class_ref, RESULT_CARD_INFO_jfieldId);
			}
		}

		static IntPtr RESULT_CONFIRMATION_SUPPRESSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='RESULT_CONFIRMATION_SUPPRESSED']"
		[Register ("RESULT_CONFIRMATION_SUPPRESSED")]
		public static int ResultConfirmationSuppressed {
			get {
				if (RESULT_CONFIRMATION_SUPPRESSED_jfieldId == IntPtr.Zero)
					RESULT_CONFIRMATION_SUPPRESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_CONFIRMATION_SUPPRESSED", "I");
				return JNIEnv.GetStaticIntField (class_ref, RESULT_CONFIRMATION_SUPPRESSED_jfieldId);
			}
		}

		static IntPtr RESULT_ENTRY_CANCELED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='RESULT_ENTRY_CANCELED']"
		[Register ("RESULT_ENTRY_CANCELED")]
		public static int ResultEntryCanceled {
			get {
				if (RESULT_ENTRY_CANCELED_jfieldId == IntPtr.Zero)
					RESULT_ENTRY_CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_ENTRY_CANCELED", "I");
				return JNIEnv.GetStaticIntField (class_ref, RESULT_ENTRY_CANCELED_jfieldId);
			}
		}

		static IntPtr RESULT_SCAN_NOT_AVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='RESULT_SCAN_NOT_AVAILABLE']"
		[Register ("RESULT_SCAN_NOT_AVAILABLE")]
		public static int ResultScanNotAvailable {
			get {
				if (RESULT_SCAN_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					RESULT_SCAN_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_SCAN_NOT_AVAILABLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, RESULT_SCAN_NOT_AVAILABLE_jfieldId);
			}
		}

		static IntPtr RESULT_SCAN_SUPPRESSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/field[@name='RESULT_SCAN_SUPPRESSED']"
		[Register ("RESULT_SCAN_SUPPRESSED")]
		public static int ResultScanSuppressed {
			get {
				if (RESULT_SCAN_SUPPRESSED_jfieldId == IntPtr.Zero)
					RESULT_SCAN_SUPPRESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_SCAN_SUPPRESSED", "I");
				return JNIEnv.GetStaticIntField (class_ref, RESULT_SCAN_SUPPRESSED_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/card/payment/CardIOActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardIOActivity); }
		}

		internal CardIOActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/constructor[@name='CardIOActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardIOActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CardIOActivity)) {
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

		static IntPtr id_getTorchRect;
		public unsafe global::Android.Graphics.Rect TorchRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='getTorchRect' and count(parameter)=0]"
			[Register ("getTorchRect", "()Landroid/graphics/Rect;", "GetGetTorchRectHandler")]
			get {
				if (id_getTorchRect == IntPtr.Zero)
					id_getTorchRect = JNIEnv.GetMethodID (class_ref, "getTorchRect", "()Landroid/graphics/Rect;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTorchRect), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_canReadCardWithCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='canReadCardWithCamera' and count(parameter)=0]"
		[Register ("canReadCardWithCamera", "()Z", "")]
		public static unsafe bool CanReadCardWithCamera ()
		{
			if (id_canReadCardWithCamera == IntPtr.Zero)
				id_canReadCardWithCamera = JNIEnv.GetStaticMethodID (class_ref, "canReadCardWithCamera", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_canReadCardWithCamera);
			} finally {
			}
		}

		static IntPtr id_getCapturedCardImage_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='getCapturedCardImage' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getCapturedCardImage", "(Landroid/content/Intent;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetCapturedCardImage (global::Android.Content.Intent p0)
		{
			if (id_getCapturedCardImage_Landroid_content_Intent_ == IntPtr.Zero)
				id_getCapturedCardImage_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getCapturedCardImage", "(Landroid/content/Intent;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCapturedCardImage_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "")]
		protected override sealed unsafe void OnActivityResult (int p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.Result p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_onBackPressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='onBackPressed' and count(parameter)=0]"
		[Register ("onBackPressed", "()V", "")]
		public override sealed unsafe void OnBackPressed ()
		{
			if (id_onBackPressed == IntPtr.Zero)
				id_onBackPressed = JNIEnv.GetMethodID (class_ref, "onBackPressed", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBackPressed);
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		protected override sealed unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		protected override sealed unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
			} finally {
			}
		}

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "")]
		protected override sealed unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
			} finally {
			}
		}

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		protected override sealed unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
			} finally {
			}
		}

		static IntPtr id_sdkBuildDate;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='sdkBuildDate' and count(parameter)=0]"
		[Register ("sdkBuildDate", "()Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SdkBuildDate ()
		{
			if (id_sdkBuildDate == IntPtr.Zero)
				id_sdkBuildDate = JNIEnv.GetStaticMethodID (class_ref, "sdkBuildDate", "()Ljava/util/Date;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sdkBuildDate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sdkVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardIOActivity']/method[@name='sdkVersion' and count(parameter)=0]"
		[Register ("sdkVersion", "()Ljava/lang/String;", "")]
		public static unsafe string SdkVersion ()
		{
			if (id_sdkVersion == IntPtr.Zero)
				id_sdkVersion = JNIEnv.GetStaticMethodID (class_ref, "sdkVersion", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sdkVersion), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
