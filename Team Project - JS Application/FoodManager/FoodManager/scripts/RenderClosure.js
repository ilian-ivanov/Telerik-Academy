/// <reference path="kendo/jquery.min.js" />
/// <reference path="classes/DayMeals.js" />

var renderer = (function () {
	function renderWelcome(selector) {
        var element = $(selector);
		var userKey = sessionStorage.key(0);
		var sessionUser = sessionStorage.getObject(userKey);
		var userName = sessionUser.fname + " " + sessionUser.lname;
        element.prepend("<p>Welcome " + userName + "</p>");
    };

    function renderAddMealForm(selector) {
        var element = $(selector);
        element.prepend("<form><fieldset><legend id='date-label'></legend>" + 
            "<label for='product'> Продукт:</label><input id='product'/>" +
            "<label for='weight'>Грамаж:</label><input id='weight'/>" +
            "<input type='button' id='btn-submit' value='Изяж'/>" +
            "</fieldset></form>");
    };

    function renderAddFoodForm(selector) {
        var element = $(selector);
        element.append("<form><fieldset><legend>За 100гр. продукт : </legend>" +
        "<label for='new-food'>Име</label>"+
        "<input id='new-food'/>"+        
        "<label for='proteins'>Протеини</label>"+
        "<input id='proteins'/>"+
        "<label for='carbs'>Въглехидрати</label>"+
        "<input id='carbs'/>"+
        "<label for='fats'>Мазнини</label>"+
        "<input id='fats'/>"+
        "<button id='create-food'>Добави нов тип храна</button>"+
        "</fieldset></form>");
    }

    function renderMealDate(date)
    {
        $('#date-label').text(date);
    }

    return {
        renderAddMealForm: renderAddMealForm,
        renderAddFoodForm: renderAddFoodForm,
        renderMealDate: renderMealDate,
		renderWelcome: renderWelcome
    }
})();