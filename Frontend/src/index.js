import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import GlobalStyle from './services/injectGlobalStyles';
import { StylesProvider, MuiThemeProvider } from '@material-ui/core/styles';
import { ThemeProvider } from 'styled-components';
import themeSC from './sources/themeSC';
import themeMui from './sources/themeMui';
import { BrowserRouter } from 'react-router-dom';

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter>
      <GlobalStyle />
      <StylesProvider injectFirst>
        <MuiThemeProvider theme={themeMui}>
          <ThemeProvider theme={themeSC}>
            <App />
          </ThemeProvider>
        </MuiThemeProvider>
      </StylesProvider>
    </BrowserRouter>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
