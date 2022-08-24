testeAjax = () => {
    const xhr = new XMLHttpRequest();

    xhr.open('POST', "/CS/Contatos.aspx/testandoComunicacao", true);
    xhr.setRequestHeader("Content-type", "application/json");
    var d = {};
    d.teste = "oi";
    xhr.send(JSON.stringify(d));

    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4) {
            if (xhr.status = 200) {
                console.log(xhr.responseText);
            }
        }
       
    }
   
}