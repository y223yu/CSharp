using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YYMember
{
    public partial class YYMember : Form
    {
        Regex provincePattern = new Regex(@"^([A-Z]|[a-z]){2}$");                               //regex for province code
        Regex phonePattern = new Regex(@"^\d{3}-?\d{3}-?\d{4}$");                               //regex for phone number
        Regex postalPattern = new Regex(@"^[A-Z]\d[A-Z] ?\d[A-Z]\d$", RegexOptions.IgnoreCase); //regex for postal code
        Regex emailPattern = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        string errorPostal = "";
        string errorPhone = "";
        string errorIsNumeric = "";

        string outputStringCapitalize = "";
        string outputStringPostal = "";
        string outputStringPhone = "";
        string outputIsNumeric = "";

        public YYMember()
        {
            InitializeComponent();
        }

        //Start: capitalize firstname,lastname, street address and city
        public string Capitalize(string inputString) 
        {
            outputStringCapitalize = ""; //a must: avoid repeat output when click submit button many times
            inputString = inputString.Trim();

            int spaceIndex = inputString.IndexOf(" "); //find the position of space

            if (string.IsNullOrWhiteSpace(inputString)) //convert null string to empty, trigger error warning
            {
                return ""; 
            }
            if (inputString.Length == 1) //if only input 1 digit, empty textbox to trigger error warning
            {
                return "";
            }
            else
            {
                if (spaceIndex == -1) //no white space
                {
                    inputString = inputString.ToLower();
                    return char.ToUpper(inputString[0]) + inputString.Substring(1);
                }
                else //capitalize all words no matter how many words entered (has white space)
                {
                    string[] inputArr = inputString.Trim().Split(' ');

                    for (int i = 0; i < inputArr.Length; i++)
                    {
                        inputArr[i] = inputArr[i].Substring(0, 1).ToUpper() + inputArr[i].Substring(1).ToLower();
                    }
                   
                    for (int i = 0; i < inputArr.Length; i++)
                    {
                        outputStringCapitalize += inputArr[i] + " ";
                    }
                    return outputStringCapitalize;
                }
            }
        }
        //End: capitalize firstname, lastname, street address and city

        //Start: postal code validation
        public bool PostalCodeValidation(string inputStringPostal)
        {
            inputStringPostal = inputStringPostal.Trim();
            errorPostal = "";  //to make continue test possible
            if (!postalPattern.IsMatch(inputStringPostal))
            {
                errorPostal += "Please follow the format: A3A 3A3 or A3A3A3. \n";
            }
            if (string.IsNullOrEmpty(inputStringPostal))
            {
                outputStringPostal = "";  //a must: for change new postal code, avoid outputStringPostal still store previous input
                return true;
            }
            if (errorPostal == "")
            {   
                inputStringPostal = inputStringPostal.ToUpper();
                if (inputStringPostal.IndexOf(" ") == -1) //no space in postal code
                {
                    outputStringPostal = inputStringPostal.Trim().Insert(3, " ");
                }
                if (inputStringPostal.IndexOf(" ") == 3)
                {
                    outputStringPostal = inputStringPostal;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        //End: postal code validation

        //Start: phone number validation
        public bool PhoneNumberValidation(string inputStringPhone) 
        {
            inputStringPhone = inputStringPhone.Trim();
            errorPhone = "";  //to make continue test possible
            if (string.IsNullOrEmpty(inputStringPhone))
            {
                //errorPhone += "Required. \n";
                return true;
            }
            if (!phonePattern.IsMatch(inputStringPhone))
            {
                errorPhone += "Please follow the format: 123-123-1234 or 1231231234. \n";
            }
            if (errorPhone == "")
            {
                if (inputStringPhone.IndexOf("-") == -1) //has no dash in phone number
                {
                    outputStringPhone = inputStringPhone.Trim().Insert(3, "-").Insert(7, "-");
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        //End: phone number validation

        //Start: number validation (for Fee)
        public bool IsNumeric(string inputStringIsNumeric)
        {
            inputStringIsNumeric = inputStringIsNumeric.Trim();

            int dashIndex = inputStringIsNumeric.IndexOf("-");
            int firstDecimal = inputStringIsNumeric.IndexOf(".");

            errorIsNumeric = "";

            if (string.IsNullOrEmpty(inputStringIsNumeric))
            {
                errorIsNumeric += "Required. One digit at least, optional leading dash and decimal. \n";
            }
            if (dashIndex != -1) //has dash
            {
                if (dashIndex > 0) //not leading
                {
                    errorIsNumeric += "Please enter the dash on leading if need one. \n";
                }
            }
            if (firstDecimal != -1) //has decimal
            {
                if (firstDecimal != inputStringIsNumeric.LastIndexOf(".")) //more than 1 decimal
                {
                    errorIsNumeric += "Please only enter one decimal. \n";
                }
            }
            foreach (char item in inputStringIsNumeric) //has non-digit character
            {
                if (char.IsLetter(item)) 
                {
                    errorIsNumeric += "Please do not enter character other than dash, decimal and digit. \n";
                }
            }
            if (errorIsNumeric == "")
            {
                if (dashIndex == 0)
                {
                    inputStringIsNumeric = inputStringIsNumeric.Remove(0, 1);
                }

                double inputDouble = double.Parse(inputStringIsNumeric);
                inputStringIsNumeric = inputDouble.ToString("n"); //rounding the number to 2 decimal
                
                while (inputStringIsNumeric.IndexOf(",") != -1) //loop to remove all comma
                {
                    int commaIndex = inputStringIsNumeric.IndexOf(",");
                    inputStringIsNumeric = inputStringIsNumeric.Remove(commaIndex, 1);
                }
                outputIsNumeric = inputStringIsNumeric;
                return true;
            }
            else
            {
                return false;
            }
        }
        //End: number validation (for Fee)

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //Start: fee validation and reform
            if (IsNumeric(textBoxFee.Text) == false)
            {
                labelFee.Text = errorIsNumeric;
                textBoxFee.Focus();
            }
            if (IsNumeric(textBoxFee.Text) == true)
            {
                textBoxFee.Text = outputIsNumeric;
                labelFee.Text = "";
            }

            //Start: Email validation and reform
            textBoxEmail.Text = textBoxEmail.Text.Trim();
            if (!emailPattern.IsMatch(textBoxEmail.Text) && textBoxEmail.Text != "")
            {
                labelEmail.Text = "Please follow the format: xxx@xxxxx.xx.";
                textBoxEmail.Text = "";
            }
            else
            {
                textBoxEmail.Text = textBoxEmail.Text.ToLower();
                labelEmail.Text = "";
            }

            //Start: phone number validation and reform
            if (PhoneNumberValidation(textBoxPhone.Text) == false)
            {
                labelHomePhone.Text = errorPhone;
            }
            if (PhoneNumberValidation(textBoxPhone.Text) == true)
            {
                textBoxPhone.Text = outputStringPhone;
                labelHomePhone.Text = "";
            }

            //Start: postal code validation and reform
            if (PostalCodeValidation(textBoxPostal.Text) == false)
            {
                labelPostalCode.Text = errorPostal;
                textBoxPostal.Focus();
            }
            if (PostalCodeValidation(textBoxPostal.Text) == true)
            {
                textBoxPostal.Text = outputStringPostal;
                labelPostalCode.Text = "";
                if (textBoxEmail.Text.Length == 0 && textBoxPostal.Text == "")
                {
                    labelPostalCode.Text = "Required if no email provided.";
                    textBoxPostal.Focus();
                }
            }

            //Start: province code validation and reform
            textBoxProvince.Text = textBoxProvince.Text.Trim();
            if (!provincePattern.IsMatch(textBoxProvince.Text) && textBoxProvince.Text != "")
            {
                labelProvince.Text = "Please enter exactly two letters.";
                textBoxProvince.Text = "";
            }
            else
            {
                textBoxProvince.Text = textBoxProvince.Text.ToUpper();
                labelProvince.Text = "";
            }

            //Start: city validation and reform
            textBoxCity.Text = Capitalize(textBoxCity.Text);
            labelCity.Text = "";
            if (textBoxEmail.Text.Length == 0)
            {
                if (textBoxCity.Text == "")
                {
                    labelCity.Text = "Required if no email provided.";
                    textBoxCity.Focus();
                }
            }

            //Start: street address validation and reform
            textBoxStreet.Text = Capitalize(textBoxStreet.Text);
            labelStreetAddress.Text = "";
            if (textBoxEmail.Text.Length == 0)
            {
                if (textBoxStreet.Text == "")
                {
                    labelStreetAddress.Text = "Required if no email provided.";
                    textBoxStreet.Focus();
                }
            }

            //Start: spouse validation and reform
            textBoxSpouseFirst.Text = Capitalize(textBoxSpouseFirst.Text);
            textBoxSpouseLast.Text = Capitalize(textBoxSpouseLast.Text);

            //Start: last name validation and reform
            textBoxLastName.Text = Capitalize(textBoxLastName.Text);
            if (Capitalize(textBoxLastName.Text) == "")
            {
                labelLastName.Text = "Required. At least 2 letters.";
                textBoxLastName.Focus();
            }
            else if (Capitalize(textBoxLastName.Text) != "")
            {
                labelLastName.Text = "";
            }

            //Start: first name validation and reform        
            textBoxFirstName.Text = Capitalize(textBoxFirstName.Text);
            if (Capitalize(textBoxFirstName.Text) == "")
            {
                labelFirstName.Text = "Required. At least 2 letters.";
                textBoxFirstName.Focus();
            }
            else if (Capitalize(textBoxFirstName.Text) != "")
            {
                labelFirstName.Text = "";
            }

            //Start: derive full name and spouse's full name
            if (textBoxSpouseFirst.Text == "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "")
            {
                labelFullName.Text = textBoxLastName.Text + ", " + textBoxFirstName.Text;
            }
            else if (textBoxSpouseLast.Text == "" || textBoxSpouseLast.Text == textBoxLastName.Text)
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "")
                {
                    labelFullName.Text = textBoxLastName.Text + ", " + textBoxFirstName.Text + " && " + textBoxSpouseFirst.Text;
                }
            }
            else if (textBoxSpouseLast.Text != textBoxLastName.Text && textBoxSpouseFirst.Text != "")
            {
                labelFullName.Text = textBoxLastName.Text + ", " + textBoxFirstName.Text + " && " + textBoxSpouseLast.Text + ", " + textBoxSpouseFirst.Text;
            }
        }

        //Start: pre-fill button
        private void buttonPreFill_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "jon";
            textBoxLastName.Text = "snow";
            textBoxSpouseFirst.Text = "daenerys";
            textBoxSpouseLast.Text = "targaryen";
            textBoxStreet.Text = "100 unvertisy avenue east";
            textBoxCity.Text = "waterloo";
            textBoxProvince.Text = "on";
            textBoxPostal.Text = "n2t6a7";
            textBoxPhone.Text = "1234567890";
            textBoxEmail.Text = "jsnow@gmail.com";
            textBoxFee.Text = "17,000.005";
        }
        
        //Start: close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
