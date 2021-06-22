const iconMenu = document.querySelector("#hamburger-menu");
const menu = document.querySelector("#menu");

let isDisplay = false;

iconMenu.addEventListener("click", () => {
  if (isDisplay) {
    menu.style.display = "none";
    isDisplay = false;
  } else {
    menu.style.display = "flex";
    isDisplay = true;
  }
});
