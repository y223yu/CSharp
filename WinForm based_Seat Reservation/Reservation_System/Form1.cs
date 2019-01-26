using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System
{
    public partial class Form1 : Form
    {
        string[,] name = new string[5, 3];  //for store customers' name

        List<string> waitingList = new List<string>(); //for store waitinglist dynamically 
        string[] waitingName;  //for output the waiting list

        Button[,] seatArrayButtons = new Button[5, 3]; //asign 15 seats to a 2D array

        bool full; //check if all seats are reserved 

        public Form1()
        {
            InitializeComponent();
            seatArrayButtons[0, 0] = seatA0;
            seatArrayButtons[0, 1] = seatA1;
            seatArrayButtons[0, 2] = seatA2;
            seatArrayButtons[1, 0] = seatB0;
            seatArrayButtons[1, 1] = seatB1;
            seatArrayButtons[1, 2] = seatB2;
            seatArrayButtons[2, 0] = seatC0;
            seatArrayButtons[2, 1] = seatC1;
            seatArrayButtons[2, 2] = seatC2;
            seatArrayButtons[3, 0] = seatD0;
            seatArrayButtons[3, 1] = seatD1;
            seatArrayButtons[3, 2] = seatD2;
            seatArrayButtons[4, 0] = seatE0;
            seatArrayButtons[4, 1] = seatE1;
            seatArrayButtons[4, 2] = seatE2;
        }
        //check if all seats are reserved: red-reserved, lightblu-empty
        public void CheckCapacity ()
        {
            foreach (Button seat in seatArrayButtons)
            {
                if (seat.BackColor == Color.LightBlue)
                {
                    full = false;   //at least one seat is available
                    break;          //out of loop when find an empty seat
                }
                else
                {
                    full = true;   //all seat are reserved
                }
            }
        }

        //Start: booking system
        public void BookingSystem(int row, int column)
        {
            //the seat has been reserved
            if (seatArrayButtons[row, column].BackColor == Color.Red) 
            {
                MessageBox.Show("Invalid! The seat has been reserved!", "Warning");
                //the situation if all seat are reserved, put the name into waiting list
                CheckCapacity();
                if (full == true)
                {
                    waitingList.Add(textBoxName.Text);
                    if (waitingList.Count < 11) //length of waitinglist <= 10
                    {
                        waitingName = waitingList.ToArray();
                        MessageBox.Show("All seats have been reserved." + "\r\n" +
                        "The name has been added into waiting list.", "Warning");
                        textBoxName.Text = "";
                    }
                    else if (waitingList.Count > 10) //length of waitinglist > 10
                    {
                        MessageBox.Show("All seats have been reserved." + "\r\n" +
                        "Tried to add into waiting list." + "\r\n" +
                        "But the waiting list has been full.", "Warning");
                        textBoxName.Text = "";
                    }
                }
            }
            //the seat still available
            else 
            {
                seatArrayButtons[row, column].BackColor = Color.Red; //change color after successful reserving
                name[row, column] = textBoxName.Text; //record costumers' names into an array
                textBoxName.Text = "";  //the text of name is cleared for next entering
                MessageBox.Show("Booking successful.");
            }
        }
        private void buttonBooking_Click(object sender, EventArgs e)
        {
            //call the method of BookingSystem to book seats
            if (textBoxName.Text != "" && textBoxName.Text.Length >= 2
                && listBoxRow.SelectedIndex != -1 && listBoxColumn.SelectedIndex != -1)
            {
                if (listBoxRow.SelectedItem.ToString() == "A")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            BookingSystem(0, 0); //call the method of booking system
                            break;
                        case "1":
                            BookingSystem(0, 1);
                            break;
                        case "2":
                            BookingSystem(0, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "B")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            BookingSystem(1, 0);
                            break;
                        case "1":
                            BookingSystem(1, 1);
                            break;
                        case "2":
                            BookingSystem(1, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "C")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            BookingSystem(2, 0);
                            break;
                        case "1":
                            BookingSystem(2, 1);
                            break;
                        case "2":
                            BookingSystem(2, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "D")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            BookingSystem(3, 0);
                            break;
                        case "1":
                            BookingSystem(3, 1);
                            break;
                        case "2":
                            BookingSystem(3, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "E")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            BookingSystem(4, 0);
                            break;
                        case "1":
                            BookingSystem(4, 1);
                            break;
                        case "2":
                            BookingSystem(4, 2);
                            break;
                    }
                }
            }
            //check if enter null in name 
            else if (textBoxName.Text == "")
            {
                MessageBox.Show("Invalid! Please enter the customer's name!", "Warning");
            }
            //check if enter a name less than 2 characters
            else if (textBoxName.Text.Length < 2)
            {
                MessageBox.Show("Invalid! The customer's name must be equal/over 2 characters!", "Warning");
            }
            //check if a seat is chosen
            else if (listBoxRow.SelectedIndex == -1 || listBoxColumn.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid! Please choose the row and seat!", "Warning");
            }
            listBoxRow.SelectedIndex = -1;
            listBoxColumn.SelectedIndex = -1;
        }
        //End: booking system

        //Start: cancel system
        public void CancelSystem(int row, int column)
        {
            CheckCapacity();
            //all seat are reserved and names in waiting list
            if (full == true && waitingList.Count != 0)
            {
                seatArrayButtons[row, column].BackColor = Color.Red;
                name[row, column] = richTextBoxWaitingList.Lines[0].Remove(0, 3);
                MessageBox.Show("Cancel successful." + "\r\n" +
                    "This seat has been reserved for the name on the top of waiting list.",
                    "Warning");
                waitingList.RemoveAt(0);
                waitingName = waitingList.ToArray();
            }
            //the seat is empty
            else if (seatArrayButtons[row, column].BackColor != Color.Red)
            {
                MessageBox.Show("Invalid!This seat has NOT been reserved!", "Warning");
            }
            //the seat is reserved and no name in waiting list
            else if (seatArrayButtons[row, column].BackColor == Color.Red &&
                waitingList.Count == 0)
            {
                seatArrayButtons[row, column].BackColor = Color.LightBlue;
                name[row, column] = "";
                MessageBox.Show("Cancel successful.");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //call method of CancelSystem to cancel reservation
            if (listBoxRow.SelectedIndex != -1 && listBoxColumn.SelectedIndex != -1)
            {
                if (listBoxRow.SelectedItem.ToString() == "A")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CancelSystem(0, 0); //call the method of cancel system
                            break;
                        case "1":
                            CancelSystem(0, 1);
                            break;
                        case "2":
                            CancelSystem(0, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "B")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CancelSystem(1, 0);
                            break;
                        case "1":
                            CancelSystem(1, 1);
                            break;
                        case "2":
                            CancelSystem(1, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "C")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CancelSystem(2, 0);
                            break;
                        case "1":
                            CancelSystem(2, 1);
                            break;
                        case "2":
                            CancelSystem(2, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "D")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CancelSystem(3, 0);
                            break;
                        case "1":
                            CancelSystem(3, 1);
                            break;
                        case "2":
                            CancelSystem(3, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "E")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CancelSystem(4, 0);
                            break;
                        case "1":
                            CancelSystem(4, 1);
                            break;
                        case "2":
                            CancelSystem(4, 2);
                            break;
                    }
                }
            }
            //check if a seat is selected
            else if (listBoxRow.SelectedIndex == -1 || listBoxColumn.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid! Please choose the row and seat!", "Warning");
            }
            listBoxRow.SelectedIndex = -1;
            listBoxColumn.SelectedIndex = -1;
        }
        //End: cancel system

        //Start: check seat status
        public void CheckStatus(int row, int column)
        {
            if (seatArrayButtons[row, column].BackColor == Color.Red)
            {
                labelStatus.Text = seatArrayButtons[row, column].Name + ": Not available";
            }
            else
            {
                labelStatus.Text = seatArrayButtons[row, column].Name + ": Available";
            }
        }
        private void buttonStatus_Click(object sender, EventArgs e)
        {
            //call the method of CheckStatus to check seat status
            if (listBoxRow.SelectedIndex != -1 && listBoxColumn.SelectedIndex != -1)
            {
                if (listBoxRow.SelectedItem.ToString() == "A")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CheckStatus(0, 0);
                            break;
                        case "1":
                            CheckStatus(0, 1);
                            break;
                        case "2":
                            CheckStatus(0, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "B")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CheckStatus(1, 0);
                            break;
                        case "1":
                            CheckStatus(1, 1);
                            break;
                        case "2":
                            CheckStatus(1, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "C")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CheckStatus(2, 0);
                            break;
                        case "1":
                            CheckStatus(2, 1);
                            break;
                        case "2":
                            CheckStatus(2, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "D")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CheckStatus(3, 0);
                            break;
                        case "1":
                            CheckStatus(3, 1);
                            break;
                        case "2":
                            CheckStatus(3, 2);
                            break;
                    }
                }
                else if (listBoxRow.SelectedItem.ToString() == "E")
                {
                    switch (listBoxColumn.SelectedItem.ToString())
                    {
                        case "0":
                            CheckStatus(4, 0);
                            break;
                        case "1":
                            CheckStatus(4, 1);
                            break;
                        case "2":
                            CheckStatus(4, 2);
                            break;
                    }
                }
            }
            //check if a seat is selected
            else if (listBoxRow.SelectedIndex == -1 || listBoxColumn.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid! Please choose the row and seat!", "Warning");
            }
            listBoxRow.SelectedIndex = -1;
            listBoxColumn.SelectedIndex = -1;
        }
        //End: check seat status

        //Start: fill all
        private void buttonFillAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    seatArrayButtons[i, j].BackColor = Color.Red;
                    name[i, j] = "tester";
                }
            }
            buttonReleaseAll.Visible = true;
        }
        //End: fill all

        //Start: release all
        private void buttonReleaseAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    seatArrayButtons[i, j].BackColor = Color.LightBlue;
                    name[i, j] = "";
                }
            }
            buttonReleaseAll.Visible = false;
        }
        //End: release all

        //Start: add to waiting list
        private void buttonAddWaitingList_Click(object sender, EventArgs e)
        {
            CheckCapacity();
            //all seats are reserved
            if (full == true) 
            {
                waitingList.Add(textBoxName.Text);
                //check if a name is entered
                if (textBoxName.Text == "")
                {
                    waitingList.Remove("");
                    MessageBox.Show("Invalid! Please enter the customer's name!", "Warning");
                }
                else if (waitingList.Count < 11)  //length of waiting list <= 10
                {
                    waitingName = waitingList.ToArray();
                    MessageBox.Show("Waiting list adding successful");
                    textBoxName.Text = "";
                }
                else if (waitingList.Count > 10) //length of waiting list > 10
                {
                    MessageBox.Show("Invalid! The waiting list has been full.", "Warning");
                    textBoxName.Text = "";
                    waitingList.RemoveAt(10);
                    waitingName = waitingList.ToArray();
                }
            }
            //one or more seats are empty
            else if (full == false)
            {
                MessageBox.Show("Invalid! There are still available seats!", "Warning");
            }
        }
        //End: add to waiting list

        //Start: show waiting list
        private void buttonShowWaitingList_Click(object sender, EventArgs e)
        {
            if (waitingList.Count == 0)
            {
                richTextBoxWaitingList.Text = "";
                MessageBox.Show("Invalid! No names in waiting list now.", "Warning");
            }
            else
            {
                richTextBoxWaitingList.Text = "";
                for (int i = 0; i < waitingName.Length; i++)
                {
                    //richTextBoxWaitingList.Lines[i] = waitingName[i] + "\r\n";
                    richTextBoxWaitingList.Text += i + 1 + ", " + waitingName[i] + "\r\n";
                }
            }
        }
        //End: show waiting list

        //Start: show all
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            //check if all seats are empty
            foreach (Button seat in seatArrayButtons)
            {
                if (seat.BackColor == Color.Red)
                {
                    full = false;
                    break;
                }
                else
                {
                    full = true; //all seat are empty
                }
            }
            if (full == true)
            {
                MessageBox.Show("No name displaying." + "\r\n" +
                        "All seats are empty.", "Warning");
                richTextBoxShowAll.Text = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        
                        richTextBoxShowAll.Text += seatArrayButtons[i, j].Name + ": " + "\r\n";
                    }
                }
            }
            else if (full == false)
            {
                richTextBoxShowAll.Text = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        richTextBoxShowAll.Text += seatArrayButtons[i, j].Name + ": "
                            + name[i, j] + "\r\n";
                    }
                }
            }
        }
        //End: show all

        //Start: booking or cancelling by click seat-bottons directly
        public void ClickSeat(int r, int c)
        {
            //booking
            if (seatArrayButtons[r, c].BackColor == Color.LightBlue)
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Invalid! Please enter the customer's name!", "Warning");
                }
                else
                {
                    seatArrayButtons[r, c].BackColor = Color.Red;
                    name[r, c] = textBoxName.Text;
                    textBoxName.Text = "";  //the text of name is cleared for next entering
                    MessageBox.Show("Booking successful.");
                }
            }
            //canceling
            else if (seatArrayButtons[r, c].BackColor == Color.Red)
            {
                CheckCapacity();
                //all seat are reserved and names in wating list
                if (full == true && waitingList.Count != 0)
                {
                    seatArrayButtons[r, c].BackColor = Color.Red;
                    name[r, c] = richTextBoxWaitingList.Lines[0].Remove(0, 3);
                    MessageBox.Show("Cancel successful." + "\r\n" +
                        "This seat has been reserved for the name on the top of waiting list.",
                        "Warning");
                    waitingList.RemoveAt(0);
                    waitingName = waitingList.ToArray();
                }
                //one or more seats are empty
                else if (full == false)
                {
                    seatArrayButtons[r, c].BackColor = Color.LightBlue;
                    name[r, c] = "";
                    MessageBox.Show("Cancel successful.", "Warning");
                }
            }
        }
        private void seatA0_Click(object sender, EventArgs e)
        {
            ClickSeat(0, 0);
        }
        private void seatA1_Click(object sender, EventArgs e)
        {
            ClickSeat(0, 1);
        }
        private void seatA2_Click(object sender, EventArgs e)
        {
            ClickSeat(0, 2);
        }
        private void seatB0_Click(object sender, EventArgs e)
        {
            ClickSeat(1, 0);
        }
        private void seatB1_Click(object sender, EventArgs e)
        {
            ClickSeat(1, 1);
        }
        private void seatB2_Click(object sender, EventArgs e)
        {
            ClickSeat(1, 2);
        }
        private void seatC0_Click(object sender, EventArgs e)
        {
            ClickSeat(2, 0);
        }
        private void seatC1_Click(object sender, EventArgs e)
        {
            ClickSeat(2, 1);
        }
        private void seatC2_Click(object sender, EventArgs e)
        {
            ClickSeat(2, 2);
        }
        private void seatD0_Click(object sender, EventArgs e)
        {
            ClickSeat(3, 0);
        }
        private void seatD1_Click(object sender, EventArgs e)
        {
            ClickSeat(3, 1);
        }
        private void seatD2_Click(object sender, EventArgs e)
        {
            ClickSeat(3, 2);
        }
        private void seatE0_Click(object sender, EventArgs e)
        {
            ClickSeat(4, 0);
        }
        private void seatE1_Click(object sender, EventArgs e)
        {
            ClickSeat(4, 1);
        }
        private void seatE2_Click(object sender, EventArgs e)
        {
            ClickSeat(4, 2);
        }
        //End: booking or cancelling by click seats directly
    }
}

