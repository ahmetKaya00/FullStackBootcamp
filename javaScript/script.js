function Ekle(){
    var alisverisEkle = document.getElementById("alisverisEkle");
    var liste = document.getElementById("liste");
    var yeniOge = document.createElement("li");
    yeniOge.innerText = alisverisEkle.value;

    //Ekleme
    if(alisverisEkle.value !== ""){
        liste.appendChild(yeniOge);
        alisverisEkle.value = "";

        //Güncelleme
        yeniOge.onclick = function(){
            var yeniMetin = prompt("Yeni değeri giriniz:");
            if(yeniMetin !== null && yeniMetin !== ""){
                this.firstChild.nodeValue = yeniMetin;
            }
        }
         //Tekil Silme
        yeniOge.addEventListener("contextmenu",function(e){
            e.preventDefault();
            this.parentNode.removeChild(yeniOge);
        });
    }
    else{
        alert("Lütfen bir öğe giriniz!");
    }
}
//Tüm Listeyi Silme
function listeTemizle(){
    var liste = document.getElementById("liste")
    liste.innerHTML = "";
}


