/// <reference path="../../scripts/classes/Meal.js" />
/// <reference path="../lib/jasmine.js" />
/// <reference path="../../scripts/classes/Nutrition.js" />
/// <reference path="../lib/jasmine-html.js" />
describe("Meal Class Tests", function () {
    beforeEach(function () {
        var foods = DatabaseFood.foodData;
        for (var i = 0; i < foods.length; i++) {
            DBManager.insertFood(foods[i]);
        }
    });

    afterEach(function () {
        localStorage.clear();
    });

    it ("Initializes properties", function () {
        var name = "eggs";
        var weight = 100;
        var meal = mealNamespace.CreateMeal(name, weight);

        expect(meal.foodName).toEqual(name);
        expect(meal.weight).toEqual(weight);
    });

    it("Calculates total nutritions", function () {
        var meal = mealNamespace.CreateMeal("домат", 200);

        var expectedProteins = 4;
        var expectedCarbs = 80;
        var expectedFats = 2;
        var nutritions = meal.getTotalNutritions();

        expect(nutritions.proteins).toEqual(expectedProteins);
        expect(nutritions.carbohydrates).toEqual(expectedCarbs);
        expect(nutritions.fats).toEqual(expectedFats);
    });
});