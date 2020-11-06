import React from 'react';
import styled from 'styled-components';
import TopContentBlock from './HomePage/TopContentBlock';
import NewsBlock from './HomePage/NewsBlock';
import MiddleContentBlock from './HomePage/MiddleContentBlock';
import QuestionsBlock from './HomePage/QuestionsBlock';
import vectorForTopHomePage from '../assets/vectorForTopHomePage.svg';
import { useHistory } from 'react-router-dom';

const HomePage = () => {
    const history = useHistory();

    return (
      <Container>
        <TopContentBlock
          title="Кафедра ИУ-2 ждет тебя"
          text=" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
          magna aliqua. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut
          labore et dolore."
          vector={vectorForTopHomePage}
          buttonAction={() => history.push('/about')}
        />
        <NewsBlock />
        <MiddleContentBlock />
        <QuestionsBlock />
      </Container>
    );
};
export default HomePage;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
