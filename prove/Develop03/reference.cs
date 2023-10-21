using System;
public class Reference
{
    private string _refernce = "Acts 7:55-56";
    private string _verse = "55 But he, being full of the Holy Ghost, looked up steadfastly into heaven, and saw the glory of God, and Jesus standing on the right hand of God, 56 And said, Behold, I see the heavens opened, and the Son of man standing on the right hand of God";

    public string GetVerse()
    {
        return _verse;
    }

    public string GetReference()
    {
        return _refernce;
    }
}