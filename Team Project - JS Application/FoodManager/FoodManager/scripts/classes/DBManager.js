/// <reference path="Food.js" />
/// <reference path="DayMeals.js" />
var DBManager = (function () {

    function getDayMeal(date) {
        var obj = localStorage.getItem(date);
        var parsed = JSON.parse(obj);
        if (parsed !== null) {
            return dayMealNamespace.CreateDayMeal(parsed.date, parsed.meals);
        }

        return null;
    }

    function insertDayMeal(dayMeal) {
        localStorage.setItem(dayMeal.date, JSON.stringify(dayMeal));
    }

    function deleteDayMeal(date) {
        localStorage.removeItem(date);
    }

    function getFood(name) {        
        var obj = localStorage.getItem(name);
        var parsed = JSON.parse(obj);

        if (parsed) {
            return foodNamespace.CreateFood(parsed.name,
                parsed.nutritions.proteins, parsed.nutritions.carbohydrates, parsed.nutritions.fats);
        }

        return null;
    }

    function getFoodNames() {
        var foodNames = [];
        for (var name in localStorage) {
            var obj = localStorage.getItem(name);
            var parsed = JSON.parse(obj);

            if (parsed !== null && parsed.name !== undefined) {
                foodNames.push(parsed.name);
            }
        }

        return foodNames;
    }

    function insertFood(food) {
        localStorage.setItem(food.name, JSON.stringify(food));
    }

    function deleteFood(name) {
        localStorage.removeItem(name);
    }

    return {
        getDayMeal: getDayMeal,
        insertDayMeal: insertDayMeal,
        deleteDayMeal: deleteDayMeal,
        getFood: getFood,
        insertFood: insertFood,
        deleteFood: deleteFood,
        getFoodNames: getFoodNames
    }
})();