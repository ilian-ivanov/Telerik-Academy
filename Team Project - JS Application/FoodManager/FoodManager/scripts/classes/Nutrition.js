var nutritionNamespace = (function () {

    function Nutrition(proteins, cabohydrates, fats) {
        this.proteins = proteins;
        this.carbohydrates = cabohydrates;
        this.fats = fats;
        this.calories = parseFloat((proteins * 4 + cabohydrates * 4 + fats * 9).toFixed(2));

    }

    return {
        Nutrition: function (proteins, carbohydrates, fats) {
            return new Nutrition(proteins, carbohydrates, fats);
        }
    }
})();