import React from "react";
import styled from "styled-components";
import Button from "@material-ui/core/Button";

const NewsBlock = () => {
  return (
    <Container>
      <Header>
        <Title>Новости</Title>
        <Button>Смотреть все...</Button>
      </Header>
        <SubContainer />
    </Container>
  );
};
export default NewsBlock;

const Container = styled.div`
  display: flex;
  flex-direction: column;
  width: 100%;
  height: 100%;
  box-sizing: border-box;
`;

const Header = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  height: 70px;
  box-sizing: border-box;
  padding: 0 106px;
  border-bottom: 1px solid rgba(0, 0, 0, 0.3);
`;

const SubContainer = styled.div`
  display: flex;
  flex-direction: column;
  width: 100%;
  height: calc(100vh - 70px);
  box-sizing: border-box;
  background-color: rgba(174, 174, 174, 0.1);
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
