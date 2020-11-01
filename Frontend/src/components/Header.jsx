import React from 'react';
import styled from 'styled-components';

import logo from '../assets/logo.svg';
import burger from '../assets/burger.svg';

const Header = ({ openMenu }) => {
  return (
    <Container>
      <LogoBlock>
        <img src={logo} alt="ИУ-2" />
        ИУ-2
      </LogoBlock>
      <MenuButton onClick={openMenu}>
        <img src={burger} alt="menu" />
      </MenuButton>
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

const MenuButton = styled.div`
  :hover {
    cursor: pointer;
  }
`;

const LogoBlock = styled.div`
  display: flex;
  width: 100px;
  height: 100%;
  justify-content: space-between;
  align-items: center;
  font-family: Lato;
  font-style: normal;
  font-weight: normal;
  font-size: 24px;
  line-height: 29px;
  color: #1935d8;
  :hover {
    cursor: pointer;
  }
`;
