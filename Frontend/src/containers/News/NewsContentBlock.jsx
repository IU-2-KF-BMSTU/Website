import React, { useCallback, useEffect, useState } from 'react';
import styled from 'styled-components';
import { getNews } from '../../sources/rest';
import { NewsCart } from '../../components/NewsCart';

const NewsContentBlock = () => {
  const [loading, setLoading] = useState(true);
  const [dataNews, setDataNews] = useState([]);
  const [error, setError] = useState('');

  const getDataNews = useCallback(async () => {
    try {
      setLoading(true);
      const response = await getNews('10', '1');
      console.log('resp', response.data);
      if (response.status === 200) {
        setDataNews({ ...response.data });
        setLoading(false);
      } else {
        if (response.data.description) {
          setError(response.data.description);
        }
      }
    } catch (e) {
      console.error(e);
    }
  }, []);

  useEffect(() => {
    getDataNews();
  }, []);
  return (
    <Container>
      {!loading && dataNews.data
        ? dataNews.data.map((item, index) => (
            <NewsCart
              data={{
                imgId: dataNews.data.imageId,
                date: dataNews.data.publicationDate,
                title: dataNews.data.title,
                text: dataNews.data.description,
              }}
              mode={index === 0}
            />
          ))
        : 'loading...'}
    </Container>
  );
};
export default NewsContentBlock;

const Container = styled.div`
  display: flex;
  width: 100%;
`;

const ContentBlock = styled.div`
  display: flex;
  flex-direction: column;
  width: 266px;
  align-items: center;
  box-sizing: border-box;
`;

const SubContainer = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  min-height: 248px;
  box-sizing: border-box;
`;

const Title = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: 500;
  font-size: 48px;
  line-height: 58px;
  color: #000000;
`;

const TitleBlock = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: normal;
  font-size: 24px;
  line-height: 29px;
  white-space: pre-wrap;
  color: #000000;
`;

const TextBlock = styled.span`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  text-align: center;
  font-feature-settings: 'pnum' on, 'lnum' on;
  white-space: pre-wrap;
  color: #000000;
`;
