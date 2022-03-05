namespace DIKULecture{
    class Student : Person{
        private bool isInLecture = false;
        private Lecture lecture;
        private string information = "";


        public void Join(Lecture newLecture) {
            if (this.isInLecture == false) {
                this.isInLecture = true;
                this.lecture = newLecture;
                this.lecture.incrementNumOfStudentsOnline();
            }
        }

        public void Listen() {
            if (this.isInLecture) {
                this.information = this.lecture.getLectureInformation();
            }
        }

        public Lecture getLecture() {
            return this.lecture;
        }

        public bool getLectureStatus() {
            return this.isInLecture;
        }

        public string getInformation() {
            return this.information;
        }
    }
}
