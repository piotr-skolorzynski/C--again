int[] numbers = { 1, 2, 3 };

var pattern1 = numbers is [1, 2, 3]; // true jeśli patern pokrywa się ze wszystkimi wartościami listy
var pattern2 = numbers is [_, 2, 3]; // _ pozwala pominąć znak do sprawdzania
var pattern3 = numbers is [_, 2, > 2 and <5]; // można stosować operatory

var numbers2 = new List<int> { 1, 2, 3, 4, 5 };

//wzór który pozwala sprawdzic pierwsze dwa elementy a reszta mnie nie interesuje
var pattern2_1 = numbers2 is [1, 2, ..];

//pomijanie pierwszych wartości
var pattern2_2 = numbers2 is [.., 4, 5];

//pomijanie w środku
var pattern2_3 = numbers2 is [1, .., 5];
