import React, { useEffect, useState } from 'react';
import styled from 'styled-components';
import Button from '@material-ui/core/Button';
import vectorForQuestionsBlock from '../assets/vectorForQuestionsBlock.svg';

const QuestionsBlock = () => {
  return (
    <Container>
      <Content>
        <Title>Учебная деятельность</Title>
        <Button>Напишите нам</Button>
      </Content>
      <img src={vectorForQuestionsBlock} alt="questions?" />
    </Container>
  );
};
export default QuestionsBlock;

const Container = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  width: 100%;
  height: calc(100vh - 80px);
  box-sizing: border-box;
  padding: 104px 106px 72px 106px;
  background: #fff;
`;

const Title = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: 500;
  font-size: 48px;
  line-height: 58px;
  color: #000000;
`;

const Content = styled.div`
  display: flex;
`;
