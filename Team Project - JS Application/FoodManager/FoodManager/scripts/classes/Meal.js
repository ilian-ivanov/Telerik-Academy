/// <reference path="Nutrition.js" />
/// <reference path="Food.js" />
/// <reference path="FoodManager.js" />
var mealNamespace = (function () {
    function Meal(foodName, weight) {
        this.foodName = foodName;
        this.weight = weight;   // weight is in grams
        this.nutritions = FoodManager.calculateNutritions(this.foodName, this.weight);

        this.getTotalNutritions = function () {
            return this.nutritions;
        }
    }

    return {
        CreateMeal: function (foodName, weight) {
            return new Meal(foodName, weight);
        }
    }
})();