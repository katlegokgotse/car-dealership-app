import express from 'express';
import { connection } from './database';
import mysql2 from mysql2

const app = express()
const port = 3000;
app.get('/', (req, res) => {
    res.send("Hello, World!")
})

app.get("/cars_ad", (req, res)=>{
    const get_cars = "SELECT * FROM dealershipDB"
    connection.quer
})

app.listen(port, function() {
    console.log(`Listening on port ${port}`);
    connection()
})