import React from 'react'
import Card from '../Cards/Card'

interface Props{  

}

const CardList = (props: Props) => {
  return (
    <div>
        <Card 
        image='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRxLkf2I8NT1UzTbEuXIYxHakacuAjZMuR5kg&s' 
        model='i30N' 
        make='Hyunadi' 
        price={500000}
         year={2024}
         state='used'
         color='black'
         extras='none'
         />
          <Card 
        image='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnOTxMnYHQntvLmu8L5galSstsSe8rYeLcHA&s' 
        model='i30N' 
        make='Hyunadi' 
        price={625000}
         year={2023}
         state='used'
         color='black'
         extras='panaromic sun roof'
         />
    </div>
  )
}

export default CardList