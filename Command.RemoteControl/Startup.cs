using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Startup
    {
        public static void Main()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            //Command Pattern Receivers
            Light light = new Light("Kitchen");
            GarageDoor garageDoor = new GarageDoor("");

            //Commands for the receivers
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorUpCommand garageDoorOpen =
                new GarageDoorUpCommand(garageDoor);

            //Passing the light on command to the invoker
            remote.SetCommand(lightOn);
            //Simulate the button being pressed on the invoker
            Console.WriteLine(remote.ButtonWasPressed());

            //Passing the garage door open command to the invoker
            remote.SetCommand(garageDoorOpen);
            //Simulate the button being pressed on the invoker
            Console.WriteLine(remote.ButtonWasPressed());

            /////////////////////////////////////////////////

            //Command Pattern Invoker
             Remote remote2 = new Remote();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
             garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn =
                new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff =
                new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn =
                new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff =
                new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn =
                new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff =
                new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp =
                new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown =
                new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD =
                new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff =
                new StereoOffCommand(stereo);

            remote2.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote2.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote2.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote2.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote2.OnButtonWasPushed(0));
            Console.WriteLine(remote2.OffButtonWasPushed(0));

            Console.WriteLine(remote2.OnButtonWasPushed(1));
            Console.WriteLine(remote2.OffButtonWasPushed(1));
            Console.WriteLine(remote2.OnButtonWasPushed(2));
            Console.WriteLine(remote2.OffButtonWasPushed(2));
            Console.WriteLine(remote2.OnButtonWasPushed(3));
            Console.WriteLine(remote2.OffButtonWasPushed(3));
        }
    }
