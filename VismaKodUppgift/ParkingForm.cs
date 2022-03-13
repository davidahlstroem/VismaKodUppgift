using System;
using System.Linq;
using System.Windows.Forms;

namespace VismaKodUppgift
{
    public partial class ParkingForm : Form
    {
        Validator validator = new Validator();
        Database db = new Database();
        private readonly int CAPACITY = 45;

        public ParkingForm()
        {
            InitializeComponent();
            progressBar.Maximum = CAPACITY;
        }

        // Enters a new vehicle into the system using ParkingId
        private void ButtonEnterNewVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                // Create objects
                Ticket ticket = new Ticket();
                Vehicle v = new Vehicle();
                ParkingSpot pSpot = new ParkingSpot();

                // Get pID values
                ticket.ParkingSpotId = Convert.ToInt32(NumericParkingPlace.Value);
                pSpot.parkingSpotId = Convert.ToInt32(NumericParkingPlace.Value);

                // Checks if the parkingspot is occupied
                ParkingSpot result = db.ParkingSpotList.Find(x => x.parkingSpotId == pSpot.parkingSpotId);
                if (result != null && !result.state)
                {
                    MessageBox.Show("Parkingspot is currently occupied");
                    return;
                }
                pSpot.state = false; // sets the parkinlot to occupied

                // Check if License number is valid, if so add to objects
                if (!validator.validateLicenseNumber(textBoxLicenseNumber.Text.ToUpper()))
                {
                    MessageBox.Show("Not a valid license number");
                    return;
                }
                ticket.LicenseNumber = textBoxLicenseNumber.Text.ToUpper();
                v.licenseId = textBoxLicenseNumber.Text.ToUpper();
                v.vType = comboBoxVehicleType.Text; // this type (string) currently serves no function, according to the exercise-case

                // Get the time
                DateTime dateOnly = PickerDate.Value;
                DateTime timeOnly = PickerTime.Value;
                ticket.EntryTime = new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day, timeOnly.Hour, timeOnly.Minute, timeOnly.Second);

                // Add to Lists
                db.ParkingSpotList.Add(pSpot);
                db.tList.Add(ticket);
                AddToFormList();

                // Add to capacity-progress bar
                progressBar.Increment(1);
                LabelParkingSpace.Text = progressBar.Value + "/" + CAPACITY.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Data not valid");
            }
        }

        // Removes a vehicle from the system using ParkingId
        //
        private void ButtonVehicleLeaves_Click(object sender, EventArgs e)
        {
            try
            {
                // Create objects
                Ticket ticket = new Ticket();

                // Add values
                ticket.ParkingSpotId = Convert.ToInt32(NumericParkingPlace.Value);
                ticket.LicenseNumber = textBoxLicenseNumber.Text.ToUpper();
                DateTime dateOnly = PickerDate.Value;
                DateTime timeOnly = PickerTime.Value;
                ticket.ExitTime = new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day, timeOnly.Hour, timeOnly.Minute, timeOnly.Second);

                // Find the entryTime by ID
                Ticket ticketByID = db.tList.Find(x => x.TicketId == ticket.TicketId);
                ticket.EntryTime = ticketByID.EntryTime;

                // Calculate Payment
                ticket.CalculatePayment(ticket.EntryTime, ticket.ExitTime);

                // Remove from ticketlist
                Ticket item = db.tList.Single(x => x.ParkingSpotId == ticket.ParkingSpotId);
                db.tList.Remove(item);

                // Remove from parkingSpot list
                ParkingSpot result = db.ParkingSpotList.Find(x => x.parkingSpotId == ticket.ParkingSpotId);
                result.state = true;
                db.ParkingSpotList.Remove(result);

                // Add to lists
                db.ticketHistory.Add(ticket);
                AddToFormList();
                AddToTicketFormList();

                // Remove from capacity-progressbar
                progressBar.Increment(-1);
                LabelParkingSpace.Text = progressBar.Value + "/" + CAPACITY.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There is no vehicle with that ID in the parking lot");
            }
        }

        private void AddToFormList()
        {
            ListOfVehicles.Items.Clear();
            foreach (Ticket item in db.tList)
            {
                ListViewItem list = new ListViewItem();
                list.Text = item.ParkingSpotId.ToString();
                list.SubItems.Add(item.LicenseNumber);
                list.SubItems.Add(item.EntryTime.ToString());
                ListOfVehicles.Items.Add(list);
            }
        }
        private void AddToTicketFormList()
        {
            ListOfVehiclesHistory.Items.Clear();
            foreach (Ticket item in db.ticketHistory)
            {
                ListViewItem list = new ListViewItem();
                list.Text = item.LicenseNumber;
                list.SubItems.Add(item.ExitTime.ToString());
                list.SubItems.Add(item.Payment.ToString() + " kr");
                ListOfVehiclesHistory.Items.Add(list);
            }
        }
    }
}
