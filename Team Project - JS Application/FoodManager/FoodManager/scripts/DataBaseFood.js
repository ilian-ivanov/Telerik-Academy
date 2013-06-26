/// <reference path="classes/Food.js" />
var DatabaseFood = (function () {
    var foodData = [
        foodNamespace.CreateFood("домат", 2, 40, 1),
        foodNamespace.CreateFood("краставица", 2, 40, 1),
        foodNamespace.CreateFood("ориз", 7, 70, 2),
        foodNamespace.CreateFood("Извара (Кашкавалена)", 18, 2, 7),
        foodNamespace.CreateFood("Извара (Сирене)", 18, 2, 0),
        foodNamespace.CreateFood("Кисело мляко - 3,6% масленост", 3.47, 4.66, 3.25),
        foodNamespace.CreateFood("Кисело мляко - нискомаслено, 1% масленост", 5.25, 7.04, 1.55),
        foodNamespace.CreateFood("Сирене - козе, меко", 18.52, 0.89, 21.08),
        foodNamespace.CreateFood("Сметана - бита", 3.2, 12.49, 22.22),
        foodNamespace.CreateFood("Яйце - белтък, суров", 10.9, 0.73, 0.17),
        foodNamespace.CreateFood("Яйце - цяло, омлет / бъркани", 10.57, 0.64, 11.66),
        foodNamespace.CreateFood("Яйце - цяло, пържено", 13.61, 0.83, 14.84),
        foodNamespace.CreateFood("Аспержи - готвени, варени", 2.4, 4.11, 0.22),
        foodNamespace.CreateFood("хляб", 5, 80, 5)
    ];

    return {
        foodData: foodData
    }
})();