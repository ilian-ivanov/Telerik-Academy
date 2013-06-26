/// <reference path="../lib/jasmine.js" />
/// <reference path="../lib/jasmine-html.js" />
/// <reference path="../../scripts/classes/Nutrition.js" />
describe("Nutrition Class Tests", function () {
    it("Initializes properties", function () {
        var proteins = 25;
        var carbs = 30;
        var fats = 5;
        var nutrition = nutritionNamespace.Nutrition(proteins, carbs, fats);

        expect(nutrition.proteins).toEqual(proteins);
        expect(nutrition.carbohydrates).toEqual(carbs);
        expect(nutrition.fats).toEqual(fats);
    });

    it("Calculates calories", function () {
        var proteins = 25;
        var carbs = 30;
        var fats = 5;
        var nutrition = nutritionNamespace.Nutrition(proteins, carbs, fats);
        var expectedCalories = proteins * 4 + carbs * 4 + fats * 9;

        expect(nutrition.calories).toEqual(expectedCalories);
    });
});