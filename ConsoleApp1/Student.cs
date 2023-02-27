namespace ConsoleApp1
{
    class Student
    {
        private string id;
        private string name;
        private DateTime dateOfBirthSaving;
        private string gender;
        private string majorId;
        private Major major;
        public Student()
        {

        }
        public Student(string id, string name, string dob, string gender, string majorId)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.majorId = majorId;
            this.dateOfBirthSaving = DateTime.Parse(dob).Date;

        }


        public string Id
        {
            set
            {
                this.id = value;
            }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public DateTime DateOfBirthSaving
        {
            set { this.dateOfBirthSaving = value; }
            get { return this.dateOfBirthSaving; }
        }
        public string Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        }
        public string MajorId
        {
            set { this.majorId = value; }
            get
            {
                return majorId;
            }
        }
        public Major Major
        {
            set { major = value; }
            get { return major; }
        }

    }
}
