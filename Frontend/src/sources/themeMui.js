import { createMuiTheme } from '@material-ui/core/styles';
// import { themeSC } from 'sources/themeSC';
import blue from '@material-ui/core/colors/blue';
import red from '@material-ui/core/colors/red';
import grey from '@material-ui/core/colors/grey';

export default createMuiTheme({
  typography: {
    useNextVariants: true,
    fontFamily: ['Lato', 'Roboto'].join(','),
  },
  palette: {
    primary: {
      light: blue[400],
      main: blue[700],
      dark: blue[700],
    },
    secondary: {
      light: blue[500],
      main: blue[500],
      dark: blue[700],
    },
    error: {
      light: red[500],
      main: red[500],
      dark: red[500],
    },
    common: {
      light: blue[500],
      main: blue[700],
      dark: blue[700],
    },
    disabled: {
      light: grey[400],
      main: grey[700],
      dark: grey[700],
    },
  },
  overrides: {
    MuiButton: {
      label: {
        textTransform: 'none',
      },
      root: {
        '&:hover': {
          backgroundColor: 'var(--prDark)',
        },
      },
      contained: {
        '&:hover': {
          boxShadow: 'none',
        },
      },
    },
    MuiTab: {
      root: {
        padding: 0,
        '&$selected': {
          color: 'var(--pr)',
          opacity: 1,
        },
      },
    },
    MuiMenuItem: {
      root: {
        boxSizing: 'content-box',
        minHeight: 'auto',
      },
    },
    MuiListItemText: {
      root: {
        marginTop: 0,
        marginBottom: 0,
      },
    },
    MuiTypography: {
      root: {
        lineHeight: '19px',
      },
      body1: {
        fontSize: '14px',
      },
      body2: {
        lineHeight: 1,
        fontSize: '12px',
      },
      paragraph: {
        marginBottom: 8,
      },
    },
    MuiListItemIcon: {
      root: {
        minWidth: '28px',
      },
    },
    MuiTableCell: {
      head: {
        lineHeight: '1.15',
      },
    },
    MuiFormLabel: {
      root: {
        color: 'var(--lightText)',
        fontSize: '14px',
        fontWeight: 300,
        '&$focused': {
          color: 'var(--pr)',
        },
        '&$error': {
          color: 'var(--lightText)',
        },
        '&$filled': {
          '&:not($focused):not($disabled)': {
            '&+ div > input': {
              color: 'var(--prText)',
            },
            '&+ div': {
              '&.MuiInput-underline:not(:hover):before': {
                borderBottom: '1px solid var(--lightText)',
              },
            },
          },
        },
      },
    },
    MuiInputBase: {
      input: {
        padding: '5px 0 5.5px',
        fontSize: '14px',
        color: 'var(--activeText)',
        '&$disabled': {
          color: 'var(--lightText)',
        },
        
      },
    },
    MuiInput: {
      underline: {
        '&:before': {
          borderBottom: '0.5px solid var(--lightText)',
          opacity: '.8',
        },
        '&:after': {
          content: 'none',
        },
        '&:hover:not($disabled):not($focused):before': {
          borderBottom: '1px solid var(--prText)',
        },
        '&$focused:before': {
          borderBottom: '1px solid var(--pr) !important',
        },
        '&$error:before': {
          borderBottom: '1px solid var(--error) !important',
        },
        '&$disabled:before': {
          borderBottomStyle: 'solid',
        },
      },
    },
    MuiFormHelperText: {
      root: {
        position: 'absolute',
        fontSize: '10px',
        top: '44px', // height input
        left: 0,
        zIndex: 100,
        fontWeight: 300,
        lineHeight: '14px',
        marginTop: '5.5px',
        color: 'var(--lightText)',
      },
    },
    Mui: {
      root: {
        '&$error': {
          color: 'var(--error)',
          '&$underline': {
            borderBottom: '1px solid var(--error)',
          },
        },
      },
    },
    MuiTableSortLabel: {
      active: {
        color: 'var(--pr) !important',
      },
    },
  },
});
