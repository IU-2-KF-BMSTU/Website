import React from 'react';
import styled from 'styled-components';
import Header from '../components/Header';
import TopContentBlock from './HomePage/TopContentBlock';
import Footer from '../components/Footer';
import vectorForTopAbout from '../assets/vectorForTopAbout.svg';
import HeadDepartment from "./About/HeadDepartment";

const About = () => {
  return (
    <Container>
      <Header />
      <TopContentBlock
        title="Кафедра ИУ-2"
        text="Впервые о своих притязаниях на трон Уорбек заявил в 1490 году в Бургундии при дворе Маргариты Йоркской — тётки реального Ричарда. Он рассказал историю своего чудесного спасения: якобы брат его, король Эдуард V, был убит, но самого Ричарда пощадили из-за его возраста и «невинности» и заставили принести клятву, которая заставила принца скрывать своё истинное имя и происхождение «некоторое количество лет». С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.
"
        vector={vectorForTopAbout}
      />
      <HeadDepartment />
      <Footer />
    </Container>
  );
};
export default About;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
