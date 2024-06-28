import React, { ChangeEvent, useState, SyntheticEvent } from 'react'
import './Search.css'
interface Props {
    handleSearchChange: (e: ChangeEvent<HTMLInputElement>) => void;
    onSubmitSearch: (e: SyntheticEvent) => void;
    search: string | undefined;
}

const Search = ({onSubmitSearch, search, handleSearchChange}: Props) : JSX.Element => {
 
  return (
    <div>
        <form action=""
            className='searchForm'
            onChange={onSubmitSearch}>
        <input 
        type="text"
         value={search} 
         className='btnSearch' 
         onChange={handleSearchChange} 
         placeholder='Enter vehicle name'
         name='btnSearch'
         id='input-search'/>
        </form>
        
    </div>
  )
}

export default Search