import React, { useEffect, useState, useCallback } from 'react';
import styled from 'styled-components';
import { getDepartmentHead } from '../../sources/rest';

const HeadDepartment = ({}) => {
  const [data, setData] = useState({});
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState();

  const getDepartHead = useCallback(async () => {
    try {
      setLoading(true);
      const response = await getDepartmentHead();
      if (response.status === 200) {
        setLoading(false);
        setData({ ...response.data });
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
    getDepartHead();
  }, []);

  return (
    <Container>
      <Img src="https://images.unsplash.com/photo-1512341689857-198e7e2f3ca8?auto=format&fit=crop&w=400&h=250&q=60" />
      <SubContainer>
        <Title>{!loading && data?.surname + ' ' + data?.name + ' ' + data?.patronymic}</Title>
        <SubTitle>{!loading && data?.degree}</SubTitle>
        <Text>
          Впервые о своих притязаниях на трон Уорбек заявил в 1490 году в Бургундии при дворе Маргариты Йоркской — тётки
          реального Ричарда. Он рассказал историю своего чудесного спасения: якобы брат его, король Эдуард V, был убит,
          но самого Ричарда пощадили из-за его возраста и «невинности» и заставили принести клятву, которая заставила
          принца скрывать своё истинное имя и происхождение «некоторое количество лет». С 1483 по 1490 год он скрывался
          в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить
          о себе.
        </Text>
        <Line />
        <SubText>Автор цитаты или текста 1939 г.</SubText>
        {error && error}
      </SubContainer>
    </Container>
  );
};
export default HeadDepartment;

const Img = styled.img`
  width: 463px;
  height: 463px;
`;

const Container = styled.div`
  display: flex;
  width: 100%;
  height: 463px;
  padding: 0 106px;
`;

const SubContainer = styled.div`
  display: flex;
  height: 100%;
  width: 100%;
  flex-direction: column;
  padding: 0 70px 0 128px;
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
const SubTitle = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: normal;
  font-size: 24px;
  line-height: 29px;

  color: #000000;
`;

const Text = styled.div`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  color: #000000;
  width: 493px;
`;
const SubText = styled.span`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 12px;
  line-height: 18px;
  color: #000000;
`;

const Line = styled.div`
  width: 69px;
  height: 4px;
  background: #1935d8;
`;
