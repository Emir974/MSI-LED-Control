﻿using System.Collections.Generic;

namespace MSI_LED_Custom
{
    internal class Constants
    {
        #region vendors
        public const string VendorCodeNvidia = "10DE";
        public const string VendorCodeAmd = "1002";
        public const string SubVendorCodeMsi = "1462";
        #endregion

        #region nVidia
        #region Pascal
        public const string DeviceCodeGtx1080 = "1B80";
        public const string DeviceCodeGtx1070 = "1B81";
        public const string DeviceCodeGtx1060With6G = "1C03";
        public const string DeviceCodeGtx1060With3G = "1C02";
        #endregion
        #region Maxwell
        public const string DeviceCodeGtx980Ti = "17C8";
        public const string DeviceCodeGtx960 = "1401";
        #endregion
        #endregion

        #region AMD
        #region Polaris
        public const string DeviceCodeRxPolaris = "67DF";
        #endregion
        #endregion

        public static readonly List<string> SupportedDeviceCodes = new List<string>
        {
            DeviceCodeGtx1080,
            DeviceCodeGtx1070,
            DeviceCodeGtx1060With6G,
            DeviceCodeGtx1060With3G,
            DeviceCodeGtx980Ti,
            DeviceCodeGtx960,
            DeviceCodeRxPolaris
        };
    }
}
