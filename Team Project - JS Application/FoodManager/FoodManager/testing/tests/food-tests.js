/// <reference path="../lib/jasmine.js" />
/// <reference path="../lib/jasmine-html.js" />
/// <reference path="../../scripts/classes/Food.js" />
describe("Food Class Tests", function () {
    it("Initializes properties", function () {
        var name = "meat";
        var proteins = 30;
        var carbs = 7;
        var fats = 18;
        var food = foodNamespace.CreateFood(name, proteins, carbs, fats);

        expect(food.name).toEqual(name);
        expect(food.nutritions.proteins).toEqual(proteins);
        expect(food.nutritions.carbohydrates).toEqual(carbs);
        expect(food.nutritions.fats).toEqual(fats);
    });
});