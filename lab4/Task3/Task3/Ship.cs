using System;

namespace Task3
{
    public class Ship
    {
        protected String name;
        protected String appointment;
        protected Double power;
        protected String typeOfFuel;
        
        public string Name
            {
                get => name;
                set => name = value;
            }

        public string Appointment
            {
                get => appointment;
                set => appointment = value;
            }

            public Double Power
            {
                get => power;
                set => power = value;
            }

            public string TypeOfFuel
            {
                get => typeOfFuel;
                set => typeOfFuel = value;
            }

            protected Ship(string name, string appointment, Double power, string typeOfFuel)
            {
                this.name = name;
                this.appointment = appointment;
                this.power = power;
                this.typeOfFuel = typeOfFuel;
            }

            public override string ToString()
            {
                return $"{nameof(name)}: {name},\n{nameof(appointment)}: {appointment},\n{nameof(power)}: {power},\n{nameof(typeOfFuel)}: {typeOfFuel}";
            }
    }
    }
