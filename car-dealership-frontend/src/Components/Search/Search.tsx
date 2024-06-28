import React, { ChangeEvent, useState, SyntheticEvent } from 'react'

type Props = {}

const Search = (props: Props) : JSX.Element => {
    const [search, setSearch] = useState<string>("");

    const handleChange = (e: ChangeEvent<HTMLInputElement>)=> {
        setSearch(e.target.value);
        console.log(e);
    }

    const submitSearch = (e: SyntheticEvent) => {
        console.log(e);
    }
  return (
    <div>
        <input 
        type="text" 
        value={search} 
        name="search" 
        id="search"
        placeholder='Search for car'
        onChange={(e) => handleChange(e)} />
        <button className='btnSearch' onClick={(e) => submitSearch(e)}/>
    </div>
  )
}

export default Search