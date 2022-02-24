using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PrivateHire_Cars_System.myclass
{
    public static class Check
    {
        public static string currentUser = "";
        public static Boolean staffCheck;
        public static string customerEmail = "";
        public static decimal basePrice = 0.00m;
        public static decimal totalPrice = 0.00m;
        public static decimal subTotal = 0.00m;

        public static string verifyEmail;
        public static int verifyCab;

        public static bool special;

        public static int b_numOfPpl = 0;
        public static int b_cabSize = 0;
        public static decimal b_tripFare = 0.00m;
        public static string b_tripType = "";
        public static decimal b_carFee = 0.00m;
        public static decimal b_extraServiceFee = 1.00m;
        public static decimal b_discount15 = 0.00m;

        public static string pickAdd = "";
        public static string dropAdd = "";
        public static DateTime b_pickupDate;
        public static DateTime b_createDate;
        public static string b_cabType;
        public static string b_paymentType;
        public static string b_service;
        public static decimal b_serviceFee = 1.00m;
        public static string b_extraService;
        public static decimal b_total = 1.00m;
        public static string b_status;

        public static int c_id = 1;
        public static int d_id = 1;

        public static string taxiType = "";

        public static void getTotalprice()
        {
            if (taxiType == "Airport Taxi")
            {
                basePrice = 35m;
            }
            else
            {
                basePrice = 15m;
            }
        }

        public static void checkDiscount()
        {
            if (currentUser == "admin")
            {
                special = false;
            }
            else
            {
                special = true;
            }
        }
    }
}
