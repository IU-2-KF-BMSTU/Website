import React from 'react';
import styled from 'styled-components';
import Button from '@material-ui/core/Button';

export const NewsCart = ({ mode, data: { src, date, title, text } }) => {
  return (
    <>
      {mode === 'big' ? (
        <WrapperBig>
          <Img width={562} height={360} src={src} />
          <TitleBig>{title}</TitleBig>
        </WrapperBig>
      ) : (
        <Wrapper>
          <Img width={265} height={180} src={src} />
          <Date>{date}</Date>
          <Title>{title}</Title>
          <Text>{text}</Text>
        </Wrapper>
      )}
    </>
  );
};

const Wrapper = styled.div`
  width: 265px;
  height: 360px;
  border: 1px solid rgba(174, 174, 174, 0.6);
  display: flex;
  flex-direction: column;
  box-sizing: border-box;
  :hover {
    cursor: pointer;
    border: none;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.16);
  }
`;
const Img = styled.img``;

const WrapperBig = styled.div`
  width: 562px;
  height: 360px;
  box-sizing: border-box;
  position: relative;
  :hover {
    cursor: pointer;
    border: none;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.16);
  }
`;

const Date = styled.div`
  font-family: Rubik;
  font-weight: 300;
  font-size: 12px;
  line-height: 18px;
  color: rgba(0, 0, 0, 0.5);
`;

const Title = styled.div`
  font-family: Lato;
  font-weight: bold;
  font-size: 16px;
  line-height: 19px;

  color: #000000;
`;
const TitleBig = styled.div`
  position: absolute;
  bottom: 10px;
  z-index: 100;
  left: 10px;
  font-family: Roboto;
  font-weight: bold;
  font-size: 20px;
  line-height: 23px;
  color: #ffffff;
`;
const Text = styled.div`
  font-family: Rubik;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  color: #000000;
`;
