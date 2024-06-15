using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Personal_Organizer
{
    public class CsvHelper
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "User_Infos.txt");

        public CsvHelper()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Id,Name,Surname,PhoneNumber,Address,Email,Password,Authority,Salary\n");
            }
        }

        public bool RegisterUser(UserInfo user)
        {
            var users = GetAllUsers();
            if (users.Any(u => u.Email == user.Email))
            {
                return false;
            }

            user.Id = GetNextUserId(users).ToString();
            user.Authority = users.Count == 0 ? "admin" : "user";

            // If the user is part-time, adjust the salary
            if (user.Authority == "part-time user")
            {
                user.Salary /= 2;
            }

            var userLine = $"{user.Id},{user.Name},{user.Surname},{user.PhoneNumber},{user.Address},{user.Email},{user.Password},{user.Authority},{user.Salary}\n";
            File.AppendAllText(filePath, userLine);
            return true;
        }

        public int GetNextUserId(List<UserInfo> users)
        {
            return users.Count == 0 ? 1 : users.Max(u => int.Parse(u.Id)) + 1;
        }

        public UserInfo ValidateUser(string email, string password)
        {
            var users = GetAllUsers();
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public List<UserInfo> GetAllUsers()
        {
            var users = new List<UserInfo>();
            var lines = File.ReadAllLines(filePath).Skip(1);
            foreach (var line in lines)
            {
                var values = line.Split(',');
                double salary;
                double.TryParse(values[8], out salary);
                var user = new UserInfo
                {
                    Id = values[0],
                    Name = values[1],
                    Surname = values[2],
                    PhoneNumber = values[3],
                    Address = values[4],
                    Email = values[5],
                    Password = values[6],
                    Authority = values[7],
                    Salary = salary
                };
                users.Add(user);
            }
            return users;
        }

        public void UpdateUser(UserInfo updatedUser)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Surname = updatedUser.Surname;
                user.PhoneNumber = updatedUser.PhoneNumber;
                user.Address = updatedUser.Address;
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password;
                user.Authority = updatedUser.Authority;
                user.Salary = updatedUser.Salary;

                var userLines = users.Select(u => $"{u.Id},{u.Name},{u.Surname},{u.PhoneNumber},{u.Address},{u.Email},{u.Password},{u.Authority},{u.Salary}\n");
                File.WriteAllText(filePath, "Id,Name,Surname,PhoneNumber,Address,Email,Password,Authority,Salary\n" + string.Join("", userLines));
            }
        }

        public void UpdateUsers(List<UserInfo> users)
        {
            var userLines = users.Select(u => $"{u.Id},{u.Name},{u.Surname},{u.PhoneNumber},{u.Address},{u.Email},{u.Password},{u.Authority},{u.Salary}\n");
            File.WriteAllText(filePath, "Id,Name,Surname,PhoneNumber,Address,Email,Password,Authority,Salary\n" + string.Join("", userLines));
        }

        public void DeleteUser(string userId)
        {
            var users = GetAllUsers();
            var userToRemove = users.FirstOrDefault(u => u.Id == userId);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                UpdateUsers(users);
            }
        }

        public void UpdateUserPassword(string email, string newPassword)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            for (int i = 1; i < lines.Count; i++)
            {
                var columns = lines[i].Split(',');
                if (columns[5] == email)
                {
                    columns[6] = newPassword;
                    lines[i] = string.Join(",", columns);
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}
