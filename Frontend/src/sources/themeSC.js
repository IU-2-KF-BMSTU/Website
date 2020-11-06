export const animationTime = '450ms';

export default {
  colors: {
    pr: 'hsla(211, 86%, 53%, 1)', // #2285ee
    prLight: 'hsla(210, 83%, 95%, 1)', // #E9F3FD
    prDark: 'hsla(212, 100%, 43%, 1)', // #0067DD
    prText: 'hsla(212, 56%, 26%, 1)', // #1D3F66

  },
  sizes: {
    header: {
      h: '68px',
      w: '100%',
      suggestionHeader: '48px', // второй хедер
    },
    container: {
      w: '1200px',
    },
    common: {
      maxPad: '7rem',
      pad: '4rem',
      minPad: '2.5rem',
      midMedia: '1620px',
      minMedia: '1400px',
    },
  },
  times: {
    animation: animationTime,
  },
  button: `
    margin: 1rem;
    min-width: 8rem;
    min-height: 2.5rem;
  `,
  fontSizes: {
    megaText: '64px',
    bigTitleText: '48px',
    mainText: '24px', // юзать из variableCss
    mediumText: '20px',
    smallText: '16',
    tinyText: '14px',
    veryTinyText: '12px',
  },
  transitionFunction: 'cubic-bezier(0.4, 0, 0.2, 1)',
  transition: `transition all ${animationTime} cubic-bezier(0.4, 0, 0.2, 1)`,
  getTransition: (target = 'all', duration = animationTime) =>
    `transition ${target} ${duration} cubic-bezier(0.4, 0, 0.2, 1)`,
  shadow: 'box-shadow: 0 0 1vh rgba(0, 0, 0, 0.2);',
  // анимации описаны в services/injectGlobalStyles.js
  animations: {
    fadeIn: (duration = animationTime, delay = '0s') => {
      return `fade-in ${duration} cubic-bezier(0.4, 0, 0.2, 1) ${delay}`;
    },
    fadeOut: (duration = animationTime, delay = '0s') => {
      return `fade-out ${duration} cubic-bezier(0.4, 0, 0.2, 1) ${delay}`;
    },
    showFromTop: (duration = animationTime, delay = '0s') => {
      return `show-from-top ${duration} cubic-bezier(0.4, 0, 0.2, 1) ${delay}`;
    },
    hideToTop: (duration = animationTime, delay = '0s') => {
      return `hide-to-top ${duration} cubic-bezier(0.4, 0, 0.2, 1) ${delay}`;
    },
    showByZoom: (duration = animationTime, delay = '0s') => {
      return `show-by-zoom ${duration} cubic-bezier(0.4, 0, 0.2, 1) ${delay}`;
    },
    hideByZoom: (duration = animationTime, delay = '0s') => {
      return `hide-by-zoom ${duration} cubic-bezier(0.4, 0, 0.2, 1) ${delay}`;
    },
  },
};
