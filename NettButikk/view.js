updateView();
function updateView() {
    let html = "";
    let side = model.app.currentPage;
    if (side == "Homepage") html = Homepage();
    if (side == "About") html = About();
    if (side == "Violin") html = Violin();

    document.getElementById("app").innerHTML = html;
}

function Homepage() {
    html = `
    
    <div class="wrapper"></div>
   
    <header><img class="LogoImg" src="images/logo.png" alt="logo"></header>
    <nav>
    <div class="ItemsOnPage" onclick="changePage('Homepage')" alt="Home">Home</div>
    <div class="ItemsOnPage" onclick="changePage('About')" alt="about">About</div>
    <div class="ItemsOnPage" onclick="changePage('Contact'); alt="contact">Contact</div>

    <div class="ItemsOnPage" onclick="changePage(''); alt="Acoustic Violas">${model.info[0].title}</div>   
    <div class="ItemsOnPage" onclick="changePage('Violin')" alt="Violin">${model.info[1].title}</div>
    <div class="ItemsOnPage" onclick="changePage('');alt="Viola/Violin Accesories">${model.info[4].title}</div>

    </nav>
    </div>
   <div class="txt" alt="text on homepage"></div>
    </div><section>
    <article><h1 class="title">Capriccio</h1><p><img class="left" src="images/johanna-vogt-H7kVzJgum3M-unsplash.jpg" alt="image-on-homepage"/>
   <i> Capriccio is a musical instrument store a retail business that sells musical instruments and related equipment and accessories.</p>
    
    <p>We sell additional services, such as music lessons, music instrument or equipment rental, or repair services.</p></article>
    </i></section>
    `;

   
    return html;
}

function About() {
    html = `
    <header><img class="LogoImg" src="images/logo.png" alt="logo"></header>
    <h1 style="text-align:center">Work in progress</h1>
    <button onclick="changePage('Homepage')" class="btnHome" alt="Back to homepage">Go back</button>
    
    `;
    return html;
}
function Violin(){
    html = `
    <header><img class="LogoImg" src="images/logo.png" alt="logo"></header>
    <h1 style="text-align:center">${model.info[1].title}</h1>
    <button onclick="changePage('Homepage')" class="btnHome" alt="Back to homepage">Go back</button>
    <input type="checkbox" id="pic-1"/>
    
      <label for="pic-1" class="lightbox"><img src="images/yamahaV3.jpg"></label>
      <input type="checkbox" id="pic-2"/>
      <label for="pic-2" class="lightbox"><img src="images/yamahaV20.jpg"></label>
      <input type="checkbox" id="pic-3"/>
      <label for="pic-3" class="lightbox"><img src="images/StentorSR1864.jpg" ></label>
      
      <div class="grid1">
      <label for="pic-1" class="grid-item1"><img class="img1" src="images/yamahaV3.jpg" "></label>
     
     
      <label for="pic-2" class="grid-item1"><img class="img1" src="images/yamahaV20.jpg" "></label>
    
      <label for="pic-3" class="grid-item1"><img class="img1" src="images/StentorSR1864.jpg" ></label>
    
      
      </div>  
    
    
    `;
    return html;
}


