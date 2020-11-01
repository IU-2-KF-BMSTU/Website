import React from 'react';
import styled from 'styled-components';
import TopContentBlock from './HomePage/TopContentBlock';
import vectorForTopWork from '../assets/vectorForTopWork.svg';

const Work = () => {

  return (
    <Container>
      <TopContentBlock
        title="Учебная деятельность"
        text="Впервые о своих притязаниях на трон Уорбек заявил в 1490 году в Бургундии при дворе Маргариты Йоркской — тётки реального Ричарда. Он рассказал историю своего чудесного спасения: якобы брат его, король Эдуард V, был убит, но самого Ричарда пощадили из-за его возраста и «невинности» и заставили принести клятву, которая заставила принца скрывать своё истинное имя и происхождение «некоторое количество лет»"
        vector={vectorForTopWork}
      />
    </Container>
  );
};
export default Work;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
