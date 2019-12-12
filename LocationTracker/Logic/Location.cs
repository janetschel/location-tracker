using System.Collections.Generic;
using System.Json;
using System.Linq;
using System;

namespace LocationTracker
{
    public class Location
    {
        private readonly string _timestamp;
        private readonly int _latitude;
        private readonly int _longitude;

        public double Latitude => _latitude / 1e7;
        public double Longitude => _longitude / 1e7;

        private Location(string json)
        {
            var jsonValue = JsonValue.Parse(json);

            if (!IsValidJson(jsonValue))
                throw new ArgumentException("Provided JSON is not valid");

            _timestamp = jsonValue["timestampMs"];
            _latitude = jsonValue["latitudeE7"];
            _longitude = jsonValue["longitudeE7"];
        }

        private static bool IsValidJson(JsonValue jsonValue) => 
            jsonValue.ContainsKey("timestampMs") && jsonValue.ContainsKey("latitudeE7") && 
            jsonValue.ContainsKey("longitudeE7");

        public static List<Location> GetObjectsFromJsonFile(string jsonFile)
        {
            var locations = new List<Location>();
            var input = System.IO.File.ReadAllText($@"..\..\Logic\{jsonFile}").Replace("\"locations\" : [ {", "");

            // substringing the input so I don't have to deal with the last ]} from the Json file
            var file = input.Substring(0, input.Length - 3).Split(new []{ ", " }, StringSplitOptions.None).ToList();
            
            file.ForEach(currentElement => locations.Add(new Location(currentElement)));
            return locations;
        }
    }
}