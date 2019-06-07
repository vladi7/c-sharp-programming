using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
namespace DTS_Project
{
    [Serializable()]
    static class TenantData
             {
       public  static int count { get; private set; }
            /// <summary>
            /// stores ordered tenant's list with possibility of search by AC(main dictionary that stores tenant as an object)
            /// </summary>
            static public OrderedDictionary tenants { get;  private set; } = new OrderedDictionary();

            /// <summary>
            /// Key - name, Value - AC code, mainly used to find AC by First+Last Name
            /// </summary>
            static public Dictionary<string, string> ACfinder { get; private set; } = new Dictionary<string, string>();

            static public void AddTenant(Tenant tenant)
            {
            
            if(!TenantData.tenants.Contains(tenant.accessCode))
            {
                tenants.Add(tenant.accessCode, tenant);
                ACfinder.Add(String.Concat(tenant.firstName, tenant.lastName), tenant.accessCode);
                count++;
            }
            

            }

            static public void DeleteTenant(string firstName, string lastName)
            {
                string AC;//Access Code
                string fullName = String.Concat(firstName, lastName);
                if (ACfinder.ContainsKey(fullName))
                {
                    AC = ACfinder[fullName];
                    ACfinder.Remove(fullName);
                    tenants.Remove(AC);
                count--;
                }
            }

            static public bool FindTenant(string firstName, string lastName, ref Tenant t)
            {
                string AC;//Access Code
                string fullName = String.Concat(firstName, lastName);
                if(ACfinder.TryGetValue(fullName, out AC)) { t = (Tenant)tenants[AC]; return true; }
            return false;
            }

            static public bool FindTenantByAC(string AC, ref Tenant t)
            {
                if (tenants.Contains(AC)) { t = (Tenant)tenants[AC]; return true; }
                return false;
            }
    }
    }

