import React from 'react';
import styled from 'styled-components';
import { ButtonCustom } from '../../components/Button';
const TopContentBlock = ({ title, text, vector, buttonAction }) => {
  return (
    <Container>
      <LeftContainer>
        <Title>{title}</Title>
        <Text>{text}</Text>
        {buttonAction && (
          <ButtonCustom width={'168px'} onClick={buttonAction}>
            Подробнее
          </ButtonCustom>
        )}
      </LeftContainer>
      <RightContainer>
        <img src={vector} alt="vector" />
      </RightContainer>
    </Container>
  );
};
export default TopContentBlock;

const Container = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  height: calc(100vh - 80px);
  box-sizing: border-box;
  align-items: center;
  padding: 16px 170px 0 105px;
`;

const RightContainer = styled.div`
  display: flex;
  width: 50%;
  height: 100%;
  box-sizing: border-box;
`;

const LeftContainer = styled.div`
  display: flex;
  flex-direction: column;
  width: 50%;
  height: 100%;
  box-sizing: border-box;
`;

const Title = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: 900;
  font-size: 64px;
  line-height: 77px;
  width: 462px;
  white-space: pre-wrap;
  color: #000000;
`;

const Text = styled.span`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  font-feature-settings: 'pnum' on, 'lnum' on;
  width: 430px;
  white-space: pre-wrap;
  color: #000000;
`;
