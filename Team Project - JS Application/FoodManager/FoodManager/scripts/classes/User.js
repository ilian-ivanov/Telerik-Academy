/// <reference path="../local-storage-extensions.js" />
var users = (function () {
    function User(email, pass, fname, lname, gender, age, weight, height, trainings) {
        this.email = email;
        this.pass = pass;
        this.fname = fname;
        this.lname = lname;
        this.gender = gender;
        this.age = age;
        this.weight = weight;
        this.height = height;
        this.trainings = trainings;
    };

    var getBMR = function (user) {
        if (user.gender == 'F') {
            return (655 + 9.6 * user.weight + 1.8 * user.height - 4.7 * user.age) * user.trainings;
        }
        else if (user.gender == 'M') {
            return (66 + 13.7 * user.weight + 5 * user.height - 6.8 * user.age) * user.trainings;
        }
    }

    var createUser = function (email, pass, fname, lname, gender, age, weight, height, trainings) {
        return new User(email, pass, fname, lname, gender, age, weight, height, trainings);
    };

    var saveUser = function (user) {
        if (localStorage.getObject(user.email)) {
            return false;
        }
        else {
            localStorage.setObject(user.email, user);
            return true;
        }
    }

    var getUser = function (login_email, login_pass) {
        var user = localStorage.getObject(login_email);
        if (user && user.pass === login_pass)
            return user;
        return false;
    };

    return {
        getUser: getUser,
        createUser:createUser,
        saveUser: saveUser,
        getBmr: getBMR
    }
}());