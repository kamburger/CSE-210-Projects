using System;

class Program
{
    static void Main(string[] args)
    {
        User testUser = new User("KamKam");
        testUser.UploadGoals();
        testUser.ListGoals();
    }
}