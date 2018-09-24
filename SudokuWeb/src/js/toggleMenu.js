const toggleMenu = () => {
  const toggleBtn = document.querySelector('#hamburguer-btn');
  const menuList = document.querySelector('#menu-list');
  const languageList = document.querySelector('#language-list');
  const menuListItem = menuList.querySelectorAll('.menu-list-item > .anchor');

  const _toggleMenu = () => {
    toggleBtn.classList.toggle('-open');
    menuList.classList.toggle('-open');
    languageList.classList.toggle('-open');
  };
  const _closeMenu = () => {
    toggleBtn.classList.remove('-open');
    menuList.classList.remove('-open');
    languageList.classList.remove('-open');
  };

  toggleBtn.addEventListener('click', ev => {
    ev.preventDefault();
    _toggleMenu();
  });

  menuList.addEventListener('click', ev => {
    if (ev.target.nodeName === 'A') _closeMenu();
  });
  languageList.addEventListener('click', ev => {
    if (ev.target.nodeName === 'A') _closeMenu();
  });
};

export default toggleMenu;
