import { createGlobalStyle } from 'styled-components';
import '../assets/fonts/index.css';
import variableCss from '../sources/variableCss';

import '../sources/normalize.css';

export default createGlobalStyle`
  ${variableCss}
  body {
    margin: 0;
    font-family: 'Lato', sans-serif;
    overflow: hidden;
    overflow-y: auto;
    background: #ffffff;
    /* -webkit-text-stroke-width: 0.1px; */
  }

  /* для кастомизации фона автозаполнения */
input:-webkit-autofill {
    -webkit-box-shadow: 0 0 0 1000px white inset !important;
    -webkit-text-fill-color: var(--pText) !important;
  }

  @media screen and (-webkit-min-device-pixel-ratio:0) {
    input[type="password"] {
      font-family: Verdana, Geneva, sans-serif;
      letter-spacing: 1.25px;
    } 
  }

  input[type='password'], input[name='password'], input#password, input#repeatPassword, input#oldPassword {
    letter-spacing: 0.1em;
  }

  input[type='password']::placeholder, input[name='password']::placeholder, input#password::placeholder {
    letter-spacing: initial;
    font-family: Lato,sans-serif;
    font-size: 12px;
  }

  input[type='password']::-ms-reveal {
    display: none;
  }

  main {
    scroll-behavior: smooth;
    position: absolute;
    overflow-y: auto;
    top: 0;
    height: 100%;
    background: #f0f4f7;
    width: 100vw;
    z-index: 1;
  }

  button, a {
      outline: none !important;
  }

  .link-button {
    background-color: transparent;
    border: none;
    cursor: pointer;
    text-decoration: underline;
    display: inline;
    margin: 0;
    padding: 0;
    }

  .link-button:hover, .link-button:focus {
    text-decoration: none;
    }

  .filter-enter {
    opacity: 0.01;
    transform: scale(0, 0);
    transition: transform 0.3s ease-in;
  }

  .filter-enter.filter-enter-active {
    opacity: 1;
    transform: scale(2, 2);
  }

  .filter-leave {
    opacity: 1;
    transform: scale(0, 0);
    
  }

  .filter-leave.filter-leave-active {
    transform: scale(0, 0);
    transition: transform 0.3s ease-out;
    opacity: 0.01;
  }

  @keyframes fade-in {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }

  @keyframes fade-out {
    from {
      opacity: 1;
    }
    to {
      opacity: 0;
    }
  }

  @keyframes show-from-top {
    from {
      transform: translateY(-100%);
    }
    to {
      transform: translateY(0);
    }
  }

  @keyframes hide-to-top {
    from {
      transform: translateY(0);
    }
    to {
      transform: translateY(-100%);
    }
  }

@keyframes show-by-zoom {
  from {
    transform: scale(0);
  }
  to {
    transform: scale(1);;
  }
}

@keyframes hide-by-zoom {
  from {
    transform: scale(1);
  }
  to {
    transform: scale(0);
  }
}

.sortCloneItem {
  z-index: 1301;
}
`;
