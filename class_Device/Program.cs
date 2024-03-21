namespace class_Device
{
    class Device
    {
        protected string name;
        protected string characteristics;

        public Device(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Устройство издает звук");
        }

        public void Show()
        {
            Console.WriteLine("Название устройства: " + name);
        }

        public void Desc()
        {
            Console.WriteLine("Описание устройства: " + characteristics);
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Чайник издает шипящий звук");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Микроволновка издает звук гудения");
        }
    }

    class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Автомобиль издает звук двигателя");
        }
    }

    class Ship : Device
    {
        public Ship(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Пароход издает звук свистка");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle("Чайник", "Вместимость: 1.7 л");
            kettle.Show();
            kettle.Desc();
            kettle.Sound();

            Microwave microwave = new Microwave("Микроволновка", "Мощность: 900 Вт");
            microwave.Show();
            microwave.Desc();
            microwave.Sound();

            Car car = new Car("Автомобиль", "Максимальная скорость: 200 км/ч");
            car.Show();
            car.Desc();
            car.Sound();

            Ship ship = new Ship("Пароход", "Грузоподъемность: 1000 тонн");
            ship.Show();
            ship.Desc();
            ship.Sound();

            Console.ReadLine();
        }
    }

}
