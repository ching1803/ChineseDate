using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseDate
{
    public class ChineseDate
    {
        public static string ConvertToChineseDate(DateTime dateTime)
        {
            string year = ConvertChiYear(dateTime.Year.ToString());
            string month = ConvertChiMonth(dateTime.Month.ToString());
            string day = ConvertChiDay(dateTime.Day.ToString());
            return year + "年" + month + "月" + day + "日";
        }

        public static string ConvertToChineseDate(DateTime dateTime, bool showDetails, bool showMinute, bool showSecond)
        {
            string baseStr = ConvertToChineseDate(dateTime);
            if(!showDetails) { return baseStr; }

            int hourIn24 = dateTime.Hour;
            int hourIn12 = (hourIn24 > 12) ? hourIn24 - 12 : hourIn24;
            string amOrPm = (hourIn24 > 12) ? "下午" : "上午";
            string hour = ConverChiHour((hourIn12).ToString());
            baseStr += amOrPm + hour + "時";
            if (!showMinute) { return baseStr; }

            string minute = ConvertChiMinute(dateTime.Minute.ToString());
            baseStr += minute + "分";
            if (!showSecond) { return baseStr; }

            string second = ConvertChiMinute(dateTime.Second.ToString());
            baseStr += second + "秒";
            return baseStr;

        }


        public static string ConvertChiYear(string year)
        {
            StringBuilder result = new StringBuilder();
            for(var i = 0; i< year.Length; i++)
            {
                switch (year[i])
                {
                    case '1':
                        result.Append("一");
                        break;
                    case '2':
                        result.Append("二");
                        break;
                    case '3':
                        result.Append("三");
                        break;
                    case '4':
                        result.Append("四");
                        break;
                    case '5':
                        result.Append("五");
                        break;
                    case '6':
                        result.Append("六");
                        break;
                    case '7':
                        result.Append("七");
                        break;
                    case '8':
                        result.Append("八");
                        break;
                    case '9':
                        result.Append("九");
                        break;
                    default:
                        result.Append("零");
                        break;
                }
            }

            return result.ToString();
        }

        public static string ConvertChiMonth(string month)
        {
            return ConvertOneToTwelveChiNumber(month);
        }

        public static string ConvertChiDay(string day)
        {
            return ConverSixtyChiNumber(day);
        }

        public static string ConverChiHour(string hour)
        {
            return ConvertOneToTwelveChiNumber(hour);
        }
        public static string ConvertChiMinute(string minute)
        {
            return ConverSixtyChiNumber(minute);
        }
        public static string ConvertChiSecond(string second)
        {
            return ConverSixtyChiNumber(second);
        }

        private static string ConvertOneToTwelveChiNumber(string number)
        {
            StringBuilder result = new StringBuilder();
            switch (number)
            {
                case "1":
                    result.Append("一");
                    break;
                case "2":
                    result.Append("二");
                    break;
                case "3":
                    result.Append("三");
                    break;
                case "4":
                    result.Append("四");
                    break;
                case "5":
                    result.Append("五");
                    break;
                case "6":
                    result.Append("六");
                    break;
                case "7":
                    result.Append("七");
                    break;
                case "8":
                    result.Append("八");
                    break;
                case "9":
                    result.Append("九");
                    break;
                case "10":
                    result.Append("十");
                    break;
                case "11":
                    result.Append("十一");
                    break;
                default:
                    result.Append("十二");
                    break;
            }
            return result.ToString();
        }

        private static string ConverSixtyChiNumber(string number)
        {
            StringBuilder result = new StringBuilder();
            if (number.Length == 2)
            {
                switch (number[0].ToString())
                {
                    case "1":
                        result.Append("十");
                        break;
                    case "2":
                        result.Append("二十");
                        break;
                    case "3":
                        result.Append("三十");
                        break;
                    case "4":
                        result.Append("四十");
                        break;
                    case "5":
                        result.Append("五十");
                        break;
                    default:
                        result.Append("六十");
                        break;
                }

                switch (number[1].ToString())
                {
                    case "1":
                        result.Append("一");
                        break;
                    case "2":
                        result.Append("二");
                        break;
                    case "3":
                        result.Append("三");
                        break;
                    case "4":
                        result.Append("四");
                        break;
                    case "5":
                        result.Append("五");
                        break;
                    case "6":
                        result.Append("六");
                        break;
                    case "7":
                        result.Append("七");
                        break;
                    case "8":
                        result.Append("八");
                        break;
                    case "9":
                        result.Append("九");
                        break;
                    default:
                        break;
                }
                return result.ToString();

            }
            else
            {
                switch (number[0].ToString())
                {
                    case "1":
                        result.Append("一");
                        break;
                    case "2":
                        result.Append("二");
                        break;
                    case "3":
                        result.Append("三");
                        break;
                    case "4":
                        result.Append("四");
                        break;
                    case "5":
                        result.Append("五");
                        break;
                    case "6":
                        result.Append("六");
                        break;
                    case "7":
                        result.Append("七");
                        break;
                    case "8":
                        result.Append("八");
                        break;
                    case "9":
                        result.Append("九");
                        break;
                    default:
                        break;
                }
                return result.ToString();
            }
        }


    }
}
