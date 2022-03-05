namespace DIKULecture{
    class Lecture : ChatRoom{
        private int numOfStudentsOnline = 0;
        private string Name;
        private string information = "";

        public Lecture(string Name) : base(Name) {
        }

        public override string ToString()
        {
            return String.Format("Lecture: " + this.name + "\nNumber of students online: " +
                numOfStudentsOnline);
        }

        public string getLectureInformation() {
            return this.information;
        }

        public void setLectureInformation(string info) {
            this.information = info;
        }

        public int getNumOfStudentsOnline() {
            return this.numOfStudentsOnline;
        }

        public void incrementNumOfStudentsOnline() {
            this.numOfStudentsOnline++;
        }

        public string getName() {
            return this.name;
        }
    }
}