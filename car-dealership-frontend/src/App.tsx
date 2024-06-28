import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import CardList from './Components/CardList/CardList';
import Search from './Components/Search/Search';
export default function App(){
  return (
    <>
      <div>
        <Search/>
        <CardList/>
      </div>
    </>
  );
}

