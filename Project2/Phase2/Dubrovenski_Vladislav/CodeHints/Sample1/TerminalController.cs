using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;  // Add this for serialization
using System.IO;    // Add this for serialization

namespace DTS_Project
{

    public class TerminalController
    {
        private ITerminalDevice terminalDevice;

        List<State> states; 

        public TerminalController()
        {
            states = new List<State>();
            constructStateList();
        }

        private void constructStateList()
        {
            List<City> cities = new List<City>();
            cities.Add(new City(12000, "Topeka"));
            cities.Add(new City(5000, "Manhattan"));
            cities.Add(new City(20000, "Wichita"));
            states.Add(new State(50000, "Kansas", cities));

            cities = new List<City>();
            cities.Add(new City(200000, "Los Angeles"));
            cities.Add(new City(100000, "San Francisco"));
            states.Add(new State(500000, "California", cities));

            cities = new List<City>();
            cities.Add(new City(30000, "Columbus"));
            states.Add(new State(80000, "Ohio", cities));
        }

        public ITerminalDevice TerminalDevice
        {
            set { terminalDevice = value; }
        }


        public void Activate()
        { //XXXXX Entry Point to CodeHints

            //verify password and if verified, show MainMenuDialog
            // if a user presses "Cancel", do nothing and just return
            //string password = null;
            //if (!terminalDevice.GetPassword(ref password)) return;

            terminalDevice.ShowMainMenuDialog();
        }

        // handlers for MainMenuDialog
        public void AddTenant_Handler()
        {  //XXXXX Not Used
            // Add a tenant
            // Get the name and access code of the tenant to be added
            //string firstName = null;
            //string lastName = null;
            //string accessCode = null;
            //if (!terminalDevice.GetTenantInfo(ref firstName, ref lastName, ref accessCode)) return;

        }

        public void DeleteTenant_Handler()
        { // XXXXX Not Used
          // Delete a tenant
          // Get the first name and the last name of the tenant to be deleted
          //string firstName = null;
          //string lastName = null;
          //if (!terminalDevice.GetTenantName(ref firstName, ref lastName)) return;

        }

        public void WorkOnTenant_Handler()
        {  // XXXXX NOT USED
            // Work on a specific tenant
            // Input the first name and the last name of the tenant to work on
            //string firstName = null;
            //string lastName = null;
            //if (!terminalDevice.GetTenantName(ref firstName, ref lastName)) return;

            //terminalDevice.ShowTenantMenuDialog();
        }

        public void DisplayTenantList_Handler()
        { //XXXXX Display StateList
            // call "void DisplayList(object[] list)" to list Tenants
            object[] objects = states.ToArray();
            terminalDevice.DisplayList(objects);
        }

        public void Save_Handler()
        { //XXXXX Save
            BinaryFormatter fo = new BinaryFormatter();
            FileStream f = new FileStream("savefile.svf",
            FileMode.Create, FileAccess.Write);
            fo.Serialize(f, states);
            f.Close();

            // The next line is for testing purpose.  Don't do this in your DTS program
            states.Clear();
        }

        public void Restore_Handler()
        {  // XXXXX Restore
            FileStream f = new FileStream("savefile.svf",
                    FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter fo = new BinaryFormatter();
            states = (List<State>)fo.Deserialize(f);
            f.Close();
        }

        public void ChangePassword_Handler()
        { // XXXX Instantiate DateForm to explain how to use DateTime
          //string password = null;
          //if (!terminalDevice.GetPassword(ref password)) return;

            DateForm dateForm = new DateForm();
            dateForm.ShowDialog();

        }

        // ==== HandlersFor TenantMenuDialog
        //XXXX IGNORE THE FOLLOWING METHODS
        public void BarAreaCode_Handler()
        {
            // Bar an area code
            // Input the area code to bar
            string areaCode = null;
            if (!terminalDevice.GetAreaCode(ref areaCode)) return;

        }

        public void BarTelephoneNumber_Handler()
        {
            // Bar a telephone number
            // Input the telephone number to bar
            string areaCode = null;
            string exchange = null;
            string number = null;
            if (!terminalDevice.GetTelephoneNumber(ref areaCode, ref exchange, ref number)) return;

        }

        public void UnBarAreaCode_Handler()
        {
            // Unbar an area code
            // Input the area code to unbar
            string areaCode = null;
            if (!terminalDevice.GetAreaCode(ref areaCode)) return;

        }

        public void UnBarTelephoneNumber_Handler()
        {
            // Unbar a telephone number
            // Input the telephone number to unbar 
            string areaCode = null;
            string exchange = null;
            string number = null;
            if (!terminalDevice.GetTelephoneNumber(ref areaCode, ref exchange, ref number)) return;

        }

        public void DisplayCallList_Handler()
        {
            // call  "void DisplayList(object[] list)" to list Calls
        }

        public void DisplayBarList_Handler()
        {
            // call "void DisplayList(object[] list)" to list Bar Numbers

        }

        public void ClearCalls_Handler()
        {

        }
    }
}
