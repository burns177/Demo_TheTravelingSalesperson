using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    class Controller
    {
        #region FIELDS

        private ConsoleView _consoleView;
        private Salesperson _salesperson;
        private bool _usingApplication;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS
        public Controller()
        {

            InitializeController();

            _consoleView = new ConsoleView();

            _salesperson = new Salesperson();
    
            ManageApplicationLoop();
        }

        #endregion

        #region METHODS

        public void DisplayAccountInfo()
        {
            _consoleView.DisplayAccountInfo(_salesperson);
        }

        public void DisplayCities()
        {
            _consoleView.DisplayCitiesTraveled(_salesperson);
        }

        public void InitializeController()
        {
            _usingApplication = true;
        }

        public void ManageApplicationLoop()
        {
            MenuOptions userMenuChoice;


            _consoleView.DisplayWelcomeScreen();

            _salesperson = _consoleView.DisplaySetupAccount();

            while (_usingApplication)
            {
                userMenuChoice = _consoleView.DisplayGetUserMenuChoice();

                switch (userMenuChoice)
                {
                    case MenuOptions.None:
                        break;
                    case MenuOptions.Travel:
                        Travel();
                        break;
                    case MenuOptions.DisplayCities:
                        DisplayCities();
                        break;
                    case MenuOptions.DisplayAccountInfo:
                        DisplayAccountInfo();
                        break;
                    case MenuOptions.Exit:
                        _usingApplication = false;
                        break;
                    default:
                        break;
                }

                _consoleView.DisplayClosingScreen();

                Environment.Exit(1);
            }
        }

        public void Travel()
        {
            string nextCity = _consoleView.DisplayGetNextCity();

            if (nextCity != "")
            {
                _salesperson.CitiesVisited.Add(nextCity);
            }
        }

        #endregion
    }
}