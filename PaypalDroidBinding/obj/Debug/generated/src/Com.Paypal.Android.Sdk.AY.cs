using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aY']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/aY", DoNotGenerateAcw=true)]
	public sealed partial class AY : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aY']/field[@name='a']"
		[Register ("a")]
		public static IList<string> A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, a_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/aY", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AY); }
		}

		internal AY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
