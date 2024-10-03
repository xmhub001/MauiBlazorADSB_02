using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorADSB_02.Data
{
    internal class OpenSkyApiModel7
    {
        public int time { get; set; }
        public OpenSkyApiModelData7[] states { get; set; }
    }

    internal class OpenSkyApiModelData7
    {

        public OpenSkyApiModelList7[] list { get; set; }

    }

    internal class OpenSkyApiModelList7
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
        [DataMember]
        public string Icao24 { get; set; }
        [DataMember]
        public string Callsign { get; set; }
        [DataMember]
        public string Origin_country { get; set; }
        [DataMember]
        public int Utc_timeposition { get; set; }
        [DataMember]
        public int Utc_timelastcontact { get; set; }
        [DataMember]
        public double Lng { get; set; }
        [DataMember]
        public double Lat { get; set; }
        [DataMember]
        public double Baro_alt { get; set; }
        [DataMember]
        public bool On_grd { get; set; }
        [DataMember]
        public double Velocity { get; set; }
        //[DataMember]
        //public double Heading { get; set; }
        [DataMember]
        public double True_trk { get; set; }
        [DataMember]
        public double Vert_rate { get; set; } //m/s
        [DataMember]
        public string Sensors { get; set; }
        [DataMember]
        public double Geo_alt { get; set; }
        [DataMember]
        public string Squawk { get; set; }
        [DataMember]
        public bool Spi { get; set; }  //safety performance indicator
        [DataMember]
        public int Position_src { get; set; }
        //[DataMember]
        //public int Category { get; set; }
    }

}
