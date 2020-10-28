import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';
import HomePage from "./containers/HomePage";
import About from "./containers/About";

const RoutePath = () => {
  return (
    <>
      <Switch key="main-router">
        <Route path={`/home`} component={HomePage} />
          <Route path={`/about`} component={About} />
        <Redirect to={`/home`} />
      </Switch>
    </>
  );
};

export default RoutePath;
