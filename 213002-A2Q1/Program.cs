using System;
class Program
{
    static void Main(string[] args)
    {
        //Q1-a) Testing the run method
        ElectronicPhone obj = new ElectronicPhone();
        obj.Run();
       //Q1-b) Overriding the ring method
        obj.Ring("Please pick up my phone!");
        //Q1-c)
        TalkingPhone talkingPhone = new TalkingPhone();
        talkingPhone.Ring();
        DigitalPhone digitalPhone = new DigitalPhone();
        digitalPhone.Ring();
    }
}

public abstract class Telephone
{
    protected string Phonetype { get; set;}

    public Telephone()
    {
        Phonetype = string.Empty;
    }

    public Telephone(string phonetype)
    {
        Phonetype = phonetype;
    }

    public void Ring()
    {
        //implementation in concrete classes
    }
}

public class ElectronicPhone : Telephone
{
    public ElectronicPhone()
    {
        Phonetype = "Digital";
    }
    //Q1-a
    public void Run()
    {
        this.Ring();
    }
    //Q1-b
    public void Ring(string s)
    {
        Console.WriteLine($"Ringing the {Phonetype} and sending this message: {s}.");
    }
}

public class DigitalPhone : Telephone
{
    public DigitalPhone()
    {
        this.Phonetype = "Digital";
    }

    public void Ring() 
    {
        Console.WriteLine($"Ringing the {Phonetype} phone!");
    }

}

public class TalkingPhone : Telephone
{
    public TalkingPhone()
    {
        this.Phonetype = "Talking";
    }

    public void Ring() 
    {
        Console.WriteLine($"Ringing the {Phonetype} phone.");
    }
}