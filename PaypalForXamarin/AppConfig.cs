using System;

namespace PaypalForXamarin
{
	public class AppConfig
	{
		private static AppConfig instance;
		public static AppConfig Instance
		{
			get
			{
				if (instance == null)
					instance = new AppConfig ();
				return instance;
			}
		}
		private AppConfig ()
		{
		}

		public Environment Env {
			get;
			set;
		}

public const string kPayPalClientId = @"AeAS71Qs_qx-D4nkg7wdgg4JVPMhGkSYHk0-hUh0GMSpfOqt80jnMgXTEvGDymY6biqdjASmLWa6yxpL";
		public const string kPayPalReceiverEmail = @"edocineapp-facilitator@gmail.com";
		public const int REQUEST_CODE_PAYPAL_PAYMENT = 1;
	}

	public enum Environment
	{
		Mock,
		Sandbox,
		Production
	}

}