using System;

namespace SharpBar;

public class CPUTemperatureModule
{
    public static Block GetBlock()
    {
        string SensorPath = "/sys/class/hwmon/hwmon1/temp1_input";
        
        string SensorValueString = System.IO.File.ReadAllText(SensorPath);
        
        int TempCMILL = Int32.Parse(SensorValueString);

        float tempC = TempCMILL / 1000;
        
        var temperatureblock = new Block
        {
            name = "cpu_temperature",
            full_text = "CPU TEMP: " + tempC.ToString() + " °C"
        };
        
        return temperatureblock;
    }
}