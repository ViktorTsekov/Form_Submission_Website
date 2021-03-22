var express = require('express');
var router = express.Router();

/* GET users listing. */
router.get('/', function(req, res, next) {
  res.render('uverenie',{
    isadmin:req.isadmin,
    userName: req.session.name,
    islogged : req.islogged
});
});

router.post('/',(req,res,next)=>{
  
})

module.exports = router;