using System.Text.Json;

namespace SharpBar;

public class TimeBlock
{
    public static string GetJson()
    {
        DateTime now = DateTime.Now;
        
        var timeblock = new BlankBlock
        {
            name = "time",
            full_text = now.ToString("F")
        };
        
        return JsonSerializer.Serialize(timeblock);
    }
}
