import { ChangeEvent, SyntheticEvent, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import CardList from './Components/CardList/CardList';
import Search from './Components/Search/Search';
export default function App(){
  const [search, setSearch] = useState<string>("");

  const handleChange = (e: ChangeEvent<HTMLInputElement>)=> {
      setSearch(e.target.value);
      console.log(e);
  }

  const submitSearch = (e: SyntheticEvent) => {
      console.log(e);
  }
  return (
    <>
      <div>
        <Search onSubmitSearch={submitSearch} handleSearchChange={handleChange} search={search}/>
        <CardList/>
      </div>
    </>
  );
}

