namespace lab4.Services;

using System;

public class SmsSender
{
    private readonly string _sender;

    public SmsSender(string sender)
    {
        _sender = sender;
    }

    public void Send(string phoneNum, string title, string message)
    {
        Console.WriteLine($"Sent SMS from {_sender} to {phoneNum} with title {title} that says {message}");
    }
}
