/* NameInformation.cs
 * Author: Vladislav Dubrovenski
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A structure containing a name, frequency, and rank.
    /// </summary>
    public struct NameInformation : IComparable<NameInformation>
    {
        /// <summary>
        /// compares this and info
        /// </summary>
        /// <param name="info">nameinformation that we will implement</param>
        /// <returns></returns>
        public int CompareTo(NameInformation info)
        {
            return this.Name.CompareTo(info.Name);
        }

        private string _name;

        private float _frequency;

        private int _rank;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public float Frequency
        {
            get
            {
                return _frequency;
            }
        }

        public int Rank
        {
            get
            {
                return _rank;
            }
        }

        /// <summary>
        /// Constructs a new NameInformation containing the given name,
        /// frequency, and rank.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="frequency">The frequency.</param>
        /// <param name="rank">The rank.</param>
        public NameInformation(string name, float frequency, int rank)
        {
            _name = name;
            _frequency = frequency;
            _rank = rank;
        }

        /// <summary>
        /// Converts this NameInformation to a string.
        /// </summary>
        /// <returns>The string equivalent of this NameInformation.</returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
