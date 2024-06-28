import React from 'react';
import './Card.css';
interface Props{
    image: string;
    model: string;
    make: string;
    price: number;
    year: number;
    state: string;
    color: string
    extras: string;
}

const Card = (props: Props) => {
  return (
    <div className='Card'>
        <div className='card-contents'>
            <div className='card-image'>
                <img src={props.image} />
            </div>
            <div className='card-text'>
                <p className='card-money'>R {props.price}</p>
                <div>
                <p>{props.state}</p>
                <p className='card-information'>{props.year} {props.make} {props.model}</p>
                <p>{props.extras}</p>
                </div>
            </div>
            <button>Find out more</button>
        </div>
    </div>
  )
}

export default Card