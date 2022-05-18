using System;

namespace SharpBar;

public class TimeModule
{
    public static Block GetBlock()
    {
        DateTime now = DateTime.Now;
        
        var timeblock = new Block
        {
            name = "time",
            full_text = now.ToString("F")
        };
        
        return timeblock;
    }
}
