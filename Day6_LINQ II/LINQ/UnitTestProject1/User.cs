namespace UnitTestProject1
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"[Name: {Name}; Age: {Age}; Salary: {Salary}; Gander: {Gender};]";
        }

        public override bool Equals(object obj)
        {
            var userObj = obj as User;
            if (userObj == null)
                return false;

            return Name == userObj.Name && Age == userObj.Age && Salary == userObj.Salary && Gender == userObj.Gender;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}
