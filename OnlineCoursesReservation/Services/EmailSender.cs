using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace OnlineCoursesReservation.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "jakihop889@gmail.com";
            var password = "iklssketklgitjpm";

            var message = new MailMessage();
            message.From = new MailAddress(fromMail, "مركز خدمة المجتمع");
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body style=\"text-align: center; direction: rtl; font-family: Arial, sans-serif;\">{htmlMessage}<html><body>";
            message.IsBodyHtml = true;



            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, password),
                EnableSsl = true
            };

            smtpClient.Send(message);
        }
    }
}
