html {
  font-family: 'Gill sans';
  margin: 0;
  padding: 0;
}

body {
  background-color: #2d2e47;
  width: 100%;
  max-width: 100%;
  line-height: 1.5;
  margin: 0;
  padding: 0;
}

.cover{
  position:absolute;
  top:0;
  left:0;
  bottom:0;
  right:0;
  margin: 0;
  padding: 0;
  height: 50rem;
  z-index: -1;
}

.about{
  padding-top: 25rem;
  color: #ffffff;
  margin-left: 20%;
  margin-right: 20%;
  font-size: 2rem;
}

.aboutdesc{
  font-size: 1rem;
}

* {
  box-sizing: border-box;
}


.title {
  font-size: 4.5rem;
  color: #ffffff;
  font-style: bold;
  margin-top: 15rem;
  margin-left: 13%;
  line-height: 3.5rem;
}

.subtitle {
  font-size: 2.5rem;
  color: #ffffff;
  font-style: bold;
  margin-left: 13.3%;
}

.desc{
  font-size: 1rem;
  color: #ffffff;
  font-style: bold;
  margin-left: 13.3%;
  flex-wrap: wrap;
}

/* nav styles */
.hamburger {
  padding-left: 5px;
  cursor: pointer;
  padding-bottom:10px;
  padding-top: 0;
  position: relative;
  z-index: 2;
  padding-top: 10px;
}

.hamburger .line {
  display: block;
  width: 40px;
  height: 5px;
  background-color: #7021bf;
  margin-bottom: 10px;
}

.nav-links {
  background-image: linear-gradient(to right, #494a71, #7021bf);
  overflow: hidden;
  padding-bottom: 0.5rem;
  position:relative;
  display: none;
}

.nav-links a {
  display: block;
  position: relative;
  text-decoration: none;
  font-size: 1rem;
  height: 2.3rem;
  color:#d2d0d8;
  text-align: center;
}

.right{
  float: none;
}

.nav-links a:hover, a:focus {
  color: #ffffff;
}

.expanded {
  display: block;
  background-image: linear-gradient(to right, #494a71, #7021bf);
}

.techicon{
  border-radius: 25px;
  background: #bab5bf;
  padding: 20px;
  width: 100px;
  height: 125px;
  font-size: 1rem;
  text-align: center;
  display: inline-block;
}

.techlogo{
  width: 50px;
  height: 60px;
  display: flex;
}

.hover-underline-animation {
  display: inline-block;
  position: relative;
  color: #c3a3ee;
}

.hover-underline-animation::after {
  content: '';
  position: absolute;
  display: block;
  width: 100%;
  transform: scaleX(0);
  height: 2px;
  bottom: 0;
  left: 0;
  background-color: #c3a3ee;
  transform-origin: bottom right;
  transition: transform 0.25s ease-out;
}

.hover-underline-animation:hover::after {
  transform: scaleX(1);
  transform-origin: bottom left;
}

.navlogo{
  display: inline;
  height: 40px;
  width: 40px;
  text-align: center;
  position: relative;
}

@media screen and (min-width: 836px) {
  .nav-links {
    display: block;
    position: static;
    width: auto;
    max-height: 45px;
  }

  /* The sticky class is added to the navbar with JS when it reaches its scroll position */
  .sticky {
    position: fixed;
    top: 0;
    width: 100%;
  }

  /* Add some top padding to the page content to prevent sudden quick movement (as the navigation bar gets a new position at the top of the page (position:fixed and top:0) */
  .sticky + .content {
    padding-top: 60px;
  }

  .nav-links a {
    display: inline-block;
    margin-right: 1rem;
    font-size: 20px;
  }

  .navbarreroute{
    padding-top: 0.6rem;
  }

  .right{
    float: right;
  }

  .hamburger {
    display: none;
  }

  .navlogo{
    width: 50px;
    height: 50px;
    display: block;
    padding-top: 0px;

  }
}
