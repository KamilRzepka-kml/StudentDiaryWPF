using StudentDiaryWPF.Commands;
using StudentDiaryWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StudentDiaryWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            RefreshStudentsCommand = new RelayCommand(RefreshStudents);

            Students = new ObservableCollection<Student>
            {
                new Student 
                { 
                    FirstName = "Kamil", 
                    LastName = "Rzepka", 
                    Group = new Group {Id = 1 } 
                },
                new Student
                {
                    FirstName = "Marta",
                    LastName = "Rzepka",
                    Group = new Group {Id = 1 }
                },
                new Student
                {
                    FirstName = "Hania",
                    LastName = "Rzepka",
                    Group = new Group {Id = 2 }
                },
                new Student
                {
                    FirstName = "Wojtek",
                    LastName = "Rzepka",
                    Group = new Group {Id = 2 }
                },

            };
        }

        public ICommand RefreshStudentsCommand { get; set; }


        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set 
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                OnPropertyChanged();
            }
        }

        private int _selectedGroupId;

        public int SelectedGroupId
        {
            get { return _selectedGroupId; }
            set 
            { 
                _selectedGroupId = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Group> _groups;

        public ObservableCollection<Group> Groups
        {
            get { return _groups; }
            set
            {
                _groups = value;
                OnPropertyChanged();
            }
        }



        private void RefreshStudents(object obj)
        {
            
        }

    }
}
