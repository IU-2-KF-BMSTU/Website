import React, { useEffect, useState } from 'react';
import styled from 'styled-components';

import logo from '../assets/logo.svg';
import burger from '../assets/burger.svg';

const Footer = () => {
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
export default Footer;

const Container = styled.div`
  width: 100%;
  height: 80px;
  flex-direction: row;
  justify-content: space-between;
  vertical-align: center;
  bottom: 0;
  padding: 17px 40px;
  background-color: #1935d8;
  box-sizing: border-box;
  color: #7f8c94;
  align-items: center;
  margin-top: -80px;
  position: relative;
`;

const LogoBlock = styled.div`
  display: flex;
  width: 135px;
  height: 100%;
  justify-content: space-between;
  align-items: center;
`;
