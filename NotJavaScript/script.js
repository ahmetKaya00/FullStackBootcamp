var notlar = [];

function notListesiniGuncelle(){
    var notListesi = document.getElementById("notListesi");
    notListesi.innerHTML = "";

    notlar.forEach(function (not, index){
        var li = document.createElement("li");
        li.innerText = not;
        li.addEventListener("click", function(){
            var yeniNot = prompt("Notu düzenle:",not);
            if(yeniNot !== null && yeniNot !== ""){
                notlar[index] = yeniNot;
                notListesiniGuncelle();
            }
        });
        li.addEventListener("contextmenu", function(e){
            e.preventDefault();
            notlar.splice(index,1);
            notListesiniGuncelle();
        });
        notListesi.appendChild(li);
    });
}

function notEkle(){
    var notInput = document.getElementById("notInput");
    var not = notInput.value.trim();

    if(not !== ""){
        notlar.push(not);
        notInput.value = "";
        notListesiniGuncelle();
    }else{
        alert("Lütfen bir not girin!");
    }
}
notListesiniGuncelle();