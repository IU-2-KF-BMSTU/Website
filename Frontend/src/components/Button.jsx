import React from 'react';
import styled from 'styled-components';
import Button from '@material-ui/core/Button';

export const ButtonCustom = ({ width, children }) => {
  return <ButtonWrapper width={width}>{children}</ButtonWrapper>;
};

const ButtonWrapper = styled(Button)`
  width: ${({ width }) => width || '100%'};
  box-sizing: border-box;
  border-radius: 24px;
  border: 2px solid #1935d8;
  background-color: #fff;
  color: #1935d8;
  min-height: 48px;
  :hover {
    background-color: #fff;
    box-shadow: 0px 6px 15px rgba(0, 0, 0, 0.05), 0px 4px 8px rgba(0, 0, 0, 0.1);
  }
`;
