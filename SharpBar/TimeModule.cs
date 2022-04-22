using System;

namespace SharpBar;

public class TimeModule
{
    public static Module GetBlock()
    {
        DateTime now = DateTime.Now;
        
        var timeblock = new Module
        {
            name = "time",
            full_text = now.ToString("F")
        };
        
        return timeblock;
    }
}
