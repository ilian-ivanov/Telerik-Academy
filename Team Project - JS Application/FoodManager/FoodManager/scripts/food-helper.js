var foodHelper = (function () {

    var validateFood = function () {
        if (validateFoodName() &&
            validateProteins() &&
            validateCarbohydrates() &&
            validateFats())
            return true;
        return false;

    };

    var validateMeal = function () {
        if (validateFoodExists() &&
            validateMealWeight())
            return true;
        return false;

    };

    function validateFoodName() {
        var foodName = $("#new-food").val().trim();
        if (foodName == null || foodName == '') {
            $('#new-food').css('background-color', 'pink');
            return false;
        }
        $('#new-food').css('background-color', 'white');
        return true;
    }

    function validateProteins() {
        var proteins = parseFloat($("#proteins").val());
        console.log(proteins);
        if (proteins == null || proteins == '' || isNaN(proteins) || proteins < 0) {
            $('#proteins').css('background-color', 'pink');
            return false;
        }
        $('#proteins').css('background-color', 'white');
        return true;
    }

    function validateCarbohydrates() {
        var carbs = parseFloat($("#carbs").val());
        if (carbs == null || carbs == '' || isNaN(carbs) || carbs < 0) {
            $('#carbs').css('background-color', 'pink');
            return false;
        }
        $('#carbs').css('background-color', 'white');
        return true;
    }

    function validateFats() {
        var fats = parseFloat($("#fats").val());
        if (fats == null || fats == '' || isNaN(fats) || fats < 0) {
            $('#fats').css('background-color', 'pink');
            return false;
        }
        $('#fats').css('background-color', 'white');
        return true;
    }

    function validateFoodExists() {
        var foodName = $("#product").val().trim();
        if (foodName == null || foodName == '') {
            $('#product').css('background-color', 'pink');
            return false;
        }

        var food = FoodManager.getFoodByName(foodName);
        console.log(food);
        if (food == null || food == undefined) {
            $('#product').css('background-color', 'pink');
            return false;
        }
        $('#product').css('background-color', 'white');

        return true;
    }

    function validateMealWeight() {
        var weight = parseFloat($("#weight").val());
        if (weight == null || weight == '' || isNaN(weight) || weight < 1 || weight > 2000) {
            $('#weight').css('background-color', 'pink');
            return false;
        }
        $('#weight').css('background-color', 'white');
        return true;
    }
    
    return {
        validateMeal: validateMeal,
        validateFood: validateFood,
    }
})();