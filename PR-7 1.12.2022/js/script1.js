function End(){
    alert('Хорошего вам дня, до свидания');
}


var year;
year = 12 % 12;
function cYear(){
     if (year=1) {
document.getElementById('god-content').innerHTML = "Вы родились в год Обезьяны вы очень энергичны и стремительны" ;
        }else {document.getElementById('Year').innerHTML = "Вы родились в год " ;
    }
}