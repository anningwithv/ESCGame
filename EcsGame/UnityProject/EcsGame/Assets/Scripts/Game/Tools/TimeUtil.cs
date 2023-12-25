using System;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game.Logic
{
	public class TimeUtil
{
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER || UNITY_2021_2_OR_NEWER
        
	public static readonly DateTime UnixEpoch = DateTime.UnixEpoch;
	#else
	        public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	#endif
	
	    public static readonly long MaxUnixMs =
	            (DateTime.MaxValue.Ticks - UnixEpoch.Ticks) / TimeSpan.TicksPerMillisecond;
	    public static readonly long MinUnixMs = 0L;
	
	    /// <summary>
	    /// 获取当前时间 (统一从这里获取时间，方便以后处理)
	    /// </summary>
	    /// <returns></returns>
	    public static DateTime GetNow()
	    {
	        return DateTime.Now;
	    }
	
	    /// <summary>
	    /// dateTime转化为时间戳毫秒数
	    /// </summary>
	    /// <param name="dateTime"></param>
	    /// <returns></returns>
	    public static long DateTimeToUnixMs(DateTime dateTime)
	    {
	        DateTime utc = dateTime.ToUniversalTime();
	        if (utc.CompareTo(UnixEpoch) < 0)
	            throw new ArgumentOutOfRangeException(nameof(dateTime), "DateTime value may not be before the epoch");
	
	        return (utc.Ticks - UnixEpoch.Ticks) / TimeSpan.TicksPerMillisecond;
	    }
	
	    /// <summary>
	    /// 时间戳毫秒数转换成DateTime
	    /// </summary>
	    /// <param name="unixMs"></param>
	    /// <returns></returns>
	    public static DateTime UnixMsToDateTime(long unixMs)
	    {
	        if (unixMs < MinUnixMs || unixMs > MaxUnixMs)
	            throw new ArgumentOutOfRangeException(nameof(unixMs));
	
	        return new DateTime(unixMs * TimeSpan.TicksPerMillisecond + UnixEpoch.Ticks, DateTimeKind.Local);
	    }
	
	    /// <summary>
	    /// 获取当前毫秒数
	    /// </summary>
	    public static long CurrentUnixMs()
	    {
	        return DateTimeToUnixMs(GetNow());
	    }
	
	    /// <summary>
	    /// 获取当前秒数
	    /// </summary>
	    public static long CurrentUnixSec()
	    {
	        return CurrentUnixMs() / 1000;
	    }
	
	    /// <summary>
	    /// 是否是今天
	    /// </summary>
	    /// <param name="timeMs"></param>
	    public static bool IsToday(long timeMs)
	    {
	        var dt = UnixMsToDateTime(timeMs);
	        return GetNow().Date == dt.Date;
	    }
	}
	
}