﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesosin3
{
    public static class Global
    {
        public static void CheckItemDate()
        {
            using (Session3Entities entities = new Session3Entities())
            {
                DateTime date = new DateTime(2017, 02, 19).Date;
                var items = entities.Items.Where(t => t.ItemPrices.Any(x => x.Date <= date)).ToList();
                if (items.Count > 0)
                {
                    throw new Exception($"No property or listing should have availabilities before 19/02/2017." +
                        $"{Environment.NewLine}Error Data : {String.Join(Environment.NewLine, items.Select(t => $"Item ID: {t.ID}"))}");
                }
            }
        }


        public static void CheckScore()
        {
            using (Session3Entities entities = new Session3Entities())
            {
                var itemsScore = entities.ItemScores.Where(t => t.Value > 5 || t.Value < 0).ToList();
                if (itemsScore.Count > 0)
                {
                    throw new Exception($"No score associated with any of the properties or listings should have higher score than 5 and lower score than 0." +
                        $"{Environment.NewLine}Error Data: {String.Join(Environment.NewLine, itemsScore.Select(t => $"ItemScoreId : {t.ID}  Value : {t.Value}" ))}");
                }
            }
        }


        public static Users Register(string username, string fullname,
          string password, DateTime birthday, int numberOfFamily, bool gender)
        {
            using (Session3Entities entities = new Session3Entities())
            {
                var user = entities.Users.SingleOrDefault(t => t.Username == username);
                if (user != null)
                {
                    throw new ArgumentException("Username is exists.");
                }
                if (password.Length < 5)
                {
                    throw new ArgumentException("Password length need least five.");
                }
                user = entities.Users.Add(new Users
                {
                    GUID = Guid.NewGuid(),
                    Username = username,
                    Password = password,
                    BirthDate = birthday,
                    FullName = fullname,
                    FamilyCount = numberOfFamily,
                    Gender = gender,
                    UserTypeID = 2
                });
                entities.SaveChanges();
                return user;
            }
        }
    }
}
