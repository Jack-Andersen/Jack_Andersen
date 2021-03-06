﻿using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;

namespace Noodle_chat
{
    class Database
    {
        public static void SetupSQLServer()
        {
            try
            {
                SQLet.Execute(@" CREATE TABLE UserID_for_chat(
                    UserID int primary key IDENTITY(1,1) NOT NULL,
                    UserName nvarchar(32) NOT NULL
                ");

                // FK_user_message = imptementere referenceintegritet.

                SQLet.Execute(@" CREATE TABLE Messages_for_chat(
                    MessagesID int primary key IDENTITY(1,1) NOT NULL,
                    MessagesDate datetime NOT NULL DEFAULT GETDATE(),
                    MessagesText text NOT NULL, 
                    MessagesUserID int CONSTRAINT FK_user_message FOREIGN KEY (MessagesUserID)
                    REFERENCES UserID_for_chat
                    ON DELETE Cascade
                    ON UPDATE Cascade
                ");

                SQLet.Execute(@"CREATE VIEW Noodle_Info AS
                    SELECT MessagesID, MessagesUserID, MessagesText, MessagesDate, sender.UserName, 
                    recipient.UserID AS recipientID, recipient.UserName AS recipient FROM Messages_for_chat
                    INNER JOIN UserID_for_chat AS sender
                    ON Messages_for_chat.MessagesUserID = sender.UserID
                    LEFT JOIN UserID_for_chat as recipient ON Messages_for_chat.recipientID = recipient.UserID");
            }
            catch(Microsoft.Data.SqlClient.SqlException)
            {

            }
        }     

        public static List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            Result result = SQLet.GetResult($@"SELECT * FROM Noodle_Info 
                WHERE (recipientID = 0 OR recipientID IS NULL)
                OR recipientID = {User.CurrentUserID}
                OR MessagesUserID = {User.CurrentUserID}");
            int number = 0;
            foreach (var row in result)
            {
                // parser teksten MessagesUserID om til et tal.
                int.TryParse(row["MessagesUserID"], out number);

                //opretter en instans af MessagesText.
                Message msg = new Message(row["MessagesText"], number);

                //Sætter datoen på instansen til samme dato som fra databasen.
                msg.MessagesDate = DateTime.Parse(row["MessagesDate"]);

                //parser teksten fra MessagesID om til et tal og lægger det i number.
                int.TryParse(row["MessagesID"], out number);
                msg.MessagesID = number;// putter tallet fra number over i MassagesID på instans

                //sæt propertien User til en bruger instans
                int.TryParse(row["MessagesID"], out number);
                msg.Sender = new User(number ,row["UserName"]);

                int.TryParse(row["recipientID"], out number);
                msg.Recipient = new User(number, row["recipient"]);

                //Tilføj msg til listen.
                messages.Add(msg); 

            }

            return messages;

        }

        public static List<User> GetUsers()
        {
            List<User> user = new List<User>();

            Result result;

            try
            {
                result = SQLet.GetResult("SELECT UserID, UserName FROM UserID_for_chat");
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                Logger.WriteToFile(e);
                    return new List<User>();
            }
            int number = 0;
            foreach (var row in result)
            {
                // parser teksten MessagesUserID om til et tal.
                int.TryParse(row["UserID"], out number);

                //opretter en instans af MessagesText.
                User loginUser = new User ( number, row["UserName"]);

                //Tilføj msg til listen.
                user.Add(loginUser);
            }

            return user;

        }

        public static void InsertUser(string UserName)
        {
            string SQL = @"
            INSERT INTO UserID_for_chat (UserName)
            VALUES ('{0}')";
            string formattet = string.Format(SQL, UserName);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        public static void InsertMessage(string MessagesText, int MessagesUserID, int recipientID = 0)
        {
            string SQL = @"
            INSERT INTO Messages_for_chat (MessagesText, MessagesUserID, MessagesDate, recipientID)
            VALUES ('{0}', {1}, '{2}', {3})";
            string formattet = string.Format(SQL, MessagesText, MessagesUserID, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), recipientID);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        public static User GetUserByLogin(string username)
        {

            Result result;

            string sql = "";
            username = username.Replace("'", "\'");
            sql = string.Format("SELECT UserID, UserName FROM UserID_for_chat WHERE UserName = '{0}'", username);
            try
            {
                result = SQLet.GetResult(sql);
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                Logger.WriteToFile(e);
                return null;
            }

            if (result.Count == 0)
            {
                return null;
            }
            User user = new User(int.Parse(result[0]["UserID"]), result[0]["UserName"]);
            return user;
        }
        
        public static User GetUser(int userID)
        {
            string sql = "";
            sql = string.Format("SELECT UserID, UserName FROM UserID_for_chat WHERE UserID = '{0}'", userID);
            Result result = SQLet.GetResult(sql);
            if (result.Count == 0)
            {
                return null;
            }
            User user = new User(int.Parse(result[0]["UserID"]), result[0]["UserName"]);
            return user;
        }
    }
}
