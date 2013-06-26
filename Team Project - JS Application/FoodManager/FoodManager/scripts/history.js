
var controls = (function () {
    function History(selector, dayMeal) {
        var historyItem = $(selector);
        var itemsList = $('<table id="info-table"></table>');

        this.render = function() {
            $('#info-table').remove();

            itemsList.append('<thead><th>Храна</th><th>Тегло</th><th>Протеини</th>' +
                '<th>Въглехидрати</th><th>Мазнини</th><th>Калории</th></thead>');

            for (var i = 0, len = dayMeal.meals.length; i < len; i += 1) {
                var domItem = new Item(dayMeal.meals[i]).render();
                itemsList.append(domItem);
            }

            itemsList.append('<tfoot><td>Общо :</td><td/>'
                                + '<td>' + (dayMeal.totalNutritions.proteins).toFixed(2) + '</td>'
                                + '<td>' + (dayMeal.totalNutritions.carbohydrates).toFixed(2) + '</td>'
                                + '<td>' + (dayMeal.totalNutritions.fats).toFixed(2) + '</td>'
                                + '<td>' + (dayMeal.totalNutritions.calories).toFixed(2) + '</td></tfood>');

            historyItem.append(itemsList);
            return this;
        };
    };

    function Item(item) {

        this.render = function() {
            var itemNode = $("<tr></tr>");

            itemNode.append("<td>" + item.foodName + "</td>"
                    + "<td>" + (item.weight).toFixed(2) + "</td>"
                    + "<td>" + (item.nutritions.proteins).toFixed(2) + "</td>"
                    + "<td>" + (item.nutritions.carbohydrates).toFixed(2) + "</td>"
                    + "<td>" + (item.nutritions.fats).toFixed(2) + "</td>"
                    + "<td>" + (item.nutritions.calories).toFixed(2) + "</td>");

            return itemNode;
        };
    }

    return {
        getHistory: function (selector, dayMeal) {
            return new History(selector, dayMeal);
        }
    }
}());