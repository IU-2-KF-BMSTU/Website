import React from 'react';
import styled from 'styled-components';
import Button from '@material-ui/core/Button';

export const TeacherCart = ({ noMargin, data: { src, name, subText, text } }) => {
  return (
    <Wrapper>
      <Img width={265} src={src} />
      <Name>{name}</Name>
      <Text>{text}</Text>
      <Line />
      <SubText>{subText}</SubText>
    </Wrapper>
  );
};

const Wrapper = styled.div`
  width: 463px;
  height: 556px;
  display: flex;
  flex-direction: column;
  box-sizing: border-box;
  margin-left: ${({ noMargin }) => !noMargin && '30px'};
`;

const Img = styled.img`
width: 100%;
`;

const Line = styled.div`
  width: 99px;
  height: 2px;
  background: #1935d8;
`;
const Name = styled.div`
  font-family: Roboto Slab;
  font-style: normal;
  font-weight: bold;
  font-size: 20px;
  line-height: 26px;
  color: #000000;
`;

const Text = styled.div`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  color: #000000;
`;

const SubText = styled.div`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 12px;
  line-height: 18px;
  color: rgba(0, 0, 0, 0.6);
`;
