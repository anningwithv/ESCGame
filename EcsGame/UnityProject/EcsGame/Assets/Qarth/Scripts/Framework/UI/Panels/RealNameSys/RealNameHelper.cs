using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GameFrame
{
    public class RealNameHelper
    {
        public enum RealNamePopType
        {
            Success,
            Invalid,
            Warning,
        }

        public enum RealNameAgeType
        {
            Over18,
            Limited,
            Invalid,
        }

        public const string REALNAME_STATE_KEY = "real_name_sys_record";
        public const string REALNAME_DAILY_KEY = "real_name_sys_new_day_key";
        public const string REALNAME_LIMIT_PLAY_TIME = "real_name_sys_limit_play_time";

        public const string REALNAME_NEEDS = "请填写身份信息";
        public const string REALNAME_ID_ERROR = "身份信息格式不正确,请检查重试";
        public const string REALNAME_AGE_LIMIT_WORDS = "根据国家相关法律规定，未满8周岁的用户限制进入游戏";
        public const string REALNAME_TIME_LIMIT_OVER_WORDS = "您的账号今日已达到游戏时长上限，请注意休息";
        public const string REALNAME_TIME_LIMIT_START_WORDS = "您的账号已被纳入防沉迷系统，每日游戏时长为2小时，请合理安排游戏时间";

        // 验证18岁
        public static RealNameAgeType ValidAge18(string idNumber)
        {
            var dateStr = idNumber.Substring(6, 8);
            dateStr = dateStr.Substring(0, 4) + "-" + dateStr.Substring(4, 2) + "-" + dateStr.Substring(6);
            DateTime birthday;

            if (DateTime.TryParse(dateStr, out birthday))
            {
                ////Log.e(birthday);
                var disYear = DateTime.Now.Year - birthday.Year;
                var disMonth = DateTime.Now.Month - birthday.Month;
                if (disYear < 8)
                {
                    return RealNameAgeType.Invalid; // dead
                }
                else if (disYear > 18)
                {
                    return RealNameAgeType.Over18;
                }
                else if (disYear == 18)
                {
                    return disMonth >= 0 ? RealNameAgeType.Over18 : RealNameAgeType.Limited;
                }
                else
                {
                    return RealNameAgeType.Limited;
                }
            }
            return RealNameAgeType.Invalid;
        }

        /// <summary>  
        /// 验证身份证合理性  
        /// </summary>  
        /// <param name="Id"></param>  
        /// <returns></returns>  
        public static bool ValidIDCard(string idNumber)
        {
            if (idNumber.Length == 18)
            {
                bool check = ValidIDCard18(idNumber);
                return check;
            }
            else if (idNumber.Length == 15)
            {
                bool check = ValidIDCard15(idNumber);
                return check;
            }
            else
            {
                return false;
            }
        }


        /// <summary>  
        /// 18位身份证号码验证  
        /// </summary>  
        private static bool ValidIDCard18(string idNumber)
        {
            long n = 0;
            if (long.TryParse(idNumber.Remove(17), out n) == false
                || n < Math.Pow(10, 16) || long.TryParse(idNumber.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证  
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(idNumber.Remove(2)) == -1)
            {
                return false;//省份验证  
            }
            string birth = idNumber.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证  
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = idNumber.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != idNumber.Substring(17, 1).ToLower())
            {
                return false;//校验码验证  
            }
            return true;//符合GB11643-1999标准  
        }


        /// <summary>  
        /// 15位身份证号码验证  
        /// </summary>  
        private static bool ValidIDCard15(string idNumber)
        {
            long n = 0;
            if (long.TryParse(idNumber, out n) == false || n < Math.Pow(10, 14))
            {
                return false;//数字验证  
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(idNumber.Remove(2)) == -1)
            {
                return false;//省份验证  
            }
            string birth = idNumber.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证  
            }
            return true;
        }
    }
}