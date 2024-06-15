import mysql,{ createPool } from 'mysql2';
import dotenv from 'dotenv'

//configure the environment variables
dotenv.config()
const connectToDatabase = mysql.createPool({
    host: process.env.MYSQL_HOST,
    user: process.env.MYSQL_USER,
    password: process.env.MYSQL_PASSWORD,
    database: process.env.MYSQL_DATABASE
}).promise();

async function getCars(id){
    const [rows] = await connectToDatabase.query(`
        SELECT * 
        from CARS
        WHERE car_id = ?
        `, [id]);
    return rows[0];
}

const cars = await getCars()
console.log(cars)

/*function connection(){
    connectToDatabase.connect((error) => {
    if(error){
        console.log("Error connecting to the database");
        return;
    }else
    {
        console.log('Connection Established')
    }
})
}*/
//connection()
connectToDatabase.end();