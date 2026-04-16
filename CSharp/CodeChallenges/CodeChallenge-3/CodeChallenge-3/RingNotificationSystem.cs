using System;

namespace CodeChallenge_3
{
    internal class RingNotificationSystem
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            Console.WriteLine("---------------------");
            Console.Write("Incoming call Received\n");
            Console.WriteLine("---------------------");

            if (OnRing != null)
            {
                OnRing();
            }
        }
    }

    internal class RingtonePlayer
    {
        public void PlayRingtone()
        {
            Console.WriteLine("\nPlaying ringtone...");
        }
    }

    internal class ScreenDisplay
    {
        public void ShowCallerInfo()
        {
            Console.WriteLine("Displaying caller info...");
        }
    }

    internal class VibrationMotor
    {
        public void Vibrate()
        {
            Console.WriteLine("Phone is vibrating...");
        }
    }

    internal class Mobile
    {
        static void Main(string[] args)
        {
            RingNotificationSystem phone = new RingNotificationSystem();

            RingtonePlayer ringtone = new RingtonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vibration = new VibrationMotor();

            phone.OnRing += ringtone.PlayRingtone;
            phone.OnRing += screen.ShowCallerInfo;
            phone.OnRing += vibration.Vibrate;

            phone.ReceiveCall();

            Console.ReadLine();
        }
    }
}