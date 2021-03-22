var express = require('express');
var router = express.Router();
var db = require('../dataBase/db');
var User = require('../models/user')
var Form = require('../models/form')

/* GET home page. */
router.get('/login', async function(req, res, next) {
  
  await res.render('login',{
    isadmin : req.isadmin,
    userName : req.session.name,
    islogged : req.islogged
})
});

router.post('/login', async function(req, res, next) {
  

  await Form.find((err,ans)=>{
    req.session.list =ans
   })
  await User.findOne({name: req.body.uname, password: req.body.password}).populate('forms').then(an=>
  {
    try{
    if(an.name == req.body.uname){
      req.session.id = an._id;
      req.session.name =req.body.uname;
      req.session.password = req.body.password

      if(an.name != 'admin'){
      
    req.session.list = an.forms
  }
      res.redirect('/');
    }
   
  }
    catch{
     console.log()
      res.redirect('/login')
    }
  })
  
  // if(db.ContainsUser(req.body.uname,req.body.password))
  // {
  //   req.session.name =req.body.uname;
  //   req.session.password = req.body.password
  //   res.redirect('/');
  //   return
  // }
  // //db.addUser(req.body.uname,req.body.password)
  // res.redirect('/login')

  
});



module.exports = router;