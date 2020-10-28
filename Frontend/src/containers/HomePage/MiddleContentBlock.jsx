import React from 'react';
import styled from 'styled-components';
import Button from '@material-ui/core/Button';
import { contentForBlock } from '../../sources/constants';

const MiddleContentBlock = () => {
  return (
    <Container>
      <Title>Учебная деятельность</Title>
      <SubContainer>
        {contentForBlock.map((item, ind) => (
          <ContentBlock key={`${ind}-block`}>
            <img src={item.svg} alt="" />
            <TitleBlock>{item.title}</TitleBlock>
            <TextBlock>{item.text}</TextBlock>
          </ContentBlock>
        ))}
      </SubContainer>
      <Button>Подробнее</Button>
    </Container>
  );
};
export default MiddleContentBlock;

const Container = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-items: center;
  width: 100%;
  height: 100vh;
  box-sizing: border-box;
  padding: 104px 106px 72px 106px;
  background: linear-gradient(104.98deg, rgba(23, 51, 215, 0.1), rgba(0, 195, 230, 0.1));
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
