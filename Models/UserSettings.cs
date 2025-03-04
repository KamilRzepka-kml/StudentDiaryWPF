using StudentDiaryWPF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiaryWPF.Models
{
    public class UserSettings : IDataErrorInfo
    {
        public bool _isServerAdressValid;
        public bool _isServerNameValid;
        public bool _isDatabaseValid;
        public bool _isUserValid;
        public bool _isPasswordValid;

        public string ServerAdress
        {
            get
            {
                return Settings.Default.ServerAdress;
            }
            set
            {
                Settings.Default.ServerAdress = value;
            }
        }
        public string ServerName
        {
            get
            {
                return Settings.Default.ServerName;
            }
            set
            {
                Settings.Default.ServerName = value;
            }
        }
        public string Database
        {
            get
            {
                return Settings.Default.Database;
            }
            set
            {
                Settings.Default.Database = value;
            }
        }
        public string User
        {
            get
            {
                return Settings.Default.User;
            }
            set
            {
                Settings.Default.User = value;
            }
        }
        public string Password
        {
            get
            {
                return Settings.Default.Password;
            }
            set
            {
                Settings.Default.Password = value;
            }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(ServerAdress):
                        if (string.IsNullOrWhiteSpace(ServerAdress))
                        {
                            Error = "Pole Adres serwera jest wymagane.";
                            _isServerAdressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAdressValid = true;

                        }
                        break;
                    case nameof(ServerAdress):
                        if (string.IsNullOrWhiteSpace(ServerAdress))
                        {
                            Error = "Pole Adres serwera jest wymagane.";
                            _isServerAdressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAdressValid = true;

                        }
                        break;
                    case nameof(ServerAdress):
                        if (string.IsNullOrWhiteSpace(ServerAdress))
                        {
                            Error = "Pole Adres serwera jest wymagane.";
                            _isServerAdressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAdressValid = true;

                        }
                        break;
                    case nameof(ServerAdress):
                        if (string.IsNullOrWhiteSpace(ServerAdress))
                        {
                            Error = "Pole Adres serwera jest wymagane.";
                            _isServerAdressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAdressValid = true;

                        }
                        break;
                    case nameof(ServerAdress):
                        if (string.IsNullOrWhiteSpace(ServerAdress))
                        {
                            Error = "Pole Adres serwera jest wymagane.";
                            _isServerAdressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAdressValid = true;

                        }
                        break;
                    default:
                        break;
                }
                return Error;
            }
        }

        public string Error { get;set;}

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
