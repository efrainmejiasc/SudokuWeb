const menuActive = () => {
  const menuList = document.querySelector('#menu-list');
  const menuListItem = menuList.querySelectorAll('.menu-list-item > .nav-item');
  const allHashes = [...menuListItem].map(anchor => anchor.hash);
  const getScrollPosition = () => document.documentElement.scrollTop;
  const getElementPosition = element => Math.floor(element.getBoundingClientRect().top + getScrollPosition());

  const setActiveItem = () => {
    let activeItem;
    if (getScrollPosition() < 5) {
      activeItem = ['#home'];
    } else {
      activeItem = allHashes.filter(anchor => {
        if (getElementPosition(document.querySelector(anchor)) < getScrollPosition() + 120) return anchor;
      });
    }
    document.querySelector(`a[href="${activeItem[activeItem.length - 1]}"]`).parentElement.classList.add('-active');
    [...menuListItem]
      .filter(el => el.getAttribute('href') !== activeItem[activeItem.length - 1])
      .map(el => el.parentElement.classList.remove('-active'));
  };

  window.addEventListener('scroll', () => {
    setActiveItem();
  });

  window.addEventListener('DOMContentLoaded', () => {
    setActiveItem();
  });
};

export default menuActive;
