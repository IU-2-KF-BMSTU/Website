import React from 'react';
import styled from 'styled-components';
import { useHistory } from 'react-router-dom';

import Drawer from '@material-ui/core/Drawer';

const Menu = ({ isOpen, onClose }) => {
  const history = useHistory();

  return (
    <Drawer anchor={'right'} open={isOpen} onClose={onClose}>
      <DrawerWrapper>
        <Container>
          <Close onClick={onClose}>X</Close>
          <span onClick={() => history.push('/home')}>Главная</span>
          <span onClick={() => history.push('/news')}>Новости</span>
          <span onClick={() => history.push('/about')}>О кафедре</span>
          <span onClick={() => history.push('/work')}>Учебная деятельность</span>
        </Container>

        <span>Личный кабинет</span>
      </DrawerWrapper>
    </Drawer>
  );
};
export default Menu;

const DrawerWrapper = styled.div`
  display: flex;
  width: 472px;
  height: 100%;
  flex-direction: column;
  padding: 0 107px 116px 107px;
  justify-content: space-between;
`;

const Close = styled.div`
  display: flex;
  width: 100%;
  justify-content: flex-end;
  padding: 33px 127px 75px;
  box-sizing: border-box;
  cursor: pointer;
`;

const Container = styled.div`
  display: flex;
  flex-direction: column;
  width: 100%;
  span {
    font-family: Rubik;
    font-style: normal;
    font-weight: 300;
    font-size: 14px;
    line-height: 17px;
    color: rgba(0, 0, 0, 0.6);
  }
`;
