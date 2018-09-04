﻿namespace AuthorizeNet.Utilities
{
    public static class Constants
    {
        public const string ProxyProtocol = "http";

        public const string HttpsUseProxy = "http.useProxy";
        public const string HttpsProxyHost = "https.proxyHost";
        public const string HttpsProxyPort = "https.proxyPort";
	    public const string HttpsProxyUsername = "https.proxyUsername";
	    public const string HttpsProxyPassword = "https.proxyPassword";

		public const string HttpUseProxy = "http.proxyUse";
        public const string HttpProxyHost = "http.proxyHost";
        public const string HttpProxyPort = "http.proxyPort";

        public const string EnvApiLoginid = "API_LOGIN_ID";
        //public const string EnvTransactionKey = "TRANSACTION_KEY";
        //public const string EnvMd5Hashkey = "MD5_HASH_KEY";

        public const string PropApiLoginid = "api.login.id";
        //public const string PropTransactionKey = "transaction.key";
       // public const string PropMd5Hashkey = "md5.hash.key";

        public const string HttpConnectionTimeout = "http.connectionTimeout";
        public const string HttpReadWriteTimeout = "http.readWriteTimeout";

        public const int HttpConnectionDefaultTimeout = 30000;
        public const int HttpReadWriteDefaultTimeout = 30000;

        public const string SDKVersion = "1.9.1";
    }
}
