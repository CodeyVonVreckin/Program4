// Codey Von Vreckin
// Program 4
//CIS 199-01
// April 24, 2016
// form that calculates the cost of shipping a ground package by taking the origin/ destination zip codes, 
//length, width, height, and weight of the package entered by the user. Also recalculates the price of shipment
// when the origin/ destination of the package is being changed to U of L

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Prog4 : Form
    {
       private List<GroundPackage> packageList = new List<GroundPackage>(); //creates a new list object from the GroundPackage class

        public Prog4()
        {
            InitializeComponent();
        }
        //Preconditions:
        //              00000 <= origin Zip <= 99999
        //              00000 <= destination zip <= 99999
        //              length > 0
        //              width > 0
        //              height > 0
        //              weight > 0
        //Postconditions: takes entered info and calculates the cost of shipping
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            int originZip; // declares a int variable to hold the origin zip code
            int destinationZip;// declares a int variable to hold the destination zip code
            double length;// declares a double variable to hold the length of the package
            double width;// declares a double variable to hold the width of the package
            double height;// declares a double variable to hold the height of the package
            double weight;// declares a double variable to hold the weight of the package         
            const int MIN_ZIP = 00000;// declares a constant int variable to hold the minimum value the zip code could have
            const int MAX_ZIP = 99999;// declares a constant int variable to hold the maximum value the zip code could have
            const double INVALID_VALUE = 0;// declares a constant double variable to hold the the invalid value for the length,
                                           //width, height, and weight 


            if (originZipTxtBox.Text.Length > 5 || originZipTxtBox.Text.Length < 5) // test to see if there is a 5 digit number in the origin zip text box
            {
                MessageBox.Show("Please enter a 5 digit zip code"); //error message if length does not = 5
                originZipTxtBox.Focus();                    // highlights the textbox where there error message is coming from
                originZipTxtBox.SelectAll();
            }

            else// origin zip has 5 characters in its text box
            {
                if (destinationZipTxtBox.Text.Length > 5 || destinationZipTxtBox.Text.Length < 5)// test to see if there is a 5 digit number in the destination zip text box
                {
                    MessageBox.Show("Please enter a 5 digit zip code");//error message if length does not = 5
                    destinationZipTxtBox.Focus();                   // highlights the textbox where there error message is coming from
                    destinationZipTxtBox.SelectAll();
                }
                else// destination zip has 5 characters in its text box
                {
                    if (int.TryParse(originZipTxtBox.Text, out originZip) && originZip >= MIN_ZIP && originZip <= MAX_ZIP)// validing if the origin zip is an integer betweem 00000-99999
                    {
                        if (int.TryParse(destinationZipTxtBox.Text, out destinationZip) && destinationZip >= MIN_ZIP && destinationZip <= MAX_ZIP)// validing if the destination zip is an integer betweem 00000-99999
                        {
                            if (double.TryParse(lengthTxtBox.Text, out length) && length > INVALID_VALUE)// validating if the length is > 0
                            {
                                if (double.TryParse(widthTxtBox.Text, out width) && width > INVALID_VALUE)// validating if the width is > 0
                                {
                                    if (double.TryParse(heightTxtBox.Text, out height) && height > INVALID_VALUE)// validating if the height is > 0
                                    {
                                        if (double.TryParse(weightTxtBox.Text, out weight) && weight > INVALID_VALUE)// validating if the weight is > 0
                                        {

                                            GroundPackage myGroundPackage = new GroundPackage(originZip, destinationZip, length, width, height, weight); // adds a new GroundPackage Object

                                            myGroundPackage.OriginZip = originZip; // sets the new value of the origin Zip to the one entered by the user
                                            myGroundPackage.DestinationZip = destinationZip;// sets the new value of the destination Zip to the one entered by the user
                                            myGroundPackage.Length = length;// sets the new value of the length to the one entered by the user
                                            myGroundPackage.Width = width;// sets the new value of the width to the one entered by the user
                                            myGroundPackage.Height = height;// sets the new value of the height to the one entered by the user
                                            myGroundPackage.Weight = weight;// sets the new value of the weight to the one entered by the user

                                            myGroundPackage.CalcCost(); // takes entered info and calculates cost of shipping
                                            packageList.Add(myGroundPackage);// adds the groundpackage object into the list
                                            groundPackageListBox.Items.Add(myGroundPackage.CalcCost().ToString("C"));// displays the price of shipment into the list box

                                            originZipTxtBox.Clear();// clears the origin zip code text box
                                            destinationZipTxtBox.Clear();// clears the destination zip code text box                   
                                            lengthTxtBox.Clear();// clears the length text box                                
                                            widthTxtBox.Clear(); // clears the width text box                             
                                            heightTxtBox.Clear();// clears the height text box
                                            weightTxtBox.Clear();// clears the weight text box

                                        }
                                        else// weight had invalid entry
                                        {
                                            MessageBox.Show("Please enter a valid weight (number > 0)");
                                            weightTxtBox.Focus();            // highlights the textbox where there error message is coming from 
                                            weightTxtBox.SelectAll();
                                        }
                                    }
                                    else// height had invalid entry
                                    {
                                        MessageBox.Show(" Please enter a valid height in inches (number > 0)");
                                        heightTxtBox.Focus();               // highlights the textbox where there error message is coming from
                                        heightTxtBox.SelectAll();
                                    }
                                }
                                else// width had invalid entry
                                {
                                    MessageBox.Show("Please enter a valid width in inches (number > 0)");
                                    widthTxtBox.Focus();                    // highlights the textbox where there error message is coming from
                                    widthTxtBox.SelectAll();
                                }
                            }
                            else// length had invalid entry
                            {
                                MessageBox.Show("Please enter a valid length in inches ( number > 0)");
                                lengthTxtBox.Focus();                       // highlights the textbox where there error message is coming from
                                lengthTxtBox.SelectAll();

                            }
                        }
                        else// origin zip code had invalid entry
                        {
                            MessageBox.Show("Please enter a valid, non negative 5 digit zip code");
                            originZipTxtBox.Focus();                       // highlights the textbox where there error message is coming from
                            originZipTxtBox.SelectAll();
                            
                        }

                    }
                    else// destination zip code had invalid entry
                    {
                        MessageBox.Show("Please enter a valid, non negative 5 digit zip code");
                        destinationZipTxtBox.Focus();                      // highlights the textbox where there error message is coming from
                        destinationZipTxtBox.SelectAll();
                    }

                }
            }
        
        }
        //Precondition: there must be an item in the list box
        //              the item must be selected 
        //Postcondition: displays a messagebox that shows the package details (ones entered previously by the user)
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index = groundPackageListBox.SelectedIndex;// declares an int variable to hold the selected index for the listbox
            if (index <0)            //test to see if anything has been selected
                MessageBox.Show("Please select an item from the List Box"); // nothing was selected
            else //something was selected
                MessageBox.Show(packageList[index].ToString()); // displays a messagebox that shows the package details (ones entered previously by the user)

        }
        //Precondition: there must be an item in the list box
        //              the item must be selected
        //Postcondtion: updates the Destination zip code and displays new price of shipment 
        private void sendToButton_Click(object sender, EventArgs e)
        {
            int index = groundPackageListBox.SelectedIndex;// declares an int variable to hold the selected index for the listbox
            if (index < 0)                  //test to see if anything has been selected
                MessageBox.Show("Please select an item from the List Box"); // nothing was selected
            else//something was selected
            {
                
                packageList[index].DestinationZip = 40292; // changes the destination zip code to 40292
                groundPackageListBox.Items[index] = packageList[index].CalcCost().ToString("C"); // uses new zip code to calculate a new price of shipment 
                                                                                                 //and displays the new price in the same location as the previous one                                                                                                
                MessageBox.Show("The package's Destination Zip Code has been updated. Zip code changed to 40292"); // displays once the zip code has been updated in the details                   
               
            }
        }
        //Precondition: there must be an item in the list box
        //              the item must be selected
        //Postcondtion: updates the Origin zip code and displays new price of shipment 
        private void sendFromButton_Click(object sender, EventArgs e)
        {
             int index = groundPackageListBox.SelectedIndex;// declares an int variable to hold the selected index for the listbox
             if (index < 0)                  //test to see if anything has been selected
                 MessageBox.Show("Please select an item from the List Box"); // nothing was selected
             else//something was selected
             {

                 packageList[index].OriginZip = 40292;// changes the origin zip code to 40292
                 groundPackageListBox.Items[index] = packageList[index].CalcCost().ToString("C");// uses new zip code to calculate a new price of shipment 
                                                                                                 //and displays the new price in the same location as the previous one 

                 MessageBox.Show("The package's Origin Zip Code has been updated. Zip code changed to 40292"); // displays once the zip code has been updated in the details
             }
        }
      
    }
}
