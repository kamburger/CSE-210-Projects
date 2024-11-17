using System;

class Program
{
    static void Main(string[] args)
    {
        public abstract class SmartDevice
        {
            private string _name;
            private bool _isOn = false;
            private var _timeOn;

            public SmartDevice(string name)
            {
                _name = name;
            }

            public void TurnOn()
            {
                var _timeStart = DateTimeOffSet.UtcNow;
                _isOn = true;
            }
            public void TurnOff()
            {
                var _timeEnd = DateTimeOffSet.UtcNow;
                _timeOn = _timeEnd - _timeStart;
                Console.WriteLine($"The {_name} was on for {_timeOn}.");
                _isOn = false;
            }
            public void GetStatus()
            {
                if (!_isOn)
                {
                    Console.WriteLine($"The {_name} is currently off.");
                }
                else
                {
                    Console.WriteLine($"The {_name} is currently on.");
                }
            }
            public void OnLength()
            {
                if (_isOn)
                {
                    var _timeNow = DateTimeOffSet.UtcNow;
                    _timeOn = _timeNow - _timeStart;
                    Console.WriteLine($"{_name} has been on for {_timeOn}.");
                }
                else
                {
                    Console.WriteLine($"{_name} is not on.");
                }
            }
        } 
        
        public class SmartTV : SmartDevice
        {
            public SmartTV(string name) : base(name)
            {
            }
        }

        SmartTV test = new SmartTV("Living Room TV");
        test.TurnOn();
       // Thread.Sleep(2000);
        test.OnLength();
        test.TurnOff();

    }
}

