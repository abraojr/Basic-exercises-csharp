namespace Exercise_032_Renting_a_pension
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
