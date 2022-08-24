using System;
using System.Collections.Generic;
using System.Windows;

namespace Line2DChart {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        List<DataPoint> dataPoints;
        public List<DataPoint> DataPoints {
            get {
                if (dataPoints == null) {
                    dataPoints = new List<DataPoint> {
                            new DataPoint (new DateTime(2021, 1, 1), 7.2),
                            new DataPoint (new DateTime(2021, 2, 1), 8.3),
                            new DataPoint (new DateTime(2021, 3, 1), 12.2),
                            new DataPoint (new DateTime(2021, 4, 1), 15.6),
                            new DataPoint (new DateTime(2021, 5, 1), 19.6),
                            new DataPoint (new DateTime(2021, 6, 1), 22.7),
                            new DataPoint (new DateTime(2021, 7, 1), 25.2),
                            new DataPoint (new DateTime(2021, 8, 1), 25),
                            new DataPoint (new DateTime(2021, 9, 1), 21.1),
                            new DataPoint (new DateTime(2021, 10, 1), 16.3),
                            new DataPoint (new DateTime(2021, 11, 1), 10.8),
                            new DataPoint (new DateTime(2021, 12, 1), 7.5)
                };
                }
                return dataPoints;
            }
        }
    }
    public class DataPoint {
        public DateTime Time { get; set; }
        public double Value { get; set; }
        public DataPoint(DateTime time, double value) {
            this.Time = time;
            this.Value = value;
        }
    }
}
