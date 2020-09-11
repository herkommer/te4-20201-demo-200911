using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo200911
{
    class Program
    {
        static void Main(string[] args)
        {
            //vi vill se hur vi kan skapa en biluthyrningsapplikation
            //substantiv är CAR, CUSTOMER
            //aha, vi behöver en CLASS för att kunna skapa unika OBJECT

            //Klassen är en DATATYP

            Car myCar;
            //För att använda en klass behöver den instansieras
            //då blir den ett UNIKT Objekt
            //som vi kan använda i vårt program

            myCar = new Car();

            myCar.Color = "black";
            myCar.Make = "Volvo";
            myCar.Model = "V70";

            Console.WriteLine($"We offer you a {myCar.Color} {myCar.Make} {myCar.Model}");

            //
            //Car mySecondCar = new Car();
            Car mySecondCar = new Car() { Make = "Audi", Model = "Q3", Color = "White" };

            //Om vi vill hantera flera bilar, behöver vi spara dem i någon typ av struktur
            //ett annat ord är repository
            //ex en Array, ex List av Car

            List<Car> myCarCollection = new List<Car>();

            myCarCollection.Add(myCar);
            myCarCollection.Add(mySecondCar);

            myCar.Make = "BMW";

            foreach (Car item in myCarCollection)
            {
                Console.WriteLine(item.Make);
            }

            Console.WriteLine();
            //Skriv endast ut Audi-bilar
            //Vi introducerar LAMBA, ARROW-Syntax och LINQ
            //Var kommer X ifrån?
            //Vi jobbar på den collectionen med bilar som vi har
            //X syftar på den första bilen i collection
            //och automagiskt kommer X gå igen varje bil i ordning
            //FindAll vill veta vad den ska titta efter
            //vi skriver då kolla varje enskild bil och om
            //bilens Make är Audi, då ska du ta med den, annars ignorera

            myCarCollection.Add(new Car() { Make="Audi" });

            foreach (Car item in myCarCollection.FindAll(x => x.Make == "Audi"))
            {
                Console.WriteLine(item.Make);
            }

        }
    }

    class Car
    {
        //Egenskaper, PROPERTIES
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }
}
