using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Learn_App
{
    public class UserManager
    {
        private string filePath = "users.csv";
        private List<User> users;

        public UserManager()
        {
            users = LoadUsers();
        }

        // Save user to file
        public void SaveUser(User user)
        {
            users.Add(user);
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                string userRecord = $"{user.Username},{user.Password},{user.ID},{user.Email},{user.Gender}";
                sw.WriteLine(userRecord);
            }
        }

        // Load users from file
        private List<User> LoadUsers()
        {
            List<User> loadedUsers = new List<User>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] userDetails = line.Split(',');
                        User user = new User(userDetails[0], userDetails[1], userDetails[2], userDetails[3], userDetails[4]);
                        loadedUsers.Add(user);
                    }
                }
            }
            return loadedUsers;
        }

        // Register a new user
        public void RegisterUser(string username, string password, string id, string email, string gender = null, int points = 0)
        {
            // Validate inputs
            if (username.Length < 6 || username.Length > 8 || !username.All(char.IsLetterOrDigit) || username.Count(char.IsDigit) > 2)
            {
                throw new ArgumentException("Invalid username");
            }

            if (password.Length < 8 || password.Length > 10 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(c => "!#$".Contains(c)))
            {
                throw new ArgumentException("Invalid password");
            }

            // Check if user already exists
            if (users.Any(u => u.Username == username))
            {
                throw new ArgumentException("Username already exists");
            }

            // Save the new user
            User newUser = new User(username, password, id, email, gender, points);
            SaveUser(newUser);
        }

        // Authenticate an existing user
        public User AuthenticateUser(string username, string password)
        {
            // Check if the user exists based on the username
            User user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                // User with the given username does not exist
                throw new UnauthorizedAccessException("Invalid username");
            }
            else
            if (user.Password != password)
            {
                // Password is incorrect
                throw new UnauthorizedAccessException("Invalid password");
            }

            // Return the user if both username and password are correct
            return user;
        }

    }
}
//Cde2#678