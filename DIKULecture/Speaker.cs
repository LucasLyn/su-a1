namespace DIKULecture{
    class Speaker : Person{
        private bool isInLecture = false;
        private Lecture lecture;
        private string speech = "Blah Blah Blah... Something Important...";

        public void ChangeLectureName(ChatRoom lecture, string newName) {
            if (isInLecture && this.lecture == lecture) {
                this.lecture.name = newName;
            }
        }

        public void Broadcast(Lecture lec, string info) {
            lec.setLectureInformation(info);
        }

        public void BeginLecture(Lecture lec) {
            if (isInLecture == false) {
                isInLecture = true;
                this.lecture = lec;
                Broadcast(lec, this.speech);
            }
        }

        public Lecture getLecture() {
            return this.lecture;
        }

        public bool getLectureStatus() {
            return this.isInLecture;
        }
    }
}