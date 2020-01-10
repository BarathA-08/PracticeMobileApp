using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PracticeMobileApp.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {


        private string _firstname;
        private string _lastname;
        private string _fullname;


        public MainPageViewModel()
        {

            _firstname = "Default First Name";
            _lastname = "Default Last Name";
            _fullname = "Default Full Name";


        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }


        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }



        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
