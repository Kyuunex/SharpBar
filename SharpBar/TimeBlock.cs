namespace SharpBar;

public class TimeBlock
{
    public static BlankBlock GetBlock()
    {
        DateTime now = DateTime.Now;
        
        var timeblock = new BlankBlock
        {
            name = "time",
            full_text = now.ToString("F")
        };
        
        return timeblock;
    }
}
