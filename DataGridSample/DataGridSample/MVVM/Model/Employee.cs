using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSample.Model
{
    public class Employee : INotifyPropertyChanged
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public long IDNumber { get; set; }
        public string Title { get; set; }
        public int ContactID { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int SickLeaveHours { get; set; }
        public double Salary { get; set; }
        public string LoginID { get; set; }
        public int ManagerID { get; set; }
        public bool EmployeeStatus { get; set; }
        public int Rating { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
