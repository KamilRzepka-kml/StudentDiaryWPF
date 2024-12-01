using StudentDiaryWPF.Models;
using StudentDiaryWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentDiaryWPF
{
    internal class AddEditStudentViewModel : ViewModelBase
    {
        public AddEditStudentViewModel(Student student = null)
        {
                
        }
        public  ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

    }
}
