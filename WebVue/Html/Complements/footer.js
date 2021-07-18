function setFooter(select = "") {
    let btnGrabar;
    let btnVideos;
    let btnRanking;
    let btnNovedades;
    let btnCuenta;
    switch (select) {
        case "grabar":
            btnGrabar = "#fe005d";
            btnVideos = "gray";
            btnRanking = "gray";
            btnNovedades = "gray";
            btnCuenta = "gray";
            ; break;
        case "videos":
            btnGrabar = "gray";
            btnVideos = "#fe005d";
            btnRanking = "gray";
            btnNovedades = "gray";
            btnCuenta = "gray";
            ; break;
        case "ranking":
            btnGrabar = "gray";
            btnVideos = "gray";
            btnRanking = "#fe005d";
            btnNovedades = "gray";
            btnCuenta = "gray";
            ; break;
        case "novedades":
            btnGrabar = "gray";
            btnVideos = "gray";
            btnRanking = "gray";
            btnNovedades = "#fe005d";
            btnCuenta = "gray";
            ; break;
        case "cuenta":
            btnGrabar = "gray";
            btnVideos = "gray";
            btnRanking = "gray";
            btnNovedades = "gray";
            btnCuenta = "#fe005d";
            ; break;
        case "":
            btnGrabar = "black";
            btnVideos = "black";
            btnRanking = "black";
            btnNovedades = "black";
            btnCuenta = "black";
            ; break;
    }
    //PROPIEDADES
    const footer = document.getElementById("footer");
    const host = window.location.host;
    const linkGrabar = "http://localhost:54180/Html/Cuenta/CuentaGrabar.html";
    const linkVideos = "http://localhost:54180/Html/Cuenta/CuentaVideos.html";
    const linkRanking = "http://localhost:54180/Html/Cuenta/CuentaRanking.html";
    const linkNovedades = "http://localhost:54180/Html/Cuenta/CuentaNovedades.html";
    const linkCuenta = "http://localhost:54180/Html/Cuenta/CuentaCuenta.html";
    //PROPIEDADES STYLE
    let width = "120px";
    let height = "";
    let fontsize = "15px";
    let liMargin = "3%";
    //LISTA
    let ul = this.document.createElement("ul");
    //ICONOS
    let liGrabar = document.createElement("li");
    let liVideos = document.createElement("li");
    let liRanking = document.createElement("li");
    let liNovedades = document.createElement("li");
    let liCuenta = document.createElement("li");
    //LINKS
    let aGrabar = document.createElement("a");
    let aVideos = document.createElement("a");
    let aRanking = document.createElement("a");
    let aNovedades = document.createElement("a");
    let aCuenta = document.createElement("a");
    //i
    let iGrabar = document.createElement("i");
    let iVideos = document.createElement("i");
    let iRanking = document.createElement("i");
    let iNovedades = document.createElement("i");
    let iCuenta = document.createElement("i");
    //APPEND CHILD FOOTER
    footer.appendChild(ul);
    //APPEND UL | LI
    ul.appendChild(liGrabar);
    liGrabar.appendChild(aGrabar);

    ul.appendChild(liVideos);
    liVideos.appendChild(aVideos);

    ul.appendChild(liRanking);
    liRanking.appendChild(aRanking);

    ul.appendChild(liNovedades);
    liNovedades.appendChild(aNovedades);

    ul.appendChild(liCuenta);
    liCuenta.appendChild(aCuenta);
    //STYLE FOOTER
    footer.style.backgroundColor = "#F8F8F8";
    footer.style.width = "100%";
    footer.style.padding = "1%";
    footer.style.textAlign = "center";
    footer.style.position = "fixed";
    footer.style.bottom= "0px";  
    //STYLE UL
    ul.style.listStyle = "none";
    ul.style.display = "inline";
    ul.style.margin = "auto";
    //STYLE LI
    liGrabar.style.display = "inline";
    liGrabar.style.margin = liMargin;

    liVideos.style.display = "inline";
    liVideos.style.margin = liMargin;

    liRanking.style.display = "inline";
    liRanking.style.margin = liMargin;

    liNovedades.style.display = "inline";
    liNovedades.style.margin = liMargin;

    liCuenta.style.display = "inline";
    liCuenta.style.margin = liMargin;

    //STYLE a
    aGrabar.style.display = "inline-block";
    aGrabar.style.position = "relative";
    aGrabar.style.margin = "0 auto 0 auto";
    aGrabar.style.borderRadius = "50%";
    aGrabar.style.textAlign = "center";
    aGrabar.style.width = width;
    aGrabar.style.height = height;
    aGrabar.style.fontSize = fontsize;
    aGrabar.style.color = btnGrabar;
    aGrabar.style.textDecoration = "none";

    aVideos.style.display = "inline-block";
    aVideos.style.position = "relative";
    aVideos.style.margin = "0 auto 0 auto";
    aVideos.style.borderRadius = "50%";
    aVideos.style.textAlign = "center";
    aVideos.style.width = width;
    aVideos.style.height = height;
    aVideos.style.fontSize = fontsize;
    aVideos.style.color = btnVideos;
    aVideos.style.textDecoration = "none";

    aRanking.style.display = "inline-block";
    aRanking.style.position = "relative";
    aRanking.style.margin = "0 auto 0 auto";
    aRanking.style.borderRadius = "50%";
    aRanking.style.textAlign = "center";
    aRanking.style.width = width;
    aRanking.style.height = height;
    aRanking.style.fontSize = fontsize;
    aRanking.style.color = btnRanking;
    aRanking.style.textDecoration = "none";

    aNovedades.style.display = "inline-block";
    aNovedades.style.position = "relative";
    aNovedades.style.margin = "0 auto 0 auto";
    aNovedades.style.borderRadius = "50%";
    aNovedades.style.textAlign = "center";
    aNovedades.style.width = width;
    aNovedades.style.height = height;
    aNovedades.style.fontSize = fontsize;
    aNovedades.style.color = btnNovedades;
    aNovedades.style.textDecoration = "none";

    aCuenta.style.display = "inline-block";
    aCuenta.style.position = "relative";
    aCuenta.style.margin = "0 auto 0 auto";
    aCuenta.style.borderRadius = "50%";
    aCuenta.style.textAlign = "center";
    aCuenta.style.width = width;
    aCuenta.style.height = height;
    aCuenta.style.fontSize = fontsize;
    aCuenta.style.color = btnCuenta;
    aCuenta.style.textDecoration = "none";

    //SET LINKS
    aGrabar.setAttribute('href', linkGrabar);
    aVideos.setAttribute('href', linkVideos);
    aRanking.setAttribute('href', linkRanking);
    aNovedades.setAttribute('href', linkNovedades);
    aCuenta.setAttribute('href', linkCuenta);

    //SET TEXT
    aGrabar.textContent = "Grabar";
    aVideos.textContent = "Videos";
    aRanking.textContent = "Ranking";
    aNovedades.textContent = "Novedades";
    aCuenta.textContent = "Cuenta";

    //SET i
    aGrabar.appendChild(iGrabar);
    aVideos.appendChild(iVideos);
    aRanking.appendChild(iRanking);
    aNovedades.appendChild(iNovedades);
    aCuenta.appendChild(iCuenta);

    iGrabar.setAttribute('class',"fas fa-camera");
    iVideos.setAttribute('class',"fas fa-video");
    iRanking.setAttribute('class',"fas fa-star");
    iNovedades.setAttribute('class',"fas fa-bell");
    iCuenta.setAttribute('class', "fas fa-user");

}