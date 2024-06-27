import React from 'react';
import './Card.css';
interface Props{
    image: string;
    model: string;
    make: string;
    cost: string;
}

const Card = (props: Props) => {
  return (
    <div>
        <div>
            <img src=''/>
            <div>
                <h2>Car.Model</h2>
                <p>Car.Description</p>
                <p>Car.State</p>
                <button>R890K</button>
            </div>
        </div>
    </div>
  )
}

export default Card