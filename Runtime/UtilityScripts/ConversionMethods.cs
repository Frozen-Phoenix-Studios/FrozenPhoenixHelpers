using System;

namespace FrozenPhoenix.Utilities
{
    public static class ConversionMethods
    {
        /// <summary>
        /// Convert int array to date time.
        /// Structured as {year, month, day}
        /// </summary>
        /// <param name="data"></param>
        /// <returns>DateTime</returns>
        public static DateTime ConvertArrayToDate(int[] data)
        {
            var date = new DateTime(data[0], data[1], data[2]);
            return date;
        }

        /// <summary>
        /// Convert date time to an int array
        /// </summary>
        /// <param name="data"></param>
        /// <returns>int array for date structured {year, month, day}</returns>
        public static int[] ConvertDateTimeToArray(DateTime data)
        {
            var intArray = new[]
            {
                data.Year,
                data.Month,
                data.Day
            };
            return intArray;
        }

        /// <summary>
        /// Convert UTC (seconds since 12:00 01-01-1601) to a DateTime. Converting to local time helps
        /// prvent issue where converting to UTC then back provides a different time due to time z
        /// </summary>
        /// <param name="data">UTC time formatted as a long</param>
        /// <param name="convertToLocalTime">Convert the UTC time to the local timezone</param>
        /// <returns>DateTime structured {year, month, day}</returns>
        public static DateTime ConvertDateFromUTC(long data, bool convertToLocalTime = true)
        {
            var newDate = DateTime.FromFileTimeUtc(data);
            if (convertToLocalTime)
            {
                newDate = newDate.ToLocalTime();
            }

            // return DateTime.FromFileTimeUtc(data);
            return newDate;
        }

        /// <summary>
        /// Convert a DateTime to a long - UTC (seconds since 12:00 01-01-1601)
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Long - UTC</returns>
        public static long ConvertDateToUTC(DateTime data)
        {
            return data.ToFileTimeUtc();
        }
    }
}