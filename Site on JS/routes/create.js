
var express = require('express');
var router = express.Router();
var db = require('../dataBase/db');
const Form = require('../models/form');
var User = require('../models/user')



router.get('/', function(req, res, next) {

    res.render('create',{
      isadmin : req.isadmin,
      userName : req.session.name,
      islogged : req.islogged
  })
    
  });
  
  router.post('/', async function(req, res, next) {
  
    const name = req.body.uname
    const pass = `${req.body.password}`
   //const Formtoadd = new Form({first:'yo', second:'there'})
   // Formtoadd.save()
    const usertoadd = new User({name : name, password: pass  })
    await usertoadd.save();

    await res.redirect('/')
  });
  
  
  module.exports = router;