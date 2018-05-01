using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMSSENDER;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sendEmailSMS : MonoBehaviour {
    string message = "NULL";
	public Text mytext;
   
    public void sendText()
    {
        sendSMS smssender = new sendSMS();
        smssender.Send("+13522404231");
        Debug.Log("sent text!");
    }
    public void sendEmail ()
    {/*
		message = mytext.text;
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("vrforafrica.test1@gmail.com");
        mail.To.Add("vrforafrica.test2@gmail.com");
        mail.Subject = "TEST EMAIL";
        mail.Body = message;

        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("vrforafrica.test1@gmail.com", "vrforafrica") as ICredentialsByHost;
        smtp.EnableSsl = true;
        //smtpServer.EnableSsl = true; 
        ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
                    return true;
                };
        smtp.Send(mail);
        Debug.Log("Email.sent!");
        */
		SceneManager.LoadScene("AfterSendSMS");
        
    }
}
