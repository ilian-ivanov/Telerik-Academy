/// <reference path="../lib/jasmine.js" />
/// <reference path="../lib/jasmine-html.js" />
/// <reference path="../../scripts/local-storage-extensions.js" />
/// <reference path="../../scripts/classes/User.js" />
describe("User Class Tests", function () {
    it("Initializes properties", function () {
        var email = "pesho@abv.bg";
        var pass = "123456";
        var fname = "Pesho";
        var lname = "Peshov";
        var gender = "M";
        var age = 20;
        var weight = 80;
        var height = 185;
        var trainings = 3;
        var user = users.createUser(email, pass, fname, lname,
            gender, age, weight, height, trainings);

        expect(user.email).toEqual(email);
        expect(user.pass).toEqual(pass);
        expect(user.fname).toEqual(fname);
        expect(user.lname).toEqual(lname);
        expect(user.gender).toEqual(gender);
        expect(user.age).toEqual(age);
        expect(user.weight).toEqual(weight);
        expect(user.height).toEqual(height);
        expect(user.trainings).toEqual(trainings);
    });

    it("Calculates BMR for men", function(){
        var user = users.createUser("pesho@email", "123456", "Pesho", "Peshov",
            "M", 20, 80, 180, 3);
        var expectedBmr = 1926 * 3;
        var actualBmr = users.getBmr(user);

        expect(actualBmr).toBeCloseTo(expectedBmr);
    });

    it("Calculates BMR for women", function () {
        var user = users.createUser("maria@email", "123456", "Maria", "Ivanova",
            "F", 20, 55, 170, 3);
        var expectedBmr = 1395 * 3;
        var actualBmr = users.getBmr(user);
    });

    it("Saves user in locaStorage", function () {
        var user = users.createUser("maria@email", "123456", "Maria", "Ivanova",
            "F", 20, 55, 170, 3);
        users.saveUser(user);
        var foundUser = localStorage.getItem(user.email);
        localStorage.clear();

        expect(foundUser).toNotBe(null);
    });

    it("Gets user from localStorage", function () {
        var user = users.createUser("maria@email", "123456", "Maria", "Ivanova",
            "F", 20, 55, 170, 3);
        users.saveUser(user);
        var foundUser = users.getUser(user.email, user.pass);
        localStorage.clear();

        expect(foundUser).toNotBe(null);
    });
});