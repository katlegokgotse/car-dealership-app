import mysql,{ createPool } from 'mysql2';

const connectToDatabase = mysql.createPool({
    host: process.env.HOST,
    user: process.env.USER,
    password: process.env.PASSWORD,
    database: process.env.DATABASE
}).promise();

function connection(){
    connectToDatabase.connect((error) => {
    if(error){
        console.log("Error connecting to the database");
        return;
    }else
    {
        console.log('Connection Established')
    }
})
}
connection()
connectToDatabase.end();