using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiBlazorADSB_02.Data
{
    internal class OpenSkyApiModel6
    {
        [JsonPropertyName("time")]
        public int Time { get; set; }
        [JsonPropertyName("states")]
        public List<Dictionary<string,string>> States { get; set; }

        public string[] stateslist = {
            "icao24", "callsign", "origin_country", "UTC_timeposition", "UTC_timelastcontact", 
            "lng", "lat", "baro_alt", "on_grd", "velocity true_trk", 
            "vert_rate", "sensors", "geo_alt", "squawk", "spi", 
            "position_src", "category" };
    }

}
