/// <reference path="../lib/jasmine.js" />
/// <reference path="../lib/jasmine-html.js" />
/// <reference path="../../scripts/classes/FoodManager.js" />
/// <reference path="../../scripts/classes/Nutrition.js" />
/// <reference path="../../scripts/classes/Food.js" />
describe("FoodManager class tests", function () {
    beforeEach(function () {
        DBManager.insertFood(foodNamespace.CreateFood("домат", 2, 40, 1));
        DBManager.insertFood(foodNamespace.CreateFood("краставица", 2, 40, 1));
        DBManager.insertFood(foodNamespace.CreateFood("ориз", 7, 70, 2));
        DBManager.insertFood(foodNamespace.CreateFood("хляб", 5, 80, 5));
    });

    afterEach(function () {
        localStorage.clear();
    });

    it("getFoodNames works with existing foods", function () {
        var foodNames = FoodManager.getFoodNames();
        var expectedNames = new Array("домат", "краставица", "ориз", "хляб");

        for (var i = 0, len = expectedNames.length; i < len; i++) {
            expect(foodNames.indexOf(expectedNames[i])).toBeGreaterThan(-1);
        }
    });

    it("getFoodNames return an empty array when no foods exist", function () {
        localStorage.clear();
        var foodNames = FoodManager.getFoodNames();

        expect(foodNames).toEqual(new Array());
    });

    it("getFoodByName works with existing food", function () {
        var foundFood = FoodManager.getFoodByName("домат");
        var expectedFood = foodNamespace.CreateFood("домат", 2, 40, 1);

        expect(foundFood).toEqual(expectedFood);
    });

    it("getFoodByName works with non-existing food", function () {
        var foundFood = FoodManager.getFoodByName("пръжки");

        expect(foundFood).toBeNull();
    });

    it("calculateNutritions works", function () {
        var foodName = "домат";
        var weight = 200;
        var expectedNutrition = nutritionNamespace.Nutrition(4, 80, 2);
        var calculatedNutrition = FoodManager.calculateNutritions(foodName, weight);

        expect(calculatedNutrition).toEqual(expectedNutrition);
    });

    it("calculateNutrition returns an empty nutrition when food is not found", function () {
        var foodName = "лук";
        var weight = 200;
        var expectedNutrition = nutritionNamespace.Nutrition(0, 0, 0);
        var calculatedNutrition = FoodManager.calculateNutritions(foodName, weight);

        expect(calculatedNutrition).toEqual(expectedNutrition);
    });
});