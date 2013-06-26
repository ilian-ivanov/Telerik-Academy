/// <reference path="Nutrition.js" />
/// <reference path="Meal.js" />
var dayMealNamespace = (function () {

    function DayMeal(date, meals) {
        this.date = date;
        this.meals = meals;
        this.totalNutritions = calculateTotalNutritions(this.meals);

        function calculateTotalNutritions(meals) {
            var mealNutritions = nutritionNamespace.Nutrition(0, 0, 0)

            for (var i = 0, length = meals.length; i < length; i++) {
                mealNutritions.proteins += meals[i].nutritions.proteins;
                mealNutritions.carbohydrates += meals[i].nutritions.carbohydrates;
                mealNutritions.fats += meals[i].nutritions.fats;
                mealNutritions.calories += meals[i].nutritions.calories;
            }

            return mealNutritions;
        };

        this.addMeal = function (meal) {
            this.meals.push(meal);
            this.totalNutritions.proteins += meal.nutritions.proteins;
            this.totalNutritions.carbohydrates += meal.nutritions.carbohydrates;
            this.totalNutritions.fats += meal.nutritions.fats;
            this.totalNutritions.calories += meal.nutritions.calories;
        }

        this.removeMeal = function (meal) {
            var index = this.meals.lastIndexOf(meal);
            if (index !== -1) {
                this.meals.splice(index, 1);
            }

            this.totalNutritions.proteins -= meal.nutritions.proteins;
            this.totalNutritions.carbohydrates -= meal.nutritions.carbohydrates;
            this.totalNutritions.fats -= meal.nutritions.fats;
            this.totalNutritions.calories -= meal.nutritions.calories;
        }

        this.getMeals = function () {
            return this.meals;
        }

        this.getTotalNutritions = function () {
            return this.totalNutritions;
        }
    }

    return {
        CreateDayMeal: function (date, meals) {
            return new DayMeal(date, meals);
        }
    }
})();