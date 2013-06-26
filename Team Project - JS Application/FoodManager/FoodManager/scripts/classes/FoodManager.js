/// <reference path="Nutrition.js" />
/// <reference path="DBManager.js" />
/// <reference path="../DataBaseFood.js" />
var FoodManager = (function () {

    function getFoodNames() {
        return DBManager.getFoodNames();
    }

    function getFoodByName(name) {
        return DBManager.getFood(name);
    }

    function calculateNutritions(foodName, weight) {
        var food = this.getFoodByName(foodName);
        if (food) {
            var ratio = weight / 100;
            var proteins = food.nutritions.proteins * ratio;
            var carbs = food.nutritions.carbohydrates * ratio;
            var fats = food.nutritions.fats * ratio;
            return nutritionNamespace.Nutrition(proteins, carbs, fats);
        }

        return nutritionNamespace.Nutrition(0, 0, 0);
    }

    return {
        getFoodNames: getFoodNames,
        getFoodByName: getFoodByName,
        calculateNutritions: calculateNutritions
    }
})();