const navbarOnScroll = () => {
  const navbar = document.querySelector('#navbar');
  window.addEventListener('scroll', function() {
    if (window.pageYOffset > navbar.offsetTop) {
      navbar.classList.add('-on-scroll');
    } else {
      navbar.classList.remove('-on-scroll');
    }
  });
};

export default navbarOnScroll;
