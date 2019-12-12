using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace LocationTracker
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            var locations = LocationTracker.Location.GetObjectsFromJsonFile("data.json");
            var polygons = new GMapOverlay("polygons");
            var averageLatitude = 0.0;
            var averageLongitude = 0.0;

            mapToDisplay.MapProvider = GMapProviders.GoogleMap;
            mapToDisplay.DragButton = MouseButtons.Left;
            mapToDisplay.ShowCenter = false;
            mapToDisplay.MaxZoom = 100;
            mapToDisplay.MinZoom = 5;
            
            locations.ForEach(location =>
            {
                var points = new List<PointLatLng>
                {
                    new PointLatLng(location.Latitude, location.Longitude),
                    new PointLatLng(location.Latitude + 1e-2, location.Longitude),
                    new PointLatLng(location.Latitude + 1e-2, location.Longitude - 1e-2),
                    new PointLatLng(location.Latitude, location.Longitude - 1e-2)
                };

                averageLatitude += location.Latitude;
                averageLongitude += location.Longitude;

                polygons.Polygons.Add(
                    new GMapPolygon(points, "")
                    {
                        Fill = new SolidBrush(Color.FromArgb(10, Color.PaleVioletRed)),
                        Stroke = new Pen(Color.PaleVioletRed, 1)
                    }
                );
            });

            var lat = averageLatitude / locations.Count;
            var lon = averageLongitude/ locations.Count;
            mapToDisplay.Position = new PointLatLng(lat, lon);

            mapToDisplay.Overlays.Add(polygons);

            mapToDisplay.Zoom = 8; // setting it here will lead to the points being drawn immediately
        }

        private void Form1_Closed(object sender, EventArgs e) => Close();
    }
}
