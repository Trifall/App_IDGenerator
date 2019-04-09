using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troschuetz.Random;

namespace IdGenerator
{
    public partial class IDGeneratorForm : Form
    {
    // Variable Initialization

        // Initialize the array that is going to be used for storing IDs on the backend
        List<int> IDList = new List<int>();
        // Create the SaveFile path variable which will be used to store and import the list of IDs.
        string SaveFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IDList.txt";

    // Class Code
        // Constructor function for the form
        public IDGeneratorForm()
        {
            // Initialize and declare the GUI Components.
            InitializeComponent();
        }


      // GUI Functions
        // This function runs on the start of the program. It clears the internal memory just in case, and also imports the ID's from the save file if there is one.
        private void IDGeneratorForm_Load(object sender, EventArgs e)
        {
            ClearIDListItems();
            ImportIDsFromFile();

        }

        // Calls AddIDToList() on button press -> ID Generation
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            AddIDToList();
        }
        
        // Calls ImportIDsFromFile() on button press -> Import IDs from File
        private void ImportIDButton_Click(object sender, EventArgs e)
        {
            ImportIDsFromFile();
        }

        // Calls ExportIDsToFile() on button press -> Export IDs to File
        private void ExportIDButton_Click(object sender, EventArgs e)
        {
            ExportIDsToFile();
        }

        // Calls ClearSavedIDs() on button press -> Clear IDs from File
        private void ClearIDButton_Click(object sender, EventArgs e)
        {
            ClearSavedIDs();
        }

        // Calls ClearIDListItems() on button press -> Clear IDs from backend
        private void ClearIDList_Click(object sender, EventArgs e)
        {
            ClearIDListItems();
        }

        // Calls OpenIDFile on button press -> Opens ID File with Notepad
        private void OpenIDFileButton_Click(object sender, EventArgs e)
        {
            OpenIDFile();
        }


     // Algorithmic / Logical Functions
        // This function is used to Open the ID File with the default notepad program.
        private void OpenIDFile()
        {
            // Declare Notepad path for opening executable
            string notepadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "notepad.exe");
            // Start Notepad process
            System.Diagnostics.Process.Start(notepadPath, SaveFile);
        }

        // This function is used to import the saved ID's from the file that is stored on the computer, and also clears the items that are stored in memory.
        private void ImportIDsFromFile()
        {
            // Check if ID FIle already exists
            if (File.Exists(SaveFile))
            {
                // Clear the ID List from memory
                IDList.Clear();
                // Clear the visible box from the Form
                IDListBox.Items.Clear();
                // Read all lines from the file that saves the IDs
                var idFile = File.ReadAllLines(SaveFile);
                // Convert the imported list to a initialized list
                List<string> _IdList = idFile.ToList();
                // For each ID in list, do the following 
                foreach (var id in _IdList)
                {
                    // Convert string ID to an Integer
                    int _id = Convert.ToInt32(id);
                    // Add converted ID to the backend list
                    IDList.Add(_id);
                    // Add converted ID to the frontend list
                    IDListBox.Items.Add(_id);
                }
            }
        }

        // This function is used to export the ID's from the internal memory to the external save file.
        private void ExportIDsToFile()
        {
            // Create a streamwriter object to be able to write to the ID File stored for backup.
            using (StreamWriter writeid = new StreamWriter(SaveFile)) // Create streamwriter object with file path
                foreach (int id in IDList) // For each ID that is in the backend list,
                    writeid.WriteLine(id); // Write each ID to the end of the file.
        }

        // This function is used to add the randomly generated ID to internal memory list, and use comparators to verify its integrity.
        private void AddIDToList()
        {
            // Call the algorithmic function to generate a random ID.
            int ID = GenerateId();
            // Check if the list already contains the ID that has been made.
            if (!IDList.Contains(ID)) // If the list doesn't contains the ID
            {
                // Add the confirmed ID to the backend list
                IDList.Add(ID);
                // Add the confirmed ID to the frontend list
                IDListBox.Items.Add(ID);
                // Set the Form Display label to the ID, so that it accurately displays the latest item.
                LatestIDLabel.Text = ID.ToString();
                // Set the same label to false, since the ID doesn't match any ones that have been found in the list.
                InUseLabel.Text = "False";
            }
            else // If the list already contains the ID
                InUseLabel.Text = "True"; // Set the label to true to display that the ID is a duplicate.
        }

        // This function clears the IDs that are currently being stored in the save file.
        private void ClearSavedIDs()
        {
            // Check if the file already exists before clearing.
            if (File.Exists(SaveFile))
                File.WriteAllText(SaveFile, String.Empty); // Replace all the text in the file with an empty string, effectively removing all of its contents.
        }

        // This function is used to clear the frontend and backend of the ID List.
        private void ClearIDListItems()
        {
            // Clear the list of items in the backend memory.
            IDList.Clear();
            // CLear the frontend list of items.
            IDListBox.Items.Clear();
        }

        // This function is the generation method that uses a random algorithm to ensure secure and truly random items. This method makes a call to a third party library to ensure a more random number.
        private int GenerateId()
        {
            // Initiate imported library object
            var _TRandom = new TRandom();
            // Create a double that uses a random algorithm to get a more random number.
            double Number = (_TRandom.Next(100000,999999) + _TRandom.Next(100000,999999)) / 2;
            // Take the random double, which is rounded to consider for odd numbers, and then implement them into a conversion algorithm. 
            return Convert.ToInt32(Math.Floor(Number)); // Return the int back to the place where it was called from.
        }
    }
}
