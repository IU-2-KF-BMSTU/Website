import React, { useEffect, useState } from 'react';
import styled from 'styled-components';
import Header from '../components/Header';
import TopContentBlock from '../containers/TopContentBlock';
import NewsBlock from '../containers/NewsBlock';
import MiddleContentBlock from '../containers/MiddleContentBlock';
import QuestionsBlock from '../containers/QuestionsBlock';
import Footer from '../components/Footer';

const HomePage = () => {
  return (
    <Container>
      <Header />
      <TopContentBlock />
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
