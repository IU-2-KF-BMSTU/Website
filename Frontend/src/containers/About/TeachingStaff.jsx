import React, { useEffect, useState, useCallback } from 'react';
import styled from 'styled-components';
import { getDepartmentHead } from '../../sources/rest';
import { TeacherCart } from '../../components/TeacherCart';
const teachers = [
  {
    name: 'Имя Фамилия Отчество',
    text:
      'С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.',
    subText: 'Кандидат наук, доцент, каратист',
    src: 'https://images.unsplash.com/photo-1537996194471-e657df975ab4?auto=format&fit=crop&w=400&h=250&q=80',
  },
  {
    name: 'Имя Фамилия Отчество',
    text:
      'С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.',
    subText: 'Кандидат наук, доцент, каратист',
    src: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    name: 'Имя Фамилия Отчество',
    text:
      'С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.',
    subText: 'Кандидат наук, доцент, каратист',
    src: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=40',
  },
  {
    name: 'Имя Фамилия Отчество',
    text:
      'С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.',
    subText: 'Кандидат наук, доцент, каратист',
    src: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=80',
  },
  {
    name: 'Имя Фамилия Отчество',
    text:
      'С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.',
    subText: 'Кандидат наук, доцент, каратист',
    src: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    name: 'Имя Фамилия Отчество',
    text:
      'С 1483 по 1490 год он скрывался в Европе под защитой йоркистов, но после отъезда своего главного опекуна, сэра Эдварда Брэмтона, решил заявить о себе.',
    subText: 'Кандидат наук, доцент, каратист',
    src: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=40',
  },
];
const TeachingStaff = ({}) => {
  return (
    <Container>
      <Title>Преподовательский состав</Title>
      <SubContainer>
        {teachers.map((item, index) => (
          <TeacherCart key={index} noMargin={index === 0 || index === 3} data={item} />
        ))}
      </SubContainer>
    </Container>
  );
};
export default TeachingStaff;

const Container = styled.div`
  display: flex;
  width: 100%;
  flex-direction: column;
  padding: 0 106px;
`;

const SubContainer = styled.div`
  display: flex;
  width: 100%;
  flex-direction: row;
  padding: 0 106px;
  box-sizing: border-box;
  flex-wrap: wrap;
`;

const Title = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: 500;
  font-size: 48px;
  line-height: 58px;
  color: #000000;
  margin: 91px 0 89px 0;
`;
