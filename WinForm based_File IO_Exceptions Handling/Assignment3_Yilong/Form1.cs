using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment3_Yilong
{
    public partial class FormFiles : Form
    {
        public FormFiles()
        {
            InitializeComponent();
        }

        string fileName = "";
        string fileMode = "";

        StreamWriter sw = null;
        StreamReader sr = null;

        string transact = "";
        string datestring = "";
        string toolPurchase = "";
        string serialNumber = "";
        double price = 0;
        int qty = 0;
        double amount = 0;

        //Start: Create a new file or open a existing file
        private void buttonCreateOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxFilename.Text == "" && radioButtonNewName.Checked)
                {
                    throw new Exception();
                }
                if (radioButtonNewName.Checked)
                {
                    fileName = textBoxFilename.Text;
                    fileMode = "Write";
                }
                else if (radioButtonOpenExisting.Checked)
                {
                    DialogResult result = openFileDialog1.ShowDialog();
                    fileName = openFileDialog1.FileName;
                    textBoxFilename.Text = fileName;
                }
                if (!File.Exists(fileName)) //check if no same name exists
                {
                    labelMessageDisplay.Text = fileName + "file created";
                }
                else  //stream is opened.
                {
                    labelMessageDisplay.Text = fileName + "file opened for appending"; 
                }
            }
            catch(Exception)
            {
                labelMessageDisplay.Text = "The file name is required.";
            }
        }
        //End: Create a new file or open a existing file

        //Start: Write in records inoto a file   
            //method to calculate amount automatically
        private void textBoxAmount_Click(object sender, EventArgs e) 
        {
            price = Convert.ToDouble(textBoxPrice.Text);
            qty = Convert.ToInt16(textBoxQuantity.Text);
            amount = price * qty;
            textBoxAmount.Text = amount.ToString();
        }

        private void buttonWriteRecord_Click(object sender, EventArgs e)
        {
            fileMode = "Write";

            transact = textBoxTransact1.Text.ToString();
            datestring = textBoxDate.Text.ToString();
            serialNumber = textBoxSerialNumber.Text.ToString();
            toolPurchase = textBoxTool.Text.ToString();

            string textString = "";

            if (transact != "" && datestring != "" && toolPurchase != "" && serialNumber != "" &&
                textBoxPrice.Text != "" && textBoxQuantity.Text != "" && textBoxAmount.Text != "")
            {
                price = Convert.ToDouble(textBoxPrice.Text);
                qty = Convert.ToInt16(textBoxQuantity.Text);
                amount = Convert.ToDouble(textBoxAmount.Text);

                textString = transact + "," + datestring + "," + serialNumber + "," + toolPurchase + ","
                    + price.ToString() + "," + qty.ToString() + "," + amount.ToString();  //textString is what displayed in the txt file

                using (sw = File.AppendText(fileName))
                {
                    sw.WriteLine(textString); //not one line: sw.Write(textString); WriteLine always with sw not sr
                }
                labelMessageDisplay.Text = "1 record written.";

                textBoxTransact1.Text = "";
                textBoxDate.Text = "";
                textBoxTool.Text = "";
                textBoxSerialNumber.Text = "";
                textBoxPrice.Text = "";
                textBoxQuantity.Text = "";
                textBoxAmount.Text = "";
            }
            else
            {
                labelMessageDisplay.Text = "Fields not complete.";
            }
        }
        //End: Write in records inoto a file

        //Start: Read and Display records of a file
        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            fileMode = "Read";
            textBoxFilename.Text = fileName;
            labelDataDisplay.Text = "";

            int itemsDisplayed = 0;
            decimal amount = 0;
            string textString = "";
            string[] sArr;

            string fLine = "#          Purchase-Date          Serial #          Manufacturing Tools             Price       Qty          Amount" + Environment.NewLine;
            fLine += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

            if (fileMode == "Write")
            {
                sw.Close();
            }
            if (!File.Exists(fileName))
            {
                labelMessageDisplay.Text = "Please open the file you want to display.";
            }
            else
            {
                try
                {
                    using (sr = File.OpenText(fileName))
                    {
                        while (!sr.EndOfStream)
                        {
                            textString = sr.ReadLine();
                            if (textString != "")
                            {
                                sArr = textString.Split(',');

                                //to fill up all the right space: must set font to fixed-pitch font like Consolas
                                sArr[0] = sArr[0].PadRight(4, ' '); //transact#
                                sArr[1] = sArr[1].PadRight(13, ' '); //date
                                sArr[2] = sArr[2].PadRight(5, ' '); //serial#
                                sArr[3] = sArr[3].PadRight(20, ' '); //tool
                                sArr[4] = sArr[4].PadRight(4, ' '); //price
                                sArr[5] = sArr[5].PadRight(5, ' '); //qty

                                amount = Convert.ToDecimal(sArr[6]);

                                fLine += String.Format("{0, -4}", sArr[0]);
                                fLine += "       " + String.Format("{0, -13}", sArr[1]);
                                fLine += "          " + String.Format("{0, -5}", sArr[2]);
                                fLine += "             " + String.Format("{0, -20}", sArr[3]);
                                fLine += "            $" + String.Format("{0, -4}", sArr[4]);
                                fLine += "       " + String.Format("{0, -5}", sArr[5]);
                                fLine += "        " + String.Format("{0:c}", amount);

                                fLine += Environment.NewLine; //very important: let line down when all lines displayed; for formatting start new line
                                itemsDisplayed++;
                            }
                        }
                        fLine += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
                        labelDataDisplay.Text = fLine;
                        labelMessageDisplay.Text = " Items displayed " + itemsDisplayed;
                    }
                }
                catch(Exception ex)
                {
                    labelMessageDisplay.Text = $"Cannot fint the file: {ex.Message}";
                }
            }
        }
        //End: Display records of a file

        //Start: Delete a line(record) of a file
        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            string lineDelete = ""; //the line we want to delete
            string transactDelete = textBoxTransact2.Text;
            fileName = textBoxFilename.Text;

            if(textBoxTransact2.Text == "")
            {
                labelMessageDisplay.Text = "Please enter the transact# you want to delete.";
            }
            else
            {
                List<string> list = new List<string>(); //a list to contain all lines of a file
                try
                {
                    using (sr = File.OpenText(fileName))
                    {
                        string lineContent;
                        while ((lineContent = sr.ReadLine()) != null)
                        {
                            list.Add(lineContent);
                        }
                        textBoxTransact2.Text = "";
                    }
                    foreach (string lines in list) //for-loop to find the line that contains the transact number
                    {
                        if (lines.StartsWith(transactDelete))
                        {
                            lineDelete = lines;

                            File.Delete(fileName); //detele original file, then create new one with same-name by codes below

                            int lineNumber = list.IndexOf(lineDelete); //the index of the line we want to delete
                            list.RemoveAt(lineNumber);

                            using (sw = File.AppendText(fileName)) //create the new file after deleting record
                            {
                                foreach (string line in list)
                                {
                                    sw.WriteLine(line);
                                }
                            }

                            labelMessageDisplay.Text = "Record delete success.";
                            fileMode = "Write";
                            break;
                        }
                        else
                        {
                            labelMessageDisplay.Text = "The entered transact# is not esisted.";
                        }
                    }
                }
                catch(Exception ex)
                {
                    labelMessageDisplay.Text = $"Cannot fint the file: {ex.Message}";
                }
            }  
        }
        //End: Delete a line(record) of a file

        //Start: Close streams of a file
        private void buttonCloseFile_Click(object sender, EventArgs e)
        {
            if (fileMode == "Read" && textBoxFilename.Text != "")
            {
                sr.Close();
                labelDataDisplay.Text = "";
                labelMessageDisplay.Text = fileName + " file now closed";
            }
            else if (fileMode == "Write" && textBoxFilename.Text != "")
            {
                sw.Close();
                labelMessageDisplay.Text = fileName + " file now closed";
            }
            else
            {
                labelMessageDisplay.Text = "No file stream is found.";
            }
        }
        //End: Close streams of a file

        //Start: Delete a whole file
        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            fileName = textBoxFilename.Text;
            if(fileName == "")
            {
                labelMessageDisplay.Text = "Please open the file you want to delete.";
            }
            if(!File.Exists(fileName))
            {
                labelMessageDisplay.Text = "The file does not exist.";
            }
            else
            {
                File.Delete(fileName);
                textBoxFilename.Text = "";
                labelMessageDisplay.Text = "File delete success.";
            }
        }
        //End: Delete a whole file
    }
}
