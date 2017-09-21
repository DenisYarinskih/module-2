using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль_два_оригинал
{
    class Inven
    {
        
        public string Name;
        public int Price;

        public Inven(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string ShowInformation()
        {
            return Name + " " + Price;
        }
    }


    class BicecleMountain : Inven
    {
        public string Speed;

        public BicecleMountain(string name, int price, string speed) : base(name, price)
        {
            Speed = speed;
        }


        public override string ShowInformation()
        {                        
            return base.ShowInformation() + " "+ Speed;
        }
    }


    class Ball : Inven
    {
        public string Type;

        public Ball(string name, int price, string type) : base(name, price)
        {
            Type = type;
        }


        public override string ShowInformation()
        {            
            return base.ShowInformation() + " " + Type;
        }
    }

    class Library
    {
        public Inven[] shop;

        public Library()
        {
            shop = new Inven[] { };
        }
                
        public void ShowAllInvent()
        {
            Console.Clear();
            if (shop.Length == 0)
            {
                Console.WriteLine("массив пустой");

                Console.WriteLine("введите 1 если хотите добавить инвентарь");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    AddInvent();
                }
            }
            else
            {
                for (int i = 0; i < shop.Length; i++)
                {
                    Console.WriteLine(shop[i].ShowInformation());
                }
            }
            
        }

        public void ShowInventByType()
        {
            Console.Clear();
            
            if (shop.Length == 0)
            {
                Console.WriteLine("массив пустой");

                Console.WriteLine("введите 1 если хотите добавить инвентарь");
                int a = int.Parse(Console.ReadLine());
                if(a == 1)
                {
                    AddInvent();
                }
            }
            else
            {
                Console.Clear();
                int count = 0;
                Console.WriteLine("введи 0 для просмотра мячей и 1 для просмотра велосипедов");
                string name = Console.ReadLine();
                if (name == "0")
                {
                    for (int i = 0; i < shop.Length; i++)
                    {
                        if (shop[i] is Ball)
                        {
                            count++;
                            Console.WriteLine(shop[i].ShowInformation());
                            break;
                        }                        
                    }
                    if(count == 0)
                    {
                        Console.WriteLine("такой тип не найден");
                    }
                }
                else if(name == "1")
                {
                    for(int i = 0; i < shop.Length; i++)
                    {
                        if (shop[i] is BicecleMountain)
                        {
                            count++;
                            Console.WriteLine(shop[i].ShowInformation());
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("такой тип не найден");
                    }
                }
            }
        }

        public void ShowChoice()
        {
            Console.Clear();

            Console.WriteLine("введи 0 для просмотра всего инвентаря , либо 1 для выборки");
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                ShowAllInvent();
            }
            else
                ShowInventByType();
        }

        public void AddInvent()
        {
            Console.Clear();

            Inven[] newshop = new Inven[shop.Length + 1];

            Console.WriteLine("что вы хотите добавить");
            string something = Console.ReadLine();
                                   
            if (something == "велосипед")
            {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();
                Console.WriteLine("price: ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("speed: ");
                string speed = Console.ReadLine();

                for (int i = 0; i < shop.Length; i++)
                {
                    newshop[i] = shop[i];
                }

                newshop[newshop.Length - 1] = new BicecleMountain(name, price, speed);
                shop = newshop;

            }

            else if(something == "мяч")
            {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();
                Console.WriteLine("price: ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("type: ");
                string type = Console.ReadLine();

                for (int i = 0; i < shop.Length; i++)
                {
                    newshop[i] = shop[i];
                }

                newshop[newshop.Length - 1] = new Ball(name, price, type);
                shop = newshop;
                

            }          
          
        }

        public void DeleteInven()
        {
            Console.Clear();

            Inven[] newdelshop = new Inven[] { };
           
            if (shop.Length == 0)
            {
                Console.WriteLine("нету элементов для удаления");

            }

            else  
            {
                Console.Clear();

                Console.WriteLine("функция недоступна");

                //Console.WriteLine("введите 0 если хотите удалить мячи , либо 1 для удаления велосипедов");
                //int deletsomething = int.Parse(Console.ReadLine());

                //if(deletsomething == 0)
                //{
                //    Console.WriteLine("введите 0 если хотите удалить все мячи , либо 1 для удаления конкретного мяча");
                //    int a = int.Parse(Console.ReadLine());
                //    if(a == 0)
                //    {

                //    }
                //    else if(a == 1)
                //    {

                //    }
                //}

                //else if(deletsomething == 1)
                //{
                //    Console.WriteLine("введите 0 если хотите удалить все велосипеды , либо 1 для удаления конкретного велосипеда");
                //    int b = int.Parse(Console.ReadLine());
                //    if (b == 0)
                //    {

                //    }
                //    else if (b == 1)
                //    {

                //    }
                //}

                //int countj = 0;
                //for (int i = 0; i < shop.Length; i++)
                //{                    
                //        newdelshop[i] = shop[i];
                //        countj += 1;                    
                //}

                
                //shop = newdelshop;

            }
        }
        
    }    

    class Menu
    {
        public Library library;
        
        public Menu()
        {
            library = new Library();
        }

        public void InvenMenu()
        {
            Console.Clear();
            Console.WriteLine("введите 1 что бы посмотреть список всего инвентаря");
            Console.WriteLine("введите 2 что бы добавить новый инвентарь");
            Console.WriteLine("введите 3 что бы удалить инвентарь");         
            Console.WriteLine("нажмите 4 для выхода");

            string ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    library.ShowChoice();
                    Console.WriteLine("введите ноль если хотите вернуться в меню");
                    string a = Console.ReadLine();
                    if (a == "0")
                    {
                        InvenMenu();
                    }
                    break;
                case "2":                    
                    library.AddInvent();
                    Console.WriteLine("введите ноль если хотите вернуться в меню");
                    string b = Console.ReadLine();
                    if (b == "0")
                    {
                        InvenMenu();
                    }
                    break;
                case "3":
                    library.DeleteInven();
                    Console.WriteLine("введите ноль если хотите вернуться в меню");
                    string c = Console.ReadLine();
                    if (c == "0")
                    {
                        InvenMenu();
                    }
                    break;                
                case "4":
                    Exit exit = new Exit();
                    exit.exit();
                    break;
                default:
                    Console.WriteLine("unklare Nummer");
                    break;
            }
        }
    }

    class Exit
    {
        public string exit()
        {
            string a = "enter the enter";
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.InvenMenu();

            Console.Read();            
        }
    }
}
