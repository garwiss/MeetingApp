namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();


        static Repository()
        {
            _users.Add(new UserInfo() { Id=1, Name = "Ali", Email = "abc@gmail.com", Phone = "5456984525", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Ahmet", Email = "abcd@gmail.com", Phone = "5648985632", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Canan", Email = "abce@gmail.com", Phone = "5332380687", WillAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static  UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id==id);
        }


    }
}
