using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheet_Application
{
    public partial class TimeSheetForm : Form
    {
        //variable declartions
        public string state = "";
        public string title = "";
        public  string type = "";
        public DateTime duration;
        public decimal hourlyRate = 250.50m;
        public decimal totalRate;
        public string hourlyRateFormat = "h:mm";
        public decimal calculatedRate = 0.0m;
        public string shortTimeString = "";
        public string hours = "";
        public string minutes = "";
        public string timeFormat = "";
        public decimal hoursAndMinutes =0.0m;
        public decimal hourlyBreakUp = 0.0m;

        public TimeSheetForm()
        {
            InitializeComponent();
        }

        //Form Load method shows when the timesheet form is loaded 
        private void Timesheet_Form_Load(object sender, EventArgs e)
        {
            timesheetGridView.Hide();
            timesheetGridView.ClearSelection();
            submitButton.Enabled = false;
        }

        //When the new button is clicked, new row in the timesheet is added
        private void new_Button_Clicked(object sender, EventArgs e)
        {
            timesheetGridView.Rows.Insert(0, new string[] {
             "", "", "", "", "250.50" , "", "Save","Cancel" });
            timesheetGridView.Show();
            timesheetGridView.ClearSelection();
        }

        //Saves the timesheet with the status active
        private void timesheetGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //using try catch block 
           try
            {
                //For save and Update the Timesheet
                if (e.ColumnIndex == 6)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row = timesheetGridView.SelectedRows[0];

                    //gets inside the loop if the cell values are not null

                    if (row.Cells[1].Value != null && row.Cells[2].Value != null &&
                            row.Cells[3].Value != null && row.Cells[4].Value != null)
                        {
                        //Assigning the state to Active
                            state = "Active";
                       
                            title = row.Cells[1].Value.ToString();
                            type = row.Cells[2].Value.ToString();
                            duration = Convert.ToDateTime(row.Cells[3].Value.ToString());

                        //Rounding up to nearest 15 minutes method call
                        var calculatedTotal = TimeRoundUp(duration);

                        //converting the datetime to short time string(h:mm format)
                        shortTimeString = calculatedTotal.ToShortTimeString();

                        //fetching the hours and minutes from datatime using substring
                         hours = shortTimeString.Substring(0, 2);
                         minutes = shortTimeString.Substring(3, 2);

                        //timeFormat shows the converted nearest 15 minute  time in the datagridview
                         timeFormat = hours + ":" + minutes;

                        //the below statement provides the breakup of hourlypay into 15 minutes pay
                        switch(minutes)
                        {
                            case "15": hourlyBreakUp = 62.6m;
                                break;
                            case "30": hourlyBreakUp = 125.2m;
                                break;
                            case "45":
                                hourlyBreakUp = 187.8m;
                                break;
                            default:
                                break;
                        }

                        //converting to decimal for calculation
                        hoursAndMinutes = Convert.ToDecimal(hours);
                        hourlyRate = Convert.ToDecimal(row.Cells[4].Value.ToString());

                        //multiplying the duration(hours and minutes) with hourly rate
                        calculatedRate = (hoursAndMinutes * hourlyRate) + hourlyBreakUp;
                        totalRate = Convert.ToDecimal(calculatedRate.ToString());

                        //Adding the result to the datagridview
                        timesheetGridView.Rows.Add(state, title, type, timeFormat, hourlyRate, totalRate, "Edit", "Delete");

                         //Removes the existing row
                        timesheetGridView.Rows.RemoveAt(row.Index);
                        this.timesheetGridView.ClearSelection();
                        submitButton.Enabled = true;

                    }

                    //Null check validations
                    else
                        {

                        if (row.Cells[1].Value == null)
                        {
                            MessageBox.Show("Please enter the Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (row.Cells[2].Value == null)
                        {
                            MessageBox.Show("Please enter the Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (row.Cells[3].Value == null)
                        {
                            MessageBox.Show("Please enter the Duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Please enter the Hourly Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
                    
                // For Delete and Cancel the timesheet
                else if (e.ColumnIndex == 7)
                {
                    string actionName = timesheetGridView[e.ColumnIndex, e.RowIndex].Value.ToString();

                    //When user clicks delete button, message box is thrown to confirm the delete operation
                    if (actionName == "Delete")
                    {
                        //Message box pops up to confirm the user for deleting the timesheet
                        var onConfirmDelete = MessageBox.Show("Are you sure want to delete the timesheet??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (onConfirmDelete == DialogResult.Yes)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row = timesheetGridView.SelectedRows[0];
                            timesheetGridView.Rows.Remove(row);
                        }
                    }

                    //When user clicks cancel button
                    else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row = timesheetGridView.SelectedRows[0];
                        timesheetGridView.Rows.Remove(row);
                    }
                }
            }

            //catch block throws incase of any format exception
            catch (Exception exceptionMessage)
            {
               MessageBox.Show(exceptionMessage.Message, "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        //TimeRoundUp method calculates the datetime and round off to the nearest 15 minute.
        public static DateTime TimeRoundUp(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0).AddMinutes(input.Minute % 15 == 0 ? 0 : 15 - input.Minute % 15);
        }

        //Submits the timesheet and changes the state from active to submitted
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            { 
            DataGridViewRow submittedRow = new DataGridViewRow();
            submittedRow = timesheetGridView.SelectedRows[0];

                if (submittedRow.Cells[1].Value != null && submittedRow.Cells[2].Value != null &&
                    submittedRow.Cells[3].Value != null && submittedRow.Cells[4].Value != null)
                {
                    //assigning the state to submitted
                    state = "Submitted";
                    title = submittedRow.Cells[1].Value.ToString();
                    type = submittedRow.Cells[2].Value.ToString();
                    duration = Convert.ToDateTime(submittedRow.Cells[3].Value.ToString());

                    //Rounding up to nearest 15 minutes method call
                    //Rounding up to nearest 15 minutes method call
                    var calculatedTotal = TimeRoundUp(duration);

                    //converting the datetime to short time string(h:mm format)
                    shortTimeString = calculatedTotal.ToShortTimeString();

                    //fetching the hours and minutes from datatime using substring
                    hours = shortTimeString.Substring(0, 2);
                    minutes = shortTimeString.Substring(3, 2);

                    //timeFormat shows the converted nearest 15 minute  time in the datagridview
                    timeFormat = hours + ":" + minutes;

                    //the below statement provides the breakup of hourlypay(250.50) into 15 minutes pay
                    switch (minutes)
                    {
                        case "15":
                            hourlyBreakUp = 62.6m;
                            break;
                        case "30":
                            hourlyBreakUp = 125.2m;
                            break;
                        case "45":
                            hourlyBreakUp = 187.8m;
                            break;
                        default:
                            break;
                    }

                    //converting to decimal for calculation
                    hoursAndMinutes = Convert.ToDecimal(hours);
                    hourlyRate = Convert.ToDecimal(submittedRow.Cells[4].Value.ToString());

                    //multiplying the duration(hours and minutes) with hourly rate
                    calculatedRate = (hoursAndMinutes * hourlyRate) + hourlyBreakUp;
                    totalRate = Convert.ToDecimal(calculatedRate.ToString());

                    //Adding the result to the datagridview
                    timesheetGridView.Rows.Add(state, title, type, timeFormat, hourlyRate, totalRate);
                    timesheetGridView.Rows.Remove(submittedRow);

                    //makes the submitted rows readonly
                    foreach(DataGridViewRow row in timesheetGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == "Submitted")
                        {
                            timesheetGridView.Rows[row.Index].ReadOnly = true;
                        }
                    }
                    this.timesheetGridView.ClearSelection();
                    timesheetGridView.Columns[6].ReadOnly = true;
                }
            }

            //throws the exception message
            catch(Exception exceptionMessage)
            {
                MessageBox.Show(exceptionMessage.Message, "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
    }
}
