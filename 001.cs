namespace Naruto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("建立5位英雄角色!!!");
            int i;
            for(i = 1;i <= 5;i++)
            {
                Hero myHero = new Hero();  //  //產生一個Hero類別，名稱叫myHero，概念如int X，賦予myHero一個記憶體空間
                Console.WriteLine($"{Environment.NewLine}這是第{i}筆輸入資料");
                Console.WriteLine("請輸入角色名字：");
                myHero.name = Console.ReadLine();
                Console.WriteLine("請輸入角色的村莊：  (木葉村、沙忍村、雷忍村、岩忍村、水忍村)");
                myHero.country = Console.ReadLine();
                Console.WriteLine("請輸入角色的年紀：");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("請輸入有效的年紀(整數數字)：");
                }
                myHero.age = age;
                Console.WriteLine($"{Environment.NewLine}");
                myHero.print();
                myHero.attack();
                Console.WriteLine($"{Environment.NewLine}");
            }
            Console.Write($"{Environment.NewLine}請按任意鍵離開程式...");
            Console.ReadKey(true);
        }
    }

    class Hero
    {
        public string? name;
        public string? country;
        public int age;

        public Hero()
        {
            name = "";
            country = "";
            age = 0;
        }

        // 傳遞參數的方法
        public void life(string name, int age)
        {
            Console.WriteLine($"{name}的年紀是 {age} 歲");
        }

        // 不傳遞參數的方法
        public void attack()
        {
            Console.WriteLine($"{name}  使出招式了!!!");
        }

        // 印出所有 Hero 的屬性
        public void print()
        {
            Console.WriteLine($"英雄叫做：{name}");
            Console.WriteLine($"英雄屬於：{country}");
            Console.WriteLine($"英雄的年紀是：{age} 歲");
        }
    }
}