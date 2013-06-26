/// <reference path="../lib/jasmine.js" />
/// <reference path="../lib/jasmine-html.js" />
/// <reference path="../../scripts/classes/DayMeals.js" />
/// <reference path="../../scripts/classes/Meal.js" />
/// <reference path="../../scripts/classes/Nutrition.js" />
describe("DayMeal Class Tests", function () {
    it("Initializes properties", function () {
        var date = "6/13/2013";
        var meals = new Array(mealNamespace.CreateMeal("хляб", 100));
        var dayMeal = dayMealNamespace.CreateDayMeal(date, meals);

        expect(dayMeal.date).toEqual(date);
        expect(dayMeal.getMeals().length).toEqual(meals.length);
    });

    it("Adds a meal", function () {
        var dayMeal = dayMealNamespace.CreateDayMeal("6/13/2013", new Array());
        expect(dayMeal.getMeals().length).toEqual(0);

        dayMeal.addMeal(mealNamespace.CreateMeal("ориз", 200));
        expect(dayMeal.getMeals().length).toEqual(1);
    });

    it("Removes an existing meal", function () {
        var meal = mealNamespace.CreateMeal("хляб", 300);
        var dayMeal = dayMealNamespace.CreateDayMeal("6/13/2013", new Array(meal));
        expect(dayMeal.getMeals().length).toEqual(1);

        dayMeal.removeMeal(meal);
        expect(dayMeal.getMeals().length).toEqual(0);
    });

    it("Removes a non-existing meal", function () {
        var meal = mealNamespace.CreateMeal("хляб", 300);
        var dayMeal = dayMealNamespace.CreateDayMeal("6/13/2013", new Array(meal));
        expect(dayMeal.getMeals().length).toEqual(1);

        var otherMeal = mealNamespace.CreateMeal("ориз", 100);
        dayMeal.removeMeal(otherMeal);
        expect(dayMeal.getMeals().length).toEqual(1);
    });

    it("Gets total nutritions", function () {
        var meals = new Array(
            mealNamespace.CreateMeal("ориз", 100),
            mealNamespace.CreateMeal("хляб", 150),
            mealNamespace.CreateMeal("домат", 200));

        var dayMeal = dayMealNamespace.CreateDayMeal("6/13/2013", meals);
        var expectedNutritions = nutritionNamespace.Nutrition(0, 0, 0);
        for (var i = 0; i < meals.length; i++) {
            var nutritions = meals[i].getTotalNutritions();
            expectedNutritions.proteins += nutritions.proteins;
            expectedNutritions.carbohydrates += nutritions.carbohydrates;
            expectedNutritions.fats += nutritions.fats;
        }

        var totalNutritions = dayMeal.getTotalNutritions();
        expect(totalNutritions.proteins).toEqual(expectedNutritions.proteins);
        expect(totalNutritions.carbohydrates).toEqual(expectedNutritions.carbohydrates);
        expect(totalNutritions.fats).toEqual(expectedNutritions.fats);
    });
});