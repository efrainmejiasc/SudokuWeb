const smoothScroll = () => {
  const menuList = document.querySelector('#menu-list');
  const menuListItem = menuList.querySelectorAll('.menu-list-item > .nav-item');
  [...menuListItem].map(anchor => {
    anchor.addEventListener('click', ev => {
      ev.preventDefault();
      ScrollTo(ev.target.hash, { duration: 350, offset: -70 });
    });
  });

  const ScrollTo = (target, options) => {
    let start = window.pageYOffset;
    let opts = {
      duration: options.duration,
      offset: options.offset || 0,
      callback: options.callback,
      easing: options.easing || _easeInOutQuad,
    };
    let distance =
      typeof target === 'string' ? opts.offset + document.querySelector(target).getBoundingClientRect().top : target;
    let duration = typeof opts.duration === 'function' ? opts.duration(distance) : opts.duration;
    let timeStart, timeElapsed;

    requestAnimationFrame(time => {
      timeStart = time;
      _loop(time);
    });

    // loop
    const _loop = time => {
      timeElapsed = time - timeStart;

      window.scrollTo(0, opts.easing(timeElapsed, start, distance, duration));

      if (timeElapsed < duration) requestAnimationFrame(_loop);
      else end();
    };

    // end
    const end = () => {
      window.scrollTo(0, start + distance);

      if (typeof opts.callback === 'function') opts.callback();
    };

    // easing
    function _easeInOutQuad(t, b, c, d) {
      t /= d / 2;
      if (t < 1) return (c / 2) * t * t + b;
      t--;
      return (-c / 2) * (t * (t - 2) - 1) + b;
    }
  };
};

export default smoothScroll;
