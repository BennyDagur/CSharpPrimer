/* This Is not the way to do this
 * 
 * class Program
{
    class WeatherData
    {
        int temperature;
        int humidity;
        string scale;

        static void Convert(int minValue, int maxValue, string scaleValue)
        {
            var wi = new WeatherData();
            wi.scale = scaleValue;
            string yOrN;

            bool tempCheck = true;
            bool humidCheck = true;
            bool conversionCheck = true;

            while (tempCheck)
            {
                Console.WriteLine($"Input temperature at or between {minValue} and {maxValue}");
                string tempValue = Console.ReadLine();
                if (int.TryParse(tempValue, out wi.temperature) && wi.temperature >= minValue && wi.temperature <= maxValue)
                {
                    while (humidCheck)
                    {
                        Console.WriteLine("Input humidity at or between 0% and 100%");
                        string humidValue = Console.ReadLine();
                        if (int.TryParse(humidValue, out wi.humidity) && wi.humidity >= 0 && wi.humidity <= 100)
                        {
                            humidCheck = false;
                            tempCheck = false;
                        }
                        else
                        {
                            Console.WriteLine("Humidity must be at or between 0% and 100%");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"You must have made a mistake, because only values at or between {minValue} and {maxValue} for this temperature system are valid");
                }
            }

            Console.WriteLine($"It Is {wi.temperature + wi.scale} outside with a humidity of {wi.humidity}%");

            while (conversionCheck)
            {
                Console.WriteLine($"Would you like to change from {wi.scale}? Enter Y for yes or N for no");
                yOrN = Console.ReadLine().ToLower();
                    if(yOrN == "y")
                {
                    if(wi.scale == "C")
                    {
                        wi.scale = "F";
                        wi.temperature = ((wi.temperature * 9/5) + 32);
                        Console.WriteLine($"It Is {wi.temperature + wi.scale} outside with a humidity of {wi.humidity}%");
                    } else if (wi.scale == "F")
                    {
                        wi.scale = "C";
                        wi.temperature = ((wi.temperature - 32) * 5/9);
                        Console.WriteLine($"It Is {wi.temperature + wi.scale} outside with a humidity of {wi.humidity}%");
                    }
                } else if(yOrN == "n")
                {
                    conversionCheck = false;
                } else
                {
                    Console.WriteLine("Repeat, enter Y for yes or N for no");
                }
            }
        }

        static void Main()
            {
                Console.WriteLine("Either enter 'C' for Celsius or 'F' for Fahrenheit");

                var wi = new WeatherData();

                bool check = true;

                while (check)
                {
                    wi.scale = Console.ReadLine().ToUpper();
                    if (wi.scale == "C" || wi.scale == "F")
                    {
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("I said either C for Celsius or F for Fahrenheit");
                    }
                }
                if (wi.scale == "C")
                {
                  Convert(-60, 60, wi.scale);
                }
                else if (wi.scale == "F")
                {
                  Convert(-76, 140, wi.scale);
                }
        }





             * I thought this wouldn't work not realizing I could fit In the logic
             
            static void Convert(int minValue, int maxValue, string scaleValue)
            {
                var wi = new WeatherData();
                wi.scale = scaleValue;

                bool tempCheck = true;
                bool humidCheck = true;

                    while (tempCheck)
                    {
                        Console.WriteLine($"Input temperature at or between {minValue} and {maxValue}");
                        wi.temperature = int.Parse(Console.ReadLine());
                        if (wi.temperature >= minValue && wi.temperature <= maxValue)
                        {
                            while (humidCheck)
                            {
                                Console.WriteLine("Input humidity at or between 0% and 100%");
                                wi.humidity = int.Parse(Console.ReadLine());
                                if (wi.humidity >= 0 && wi.humidity <= 100)
                                {
                                    humidCheck = false;
                                    tempCheck = false;
                                }
                                else
                                {
                                    Console.WriteLine("Humidity must be at or between 0% and 100%");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"You must have made a mistake, because only values at or between {minValue} and {maxValue} for this temperature system are valid");
                        }
                    }

                Console.WriteLine($"It Is {wi.temperature + wi.scale} outside with a humidity of {wi.humidity}%");
            }

            static void Main()
            {
                Console.WriteLine("Either enter 'C' for Celsius or 'F' for Fahrenheit");

                var wi = new WeatherData();

                bool check = true;

                while (check)
                {
                    wi.scale = Console.ReadLine().ToUpper();
                    if (wi.scale == "C" || wi.scale == "F")
                    {
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("I said either C for Celsius or F for Fahrenheit");
                    }
                }

                if(wi.scale == "C")
                {
                    Convert(-60, 60, wi.scale);
                } else if (wi.scale == "F")
                {
                    Convert(-76, 140, wi.scale);
                }
            }
            
        }
    }*/
        