import React from 'react';
import styled from 'styled-components';
import TopContentBlock from './HomePage/TopContentBlock';
import vectorForTopNews from '../assets/vectorForTopNews.svg';

const News = () => {
  return (
    <Container>
      <TopContentBlock
        title="Новости"
        text=""
        vector={vectorForTopNews}
      />
    </Container>
  );
};
export default News;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
