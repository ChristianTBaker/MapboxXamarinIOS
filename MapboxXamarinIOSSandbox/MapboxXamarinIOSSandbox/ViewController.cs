using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using CoreLocation;
using Foundation;
using Mapbox;
using UIKit;

namespace MapboxXamarinIOSSandbox
{
    public partial class ViewController : UIViewController, IMGLMapViewDelegate
    {
        private double lat1;
        private double lat2;
        private double lng1;
        private double lng2;
        private CLLocationCoordinate2D pickupPoint;
        private CLLocationCoordinate2D deliveryPoint;
        private MGLMapView mapView;

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
            lat1 = 41.897627;
            lng1 = -87.643526;
            lat2 = 38.742291;
            lng2 = -90.064928;
            pickupPoint = new CLLocationCoordinate2D(lat1, lng1);
            deliveryPoint = new CLLocationCoordinate2D(lat2, lng2);

            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var initialBounds = new MGLCoordinateBounds()
            {
                sw = deliveryPoint,
                ne = pickupPoint
            };

            mapView = new MGLMapView(frame: View.Bounds)
            {
                ZoomLevel = 6,
                VisibleCoordinateBounds = initialBounds,
                Direction = 0

            };
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
            var plotList = CreatePlotList();
            var yList = plotList[0];
            var xList = plotList[1];
            var latList = ConvertToLats(yList);
            var lngList = ConvertToLngs(xList);
            var points = ConvertToPoints(latList, lngList);
            CreateDashedLine(points);

/*            var coordinates = new CLLocationCoordinate2D[] {
                new CLLocationCoordinate2D(latitude:lat1, longitude: lng1),
                new CLLocationCoordinate2D(latitude: lat2, longitude: lng2)
            };

            var coordinates = points;
            var polyline = MGLPolyline.PolylineWithCoordinates(ref coordinates[0], (nuint)coordinates.Length);
            mapView.AddAnnotation(polyline);*/

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

        private List<List<double>> CreatePlotList()
        {
            double x1;
            double x2;

            var y1 = 90.0 + lat1;
            var y2 = 90.0 + lat2;

            if (lng1 < 0)
            {
                x1 = 360.0 + lng1;
            }
            else
            {
                x1 = lng1;
            }

            if (lng2 < 0)
            {
                x2 = 360.0 + lng2;
            }
            else
            {
                x2 = lng2;
            }

            var yList = new List<double>();
            yList.Add(y1);
            var xList = new List<double>();
            xList.Add(x1);

            var yDiff = y2 - y1;
            var xDiff = x2 - x1;

            var yIncrement = yDiff / 31;
            var xIncrement = xDiff / 31;

            var currentY = y1;
            var currentX = x1;

            for (var i = 0; i < 30; i++)
            {
                currentY += yIncrement;
                currentX += xIncrement;

                yList.Add(currentY);
                xList.Add(currentX);
            }

            return new List<List<double>>() { yList, xList };
        }

        private List<double> ConvertToLngs(List<double> xList)
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

        private List<double> ConvertToLats(List<double> yList)
        {
            var latList = new List<double>();

            foreach (double y in yList)
            {
                latList.Add(y - 90.0);
            }

            return latList;
        }

        private List<CLLocationCoordinate2D> ConvertToPoints(List<double> latList, List<double> lngList)
        {
            var points = new List<CLLocationCoordinate2D>();

            if (latList.Count == lngList.Count)
            {
                for (var i = 0; i < latList.Count; i++)
                {
                    points.Add(new CLLocationCoordinate2D(latList[i], lngList[i]));
                }
            }

            return points;
        }

        private void CreateDashedLine(List<CLLocationCoordinate2D> points)
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

    }
}
