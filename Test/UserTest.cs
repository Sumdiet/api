using NUnit.Framework;
using NutriNow.DataTransferObj;
using NutriNow.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class UserTest
    {
        [Test]
        public void CoutingMacroUser_Should_Pass()
        {
            List<Food> foodList = new List<Food>();
            Macro macro = new Macro(1, "3", "10", "2", null, 3, 1, "30");
            List<Meal> listMeal = new List<Meal>();
            List<RegisteredFood> listRegisteredFood = new List<RegisteredFood>();
            Food food = new Food(1, "Pão de sal", macro);
            foodList.Add(food);
            RegisteredFood registeredFood = new RegisteredFood(1, 1, 1, foodList, 150);
            listRegisteredFood.Add(registeredFood);
            Meal meal = new Meal(1, "Almoço", "12:00", new Macro(1, "50", "100", "10", null, 2, 1, "1000"), listRegisteredFood);
            listMeal.Add(meal);
            User user = new User(1, "test", "test", "test", null, null, listMeal);
            MacroDto currentMacro = user.CurrentMacro;
            MacroDto testingMacro = new MacroDto("4,5", "15", "3", null, "45");
            bool result = false;
            if (currentMacro.Carbs == testingMacro.Carbs && currentMacro.Kcal == testingMacro.Kcal && currentMacro.Protein == testingMacro.Protein && currentMacro.Fat == testingMacro.Fat && currentMacro.Water == testingMacro.Water)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
