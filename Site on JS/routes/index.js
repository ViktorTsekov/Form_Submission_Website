var express = require('express');
const cookie = require('cookie-session')
var router = express.Router();

/* GET home page. */
router.get('/', async (req, res, next) =>{

 
 console.log(req.session.list)
 await req.session.list.forEach(x => {
   x.isadmin = req.isadmin
 });
 console.log(req.isadmin)
  await res.render('index',{
    isadmin: req.isadmin,
    list: req.session.list,
    userName: req.session.name,
    islogged : req.islogged
});
 
});

 router.post('/',async (req,res,next)=>{

  
});

module.exports = router;
