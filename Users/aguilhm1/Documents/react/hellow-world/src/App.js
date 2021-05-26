import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Greet from './componets/greet'
import Xplane from './xplane';

function clickMe(){
  console.log("you clicked me!");
}

function App() {
  return (
    <div className="App">
      <Greet></Greet>
      <Xplane></Xplane>
      <Xplane></Xplane>
      
    </div>
  );
}

export default App;
