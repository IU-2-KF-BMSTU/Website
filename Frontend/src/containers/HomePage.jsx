import React from 'react';
import styled from 'styled-components';
import Header from '../components/Header';
import TopContentBlock from './HomePage/TopContentBlock';
import NewsBlock from './HomePage/NewsBlock';
import MiddleContentBlock from './HomePage/MiddleContentBlock';
import QuestionsBlock from './HomePage/QuestionsBlock';
import Footer from '../components/Footer';
import vectorForTopHomePage from '../assets/vectorForTopHomePage.svg';

const HomePage = () => {
  return (
    <Container>
      <Header />
      <TopContentBlock
        title="Кафедра ИУ-2 ждет тебя"
        text=" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
          magna aliqua. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut
          labore et dolore."
        vector={vectorForTopHomePage}
        buttonAction={()=>{console.log('click');}}
      />
      <NewsBlock />
      <MiddleContentBlock />
      <QuestionsBlock />
      <Footer />
    </Container>
  );
};
export default HomePage;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
