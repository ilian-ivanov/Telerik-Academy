/// <reference path="RenderClosure.js" />
/// <reference path="classes/Food.js" />
/// <reference path="classes/Meal.js" />
/// <reference path="classes/MealDiary.js" />
/// <reference path="classes/DBManager.js" />
/// <reference path="classes/DayMeals.js" />
/// <reference path="classes/FoodManager.js" />
/// <reference path="food-helper.js" />
/// <reference path="kendo/kendo.all.min.js" />
/// <reference path="kendo/jquery.min.js" />

$(document).ready(function () {

    var data = FoodManager.getFoodNames();

    onLoad();
	
	//renderer.renderWelcome("#welcome");
    renderer.renderAddMealForm('#add-meal');
    renderer.renderAddFoodForm('#add-food');

    var calendar = $("#calendar").kendoCalendar({
        value: new Date(),

        month: {
            // template for dates in month view
            content: '# if ($.inArray(+data.date, data.dates) != -1) { #' +
                        '<div class="' +
                            '# if (data.value < 10) { #' +
                                "red" +
                            '# } else if ( data.value < 20 ) { #' +
                                "green" +
                            '# } else { #' +
                                "yellow" +
                            '# } #' +
                        '">#= data.value #</div>' +
                        '# } else { #' +
                        '#= data.value #' +
                        '# } #'
        },
        change: function () {
            dayMeal = DBManager.getDayMeal(getDateFromCalendar());
            bindHistory(dayMeal);
            renderer.renderMealDate(getDateFromCalendar());
        },

        footer: false
    });

    var dayMeal = DBManager.getDayMeal(getDateFromCalendar());
    bindHistory();
    renderer.renderMealDate(getDateFromCalendar());

    function getDateFromCalendar() {
        return kendo.toString(calendar.data("kendoCalendar").value(), 'd');
    }

    function bindHistory() {
        if (dayMeal === null) {
            dayMeal = dayMealNamespace.CreateDayMeal(getDateFromCalendar(), new Array());
        }

        var container = controls.getHistory("#history", dayMeal);
        container.render();
    }

    function onLoad() {
        if (data.length == 0) {
            var foods = DatabaseFood.foodData;
            for (var i = 0; i < foods.length; i++) {
                DBManager.insertFood(foods[i]);
            }
            data = FoodManager.getFoodNames();
        }
    }

    $("#tabs").kendoTabStrip({
        animation: {
            open: {
                effects: "fadeIn"
            }
        }
    });

    $("#product").kendoAutoComplete({
        dataSource: data,
        filter: "startswith",
        placeholder: "Select product...",
        //separator: ", "
    });

    $('#create-food').on("click", function (ev) {
        var isValid = foodHelper.validateFood();
        if (isValid) {
            var foodName = $('#new-food').val().trim();
            var proteins = $('#proteins').val();
            var carbs = $('#carbs').val();
            var fats = $('#fats').val();
            var foodObject = foodNamespace.CreateFood(foodName, proteins, carbs, fats);
            DBManager.insertFood(foodObject);

            $('#new-food').val('');
            $('#proteins').val('');
            $('#carbs').val('');
            $('#fats').val('');
        }
    });

    $("#btn-submit").on("click", function (ev) {
        var isValid = foodHelper.validateMeal();
        if (isValid) {
            var foodName = $("#product").val().trim();
            var weight = parseFloat($("#weight").val());
            var meal = mealNamespace.CreateMeal(foodName, weight);
            dayMeal.addMeal(meal);
            DBManager.insertDayMeal(dayMeal);
            bindHistory(dayMeal);

            $('#product').val('');
            $('#weight').val('');
        }
    });
});