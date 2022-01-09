using System.Text.Json;

namespace SharpBar;

public class CPUTemperatureBlock
{
    public static string GetJson()
    {
        string SensorPath = "/sys/class/hwmon/hwmon1/temp1_input";
        
        string SensorValueString = System.IO.File.ReadAllText(SensorPath);
        
        int TempCMILL = Int32.Parse(SensorValueString);

        float tempC = TempCMILL / 1000;
        
        var temperatureblock = new BlankBlock
        {
            name = "cpu_temperature",
            full_text = "CPU TEMP: " + tempC.ToString() + " C"
        };
        
        return JsonSerializer.Serialize(temperatureblock);
    }
}