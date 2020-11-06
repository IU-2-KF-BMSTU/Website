import React, { useState } from 'react';
import RoutePath from './RoutePath';
import Header from './components/Header';
import Footer from './components/Footer';
import Menu from './components/Menu';

function App() {
  const [openMenu, setOpenMenu] = useState(false);
  return (
    <>
      <Header openMenu={()=>setOpenMenu(true)} />
      <RoutePath />
      <Footer />
      <Menu isOpen={openMenu} onClose={()=>setOpenMenu(false)} />
    </>
  );
}

export default App;
