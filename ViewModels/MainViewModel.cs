﻿using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
            AddStudentCommand = new RelayCommand(AddStudent);
            EditStudentCommand = new RelayCommand(EditStudent, CanEditDeleteStudent);
            DeleteStudentCommand = new AsyncRelayCommand(DeleteStudent, CanEditDeleteStudent);
            RefreshStudentsCommand = new RelayCommand(RefreshStudents);

            RefreshDiary();

            InitGRoups();
        }

       

        public ICommand AddStudentCommand { get; set; }
        public ICommand EditStudentCommand { get; set; }
        public ICommand DeleteStudentCommand { get; set; }
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
            RefreshDiary();
        }

        private bool CanEditDeleteStudent(object obj)
        {
            return SelectedStudent != null;
        }

        private async Task DeleteStudent(object obj)
        {
            var metroWindow = Application.Current.MainWindow as MetroWindow;
            var dialog = await metroWindow.ShowMessageAsync("Usuwanie ucznia", $"Czy na pewno chcesz usunąć ucznia {SelectedStudent.FirstName} {SelectedStudent.LastName}?", MessageDialogStyle.AffirmativeAndNegative);

            if (dialog != MessageDialogResult.Affirmative)
                return;

            //usuwanie ucznia z bazy

            RefreshDiary();
        }

        private void EditStudent(object obj)
        {
        }

        private void AddStudent(object obj)
        {
        }


        private void InitGRoups()
        {
            Groups = new ObservableCollection<Group>
            {
                new Group {Id = 0, Name = "Wszystkie"},
                new Group {Id = 1, Name = "1A"},
                new Group {Id = 2, Name = "2A"}
            };

            SelectedGroupId = 0;
        }

        private void RefreshDiary()
        {
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

    }
}
