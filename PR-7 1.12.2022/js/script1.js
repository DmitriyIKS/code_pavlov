function End(){
    alert('Хорошего вам дня, до свидания');
}


var year;
year = 12%12
function cYear(){

     if (year=1) {
document.getElementById('god-content').innerHTML = "Вы родились в год Обезьяны вы очень энергичны и стремительны " + '<br>' + "<img src='img/monkey.jpg' width='450' height='450'>";
        }else if(year=1) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=3) {
        document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=4) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=5) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=6) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=7) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=8) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=9) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=10) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=11) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else if(year=12) {
            document.getElementById('Year').innerHTML = "Вы родились в год " ;
        }else{
            document.getElementById('Year').innerHTML = "Error";
        }
}
function Open() {
    document.getElementById('vtrBlokId').innerHTML = '<h1>По году или по знаку задиака?</h1>' + '<button class="button button3" onclick="openYear()"></button>' + 'По году' + '<button class="button button4" onclick="openZod()"></button>' + 'По знаку Зодиака';
}
function openYear() {
    document.getElementById('trtBlokId').innerHTML = '<div class="godina">' + '<p>Введите год рождения</p>' + '<input type="date" name="year" ><button class="button button12" onclick="cYear()" >Подтвердить</button>' + '<p id="god-content"></p>' + '<img id="avatarka"></div>';
    //document.getElementById('trtBlokId').innerHTML = ''
}
function openZod() {
    document.getElementById('trtBlokId').innerHTML = '<div class="zodiak">' + '<p>Введите дату рождения</p>' + '<input type="date" name="" id="month"><button class="button button21" onclick="cZod()" >Подтвердить</button>' + '<p id="zodiak-content"></p></div>';
}
