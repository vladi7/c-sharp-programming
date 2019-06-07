using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization.Formatters.Binary;  // Add this for serialization
using System.IO;    // Add this for serialization
namespace DTS_Project
{
    [Serializable()]
    public class TerminalController
    {
        Tenant currentTenant;

        private ITerminalDevice terminalDevice;

        public TerminalController()
        {

        }

        public ITerminalDevice TerminalDevice
        {
            set { terminalDevice = value; }
        }




        public void Activate()
        {
            //verify password and if verified, show MainMenuDialog
            // if a user presses "Cancel", do nothing and just return
            string password = null;
            string defaultPassword = "ksu";
            if (!terminalDevice.GetPassword(ref password)) return;
            // you need to verify the password
            if (password == defaultPassword)
            {
                terminalDevice.ShowMainMenuDialog();
            }
        }

        // handlers for MainMenuDialog
        public void AddTenant_Handler()
        {
            // Add a tenant
            // Get the name and access code of the tenant to be added
            string firstName = null;
            string lastName = null;
            string accessCode = null;
            if (!terminalDevice.GetTenantInfo(ref firstName, ref lastName, ref accessCode)) return;
            BarredNumbersList bnl = new BarredNumbersList();
            CallData cl = new CallData();
            TenantData.AddTenant(new Tenant(firstName, lastName, accessCode, bnl, cl));

        }

        public void DeleteTenant_Handler()
        {
            // Delete a tenant
            // Get the first name and the last name of the tenant to be deleted
            string firstName = null;
            string lastName = null;
            if (!terminalDevice.GetTenantName(ref firstName, ref lastName)) return;
            TenantData.DeleteTenant(firstName, lastName);
        }

        public void WorkOnTenant_Handler()
        {
            // Work on a specific tenant
            // Input the first name and the last name of the tenant to work on
            string firstName = null;
            string lastName = null;
            if (!terminalDevice.GetTenantName(ref firstName, ref lastName)) return;
            if(TenantData.FindTenant(firstName, lastName, ref currentTenant)) { terminalDevice.ShowTenantMenuDialog(); }
        }

        public void DisplayTenantList_Handler()
        {

            object[] list = new object[TenantData.tenants.Count];
            for (int i = 0; i < TenantData.tenants.Count; i++)
            {
                Tenant tenant  = (Tenant)TenantData.tenants.Cast<System.Collections.DictionaryEntry>().ElementAt(i).Value;
                list[i] = tenant.firstName + " " + tenant.lastName + " : "+ tenant.accessCode;
            }
            // call "void DisplayList(object[] list)" to list Tenants
            terminalDevice.DisplayList(list);
        }

        public void Save_Handler()
        {

            List<SerializableKeyValuePair<string, object>> list = new List<SerializableKeyValuePair<string, object>>();
            foreach (DictionaryEntry de in TenantData.tenants)
            {
                object tenant = de.Value;
                SerializableKeyValuePair<string, object> keyValue = new SerializableKeyValuePair<string, object>(de.Key.ToString(), de.Value);
                list.Add(keyValue);
            }

            BinaryFormatter fo = new BinaryFormatter();
            FileStream f = new FileStream("savefile.svf",
            FileMode.Create, FileAccess.Write);
             fo.Serialize(f, list); 
            f.Close();
        }

        public void Restore_Handler()
        {
            List<SerializableKeyValuePair<string, object>> list = new List<SerializableKeyValuePair<string, object>>();
            FileStream f = new FileStream("savefile.svf",
                    FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter fo = new BinaryFormatter();

            list = (List<SerializableKeyValuePair<string, object>>)fo.Deserialize(f); 
           
            for(int i = 0; i < list.Count; i++)
            {
                Tenant toTenant = (Tenant)list[i].Value;
                Tenant toTenantData = new Tenant(toTenant.firstName, toTenant.lastName, toTenant.accessCode,toTenant.barredList,toTenant.callData);
                TenantData.AddTenant(toTenantData);
            }

            f.Close();
        }

        public void ChangePassword_Handler()
        {
            string password = null;
            if (!terminalDevice.GetPassword(ref password)) return;

        }

        // ==== Handlers for TenantMenuDialog
        public void BarAreaCode_Handler()
        {
            // Bar an area code
            // Input the area code to bar
            string areaCode = null;
            if (!terminalDevice.GetAreaCode(ref areaCode)) return;
            currentTenant.barredList.addBarredArea(areaCode);
        }

        public void BarTelephoneNumber_Handler()
        {
            // Bar a telephone number
            // Input the telephone number to bar
            string areaCode = null;
            string exchange = null;
            string number = null;
            if (!terminalDevice.GetTelephoneNumber(ref areaCode, ref exchange, ref number)) return;
            currentTenant.barredList.addBarredNumber(areaCode, exchange, number);
        }

        public void UnBarAreaCode_Handler()
        {
            // Unbar an area code
            // Input the area code to unbar
            string areaCode = null;
            if (!terminalDevice.GetAreaCode(ref areaCode)) return;
            currentTenant.barredList.deleteBarredArea(areaCode);
        }

        public void UnBarTelephoneNumber_Handler()
        {
            // Unbar a telephone number
            // Input the telephone number to unbar 
            string areaCode = null;
            string exchange = null;
            string number = null;
            if (!terminalDevice.GetTelephoneNumber(ref areaCode, ref exchange, ref number)) return;
            currentTenant.barredList.deleteBarredNumber(areaCode, exchange, number);
        }
        
        public void DisplayCallList_Handler()
        {
            // call  "void DisplayList(object[] list)" to list Calls
            terminalDevice.DisplayList(currentTenant.callData.toObjectArray(currentTenant.callData.callData));
        }
        
        public void DisplayBarList_Handler()
        {
            // call "void DisplayList(object[] list)" to list Bar Numbers
            TenantData.FindTenant(currentTenant.firstName,currentTenant.lastName,ref currentTenant);
            terminalDevice.DisplayList(currentTenant.barredList.toObjectArray(currentTenant.barredList.barredNumbers));
        }
        
        public void ClearCalls_Handler()
        {
            currentTenant.callData.ClearCallData();
        }

        /// <summary>
        /// Makes it possible to serialize a key value pair
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        [Serializable]
        public class SerializableKeyValuePair<TKey, TValue>
        {

            public SerializableKeyValuePair()
            {
            }

            public SerializableKeyValuePair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }

            public TKey Key { get; set; }
            public TValue Value { get; set; }

        }
    }
}
