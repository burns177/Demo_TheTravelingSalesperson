using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{

    public class Salesperson
    {
        #region FIELDS
        private string _accountID;

        private List<string> _citiesVisited;

        private string _firstName;

        private string _lastName;




        #endregion

        #region PROPERTIES

        public string AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }

        public List<string> CitiesVisited
        {
            get { return _citiesVisited; }
            set { _citiesVisited = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Salesperson()
        {
            _citiesVisited = new List<string>();
        }

        public Salesperson(string firstName, string lastName, string accountID)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountID = accountID;

            _citiesVisited = new List<string>();
        }
        #endregion

        #region METHODS



        #endregion
    }
}
