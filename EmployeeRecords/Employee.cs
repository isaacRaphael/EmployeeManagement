

namespace EmployeeRecords {

    public class Employee {
        private int _staffId; 
        private string _fullName; 

        private DateTime _employmentDate;

        public Employee(int staffId , string fullName , DateTime employmentDate)
        {
            _staffId = staffId;
            _fullName = fullName;
            _employmentDate = employmentDate;
        }



        public int StaffId { get{return _staffId;} }
        public string  FullName { get{return _fullName;} }
        public DateTime  EmploymentDate { get{return _employmentDate;} }

        public string JobTittle { get; set; }
        public string Department { get; set; }


         public void ClockIn() {
            DateTime ClockInTime = DateTime.Now;
            Console.WriteLine($"{_fullName} Clocked in at {ClockInTime.ToString("F")}");
        }
         public void ClockOut() {
            DateTime ClockOutTime = DateTime.Now;
            Console.WriteLine($"{_fullName} Clocked out at {ClockOutTime.ToString("F")}");
        }
         public void Work() {
            Console.WriteLine($"{_fullName} Working, Doing his {JobTittle} duties");
        }

    }

   
}