import React from 'react';
import styled from 'styled-components';
import SwipeableViews from 'react-swipeable-views';
import { NewsCart } from '../../components/NewsCart';
import { useHistory } from 'react-router-dom';

const tutorialSteps = [
  {
    title: 'Среди прохожих затерялся хороший мальчик',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1537944434965-cf4679d1a598?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Ученые открыли новый вид растений',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1538032746644-0212e812a9e7?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Среди прохожих затерялся хороший мальчик',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1537996194471-e657df975ab4?auto=format&fit=crop&w=400&h=250&q=80',
  },
  {
    title: 'Ученые открыли новый вид растений',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Среди прохожих затерялся хороший мальчик',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1512341689857-198e7e2f3ca8?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Среди прохожих затерялся хороший мальчик',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1537944434965-cf4679d1a598?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Ученые открыли новый вид растений',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1538032746644-0212e812a9e7?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Среди прохожих затерялся хороший мальчик',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1537996194471-e657df975ab4?auto=format&fit=crop&w=400&h=250&q=80',
  },
  {
    title: 'Ученые открыли новый вид растений',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1518732714860-b62714ce0c59?auto=format&fit=crop&w=400&h=250&q=60',
  },
  {
    title: 'Среди прохожих затерялся хороший мальчик',
    date: '18 августа 2018',
    text: 'Описание. Ортогональный определитель отнюдь не очевиден. Дифференциальное уравнение, общеизвестно...',
    imgPath: 'https://images.unsplash.com/photo-1512341689857-198e7e2f3ca8?auto=format&fit=crop&w=400&h=250&q=60',
  },
];

const NewsBlock = () => {
  const [activeStep, setActiveStep] = React.useState(0);
  const history = useHistory();

  const handleNext = () => {
    setActiveStep(prevActiveStep => prevActiveStep + 1);
  };

  const handleBack = () => {
    setActiveStep(prevActiveStep => prevActiveStep - 1);
  };

  const handleStepChange = step => {
    setActiveStep(step);
  };

  return (
    <Container>
      <Header>
        <Title>Новости</Title>
        <Link onClick={() => history.push('/news')}>Смотреть все...</Link>
      </Header>
      <SubContainer>
        <KeyContainer onClick={handleBack}>
          <span>{'<'}</span>
        </KeyContainer>
        <SwipeableViews index={activeStep} onChangeIndex={handleStepChange} enableMouseEvents>
          {tutorialSteps.map((step, index) => (
            <SwipeContainer>
              <NewsCart
                mode="big"
                data={{ src: step.imgPath, title: step.title, date: step.date, text: step.text }}
                alt={step.title}
              />
              <NewsCart
                data={{ src: step.imgPath, title: step.title, date: step.date, text: step.text }}
                alt={step.title}
              />
              <NewsCart
                data={{ src: step.imgPath, title: step.title, date: step.date, text: step.text }}
                alt={step.title}
              />
              <NewsCart
                data={{ src: step.imgPath, title: step.title, date: step.date, text: step.text }}
                alt={step.title}
              />
            </SwipeContainer>
          ))}
        </SwipeableViews>
        <KeyContainer onClick={handleNext}>
          <span>{'>'}</span>
        </KeyContainer>
      </SubContainer>
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

const SwipeContainer = styled.div`
  display: flex;
  margin: 0 auto;
  justify-content: space-between;
  box-sizing: border-box;
  width: calc(100% - 212px);
  height: 560px;
`;

const Header = styled.div`
  display: flex;
  justify-content: space-between;
  width: calc(100% - 212px);
  margin: 0 auto 20px auto;
  height: 70px;
  align-items: flex-end;
  box-sizing: border-box;
  border-bottom: 1px solid rgba(0, 0, 0, 0.3);
`;

const SubContainer = styled.div`
  display: flex;
  width: 100%;
  height: 100%;
`;
const KeyContainer = styled.div`
  margin-top: 200px;
  display: flex;
  width: 106px;
  height: 100%;
  padding: 0 28px;
  justify-content: center;
  align-items: center;
  cursor: pointer;
  box-sizing: border-box;
  span {
    width: 49px;
    height: 49px;
    border-radius: 25px;
    display: flex;
    justify-content: center;
    align-items: center;
    color: rgba(174, 174, 174, 0.6);
    box-sizing: border-box;
    border: 2px solid rgba(174, 174, 174, 0.6);
  }
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

const Link = styled.span`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  color: #1935d8;
  cursor: pointer;
`;
