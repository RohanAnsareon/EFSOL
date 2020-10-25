import React from 'react';
import './App.css';
import { Content } from './components/content/content';
import Navbar from './components/navbar/navbar';

const App: React.FunctionComponent<{ title: string }> = ({ title }) => {
  return (
    <div>
      <Navbar title={title} />
      <Content />
    </div>
  );
}

export default App;
