/// <reference path="../lib/jasmine.js" />
/// <reference path="../lib/jasmine-html.js" />
/// <reference path="../../scripts/classes/Meal.js" />
/// <reference path="../../scripts/classes/DayMeals.js" />
/// <reference path="../../scripts/classes/Food.js" />
/// <reference path="../../scripts/classes/DBManager.js" />
describe("DBManager Class Tests", function () {
    beforeEach(function () {
        DBManager.insertFood(foodNamespace.CreateFood("домат", 2, 40, 1));
        DBManager.insertFood(foodNamespace.CreateFood("краставица", 2, 40, 1));
        DBManager.insertFood(foodNamespace.CreateFood("ориз", 7, 70, 2));
        DBManager.insertFood(foodNamespace.CreateFood("хляб", 5, 80, 5));
    });

    afterEach(function () {
        localStorage.clear();
    });

    it("insertDayMeal works", function () {
        var date = "13/6/2013";
        var dayMeal = dayMealNamespace.CreateDayMeal(date, new Array());
        DBManager.insertDayMeal(dayMeal);
        var foundDayMeal = localStorage.getItem(date);

        expect(foundDayMeal).toNotBe(null);
    });

    it("deleteDayeal works", function () {
        var date = "6/6/2013";
        var dayMeal = dayMealNamespace.CreateDayMeal(date, new Array());
        DBManager.deleteDayMeal(date);
        var foundDayMeal = localStorage.getItem(date);

        expect(foundDayMeal).toBeNull();
    });

    it("getFood works with existing food", function () {
        var foundFood = DBManager.getFood("домат");
        var expected = foodNamespace.CreateFood("домат", 2, 40, 1);

        expect(foundFood).toEqual(expected);
    });

    it("getFood works with non-existing food", function () {
        var foundFood = DBManager.getFood("месо");

        expect(foundFood).toEqual(null);
    });

    it("getFoodNames works with existing foods", function () {
        var names = DBManager.getFoodNames();
        var expectedNames = new Array("домат", "краставица", "ориз", "хляб");

        for (var i = 0, len = expectedNames.length; i < len; i++) {
            expect(names.indexOf(expectedNames[i])).toBeGreaterThan(-1);
        }
        //expect(names).toEqual(expectedNames);
    });

    it("getFoodNames return an empty array when there are no foods", function () {
        localStorage.clear();
        var names = DBManager.getFoodNames();

        expect(names).toEqual(new Array());
    });

    it("insertFood works", function () {
        var food = foodNamespace.CreateFood("сирене", 23, 5, 20);
        DBManager.insertFood(food);
        var foundFood = localStorage.getItem(food.name);

        expect(foundFood).toNotBe(null);
    });

    it("deleteFood works", function () {
        var food = foodNamespace.CreateFood("сирене", 23, 5, 20);
        DBManager.insertFood(food);
        DBManager.deleteFood(food.name);
        var foundFood = localStorage.getItem(food.name);

        expect(foundFood).toBe(null);
    });
});