function setHeader(select = "") {

    let title = document.createElement("h5");
    let header = document.getElementById("header");
    let row = document.createElement("div");
    let left = document.createElement("div");
    let center = document.createElement("div");
    let right = document.createElement("div");
    header.appendChild(row);
    row.appendChild(left);
    row.appendChild(center);
    row.appendChild(right);
    //STYLE
    header.style.backgroundColor = "#fe005d";
    header.className = "container-fluid";
    left.style.display = "flex";
    row.className = "row";
    left.className = "col";
    center.className = "col";
    right.className = "col";

    switch (select) {
        case "grabar":
            title.textContent = "Grabar reporte";
            ; break;
        case "videos":
            title.textContent = "Videos";
            ; break;
        case "ranking":
            title.textContent = "Ranking";
            ; break;
        case "novedades":
            title.textContent = "Novedades";
            ;break;
        case "cuenta":
            title.textContent = "Mi cuenta";
            let dropdown = document.createElement("div");
            let button = document.createElement("button");
            let uldd = document.createElement("ul");
            let lidd = document.createElement("li");
            let add = document.createElement("a");
            dropdown.className = "dropdown";
            button.className = "btn dropdown-toggle";
            button.style.marginLeft = "80%";
            button.type = "button";
            button.backgroundColor = "#fe005d";
            button.setAttribute('id', 'close_session');
            button.setAttribute('data-bs-toggle', 'dropdown');
            button.setAttribute('aria-expanded', 'false');
            uldd.className = "dropdown-menu";
            uldd.setAttribute('aria-labelledby','close_session');
            add.className = "dropdown-item";
            add.textContent = "Cerrar Sesión";
            add.href = "";

            right.appendChild(dropdown);
            dropdown.appendChild(button);
            dropdown.appendChild(uldd);
            uldd.appendChild(lidd);
            lidd.append(add);
            ; break;
        case "editarPerfil":
            title.textContent = "Editar perfil";
            let li = document.createElement("li");
            let a = document.createElement("a");
            a.style.color = "white";
            li.className = "fas fa-arrow-circle-left";
            li.style.fontSize = "150%";
            li.color = "white";
            left.appendChild(a);
            a.appendChild(li);
            a.setAttribute('href','http://localhost:54180/Html/Cuenta/CuentaCuenta.html');
            ; break;
        case "misVideos":
            title.textContent = "";
            title.textContent = "Mis videos";
            let li2 = document.createElement("li");
            let a2 = document.createElement("a");
            a2.style.color = "white";
            li2.className = "fas fa-arrow-circle-left";
            li2.style.fontSize = "150%";
            li2.color = "white";
            left.appendChild(a2);
            a2.appendChild(li2);
            a2.setAttribute('href', 'http://localhost:54180/Html/Cuenta/CuentaCuenta.html');
            ; break;

        case "preguntasFrecuentes":
            title.textContent = "";
            title.textContent = "Preguntas Frecuentes";
            let li3 = document.createElement("li");
            let a3 = document.createElement("a");
            a3.style.color = "white";
            li3.className = "fas fa-arrow-circle-left";
            li3.style.fontSize = "150%";
            li3.color = "white";
            left.appendChild(a3);
            a3.appendChild(li3);
            a3.setAttribute('href', 'http://localhost:54180/Html/Cuenta/CuentaCuenta.html');
            ; break;

        case "terminosCondiciones":
            title.textContent = "";
            title.textContent = "Terminos y Condiciones";
            let li4 = document.createElement("li");
            let a4 = document.createElement("a");
            a4.style.color = "white";
            li4.className = "fas fa-arrow-circle-left";
            li4.style.fontSize = "150%";
            li4.color = "white";
            left.appendChild(a4);
            a4.appendChild(li4);
            a4.setAttribute('href', 'http://localhost:54180/Html/Cuenta/CuentaCuenta.html');
            ; break;
    }

    left.appendChild(title);
    title.style.color = "white";
}