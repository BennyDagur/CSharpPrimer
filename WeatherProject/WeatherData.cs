using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    public class WeatherData
    {

        // public int MyProperty { get { this Is the value the Main file gets } set { This sets the value for what the Main file gets } }

        private double _temperature;
        public double Temperature { get { return _temperature; } set { 
            if(_scale == "C")
                {
                    if(value < -60)
                    {
                        throw new Exception("Temperature cannot be lower than -60, please Input a valid number");
                    } else if(value > 60)
                    {
                        throw new Exception("Temperature cannot be higher than 60, please Input a valid number");
                    } else
                    {
                        _temperature = value;
                    }
                } else if(_scale == "F")
                {
                    if(value < -76)
                    {
                        throw new Exception("Temperature cannot be lower than -76, please Input a valid number");
                    }
                    else if (value > 140)
                    {
                        throw new Exception("Temperature cannot be higher than 140, please Input a valid number");
                    }
                    else
                    {
                        _temperature = value;
                    }
                }
            } }

        private int _humidity;
        public int Humidity { get { return _humidity; } set { 
            if(value < 0)
                {
                    throw new Exception("Humidity cannot be lower than 0%, please Input a valid number");
                } else if(value > 100)
                {
                    throw new Exception("Humidity cannot be higher than 100%, please Input a valid number");
                } else
                {
                    _humidity = value;
                }
            } }

        private string _scale;
        public string Scale { get { return _scale; } set { 
            if(value.ToUpper() != "C" && value.ToUpper() != "F")
                {
                    throw new Exception("Scale must either be C for Celsius or F for Fahrenheit");
                } else
                {
                    _scale = value;
                }
            } 
        }
        public void Convert()
        {
            if(_scale == "C")
            {
                _scale = "F";
                _temperature = ((_temperature * 9 / 5) + 32);
            } else
            {
                _scale = "C";
                _temperature = ((_temperature - 32) * 5 / 9);
            }
        }
    }
}

/*;
namespace WeatherProject{
Challenge 2 
rite a class called WeatherData X
This class should store data for the current weather conditions. The data should include properties for
•   temperature x
•   humidity x
•   scale x    
The class should allow the user to set the current temperature to be anywhere between -60 or +60         
Celsius (-76 and 140 Fahrenheit). Should a temperature of higher or lower than this value be set the class should generate a message         
that states that a reading mistake must have been made since the value seems unrealistic. Humidity values should be allowed between 0% and 100%.     
The scale attribute should accept either ’C’ or ’F’ as its value.    
The class should have a method called Convert(). When the method is called the current scale should be changed from     
F to C or from C to F. The formula to convert between these values     are Celsius = (Fahrenheit – 32) 5/9 Fahrenheit = (Celsius 9/5) + 32.     
Add any code you deem necessary to ensure the data is robust.    Test the class using your own code.*
public class WeatherData
{
    public WeatherData()
    {
    }
    //  The class should allow the user to set the current temperature to be        
    //  anywhere between -60 or +60 Celsius(-76 and 140 Fahrenheit).        
    private double _temperature;
    public double Temperature
    {
        get
        {
            return _temperature;
        }
        set
        {
            if (_scale == "c")
            {
                if (value >= -60 && value <= 60)
                {
                    _temperature = value;
                }
                else
                {
                    throw new Exception("Temperature out of bounds");
                }
            }
            else
            {
                if (value >= -76 && value <= 140)
                {
                    _temperature = value;
                }
                else
                {
                    throw new Exception("Temperature out of bounds");
                }
            }
            _temperature = value;
        }
    }
    //  Humidity values should be allowed between 0% and 100%.         private int _humidity;
    public int Humidity
    {
        get
        {
            return _humidity;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Humidity cannot be below zero.");
                   // Console.WriteLine("Humidity cannot be below zero.");                }
                else if (value > 100)
                {
                    Console.WriteLine("Humidity cannot be above 100.");
                }
                else
                {
                    _humidity = value;
                }
            }
        }
        private string _scale;
    public string Scale
    {
        get { return _scale; }
        set
        {
            string test = value;
            if (value.ToLower() == "c" || value.ToLower() == "f")
            {
                _scale = value.ToLower();
            }
            else
            {
                throw new Exception("Must be c or f");
            }
        }
    }
    public void Convert()
    {
        if (_scale == "c")
        {
            _scale = "f";
            // Fahrenheit = (Celsius 9/5) + 32                _temperature = (_temperature * 9 / 5) + 32;
        }
        else
        {
            // Celsius = (Fahrenheit – 32) 5/9                _scale = "c";
            _temperature = (_temperature - 32) * 5 / 9;
        }
    }
}
}
 * */