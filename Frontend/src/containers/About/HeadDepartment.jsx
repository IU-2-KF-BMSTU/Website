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
      console.log('resp', response);
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
      <Title>{!loading && data?.degree}</Title>
      zAv kaf
    </Container>
  );
};
export default HeadDepartment;

const Container = styled.div`
  display: flex;
  background-color: #fff;
  height: 200px;
`;

const Title = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: 900;
  font-size: 64px;
  color: #000000;
`;
