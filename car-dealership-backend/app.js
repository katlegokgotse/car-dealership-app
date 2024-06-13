const mysql = require('mysql')
const connectToDatabase = mysql.createConnection({
    host: 'localhost',
    user: 'user',
    password: 'password',
    database: 'car_dealershipDB'
})

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