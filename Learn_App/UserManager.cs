using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Learn_App
{
    public class UserManager
    {
        private readonly string filePath = "users.csv";
        private readonly List<User> users;

        public UserManager()
        {
            users = LoadUsers();
        }

        // Save all users to file
        public void SaveAllUsers() // Change from private to public
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    foreach (var user in users)
                    {
                        string userRecord = $"{user.Username},{user.Password},{user.ID},{user.Email},{user.Gender},{user.Points}";
                        sw.WriteLine(userRecord);
                    }
                }
            }
            catch (IOException ex)
            {
                // Log the exception (implementation depends on your logging framework)
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        // Load users from file
        private List<User> LoadUsers()
        {
            List<User> loadedUsers = new List<User>();
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] userDetails = line.Split(',');
                            User user = new User(userDetails[0], userDetails[1], userDetails[2], userDetails[3], userDetails[4], int.Parse(userDetails[5]));
                            loadedUsers.Add(user);
                        }
                    }
                }
                catch (IOException ex)
                {
                    // Log the exception (implementation depends on your logging framework)
                    Console.WriteLine("Error reading from file: " + ex.Message);
                }
            }
            return loadedUsers;
        }

        // Register a new user
        public void RegisterUser(string username, string password, string id, string email, string gender = null, int points = 0)
        {
            ValidateUsername(username);
            ValidatePassword(password);
            ValidateId(id);
            ValidateEmail(email);

            // Check if user already exists
            if (users.Any(u => u.Username == username))
            {
                throw new ArgumentException("Username already exists");
            }

            // Save the new user
            User newUser = new User(username, password, id, email, gender, points);
            users.Add(newUser);
            SaveAllUsers();
        }

        private void ValidateUsername(string username)
        {
            if (username.Length < 6 || username.Length > 8 || !username.All(char.IsLetterOrDigit) || username.Count(char.IsDigit) > 2)
            {
                throw new ArgumentException("Invalid username");
            }
        }

        private void ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 10 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(c => "!#$".Contains(c)))
            {
                throw new ArgumentException("Invalid password");
            }
        }

        private void ValidateId(string id)
        {
            if (id.Length != 9)
            {
                throw new ArgumentException("Invalid ID");
            }
        }

        private void ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Invalid email");
            }
        }

        // Authenticate an existing user
        public User AuthenticateUser(string username, string password)
        {
            // Check if the user exists based on the username
            User user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username");
            }
            if (!user.VerifyPassword(password))
            {
                throw new UnauthorizedAccessException("Invalid password");
            }

            return user;
        }

        // Update user's points
        public void UpdateUserPoints(User user, int pointsToAdd)
        {
            var existingUser = users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser != null)
            {
                existingUser.Points += pointsToAdd;
                SaveAllUsers();
            }
        }

        // Update user details
        public void UpdateUser(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser != null)
            {
                existingUser.Password = user.Password;
                existingUser.Email = user.Email;
                existingUser.Gender = user.Gender;
                existingUser.Points = user.Points;
                SaveAllUsers();
            }
        }
    }
}
