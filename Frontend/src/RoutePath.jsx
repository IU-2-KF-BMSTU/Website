import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';
import HomePage from './containers/HomePage';
import About from './containers/About';
import News from './containers/News';
import Work from './containers/Work';

const RoutePath = () => {

  return (
    <>
      <Switch key="main-router">
        <Route path={`/home`} component={HomePage} />
        <Route path={`/about`} component={About} />
        <Route path={`/news`} component={News} />
        <Route path={`/work`} component={Work} />
        <Redirect to={`/home`} />
      </Switch>
    </>
  );
};

export default RoutePath;
