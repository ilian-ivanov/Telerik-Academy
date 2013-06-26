/// <reference path="Nutrition.js" />
var foodNamespace = (function () {

    function Food(name, proteins, carbohydrates, fats) {
        this.name = name;
        this.nutritions = nutritionNamespace.Nutrition(proteins, carbohydrates, fats);
    }

    return {
        CreateFood: function (name, proteins, carbohydrates, fats) {
            return new Food(name, proteins, carbohydrates, fats);
        }
    }
})();