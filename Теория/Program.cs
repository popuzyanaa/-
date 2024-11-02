

////стейк

/*
using System;
using System.Collections.Generic;
using System.Linq;

class Recipe
{
    public string Name { get; set; }
    public int CookingTime { get; set; } // Время в минутах
    public List<string> Ingredients { get; set; }
    public int MeatRequired { get; set; } // Мясо в граммах

    public Recipe(string name, int cookingTime, List<string> ingredients, int meatRequired)
    {
        Name = name;
        CookingTime = cookingTime;
        Ingredients = ingredients;
        MeatRequired = meatRequired;
    }

    public override string ToString()
    {
        return $"{Name} (Время: {CookingTime} мин, Мясо: {MeatRequired} г)\nИнгредиенты: {string.Join(", ", Ingredients)}";
    }
}

class Program
{
    static void Main()
    {
        // Пример рецептов
        List<Recipe> recipes = new List<Recipe>
        {
            new Recipe("Жареная курица", 45, new List<string> { "Курица", "Соль", "Перец", "Масло" }, 1200),
            new Recipe("Тушеная говядина", 90, new List<string> { "Говядина", "Лук", "Морковь", "Специи" }, 1500),
            new Recipe("Суп из мяса", 60, new List<string> { "Мясо", "Картошка", "Морковь", "Лук" }, 1000),
            new Recipe("Котлеты", 30, new List<string> { "Фарш", "Хлеб", "Лук", "Яйцо" }, 800),
            new Recipe("Стейк с картошкой", 30, new List<string> { "Стейк", "Картошка", "Чеснок", "Масло" }, 500),
            new Recipe("Запеченная свинина", 120, new List<string> { "Свинина", "Специи", "Чеснок", "Лук" }, 2000),
            new Recipe("Мясные тефтели", 40, new List<string> { "Фарш", "Рис", "Лук", "Томаты" }, 600),
            new Recipe("Куриный суп", 50, new List<string> { "Курица", "Лук", "Морковь", "Специи" }, 800),
            new Recipe("Мясо по-французски", 60, new List<string> { "Говядина", "Картошка", "Лук", "Сыр" }, 1000),
            new Recipe("Шашлык", 90, new List<string> { "Свинина", "Лук", "Специи", "Масло" }, 1500),
            new Recipe("Паста с мясом", 25, new List<string> { "Фарш", "Макароны", "Томатный соус", "Специи" }, 400),
            new Recipe("Мясные рулеты", 70, new List<string> { "Фарш", "Грибы", "Лук", "Специи" }, 800),
            new Recipe("Кебаб", 45, new List<string> { "Мясо", "Лук", "Специи", "Пита" }, 600)
        };

        // Ввод данных
        Console.WriteLine("Введите количество мяса (кг или г):");
        string input = Console.ReadLine();
        double meatAmount = 0;

        // Обработка ввода
        if (input.EndsWith("кг", StringComparison.OrdinalIgnoreCase))
        {
            meatAmount = Convert.ToDouble(input.Replace("кг", "").Trim()) * 1000; // Перевод в граммы
        }
        else if (input.EndsWith("г", StringComparison.OrdinalIgnoreCase))
        {
            meatAmount = Convert.ToDouble(input.Replace("г", "").Trim());
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Укажите количество в кг или г.");
            return;
        }

        // Фильтрация по времени
        Console.WriteLine("Введите максимальное время приготовления (мин):");
        int maxCookingTime = Convert.ToInt32(Console.ReadLine());

        // Фильтрация по ингредиентам
        Console.WriteLine("Введите ингредиенты через запятую (или оставьте пустым):");
        string ingredientInput = Console.ReadLine();
        List<string> includedIngredients = ingredientInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                          .Select(i => i.Trim().ToLower()).ToList();

        // Поиск подходящих рецептов
        var filteredRecipes = recipes.Where(r => r.MeatRequired <= meatAmount && r.CookingTime <= maxCookingTime)
                                     .Where(r => !includedIngredients.Any() || r.Ingredients.Any(i => includedIngredients.Contains(i.ToLower())))
                                     .ToList();

        // Вывод рецептов
        if (filteredRecipes.Any())
        {
            Console.WriteLine("\nПодходящие рецепты:");
            foreach (var recipe in filteredRecipes)
            {
                Console.WriteLine(recipe);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Не найдено подходящих рецептов.");
        }
    }
}
*/



//// МЕНЮ

/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace Menu
{
    class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Allergens { get; set; }
        public int Calories { get; set; }
        public int EnergyValue { get; set; }
        public List<string> Variations { get; set; }

        public Dish(string name, string description, double price, List<string> ingredients, List<string> allergens, int calories, int energyValue, List<string> variations)
        {
            Name = name;
            Description = description;
            Price = price;
            Ingredients = ingredients;
            Allergens = allergens;
            Calories = calories;
            EnergyValue = energyValue;
            Variations = variations;
        }
    }

    class Program
    {
        static List<Dish> menu = new List<Dish>()
        {
            new Dish("Наггетсы", "Сочные куриные наггетсы.", 140,
                new List<string> { "Куриное филе", "Панировка", "Масло растительное" },
                new List<string> { "Глютен", "Соя" }, 250, 120, new List<string> { "Обычный"}),
            new Dish("Крылья", "Хрустящие куриные крылья.", 170,
                new List<string> { "Куриные крылья", "Панировка", "Масло растительное" },
                new List<string> { "Глютен", "Соя" }, 300, 150, new List<string> {"Острый" }),
            new Dish("Чизбургер", "Сочный бургер с говяжьей котлетой, сыром, луком, маринованными огурцами и кетчупом.", 200,
                new List<string> { "Говяжья котлета", "Сыр", "Лук", "Огурцы маринованные", "Кетчуп", "Булочка" },
                new List<string> { "Глютен", "Молоко", "Соя" }, 500, 250, new List<string> { "Обычный"}),
             new Dish("Чизбургер", "Сочный бургер с говяжьей котлетой, сыром, луком, маринованными огурцами и кетчупом.", 200,
                new List<string> { "Говяжья котлета", "Сыр", "Лук", "Огурцы маринованные", "Кетчуп", "Булочка" },
                new List<string> { "Глютен", "Молоко", "Соя" }, 500, 250, new List<string> {"Острый" }),
            new Dish("Твистер", "Куриное филе, завернутое в лепешку с салатом, помидорами, луком и соусом.", 180,
                new List<string> { "Куриное филе", "Салат", "Помидоры", "Лук", "Соус", "Лепешка" },
                new List<string> { "Глютен", "Молоко", "Соя" }, 450, 200, new List<string> { "Обычный"}),
            new Dish("Твистер", "Куриное филе, завернутое в лепешку с салатом, помидорами, луком и соусом.", 180,
                new List<string> { "Куриное филе", "Салат", "Помидоры", "Лук", "Соус", "Лепешка" },
                new List<string> { "Глютен", "Молоко", "Соя" }, 450, 200, new List<string> {"Острый" }),
            new Dish("Картошка фри", "Хрустящая картошка фри.", 80,
                new List<string> { "Картофель", "Масло растительное" },
                new List<string> { "Крахмал" }, 350, 180, new List<string> { "Обычный"}),
            new Dish("Картошка фри", "Хрустящая картошка фри.", 80,
                new List<string> { "Картофель", "Масло растительное" },
                new List<string> { "Крахмал" }, 350, 180, new List<string> {"По-деревенски" }),
            new Dish("Coca-Cola", "Классический газированный напиток.", 100,
                new List<string> { "Вода", "Сахар", "Карамель", "Кофеин" },
                new List<string> { "Глютен" }, 150, 80, new List<string> { "Со льдом" }),
             new Dish("Coca-Cola", "Классический газированный напиток.", 100,
                new List<string> { "Вода", "Сахар", "Карамель", "Кофеин" },
                new List<string> { "Глютен" }, 150, 80, new List<string> { "Без льда"}),
            new Dish("Фанта", "Газированный напиток со вкусом апельсина.", 100,
                new List<string> { "Вода", "Сахар", "Ароматизаторы", "Кофеин" },
                new List<string> { "Глютен" }, 150, 80, new List<string> { "Без льда" }),
               new Dish("Фанта", "Газированный напиток со вкусом апельсина.", 100,
                new List<string> { "Вода", "Сахар", "Ароматизаторы", "Кофеин" },
                new List<string> { "Глютен" }, 150, 80, new List<string> { "Со льдом" }),
            new Dish("Сандэй", "Вкусный десерт с мороженым, шоколадом и фруктами.", 120,
                new List<string> { "Мороженое", "Шоколад", "Фрукты" },
                new List<string> { "Молоко", "Глютен", "Соя" }, 400, 200, new List<string> {"Обычный" }),
                        new Dish("Сандэй", "Вкусный десерт с мороженым, шоколадом и фруктами.", 120,
                new List<string> { "Мороженое", "Шоколад", "Фрукты" },
                new List<string> { "Молоко", "Глютен", "Соя" }, 400, 200, new List<string> { "С вишней" }),
            new Dish("Пирожок с начинкой", "Свежий пирожок с начинкой на выбор.", 50,
                new List<string> { "Тесто", "Начинка" },
                new List<string> { "Глютен" }, 300, 150, new List<string> {"С вишней"}),
            new Dish("Пирожок с начинкой", "Свежий пирожок с начинкой на выбор.", 50,
                new List<string> { "Тесто", "Начинка" },
                new List<string> { "Глютен" }, 300, 150, new List<string> {"С клубникой" }),
            new Dish("Ролл с креветками", "Вкусненький ролл с морепродуктами креветками", 350,
                new List<string> { "Креветки", "Салат", "Помидор", "Сыр", "Лепешка" },
                new List<string> { "Глютен", "Креветки", "Морепродукты" }, 300, 150, new List<string> { "Обычный"}),
             new Dish("Ролл с креветками", "Вкусненький ролл с морепродуктами креветками", 350,
                new List<string> { "Креветки", "Салат", "Помидор", "Сыр", "Лепешка" },
                new List<string> { "Глютен", "Креветки", "Морепродукты" }, 300, 150, new List<string> {"Острый" }),
        };

        static void Main(string[] args)
        {
            List<Dish> filteredMenu = new List<Dish>(menu);
            while (true)
            {
                Console.WriteLine("----- Меню KFC -----");
                PrintMenu(filteredMenu);

                Console.WriteLine("\nФильтры:");
                Console.WriteLine("1. По цене");
                Console.WriteLine("2. По продуктам");
                Console.WriteLine("3. По аллергии");
                Console.WriteLine("4. По калориям/энергетической ценности");
                Console.WriteLine("5. Сбросить фильтры");
                Console.WriteLine("6. Показать блюда до заданной цены");
                Console.WriteLine("7. По варианту");
                Console.WriteLine("8. Выход");

                int choice = GetIntInput("Введите номер фильтра: ");

                switch (choice)
                {
                    case 1:
                        filteredMenu = FilterByPrice(menu);
                        break;
                    case 2:
                        filteredMenu = FilterByIngredients(menu);
                        break;
                    case 3:
                        filteredMenu = FilterByAllergens(menu);
                        break;
                    case 4:
                        filteredMenu = FilterByCaloriesOrEnergy(menu);
                        break;
                    case 5:
                        filteredMenu = new List<Dish>(menu);
                        break;
                    case 6:
                        ShowDishesUnderPrice(menu);
                        break;
                    case 7:
                        filteredMenu = FilterByVariants(menu);
                        break;
                    case 8:
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            }
        }
        static List<Dish> FilterByVariants(List<Dish> dishes)
        {
            Console.WriteLine("Выберите вариант блюда");
            string inputVariant = Console.ReadLine();
            List<string> variations = inputVariant.Split(',').Select(s => s.Trim()).ToList();

            return dishes.Where(d => d.Variations.Any(i => variations.Contains(i))).ToList();
        }
        static void PrintMenu(List<Dish> dishes)
        {
            if (dishes.Count == 0)
            {
                Console.WriteLine("Блюда не найдены.");
                return;
            }

            foreach (Dish dish in dishes)
            {
                Console.WriteLine($"\n{dish.Name} ({dish.Price} руб.)");
                Console.WriteLine($"{dish.Description}");
                Console.WriteLine($"Ингредиенты: {string.Join(", ", dish.Ingredients)}");
                Console.WriteLine($"Аллергены: {string.Join(", ", dish.Allergens)}");
                Console.WriteLine($"Калории: {dish.Calories}");
                Console.WriteLine($"Энергетическая ценность: {dish.EnergyValue} ккал");
                if (dish.Variations.Count > 0)
                {
                    Console.WriteLine($"Варианты: {string.Join(", ", dish.Variations)}");
                }
            }
        }

        static List<Dish> FilterByPrice(List<Dish> dishes)
        {
            double minPrice = GetDoubleInput("Введите минимальную цену: ");
            double maxPrice = GetDoubleInput("Введите максимальную цену: ");

            return dishes.Where(d => d.Price >= minPrice && d.Price <= maxPrice).ToList();
        }

        static List<Dish> FilterByIngredients(List<Dish> dishes)
        {
            Console.WriteLine("Введите ингредиенты (через запятую):");
            string inputIngredients = Console.ReadLine();
            List<string> ingredients = inputIngredients.Split(',').Select(s => s.Trim()).ToList();

            return dishes.Where(d => d.Ingredients.Any(i => ingredients.Contains(i))).ToList();
        }

        static List<Dish> FilterByAllergens(List<Dish> dishes)
        {
            Console.WriteLine("Введите аллергены (через запятую):");
            string inputAllergens = Console.ReadLine();
            List<string> allergens = inputAllergens.Split(',').Select(s => s.Trim()).ToList();

            return dishes.Where(d => !d.Allergens.Any(a => allergens.Contains(a))).ToList();
        }

        static List<Dish> FilterByCaloriesOrEnergy(List<Dish> dishes)
        {
            Console.WriteLine("1. По калориям");
            Console.WriteLine("2. По энергетической ценности");

            int choice = GetIntInput("Выберите вариант: ");

            switch (choice)
            {
                case 1:
                    return FilterByCalories(dishes);
                case 2:
                    return FilterByEnergyValue(dishes);
                default:
                    Console.WriteLine("Некорректный ввод.");
                    return dishes;
            }
        }

        static List<Dish> FilterByCalories(List<Dish> dishes)
        {
            int minCalories = GetIntInput("Введите минимальное количество калорий: ");
            int maxCalories = GetIntInput("Введите максимальное количество калорий: ");

            return dishes.Where(d => d.Calories >= minCalories && d.Calories <= maxCalories).ToList();
        }

        static List<Dish> FilterByEnergyValue(List<Dish> dishes)
        {
            int minEnergyValue = GetIntInput("Введите минимальную энергетическую ценность (ккал): ");
            int maxEnergyValue = GetIntInput("Введите максимальную энергетическую ценность (ккал): ");

            return dishes.Where(d => d.EnergyValue >= minEnergyValue && d.EnergyValue <= maxEnergyValue).ToList();
        }

        static void ShowDishesUnderPrice(List<Dish> dishes)
        {
            double budget = GetDoubleInput("Введите ваш бюджет: ");
            var affordableDishes = new List<Dish>();
            double totalSpent = 0;

            foreach (Dish dish in dishes)
            {
                if (totalSpent + dish.Price <= budget)
                {
                    affordableDishes.Add(dish);
                    totalSpent += dish.Price;
                }
            }

            Console.WriteLine("\nДоступные блюда:");
            if (affordableDishes.Count == 0)
            {
                Console.WriteLine("Нет доступных блюд в пределах вашего бюджета.");
                return;
            }

            foreach (Dish dish in affordableDishes)
            {
                Console.WriteLine($"{dish.Name} - {dish.Price} руб.");
            }

            double remainingBudget = budget - totalSpent;
            Console.WriteLine($"Общая стоимость: {totalSpent} руб.");
            Console.WriteLine($"Остаток на счету: {remainingBudget} руб.");
        }

        static int GetIntInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }
        }

        static double GetDoubleInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }
        }
    }
}
*/



// ГОРОДА

/*
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<string> usedCities = new HashSet<string>();
    static string lastCity = string.Empty;
    static List<string> cityHistory = new List<string>();

    // Список российских городов
    static List<string> russianCities = new List<string>
    {
         "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород",
    "Казань", "Челябинск", "Омск", "Самара", "Ростов-на-Дону",
    "Уфа", "Красноярск", "Воронеж", "Пермь", "Волгоград",
    "Краснодар", "Тюмень", "Барнаул", "Ижевск", "Тольятти",
    "Хабаровск", "Ярославль", "Оренбург", "Саратов", "Тула",
    "Кемерово", "Новокузнецк", "Рязань", "Магнитогорск", "Калуга",
    "Сочи", "Ставрополь", "Архангельск", "Ульяновск", "Симферополь",
    "Чита", "Иркутск", "Тверь", "Сыктывкар", "Набережные Челны",
    "Астрахань", "Калининград", "Саратов", "Набережные Челны", "Тула",
    "Тверь", "Кострома", "Липецк", "Смоленск", "Чебоксары",
    "Якутск", "Находка", "Благовещенск", "Брянск", "Петрозаводск",
    "Владикавказ", "Мурманск", "Сочи", "Саранск", "Архангельск",
    "Вологда", "Киров", "Нижневартовск", "Ангарск", "Энгельс",
    "Новороссийск", "Сызрань", "Калуга", "Челябинск", "Смоленск",
    "Псков", "Северодвинск", "Рязань", "Томск", "Химки",
    "Подольск", "Люберцы", "Камышин", "Зеленоград", "Жуковский",
    "Таганрог", "Тула", "Орлов", "Улан-Удэ", "Балашиха",
    "Одинцово", "Волгодонск", "Салават", "Кострома", "Сарапул",
    "Ставрополь", "Магадан", "Нефтеюганск", "Ноябрьск", "Шадринск",
    "Нижнекамск", "Светлогорск", "Ачинск", "Волгоград", "Саратов",
    "Хабаровск", "Челябинск", "Иркутск", "Кемерово", "Калуга",
    "Братск", "Сыктывкар", "Усть-Илимск", "Кузнецк", "Смоленск",
    "Рыбинск", "Курск", "Тверь", "Челябинск", "Уфимский",
    "Сызрань", "Астрахань", "Арзамас", "Кострома", "Нижний Тагил",
    "Томск", "Иваново", "Ноябрьск", "Камышин", "Санкт-Петербург",
    "Кострома", "Екатеринбург", "Тюмень", "Ярославль", "Тверь",
    "Чита", "Смоленск", "Сургут", "Балаково", "Нефтеюганск",
    "Тольятти", "Сыктывкар", "Кемерово", "Мурманск", "Вологда",
    "Саратов", "Астрахань", "Петропавловск-Камчатский", "Владикавказ", "Ульяновск",
    "Нижний Новгород", "Нижневартовск", "Сосновый Бор", "Златоуст", "Таганрог",
    "Кострома", "Набережные Челны", "Благовещенск", "Орел", "Калуга",
    "Ставрополь", "Липецк", "Челябинск", "Иркутск", "Уфа",
    "Находка", "Томск", "Люберцы", "Псков", "Тольятти",
    "Петрозаводск", "Братск", "Химки", "Красногорск", "Зеленоград",
    "Ангарск", "Ессентуки", "Щелково", "Гатчина", "Северодвинск",
    "Сергиев Посад", "Ульяновск", "Тверь", "Камышин", "Пятигорск",
    "Курск", "Старый Оскол", "Таганрог", "Усть-Лабинск", "Астрахань",
    "Кемерово", "Кострома", "Ухта", "Волжский", "Калининград",
    "Шадринск", "Санкт-Петербург", "Чебоксары", "Норильск", "Томск",
    "Калуга", "Волгоград", "Братск", "Саратов", "Симферополь",
    "Ульяновск", "Сочи", "Челябинск", "Иркутск", "Находка",
    "Чита", "Якутск", "Петропавловск", "Кострома", "Рязань",
    "Кемерово", "Нижневартовск", "Ижевск", "Тюмень", "Златоуст",
    "Сургут", "Анапа", "Астрахань", "Благовещенск", "Волгодонск",
    "Кузнецк", "Энгельс", "Салехард", "Таганрог", "Набережные Челны",
    "Нижний Тагил", "Серов", "Ноябрьск", "Хабаровск", "Киров",
    "Улан-Удэ", "Сердобск", "Усть-Илимск", "Надым", "Выборг",
    "Лермонтов", "Шахты", "Железногорск", "Калуга", "Мытищи",
    "Одинцово", "Кострома", "Туапсе", "Светлоград", "Чистополь",
    "Южно-Сахалинск", "Майкоп", "Элиста", "Северодвинск", "Уссурийск",
    "Находка", "Балаково", "Ачинск", "Калуга", "Сосновый Бор",
    "Химки", "Бийск", "Зеленогорск", "Каменск-Уральский", "Томск",
    "Саратов", "Сыктывкар", "Анапа", "Тверь", "Калуга",
    "Энергодар", "Лысьва", "Уфимский", "Черкесск", "Петропавловск", "Грозный", "Дербент", "Кисловодск", "Минеральные Воды", "Ыб"
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в игру 'Города'!");
        Console.WriteLine("Правила: назовите город, который начинается с последней буквы предыдущего города.");
        Console.WriteLine("Если последний город заканчивается на 'ь' или 'ъ', берите букву перед ними.");
        Console.WriteLine("Играйте до тех пор, пока кто-то не назовет город, который уже был назван.");
        Console.WriteLine("Введите 'стоп' для завершения игры.");

        while (true)
        {
            // Ход первого игрока
            if (PlayerTurn("Игрок 1")) break;

            // Ход второго игрока
            if (PlayerTurn("Игрок 2")) break;
        }

        Console.WriteLine("Игра окончена!");
    }

    static bool PlayerTurn(string playerName)
    {
        Console.WriteLine($"{playerName}, введите город (с заглавной буквы):");
        string city = Console.ReadLine().Trim();

        if (city.ToLower() == "стоп")
        {
            Console.WriteLine("Вы завершили игру.");
            return true;
        }

        // Проверка на пустое значение
        if (string.IsNullOrEmpty(city))
        {
            Console.WriteLine("Вы не можете ввести пустое значение. Попробуйте снова.");
            return PlayerTurn(playerName);
        }

        // Приведение к нужному формату (с заглавной буквы)
        if (!char.IsUpper(city[0]))
        {
            Console.WriteLine("Город должен начинаться с заглавной буквы. Попробуйте снова.");
            return PlayerTurn(playerName);
        }

        // Проверка на корректность ввода (только буквы и пробелы)
        foreach (char c in city)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                Console.WriteLine("Вы можете вводить только буквы и пробелы. Попробуйте снова.");
                return PlayerTurn(playerName);
            }
        }

        // Проверка на наличие города в списке
        if (!russianCities.Contains(city))
        {
            Console.WriteLine($"Город '{city}' не найден в списке российских городов. Попробуйте снова.");
            return PlayerTurn(playerName);
        }

        // Проверка на уникальность и соответствие правилам
        if (usedCities.Contains(city))
        {
            Console.WriteLine($"Город '{city}' уже был назван. Вы проиграли!");
            return true;
        }

        // Проверка на соответствие последней букве предыдущего города
        char lastChar = lastCity.Length > 0 ? GetRelevantLastChar(lastCity) : '\0';
        if (lastChar != '\0' && char.ToLower(city[0]) != char.ToLower(lastChar))
        {
            Console.WriteLine($"Город '{city}' не начинается с буквы '{lastChar}'. Вы проиграли!");
            return true;
        }

        // Добавляем город в список использованных и обновляем последний город
        usedCities.Add(city);
        cityHistory.Add(city);
        lastCity = city;

        Console.WriteLine($"Город '{city}' принят.");
        ShowCityHistory();
        return false;
    }

    static char GetRelevantLastChar(string city)
    {
        if (city.EndsWith("ь") || city.EndsWith("ъ"))
        {
            return city[city.Length - 2];
        }
        return city[city.Length - 1];
    }

    static void ShowCityHistory()
    {
        Console.WriteLine("История названных городов:");
        foreach (var city in cityHistory)
        {
            Console.WriteLine(city);
        }
    }
}
*/