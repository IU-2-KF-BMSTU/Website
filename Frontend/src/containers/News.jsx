import React, { useCallback, useEffect, useState } from 'react';
import styled from 'styled-components';
import TopContentBlock from './HomePage/TopContentBlock';
import vectorForTopNews from '../assets/vectorForTopNews.svg';
import NewsContentBlock from "./News/NewsContentBlock";

const News = () => {

  return (
    <Container>
      <TopContentBlock title="Новости" text="" vector={vectorForTopNews} />
      <NewsContentBlock/>
    </Container>
  );
};
export default News;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
