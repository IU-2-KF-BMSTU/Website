import React from 'react';
import styled from 'styled-components';

import logo from '../assets/logo.svg';
import burger from '../assets/burger.svg';

const Header = () => {
  return (
    <Container>
      <LogoBlock>
        <img src={logo} alt="ИУ-2" />
        ИУ-2
      </LogoBlock>
      <img src={burger} alt="menu" />
    </Container>
  );
};
export default Header;

const Container = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  height: 80px;
  padding: 0 125px;
  box-sizing: border-box;
  align-items: center;
  border-bottom: 1px solid rgba(174, 174, 174, 0.4);
`;

const LogoBlock = styled.div`
  display: flex;
  width: 135px;
  height: 100%;
  justify-content: space-between;
  align-items: center;
  font-family: 'Lato', sans-serif;
`;
