///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: Constants.cs
////
//// Date Created: 12/17/2016
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 12/17/2016     Initial
//// 03/08/2017     Removed Model/View Constant classes since they're not needed. Renamed EnumsConstants
///////////////////////////////////////////////////////////////////////////////////////////////////

namespace Website.Utility
{
    /// <summary> Constants for ensums
    /// </summary>
    public static class Constants
    {
        public static string GENERAL_CATEGORY { get { return "General"; } }
        public static string GAMING_CATEGORY { get { return "Gaming"; } }
        public static string LIFE_CATEGORY { get { return "Life"; } }
        public static string FINANCIAL_CATEGORY { get { return "Financial"; } }
        public static string PROGRAMMING_CATEGORY { get { return "Programming"; } }
        public static string RELATIONSHIP_CATEGORY { get { return "Relationship"; } }
        public static string OTHER_CATEGORY { get { return "Other"; } }
    }
}