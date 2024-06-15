const express = require("express");
const router = express.Router();

router.post('/post', async function(req, res, next){
    try {
        res.json(await creatingPost(req.query))
    }catch({error}){
        next(error)
    }
});