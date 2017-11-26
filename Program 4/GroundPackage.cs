using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class GroundPackage
    {// backing fields
        private int _originZip;         //00000-99999
        private int _destinationZip;    //00000-99999
        private double _length;         // > 0
        private double _width;          // > 0
        private double _height;         // > 0
        private double _weight;         // > 0
        private const int MIN_ZIP = 00000;      // const variable to hold the Min Zip value 
        private const int MAX_ZIP = 99999;      //const variable to hold the Max Zip value
        private const int INVALID_ZIP = 0;      //const variable to hold the invalid Zip value
        private const double INVALID_VALUE = 0;   //  const variable to hold the invalid value for the double variables

        //Precondition:
        //      00000<= origin <= 99999
        //      00000<= destination <= 99999
        //      length > 0
        //      width  > 0
        //      height > 0
        //      weight > 0  
        //Postcondition: the GroundPackage object is initilized with specified origin/ destination zip
        //              length, width, height, weight, a Min and Max zip value, and Invalid Values for 
        //              both the int and double variables

        public GroundPackage(int oZ = 0, int dZ = 0, double l = 0, double w = 0, double h = 0, double p = 0)// constuctor with origin/ destination zip
        //              length, width, height, weight as its arugments
        {
            OriginZip = oZ;// sets the OriginZip Property
            DestinationZip = dZ;// sets the DestinationZip Property
            Length = l;// sets the Length Property
            Width = w;// sets the Width Property
            Height = h;// sets the Height Property
            Weight = p;// sets the Weight Property            
        }
        public int OriginZip// declares a Origin Zip Property
        {
            //Precondition: None
            //Postcondition: returns origin Zip
            get { return _originZip; }
            //Precondition: 00000<= value <= 99999
            //Postcondition: the origin zip is set to the specified value
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP) // test for validity
                    _originZip = value;
                else// invalid set to 0
                    _originZip = INVALID_ZIP;
            }          

        }
        public int DestinationZip// declares a Destination Zip Property
        {
            //Precondition:None
            //Postcondition:returns destination Zip
            get { return _destinationZip; }
            //Precondition: 00000<= value <= 99999
            //Postcondition:the origin zip is set to the specified value
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)// test for validity
                    _destinationZip = value;
                else// invalid set to 0
                    _destinationZip = INVALID_ZIP;
            }
        }
        public int ZoneDistance// declares a Zone Distance Property that is Read-Only
        {
            //Precondition:  00000<= origin <= 99999
            //             & 00000<= destination <= 99999
            //Postcondition: returns the difference between the first number in both zip codes
            get { return Math.Abs(_originZip / 10000 - _destinationZip / 10000); }   
                                                                   
        }
        public double Length// declares a Length Property
        {
            //Precondition:None
            //Postcondition:returns length
            get { return _length; }
            //Precondition: value > 0
            //Postcondition:the length is set to the specified value
            set
            {
                if (value > INVALID_VALUE)// test for validity
                    _length = value;
                else// invalid set to 0
                    _length = INVALID_VALUE;
            }

        }
        public double Width// declares a Width Property
        {
            //Precondition:None
            //Postcondition:returns width
            get { return _width; }
            //Precondition: value > 0
            //Postcondition:the width is set to the specified value
            set
            {
                if (value > INVALID_VALUE)// test for validity
                    _width = value;
                else// invalid set to 0
                    _width = INVALID_VALUE;
            }

        }
        public double Height// declares a Height Property
        {
            //Precondition:None
            //Postcondition:returns height
            get { return _height; }
            //Precondition: value > 0
            //Postcondition:the height is set to the specified value
            set
            {
                if (value > INVALID_VALUE)// test for validity
                    _height = value;
                else// invalid set to 0
                    _height = INVALID_VALUE;
            }

        }
        public double Weight// declares a Weight Property
        {
            //Precondition: None
            //Postcondition:returns weight
            get { return _weight; }
            //Precondition: value > 0
            //Postcondition:the weight is set to the specified value
            set
            {
                if (value > INVALID_VALUE)// test for validity
                    _weight = value;
                else// invalid set to 0
                    _weight = INVALID_VALUE;
            }
        }
        public double CalcCost() // declares a CalcCost method 
        {
            double cost;// declares a double variable to hold cost
            return cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight); // calculates the cost of shipment
        }
        //Precondition: None
        //Postcondition: a string is returned in a new format
        public override string ToString()
        {                                                                                                       //  Changes the previous ToString format to:
            return "Origin Zip Code: " + OriginZip.ToString("D5") + System.Environment.NewLine +                //
                "Destination Zip Code: " + DestinationZip.ToString("D5") + System.Environment.NewLine +         // Origin Zip Code: #####
                "Length (inches): " + Length.ToString() + System.Environment.NewLine +                          // Destination Zip Code: #####
                "Width (inches): " + Width.ToString() + System.Environment.NewLine +                            // Length (inches): ###
                "Height (inches): " + Height.ToString() + System.Environment.NewLine +                          // Width (inches): ###
                "Weight (pounds): " + Weight.ToString();                                                        // Height (inches): ###
                                                                                                                // Weight (pounds): ###
       
        }
    }





}
