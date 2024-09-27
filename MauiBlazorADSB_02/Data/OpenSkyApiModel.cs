using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiBlazorADSB_02.Data
{
    //https_//opensky-network.org/api/states/all?lamin=37.020&lomin=-109.080&lamax=40.980&lomax=-102.080
    internal class OpenSkyApiModel
    {
        [JsonPropertyName("time")]
        public int Time { get; set; }
        [JsonPropertyName("states")]
        //public object[][]? States { get; set; }
        public List<OpenSkyApiModelData> States { get; set; }
    }

    internal class OpenSkyApiModelData
    {
        /*
           * {
           "time" : 1727456063,
           "states":[
           [
           //icao24,callsign,origin_country,UTC_timeposition, UTC_timelastcontact, lng,     lat,   baro_alt,
           "a57b26","N452SM  ","United States", 1727456063,     1727456063,        -105.1646, 39.6394, 2651.76,

           //on_grd, velocity, true_trk,vert_rate, sensors, geo_alt, squawk, spi, position_src, category?
           false,27.7,   328.67,  -1.63,   null,  2819.4,null, false, 0
       ],[
       */
        [JsonPropertyName("icao24")]
        public string Icao24 { get; set; }
        [JsonPropertyName("callsign")]
        public string Callsign { get; set; }
        [JsonPropertyName("origin_country")]
        public string Origin_country { get; set; }
        [JsonPropertyName("utc_timeposition")]
        public string Utc_timeposition { get; set; }
        [JsonPropertyName("utc_timelastcontact")]
        public string Utc_timelastcontact { get; set; }
        [JsonPropertyName("lng")]
        public double Lng { get; set; }
        [JsonPropertyName("lat")]
        public double Lat { get; set; }
        [JsonPropertyName("baro_alt")]
        public double Baro_alt { get; set; }
        [JsonPropertyName("on_grd")]
        public string On_grd { get; set; }
        [JsonPropertyName("velocity")]
        public double Velocity { get; set; }
        [JsonPropertyName("heading")]
        public double Heading { get; set; }
        [JsonPropertyName("true_trk")]
        public string True_trk { get; set; }
        [JsonPropertyName("vert_rate")]
        public double Vert_rate { get; set; } //m/s
        [JsonPropertyName("sensors")]
        public string Sensors { get; set; }
        [JsonPropertyName("geo_alt")]
        public double Geo_alt { get; set; }
        [JsonPropertyName("squawk")]
        public string Squawk { get; set; }
        [JsonPropertyName("spi")]
        public bool Spi { get; set; }  //safety performance indicator
        [JsonPropertyName("position_src")]
        public int Position_src { get; set; }
        [JsonPropertyName("category")]
        public int Category { get; set; }


    }
}
