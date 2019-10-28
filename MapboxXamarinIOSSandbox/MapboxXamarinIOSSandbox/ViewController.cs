using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime;
using AddressBook;
using CoreLocation;
using Foundation;
using Mapbox;
using UIKit;

namespace MapboxXamarinIOSSandbox
{
    public partial class ViewController : UIViewController, IMGLMapViewDelegate
    {
        private bool centerCoordinateNeeded;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public T GetValueFromExpression<T>(NSExpression expr) where T : NSObject
        {
            if (expr == null) return default(T);
            switch (expr.ExpressionType)
            {
                case NSExpressionType.ConstantValue:
                    return expr.ConstantValue as T;
                case NSExpressionType.NSAggregate:
                    if (expr.Collection is T)
                        return expr.Collection as T;
                    if (expr.Collection is NSArray array
                        && array.Count != 0)
                    {
                        var first = array.GetItem<T>(0);
                        if (first is NSExpression innerExpr)
                        {
                            return GetValueFromExpression<T>(innerExpr);
                        }
                        return first;
                    }
                    return default(T);
                case NSExpressionType.Function:
                    //TODO
                    var function = expr.Function; //"mgl_interpolate:withCurveType:parameters:stops:"
                    if (expr.Arguments is NSExpression[] args)// $zoomLevel, exponential, 1.299999, {{ 13 = "0.5", 20 = 2;}}
                    {
                        //TODO
                    }
                    return default(T);
                default:
                    return default(T);
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            /*Dictionary<string, CLLocationCoordinate2D> boundsDict = FindBounds(lat1, lng1, lat2, lng2);*/

            var lat1 = 21.353550;
            var lng1 = -157.842061;
            var lat2 = 35.832595;
            var lng2 = 139.535024;
            var pickupPoint = new CLLocationCoordinate2D(lat1, lng1);
            var deliveryPoint = new CLLocationCoordinate2D(lat2, lng2);

            var initialBounds = new MGLCoordinateBounds()
            {
                sw = pickupPoint,
                ne = deliveryPoint
            };

            var mapView = new MGLMapView(frame: View.Bounds)
            {
                //This can be cleaned up at the end
/*                ZoomLevel = 6,
                CenterCoordinate = new CLLocationCoordinate2D(28.903782, -36.516551),
                VisibleCoordinateBounds = initialBounds,
                Direction = 0*/

            };

            bool crossesMeridianOrDateline;

            if ((lng1 > 0.0 && lng2 < 0.0) || (lng1 < 0.0 && lng2 > 0.0))
            {
                crossesMeridianOrDateline = true;
            }
            else
            {
                crossesMeridianOrDateline = false;
            }

            var xDiffPrimeMeridianZero = FindXDiffPrimeMeridianZero(lng1, lng2);
            var xDiffDatelineZero = FindXDiffDatelineZero(lng1, lng2);

            List<double> xList;
            List<double> lngList;

            if ((Math.Abs(xDiffDatelineZero) > Math.Abs(xDiffPrimeMeridianZero)) && crossesMeridianOrDateline == true)
            {
                var latCenter = (lat1 + lat2) / 2.0;

                // Find center coordinate here
                var x1 = FindXPrimeMeridianZero(lng1);
                var xCenter = x1 + (xDiffPrimeMeridianZero / 2.0);
                double lngCenter;

                if (x1 > 180.0)
                {
                    lngCenter = xCenter - 360.0;
                }
                else
                {
                    lngCenter = xCenter;
                }

                mapView.SetCenterCoordinate(new CLLocationCoordinate2D(latCenter, lngCenter), false);
                mapView.SetZoomLevel(1.5, false);

                xList = CreateXList(xDiffPrimeMeridianZero, x1);
                lngList = ConvertToLngsPrimeMeridianZero(xList);
            }
            else
            {
                // find max/min lat/lng here
                // use those to determine the initialBounds

                var latDict = FindLowHigh(lat1, lat2);
                var latHigh = latDict["high"];
                var latLow = latDict["low"];
                var lngDict = FindLowHigh(lng1, lng2);
                var lngHigh = lngDict["high"];
                var lngLow = lngDict["low"];

                var latBuffer = (latHigh - latLow) / 10.0;
                var lngBuffer = (lngHigh - lngLow) / 10.0;

                var swLat = latLow - latBuffer;
                var swLng = lngLow - lngBuffer;
                var neLat = latHigh + latBuffer;
                var neLng = lngHigh + lngBuffer;

                var bounds = new MGLCoordinateBounds()
                {
                    sw = new CLLocationCoordinate2D(swLat, swLng),
                    ne = new CLLocationCoordinate2D(neLat, neLng)
                };

                mapView.SetVisibleCoordinateBounds(bounds, new UIEdgeInsets(top: 0.0f, left: 0.0f, bottom: 0.0f, right: 0.0f), false);

                xList = CreateXList(xDiffDatelineZero, FindXDatelineZero(lng1));
                lngList = ConvertToLngsDatelineZero(xList);
            }

            var yList = CreateYList(lat1, lat2);

            var latList = ConvertToLats(yList);
            var coords = ConvertToCoords(latList, lngList);


            this.View.AddSubview(mapView);
            mapView.WeakDelegate = this;

/*            mapView.SetCenterCoordinate(new CLLocationCoordinate2D(50.392381, -98.94189), 6, false);*/

            var pickupPointAnnotation = new MGLPointAnnotation()
            {
                Title = "Echo Chicago",
                Subtitle = "#1 3PL",
                Coordinate = pickupPoint
            };

            var deliveryPointAnnotation = new MGLPointAnnotation()
            {
                Title = "St. Louis",
                Subtitle = "Delivery Spot",
                Coordinate = deliveryPoint
            };

            mapView.AddAnnotation(pickupPointAnnotation);
            mapView.AddAnnotation(deliveryPointAnnotation);

            CreateDashedLine(coords, mapView);

            /*			var newLayer = new MGLSymbolStyleLayer(Guid.NewGuid().ToString(), new MGLSource("xxx"))
                        {
                            IconImageName = NSExpression.FromConstant(new NSString("temple")),
                            IconOpacity = NSExpression.FromConstant(NSNumber.FromDouble(0.7))
                        };
                        Debug.WriteLine(newLayer.IconImageName.ToString());*/
        }

        [Export("mapViewDidFinishLoadingMap:")]
        public void MapViewDidFinishLoadingMap(MGLMapView mapView)
        {



        }

        [Export("mapView:strokeColorForShapeAnnotation:")]
        public UIColor MapView_StrokeColorForShapeAnnotation(MGLMapView mapView, MGLShape annotation)
        {
            return UIColor.Gray;
        }

        [Export("mapView:lineWidthForPolylineAnnotation:")]
        public nfloat MapView_LineWidthForPolylineAnnotation(MGLMapView mapView, MGLPolyline annotation)
        {
            return 2.0f;
        }

        //private void ShowLayers(object sender, EventArgs e)
        //{
        //    if (mapView.Style == null) return;
        //    var styleId = mapView.StyleURL.LastPathComponent;
        //    var owner = mapView.StyleURL.RemoveLastPathComponent().LastPathComponent;
        //    var vc = new LayersListViewController(mapView.Style, owner, styleId);
        //    PresentViewController(vc, true, null);
        //}

        [Export("mapView:annotationCanShowCallout:")]
        public bool MapView_AnnotationCanShowCallout(MGLMapView mapView, IMGLAnnotation annotation)
        {
            return true;
        }

/*        [Export("mapView:imageForAnnotation:")]
        public MGLAnnotationImage MapView_ImageForAnnotation(MGLMapView mapView, IMGLAnnotation annotation)
        {
            var annotationImage = mapView.DequeueReusableAnnotationImageWithIdentifier("temple");
            if (annotationImage == null) {
                var image = UIImage.FromBundle("temple");
                image = image.ImageWithAlignmentRectInsets(new UIEdgeInsets(0, 0, image.Size.Height / 2, 0));
                annotationImage = MGLAnnotationImage.AnnotationImageWithImage(image, "temple");
            }
            return annotationImage;
        }*/

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private List<double> CreateXList(double xDiff, double x1)
        {

            var xList = new List<double>();
            xList.Add(x1);

            var xIncrement = xDiff / 31;

            var currentX = x1;

            for (var i = 0; i < 30; i++)
            {
                currentX += xIncrement;

                xList.Add(currentX);
            }

            return xList;
        }

        public double FindXDiffPrimeMeridianZero(double lng1, double lng2)
        {
            var x1 = FindXPrimeMeridianZero(lng1);
            var x2 = FindXPrimeMeridianZero(lng2);

            var xDiff = x2 - x1;

            return xDiff;
        }

        public double FindXPrimeMeridianZero(double lng)
        {
            double x;

            if (lng < 0.0)
            {
                x = 360.0 + lng;
            }
            else
            {
                x = lng;
            }

            return x;
        }

        public double FindXDiffDatelineZero(double lng1, double lng2)
        {
            var x1 = FindXDatelineZero(lng1);
            var x2 = FindXDatelineZero(lng2);

            var xDiff = x2 - x1;

            return xDiff;
        }

        public double FindXDatelineZero(double lng)
        {
            return 180.0 + lng;
        }

        private List<double> CreateYList(double lat1, double lat2)
        {
            var y1 = 90.0 + lat1;
            var y2 = 90.0 + lat2;

            var yDiff = y2 - y1;

            var yList = new List<double>();
            yList.Add(y1);

            var yIncrement = yDiff / 31;

            var currentY = y1;

            for (var i = 0; i < 30; i++)
            {
                currentY += yIncrement;

                yList.Add(currentY);
            }

            return yList;
        }

        private List<double> ConvertToLngsPrimeMeridianZero(List<double> xList)
        {
            var lngList = new List<double>();

            foreach (double x in xList)
            {
                if (x > 180)
                {
                    lngList.Add(x - 360.0);
                }
                else
                {
                    lngList.Add(x);
                }
            }

            return lngList;
        }

        private List<double> ConvertToLngsDatelineZero(List<double> xList)
        {
            var lngList = new List<double>();

            foreach (double x in xList)
            {
                lngList.Add(x - 180.0);
            }

            return lngList;
        }

        private List<double> ConvertToLats(List<double> yList)
        {
            var latList = new List<double>();

            foreach (double y in yList)
            {
                latList.Add(y - 90.0);
            }

            return latList;
        }

        private List<CLLocationCoordinate2D> ConvertToCoords(List<double> latList, List<double> lngList)
        {
            var coords = new List<CLLocationCoordinate2D>();

            if (latList.Count == lngList.Count)
            {
                for (var i = 0; i < latList.Count; i++)
                {
                    coords.Add(new CLLocationCoordinate2D(latList[i], lngList[i]));
                }
            }

            return coords;
        }

        private void CreateDashedLine(List<CLLocationCoordinate2D> points, MGLMapView mapView)
        {
            for (var i = 0; i < (points.Count - 1); i += 2)
            {
                var nextLine = new CLLocationCoordinate2D[2];
                nextLine[0] = points[i];
                nextLine[1] = points[i + 1];
                var polyline = MGLPolyline.PolylineWithCoordinates(ref nextLine[0], (nuint)nextLine.Length);
                mapView.AddAnnotation(polyline);
            }
        }

/*        private Dictionary<string, CLLocationCoordinate2D> FindBounds(double lat1, double lng1, double lat2,
            double lng2)
        {
            var lowHighLat = FindLowHigh(lat1, lat2);
            var lowHighLng = FindLowHigh(lng1, lng2);

            var lowLat = lowHighLat["low"];
            var highLat = lowHighLat["high"];
            var lowLng = lowHighLng["low"];
            var highLng = lowHighLng["high"];

        }*/

        private Dictionary<string, double> FindLowHigh(double num1, double num2)
        {
            double low;
            double high;

            if (num1 >= num2)
            {
                high = num1;
                low = num2;
            }
            else
            {
                high = num2;
                low = num1;
            }

            return new Dictionary<string, double>()
            {
                {"low", low },
                {"high", high }
            };
        }

    }
}
