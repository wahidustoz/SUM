using System;
using JSONUtils;
using System.Collections.Generic;
using MvvmHelpers;
using Newtonsoft.Json;

namespace JSONUtils
{

    public class Timings
    {

        [JsonProperty("Fajr")]
        public string Fajr { get; set; }

        [JsonProperty("Sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("Dhuhr")]
        public string Dhuhr { get; set; }

        [JsonProperty("Asr")]
        public string Asr { get; set; }

        [JsonProperty("Sunset")]
        public string Sunset { get; set; }

        [JsonProperty("Maghrib")]
        public string Maghrib { get; set; }

        [JsonProperty("Isha")]
        public string Isha { get; set; }

        [JsonProperty("Imsak")]
        public string Imsak { get; set; }

        [JsonProperty("Midnight")]
        public string Midnight { get; set; }
    }

    public class Weekday
    {

        [JsonProperty("en")]
        public string En { get; set; }
    }

    public class Month
    {

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }
    }

    public class Designation
    {

        [JsonProperty("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonProperty("expanded")]
        public string Expanded { get; set; }
    }

    public class Gregorian
    {

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("weekday")]
        public Weekday Weekday { get; set; }

        [JsonProperty("month")]
        public Month Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("designation")]
        public Designation Designation { get; set; }
    }

    public class Hijri
    {

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("weekday")]
        public Weekday Weekday { get; set; }

        [JsonProperty("month")]
        public Month Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("designation")]
        public Designation Designation { get; set; }

        [JsonProperty("holidays")]
        public IList<string> Holidays { get; set; }

    }

    public class Date
    {

        [JsonProperty("readable")]
        public string Readable { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("gregorian")]
        public Gregorian Gregorian { get; set; }

        [JsonProperty("hijri")]
        public Hijri Hijri { get; set; }
    }

    public class Params
    {

        [JsonProperty("Fajr")]
        public int Fajr { get; set; }

        [JsonProperty("Isha")]
        public int Isha { get; set; }
    }

    public class Method
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }
    }

    public class Offset
    {

        [JsonProperty("Imsak")]
        public int Imsak { get; set; }

        [JsonProperty("Fajr")]
        public int Fajr { get; set; }

        [JsonProperty("Sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty("Dhuhr")]
        public int Dhuhr { get; set; }

        [JsonProperty("Asr")]
        public int Asr { get; set; }

        [JsonProperty("Maghrib")]
        public int Maghrib { get; set; }

        [JsonProperty("Sunset")]
        public int Sunset { get; set; }

        [JsonProperty("Isha")]
        public int Isha { get; set; }

        [JsonProperty("Midnight")]
        public int Midnight { get; set; }
    }

    public class Meta
    {

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }

        [JsonProperty("latitudeAdjustmentMethod")]
        public string LatitudeAdjustmentMethod { get; set; }

        [JsonProperty("midnightMode")]
        public string MidnightMode { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("offset")]
        public Offset Offset { get; set; }
    }

    public class Datum
    {

        [JsonProperty("timings")]
        public Timings Timings { get; set; }

        [JsonProperty("date")]
        public Date Date { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class Prayers
    {

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }

}