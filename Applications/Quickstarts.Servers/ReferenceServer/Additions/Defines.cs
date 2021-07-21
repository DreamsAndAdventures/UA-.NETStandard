using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS1591

namespace Quickstarts.ReferenceServer
{
    public class Defines
    {
        public const int MAX_VALUE = 100;
        public const int MIN_VALUE = 0;
        public const int NORMAL_START_VALUE = 50;

        public const int HIGHHIGH_ALARM = 90;
        public const int HIGH_ALARM = 70;
        public const int LOW_ALARM = 30;
        public const int LOWLOW_ALARM = 10;

        public const int DEVIATION_HIGHHIGH_ALARM = 10;
        public const int DEVIATION_HIGH_ALARM = 7;
        public const int DEVIATION_LOW_ALARM = -7;
        public const int DEVIATION_LOWLOW_ALARM = -10;

        public const int RATEOFCHANGE_OFFSET = 65;
        public const int RATEOFCHANGE_MAXIMUM = MAX_VALUE + ( RATEOFCHANGE_OFFSET * 2 );
        public const int RATEOFCHANGE_MINIMUM = MIN_VALUE;
        public const int RATEOFCHANGE_HIGHHIGH_THRESHOLD = 180;
        public const int RATEOFCHANGE_HIGH_THRESHOLD = HIGH_ALARM + RATEOFCHANGE_OFFSET;
        public const int RATEOFCHANGE_LOW_THRESHOLD = LOW_ALARM + RATEOFCHANGE_OFFSET;
        public const int RATEOFCHANGE_LOWLOW_THRESHOLD = 50;
        public const int RATEOFCHANGE_HIGHHIGH_ALARM = 16;
        public const int RATEOFCHANGE_HIGH_ALARM = 8;
        public const int RATEOFCHANGE_LOW_ALARM = -8;
        public const int RATEOFCHANGE_LOWLOW_ALARM = -16;

        public const int INACTIVE_SEVERITY = 100;

        public const int HIGHHIGH_SEVERITY = 850;
        public const int HIGH_SEVERITY = 450;
        public const int LOW_SEVERITY = 400;
        public const int LOWLOW_SEVERITY = 800;

        public const int BOOL_SEVERITY = 500;


        public const double NORMAL_MAX_TIME_SHELVED = 2000000;
        public const double SHORT_MAX_TIME_SHELVED = 30000;

        public const string BASE_PRODUCT_URI = "http://dreamsandadventures.ca/FoundationServer/";

        public const int BASE_CUSTOM_TYPE_NODE_ID = 111111;

        public const string DERIVED_NAME = "Derived";
        public const int DERIVED_TYPE_OFFSET = 500000; // Goofy, but should work to make it easier to create new alarm types

        //public const int DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE = BASE_CUSTOM_TYPE_NODE_ID + 1;
        //public const string DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE_NAME = "DerivedSystemOffNormalAlarmType";
        //public const string DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE_PRODUCT_URI = BASE_PRODUCT_URI + DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE_NAME;

        public const int MILLISECONDS_PER_SECOND = 1000;
        public const int MILLISECONDS_PER_MINUTE = 60 * MILLISECONDS_PER_SECOND;
        public const int MILLISECONDS_PER_HOUR = 60 * MILLISECONDS_PER_MINUTE;
        public const int MILLISECONDS_PER_DAY = 24 * MILLISECONDS_PER_HOUR;
        public const int MILLISECONDS_PER_WEEK = 7 * MILLISECONDS_PER_DAY;
        public const int MILLISECONDS_PER_TWO_WEEKS = 2 * MILLISECONDS_PER_WEEK;

        public const string SET_CERTIFICATE_EXPIRATION_NAME = "SetCertificateExpiration";
        public const string RESET_CERTIFICATE_EXPIRATIONS_NAME = "ResetCertificateExpirations";
        public const string RESET_OUTSIDE_CERTIFICATE_NAME = "ResetOutsideCertificate";
        public const string RESET_INSIDE_CERTIFICATE_NAME = "ResetInsideCertificate";
        public const string RESET_EXPIRED_CERTIFICATE_NAME = "ResetExpiredCertificate";


        public const string OUTSIDE_LIMIT_NAME = "OutsideLimit";
        public const string INSIDE_LIMIT_NAME = "InsideLimit";
        public const string EXPIRED_LIMIT_NAME = "ExpiredLimit";

        public const string TRIGGER_EXTENSION = ".Trigger";
        public const string ALARM_EXTENSION = ".Alarm";
        public const string DISCREPANCY_TARGET_NAME = "TargetValueNodeId";


    }
}
