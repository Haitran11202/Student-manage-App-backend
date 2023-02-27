namespace ConsoleApp1
{
    class Major
    {
        string majorId;
        string majorName;

        public Major(string majorId, string majorName)
        {
            this.majorId = majorId;
            this.majorName = majorName;
        }
        public Major()
        {

        }
        public string MajorId
        {
            set { majorId = value; }
            get { return majorId; }
        }
        public string MajorName
        {
            set { majorName = value; }
            get { return majorName; }
        }
    }
}
