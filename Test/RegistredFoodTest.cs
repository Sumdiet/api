using NUnit.Framework;
using NutriNow.DataTransferObj;
using NutriNow.Domains;
using System.Collections.Generic;

namespace Test
{
    public class RegistredfoodTest
    {
        [Test]
        public void CoutingMacroFood_Should_Pass()
        {
            List<Food> foodList = new List<Food>();
            Macro macro = new Macro(1, "3", "10", "2", null, 3, 1, "30");
            Food food = new Food(1, "Pão de sal", macro);
            foodList.Add(food);
            MacroDto testingMacro = new MacroDto("2,4", "8", "1,6", null, "24");
            RegisteredFood registredFood = new RegisteredFood(1, 1, 1, foodList, 80);
            var currentMacro = registredFood.CurrentMacro;
            bool result = false;
            if (currentMacro.Carbs == testingMacro.Carbs && currentMacro.Kcal == testingMacro.Kcal && currentMacro.Protein == testingMacro.Protein && currentMacro.Fat == testingMacro.Fat && currentMacro.Water == testingMacro.Water)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}