namespace training_exam_app.Concrete
{
    class User
    {
        public int Id { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string RecoverKey { get; set; }
    }
}
