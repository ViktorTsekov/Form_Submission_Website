const express = require('express')
const router = express.Router()
const Form = require('../models/form')

router.post('/accept/:id', async (req,res)=>{
    await console.log(req.params.id)

await Form.findByIdAndUpdate(req.params.id,{status: 'Accepted'});

await res.redirect('/')

})

router.post('/decline/:id', async (req,res)=>{
    await console.log(req.params.id)
    await Form.findByIdAndUpdate(req.params.id,{status: 'Declined'});
    await res.redirect('/')

})

module.exports = router