import { css } from 'styled-components';
import themeSC from '../sources/themeSC';

const { colors, fontSizes, sizes } = themeSC;

const colorsCss = Object.keys(colors)
  .map(color => {
    return `--${color}: ${colors[color]};`;
  })
  .join('');

const cssVariable = css`
  body {
    /* цвета */
    ${colorsCss}

    /* размер текста */
    --megaText: ${fontSizes.megaText};
    --bigTitleText: ${fontSizes.bigTitleText}; /* 24px */
    --smallSubTitleText: ${fontSizes.smallSubTitleText}; /* 16px */
    --mainText: ${fontSizes.mainText}; /* 14px */
    --smallText: ${fontSizes.smallText};
    --veryTinyText: ${fontSizes.veryTinyText}; /* 10px */
    --subTitleText: ${fontSizes.subTitleText}; /* 18px */
    --titleText: ${fontSizes.titleText}; 
    --tinyText: ${fontSizes.tinyText}; /* 12 px */
    
    /* размер контейнера */
    --w-container: ${sizes.container.w};
  }
`;

export default cssVariable;
