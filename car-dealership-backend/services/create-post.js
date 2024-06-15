const express = require("express")
const databse = require('./database/car-dealership.sql')

async function createPost(){
    const rows = await databse.query(
        `SELECT advert_status, advert_created_at, car_id, admin_id, admin_username
        from ADVERT_STATE`
    )
}